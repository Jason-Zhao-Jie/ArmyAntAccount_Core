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
		public UserChecker(IStream file, AQCloudOS cloud)
		{
			ConfigSync.file = file;
			ConfigSync.cloud = cloud;
			bool isopened = file.IsOpened;
			if(!isopened && !file.Open(ConfigSync.Instance.FileUserAccount))
				throw new System.IO.FileNotFoundException("The stream is null");
			string xmls = file.Read();
			if(!isopened)
				file.Close();
			if(xmls == null)
				throw new System.ArgumentException("The stream cannot read");
			if(xmls == "")
				throw new System.IO.EndOfStreamException("The stream was empty");
			xmls = xmls.Replace(""+(char)65279, "");
			System.IO.StringReader reader = new System.IO.StringReader(xmls);
			var xml = System.Xml.XmlReader.Create(reader);
			list.Clear();
			while(xml.Read() && xml.MoveToContent() != System.Xml.XmlNodeType.None)
			{
				list.Add(new UserData(xml.GetAttribute("uid"), xml.GetAttribute("pwd"), System.Convert.ToByte(xml.GetAttribute("access")), xml.GetAttribute("name")));
			}
		}
		public bool Save()
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
			bool isopened = ConfigSync.file.IsOpened;
			if(!isopened && !ConfigSync.file.Open(ConfigSync.Instance.FileUserAccount))
				throw new System.IO.FileNotFoundException("The stream is null");
			bool ret = ConfigSync.file.Write(xml.ToString());
			if(!isopened)
				ConfigSync.file.Close();
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
    }
}
