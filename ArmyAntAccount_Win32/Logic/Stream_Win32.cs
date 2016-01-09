using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	class Stream_Win32 : IStream
	{
		System.IO.FileStream file = null;
		public bool Close()
		{
			if(file != null)
				file.Close();
			file = null;
			return true;
		}

		public bool Open(string filepath)
		{
			if(file != null)
				return false;
			if(filepath == null)
				return false;
			try
			{
				file = System.IO.File.Open(filepath, System.IO.FileMode.Open);
			}
			catch(System.IO.FileNotFoundException)
			{
				file = null;
				return false;
			}
			return true;
		}

		public string Read()
		{
			if(file == null || !file.CanRead)
				return null;
			if(file.Length == 0)
				return "";
			byte[] buf = new byte[file.Length];
			file.Read(buf, 0, (int)file.Length);
			return Encoding.UTF8.GetString(buf);
		}

		public bool Write(string text)
		{
			if(file == null || !file.CanWrite)
				return false;
			file.SetLength(0);
			var bts = Encoding.UTF8.GetBytes(text);
			file.Write(bts, 0, bts.Length);
			return true;
		}

		public bool Create(string path)
		{
			if(file != null)
				return false;
			file = System.IO.File.Create(path);
			return true;
		}

		public string GetPath(string filename = "")
		{
			return filename;
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
