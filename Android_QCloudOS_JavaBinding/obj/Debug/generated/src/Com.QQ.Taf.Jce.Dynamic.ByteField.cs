using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ByteField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/ByteField", DoNotGenerateAcw=true)]
	public sealed partial class ByteField : global::Com.QQ.Taf.Jce.Dynamic.NumberField {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/ByteField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteField); }
		}

		internal ByteField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getNumber;
		public override unsafe global::Java.Lang.Number Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ByteField']/method[@name='getNumber' and count(parameter)=0]"
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

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ByteField']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()B", "")]
		public unsafe sbyte Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()B");
			try {
				return JNIEnv.CallByteMethod  (Handle, id_get);
			} finally {
			}
		}

		static IntPtr id_set_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='ByteField']/method[@name='set' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("set", "(B)V", "")]
		public unsafe void Set (sbyte p0)
		{
			if (id_set_B == IntPtr.Zero)
				id_set_B = JNIEnv.GetMethodID (class_ref, "set", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_set_B, __args);
			} finally {
			}
		}

	}
}
