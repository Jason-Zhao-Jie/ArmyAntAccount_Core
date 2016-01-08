using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskCenter']"
	[global::Android.Runtime.Register ("com/tencent/upload/impl/TaskCenter", DoNotGenerateAcw=true)]
	public partial class TaskCenter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/impl/TaskCenter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskCenter); }
		}

		protected TaskCenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskCenter']/constructor[@name='TaskCenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaskCenter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TaskCenter)) {
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

		static IntPtr id_registTask_Ljava_lang_String_Lcom_tencent_upload_task_UploadTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskCenter']/method[@name='registTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.upload.task.UploadTask']]"
		[Register ("registTask", "(Ljava/lang/String;Lcom/tencent/upload/task/UploadTask;)V", "")]
		public static unsafe void RegistTask (string p0, global::Com.Tencent.Upload.Task.UploadTask p1)
		{
			if (id_registTask_Ljava_lang_String_Lcom_tencent_upload_task_UploadTask_ == IntPtr.Zero)
				id_registTask_Ljava_lang_String_Lcom_tencent_upload_task_UploadTask_ = JNIEnv.GetStaticMethodID (class_ref, "registTask", "(Ljava/lang/String;Lcom/tencent/upload/task/UploadTask;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registTask_Ljava_lang_String_Lcom_tencent_upload_task_UploadTask_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_unregistTask_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskCenter']/method[@name='unregistTask' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregistTask", "(Ljava/lang/String;)V", "")]
		public static unsafe void UnregistTask (string p0)
		{
			if (id_unregistTask_Ljava_lang_String_ == IntPtr.Zero)
				id_unregistTask_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unregistTask", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregistTask_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
