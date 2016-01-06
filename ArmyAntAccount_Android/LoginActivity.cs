using Android.App;
using Android.Widget;

namespace ArmyAntAccount
{
	[Activity(Label = "账务管理系统", MainLauncher = true, Icon = "@drawable/icon")]
	public class LoginActivity : Activity
	{
		UserChecker userdata = null;
		public UserData user = null;
		protected override void OnDestroy()
		{
			var file = new Stream_Android();
			userdata.Save();
			base.OnDestroy();
		}
		protected override void OnCreate(Android.OS.Bundle bundle)
		{
			base.OnCreate(bundle);
			Stream_Android.Path = ApplicationContext.FilesDir.Path + "/";

			var file = new Stream_Android();
			userdata = new UserChecker(file);
			Android.Util.Log.Warn("ZJ", "Open and read another library");

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
				user = userdata.Check(uid.Text, pwd.Text);
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
		}

		public static void MessageBox(Activity act, string title, string text)
		{
			var ad = new AlertDialog.Builder(act).Create();
			ad.SetTitle(title);
			ad.SetMessage(text);
			ad.SetButton("OK", (object sender, Android.Content.DialogClickEventArgs e) => { });
			ad.Show();
		}
	}
}

