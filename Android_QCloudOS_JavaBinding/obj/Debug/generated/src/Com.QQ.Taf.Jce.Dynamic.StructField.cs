using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='StructField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/StructField", DoNotGenerateAcw=true)]
	public partial class StructField : global::Com.QQ.Taf.Jce.Dynamic.JceField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/StructField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StructField); }
		}

		protected StructField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.StructField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.StructField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='StructField']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()[Lcom/qq/taf/jce/dynamic/JceField;", "GetGetHandler")]
		public virtual unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField[] Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()[Lcom/qq/taf/jce/dynamic/JceField;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.QQ.Taf.Jce.Dynamic.JceField[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.Dynamic.JceField));
				else
					return (global::Com.QQ.Taf.Jce.Dynamic.JceField[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()[Lcom/qq/taf/jce/dynamic/JceField;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.Dynamic.JceField));
			} finally {
			}
		}

		static Delegate cb_getFieldByTag_I;
#pragma warning disable 0169
		static Delegate GetGetFieldByTag_IHandler ()
		{
			if (cb_getFieldByTag_I == null)
				cb_getFieldByTag_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFieldByTag_I);
			return cb_getFieldByTag_I;
		}

		static IntPtr n_GetFieldByTag_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Taf.Jce.Dynamic.StructField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.StructField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFieldByTag (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFieldByTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='StructField']/method[@name='getFieldByTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFieldByTag", "(I)Lcom/qq/taf/jce/dynamic/JceField;", "GetGetFieldByTag_IHandler")]
		public virtual unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField GetFieldByTag (int p0)
		{
			if (id_getFieldByTag_I == IntPtr.Zero)
				id_getFieldByTag_I = JNIEnv.GetMethodID (class_ref, "getFieldByTag", "(I)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallObjectMethod  (Handle, id_getFieldByTag_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldByTag", "(I)Lcom/qq/taf/jce/dynamic/JceField;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setByTag_ILcom_qq_taf_jce_dynamic_JceField_;
#pragma warning disable 0169
		static Delegate GetSetByTag_ILcom_qq_taf_jce_dynamic_JceField_Handler ()
		{
			if (cb_setByTag_ILcom_qq_taf_jce_dynamic_JceField_ == null)
				cb_setByTag_ILcom_qq_taf_jce_dynamic_JceField_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetByTag_ILcom_qq_taf_jce_dynamic_JceField_);
			return cb_setByTag_ILcom_qq_taf_jce_dynamic_JceField_;
		}

		static bool n_SetByTag_ILcom_qq_taf_jce_dynamic_JceField_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.QQ.Taf.Jce.Dynamic.StructField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.StructField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.Dynamic.JceField p1 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetByTag (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setByTag_ILcom_qq_taf_jce_dynamic_JceField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='StructField']/method[@name='setByTag' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qq.taf.jce.dynamic.JceField']]"
		[Register ("setByTag", "(ILcom/qq/taf/jce/dynamic/JceField;)Z", "GetSetByTag_ILcom_qq_taf_jce_dynamic_JceField_Handler")]
		public virtual unsafe bool SetByTag (int p0, global::Com.QQ.Taf.Jce.Dynamic.JceField p1)
		{
			if (id_setByTag_ILcom_qq_taf_jce_dynamic_JceField_ == IntPtr.Zero)
				id_setByTag_ILcom_qq_taf_jce_dynamic_JceField_ = JNIEnv.GetMethodID (class_ref, "setByTag", "(ILcom/qq/taf/jce/dynamic/JceField;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_setByTag_ILcom_qq_taf_jce_dynamic_JceField_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setByTag", "(ILcom/qq/taf/jce/dynamic/JceField;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
