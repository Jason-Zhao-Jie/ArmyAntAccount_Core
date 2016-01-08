using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DynamicOutputStream']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/DynamicOutputStream", DoNotGenerateAcw=true)]
	public sealed partial class DynamicOutputStream : global::Com.QQ.Taf.Jce.JceOutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/DynamicOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamicOutputStream); }
		}

		internal DynamicOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DynamicOutputStream']/constructor[@name='DynamicOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DynamicOutputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DynamicOutputStream)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DynamicOutputStream']/constructor[@name='DynamicOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DynamicOutputStream (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DynamicOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DynamicOutputStream']/constructor[@name='DynamicOutputStream' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe DynamicOutputStream (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DynamicOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_write_Lcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DynamicOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.dynamic.JceField']]"
		[Register ("write", "(Lcom/qq/taf/jce/dynamic/JceField;)V", "")]
		public unsafe void Write (global::Com.QQ.Taf.Jce.Dynamic.JceField p0)
		{
			if (id_write_Lcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_write_Lcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/qq/taf/jce/dynamic/JceField;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_qq_taf_jce_dynamic_JceField_, __args);
			} finally {
			}
		}

	}
}
