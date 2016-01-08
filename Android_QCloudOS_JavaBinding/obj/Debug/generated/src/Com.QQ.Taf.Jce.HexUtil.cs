using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/HexUtil", DoNotGenerateAcw=true)]
	public partial class HexUtil : global::Java.Lang.Object {


		static IntPtr emptybytes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/field[@name='emptybytes']"
		[Register ("emptybytes")]
		public static IList<byte> Emptybytes {
			get {
				if (emptybytes_jfieldId == IntPtr.Zero)
					emptybytes_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "emptybytes", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, emptybytes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/HexUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HexUtil); }
		}

		protected HexUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/constructor[@name='HexUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HexUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HexUtil)) {
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

		static IntPtr id_byte2HexStr_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='byte2HexStr' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("byte2HexStr", "(B)Ljava/lang/String;", "")]
		public static unsafe string Byte2HexStr (sbyte p0)
		{
			if (id_byte2HexStr_B == IntPtr.Zero)
				id_byte2HexStr_B = JNIEnv.GetStaticMethodID (class_ref, "byte2HexStr", "(B)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byte2HexStr_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_bytes2HexStr_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='bytes2HexStr' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytes2HexStr", "([B)Ljava/lang/String;", "")]
		public static unsafe string Bytes2HexStr (byte[] p0)
		{
			if (id_bytes2HexStr_arrayB == IntPtr.Zero)
				id_bytes2HexStr_arrayB = JNIEnv.GetStaticMethodID (class_ref, "bytes2HexStr", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bytes2HexStr_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_char2Byte_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='char2Byte' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("char2Byte", "(C)B", "")]
		public static unsafe sbyte Char2Byte (char p0)
		{
			if (id_char2Byte_C == IntPtr.Zero)
				id_char2Byte_C = JNIEnv.GetStaticMethodID (class_ref, "char2Byte", "(C)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_char2Byte_C, __args);
			} finally {
			}
		}

		static IntPtr id_hexStr2Byte_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='hexStr2Byte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStr2Byte", "(Ljava/lang/String;)B", "")]
		public static unsafe sbyte HexStr2Byte (string p0)
		{
			if (id_hexStr2Byte_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStr2Byte_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStr2Byte", "(Ljava/lang/String;)B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				sbyte __ret = JNIEnv.CallStaticByteMethod  (class_ref, id_hexStr2Byte_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_hexStr2Bytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='hexStr2Bytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStr2Bytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexStr2Bytes (string p0)
		{
			if (id_hexStr2Bytes_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStr2Bytes_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStr2Bytes", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStr2Bytes_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='HexUtil']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
