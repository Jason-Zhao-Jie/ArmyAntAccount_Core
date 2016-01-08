using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='ITaskRsp']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/ITaskRsp", DoNotGenerateAcw=true)]
	public partial class ITaskRsp : global::Java.Lang.Object {


		static IntPtr msg_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='ITaskRsp']/field[@name='msg']"
		[Register ("msg")]
		public string Msg {
			get {
				if (msg_jfieldId == IntPtr.Zero)
					msg_jfieldId = JNIEnv.GetFieldID (class_ref, "msg", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, msg_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (msg_jfieldId == IntPtr.Zero)
					msg_jfieldId = JNIEnv.GetFieldID (class_ref, "msg", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, msg_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ret_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='ITaskRsp']/field[@name='ret']"
		[Register ("ret")]
		public int Ret {
			get {
				if (ret_jfieldId == IntPtr.Zero)
					ret_jfieldId = JNIEnv.GetFieldID (class_ref, "ret", "I");
				return JNIEnv.GetIntField (Handle, ret_jfieldId);
			}
			set {
				if (ret_jfieldId == IntPtr.Zero)
					ret_jfieldId = JNIEnv.GetFieldID (class_ref, "ret", "I");
				try {
					JNIEnv.SetField (Handle, ret_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/ITaskRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITaskRsp); }
		}

		protected ITaskRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='ITaskRsp']/constructor[@name='ITaskRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ITaskRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ITaskRsp)) {
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

	}
}
