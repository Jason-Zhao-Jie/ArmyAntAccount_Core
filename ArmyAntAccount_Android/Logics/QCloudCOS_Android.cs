using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ArmyAntAccount
{
	class QCloudOS_Android : AQCloudOS
	{
		private QCloud.CosApi.Api.CosCloud cos = null;
		private string[] folders = null;
		private string[] files = null;
		public QCloudOS_Android()
		{
		}

		public override bool Create()
		{
			if(!base.Create())
				return false;
			cos = new QCloud.CosApi.Api.CosCloud(app_id, secret_id, secret_key);
			folders = GetFolderList().ToArray();
			files = GetFileList().ToArray();

			return true;
		}

		public override bool CreateDirectory(string parentdir, string name)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			var ret = cos.CreateFolder(bucket_name, parentdir + name);
			var obj = ParseJson(ret);
			return Convert.ToInt32(obj.GetInt("code")) == 0;
		}

		public override bool DeleteDirectory(string dir)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			var ret = cos.DeleteFolder(bucket_name, dir);
			var obj = ParseJson(ret);
			var res = (Convert.ToInt32(obj.GetInt("code")) == 0);
			if(res)
			{
				var tmp = folders.ToList();
				tmp.Remove(dir);
				folders = tmp.ToArray();
			}
			return res;
		}

		public override bool DeleteFile(string path)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			var ret = cos.DeleteFile(bucket_name, path);
			var obj = ParseJson(ret);
			var res = (Convert.ToInt32(obj.GetInt("code")) == 0);
			if(res)
			{
				var tmp = files.ToList();
				tmp.Remove(path);
				files = tmp.ToArray();
			}
			return res;
		}

		public override bool Download(string netpath, string localpath)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			return cos.DownloadFile(bucket_name, netpath, localpath);
		}

		public override bool IsDirectoryExist(string dir)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			return 0 <= Array.IndexOf(folders, dir);
		}

		public override bool IsFileExist(string netpath)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			return 0 <= Array.IndexOf(files, netpath);
		}

		public override bool Upload(string localpath, string netpath)
		{
			if(cos == null)
				throw new MemberAccessException("Please create before use cloud");
			var ret = cos.UploadFile(bucket_name, netpath, localpath);
			var obj = ParseJson(ret);
			var res = (Convert.ToInt32(obj.GetInt("code")) == 0);
			if(res)
			{
				var tmp = files.ToList();
				tmp.Add(netpath);
				files = tmp.ToArray();
			}
			return res;
		}

		private static Org.Json.JSONObject ParseJson(string json)
		{
			return new Org.Json.JSONObject(json);
		}

		protected List<string> GetFolderList(int page = 0)
		{
			//获取根目录列表
			var files = cos.GetFolderList(bucket_name, "/.", 100, "", page, QCloud.CosApi.Api.FolderPattern.Folder);
			//解析Json字符串
			var obj = ParseJson(files);
			//记录列表
			if(obj.GetInt("code") != 0)
				throw new Java.Net.URISyntaxException("Get the folder list failed !", obj.GetString("message"));
			var ret = new List<string>();
			var data = obj.GetJSONObject("data");
			var infos = data.GetJSONArray("infos");
			for(int i = 0; i < infos.Length(); i++)
			{
				ret.Add(infos.GetJSONObject(i).GetString("name"));
			}
			if(data.GetBoolean("has_more"))
				ret.AddRange(GetFolderList(page + 1));
			return ret;
		}

		protected List<string> GetFileList(int page = 0)
		{
			//获取根目录列表
			var files = cos.GetFolderList(bucket_name, "/.", 100, "", page, QCloud.CosApi.Api.FolderPattern.File);
			//解析Json字符串
			var obj = ParseJson(files);
			//记录列表
			if(obj.GetInt("code") != 0)
				throw new Java.Net.URISyntaxException("Get the file list failed !", obj.GetString("message"));
			var ret = new List<string>();
			var data = obj.GetJSONObject("data");
			var infos = data.GetJSONArray("infos");
			for(int i = 0; i < infos.Length(); i++)
			{
				ret.Add(infos.GetJSONObject(i).GetString("name"));
			}
			if(data.GetBoolean("has_more"))
				ret.AddRange(GetFileList(page + 1));
			return ret;
		}
	}
}