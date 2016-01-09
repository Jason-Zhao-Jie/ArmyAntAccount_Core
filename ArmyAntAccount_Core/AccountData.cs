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

		public Dictionary<string, object> ToDic()
		{
			var ret = new Dictionary<string, object>();
			ret.Add("datetime", datetime.ToString());
			ret.Add("type", type);
			ret.Add("change", change);
			ret.Add("tag", tag);
			ret.Add("person", person);
			ret.Add("comment", comment);
			ret.Add("otherRemark", otherRemark);
			return ret;
		}
	}
	public class AccountData
	{
		private List<AccountItem> data = new List<AccountItem>();
		internal AccountData()
		{
			bool isopened = Core.File.IsOpened;
			if(!isopened && !Core.File.Open(Core.Config.FileMainData))
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
		internal bool Save()
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
			bool isopened = Core.File.IsOpened;
			if(!isopened && !Core.File.Open(Core.Config.FileMainData))
				throw new System.IO.FileNotFoundException("The stream is null");
			bool ret = Core.File.Write(ConfigSync.xmlDocumentDef);
			ret = ret && Core.File.Write(xml.ToString());
			if(!isopened)
				Core.File.Close();
			return ret;
		}
		public bool InsertRecord(AccountItem item)
		{
			data.Add(item);
			return true;
		}
		public bool RemoveRecord(System.DateTime time)
		{
			var ret = Find(time);
			if(ret != null)
				data.Remove(ret);
			return true;
		}
		public bool RemoveRecord(int index)
		{
			data.RemoveAt(index);
			return true;
		}

		public List<IDictionary<string, object>> ToDicList()
		{
			var ret = new List<IDictionary<string, object>>();
			for(int i = 0; data != null && data.Count > i; i++)
			{
				ret.Add(data[i].ToDic());
			}
			return ret;
		}

		public AccountItem[] Data
		{
			get
			{
				return data.ToArray();
			}
		}

		private AccountItem Find(System.DateTime time)
		{
			foreach(var i in data)
			{
				if(i.datetime == time)
					return i;
			}
			return null;
		}

		internal bool Mix(AccountData data)
		{
			for(int i = 0; i < data.data.Count; i++)
			{
				if(Find(data.data[i].datetime) == null)
					this.data.Add(data.data[i]);
			}
			return true;
		}
	}
}
