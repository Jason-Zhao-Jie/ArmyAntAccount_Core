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
	[Activity(Label = "账务管理系统")]
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

			// 绘制列表,添加原始数据
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

			//加入点击时的响应
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
			// listview每次得到一个item，都要view去绘制，通过getView方法得到view 
			// position为item的序号 
			View view = null;
			if(convertView != null)
			{
				view = convertView;
				// 使用缓存的view,节约内存 
				// 当listview的item过多时，拖动会遮住一部分item，被遮住的item的view就是convertView保存着。 
				// 当滚动条回到之前被遮住的item时，直接使用convertView，而不必再去new view() 
			}
			else
			{
				view = base.GetView(position, convertView, parent);
			}

			int[] colors = { Android.Graphics.Color.White, Android.Graphics.Color.Rgb(219, 238, 244) };//RGB颜色 
			view.SetBackgroundColor(new Android.Graphics.Color(colors[position % 2]));// 每隔item之间颜色不同 
			return base.GetView(position, view, parent);
		}
	}
}