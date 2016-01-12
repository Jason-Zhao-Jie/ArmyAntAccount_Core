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

			// �����б�,���ԭʼ����
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

			//������ʱ����Ӧ
			lv.OnItemClickListener = adapter;
			lv.OnItemLongClickListener = adapter;
		}

		public void SaveAndExit(bool isJustLogOut)
		{
			var loadingdlg = new AlertDialog.Builder(this).Create();
			loadingdlg.SetCancelable(false);
			loadingdlg.SetTitle("���Ժ�");
			loadingdlg.SetMessage("���ڱ����޸�");
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
						loadingdlg.SetTitle("���ݴ���");
						loadingdlg.SetMessage("��������ʧ��");
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
						loadingdlg.SetTitle("�������");
						loadingdlg.SetMessage("ͬ������ʧ��");
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

			view.SetBackgroundColor(position % 2 == 0 ? Android.Graphics.Color.White : Android.Graphics.Color.Gray);// ÿ��item֮����ɫ��ͬ 
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
			menu.Menu.Add("�鿴");
			menu.Menu.Add("ɾ��");
			menu.Menu.Add("�޸�");
			menu.Menu.Add("���");
			menu.Menu.Add("����");
			menu.Menu.Add("ɸѡ");
			menu.Menu.Add("ע��");
			menu.Menu.Add("�˳�");
			menu.MenuItemClick += Menu_MenuItemClick;
			menu.Show();
			view.SetBackgroundColor(position % 2 == 0 ? Android.Graphics.Color.White : Android.Graphics.Color.Gray);
			return false;
		}
		private void Menu_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
		{
			switch(e.Item.TitleFormatted.ToString())
			{
				case "�鿴":
					LoginActivity.MessageBox(MainActivity.This, "�鿴", "�����ݲ�֧��");
					break;
				case "ɾ��":
					QuestionBox(MainActivity.This, "ɾ����Ŀ", "ȷ��ɾ��������¼?", delegate (object s)
					{
						Core.Data.RemoveRecord(selectedPos);
						MainActivity.ret.Remove(GetItem(selectedPos));
						changed = true;
					});
					break;
				case "�޸�":
					LoginActivity.MessageBox(MainActivity.This, "�޸�", "�����ݲ�֧��");
					break;
				case "���":
					LoginActivity.MessageBox(MainActivity.This, "���", "�����ݲ�֧��");
					break;
				case "����":
					LoginActivity.MessageBox(MainActivity.This, "����", "��ǰ�ʲ�: " + Core.Data.Total + "\n������: " + Core.Data.TotalGain + "\n��֧��: " + Core.Data.TotalPain + "\n�վ�������: " + Core.Data.TotalOneDay);
					break;
				case "ɸѡ":
					LoginActivity.MessageBox(MainActivity.This, "ɸѡ", "�����ݲ�֧��");
					break;
				case "ע��":
					QuestionBox(MainActivity.This, "ע��", "ȷ��ע���û�?", delegate (object s)
					{
						if(changed)
							MainActivity.This.SaveAndExit(true);
						else
							MainActivity.This.GotoLogin();
					});
					break;
				case "�˳�":
					QuestionBox(MainActivity.This, "�˳�", "ȷ���˳��������ϵͳ?", delegate (object s)
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