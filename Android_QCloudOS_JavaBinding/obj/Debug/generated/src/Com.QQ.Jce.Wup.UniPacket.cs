using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/UniPacket", DoNotGenerateAcw=true)]
	public partial class UniPacket : global::Com.QQ.Jce.Wup.UniAttribute {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/field[@name='UniPacketHeadSize']"
		[Register ("UniPacketHeadSize")]
		public const int UniPacketHeadSize = (int) 4;

		static IntPtr _package_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/field[@name='_package']"
		[Register ("_package")]
		protected global::Com.QQ.Taf.RequestPacket Package {
			get {
				if (_package_jfieldId == IntPtr.Zero)
					_package_jfieldId = JNIEnv.GetFieldID (class_ref, "_package", "Lcom/qq/taf/RequestPacket;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, _package_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.RequestPacket> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (_package_jfieldId == IntPtr.Zero)
					_package_jfieldId = JNIEnv.GetFieldID (class_ref, "_package", "Lcom/qq/taf/RequestPacket;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, _package_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/UniPacket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UniPacket); }
		}

		protected UniPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/constructor[@name='UniPacket' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe UniPacket (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UniPacket)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/constructor[@name='UniPacket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UniPacket ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UniPacket)) {
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

		static Delegate cb_getFuncName;
#pragma warning disable 0169
		static Delegate GetGetFuncNameHandler ()
		{
			if (cb_getFuncName == null)
				cb_getFuncName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFuncName);
			return cb_getFuncName;
		}

		static IntPtr n_GetFuncName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FuncName);
		}
#pragma warning restore 0169

		static Delegate cb_setFuncName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFuncName_Ljava_lang_String_Handler ()
		{
			if (cb_setFuncName_Ljava_lang_String_ == null)
				cb_setFuncName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFuncName_Ljava_lang_String_);
			return cb_setFuncName_Ljava_lang_String_;
		}

		static void n_SetFuncName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FuncName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFuncName;
		static IntPtr id_setFuncName_Ljava_lang_String_;
		public virtual unsafe string FuncName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='getFuncName' and count(parameter)=0]"
			[Register ("getFuncName", "()Ljava/lang/String;", "GetGetFuncNameHandler")]
			get {
				if (id_getFuncName == IntPtr.Zero)
					id_getFuncName = JNIEnv.GetMethodID (class_ref, "getFuncName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFuncName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFuncName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='setFuncName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFuncName", "(Ljava/lang/String;)V", "GetSetFuncName_Ljava_lang_String_Handler")]
			set {
				if (id_setFuncName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFuncName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFuncName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFuncName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFuncName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOldRespIret;
#pragma warning disable 0169
		static Delegate GetGetOldRespIretHandler ()
		{
			if (cb_getOldRespIret == null)
				cb_getOldRespIret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOldRespIret);
			return cb_getOldRespIret;
		}

		static int n_GetOldRespIret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OldRespIret;
		}
#pragma warning restore 0169

		static Delegate cb_setOldRespIret_I;
#pragma warning disable 0169
		static Delegate GetSetOldRespIret_IHandler ()
		{
			if (cb_setOldRespIret_I == null)
				cb_setOldRespIret_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOldRespIret_I);
			return cb_setOldRespIret_I;
		}

		static void n_SetOldRespIret_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OldRespIret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOldRespIret;
		static IntPtr id_setOldRespIret_I;
		public virtual unsafe int OldRespIret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='getOldRespIret' and count(parameter)=0]"
			[Register ("getOldRespIret", "()I", "GetGetOldRespIretHandler")]
			get {
				if (id_getOldRespIret == IntPtr.Zero)
					id_getOldRespIret = JNIEnv.GetMethodID (class_ref, "getOldRespIret", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOldRespIret);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOldRespIret", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='setOldRespIret' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOldRespIret", "(I)V", "GetSetOldRespIret_IHandler")]
			set {
				if (id_setOldRespIret_I == IntPtr.Zero)
					id_setOldRespIret_I = JNIEnv.GetMethodID (class_ref, "setOldRespIret", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOldRespIret_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOldRespIret", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageVersion;
#pragma warning disable 0169
		static Delegate GetGetPackageVersionHandler ()
		{
			if (cb_getPackageVersion == null)
				cb_getPackageVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPackageVersion);
			return cb_getPackageVersion;
		}

		static int n_GetPackageVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackageVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getPackageVersion;
		public virtual unsafe int PackageVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='getPackageVersion' and count(parameter)=0]"
			[Register ("getPackageVersion", "()I", "GetGetPackageVersionHandler")]
			get {
				if (id_getPackageVersion == IntPtr.Zero)
					id_getPackageVersion = JNIEnv.GetMethodID (class_ref, "getPackageVersion", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPackageVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackageVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequestId);
			return cb_getRequestId;
		}

		static int n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestId;
		}
#pragma warning restore 0169

		static Delegate cb_setRequestId_I;
#pragma warning disable 0169
		static Delegate GetSetRequestId_IHandler ()
		{
			if (cb_setRequestId_I == null)
				cb_setRequestId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequestId_I);
			return cb_setRequestId_I;
		}

		static void n_SetRequestId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		static IntPtr id_setRequestId_I;
		public virtual unsafe int RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()I", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRequestId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequestId", "(I)V", "GetSetRequestId_IHandler")]
			set {
				if (id_setRequestId_I == IntPtr.Zero)
					id_setRequestId_I = JNIEnv.GetMethodID (class_ref, "setRequestId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRequestId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestId", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getServantName;
#pragma warning disable 0169
		static Delegate GetGetServantNameHandler ()
		{
			if (cb_getServantName == null)
				cb_getServantName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServantName);
			return cb_getServantName;
		}

		static IntPtr n_GetServantName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServantName);
		}
#pragma warning restore 0169

		static Delegate cb_setServantName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServantName_Ljava_lang_String_Handler ()
		{
			if (cb_setServantName_Ljava_lang_String_ == null)
				cb_setServantName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServantName_Ljava_lang_String_);
			return cb_setServantName_Ljava_lang_String_;
		}

		static void n_SetServantName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServantName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServantName;
		static IntPtr id_setServantName_Ljava_lang_String_;
		public virtual unsafe string ServantName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='getServantName' and count(parameter)=0]"
			[Register ("getServantName", "()Ljava/lang/String;", "GetGetServantNameHandler")]
			get {
				if (id_getServantName == IntPtr.Zero)
					id_getServantName = JNIEnv.GetMethodID (class_ref, "getServantName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getServantName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServantName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='setServantName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServantName", "(Ljava/lang/String;)V", "GetSetServantName_Ljava_lang_String_Handler")]
			set {
				if (id_setServantName_Ljava_lang_String_ == IntPtr.Zero)
					id_setServantName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServantName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setServantName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServantName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_createOldRespEncode;
#pragma warning disable 0169
		static Delegate GetCreateOldRespEncodeHandler ()
		{
			if (cb_createOldRespEncode == null)
				cb_createOldRespEncode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateOldRespEncode);
			return cb_createOldRespEncode;
		}

		static IntPtr n_CreateOldRespEncode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.CreateOldRespEncode ());
		}
#pragma warning restore 0169

		static IntPtr id_createOldRespEncode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='createOldRespEncode' and count(parameter)=0]"
		[Register ("createOldRespEncode", "()[B", "GetCreateOldRespEncodeHandler")]
		public virtual unsafe byte[] CreateOldRespEncode ()
		{
			if (id_createOldRespEncode == IntPtr.Zero)
				id_createOldRespEncode = JNIEnv.GetMethodID (class_ref, "createOldRespEncode", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_createOldRespEncode), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOldRespEncode", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_createResponse;
#pragma warning disable 0169
		static Delegate GetCreateResponseHandler ()
		{
			if (cb_createResponse == null)
				cb_createResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateResponse);
			return cb_createResponse;
		}

		static IntPtr n_CreateResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateResponse ());
		}
#pragma warning restore 0169

		static IntPtr id_createResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='createResponse' and count(parameter)=0]"
		[Register ("createResponse", "()Lcom/qq/jce/wup/UniPacket;", "GetCreateResponseHandler")]
		public virtual unsafe global::Com.QQ.Jce.Wup.UniPacket CreateResponse ()
		{
			if (id_createResponse == IntPtr.Zero)
				id_createResponse = JNIEnv.GetMethodID (class_ref, "createResponse", "()Lcom/qq/jce/wup/UniPacket;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (JNIEnv.CallObjectMethod  (Handle, id_createResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createResponse", "()Lcom/qq/jce/wup/UniPacket;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.StringBuilder p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Display (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_display_Ljava_lang_StringBuilder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int']]"
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
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.JceInputStream p0 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFrom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
		[Register ("readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V", "GetReadFrom_Lcom_qq_taf_jce_JceInputStream_Handler")]
		public virtual unsafe void ReadFrom (global::Com.QQ.Taf.Jce.JceInputStream p0)
		{
			if (id_readFrom_Lcom_qq_taf_jce_JceInputStream_ == IntPtr.Zero)
				id_readFrom_Lcom_qq_taf_jce_JceInputStream_ = JNIEnv.GetMethodID (class_ref, "readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_readFrom_Lcom_qq_taf_jce_JceInputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V"), __args);
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
			global::Com.QQ.Jce.Wup.UniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.UniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.QQ.Taf.Jce.JceOutputStream p0 = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTo_Lcom_qq_taf_jce_JceOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='UniPacket']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
		[Register ("writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V", "GetWriteTo_Lcom_qq_taf_jce_JceOutputStream_Handler")]
		public virtual unsafe void WriteTo (global::Com.QQ.Taf.Jce.JceOutputStream p0)
		{
			if (id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_qq_taf_jce_JceOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V"), __args);
			} finally {
			}
		}

	}
}
