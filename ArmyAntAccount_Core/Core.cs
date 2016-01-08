using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	public static class Core
	{
		private static IStream file = null;
		private static AQCloudOS cloud = null;
		private static ConfigSync config = null;
		private static UserChecker users = null;
		private static AccountData data = null;
		private static bool isInited = false;

		public static IStream File
		{
			get
			{
				return file;
			}
		}
		public static AQCloudOS Cloud
		{
			get
			{
				return cloud;
			}
		}
		public static ConfigSync Config
		{
			get
			{
				return config;
			}
		}
		public static UserChecker Users
		{
			get
			{
				return users;
			}
		}
		public static AccountData Data
		{
			get
			{
				return data;
			}
		}
		public static bool Inited
		{
			get
			{
				return isInited;
			}
		}

		public static void Init(IStream stream, AQCloudOS cloud)
		{
			file = stream;
			Core.cloud = cloud;
			config = new ConfigSync();
			users = new UserChecker();
			data = new AccountData();
			isInited = true;
		}

		public enum IOType
		{
			All,
			Users,
			Data
		}

		public static bool Save(IOType type = IOType.All)
		{
			switch(type)
			{
				case IOType.All:
					return users.Save() && data.Save();
				case IOType.Users:
					return users.Save();
				case IOType.Data:
					return data.Save();
			}
			return false;
		}

		public static bool Download(IOType type = IOType.All)
		{
			var ret = config.SyncFromCloud(type);
			switch(type)
			{
				case IOType.All:
					users = new UserChecker();
					data = new AccountData();
					break;
				case IOType.Users:
					users = new UserChecker();
					break;
				case IOType.Data:
					data = new AccountData();
					break;
			}
			return ret;
		}

		public static bool Upload(IOType type = IOType.All)
		{
			return config.SyncToCloud(type);
		}

		public static bool Sync(IOType type = IOType.All)
		{
			return config.Sync(type);
		}
	}
}
