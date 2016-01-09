using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	public class ConfigSync
	{
		internal ConfigSync()
		{
			string xml = null;
			if(!Core.File.Open(file_main_config))
			{
				Core.File.Create(file_main_config);
				xml = initMainConfig;
				Core.File.Write(xml);
			}
			else
			{
				xml = Core.File.Read();
			}
			Core.File.Close();

			System.IO.StringReader reader = new System.IO.StringReader(xml);
			var xmlreader = System.Xml.XmlReader.Create(reader);
			while(xmlreader.Read() && xmlreader.MoveToContent() != System.Xml.XmlNodeType.None)
			{
				switch(xmlreader.Name)
				{
					case "qcloud":
						Core.Cloud.app_id = Convert.ToInt32(xmlreader.GetAttribute("appId"));
						Core.Cloud.secret_id = xmlreader.GetAttribute("secretId");
						Core.Cloud.secret_key = xmlreader.GetAttribute("secretKey");
						Core.Cloud.bucket_name = xmlreader.GetAttribute("bucket");
						Core.Cloud.Create();
						break;
					case "config_files":
						file_user_account = xmlreader.GetAttribute("user_account");
						file_main_data = xmlreader.GetAttribute("main_data");
						break;
				}
			}

			//接下来检查本地文件,没有则建立初始值文件
			if(!Core.File.Open(file_user_account))
			{
				Core.File.Create(file_user_account);
				Core.File.Write(initUserAccount);
			}
			Core.File.Close();
			if(!Core.File.Open(file_main_data))
			{
				Core.File.Create(file_main_data);
				Core.File.Write(initDataAccount);
			}
			Core.File.Close();
		}

		~ConfigSync()
		{
		}

		public string FileUserAccount
		{
			get
			{
				return file_user_account;
			}
		}

		public string FileMainData
		{
			get
			{
				return file_main_data;
			}
		}

		internal bool SyncFromCloud(Core.IOType type = Core.IOType.All)
		{
			bool ret = true;
			//先判断服务器上是否有文件服务器上无文件则上传本地副本
			if(type == Core.IOType.All || type == Core.IOType.Users)
				if(Core.Cloud.IsFileExist(file_user_account))
					ret = ret && Core.Cloud.Download(file_user_account, Core.File.GetPath(file_user_account));
				else
					ret = ret && Core.Cloud.Upload(file_user_account, Core.File.GetPath(file_user_account));
			if(type == Core.IOType.All || type == Core.IOType.Data)
				if(Core.Cloud.IsFileExist(file_main_data))
					ret = ret && Core.Cloud.Download(file_main_data, Core.File.GetPath(file_main_data));
				else
					ret = ret && Core.Cloud.Upload(file_main_data, Core.File.GetPath(file_main_data));

			return ret;
		}

		internal bool SyncToCloud(Core.IOType type = Core.IOType.All)
		{
			bool ret = true;
			if(type == Core.IOType.All || type == Core.IOType.Users)
			{
				if(Core.Cloud.IsFileExist(file_user_account))
					ret = ret && Core.Cloud.DeleteFile(file_user_account);
				ret = Core.Cloud.Upload(file_user_account, Core.File.GetPath(file_user_account));
			}
			if(type == Core.IOType.All || type == Core.IOType.Data)
			{
				if(Core.Cloud.IsFileExist(file_main_data))
					ret = ret && Core.Cloud.DeleteFile(file_main_data);
				ret = ret && Core.Cloud.Upload(file_main_data, Core.File.GetPath(file_main_data));
			}
			return ret;
		}

		internal bool Sync(Core.IOType type = Core.IOType.All)
		{
			bool ret = true;
			if(type == Core.IOType.All || type == Core.IOType.Users)
			{
				if(Core.Cloud.IsFileExist(file_user_account))
				{
					var cmp = new UserChecker();
					if(!Core.Cloud.Download(file_user_account, Core.File.GetPath(file_user_account)))
						return false;
					cmp.Mix(new UserChecker());
					cmp.Save();
				}
			}
			if(type == Core.IOType.All || type == Core.IOType.Data)
			{
				if(Core.Cloud.IsFileExist(file_main_data))
				{
					var cmp = new AccountData();
					if(!Core.Cloud.Download(file_main_data, Core.File.GetPath(file_main_data)))
						return false;
					cmp.Mix(new AccountData());
					cmp.Save();
				}
			}

			return ret && SyncToCloud(type);
		}

		internal const string xmlDocumentDef = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n";
		private const string initMainConfig = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<appdata>\r\n\t<qcloud appId=\"10016653\" secretId=\"AKIDgasH8laSoVtQS6o8iOXekR7uFllGfn9W\" secretKey=\"kiwoKfFfFTmhXmQV65sI3HFrnlbTrYGZ\" bucket=\"default\" />\r\n\t<config_files user_account=\"account_user.xml\" main_data=\"account_data.xml\" />\r\n</appdata>";
		private const string initUserAccount = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<userdata>\r\n\t<user uid=\"zhaojie\" pwd=\"zjljcy\" access=\"5\" name=\"赵杰\"/>\r\n</userdata>";
		private const string initDataAccount = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<data>\r\n</data>";

		private const string file_main_config = "ArmyAntAccount.config.xml";
		private string file_user_account = null;
		private string file_main_data = null;
	}
}
