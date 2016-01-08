using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/ListField", DoNotGenerateAcw=true)]
	public sealed partial class ListField : global::Com.QQ.Taf.Jce.Dynamic.JceField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/ListField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListField); }
		}

		internal ListField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()[Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField[] Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()[Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				return (global::Com.QQ.Taf.Jce.Dynamic.JceField[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.Dynamic.JceField));
			} finally {
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallObjectMethod  (Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_set_arrayLcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.dynamic.JceField[]']]"
		[Register ("set", "([Lcom/qq/taf/jce/dynamic/JceField;)V", "")]
		public unsafe void Set (global::Com.QQ.Taf.Jce.Dynamic.JceField[] p0)
		{
			if (id_set_arrayLcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_set_arrayLcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "set", "([Lcom/qq/taf/jce/dynamic/JceField;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_set_arrayLcom_qq_taf_jce_dynamic_JceField_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_set_ILcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qq.taf.jce.dynamic.JceField']]"
		[Register ("set", "(ILcom/qq/taf/jce/dynamic/JceField;)V", "")]
		public unsafe void Set (int p0, global::Com.QQ.Taf.Jce.Dynamic.JceField p1)
		{
			if (id_set_ILcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_set_ILcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "set", "(ILcom/qq/taf/jce/dynamic/JceField;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_set_ILcom_qq_taf_jce_dynamic_JceField_, __args);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ListField']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_size);
			} finally {
			}
		}

	}
}
