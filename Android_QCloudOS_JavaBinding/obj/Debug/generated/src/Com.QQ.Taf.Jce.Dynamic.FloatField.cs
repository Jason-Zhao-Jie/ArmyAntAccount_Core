using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='FloatField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/FloatField", DoNotGenerateAcw=true)]
	public partial class FloatField : global::Com.QQ.Taf.Jce.Dynamic.NumberField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/FloatField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatField); }
		}

		protected FloatField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.QQ.Taf.Jce.Dynamic.FloatField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.FloatField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Number);
		}
#pragma warning restore 0169

		static IntPtr id_getNumber;
		public override unsafe global::Java.Lang.Number Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='FloatField']/method[@name='getNumber' and count(parameter)=0]"
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
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Get);
			return cb_get;
		}

		static float n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.FloatField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.FloatField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get ();
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='FloatField']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()F", "GetGetHandler")]
		public virtual unsafe float Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_get);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()F"));
			} finally {
			}
		}

		static Delegate cb_set_F;
#pragma warning disable 0169
		static Delegate GetSet_FHandler ()
		{
			if (cb_set_F == null)
				cb_set_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_Set_F);
			return cb_set_F;
		}

		static void n_Set_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.QQ.Taf.Jce.Dynamic.FloatField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.FloatField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='FloatField']/method[@name='set' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("set", "(F)V", "GetSet_FHandler")]
		public virtual unsafe void Set (float p0)
		{
			if (id_set_F == IntPtr.Zero)
				id_set_F = JNIEnv.GetMethodID (class_ref, "set", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(F)V"), __args);
			} finally {
			}
		}

	}
}
