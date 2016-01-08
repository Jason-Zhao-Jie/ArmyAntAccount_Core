using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QCloud.CosApi.Common;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QCloud.CosApi.Api
{
    enum FolderPattern { File = 0, Folder, Both };
    class CosCloud
    {
        const string COSAPI_CGI_URL = "http://web.file.myqcloud.com/files/v1/";
        private int appId;
        private string secretId;
        private string secretKey;
        private int timeOut;
        private Request httpRequest;
        /// <summary>
        /// CosCloud 构造方法
        /// </summary>
        /// <param name="appId">授权appid</param>
        /// <param name="secretId">授权secret id</param>
        /// <param name="secretKey">授权secret key</param>
        /// <param name="timeOut">网络超时,默认60秒</param>
        public CosCloud(int appId, string secretId, string secretKey, int timeOut = 60)
        {
            this.appId = appId;
            this.secretId = secretId;
            this.secretKey = secretKey;
            this.timeOut = timeOut * 1000;
            this.httpRequest = new Request();
        }

        /// <summary>
        /// 远程路径Encode处理
        /// </summary>
        /// <param name="remotePath"></param>
        /// <returns></returns>
        private string EncodeRemotePath(string remotePath)
        {
            if (remotePath == "/")
            {
                return remotePath;
            }
		    var endWith = remotePath.EndsWith("/");
            String[] part = remotePath.Split('/');
            remotePath = "";
            foreach(var s in part)
            {
        	    if (s != "")
                {
        		    if(remotePath != "")
                    {
        			    remotePath += "/";
        		    }
                    remotePath += HttpUtility.UrlEncode(s);
                }
            }
            remotePath = (remotePath.StartsWith("/") ? "" : "/") + remotePath + (endWith ? "/" : "");
            return remotePath;
        }

        /// <summary>
        /// 标准化远程路径
        /// </summary>
        /// <param name="remotePath">要标准化的远程路径</param>
        /// <returns></returns>
        private string StandardizationRemotePath(string remotePath)
        {
            if (!remotePath.StartsWith("/"))
            {
                remotePath = "/" + remotePath;
            }
            if (!remotePath.EndsWith("/"))
            {
                remotePath += "/";
            }
            return remotePath;
        }

        /// <summary>
        /// 更新文件夹信息
        /// </summary>
        /// <param name="bucketName"> bucket名称</param>
        /// <param name="remotePath">远程文件夹路径</param>
        /// <param name="bizAttribute">更新信息</param>
        /// <returns></returns>
        public string UpdateFolder(string bucketName, string remotePath, string bizAttribute)
        {
            remotePath = StandardizationRemotePath(remotePath);
		    return UpdateFile(bucketName, remotePath, bizAttribute);
	    }

        /// <summary>
        /// 更新文件信息
        /// </summary>
        /// <param name="bucketName"> bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <param name="bizAttribute">更新信息</param>
        /// <returns></returns>
        public string UpdateFile(string bucketName, string remotePath, string bizAttribute)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var data = new Dictionary<string, string>();
            data.Add("op", "update");
            data.Add("biz_attr", bizAttribute);
            var sign = Sign.SignatureOnce(appId, secretId, secretKey, (remotePath.StartsWith("/") ? "" : "/") + remotePath, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            header.Add("Content-Type", "application/json");
            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut);
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件夹路径</param>
        /// <returns></returns>
        public string DeleteFolder(string bucketName, string remotePath)
        {
            remotePath = StandardizationRemotePath(remotePath);
            return DeleteFile(bucketName, remotePath);
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <returns></returns>
        public string DeleteFile(string bucketName, string remotePath)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var data = new Dictionary<string, string>();
            data.Add("op", "delete");
            var sign = Sign.SignatureOnce(appId, secretId, secretKey, (remotePath.StartsWith("/") ? "" : "/") + remotePath, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            header.Add("Content-Type", "application/json");

            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut);
        }

        /// <summary>
        /// 获取文件夹信息
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件夹路径</param>
        /// <returns></returns>
        public string GetFolderStat(string bucketName, string remotePath)
        {
            remotePath = StandardizationRemotePath(remotePath);
            return GetFileStat(bucketName, remotePath);
        }

        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <returns></returns>
        public string GetFileStat(string bucketName, string remotePath)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var data = new Dictionary<string, string>();
            data.Add("op", "stat");
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            return httpRequest.SendRequest(url, data, HttpMethod.Get, header, timeOut);
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件夹路径</param>
        /// <returns></returns>
        public string CreateFolder(string bucketName, string remotePath, string bizAttribute = "")
        {
            remotePath = StandardizationRemotePath(remotePath);
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var data = new Dictionary<string, string>();
            data.Add("op", "create");
            data.Add("biz_attr", bizAttribute);
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            header.Add("Content-Type", "application/json");
            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut);
        }

        /// <summary>
        /// 目录列表,前缀搜索
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件夹路径</param>
        /// <param name="num">拉取的总数</param>
        /// <param name="context">透传字段,用于翻页,前端不需理解,需要往前/往后翻页则透传回来</param>
        /// <param name="order">默认正序(=0), 填1为反序</param>
        /// <param name="pattern">拉取模式:只是文件，只是文件夹，全部</param>
        /// <param name="prefix">读取文件/文件夹前缀</param>
        /// <returns></returns>
        public string GetFolderList(string bucketName, string remotePath, int num, string context, int order, FolderPattern pattern, string prefix = "")
        {
            remotePath = StandardizationRemotePath(remotePath);
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath) + HttpUtility.UrlEncode(prefix);
            var data = new Dictionary<string, string>();
            data.Add("op", "list");
            data.Add("num", num.ToString());
            data.Add("context", context);
            data.Add("order", order.ToString());
            string[] patternArray = { "eListFileOnly", "eListDirOnly", "eListBoth" };
            data.Add("pattern", patternArray[(int)pattern]);
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            return httpRequest.SendRequest(url, data, HttpMethod.Get, header, timeOut);
        }

        /// <summary>
        /// 单个文件上传
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <param name="localPath">本地文件路径</param>
        /// <returns></returns>
        public string UploadFile(string bucketName, string remotePath, string localPath)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var sha1 = SHA1.GetSHA1(localPath);
            var data = new Dictionary<string, string>();
            data.Add("op", "upload");
            data.Add("sha", sha1);
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut, localPath);
        }

		/// <summary>
		/// 单个文件下载
		/// </summary>
		/// <param name="bucketName">bucket名称</param>
		/// <param name="remotePath">远程文件路径</param>
		/// <param name="localPath">本地文件路径</param>
		/// <returns></returns>
		public bool DownloadFile(string bucketName, string remotePath, string localPath)
		{
			var url = "http://" + bucketName + "-"+appId+"."+"file.myqcloud.com/" + EncodeRemotePath(remotePath);
			if(File.Exists(localPath + ".qcloud.t.t.temp"))
				File.Delete(localPath + ".qcloud.t.t.temp");
			var stream = File.Create(localPath + ".qcloud.t.t.temp");
			try
			{
				//打开网络连接
				var myRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
				myRequest.Accept = "*/*";
				myRequest.KeepAlive = true;
				myRequest.UserAgent = "qcloud-dotnet-sdk";
				myRequest.Timeout = timeOut;
				//向服务器请求,获得服务器的回应数据流
				Stream myStream = myRequest.GetResponse().GetResponseStream();
				//定义一个字节数据
				byte[] btContent = new byte[512];
				int intSize = 0;
				intSize = myStream.Read(btContent, 0, 512);
				while(intSize > 0)
				{
					stream.Write(btContent, 0, intSize);
					intSize = myStream.Read(btContent, 0, 512);
				}
				//关闭流
				myStream.Close();
				stream.Close();
			}
			catch(Exception)
			{
				stream.Close();
				if(File.Exists(localPath + ".qcloud.t.t.temp"))
					File.Delete(localPath + ".qcloud.t.t.temp");
				return false;       //返回false下载失败
			}
			if(!File.Exists(localPath))
				File.Create(localPath).Close();
			var tmp = File.Open(localPath, FileMode.Create);
			tmp.SetLength(0);
			tmp.Close();
			File.Replace(localPath + ".qcloud.t.t.temp", localPath, localPath + ".qcloud.t.old.temp");
			File.Delete(localPath + ".qcloud.t.old.temp");
			return true;
		}

		/// <summary>
		/// 分片上传第一步
		/// </summary>
		/// <param name="bucketName">bucket名称</param>
		/// <param name="remotePath">远程文件路径</param>
		/// <param name="localPath">本地文件路径</param>
		/// <param name="sliceSize">切片大小（字节）</param>
		/// <returns></returns>
		public string SliceUploadFileFirstStep(string bucketName, string remotePath, string localPath, int sliceSize)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var sha1 = SHA1.GetSHA1(localPath);
            var fileSize = new FileInfo(localPath).Length;
            var data = new Dictionary<string, string>();
            data.Add("op", "upload_slice");
            data.Add("sha", sha1);
            data.Add("filesize", fileSize.ToString());
            data.Add("slice_size", sliceSize.ToString());
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut);
        }

        /// <summary>
        /// 分片上传后续步骤
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <param name="localPath">本地文件路径</param>
        /// <param name="sessionId">分片上传会话ID</param>
        /// <param name="offset">文件分片偏移量</param>
        /// <param name="sliceSize">切片大小（字节）</param>
        /// <returns></returns>
        public string SliceUploadFileFollowStep(string bucketName, string remotePath, string localPath,
            string sessionId, int offset, int sliceSize)
        {
            var url = COSAPI_CGI_URL + appId + "/" + bucketName + EncodeRemotePath(remotePath);
            var data = new Dictionary<string, string>();
            data.Add("op", "upload_slice");
            data.Add("session", sessionId);
            data.Add("offset", offset.ToString());
            var expired = DateTime.Now.ToUnixTime() / 1000 + 60;
            var sign = Sign.Signature(appId, secretId, secretKey, expired, bucketName);
            var header = new Dictionary<string, string>();
            header.Add("Authorization", sign);
            return httpRequest.SendRequest(url, data, HttpMethod.Post, header, timeOut, localPath, offset, sliceSize);
        }

        /// <summary>
        /// 分片上传
        /// </summary>
        /// <param name="bucketName">bucket名称</param>
        /// <param name="remotePath">远程文件路径</param>
        /// <param name="localPath">本地文件路径</param>
        /// <param name="sliceSize">切片大小（字节）,默认为512K</param>
        /// <returns></returns>
        public string SliceUploadFile(string bucketName, string remotePath, string localPath, int sliceSize = 512 * 1024)
        {
            var result = SliceUploadFileFirstStep(bucketName, remotePath, localPath, sliceSize);
            var obj = (JObject)JsonConvert.DeserializeObject(result);
            var code = (int)obj["code"];
            if(code != 0)
            {
                return result;
            }
            var data = obj["data"];
            if(data["access_url"] != null)
            {
                var accessUrl = data["access_url"];
                Console.WriteLine("命中秒传：" + accessUrl);
                return result;
            }
            else
            {
                var sessionId = data["session"].ToString();
                sliceSize = (int)data["slice_size"]; 
                var offset = (int)data["offset"];
                var retryCount = 0;
                while(true)
                {
                    result = SliceUploadFileFollowStep(bucketName, remotePath, localPath, sessionId, offset, sliceSize);
                    Console.WriteLine(result);
                    obj = (JObject)JsonConvert.DeserializeObject(result);
                    code = (int)obj["code"];
                    if(code != 0)
                    {
                        //当上传失败后会重试3次
                        if(retryCount < 3)
                        {
                            retryCount++;
                            Console.WriteLine("重试....");
                        }
                        else
                        {
                            return result;
                        }
                    }
                    else
                    {
                        data = obj["data"];
                        if(data["offset"] != null)
                        {
                            offset = (int)data["offset"] + sliceSize;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return "";
	    }
    }


}
