using System.Collections.Generic;

namespace ArmyAntAccount
{
	public class AccountItem
	{
		public System.DateTime datetime;
		public string type = "";
		public int change = 0;
		public string tag = "";
		public string person = "";
		public string comment = "";
		public string otherRemark = "";
	}
	public class AccountData
	{
		private List<AccountItem> data = new List<AccountItem>();
		public AccountData(IStream file, AQCloudOS cloud)
		{
			ConfigSync.file = file;
			ConfigSync.cloud = cloud;
			bool isopened = file.IsOpened;
			if(!isopened && !file.Open(ConfigSync.Instance.FileMainData))
				throw new System.IO.FileNotFoundException("The stream is null");
			string xmls = file.Read();
			if(!isopened)
				file.Close();
			if(xmls == null)
				throw new System.ArgumentException("The stream cannot read");
			if(xmls == "")
				throw new System.IO.EndOfStreamException("The stream was empty");
			xmls = xmls.Replace("" + (char)65279, "");

			System.IO.StringReader reader = new System.IO.StringReader(xmls);
			var xml = System.Xml.XmlReader.Create(reader);
			data.Clear();
			while(xml.Read() && xml.MoveToContent() != System.Xml.XmlNodeType.None)
			{
				switch(xml.Name)
				{
					case "data":
						break;
					case "record":
						data.Add(new AccountItem
						{
							datetime = System.Convert.ToDateTime(xml.GetAttribute("datetime")),
							type = xml.GetAttribute("type"),
							change = System.Convert.ToInt32(xml.GetAttribute("change")),
							tag = xml.GetAttribute("tag"),
							person = xml.GetAttribute("person"),
							comment = xml.GetAttribute("comment"),
							otherRemark = xml.GetAttribute("otherRemark")
						});
						break;
					default:
						throw new System.Xml.XmlException("Xml file format error !");
				}
			}
		}
		public bool Save()
		{
			var xml = new System.Xml.Linq.XDocument();
			xml.AddFirst(new System.Xml.Linq.XElement("data"));
			var root = xml.Element("data");
			for(var i = data.GetEnumerator(); i.MoveNext();)
			{
				if(i.Current.person == null || i.Current.person == "")
					continue;
				root.Add(new System.Xml.Linq.XElement("record"));
			}
			var elems = (System.Xml.Linq.XElement)(root.FirstNode);
			for(var i = data.GetEnumerator(); i.MoveNext();)
			{
				if(i.Current.person == null || i.Current.person == "")
					continue;
				elems.SetAttributeValue("datetime", i.Current.datetime.ToString());
				elems.SetAttributeValue("type", i.Current.type);
				elems.SetAttributeValue("change", i.Current.change.ToString());
				elems.SetAttributeValue("tag", i.Current.tag);
				elems.SetAttributeValue("person", i.Current.person);
				elems.SetAttributeValue("comment", i.Current.comment);
				elems.SetAttributeValue("otherRemark", i.Current.otherRemark);
				elems = (System.Xml.Linq.XElement)(elems.NextNode);
			}
			bool isopened = ConfigSync.file.IsOpened;
			if(!isopened && !ConfigSync.file.Open(ConfigSync.Instance.FileMainData))
				throw new System.IO.FileNotFoundException("The stream is null");
			bool ret = ConfigSync.file.Write(xml.ToString());
			if(!isopened)
				ConfigSync.file.Close();
			return ret;
		}
		public bool InsertRecord(AccountItem item)
		{
			data.Add(item);
			return true;
		}
		public bool RemoveRecord(System.DateTime time)
		{
			foreach(var i in data)
			{
				if(i.datetime == time)
					data.Remove(i);
			}
			return true;
		}
		public AccountItem[] Data
		{
			get
			{
				return data.ToArray();
			}
		}
	}
}
