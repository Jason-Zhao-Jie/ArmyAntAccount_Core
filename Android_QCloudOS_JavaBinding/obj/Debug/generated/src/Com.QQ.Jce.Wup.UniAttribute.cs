using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/UniAttribute", DoNotGenerateAcw=true)]
	public partial class UniAttribute : global::Com.QQ.Jce.Wup.OldUniAttribute {


		static IntPtr _newData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/field[@name='_newData']"
		[Register ("_newData")]
		protected global::System.Collections.IDictionary NewData {
			get {
				if (_newData_jfieldId == IntPtr.Zero)
					_newData_jfieldId = JNIEnv.GetFieldID (class_ref, "_newData", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, _newData_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (_newData_jfieldId == IntPtr.Zero)
					_newData_jfieldId = JNIEnv.GetFieldID (class_ref, "_newData", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, _newData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/UniAttribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UniAttribute); }
		}

		protected UniAttribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/constructor[@name='UniAttribute' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UniAttribute ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UniAttribute)) {
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

		static Delegate cb_getEncodeName;
#pragma warning disable 0169
		static Delegate GetGetEncodeNameHandler ()
		{
			if (cb_getEncodeName == null)
				cb_getEncodeName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodeName);
			return cb_getEncodeName;
		}

		static IntPtr n_GetEncodeName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncodeName);
		}
#pragma warning restore 0169

		static Delegate cb_setEncodeName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncodeName_Ljava_lang_String_Handler ()
		{
			if (cb_setEncodeName_Ljava_lang_String_ == null)
				cb_setEncodeName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncodeName_Ljava_lang_String_);
			return cb_setEncodeName_Ljava_lang_String_;
		}

		static void n_SetEncodeName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodeName;
		static IntPtr id_setEncodeName_Ljava_lang_String_;
		public override unsafe string EncodeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getEncodeName' and count(parameter)=0]"
			[Register ("getEncodeName", "()Ljava/lang/String;", "GetGetEncodeNameHandler")]
			get {
				if (id_getEncodeName == IntPtr.Zero)
					id_getEncodeName = JNIEnv.GetMethodID (class_ref, "getEncodeName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEncodeName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodeName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='setEncodeName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncodeName", "(Ljava/lang/String;)V", "GetSetEncodeName_Ljava_lang_String_Handler")]
			set {
				if (id_setEncodeName_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncodeName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncodeName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEncodeName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncodeName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public override unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getKeySet;
#pragma warning disable 0169
		static Delegate GetGetKeySetHandler ()
		{
			if (cb_getKeySet == null)
				cb_getKeySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeySet);
			return cb_getKeySet;
		}

		static IntPtr n_GetKeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet);
		}
#pragma warning restore 0169

		static IntPtr id_getKeySet;
		public override unsafe global::System.Collections.Generic.ICollection<string> KeySet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getKeySet' and count(parameter)=0]"
			[Register ("getKeySet", "()Ljava/util/Set;", "GetGetKeySetHandler")]
			get {
				if (id_getKeySet == IntPtr.Zero)
					id_getKeySet = JNIEnv.GetMethodID (class_ref, "getKeySet", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getKeySet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearCacheData;
#pragma warning disable 0169
		static Delegate GetClearCacheDataHandler ()
		{
			if (cb_clearCacheData == null)
				cb_clearCacheData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCacheData);
			return cb_clearCacheData;
		}

		static void n_ClearCacheData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCacheData ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCacheData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='clearCacheData' and count(parameter)=0]"
		[Register ("clearCacheData", "()V", "GetClearCacheDataHandler")]
		public override unsafe void ClearCacheData ()
		{
			if (id_clearCacheData == IntPtr.Zero)
				id_clearCacheData = JNIEnv.GetMethodID (class_ref, "clearCacheData", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearCacheData);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCacheData", "()V"));
			} finally {
			}
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler")]
		public override unsafe bool ContainsKey (string p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsKey_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsKey", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static void n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Decode (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)V", "GetDecode_arrayBHandler")]
		public override unsafe void Decode (byte[] p0)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_decode_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decodeVersion2_arrayB;
#pragma warning disable 0169
		static Delegate GetDecodeVersion2_arrayBHandler ()
		{
			if (cb_decodeVersion2_arrayB == null)
				cb_decodeVersion2_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeVersion2_arrayB);
			return cb_decodeVersion2_arrayB;
		}

		static void n_DecodeVersion2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DecodeVersion2 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_decodeVersion2_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='decodeVersion2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeVersion2", "([B)V", "GetDecodeVersion2_arrayBHandler")]
		public virtual unsafe void DecodeVersion2 (byte[] p0)
		{
			if (id_decodeVersion2_arrayB == IntPtr.Zero)
				id_decodeVersion2_arrayB = JNIEnv.GetMethodID (class_ref, "decodeVersion2", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_decodeVersion2_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeVersion2", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decodeVersion3_arrayB;
#pragma warning disable 0169
		static Delegate GetDecodeVersion3_arrayBHandler ()
		{
			if (cb_decodeVersion3_arrayB == null)
				cb_decodeVersion3_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeVersion3_arrayB);
			return cb_decodeVersion3_arrayB;
		}

		static void n_DecodeVersion3_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DecodeVersion3 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_decodeVersion3_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='decodeVersion3' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeVersion3", "([B)V", "GetDecodeVersion3_arrayBHandler")]
		public virtual unsafe void DecodeVersion3 (byte[] p0)
		{
			if (id_decodeVersion3_arrayB == IntPtr.Zero)
				id_decodeVersion3_arrayB = JNIEnv.GetMethodID (class_ref, "decodeVersion3", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_decodeVersion3_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeVersion3", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encode;
#pragma warning disable 0169
		static Delegate GetEncodeHandler ()
		{
			if (cb_encode == null)
				cb_encode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Encode);
			return cb_encode;
		}

		static IntPtr n_Encode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Encode ());
		}
#pragma warning restore 0169

		static IntPtr id_encode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='encode' and count(parameter)=0]"
		[Register ("encode", "()[B", "GetEncodeHandler")]
		public override unsafe byte[] Encode ()
		{
			if (id_encode == IntPtr.Zero)
				id_encode = JNIEnv.GetMethodID (class_ref, "encode", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_encode), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Lang.Object Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_Object_);
			return cb_get_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Get (string p0, global::Java.Lang.Object p1)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByClass_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetByClass_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getByClass_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getByClass_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetByClass_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getByClass_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetByClass_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetByClass (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getByClass_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getByClass' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("getByClass", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetByClass_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object GetByClass (string p0, global::Java.Lang.Object p1)
		{
			if (id_getByClass_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getByClass_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getByClass", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getByClass_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByClass", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_GetByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetByClass (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getByClass' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T'] and parameter[3][@type='T']]"
		[Register ("getByClass", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object GetByClass (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getByClass", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getByClass_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByClass", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getJceStruct_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetJceStruct_Ljava_lang_String_Handler ()
		{
			if (cb_getJceStruct_Ljava_lang_String_ == null)
				cb_getJceStruct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJceStruct_Ljava_lang_String_);
			return cb_getJceStruct_Ljava_lang_String_;
		}

		static IntPtr n_GetJceStruct_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetJceStruct (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJceStruct_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getJceStruct' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getJceStruct", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetJceStruct_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Lang.Object GetJceStruct (string p0)
		{
			if (id_getJceStruct_Ljava_lang_String_ == IntPtr.Zero)
				id_getJceStruct_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getJceStruct", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getJceStruct_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJceStruct", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getJceStruct_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetJceStruct_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getJceStruct_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getJceStruct_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJceStruct_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getJceStruct_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetJceStruct_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetJceStruct (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJceStruct_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='getJceStruct' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("getJceStruct", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetJceStruct_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object GetJceStruct (string p0, global::Java.Lang.Object p1)
		{
			if (id_getJceStruct_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getJceStruct_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getJceStruct", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getJceStruct_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJceStruct", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public override unsafe void Put (string p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static IntPtr n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Ljava/lang/Object;", "GetRemove_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Lang.Object Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Remove_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Remove (string p0, global::Java.Lang.Object p1)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_useVersion3;
#pragma warning disable 0169
		static Delegate GetUseVersion3Handler ()
		{
			if (cb_useVersion3 == null)
				cb_useVersion3 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UseVersion3);
			return cb_useVersion3;
		}

		static void n_UseVersion3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniAttribute __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseVersion3 ();
		}
#pragma warning restore 0169

		static IntPtr id_useVersion3;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniAttribute']/method[@name='useVersion3' and count(parameter)=0]"
		[Register ("useVersion3", "()V", "GetUseVersion3Handler")]
		public virtual unsafe void UseVersion3 ()
		{
			if (id_useVersion3 == IntPtr.Zero)
				id_useVersion3 = JNIEnv.GetMethodID (class_ref, "useVersion3", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_useVersion3);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useVersion3", "()V"));
			} finally {
			}
		}

	}
}
