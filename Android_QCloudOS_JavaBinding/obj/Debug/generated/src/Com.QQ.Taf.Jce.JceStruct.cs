using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/JceStruct", DoNotGenerateAcw=true)]
	public abstract partial class JceStruct : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='BYTE']"
		[Register ("BYTE")]
		public const sbyte Byte = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='DOUBLE']"
		[Register ("DOUBLE")]
		public const sbyte Double = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='FLOAT']"
		[Register ("FLOAT")]
		public const sbyte Float = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='INT']"
		[Register ("INT")]
		public const sbyte Int = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='JCE_MAX_STRING_LENGTH']"
		[Register ("JCE_MAX_STRING_LENGTH")]
		public const int JceMaxStringLength = (int) 104857600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='LIST']"
		[Register ("LIST")]
		public const sbyte List = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='LONG']"
		[Register ("LONG")]
		public const sbyte Long = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='MAP']"
		[Register ("MAP")]
		public const sbyte Map = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='SHORT']"
		[Register ("SHORT")]
		public const sbyte Short = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='SIMPLE_LIST']"
		[Register ("SIMPLE_LIST")]
		public const sbyte SimpleList = (sbyte) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='STRING1']"
		[Register ("STRING1")]
		public const sbyte String1 = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='STRING4']"
		[Register ("STRING4")]
		public const sbyte String4 = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='STRUCT_BEGIN']"
		[Register ("STRUCT_BEGIN")]
		public const sbyte StructBegin = (sbyte) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='STRUCT_END']"
		[Register ("STRUCT_END")]
		public const sbyte StructEnd = (sbyte) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/field[@name='ZERO_TAG']"
		[Register ("ZERO_TAG")]
		public const sbyte ZeroTag = (sbyte) 12;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/JceStruct", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceStruct); }
		}

		protected JceStruct (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/constructor[@name='JceStruct' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JceStruct ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JceStruct)) {
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

		static Delegate cb_containField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainField_Ljava_lang_String_Handler ()
		{
			if (cb_containField_Ljava_lang_String_ == null)
				cb_containField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainField_Ljava_lang_String_);
			return cb_containField_Ljava_lang_String_;
		}

		static bool n_ContainField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainField (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containField_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='containField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containField", "(Ljava/lang/String;)Z", "GetContainField_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainField (string p0)
		{
			if (id_containField_Ljava_lang_String_ == IntPtr.Zero)
				id_containField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containField", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_containField_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containField", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_display_Ljava_lang_StringBuilder_I;
#pragma warning disable 0169
		static Delegate GetDisplay_Ljava_lang_StringBuilder_IHandler ()
		{
			if (cb_display_Ljava_lang_StringBuilder_I == null)
				cb_display_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Display_Ljava_lang_StringBuilder_I);
			return cb_display_Ljava_lang_StringBuilder_I;
		}

		static void n_Display_Ljava_lang_StringBuilder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.StringBuilder p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Display (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_display_Ljava_lang_StringBuilder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int']]"
		[Register ("display", "(Ljava/lang/StringBuilder;I)V", "GetDisplay_Ljava_lang_StringBuilder_IHandler")]
		public virtual unsafe void Display (global::Java.Lang.StringBuilder p0, int p1)
		{
			if (id_display_Ljava_lang_StringBuilder_I == IntPtr.Zero)
				id_display_Ljava_lang_StringBuilder_I = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/lang/StringBuilder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_display_Ljava_lang_StringBuilder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "display", "(Ljava/lang/StringBuilder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_displaySimple_Ljava_lang_StringBuilder_I;
#pragma warning disable 0169
		static Delegate GetDisplaySimple_Ljava_lang_StringBuilder_IHandler ()
		{
			if (cb_displaySimple_Ljava_lang_StringBuilder_I == null)
				cb_displaySimple_Ljava_lang_StringBuilder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DisplaySimple_Ljava_lang_StringBuilder_I);
			return cb_displaySimple_Ljava_lang_StringBuilder_I;
		}

		static void n_DisplaySimple_Ljava_lang_StringBuilder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.StringBuilder p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisplaySimple (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displaySimple_Ljava_lang_StringBuilder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='displaySimple' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int']]"
		[Register ("displaySimple", "(Ljava/lang/StringBuilder;I)V", "GetDisplaySimple_Ljava_lang_StringBuilder_IHandler")]
		public virtual unsafe void DisplaySimple (global::Java.Lang.StringBuilder p0, int p1)
		{
			if (id_displaySimple_Ljava_lang_StringBuilder_I == IntPtr.Zero)
				id_displaySimple_Ljava_lang_StringBuilder_I = JNIEnv.GetMethodID (class_ref, "displaySimple", "(Ljava/lang/StringBuilder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displaySimple_Ljava_lang_StringBuilder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displaySimple", "(Ljava/lang/StringBuilder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getFieldByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFieldByName_Ljava_lang_String_Handler ()
		{
			if (cb_getFieldByName_Ljava_lang_String_ == null)
				cb_getFieldByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFieldByName_Ljava_lang_String_);
			return cb_getFieldByName_Ljava_lang_String_;
		}

		static IntPtr n_GetFieldByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFieldByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='getFieldByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFieldByName", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetFieldByName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetFieldByName (string p0)
		{
			if (id_getFieldByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getFieldByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFieldByName", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFieldByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldByName", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_newInit;
#pragma warning disable 0169
		static Delegate GetNewInitHandler ()
		{
			if (cb_newInit == null)
				cb_newInit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewInit);
			return cb_newInit;
		}

		static IntPtr n_NewInit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInit ());
		}
#pragma warning restore 0169

		static IntPtr id_newInit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='newInit' and count(parameter)=0]"
		[Register ("newInit", "()Lcom/qq/taf/jce/JceStruct;", "GetNewInitHandler")]
		public virtual unsafe global::Com.QQ.Taf.Jce.JceStruct NewInit ()
		{
			if (id_newInit == IntPtr.Zero)
				id_newInit = JNIEnv.GetMethodID (class_ref, "newInit", "()Lcom/qq/taf/jce/JceStruct;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (JNIEnv.CallObjectMethod  (Handle, id_newInit), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newInit", "()Lcom/qq/taf/jce/JceStruct;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readFrom_Lcom_qq_taf_jce_JceInputStream_;
#pragma warning disable 0169
		static Delegate GetReadFrom_Lcom_qq_taf_jce_JceInputStream_Handler ()
		{
			if (cb_readFrom_Lcom_qq_taf_jce_JceInputStream_ == null)
				cb_readFrom_Lcom_qq_taf_jce_JceInputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadFrom_Lcom_qq_taf_jce_JceInputStream_);
			return cb_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		}

		static void n_ReadFrom_Lcom_qq_taf_jce_JceInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.JceInputStream p0 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFrom (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
		[Register ("readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V", "GetReadFrom_Lcom_qq_taf_jce_JceInputStream_Handler")]
		public abstract void ReadFrom (global::Com.QQ.Taf.Jce.JceInputStream p0);

		static Delegate cb_recyle;
#pragma warning disable 0169
		static Delegate GetRecyleHandler ()
		{
			if (cb_recyle == null)
				cb_recyle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recyle);
			return cb_recyle;
		}

		static void n_Recyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recyle ();
		}
#pragma warning restore 0169

		static IntPtr id_recyle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='recyle' and count(parameter)=0]"
		[Register ("recyle", "()V", "GetRecyleHandler")]
		public virtual unsafe void Recyle ()
		{
			if (id_recyle == IntPtr.Zero)
				id_recyle = JNIEnv.GetMethodID (class_ref, "recyle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recyle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recyle", "()V"));
			} finally {
			}
		}

		static Delegate cb_setFieldByName_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetFieldByName_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setFieldByName_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setFieldByName_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFieldByName_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setFieldByName_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetFieldByName_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFieldByName (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFieldByName_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='setFieldByName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setFieldByName", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetFieldByName_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetFieldByName (string p0, global::Java.Lang.Object p1)
		{
			if (id_setFieldByName_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setFieldByName_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setFieldByName", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFieldByName_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFieldByName", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_toByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_toByteArray_Ljava_lang_String_ == null)
				cb_toByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToByteArray_Ljava_lang_String_);
			return cb_toByteArray_Ljava_lang_String_;
		}

		static IntPtr n_ToByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ToByteArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toByteArray", "(Ljava/lang/String;)[B", "GetToByteArray_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] ToByteArray (string p0)
		{
			if (id_toByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_toByteArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toDisplaySimpleString_Lcom_qq_taf_jce_JceStruct_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='toDisplaySimpleString' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceStruct']]"
		[Register ("toDisplaySimpleString", "(Lcom/qq/taf/jce/JceStruct;)Ljava/lang/String;", "")]
		public static unsafe string ToDisplaySimpleString (global::Com.QQ.Taf.Jce.JceStruct p0)
		{
			if (id_toDisplaySimpleString_Lcom_qq_taf_jce_JceStruct_ == IntPtr.Zero)
				id_toDisplaySimpleString_Lcom_qq_taf_jce_JceStruct_ = JNIEnv.GetStaticMethodID (class_ref, "toDisplaySimpleString", "(Lcom/qq/taf/jce/JceStruct;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toDisplaySimpleString_Lcom_qq_taf_jce_JceStruct_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeTo_Lcom_qq_taf_jce_JceOutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Lcom_qq_taf_jce_JceOutputStream_Handler ()
		{
			if (cb_writeTo_Lcom_qq_taf_jce_JceOutputStream_ == null)
				cb_writeTo_Lcom_qq_taf_jce_JceOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Lcom_qq_taf_jce_JceOutputStream_);
			return cb_writeTo_Lcom_qq_taf_jce_JceOutputStream_;
		}

		static void n_WriteTo_Lcom_qq_taf_jce_JceOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceStruct __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.JceOutputStream p0 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
		[Register ("writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V", "GetWriteTo_Lcom_qq_taf_jce_JceOutputStream_Handler")]
		public abstract void WriteTo (global::Com.QQ.Taf.Jce.JceOutputStream p0);

	}

	[global::Android.Runtime.Register ("com/qq/taf/jce/JceStruct", DoNotGenerateAcw=true)]
	internal partial class JceStructInvoker : JceStruct {

		public JceStructInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceStructInvoker); }
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
		[Register ("readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V", "GetReadFrom_Lcom_qq_taf_jce_JceInputStream_Handler")]
		public override unsafe void ReadFrom (global::Com.QQ.Taf.Jce.JceInputStream p0)
		{
			if (id_readFrom_Lcom_qq_taf_jce_JceInputStream_ == IntPtr.Zero)
				id_readFrom_Lcom_qq_taf_jce_JceInputStream_ = JNIEnv.GetMethodID (class_ref, "readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_readFrom_Lcom_qq_taf_jce_JceInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_writeTo_Lcom_qq_taf_jce_JceOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceStruct']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
		[Register ("writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V", "GetWriteTo_Lcom_qq_taf_jce_JceOutputStream_Handler")]
		public override unsafe void WriteTo (global::Com.QQ.Taf.Jce.JceOutputStream p0)
		{
			if (id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_qq_taf_jce_JceOutputStream_, __args);
			} finally {
			}
		}

	}

}
