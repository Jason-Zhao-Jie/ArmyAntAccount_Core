using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DoubleField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/DoubleField", DoNotGenerateAcw=true)]
	public partial class DoubleField : global::Com.QQ.Taf.Jce.Dynamic.NumberField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/DoubleField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DoubleField); }
		}

		protected DoubleField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNumber;
#pragma warning disable 0169
		static Delegate GetGetNumberHandler ()
		{
			if (cb_getNumber == null)
				cb_getNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumber);
			return cb_getNumber;
		}

		static IntPtr n_GetNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.DoubleField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.DoubleField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Number);
		}
#pragma warning restore 0169

		static IntPtr id_getNumber;
		public override unsafe global::Java.Lang.Number Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DoubleField']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()Ljava/lang/Number;", "GetGetNumberHandler")]
			get {
				if (id_getNumber == IntPtr.Zero)
					id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()Ljava/lang/Number;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod  (Handle, id_getNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumber", "()Ljava/lang/Number;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get);
			return cb_get;
		}

		static double n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.DoubleField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.DoubleField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get ();
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DoubleField']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()D", "GetGetHandler")]
		public virtual unsafe double Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_get);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()D"));
			} finally {
			}
		}

		static Delegate cb_set_D;
#pragma warning disable 0169
		static Delegate GetSet_DHandler ()
		{
			if (cb_set_D == null)
				cb_set_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_D);
			return cb_set_D;
		}

		static void n_Set_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.QQ.Taf.Jce.Dynamic.DoubleField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.DoubleField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='DoubleField']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set", "(D)V", "GetSet_DHandler")]
		public virtual unsafe void Set (double p0)
		{
			if (id_set_D == IntPtr.Zero)
				id_set_D = JNIEnv.GetMethodID (class_ref, "set", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(D)V"), __args);
			} finally {
			}
		}

	}
}
