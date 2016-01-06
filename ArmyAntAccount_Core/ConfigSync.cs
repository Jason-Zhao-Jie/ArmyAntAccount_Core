using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	class ConfigSync
	{
		private static ConfigSync instance = null;
		internal static AQCloudOS cloud = null;
		internal static IStream file = null;

		public static ConfigSync Instance
		{
			get
			{
				if(cloud == null || file == null)
					throw new MissingMemberException("Cloud or filestream object is null");
				if(instance == null)
					instance = new ConfigSync(file, cloud);
				return instance;
			}
		}
		private ConfigSync(IStream file, AQCloudOS cloud)
		{
			string xml = null;
			if(!file.Open(file_main_config))
			{
				file.Create(file_main_config);
				xml = initMainConfig;
				file.Write(xml);
			}
			else
			{
				xml = file.Read();
			}
			file.Close();

			System.IO.StringReader reader = new System.IO.StringReader(xml);
			var xmlreader = System.Xml.XmlReader.Create(reader);
			while(xmlreader.Read() && xmlreader.MoveToContent() != System.Xml.XmlNodeType.None)
			{
				switch(xmlreader.Name)
				{
					case "qcloud":
						cloud.app_id = Convert.ToInt32(xmlreader.GetAttribute("appId"));
						cloud.secret_id = xmlreader.GetAttribute("secretId");
						cloud.secret_key = xmlreader.GetAttribute("secretKey");
						cloud.bucket_name = xmlreader.GetAttribute("bucket");
						cloud.Create();
						break;
					case "config_files":
						file_user_account = xmlreader.GetAttribute("user_account");
						file_main_data = xmlreader.GetAttribute("main_data");
						break;
				}
			}

			//接下来检查本地文件,没有则建立初始值文件
			if(!file.Open(file_user_account))
			{
				file.Create(file_user_account);
				file.Write(initUserAccount);
			}
			file.Close();
			if(!file.Open(file_main_data))
			{
				file.Create(file_main_data);
				file.Write(initDataAccount);
			}
			file.Close();
			if(!SyncFromCloud())
				throw new Exception("Download failed");
		}

		~ConfigSync()
		{
			if(!SyncToCloud())
				throw new Exception("Upload failed");
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

		public bool SyncFromCloud()
		{
			bool ret = true;
			//先判断服务器上是否有文件服务器上无文件则上传本地副本
			if(cloud.IsFileExist(file_user_account))
				ret = ret && cloud.Download(file_user_account, file.GetPath(file_user_account));
			else
				ret = ret && cloud.Upload(file_user_account, file.GetPath(file_user_account));
			if(cloud.IsFileExist(file_main_data))
				ret = ret && cloud.Download(file_main_data, file.GetPath(file_main_data));
			else
				ret = ret && cloud.Upload(file_main_data, file.GetPath(file_main_data));

			return ret;
		}

		public bool SyncToCloud()
		{
			var ret = cloud.Upload(file_user_account, file.GetPath(file_user_account));
			ret = ret && cloud.Upload(file_main_data, file.GetPath(file_main_data));
			return true;
		}

		private const string initMainConfig = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> <appdata><qcloud appId=\"10016653\" secretId=\"AKIDgasH8laSoVtQS6o8iOXekR7uFllGfn9W\" secretKey=\"kiwoKfFfFTmhXmQV65sI3HFrnlbTrYGZ\" bucket=\"default\" /><config_files user_account=\"account_user.xml\" main_data=\"account_data.xml\" /></appdata>";
		private const string initUserAccount = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> <userdata><user uid=\"zhaojie\" pwd=\"zjljcy\" access=\"5\" name=\"赵杰\"/></userdata>";
		private const string initDataAccount = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> <data></data>";

		private string file_main_config = "ArmyAntAccount.config.xml";
		private string file_user_account = null;
		private string file_main_data = null;
	}
}
