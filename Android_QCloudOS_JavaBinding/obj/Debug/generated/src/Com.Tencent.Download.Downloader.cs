using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']"
	[global::Android.Runtime.Register ("com/tencent/download/Downloader", DoNotGenerateAcw=true)]
	public partial class Downloader : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.download']/interface[@name='Downloader.DownloadListener']"
		[Register ("com/tencent/download/Downloader$DownloadListener", "", "Com.Tencent.Download.Downloader/IDownloadListenerInvoker")]
		public partial interface IDownloadListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/interface[@name='Downloader.DownloadListener']/method[@name='onDownloadCanceled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDownloadCanceled", "(Ljava/lang/String;)V", "GetOnDownloadCanceled_Ljava_lang_String_Handler:Com.Tencent.Download.Downloader/IDownloadListenerInvoker, Android_QCloudOS_JavaBinding")]
			void OnDownloadCanceled (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/interface[@name='Downloader.DownloadListener']/method[@name='onDownloadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.download.core.DownloadResult']]"
			[Register ("onDownloadFailed", "(Ljava/lang/String;Lcom/tencent/download/core/DownloadResult;)V", "GetOnDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_Handler:Com.Tencent.Download.Downloader/IDownloadListenerInvoker, Android_QCloudOS_JavaBinding")]
			void OnDownloadFailed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/interface[@name='Downloader.DownloadListener']/method[@name='onDownloadProgress' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='float']]"
			[Register ("onDownloadProgress", "(Ljava/lang/String;JF)V", "GetOnDownloadProgress_Ljava_lang_String_JFHandler:Com.Tencent.Download.Downloader/IDownloadListenerInvoker, Android_QCloudOS_JavaBinding")]
			void OnDownloadProgress (string p0, long p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/interface[@name='Downloader.DownloadListener']/method[@name='onDownloadSucceed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.download.core.DownloadResult']]"
			[Register ("onDownloadSucceed", "(Ljava/lang/String;Lcom/tencent/download/core/DownloadResult;)V", "GetOnDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_Handler:Com.Tencent.Download.Downloader/IDownloadListenerInvoker, Android_QCloudOS_JavaBinding")]
			void OnDownloadSucceed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1);

		}

		[global::Android.Runtime.Register ("com/tencent/download/Downloader$DownloadListener", DoNotGenerateAcw=true)]
		internal class IDownloadListenerInvoker : global::Java.Lang.Object, IDownloadListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/download/Downloader$DownloadListener");
			IntPtr class_ref;

			public static IDownloadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.download.Downloader.DownloadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDownloadListenerInvoker); }
			}

			static Delegate cb_onDownloadCanceled_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnDownloadCanceled_Ljava_lang_String_Handler ()
			{
				if (cb_onDownloadCanceled_Ljava_lang_String_ == null)
					cb_onDownloadCanceled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDownloadCanceled_Ljava_lang_String_);
				return cb_onDownloadCanceled_Ljava_lang_String_;
			}

			static void n_OnDownloadCanceled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Download.Downloader.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDownloadCanceled (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDownloadCanceled_Ljava_lang_String_;
			public unsafe void OnDownloadCanceled (string p0)
			{
				if (id_onDownloadCanceled_Ljava_lang_String_ == IntPtr.Zero)
					id_onDownloadCanceled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDownloadCanceled", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onDownloadCanceled_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
#pragma warning disable 0169
			static Delegate GetOnDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_Handler ()
			{
				if (cb_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ == null)
					cb_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_);
				return cb_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
			}

			static void n_OnDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Download.Downloader.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Download.Core.DownloadResult p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Core.DownloadResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDownloadFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
			public unsafe void OnDownloadFailed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				if (id_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ == IntPtr.Zero)
					id_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ = JNIEnv.GetMethodID (class_ref, "onDownloadFailed", "(Ljava/lang/String;Lcom/tencent/download/core/DownloadResult;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onDownloadFailed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onDownloadProgress_Ljava_lang_String_JF;
#pragma warning disable 0169
			static Delegate GetOnDownloadProgress_Ljava_lang_String_JFHandler ()
			{
				if (cb_onDownloadProgress_Ljava_lang_String_JF == null)
					cb_onDownloadProgress_Ljava_lang_String_JF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, float>) n_OnDownloadProgress_Ljava_lang_String_JF);
				return cb_onDownloadProgress_Ljava_lang_String_JF;
			}

			static void n_OnDownloadProgress_Ljava_lang_String_JF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, float p2)
			{
				global::Com.Tencent.Download.Downloader.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDownloadProgress (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onDownloadProgress_Ljava_lang_String_JF;
			public unsafe void OnDownloadProgress (string p0, long p1, float p2)
			{
				if (id_onDownloadProgress_Ljava_lang_String_JF == IntPtr.Zero)
					id_onDownloadProgress_Ljava_lang_String_JF = JNIEnv.GetMethodID (class_ref, "onDownloadProgress", "(Ljava/lang/String;JF)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onDownloadProgress_Ljava_lang_String_JF, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
#pragma warning disable 0169
			static Delegate GetOnDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_Handler ()
			{
				if (cb_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ == null)
					cb_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_);
				return cb_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
			}

			static void n_OnDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Download.Downloader.IDownloadListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Download.Core.DownloadResult p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Core.DownloadResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDownloadSucceed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_;
			public unsafe void OnDownloadSucceed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				if (id_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ == IntPtr.Zero)
					id_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_ = JNIEnv.GetMethodID (class_ref, "onDownloadSucceed", "(Ljava/lang/String;Lcom/tencent/download/core/DownloadResult;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onDownloadSucceed_Ljava_lang_String_Lcom_tencent_download_core_DownloadResult_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class DownloadCanceledEventArgs : global::System.EventArgs {

			public DownloadCanceledEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class DownloadFailedEventArgs : global::System.EventArgs {

			public DownloadFailedEventArgs (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Com.Tencent.Download.Core.DownloadResult p1;
			public global::Com.Tencent.Download.Core.DownloadResult P1 {
				get { return p1; }
			}
		}

		public partial class DownloadProgressEventArgs : global::System.EventArgs {

			public DownloadProgressEventArgs (string p0, long p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		public partial class DownloadSucceedEventArgs : global::System.EventArgs {

			public DownloadSucceedEventArgs (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Com.Tencent.Download.Core.DownloadResult p1;
			public global::Com.Tencent.Download.Core.DownloadResult P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/download/Downloader_DownloadListenerImplementor")]
		internal sealed partial class IDownloadListenerImplementor : global::Java.Lang.Object, IDownloadListener {

			object sender;

			public IDownloadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/download/Downloader_DownloadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DownloadCanceledEventArgs> OnDownloadCanceledHandler;
#pragma warning restore 0649

			public void OnDownloadCanceled (string p0)
			{
				var __h = OnDownloadCanceledHandler;
				if (__h != null)
					__h (sender, new DownloadCanceledEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<DownloadFailedEventArgs> OnDownloadFailedHandler;
#pragma warning restore 0649

			public void OnDownloadFailed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				var __h = OnDownloadFailedHandler;
				if (__h != null)
					__h (sender, new DownloadFailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<DownloadProgressEventArgs> OnDownloadProgressHandler;
#pragma warning restore 0649

			public void OnDownloadProgress (string p0, long p1, float p2)
			{
				var __h = OnDownloadProgressHandler;
				if (__h != null)
					__h (sender, new DownloadProgressEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<DownloadSucceedEventArgs> OnDownloadSucceedHandler;
#pragma warning restore 0649

			public void OnDownloadSucceed (string p0, global::Com.Tencent.Download.Core.DownloadResult p1)
			{
				var __h = OnDownloadSucceedHandler;
				if (__h != null)
					__h (sender, new DownloadSucceedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDownloadListenerImplementor value)
			{
				return value.OnDownloadCanceledHandler == null && value.OnDownloadFailedHandler == null && value.OnDownloadProgressHandler == null && value.OnDownloadSucceedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader.Priority']"
		[global::Android.Runtime.Register ("com/tencent/download/Downloader$Priority", DoNotGenerateAcw=true)]
		public sealed partial class Priority : global::Java.Lang.Enum {


			static IntPtr FIFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader.Priority']/field[@name='FIFO']"
			[Register ("FIFO")]
			public static global::Com.Tencent.Download.Downloader.Priority Fifo {
				get {
					if (FIFO_jfieldId == IntPtr.Zero)
						FIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIFO", "Lcom/tencent/download/Downloader$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LIFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader.Priority']/field[@name='LIFO']"
			[Register ("LIFO")]
			public static global::Com.Tencent.Download.Downloader.Priority Lifo {
				get {
					if (LIFO_jfieldId == IntPtr.Zero)
						LIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIFO", "Lcom/tencent/download/Downloader$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/download/Downloader$Priority", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Priority); }
			}

			internal Priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader.Priority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/download/Downloader$Priority;", "")]
			public static unsafe global::Com.Tencent.Download.Downloader.Priority ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/download/Downloader$Priority;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Download.Downloader.Priority __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.Priority> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader.Priority']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/download/Downloader$Priority;", "")]
			public static unsafe global::Com.Tencent.Download.Downloader.Priority[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/download/Downloader$Priority;");
				try {
					return (global::Com.Tencent.Download.Downloader.Priority[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Download.Downloader.Priority));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/download/Downloader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Downloader); }
		}

		protected Downloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/constructor[@name='Downloader' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Downloader (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Downloader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_Handler ()
		{
			if (cb_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ == null)
				cb_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_);
			return cb_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
		}

		static void n_Cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Download.Downloader.IDownloadListener p1 = (global::Com.Tencent.Download.Downloader.IDownloadListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='cancel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.download.Downloader.DownloadListener']]"
		[Register ("cancel", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)V", "GetCancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_Handler")]
		public virtual unsafe void Cancel (string p0, global::Com.Tencent.Download.Downloader.IDownloadListener p1)
		{
			if (id_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ == IntPtr.Zero)
				id_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cancelAll;
#pragma warning disable 0169
		static Delegate GetCancelAllHandler ()
		{
			if (cb_cancelAll == null)
				cb_cancelAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelAll);
			return cb_cancelAll;
		}

		static void n_CancelAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAll ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='cancelAll' and count(parameter)=0]"
		[Register ("cancelAll", "()V", "GetCancelAllHandler")]
		public virtual unsafe void CancelAll ()
		{
			if (id_cancelAll == IntPtr.Zero)
				id_cancelAll = JNIEnv.GetMethodID (class_ref, "cancelAll", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelAll);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_cleanCache;
#pragma warning disable 0169
		static Delegate GetCleanCacheHandler ()
		{
			if (cb_cleanCache == null)
				cb_cleanCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CleanCache);
			return cb_cleanCache;
		}

		static void n_CleanCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanCache ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='cleanCache' and count(parameter)=0]"
		[Register ("cleanCache", "()V", "GetCleanCacheHandler")]
		public virtual unsafe void CleanCache ()
		{
			if (id_cleanCache == IntPtr.Zero)
				id_cleanCache = JNIEnv.GetMethodID (class_ref, "cleanCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_Handler ()
		{
			if (cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ == null)
				cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_);
			return cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
		}

		static bool n_Download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Download.Downloader.IDownloadListener p1 = (global::Com.Tencent.Download.Downloader.IDownloadListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Download (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='download' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.download.Downloader.DownloadListener']]"
		[Register ("download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)Z", "GetDownload_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_Handler")]
		public virtual unsafe bool Download (string p0, global::Com.Tencent.Download.Downloader.IDownloadListener p1)
		{
			if (id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ == IntPtr.Zero)
				id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_DownloadListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$DownloadListener;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_Handler ()
		{
			if (cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_ == null)
				cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_);
			return cb_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_;
		}

		static bool n_Download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Download.Downloader.Priority p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.Priority> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Download.Downloader.IDownloadListener p2 = (global::Com.Tencent.Download.Downloader.IDownloadListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader.IDownloadListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Download (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='download' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.download.Downloader.Priority'] and parameter[3][@type='com.tencent.download.Downloader.DownloadListener']]"
		[Register ("download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$Priority;Lcom/tencent/download/Downloader$DownloadListener;)Z", "GetDownload_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_Handler")]
		public virtual unsafe bool Download (string p0, global::Com.Tencent.Download.Downloader.Priority p1, global::Com.Tencent.Download.Downloader.IDownloadListener p2)
		{
			if (id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_ == IntPtr.Zero)
				id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$Priority;Lcom/tencent/download/Downloader$DownloadListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_download_Ljava_lang_String_Lcom_tencent_download_Downloader_Priority_Lcom_tencent_download_Downloader_DownloadListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Ljava/lang/String;Lcom/tencent/download/Downloader$Priority;Lcom/tencent/download/Downloader$DownloadListener;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_enableHTTPRange_Z;
#pragma warning disable 0169
		static Delegate GetEnableHTTPRange_ZHandler ()
		{
			if (cb_enableHTTPRange_Z == null)
				cb_enableHTTPRange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableHTTPRange_Z);
			return cb_enableHTTPRange_Z;
		}

		static void n_EnableHTTPRange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableHTTPRange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableHTTPRange_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='enableHTTPRange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableHTTPRange", "(Z)V", "GetEnableHTTPRange_ZHandler")]
		public virtual unsafe void EnableHTTPRange (bool p0)
		{
			if (id_enableHTTPRange_Z == IntPtr.Zero)
				id_enableHTTPRange_Z = JNIEnv.GetMethodID (class_ref, "enableHTTPRange", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableHTTPRange_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableHTTPRange", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enableKeepAlive_Z;
#pragma warning disable 0169
		static Delegate GetEnableKeepAlive_ZHandler ()
		{
			if (cb_enableKeepAlive_Z == null)
				cb_enableKeepAlive_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableKeepAlive_Z);
			return cb_enableKeepAlive_Z;
		}

		static void n_EnableKeepAlive_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableKeepAlive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableKeepAlive_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='enableKeepAlive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableKeepAlive", "(Z)V", "GetEnableKeepAlive_ZHandler")]
		public virtual unsafe void EnableKeepAlive (bool p0)
		{
			if (id_enableKeepAlive_Z == IntPtr.Zero)
				id_enableKeepAlive_Z = JNIEnv.GetMethodID (class_ref, "enableKeepAlive", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableKeepAlive_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableKeepAlive", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCacheFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCacheFile_Ljava_lang_String_Handler ()
		{
			if (cb_getCacheFile_Ljava_lang_String_ == null)
				cb_getCacheFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCacheFile_Ljava_lang_String_);
			return cb_getCacheFile_Ljava_lang_String_;
		}

		static IntPtr n_GetCacheFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCacheFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCacheFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='getCacheFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCacheFile", "(Ljava/lang/String;)Ljava/io/File;", "GetGetCacheFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File GetCacheFile (string p0)
		{
			if (id_getCacheFile_Ljava_lang_String_ == IntPtr.Zero)
				id_getCacheFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCacheFile", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.IO.File __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getCacheFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheFile", "(Ljava/lang/String;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasCache_Ljava_lang_String_Handler ()
		{
			if (cb_hasCache_Ljava_lang_String_ == null)
				cb_hasCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasCache_Ljava_lang_String_);
			return cb_hasCache_Ljava_lang_String_;
		}

		static bool n_HasCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasCache (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='hasCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasCache", "(Ljava/lang/String;)Z", "GetHasCache_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasCache (string p0)
		{
			if (id_hasCache_Ljava_lang_String_ == IntPtr.Zero)
				id_hasCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasCache", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasCache_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCache", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_raisePriority_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRaisePriority_Ljava_lang_String_Handler ()
		{
			if (cb_raisePriority_Ljava_lang_String_ == null)
				cb_raisePriority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RaisePriority_Ljava_lang_String_);
			return cb_raisePriority_Ljava_lang_String_;
		}

		static bool n_RaisePriority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RaisePriority (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_raisePriority_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='raisePriority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("raisePriority", "(Ljava/lang/String;)Z", "GetRaisePriority_Ljava_lang_String_Handler")]
		public virtual unsafe bool RaisePriority (string p0)
		{
			if (id_raisePriority_Ljava_lang_String_ == IntPtr.Zero)
				id_raisePriority_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "raisePriority", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_raisePriority_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "raisePriority", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMaxConcurrent_I;
#pragma warning disable 0169
		static Delegate GetSetMaxConcurrent_IHandler ()
		{
			if (cb_setMaxConcurrent_I == null)
				cb_setMaxConcurrent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxConcurrent_I);
			return cb_setMaxConcurrent_I;
		}

		static void n_SetMaxConcurrent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Download.Downloader __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Download.Downloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxConcurrent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxConcurrent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='setMaxConcurrent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxConcurrent", "(I)V", "GetSetMaxConcurrent_IHandler")]
		public virtual unsafe void SetMaxConcurrent (int p0)
		{
			if (id_setMaxConcurrent_I == IntPtr.Zero)
				id_setMaxConcurrent_I = JNIEnv.GetMethodID (class_ref, "setMaxConcurrent", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxConcurrent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxConcurrent", "(I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.download']/class[@name='Downloader']/method[@name='uploadLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date']]"
		[Register ("uploadLog", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)Z", "")]
		public static unsafe bool UploadLog (string p0, global::Java.Util.Date p1, global::Java.Util.Date p2)
		{
			if (id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "uploadLog", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
