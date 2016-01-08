using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/JceDisplayer", DoNotGenerateAcw=true)]
	public sealed partial class JceDisplayer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/JceDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceDisplayer); }
		}

		internal JceDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_StringBuilder_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/constructor[@name='JceDisplayer' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/StringBuilder;I)V", "")]
		public unsafe JceDisplayer (global::Java.Lang.StringBuilder p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JceDisplayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/StringBuilder;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/StringBuilder;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_StringBuilder_I == IntPtr.Zero)
					id_ctor_Ljava_lang_StringBuilder_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/StringBuilder;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_StringBuilder_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_StringBuilder_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/constructor[@name='JceDisplayer' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register (".ctor", "(Ljava/lang/StringBuilder;)V", "")]
		public unsafe JceDisplayer (global::Java.Lang.StringBuilder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JceDisplayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/StringBuilder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/StringBuilder;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_StringBuilder_ == IntPtr.Zero)
					id_ctor_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/StringBuilder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_StringBuilder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_StringBuilder_, __args);
			} finally {
			}
		}

		static IntPtr id_display_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (global::Java.Lang.Object p0, string p1)
		{
			if (id_display_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayLjava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([Ljava/lang/Object;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (global::Java.Lang.Object[] p0, string p1)
		{
			if (id_display_arrayLjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_display_arrayLjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([Ljava/lang/Object;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayLjava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(ZLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (bool p0, string p1)
		{
			if (id_display_ZLjava_lang_String_ == IntPtr.Zero)
				id_display_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(ZLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_ZLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_BLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(BLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (sbyte p0, string p1)
		{
			if (id_display_BLjava_lang_String_ == IntPtr.Zero)
				id_display_BLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(BLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_BLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([BLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (byte[] p0, string p1)
		{
			if (id_display_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_display_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([BLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_CLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(CLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (char p0, string p1)
		{
			if (id_display_CLjava_lang_String_ == IntPtr.Zero)
				id_display_CLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(CLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_CLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayCLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([CLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (char[] p0, string p1)
		{
			if (id_display_arrayCLjava_lang_String_ == IntPtr.Zero)
				id_display_arrayCLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([CLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayCLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_Lcom_qq_taf_jce_JceStruct_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.JceStruct'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Lcom/qq/taf/jce/JceStruct;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (global::Com.QQ.Taf.Jce.JceStruct p0, string p1)
		{
			if (id_display_Lcom_qq_taf_jce_JceStruct_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Lcom_qq_taf_jce_JceStruct_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Lcom/qq/taf/jce/JceStruct;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_Lcom_qq_taf_jce_JceStruct_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(DLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (double p0, string p1)
		{
			if (id_display_DLjava_lang_String_ == IntPtr.Zero)
				id_display_DLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(DLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_DLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([DLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (double[] p0, string p1)
		{
			if (id_display_arrayDLjava_lang_String_ == IntPtr.Zero)
				id_display_arrayDLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([DLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_FLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(FLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (float p0, string p1)
		{
			if (id_display_FLjava_lang_String_ == IntPtr.Zero)
				id_display_FLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(FLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_FLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayFLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([FLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (float[] p0, string p1)
		{
			if (id_display_arrayFLjava_lang_String_ == IntPtr.Zero)
				id_display_arrayFLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([FLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayFLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(ILjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (int p0, string p1)
		{
			if (id_display_ILjava_lang_String_ == IntPtr.Zero)
				id_display_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(ILjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([ILjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (int[] p0, string p1)
		{
			if (id_display_arrayILjava_lang_String_ == IntPtr.Zero)
				id_display_arrayILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([ILjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/lang/String;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (string p0, string p1)
		{
			if (id_display_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/lang/String;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_Ljava_util_Collection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/util/Collection;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (global::System.Collections.ICollection p0, string p1)
		{
			if (id_display_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/util/Collection;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_Ljava_util_Collection_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;K, V&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/util/Map;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (global::System.Collections.IDictionary p0, string p1)
		{
			if (id_display_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/util/Map;Ljava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(JLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (long p0, string p1)
		{
			if (id_display_JLjava_lang_String_ == IntPtr.Zero)
				id_display_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(JLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arrayJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([JLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (long[] p0, string p1)
		{
			if (id_display_arrayJLjava_lang_String_ == IntPtr.Zero)
				id_display_arrayJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([JLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arrayJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_SLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(SLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (short p0, string p1)
		{
			if (id_display_SLjava_lang_String_ == IntPtr.Zero)
				id_display_SLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(SLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_SLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_display_arraySLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "([SLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer Display (short[] p0, string p1)
		{
			if (id_display_arraySLjava_lang_String_ == IntPtr.Zero)
				id_display_arraySLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "([SLjava/lang/String;)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_display_arraySLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_displaySimple_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(Ljava/lang/Object;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (global::Java.Lang.Object p0, bool p1)
		{
			if (id_displaySimple_Ljava_lang_Object_Z == IntPtr.Zero)
				id_displaySimple_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Ljava/lang/Object;Z)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_Ljava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_displaySimple_arrayLjava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([Ljava/lang/Object;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (global::Java.Lang.Object[] p0, bool p1)
		{
			if (id_displaySimple_arrayLjava_lang_Object_Z == IntPtr.Zero)
				id_displaySimple_arrayLjava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "([Ljava/lang/Object;Z)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayLjava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(ZZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (bool p0, bool p1)
		{
			if (id_displaySimple_ZZ == IntPtr.Zero)
				id_displaySimple_ZZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(ZZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_ZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_BZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(BZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (sbyte p0, bool p1)
		{
			if (id_displaySimple_BZ == IntPtr.Zero)
				id_displaySimple_BZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(BZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_BZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([BZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (byte[] p0, bool p1)
		{
			if (id_displaySimple_arrayBZ == IntPtr.Zero)
				id_displaySimple_arrayBZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([BZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayBZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_CZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(CZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (char p0, bool p1)
		{
			if (id_displaySimple_CZ == IntPtr.Zero)
				id_displaySimple_CZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(CZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_CZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayCZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([CZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (char[] p0, bool p1)
		{
			if (id_displaySimple_arrayCZ == IntPtr.Zero)
				id_displaySimple_arrayCZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([CZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayCZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_Lcom_qq_taf_jce_JceStruct_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.JceStruct'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(Lcom/qq/taf/jce/JceStruct;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (global::Com.QQ.Taf.Jce.JceStruct p0, bool p1)
		{
			if (id_displaySimple_Lcom_qq_taf_jce_JceStruct_Z == IntPtr.Zero)
				id_displaySimple_Lcom_qq_taf_jce_JceStruct_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Lcom/qq/taf/jce/JceStruct;Z)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_Lcom_qq_taf_jce_JceStruct_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_displaySimple_DZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(DZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (double p0, bool p1)
		{
			if (id_displaySimple_DZ == IntPtr.Zero)
				id_displaySimple_DZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(DZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_DZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([DZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (double[] p0, bool p1)
		{
			if (id_displaySimple_arrayDZ == IntPtr.Zero)
				id_displaySimple_arrayDZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([DZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayDZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_FZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(FZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (float p0, bool p1)
		{
			if (id_displaySimple_FZ == IntPtr.Zero)
				id_displaySimple_FZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(FZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_FZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([FZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (float[] p0, bool p1)
		{
			if (id_displaySimple_arrayFZ == IntPtr.Zero)
				id_displaySimple_arrayFZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([FZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayFZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(IZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (int p0, bool p1)
		{
			if (id_displaySimple_IZ == IntPtr.Zero)
				id_displaySimple_IZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(IZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([IZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (int[] p0, bool p1)
		{
			if (id_displaySimple_arrayIZ == IntPtr.Zero)
				id_displaySimple_arrayIZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([IZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(Ljava/lang/String;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (string p0, bool p1)
		{
			if (id_displaySimple_Ljava_lang_String_Z == IntPtr.Zero)
				id_displaySimple_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Ljava/lang/String;Z)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_displaySimple_Ljava_util_Collection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;T&gt;'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(Ljava/util/Collection;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (global::System.Collections.ICollection p0, bool p1)
		{
			if (id_displaySimple_Ljava_util_Collection_Z == IntPtr.Zero)
				id_displaySimple_Ljava_util_Collection_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Ljava/util/Collection;Z)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_Ljava_util_Collection_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_displaySimple_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;K, V&gt;'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(Ljava/util/Map;Z)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (global::System.Collections.IDictionary p0, bool p1)
		{
			if (id_displaySimple_Ljava_util_Map_Z == IntPtr.Zero)
				id_displaySimple_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Ljava/util/Map;Z)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_Ljava_util_Map_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_displaySimple_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(JZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (long p0, bool p1)
		{
			if (id_displaySimple_JZ == IntPtr.Zero)
				id_displaySimple_JZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(JZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_JZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arrayJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([JZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (long[] p0, bool p1)
		{
			if (id_displaySimple_arrayJZ == IntPtr.Zero)
				id_displaySimple_arrayJZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([JZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arrayJZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_displaySimple_SZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "(SZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (short p0, bool p1)
		{
			if (id_displaySimple_SZ == IntPtr.Zero)
				id_displaySimple_SZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "(SZ)Lcom/qq/taf/jce/JceDisplayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_SZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_displaySimple_arraySZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='boolean']]"
		[Register ("displaySimple", "([SZ)Lcom/qq/taf/jce/JceDisplayer;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceDisplayer DisplaySimple (short[] p0, bool p1)
		{
			if (id_displaySimple_arraySZ == IntPtr.Zero)
				id_displaySimple_arraySZ = JNIEnv.GetMethodID (class_ref, "displaySimple", "([SZ)Lcom/qq/taf/jce/JceDisplayer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.JceDisplayer __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_displaySimple_arraySZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceDisplayer']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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
