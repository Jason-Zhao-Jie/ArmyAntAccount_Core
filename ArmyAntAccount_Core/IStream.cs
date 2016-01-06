using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyAntAccount
{
	public interface IStream
	{
		bool Open(string filepath);
		bool Close();
		string Read();
		bool Write(string text);
		bool Create(string path);
		string GetPath(string filename = "");
		bool IsOpened
		{
			get;
		}
	}
}
