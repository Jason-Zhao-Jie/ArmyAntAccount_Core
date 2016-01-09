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
using Java.Lang;

namespace ArmyAntAccount
{
	[Activity(Label = "�������ϵͳ")]
	public class MainActivity : Activity
	{
		private bool isItemClicking = false;
		private PopupMenu menu = null;
		private PopupWindow window = null;
		protected ListView lv;
		public delegate JavaDictionary<string, Java.Lang.Object> AddingFunc(AccountItem i);
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// �����б�,���ԭʼ����
			lv = FindViewById<ListView>(Resource.Id.lv);
			var ret = new JavaList<IDictionary<string, object>>();
			AddingFunc adding = (AccountItem i) =>
			{
				var retv = new JavaDictionary<string, Java.Lang.Object>();
				retv.Add("datetime", i.datetime.ToString());
				retv.Add("type", i.type);
				retv.Add("change", i.change);
				retv.Add("tag", i.tag);
				retv.Add("person", i.person);
				retv.Add("comment", i.comment);
				retv.Add("otherRemark", i.otherRemark);
				return retv;
			};
			for(int i = 0; i < Core.Data.Data.Length; i++)
			{
				ret.Add(adding(Core.Data.Data[i]));
			}
			var adapter = new MySimpleAdapter(this, ret, Resource.Layout.listviewLayout, new string[] { "datetime", "type", "person", "change", "tag" }, new int[] { Resource.Id.datetime, Resource.Id.type, Resource.Id.person, Resource.Id.change, Resource.Id.tag });
			lv.Adapter = adapter;

			//������ʱ����Ӧ
			menu = new PopupMenu(this);
			window = new PopupWindow(this,);
			lv.LongClick += Lv_LongClick;
			lv.ItemClick += Lv_ItemClick;
			lv.ItemLongClick += Lv_ItemLongClick;
		}

		private void Lv_LongClick(object sender, View.LongClickEventArgs e)
		{
			if(isItemClicking)
				return;

		}
		private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			isItemClicking = true;

			isItemClicking = false;
		}
		private void Lv_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
		{
			isItemClicking = true;

			isItemClicking = false;
		}
	}

	public class MySimpleAdapter : SimpleAdapter
	{
		public MySimpleAdapter(Context context, JavaList<IDictionary<string, object>> data, int resource, string[] from, int[] to)
			:base(context, data, resource, from, to)
		{
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			// TODO Auto-generated method stub 
			// listviewÿ�εõ�һ��item����Ҫviewȥ���ƣ�ͨ��getView�����õ�view 
			// positionΪitem����� 
			View view = null;
			if(convertView != null)
			{
				view = convertView;
				// ʹ�û����view,��Լ�ڴ� 
				// ��listview��item����ʱ���϶�����סһ����item������ס��item��view����convertView�����š� 
				// ���������ص�֮ǰ����ס��itemʱ��ֱ��ʹ��convertView����������ȥnew view() 
			}
			else
			{
				view = base.GetView(position, convertView, parent);
			}

			int[] colors = { Android.Graphics.Color.White, Android.Graphics.Color.Rgb(219, 238, 244) };//RGB��ɫ 
			view.SetBackgroundColor(new Android.Graphics.Color(colors[position % 2]));// ÿ��item֮����ɫ��ͬ 
			return base.GetView(position, view, parent);
		}
	}
}