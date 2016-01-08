using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']"
	[global::Android.Runtime.Register ("com/tencent/upload/common/Global", DoNotGenerateAcw=true)]
	public partial class Global : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "1.1.3.332";

		static IntPtr clientIP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/field[@name='clientIP']"
		[Register ("clientIP")]
		public static string ClientIP {
			get {
				if (clientIP_jfieldId == IntPtr.Zero)
					clientIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "clientIP", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, clientIP_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (clientIP_jfieldId == IntPtr.Zero)
					clientIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "clientIP", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, clientIP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/field[@name='context']"
		[Register ("context")]
		public static global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/common/Global", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Global); }
		}

		protected Global (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/constructor[@name='Global' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Global ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Global)) {
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

		static IntPtr id_getDeviceId;
		public static unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetStaticMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEnv;
		public static unsafe global::FileCloud.StEnvironment Env {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/method[@name='getEnv' and count(parameter)=0]"
			[Register ("getEnv", "()LFileCloud/stEnvironment;", "GetGetEnvHandler")]
			get {
				if (id_getEnv == IntPtr.Zero)
					id_getEnv = JNIEnv.GetStaticMethodID (class_ref, "getEnv", "()LFileCloud/stEnvironment;");
				try {
					return global::Java.Lang.Object.GetObject<global::FileCloud.StEnvironment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnv), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMacAddress;
		public static unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				if (id_getMacAddress == IntPtr.Zero)
					id_getMacAddress = JNIEnv.GetStaticMethodID (class_ref, "getMacAddress", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMacAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNetType;
		public static unsafe int NetType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/method[@name='getNetType' and count(parameter)=0]"
			[Register ("getNetType", "()I", "GetGetNetTypeHandler")]
			get {
				if (id_getNetType == IntPtr.Zero)
					id_getNetType = JNIEnv.GetStaticMethodID (class_ref, "getNetType", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getNetType);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.common']/class[@name='Global']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
