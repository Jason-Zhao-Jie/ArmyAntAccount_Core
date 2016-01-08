using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Download.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']"
	[global::Android.Runtime.Register ("com/tencent/download/core/DownloadResult", DoNotGenerateAcw=true)]
	public sealed partial class DownloadResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/download/core/DownloadResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadResult); }
		}

		internal DownloadResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/constructor[@name='DownloadResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DownloadResult (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DownloadResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getErrorCode;
		static IntPtr id_setErrorCode_I;
		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorCode", "(I)V", "GetSetErrorCode_IHandler")]
			set {
				if (id_setErrorCode_I == IntPtr.Zero)
					id_setErrorCode_I = JNIEnv.GetMethodID (class_ref, "setErrorCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setErrorCode_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setMessage_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPath;
		static IntPtr id_setPath_Ljava_lang_String_;
		public unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler")]
			set {
				if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setPath_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getTmpPath;
		static IntPtr id_setTmpPath_Ljava_lang_String_;
		public unsafe string TmpPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='getTmpPath' and count(parameter)=0]"
			[Register ("getTmpPath", "()Ljava/lang/String;", "GetGetTmpPathHandler")]
			get {
				if (id_getTmpPath == IntPtr.Zero)
					id_getTmpPath = JNIEnv.GetMethodID (class_ref, "getTmpPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTmpPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='setTmpPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTmpPath", "(Ljava/lang/String;)V", "GetSetTmpPath_Ljava_lang_String_Handler")]
			set {
				if (id_setTmpPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setTmpPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTmpPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setTmpPath_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getUrl;
		public unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download.core']/class[@name='DownloadResult']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			} finally {
			}
		}

	}
}
