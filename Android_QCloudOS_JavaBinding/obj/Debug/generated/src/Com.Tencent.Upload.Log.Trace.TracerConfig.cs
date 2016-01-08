using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Log.Trace {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']"
	[global::Android.Runtime.Register ("com/tencent/upload/log/trace/TracerConfig", DoNotGenerateAcw=true)]
	public partial class TracerConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='DEF_TRACE_FILEEXT']"
		[Register ("DEF_TRACE_FILEEXT")]
		public const string DefTraceFileext = (string) ".upload.log";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='LOG_FLUSH_DURATION']"
		[Register ("LOG_FLUSH_DURATION")]
		public const long LogFlushDuration = (long) 10000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='LOG_MAX_KEEP_DAY']"
		[Register ("LOG_MAX_KEEP_DAY")]
		public const long LogMaxKeepDay = (long) 7L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='MAX_BLOCK_COUNT']"
		[Register ("MAX_BLOCK_COUNT")]
		public const int MaxBlockCount = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='MAX_BLOCK_SIZE']"
		[Register ("MAX_BLOCK_SIZE")]
		public const int MaxBlockSize = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/field[@name='MEMORY_SIZE']"
		[Register ("MEMORY_SIZE")]
		public const long MemorySize = (long) 32768L;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/log/trace/TracerConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TracerConfig); }
		}

		protected TracerConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/constructor[@name='TracerConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TracerConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TracerConfig)) {
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

		static IntPtr id_getLogDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/method[@name='getLogDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLogDir", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetLogDir (global::Android.Content.Context p0)
		{
			if (id_getLogDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getLogDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLogDir", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLogFilePre_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.log.trace']/class[@name='TracerConfig']/method[@name='getLogFilePre' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLogFilePre", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetLogFilePre (global::Android.Content.Context p0)
		{
			if (id_getLogFilePre_Landroid_content_Context_ == IntPtr.Zero)
				id_getLogFilePre_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLogFilePre", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogFilePre_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
