using Android.App;
using Android.Widget;

namespace ArmyAntAccount
{
	[Activity(Label = "账务管理系统", MainLauncher = true, Icon = "@drawable/icon")]
	public class LoginActivity : Activity
	{
		public static UserData user = null;
		protected override void OnDestroy()
		{
			base.OnDestroy();
		}
		protected override void OnCreate(Android.OS.Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Login);

			// Get our button from the layout resource,
			// and attach an event to it
			FindViewById<Button>(Resource.Id.exitBtn).Click += delegate
			{
				Finish();
			};
			FindViewById<Button>(Resource.Id.loginBtn).Click += delegate
			{
				TextView uid = FindViewById<TextView>(Resource.Id.uidText);
				TextView pwd = FindViewById<TextView>(Resource.Id.pwdText);
				user = Core.Users.Check(uid.Text, pwd.Text);
				if(null == user)
				{
					MessageBox(this, "登录失败", "用户名或密码错误");
				}
				else
				{
					var intent = new Android.Content.Intent();
					intent.PutExtra("name", user.name);
					intent.PutExtra("uid", user.uid);
					intent.PutExtra("access", (byte)user.access);
					intent.SetClass(ApplicationContext, System.Type.GetType("ArmyAntAccount.MainActivity"));
					StartActivity(intent);
					Finish();
				}
			};
			FindViewById<TextView>(Resource.Id.uidText).Text = "zhaojie";
			FindViewById<TextView>(Resource.Id.pwdText).Text = "zjljcy";

			if(!Core.Inited)
			{
				Stream_Android.Path = ApplicationContext.FilesDir.Path + "/";
				var loadingdlg = new AlertDialog.Builder(this).Create();
				loadingdlg.SetCancelable(false);
				loadingdlg.SetTitle("请稍后");
				loadingdlg.SetMessage("正在同步账户信息");
				loadingdlg.Show();
				new Java.Lang.Thread(() =>
				{
					Log("In thread");
					Stream_Android.Path = ApplicationContext.FilesDir.Path + "/";
					try
					{
						Core.Init(new Stream_Android(), new QCloudOS_Android());
					}
					catch(System.Exception)
					{
						RunOnUiThread(() =>
						{
							loadingdlg.Dismiss();
							loadingdlg = new AlertDialog.Builder(this).Create();
							loadingdlg.SetTitle("数据错误");
							loadingdlg.SetMessage("读取本地数据失败!\n错误信息:");
							loadingdlg.SetButton("OK", (object sender, Android.Content.DialogClickEventArgs e) =>
							{
								Finish();
							});
						});
						return;
					}
					if(!Core.Download(Core.IOType.All))
					{
						RunOnUiThread(() =>
						{
							loadingdlg.Dismiss();
							loadingdlg = new AlertDialog.Builder(this).Create();
							loadingdlg.SetTitle("数据错误");
							loadingdlg.SetMessage("从云读取账户信息失败!");
							loadingdlg.SetButton("OK", (object sender, Android.Content.DialogClickEventArgs e) =>
							{
								Finish();
							});
						});
						return;
					}
					Log("Before update thread");
					RunOnUiThread(() =>
					{
						loadingdlg.Dismiss();
					});
					Log("After update thread");
				}).Start();
			}
		}

		public static void MessageBox(Activity act, string title, string text)
		{
			var ad = new AlertDialog.Builder(act).Create();
			ad.SetTitle(title);
			ad.SetMessage(text);
			ad.SetButton("OK", (object sender, Android.Content.DialogClickEventArgs e) => { });
			ad.Show();
		}

		public static void Log(string mess)
		{
			Android.Util.Log.Debug("ZJ", mess);
		}
	}
}

