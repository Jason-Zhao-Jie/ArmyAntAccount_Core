using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/JceOutputStream", DoNotGenerateAcw=true)]
	public partial class JceOutputStream : global::Java.Lang.Object {


		static IntPtr sServerEncoding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/field[@name='sServerEncoding']"
		[Register ("sServerEncoding")]
		protected string SServerEncoding {
			get {
				if (sServerEncoding_jfieldId == IntPtr.Zero)
					sServerEncoding_jfieldId = JNIEnv.GetFieldID (class_ref, "sServerEncoding", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sServerEncoding_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sServerEncoding_jfieldId == IntPtr.Zero)
					sServerEncoding_jfieldId = JNIEnv.GetFieldID (class_ref, "sServerEncoding", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sServerEncoding_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/JceOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceOutputStream); }
		}

		protected JceOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/constructor[@name='JceOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe JceOutputStream (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JceOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/constructor[@name='JceOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JceOutputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JceOutputStream)) {
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

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/constructor[@name='JceOutputStream' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JceOutputStream (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JceOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_getByteBuffer;
#pragma warning disable 0169
		static Delegate GetGetByteBufferHandler ()
		{
			if (cb_getByteBuffer == null)
				cb_getByteBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByteBuffer);
			return cb_getByteBuffer;
		}

		static IntPtr n_GetByteBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ByteBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_getByteBuffer;
		public virtual unsafe global::Java.Nio.ByteBuffer ByteBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='getByteBuffer' and count(parameter)=0]"
			[Register ("getByteBuffer", "()Ljava/nio/ByteBuffer;", "GetGetByteBufferHandler")]
			get {
				if (id_getByteBuffer == IntPtr.Zero)
					id_getByteBuffer = JNIEnv.GetMethodID (class_ref, "getByteBuffer", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getByteBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteBuffer", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExceptionHandler;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandlerHandler ()
		{
			if (cb_getExceptionHandler == null)
				cb_getExceptionHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExceptionHandler);
			return cb_getExceptionHandler;
		}

		static IntPtr n_GetExceptionHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExceptionHandler);
		}
#pragma warning restore 0169

		static Delegate cb_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_;
#pragma warning disable 0169
		static Delegate GetSetExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_Handler ()
		{
			if (cb_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_ == null)
				cb_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_);
			return cb_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_;
		}

		static void n_SetExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.IOnIllegalArgumentException p0 = (global::Com.QQ.Taf.Jce.IOnIllegalArgumentException)global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.IOnIllegalArgumentException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExceptionHandler = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExceptionHandler;
		static IntPtr id_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_;
		public virtual unsafe global::Com.QQ.Taf.Jce.IOnIllegalArgumentException ExceptionHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='getExceptionHandler' and count(parameter)=0]"
			[Register ("getExceptionHandler", "()Lcom/qq/taf/jce/OnIllegalArgumentException;", "GetGetExceptionHandlerHandler")]
			get {
				if (id_getExceptionHandler == IntPtr.Zero)
					id_getExceptionHandler = JNIEnv.GetMethodID (class_ref, "getExceptionHandler", "()Lcom/qq/taf/jce/OnIllegalArgumentException;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.IOnIllegalArgumentException> (JNIEnv.CallObjectMethod  (Handle, id_getExceptionHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.IOnIllegalArgumentException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExceptionHandler", "()Lcom/qq/taf/jce/OnIllegalArgumentException;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='setExceptionHandler' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.OnIllegalArgumentException']]"
			[Register ("setExceptionHandler", "(Lcom/qq/taf/jce/OnIllegalArgumentException;)V", "GetSetExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_Handler")]
			set {
				if (id_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_ == IntPtr.Zero)
					id_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_ = JNIEnv.GetMethodID (class_ref, "setExceptionHandler", "(Lcom/qq/taf/jce/OnIllegalArgumentException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExceptionHandler_Lcom_qq_taf_jce_OnIllegalArgumentException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExceptionHandler", "(Lcom/qq/taf/jce/OnIllegalArgumentException;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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

		static Delegate cb_reserve_I;
#pragma warning disable 0169
		static Delegate GetReserve_IHandler ()
		{
			if (cb_reserve_I == null)
				cb_reserve_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Reserve_I);
			return cb_reserve_I;
		}

		static void n_Reserve_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reserve (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reserve_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='reserve' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reserve", "(I)V", "GetReserve_IHandler")]
		public virtual unsafe void Reserve (int p0)
		{
			if (id_reserve_I == IntPtr.Zero)
				id_reserve_I = JNIEnv.GetMethodID (class_ref, "reserve", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reserve_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reserve", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setServerEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setServerEncoding_Ljava_lang_String_ == null)
				cb_setServerEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetServerEncoding_Ljava_lang_String_);
			return cb_setServerEncoding_Ljava_lang_String_;
		}

		static int n_SetServerEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetServerEncoding (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setServerEncoding_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='setServerEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerEncoding", "(Ljava/lang/String;)I", "GetSetServerEncoding_Ljava_lang_String_Handler")]
		public virtual unsafe int SetServerEncoding (string p0)
		{
			if (id_setServerEncoding_Ljava_lang_String_ == IntPtr.Zero)
				id_setServerEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerEncoding", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_setServerEncoding_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerEncoding", "(Ljava/lang/String;)I"), __args);
				return __ret;
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
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='toByteArray' and count(parameter)=0]"
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

		static Delegate cb_write_arrayLjava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetWrite_arrayLjava_lang_Object_IHandler ()
		{
			if (cb_write_arrayLjava_lang_Object_I == null)
				cb_write_arrayLjava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayLjava_lang_Object_I);
			return cb_write_arrayLjava_lang_Object_I;
		}

		static void n_Write_arrayLjava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("write", "([Ljava/lang/Object;I)V", "GetWrite_arrayLjava_lang_Object_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Object[] p0, int p1)
		{
			if (id_write_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_write_arrayLjava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "write", "([Ljava/lang/Object;I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayLjava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([Ljava/lang/Object;I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_ZI;
#pragma warning disable 0169
		static Delegate GetWrite_ZIHandler ()
		{
			if (cb_write_ZI == null)
				cb_write_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int>) n_Write_ZI);
			return cb_write_ZI;
		}

		static void n_Write_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("write", "(ZI)V", "GetWrite_ZIHandler")]
		public virtual unsafe void Write (bool p0, int p1)
		{
			if (id_write_ZI == IntPtr.Zero)
				id_write_ZI = JNIEnv.GetMethodID (class_ref, "write", "(ZI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_ZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(ZI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayZI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayZIHandler ()
		{
			if (cb_write_arrayZI == null)
				cb_write_arrayZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayZI);
			return cb_write_arrayZI;
		}

		static void n_Write_arrayZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			bool[] p0 = (bool[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='int']]"
		[Register ("write", "([ZI)V", "GetWrite_arrayZIHandler")]
		public virtual unsafe void Write (bool[] p0, int p1)
		{
			if (id_write_arrayZI == IntPtr.Zero)
				id_write_arrayZI = JNIEnv.GetMethodID (class_ref, "write", "([ZI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([ZI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_BI;
#pragma warning disable 0169
		static Delegate GetWrite_BIHandler ()
		{
			if (cb_write_BI == null)
				cb_write_BI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, int>) n_Write_BI);
			return cb_write_BI;
		}

		static void n_Write_BI (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_BI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='int']]"
		[Register ("write", "(BI)V", "GetWrite_BIHandler")]
		public virtual unsafe void Write (sbyte p0, int p1)
		{
			if (id_write_BI == IntPtr.Zero)
				id_write_BI = JNIEnv.GetMethodID (class_ref, "write", "(BI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_BI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(BI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayBI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIHandler ()
		{
			if (cb_write_arrayBI == null)
				cb_write_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayBI);
			return cb_write_arrayBI;
		}

		static void n_Write_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("write", "([BI)V", "GetWrite_arrayBIHandler")]
		public virtual unsafe void Write (byte[] p0, int p1)
		{
			if (id_write_arrayBI == IntPtr.Zero)
				id_write_arrayBI = JNIEnv.GetMethodID (class_ref, "write", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayBI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([BI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_Lcom_qq_taf_jce_JceStruct_I;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_qq_taf_jce_JceStruct_IHandler ()
		{
			if (cb_write_Lcom_qq_taf_jce_JceStruct_I == null)
				cb_write_Lcom_qq_taf_jce_JceStruct_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Lcom_qq_taf_jce_JceStruct_I);
			return cb_write_Lcom_qq_taf_jce_JceStruct_I;
		}

		static void n_Write_Lcom_qq_taf_jce_JceStruct_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.JceStruct p0 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_qq_taf_jce_JceStruct_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.JceStruct'] and parameter[2][@type='int']]"
		[Register ("write", "(Lcom/qq/taf/jce/JceStruct;I)V", "GetWrite_Lcom_qq_taf_jce_JceStruct_IHandler")]
		public virtual unsafe void Write (global::Com.QQ.Taf.Jce.JceStruct p0, int p1)
		{
			if (id_write_Lcom_qq_taf_jce_JceStruct_I == IntPtr.Zero)
				id_write_Lcom_qq_taf_jce_JceStruct_I = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/qq/taf/jce/JceStruct;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_qq_taf_jce_JceStruct_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/qq/taf/jce/JceStruct;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_DI;
#pragma warning disable 0169
		static Delegate GetWrite_DIHandler ()
		{
			if (cb_write_DI == null)
				cb_write_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_Write_DI);
			return cb_write_DI;
		}

		static void n_Write_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("write", "(DI)V", "GetWrite_DIHandler")]
		public virtual unsafe void Write (double p0, int p1)
		{
			if (id_write_DI == IntPtr.Zero)
				id_write_DI = JNIEnv.GetMethodID (class_ref, "write", "(DI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_DI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(DI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayDI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayDIHandler ()
		{
			if (cb_write_arrayDI == null)
				cb_write_arrayDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayDI);
			return cb_write_arrayDI;
		}

		static void n_Write_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("write", "([DI)V", "GetWrite_arrayDIHandler")]
		public virtual unsafe void Write (double[] p0, int p1)
		{
			if (id_write_arrayDI == IntPtr.Zero)
				id_write_arrayDI = JNIEnv.GetMethodID (class_ref, "write", "([DI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayDI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([DI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_FI;
#pragma warning disable 0169
		static Delegate GetWrite_FIHandler ()
		{
			if (cb_write_FI == null)
				cb_write_FI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int>) n_Write_FI);
			return cb_write_FI;
		}

		static void n_Write_FI (IntPtr jnienv, IntPtr native__this, float p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("write", "(FI)V", "GetWrite_FIHandler")]
		public virtual unsafe void Write (float p0, int p1)
		{
			if (id_write_FI == IntPtr.Zero)
				id_write_FI = JNIEnv.GetMethodID (class_ref, "write", "(FI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_FI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(FI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayFI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayFIHandler ()
		{
			if (cb_write_arrayFI == null)
				cb_write_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayFI);
			return cb_write_arrayFI;
		}

		static void n_Write_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("write", "([FI)V", "GetWrite_arrayFIHandler")]
		public virtual unsafe void Write (float[] p0, int p1)
		{
			if (id_write_arrayFI == IntPtr.Zero)
				id_write_arrayFI = JNIEnv.GetMethodID (class_ref, "write", "([FI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([FI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_II;
#pragma warning disable 0169
		static Delegate GetWrite_IIHandler ()
		{
			if (cb_write_II == null)
				cb_write_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Write_II);
			return cb_write_II;
		}

		static void n_Write_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("write", "(II)V", "GetWrite_IIHandler")]
		public virtual unsafe void Write (int p0, int p1)
		{
			if (id_write_II == IntPtr.Zero)
				id_write_II = JNIEnv.GetMethodID (class_ref, "write", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayIIHandler ()
		{
			if (cb_write_arrayII == null)
				cb_write_arrayII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayII);
			return cb_write_arrayII;
		}

		static void n_Write_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("write", "([II)V", "GetWrite_arrayIIHandler")]
		public virtual unsafe void Write (int[] p0, int p1)
		{
			if (id_write_arrayII == IntPtr.Zero)
				id_write_arrayII = JNIEnv.GetMethodID (class_ref, "write", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([II)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_Ljava_lang_Boolean_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Boolean_IHandler ()
		{
			if (cb_write_Ljava_lang_Boolean_I == null)
				cb_write_Ljava_lang_Boolean_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Boolean_I);
			return cb_write_Ljava_lang_Boolean_I;
		}

		static void n_Write_Ljava_lang_Boolean_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Boolean_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Boolean'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Boolean;I)V", "GetWrite_Ljava_lang_Boolean_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Boolean p0, int p1)
		{
			if (id_write_Ljava_lang_Boolean_I == IntPtr.Zero)
				id_write_Ljava_lang_Boolean_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Boolean;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Boolean_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Boolean;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Byte_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Byte_IHandler ()
		{
			if (cb_write_Ljava_lang_Byte_I == null)
				cb_write_Ljava_lang_Byte_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Byte_I);
			return cb_write_Ljava_lang_Byte_I;
		}

		static void n_Write_Ljava_lang_Byte_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Byte p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Byte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Byte'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Byte;I)V", "GetWrite_Ljava_lang_Byte_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Byte p0, int p1)
		{
			if (id_write_Ljava_lang_Byte_I == IntPtr.Zero)
				id_write_Ljava_lang_Byte_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Byte;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Byte_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Byte;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Double_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Double_IHandler ()
		{
			if (cb_write_Ljava_lang_Double_I == null)
				cb_write_Ljava_lang_Double_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Double_I);
			return cb_write_Ljava_lang_Double_I;
		}

		static void n_Write_Ljava_lang_Double_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Double_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Double;I)V", "GetWrite_Ljava_lang_Double_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Double p0, int p1)
		{
			if (id_write_Ljava_lang_Double_I == IntPtr.Zero)
				id_write_Ljava_lang_Double_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Double;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Double_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Double;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Float_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Float_IHandler ()
		{
			if (cb_write_Ljava_lang_Float_I == null)
				cb_write_Ljava_lang_Float_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Float_I);
			return cb_write_Ljava_lang_Float_I;
		}

		static void n_Write_Ljava_lang_Float_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Float_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Float'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Float;I)V", "GetWrite_Ljava_lang_Float_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Float p0, int p1)
		{
			if (id_write_Ljava_lang_Float_I == IntPtr.Zero)
				id_write_Ljava_lang_Float_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Float;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Float_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Float;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Integer_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Integer_IHandler ()
		{
			if (cb_write_Ljava_lang_Integer_I == null)
				cb_write_Ljava_lang_Integer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Integer_I);
			return cb_write_Ljava_lang_Integer_I;
		}

		static void n_Write_Ljava_lang_Integer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Integer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Integer;I)V", "GetWrite_Ljava_lang_Integer_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Integer p0, int p1)
		{
			if (id_write_Ljava_lang_Integer_I == IntPtr.Zero)
				id_write_Ljava_lang_Integer_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Integer;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Integer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Integer;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Long_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Long_IHandler ()
		{
			if (cb_write_Ljava_lang_Long_I == null)
				cb_write_Ljava_lang_Long_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Long_I);
			return cb_write_Ljava_lang_Long_I;
		}

		static void n_Write_Ljava_lang_Long_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Long_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Long;I)V", "GetWrite_Ljava_lang_Long_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Long p0, int p1)
		{
			if (id_write_Ljava_lang_Long_I == IntPtr.Zero)
				id_write_Ljava_lang_Long_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Long;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Long_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Long;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Object_IHandler ()
		{
			if (cb_write_Ljava_lang_Object_I == null)
				cb_write_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Object_I);
			return cb_write_Ljava_lang_Object_I;
		}

		static void n_Write_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Object;I)V", "GetWrite_Ljava_lang_Object_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Object p0, int p1)
		{
			if (id_write_Ljava_lang_Object_I == IntPtr.Zero)
				id_write_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Object;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Object;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_Short_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_Short_IHandler ()
		{
			if (cb_write_Ljava_lang_Short_I == null)
				cb_write_Ljava_lang_Short_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_Short_I);
			return cb_write_Ljava_lang_Short_I;
		}

		static void n_Write_Ljava_lang_Short_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_Short_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.Short'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/Short;I)V", "GetWrite_Ljava_lang_Short_IHandler")]
		public virtual unsafe void Write (global::Java.Lang.Short p0, int p1)
		{
			if (id_write_Ljava_lang_Short_I == IntPtr.Zero)
				id_write_Ljava_lang_Short_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/Short;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_Short_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/Short;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_String_IHandler ()
		{
			if (cb_write_Ljava_lang_String_I == null)
				cb_write_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_lang_String_I);
			return cb_write_Ljava_lang_String_I;
		}

		static void n_Write_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/lang/String;I)V", "GetWrite_Ljava_lang_String_IHandler")]
		public virtual unsafe void Write (string p0, int p1)
		{
			if (id_write_Ljava_lang_String_I == IntPtr.Zero)
				id_write_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_Ljava_util_Collection_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_util_Collection_IHandler ()
		{
			if (cb_write_Ljava_util_Collection_I == null)
				cb_write_Ljava_util_Collection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_util_Collection_I);
			return cb_write_Ljava_util_Collection_I;
		}

		static void n_Write_Ljava_util_Collection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_util_Collection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/util/Collection;I)V", "GetWrite_Ljava_util_Collection_IHandler")]
		public virtual unsafe void Write (global::System.Collections.ICollection p0, int p1)
		{
			if (id_write_Ljava_util_Collection_I == IntPtr.Zero)
				id_write_Ljava_util_Collection_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/util/Collection;I)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_util_Collection_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/util/Collection;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_Ljava_util_Map_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_util_Map_IHandler ()
		{
			if (cb_write_Ljava_util_Map_I == null)
				cb_write_Ljava_util_Map_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_util_Map_I);
			return cb_write_Ljava_util_Map_I;
		}

		static void n_Write_Ljava_util_Map_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_util_Map_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;K, V&gt;'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/util/Map;I)V", "GetWrite_Ljava_util_Map_IHandler")]
		public virtual unsafe void Write (global::System.Collections.IDictionary p0, int p1)
		{
			if (id_write_Ljava_util_Map_I == IntPtr.Zero)
				id_write_Ljava_util_Map_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/util/Map;I)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_util_Map_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/util/Map;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_JI;
#pragma warning disable 0169
		static Delegate GetWrite_JIHandler ()
		{
			if (cb_write_JI == null)
				cb_write_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int>) n_Write_JI);
			return cb_write_JI;
		}

		static void n_Write_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("write", "(JI)V", "GetWrite_JIHandler")]
		public virtual unsafe void Write (long p0, int p1)
		{
			if (id_write_JI == IntPtr.Zero)
				id_write_JI = JNIEnv.GetMethodID (class_ref, "write", "(JI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_JI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(JI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayJI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayJIHandler ()
		{
			if (cb_write_arrayJI == null)
				cb_write_arrayJI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayJI);
			return cb_write_arrayJI;
		}

		static void n_Write_arrayJI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			long[] p0 = (long[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='int']]"
		[Register ("write", "([JI)V", "GetWrite_arrayJIHandler")]
		public virtual unsafe void Write (long[] p0, int p1)
		{
			if (id_write_arrayJI == IntPtr.Zero)
				id_write_arrayJI = JNIEnv.GetMethodID (class_ref, "write", "([JI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arrayJI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([JI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_SI;
#pragma warning disable 0169
		static Delegate GetWrite_SIHandler ()
		{
			if (cb_write_SI == null)
				cb_write_SI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short, int>) n_Write_SI);
			return cb_write_SI;
		}

		static void n_Write_SI (IntPtr jnienv, IntPtr native__this, short p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_SI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='int']]"
		[Register ("write", "(SI)V", "GetWrite_SIHandler")]
		public virtual unsafe void Write (short p0, int p1)
		{
			if (id_write_SI == IntPtr.Zero)
				id_write_SI = JNIEnv.GetMethodID (class_ref, "write", "(SI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_SI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(SI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arraySI;
#pragma warning disable 0169
		static Delegate GetWrite_arraySIHandler ()
		{
			if (cb_write_arraySI == null)
				cb_write_arraySI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arraySI);
			return cb_write_arraySI;
		}

		static void n_Write_arraySI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			__this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arraySI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int']]"
		[Register ("write", "([SI)V", "GetWrite_arraySIHandler")]
		public virtual unsafe void Write (short[] p0, int p1)
		{
			if (id_write_arraySI == IntPtr.Zero)
				id_write_arraySI = JNIEnv.GetMethodID (class_ref, "write", "([SI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_arraySI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([SI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_writeByteString_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetWriteByteString_Ljava_lang_String_IHandler ()
		{
			if (cb_writeByteString_Ljava_lang_String_I == null)
				cb_writeByteString_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteByteString_Ljava_lang_String_I);
			return cb_writeByteString_Ljava_lang_String_I;
		}

		static void n_WriteByteString_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteByteString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeByteString_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='writeByteString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("writeByteString", "(Ljava/lang/String;I)V", "GetWriteByteString_Ljava_lang_String_IHandler")]
		public virtual unsafe void WriteByteString (string p0, int p1)
		{
			if (id_writeByteString_Ljava_lang_String_I == IntPtr.Zero)
				id_writeByteString_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "writeByteString", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeByteString_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeByteString", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeHead_BI;
#pragma warning disable 0169
		static Delegate GetWriteHead_BIHandler ()
		{
			if (cb_writeHead_BI == null)
				cb_writeHead_BI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, int>) n_WriteHead_BI);
			return cb_writeHead_BI;
		}

		static void n_WriteHead_BI (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteHead (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeHead_BI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='writeHead' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='int']]"
		[Register ("writeHead", "(BI)V", "GetWriteHead_BIHandler")]
		public virtual unsafe void WriteHead (sbyte p0, int p1)
		{
			if (id_writeHead_BI == IntPtr.Zero)
				id_writeHead_BI = JNIEnv.GetMethodID (class_ref, "writeHead", "(BI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeHead_BI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeHead", "(BI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeStringByte_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetWriteStringByte_Ljava_lang_String_IHandler ()
		{
			if (cb_writeStringByte_Ljava_lang_String_I == null)
				cb_writeStringByte_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteStringByte_Ljava_lang_String_I);
			return cb_writeStringByte_Ljava_lang_String_I;
		}

		static void n_WriteStringByte_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.QQ.Taf.Jce.JceOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteStringByte (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeStringByte_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceOutputStream']/method[@name='writeStringByte' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("writeStringByte", "(Ljava/lang/String;I)V", "GetWriteStringByte_Ljava_lang_String_IHandler")]
		public virtual unsafe void WriteStringByte (string p0, int p1)
		{
			if (id_writeStringByte_Ljava_lang_String_I == IntPtr.Zero)
				id_writeStringByte_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "writeStringByte", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeStringByte_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeStringByte", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
