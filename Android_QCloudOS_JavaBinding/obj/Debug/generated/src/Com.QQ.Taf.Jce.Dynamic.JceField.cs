using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce.Dynamic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/dynamic/JceField", DoNotGenerateAcw=true)]
	public partial class JceField : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/dynamic/JceField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceField); }
		}

		protected JceField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTag);
			return cb_getTag;
		}

		static int n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.Dynamic.JceField __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tag;
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe int Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()I", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTag);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_create_BI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='int']]"
		[Register ("create", "(BI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (sbyte p0, int p1)
		{
			if (id_create_BI == IntPtr.Zero)
				id_create_BI = JNIEnv.GetStaticMethodID (class_ref, "create", "(BI)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_BI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("create", "([BI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (byte[] p0, int p1)
		{
			if (id_create_arrayBI == IntPtr.Zero)
				id_create_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "create", "([BI)Lcom/qq/taf/jce/dynamic/JceField;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.Dynamic.JceField __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_create_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("create", "(DI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (double p0, int p1)
		{
			if (id_create_DI == IntPtr.Zero)
				id_create_DI = JNIEnv.GetStaticMethodID (class_ref, "create", "(DI)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_DI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("create", "(FI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (float p0, int p1)
		{
			if (id_create_FI == IntPtr.Zero)
				id_create_FI = JNIEnv.GetStaticMethodID (class_ref, "create", "(FI)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_FI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("create", "(II)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (int p0, int p1)
		{
			if (id_create_II == IntPtr.Zero)
				id_create_II = JNIEnv.GetStaticMethodID (class_ref, "create", "(II)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("create", "(Ljava/lang/String;I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (string p0, int p1)
		{
			if (id_create_Ljava_lang_String_I == IntPtr.Zero)
				id_create_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;I)Lcom/qq/taf/jce/dynamic/JceField;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.Dynamic.JceField __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_create_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("create", "(JI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (long p0, int p1)
		{
			if (id_create_JI == IntPtr.Zero)
				id_create_JI = JNIEnv.GetStaticMethodID (class_ref, "create", "(JI)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_JI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_SI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='create' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='int']]"
		[Register ("create", "(SI)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField Create (short p0, int p1)
		{
			if (id_create_SI == IntPtr.Zero)
				id_create_SI = JNIEnv.GetStaticMethodID (class_ref, "create", "(SI)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_SI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createList_arrayLcom_qq_taf_jce_dynamic_JceField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='createList' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.dynamic.JceField[]'] and parameter[2][@type='int']]"
		[Register ("createList", "([Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField CreateList (global::Com.QQ.Taf.Jce.Dynamic.JceField[] p0, int p1)
		{
			if (id_createList_arrayLcom_qq_taf_jce_dynamic_JceField_I == IntPtr.Zero)
				id_createList_arrayLcom_qq_taf_jce_dynamic_JceField_I = JNIEnv.GetStaticMethodID (class_ref, "createList", "([Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.Dynamic.JceField __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createList_arrayLcom_qq_taf_jce_dynamic_JceField_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_createMap_arrayLcom_qq_taf_jce_dynamic_JceField_arrayLcom_qq_taf_jce_dynamic_JceField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='createMap' and count(parameter)=3 and parameter[1][@type='com.qq.taf.jce.dynamic.JceField[]'] and parameter[2][@type='com.qq.taf.jce.dynamic.JceField[]'] and parameter[3][@type='int']]"
		[Register ("createMap", "([Lcom/qq/taf/jce/dynamic/JceField;[Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField CreateMap (global::Com.QQ.Taf.Jce.Dynamic.JceField[] p0, global::Com.QQ.Taf.Jce.Dynamic.JceField[] p1, int p2)
		{
			if (id_createMap_arrayLcom_qq_taf_jce_dynamic_JceField_arrayLcom_qq_taf_jce_dynamic_JceField_I == IntPtr.Zero)
				id_createMap_arrayLcom_qq_taf_jce_dynamic_JceField_arrayLcom_qq_taf_jce_dynamic_JceField_I = JNIEnv.GetStaticMethodID (class_ref, "createMap", "([Lcom/qq/taf/jce/dynamic/JceField;[Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.QQ.Taf.Jce.Dynamic.JceField __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMap_arrayLcom_qq_taf_jce_dynamic_JceField_arrayLcom_qq_taf_jce_dynamic_JceField_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_createStruct_arrayLcom_qq_taf_jce_dynamic_JceField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='createStruct' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.dynamic.JceField[]'] and parameter[2][@type='int']]"
		[Register ("createStruct", "([Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField CreateStruct (global::Com.QQ.Taf.Jce.Dynamic.JceField[] p0, int p1)
		{
			if (id_createStruct_arrayLcom_qq_taf_jce_dynamic_JceField_I == IntPtr.Zero)
				id_createStruct_arrayLcom_qq_taf_jce_dynamic_JceField_I = JNIEnv.GetStaticMethodID (class_ref, "createStruct", "([Lcom/qq/taf/jce/dynamic/JceField;I)Lcom/qq/taf/jce/dynamic/JceField;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.QQ.Taf.Jce.Dynamic.JceField __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createStruct_arrayLcom_qq_taf_jce_dynamic_JceField_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_createZero_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce.dynamic']/class[@name='JceField']/method[@name='createZero' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createZero", "(I)Lcom/qq/taf/jce/dynamic/JceField;", "")]
		public static unsafe global::Com.QQ.Taf.Jce.Dynamic.JceField CreateZero (int p0)
		{
			if (id_createZero_I == IntPtr.Zero)
				id_createZero_I = JNIEnv.GetStaticMethodID (class_ref, "createZero", "(I)Lcom/qq/taf/jce/dynamic/JceField;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.Dynamic.JceField> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createZero_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
