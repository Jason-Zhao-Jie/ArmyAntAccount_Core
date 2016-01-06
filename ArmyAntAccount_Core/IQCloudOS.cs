using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	public interface IQCloudOS
	{
		bool Create();
		bool Create(int app_id, string secret_id, string secret_key, string bucket_name);
		bool Download(string netpath, string localpath);
		bool Upload(string localpath, string netpath);
		bool CreateDirectory(string parentdir, string name);
		bool DeleteDirectory(string dir);
		bool DeleteFile(string path);
		bool IsDirectoryExist(string dir);
		bool IsFileExist(string netpath);
	}

	public abstract class AQCloudOS : IQCloudOS
	{
		public virtual bool Create()
		{
			return app_id != 0 && secret_id != "" && secret_key != "" && bucket_name != "";
		}
		public bool Create(int app_id, string secret_id, string secret_key, string bucket_name)
		{
			this.app_id = app_id;
			this.secret_id = secret_id;
			this.secret_key = secret_key;
			this.bucket_name = bucket_name;
			return Create();
		}
		public abstract bool CreateDirectory(string parentdir, string name);
		public abstract bool DeleteDirectory(string dir);
		public abstract bool DeleteFile(string path);
		public abstract bool Download(string netpath, string localpath);
		public abstract bool Upload(string localpath, string netpath);
		public abstract bool IsDirectoryExist(string dir);
		public abstract bool IsFileExist(string netpath);

		protected internal int app_id;
		protected internal string secret_id = "";
		protected internal string secret_key = "";
		protected internal string bucket_name = "";
	}
}
