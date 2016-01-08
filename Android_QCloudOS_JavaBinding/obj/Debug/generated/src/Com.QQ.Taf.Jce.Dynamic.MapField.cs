using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/MapField", DoNotGenerateAcw=true)]
	public sealed partial class MapField : global::Com.QQ.Taf.Jce.Dynamic.JceField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/MapField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapField); }
		}

		internal MapField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getKey_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='getKey' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getKey", "(I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField GetKey (int p0)
		{
			if (id_getKey_I == IntPtr.Zero)
				id_getKey_I = JNIEnv.GetMethodID (class_ref, "getKey", "(I)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallObjectMethod  (Handle, id_getKey_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getKeys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='getKeys' and count(parameter)=0]"
		[Register ("getKeys", "()[Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField[] GetKeys ()
		{
			if (id_getKeys == IntPtr.Zero)
				id_getKeys = JNIEnv.GetMethodID (class_ref, "getKeys", "()[Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				return (global::Com.QQ.Taf.Jce.Dynamic.JceField[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getKeys), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.Dynamic.JceField));
			} finally {
			}
		}

		static IntPtr id_getValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField GetValue (int p0)
		{
			if (id_getValue_I == IntPtr.Zero)
				id_getValue_I = JNIEnv.GetMethodID (class_ref, "getValue", "(I)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallObjectMethod  (Handle, id_getValue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				return (global::Com.QQ.Taf.Jce.Dynamic.JceField[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.Dynamic.JceField));
			} finally {
			}
		}

		static IntPtr id_setKey_ILcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='setKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qq.taf.jce.dynamic.JceField']]"
		[Register ("setKey", "(ILcom/qq/taf/jce/dynamic/JceField;)V", "")]
		public unsafe void SetKey (int p0, global::Com.QQ.Taf.Jce.Dynamic.JceField p1)
		{
			if (id_setKey_ILcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_setKey_ILcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "setKey", "(ILcom/qq/taf/jce/dynamic/JceField;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setKey_ILcom_qq_taf_jce_dynamic_JceField_, __args);
			} finally {
			}
		}

		static IntPtr id_setValue_ILcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qq.taf.jce.dynamic.JceField']]"
		[Register ("setValue", "(ILcom/qq/taf/jce/dynamic/JceField;)V", "")]
		public unsafe void SetValue (int p0, global::Com.QQ.Taf.Jce.Dynamic.JceField p1)
		{
			if (id_setValue_ILcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_setValue_ILcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "setValue", "(ILcom/qq/taf/jce/dynamic/JceField;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setValue_ILcom_qq_taf_jce_dynamic_JceField_, __args);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='MapField']/method[@name='size' and count(parameter)=0]"
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
