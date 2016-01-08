using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/NumberField", DoNotGenerateAcw=true)]
	public abstract partial class NumberField : global::Com.QQ.Taf.Jce.Dynamic.JceField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/NumberField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumberField); }
		}

		protected NumberField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Number);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Number Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()Ljava/lang/Number;", "GetGetNumberHandler")] get;
		}

		static Delegate cb_byteValue;
#pragma warning disable 0169
		static Delegate GetByteValueHandler ()
		{
			if (cb_byteValue == null)
				cb_byteValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_ByteValue);
			return cb_byteValue;
		}

		static sbyte n_ByteValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ByteValue ();
		}
#pragma warning restore 0169

		static IntPtr id_byteValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='byteValue' and count(parameter)=0]"
		[Register ("byteValue", "()B", "GetByteValueHandler")]
		public virtual unsafe sbyte ByteValue ()
		{
			if (id_byteValue == IntPtr.Zero)
				id_byteValue = JNIEnv.GetMethodID (class_ref, "byteValue", "()B");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_byteValue);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "byteValue", "()B"));
			} finally {
			}
		}

		static Delegate cb_doubleValue;
#pragma warning disable 0169
		static Delegate GetDoubleValueHandler ()
		{
			if (cb_doubleValue == null)
				cb_doubleValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_DoubleValue);
			return cb_doubleValue;
		}

		static double n_DoubleValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleValue ();
		}
#pragma warning restore 0169

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "GetDoubleValueHandler")]
		public virtual unsafe double DoubleValue ()
		{
			if (id_doubleValue == IntPtr.Zero)
				id_doubleValue = JNIEnv.GetMethodID (class_ref, "doubleValue", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_doubleValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doubleValue", "()D"));
			} finally {
			}
		}

		static Delegate cb_floatValue;
#pragma warning disable 0169
		static Delegate GetFloatValueHandler ()
		{
			if (cb_floatValue == null)
				cb_floatValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_FloatValue);
			return cb_floatValue;
		}

		static float n_FloatValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FloatValue ();
		}
#pragma warning restore 0169

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "GetFloatValueHandler")]
		public virtual unsafe float FloatValue ()
		{
			if (id_floatValue == IntPtr.Zero)
				id_floatValue = JNIEnv.GetMethodID (class_ref, "floatValue", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_floatValue);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "floatValue", "()F"));
			} finally {
			}
		}

		static Delegate cb_intValue;
#pragma warning disable 0169
		static Delegate GetIntValueHandler ()
		{
			if (cb_intValue == null)
				cb_intValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IntValue);
			return cb_intValue;
		}

		static int n_IntValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntValue ();
		}
#pragma warning restore 0169

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "GetIntValueHandler")]
		public virtual unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_intValue);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intValue", "()I"));
			} finally {
			}
		}

		static Delegate cb_longValue;
#pragma warning disable 0169
		static Delegate GetLongValueHandler ()
		{
			if (cb_longValue == null)
				cb_longValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_LongValue);
			return cb_longValue;
		}

		static long n_LongValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "GetLongValueHandler")]
		public virtual unsafe long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_longValue);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "longValue", "()J"));
			} finally {
			}
		}

		static Delegate cb_shortValue;
#pragma warning disable 0169
		static Delegate GetShortValueHandler ()
		{
			if (cb_shortValue == null)
				cb_shortValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_ShortValue);
			return cb_shortValue;
		}

		static short n_ShortValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.NumberField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.NumberField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShortValue ();
		}
#pragma warning restore 0169

		static IntPtr id_shortValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='shortValue' and count(parameter)=0]"
		[Register ("shortValue", "()S", "GetShortValueHandler")]
		public virtual unsafe short ShortValue ()
		{
			if (id_shortValue == IntPtr.Zero)
				id_shortValue = JNIEnv.GetMethodID (class_ref, "shortValue", "()S");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_shortValue);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shortValue", "()S"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/NumberField", DoNotGenerateAcw=true)]
	internal partial class NumberFieldInvoker : NumberField {

		public NumberFieldInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumberFieldInvoker); }
		}

		static IntPtr id_getNumber;
		public override unsafe global::Java.Lang.Number Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='NumberField']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()Ljava/lang/Number;", "GetGetNumberHandler")]
			get {
				if (id_getNumber == IntPtr.Zero)
					id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()Ljava/lang/Number;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod  (Handle, id_getNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
