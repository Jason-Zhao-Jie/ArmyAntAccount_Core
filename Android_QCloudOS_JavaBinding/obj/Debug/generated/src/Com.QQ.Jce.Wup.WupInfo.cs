using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/WupInfo", DoNotGenerateAcw=true)]
	public partial class WupInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/WupInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WupInfo); }
		}

		protected WupInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/constructor[@name='WupInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WupInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WupInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getClientBuilt;
		public static unsafe string ClientBuilt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/method[@name='getClientBuilt' and count(parameter)=0]"
			[Register ("getClientBuilt", "()Ljava/lang/String;", "GetGetClientBuiltHandler")]
			get {
				if (id_getClientBuilt == IntPtr.Zero)
					id_getClientBuilt = JNIEnv.GetStaticMethodID (class_ref, "getClientBuilt", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClientBuilt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getClientInfo;
		public static unsafe string ClientInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/method[@name='getClientInfo' and count(parameter)=0]"
			[Register ("getClientInfo", "()Ljava/lang/String;", "GetGetClientInfoHandler")]
			get {
				if (id_getClientInfo == IntPtr.Zero)
					id_getClientInfo = JNIEnv.GetStaticMethodID (class_ref, "getClientInfo", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClientInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getClientNumber;
		public static unsafe string ClientNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/method[@name='getClientNumber' and count(parameter)=0]"
			[Register ("getClientNumber", "()Ljava/lang/String;", "GetGetClientNumberHandler")]
			get {
				if (id_getClientNumber == IntPtr.Zero)
					id_getClientNumber = JNIEnv.GetStaticMethodID (class_ref, "getClientNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClientNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_showString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='WupInfo']/method[@name='showString' and count(parameter)=0]"
		[Register ("showString", "()Ljava/lang/String;", "")]
		public static unsafe string ShowString ()
		{
			if (id_showString == IntPtr.Zero)
				id_showString = JNIEnv.GetStaticMethodID (class_ref, "showString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_showString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
