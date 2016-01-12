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
		public ListView lv;
		public static MainActivity This = null;
		public static JavaList<IDictionary<string, object>> ret = new JavaList<IDictionary<string, object>>();
		public delegate JavaDictionary<string, Java.Lang.Object> AddingFunc(AccountItem i);
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			This = this;
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// 绘制列表,添加原始数据
			lv = FindViewById<ListView>(Resource.Id.lv);
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
			lv.OnItemClickListener = adapter;
			lv.OnItemLongClickListener = adapter;
		}

		public void SaveAndExit(bool isJustLogOut)
		{
			var loadingdlg = new AlertDialog.Builder(this).Create();
			loadingdlg.SetCancelable(false);
			loadingdlg.SetTitle("请稍后");
			loadingdlg.SetMessage("正在保存修改");
			loadingdlg.Show();
			new Thread(() =>
			{
				Stream_Android.Path = ApplicationContext.FilesDir.Path + "/";
				if(!Core.Save(Core.IOType.Data))
				{
					RunOnUiThread(() =>
					{
						loadingdlg.Dismiss();
						loadingdlg = new AlertDialog.Builder(this).Create();
						loadingdlg.SetTitle("数据错误");
						loadingdlg.SetMessage("保存数据失败");
						loadingdlg.SetButton("OK", (object ss, DialogClickEventArgs ev) =>
						{
							Finish();
						});
					});
					return;
				}
				if(!Core.Sync(Core.IOType.Data))
				{
					RunOnUiThread(() =>
					{
						loadingdlg.Dismiss();
						loadingdlg = new AlertDialog.Builder(this).Create();
						loadingdlg.SetTitle("网络错误");
						loadingdlg.SetMessage("同步数据失败");
						loadingdlg.SetButton("OK", (object ss, DialogClickEventArgs ev) =>
						{
							Finish();
						});
					});
					return;
				}
				RunOnUiThread(() =>
				{
					loadingdlg.Dismiss();
					if(isJustLogOut)
					{
						GotoLogin();
					}
					Finish();
				});
			}).Start();
		}
		public void GotoLogin()
		{
			var intent = new Intent();
			intent.SetClass(ApplicationContext, Type.GetType("ArmyAntAccount.LoginActivity"));
			StartActivity(intent);
			Finish();
		}
	}
	public class MySimpleAdapter : SimpleAdapter, View.IOnTouchListener, AdapterView.IOnItemClickListener, AdapterView.IOnItemLongClickListener
	{
		private PopupMenu menu = null;
		private PopupWindow window = null;
		private int selectedPos = 0;
		private bool changed = false;
		public delegate void VoidEventCall(object sender);

		public MySimpleAdapter(Context context, JavaList<IDictionary<string, object>> data, int resource, string[] from, int[] to)
			: base(context, data, resource, from, to)
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

			view.SetBackgroundColor(position % 2 == 0 ? Android.Graphics.Color.White : Android.Graphics.Color.Gray);// 每隔item之间颜色不同 
			var ret = base.GetView(position, view, parent);
			ret.SetOnTouchListener(this);
			return ret;
		}

		public void OnItemClick(AdapterView parent, View view, int position, long id)
		{
			view.SetBackgroundColor(position % 2 == 0 ? Android.Graphics.Color.White : Android.Graphics.Color.Gray);
			selectedPos = position;
			window = new PopupWindow(MainActivity.This);

			window.ShowAtLocation(parent, GravityFlags.Center, 0, 0);
		}

		public bool OnItemLongClick(AdapterView parent, View view, int position, long id)
		{
			menu = new PopupMenu(MainActivity.This, view);
			selectedPos = position;
			menu.Menu.Add("查看");
			menu.Menu.Add("删除");
			menu.Menu.Add("修改");
			menu.Menu.Add("添加");
			menu.Menu.Add("总览");
			menu.Menu.Add("筛选");
			menu.Menu.Add("注销");
			menu.Menu.Add("退出");
			menu.MenuItemClick += Menu_MenuItemClick;
			menu.Show();
			view.SetBackgroundColor(position % 2 == 0 ? Android.Graphics.Color.White : Android.Graphics.Color.Gray);
			return false;
		}
		private void Menu_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
		{
			switch(e.Item.TitleFormatted.ToString())
			{
				case "查看":
					LoginActivity.MessageBox(MainActivity.This, "查看", "功能暂不支持");
					break;
				case "删除":
					QuestionBox(MainActivity.This, "删除账目", "确定删除此条记录?", delegate (object s)
					{
						Core.Data.RemoveRecord(selectedPos);
						MainActivity.ret.Remove(GetItem(selectedPos));
						changed = true;
					});
					break;
				case "修改":
					LoginActivity.MessageBox(MainActivity.This, "修改", "功能暂不支持");
					break;
				case "添加":
					LoginActivity.MessageBox(MainActivity.This, "添加", "功能暂不支持");
					break;
				case "总览":
					LoginActivity.MessageBox(MainActivity.This, "总览", "当前资产: " + Core.Data.Total + "\n总收入: " + Core.Data.TotalGain + "\n总支出: " + Core.Data.TotalPain + "\n日均净收入: " + Core.Data.TotalOneDay);
					break;
				case "筛选":
					LoginActivity.MessageBox(MainActivity.This, "筛选", "功能暂不支持");
					break;
				case "注销":
					QuestionBox(MainActivity.This, "注销", "确定注销用户?", delegate (object s)
					{
						if(changed)
							MainActivity.This.SaveAndExit(true);
						else
							MainActivity.This.GotoLogin();
					});
					break;
				case "退出":
					QuestionBox(MainActivity.This, "退出", "确定退出账务管理系统?", delegate (object s)
					{
						if(changed)
							MainActivity.This.SaveAndExit(false);
						else
							MainActivity.This.Finish();
					});
					break;
			}
		}


		public bool OnTouch(View v, MotionEvent e)
		{
			switch(e.Action)
			{
				case MotionEventActions.Down:
					v.SetBackgroundColor(Android.Graphics.Color.Yellow);
					break;
			}
			return false;
		}
		public static void QuestionBox(Activity act, string title, string text, VoidEventCall okCall)
		{
			var ad = new AlertDialog.Builder(act).Create();
			ad.SetTitle(title);
			ad.SetMessage(text);
			ad.SetButton("OK", (object sender, DialogClickEventArgs e) =>
			{
				okCall(ad);
			});
			ad.SetButton2("Cancel", (object sender, DialogClickEventArgs e) =>
			{
			});
			ad.Show();
		}
	}
}