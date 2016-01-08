using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ArmyAntAccount
{
	class QCloudCOS_Android : AQCloudOS
	{
		public override bool CreateDirectory(string parentdir, string name)
		{
			throw new NotImplementedException();
		}

		public override bool DeleteDirectory(string dir)
		{
			throw new NotImplementedException();
		}

		public override bool DeleteFile(string path)
		{
			throw new NotImplementedException();
		}

		public override bool Download(string netpath, string localpath)
		{
			throw new NotImplementedException();
		}

		public override bool IsDirectoryExist(string dir)
		{
			throw new NotImplementedException();
		}

		public override bool IsFileExist(string netpath)
		{
			throw new NotImplementedException();
		}

		public override bool Upload(string localpath, string netpath)
		{
			throw new NotImplementedException();
		}
	}
}