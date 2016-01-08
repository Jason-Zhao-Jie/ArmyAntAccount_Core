using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/BasicClassTypeUtil", DoNotGenerateAcw=true)]
	public partial class BasicClassTypeUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/BasicClassTypeUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicClassTypeUtil); }
		}

		protected BasicClassTypeUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/constructor[@name='BasicClassTypeUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicClassTypeUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BasicClassTypeUtil)) {
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

		static IntPtr id_createClassByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='createClassByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createClassByName", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CreateClassByName (string p0)
		{
			if (id_createClassByName_Ljava_lang_String_ == IntPtr.Zero)
				id_createClassByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createClassByName", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createClassByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createClassByUni_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='createClassByUni' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createClassByUni", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CreateClassByUni (string p0)
		{
			if (id_createClassByUni_Ljava_lang_String_ == IntPtr.Zero)
				id_createClassByUni_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createClassByUni", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createClassByUni_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getClassTransName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='getClassTransName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClassTransName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetClassTransName (string p0)
		{
			if (id_getClassTransName_Ljava_lang_String_ == IntPtr.Zero)
				id_getClassTransName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getClassTransName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClassTransName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getTypeList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='getTypeList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTypeList", "(Ljava/lang/String;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetTypeList (string p0)
		{
			if (id_getTypeList_Ljava_lang_String_ == IntPtr.Zero)
				id_getTypeList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTypeList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTypeList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getVariableInit_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='getVariableInit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVariableInit", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetVariableInit (string p0, string p1)
		{
			if (id_getVariableInit_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getVariableInit_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVariableInit", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVariableInit_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isBasicType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='isBasicType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBasicType", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsBasicType (string p0)
		{
			if (id_isBasicType_Ljava_lang_String_ == IntPtr.Zero)
				id_isBasicType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isBasicType", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBasicType_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_java2UniType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='java2UniType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("java2UniType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Java2UniType (string p0)
		{
			if (id_java2UniType_Ljava_lang_String_ == IntPtr.Zero)
				id_java2UniType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "java2UniType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_java2UniType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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

		static IntPtr id_transTypeList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='transTypeList' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("transTypeList", "(Ljava/util/ArrayList;)Ljava/lang/String;", "")]
		public static unsafe string TransTypeList (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_transTypeList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_transTypeList_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "transTypeList", "(Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_transTypeList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_uni2JavaType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='BasicClassTypeUtil']/method[@name='uni2JavaType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uni2JavaType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Uni2JavaType (string p0)
		{
			if (id_uni2JavaType_Ljava_lang_String_ == IntPtr.Zero)
				id_uni2JavaType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "uni2JavaType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_uni2JavaType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
