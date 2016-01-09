using System;

namespace ArmyAntAccount
{
	class Stream_Android : IStream
	{
		Java.IO.File file = null;
		static string path = "";
		public bool Close()
		{
			file = null;
			return true;
		}

		public bool Open(string filepath)
		{
			if(file != null)
			{
				Android.Util.Log.Warn("ZJ", "File has been opened");
				return false;
			}
			if(filepath == null)
			{
				Android.Util.Log.Warn("ZJ", "File path error, path=" + filepath + ", localpath=" + path);
				return false;
			}
			file = new Java.IO.File(path + filepath);
			if(!file.Exists())
			{
				file = null;
				Android.Util.Log.Warn("ZJ", "The file does not exist, path=" + filepath + ", localpath=" + path);
				return false;
			}
			return true;
		}

		public string Read()
		{
			if(file == null || !file.CanRead())
				return null;
			if(file.Length() == 0)
				return "";
			char[] buf = new char[file.Length()];
			Java.IO.FileReader reader = new Java.IO.FileReader(file);
			reader.Read(buf);
			reader.Close();
			return System.Text.Encoding.UTF8.GetString(System.Text.Encoding.UTF8.GetBytes(buf));
		}

		public bool Write(string text)
		{
			if(file == null || !file.CanWrite())
				return false;
			var bts = text.ToCharArray();
			Java.IO.FileWriter writer = new Java.IO.FileWriter(file);
			writer.Write(bts);
			writer.Close();
			return true;
		}

		public bool Create(string path)
		{
			if(file != null)
				return false;
			file = new Java.IO.File(Stream_Android.path + path);
			if(file.Exists())
				file.Delete();
			file.CreateNewFile();
			return true;
		}

		public string GetPath(string filename = "")
		{
			return path + "/" + filename;
		}

		public static string Path
		{
			get
			{
				return path;
			}
			set
			{
				path = value;
			}
		}
		public bool IsOpened
		{
			get
			{
				return file != null;
			}
		}

	}
}