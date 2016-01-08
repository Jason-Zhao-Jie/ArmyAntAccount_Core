using System.Collections.Generic;

namespace ArmyAntAccount
{
	public enum Access : byte
	{
		None,
		Guest,
		User,
		Manager,
		Administor,
		Owner,
	}
	public class UserData
	{
		public string uid;
		public string pwdMd5;
		public Access access;
		public string name;

		public UserData(string uid, string pwdMd5, byte access, string name)
		{
			this.uid = uid;
			this.pwdMd5 = pwdMd5;
			this.access = (Access)access;
			this.name = name;
		}
		public bool Equals(string uid)
		{
			return this.uid == uid.ToString();
		}
		public static bool operator ==(UserData data, string uid)
		{
			return data.uid == uid;
		}
		public static bool operator !=(UserData data, string uid)
		{
			return !(data == uid);
		}

	}
	public class UserChecker
	{
		private List<UserData> list = new List<UserData>();
		internal UserChecker()
		{
			bool isopened = Core.File.IsOpened;
			if(!isopened && !Core.File.Open(Core.Config.FileUserAccount))
				throw new System.IO.FileNotFoundException("The stream is null");
			string xmls = Core.File.Read();
			if(!isopened)
				Core.File.Close();
			if(xmls == null)
				throw new System.ArgumentException("The stream cannot read");
			if(xmls == "")
				throw new System.IO.EndOfStreamException("The stream was empty");
			xmls = xmls.Replace("" + (char)65279, "");
			System.IO.StringReader reader = new System.IO.StringReader(xmls);
			var xml = System.Xml.XmlReader.Create(reader);
			list.Clear();
			while(xml.Read() && xml.MoveToContent() != System.Xml.XmlNodeType.None)
			{
				switch(xml.Name)
				{
					case "userdata":
						break;
					case "user":
						list.Add(new UserData(xml.GetAttribute("uid"), xml.GetAttribute("pwd"), System.Convert.ToByte(xml.GetAttribute("access")), xml.GetAttribute("name")));
						break;
					default:
						throw new System.Xml.XmlException("Xml file format error !");
				}
			}
		}
		internal bool Save()
		{
			var xml = new System.Xml.Linq.XDocument();
			xml.AddFirst(new System.Xml.Linq.XElement("userdata"));
			var root = xml.Element("userdata");
			for(var i = list.GetEnumerator(); i.MoveNext();)
			{
				if(i.Current.uid == null)
					continue;
				root.Add(new System.Xml.Linq.XElement("user"));
			}
			var elems = (System.Xml.Linq.XElement)(root.FirstNode);
			for(var i = list.GetEnumerator(); i.MoveNext();)
			{
				if(i.Current.uid == null)
					continue;
				elems.SetAttributeValue("uid", i.Current.uid);
				elems.SetAttributeValue("pwd", i.Current.pwdMd5);
				elems.SetAttributeValue("access", ((byte)(i.Current.access)).ToString());
				elems.SetAttributeValue("name", i.Current.name);
				elems = (System.Xml.Linq.XElement)(elems.NextNode);
			}
			bool isopened = Core.File.IsOpened;
			if(!isopened && !Core.File.Open(Core.Config.FileUserAccount))
				throw new System.IO.FileNotFoundException("The stream is null");
			bool ret = Core.File.Write(ConfigSync.xmlDocumentDef);
			ret = ret && Core.File.Write(xml.ToString());
			if(!isopened)
				Core.File.Close();
			return ret;
		}

		public UserData Check(string uid, string pwdMd5)
		{
			for(int i = 0; i < list.Count; i++)
			{
				if(list[i].uid == uid && list[i].pwdMd5 == pwdMd5)
					return list[i];
			}
			return null;
		}

		public bool SetPwd(string uid, string pwdMd5)
		{
			var ret = list.Find((UserData data) => data == uid);
			if(list != null)
				list.Remove(ret);
			ret.pwdMd5 = pwdMd5;
			list.Add(ret);
			return true;
		}

		public bool RemoveUser(string uid, string pwdMd5)
		{
			var ret = list.Find((UserData data) => data == uid);
			if(list != null)
				list.Remove(ret);
			return true;
		}

		public bool CheckExist(string uid)
		{
			return null == list.Find((UserData data) => data == uid);
		}

		internal UserData[] Data
		{
			get
			{
				return list.ToArray();
			}
		}

		public bool Mix(UserChecker checker)
		{
			for(int i = 0; i < checker.list.Count; i++)
			{
				if(!CheckExist(checker.list[i].uid))
					list.Add(checker.list[i]);
			}
			return true;
		}
	}
}
