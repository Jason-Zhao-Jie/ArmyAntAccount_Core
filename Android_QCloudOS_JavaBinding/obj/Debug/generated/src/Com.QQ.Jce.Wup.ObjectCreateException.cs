using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='ObjectCreateException']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/ObjectCreateException", DoNotGenerateAcw=true)]
	public partial class ObjectCreateException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/ObjectCreateException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectCreateException); }
		}

		protected ObjectCreateException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='ObjectCreateException']/constructor[@name='ObjectCreateException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public unsafe ObjectCreateException (global::Java.Lang.Exception p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ObjectCreateException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Exception;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Exception;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

	}
}
