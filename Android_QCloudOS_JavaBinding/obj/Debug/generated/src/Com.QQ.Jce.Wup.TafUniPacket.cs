using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Jce.Wup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']"
	[global::Android.Runtime.Register ("com/qq/jce/wup/TafUniPacket", DoNotGenerateAcw=true)]
	public partial class TafUniPacket : global::Com.QQ.Jce.Wup.UniPacket {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/jce/wup/TafUniPacket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TafUniPacket); }
		}

		protected TafUniPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/constructor[@name='TafUniPacket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TafUniPacket ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TafUniPacket)) {
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

		static Delegate cb_getTafContext;
#pragma warning disable 0169
		static Delegate GetGetTafContextHandler ()
		{
			if (cb_getTafContext == null)
				cb_getTafContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTafContext);
			return cb_getTafContext;
		}

		static IntPtr n_GetTafContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.TafContext);
		}
#pragma warning restore 0169

		static Delegate cb_setTafContext_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetTafContext_Ljava_util_Map_Handler ()
		{
			if (cb_setTafContext_Ljava_util_Map_ == null)
				cb_setTafContext_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTafContext_Ljava_util_Map_);
			return cb_setTafContext_Ljava_util_Map_;
		}

		static void n_SetTafContext_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TafContext = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafContext;
		static IntPtr id_setTafContext_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> TafContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafContext' and count(parameter)=0]"
			[Register ("getTafContext", "()Ljava/util/Map;", "GetGetTafContextHandler")]
			get {
				if (id_getTafContext == IntPtr.Zero)
					id_getTafContext = JNIEnv.GetMethodID (class_ref, "getTafContext", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTafContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafContext", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafContext' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setTafContext", "(Ljava/util/Map;)V", "GetSetTafContext_Ljava_util_Map_Handler")]
			set {
				if (id_setTafContext_Ljava_util_Map_ == IntPtr.Zero)
					id_setTafContext_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setTafContext", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafContext_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafContext", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTafMessageType;
#pragma warning disable 0169
		static Delegate GetGetTafMessageTypeHandler ()
		{
			if (cb_getTafMessageType == null)
				cb_getTafMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTafMessageType);
			return cb_getTafMessageType;
		}

		static int n_GetTafMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TafMessageType;
		}
#pragma warning restore 0169

		static Delegate cb_setTafMessageType_I;
#pragma warning disable 0169
		static Delegate GetSetTafMessageType_IHandler ()
		{
			if (cb_setTafMessageType_I == null)
				cb_setTafMessageType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTafMessageType_I);
			return cb_setTafMessageType_I;
		}

		static void n_SetTafMessageType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TafMessageType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafMessageType;
		static IntPtr id_setTafMessageType_I;
		public virtual unsafe int TafMessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafMessageType' and count(parameter)=0]"
			[Register ("getTafMessageType", "()I", "GetGetTafMessageTypeHandler")]
			get {
				if (id_getTafMessageType == IntPtr.Zero)
					id_getTafMessageType = JNIEnv.GetMethodID (class_ref, "getTafMessageType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTafMessageType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafMessageType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafMessageType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTafMessageType", "(I)V", "GetSetTafMessageType_IHandler")]
			set {
				if (id_setTafMessageType_I == IntPtr.Zero)
					id_setTafMessageType_I = JNIEnv.GetMethodID (class_ref, "setTafMessageType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafMessageType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafMessageType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTafPacketType;
#pragma warning disable 0169
		static Delegate GetGetTafPacketTypeHandler ()
		{
			if (cb_getTafPacketType == null)
				cb_getTafPacketType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetTafPacketType);
			return cb_getTafPacketType;
		}

		static sbyte n_GetTafPacketType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TafPacketType;
		}
#pragma warning restore 0169

		static Delegate cb_setTafPacketType_B;
#pragma warning disable 0169
		static Delegate GetSetTafPacketType_BHandler ()
		{
			if (cb_setTafPacketType_B == null)
				cb_setTafPacketType_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_SetTafPacketType_B);
			return cb_setTafPacketType_B;
		}

		static void n_SetTafPacketType_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TafPacketType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafPacketType;
		static IntPtr id_setTafPacketType_B;
		public virtual unsafe sbyte TafPacketType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafPacketType' and count(parameter)=0]"
			[Register ("getTafPacketType", "()B", "GetGetTafPacketTypeHandler")]
			get {
				if (id_getTafPacketType == IntPtr.Zero)
					id_getTafPacketType = JNIEnv.GetMethodID (class_ref, "getTafPacketType", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod  (Handle, id_getTafPacketType);
					else
						return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafPacketType", "()B"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafPacketType' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setTafPacketType", "(B)V", "GetSetTafPacketType_BHandler")]
			set {
				if (id_setTafPacketType_B == IntPtr.Zero)
					id_setTafPacketType_B = JNIEnv.GetMethodID (class_ref, "setTafPacketType", "(B)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafPacketType_B, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafPacketType", "(B)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTafResultCode;
#pragma warning disable 0169
		static Delegate GetGetTafResultCodeHandler ()
		{
			if (cb_getTafResultCode == null)
				cb_getTafResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTafResultCode);
			return cb_getTafResultCode;
		}

		static int n_GetTafResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TafResultCode;
		}
#pragma warning restore 0169

		static IntPtr id_getTafResultCode;
		public virtual unsafe int TafResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafResultCode' and count(parameter)=0]"
			[Register ("getTafResultCode", "()I", "GetGetTafResultCodeHandler")]
			get {
				if (id_getTafResultCode == IntPtr.Zero)
					id_getTafResultCode = JNIEnv.GetMethodID (class_ref, "getTafResultCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTafResultCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafResultCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTafResultDesc;
#pragma warning disable 0169
		static Delegate GetGetTafResultDescHandler ()
		{
			if (cb_getTafResultDesc == null)
				cb_getTafResultDesc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTafResultDesc);
			return cb_getTafResultDesc;
		}

		static IntPtr n_GetTafResultDesc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TafResultDesc);
		}
#pragma warning restore 0169

		static IntPtr id_getTafResultDesc;
		public virtual unsafe string TafResultDesc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafResultDesc' and count(parameter)=0]"
			[Register ("getTafResultDesc", "()Ljava/lang/String;", "GetGetTafResultDescHandler")]
			get {
				if (id_getTafResultDesc == IntPtr.Zero)
					id_getTafResultDesc = JNIEnv.GetMethodID (class_ref, "getTafResultDesc", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTafResultDesc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafResultDesc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTafStatus;
#pragma warning disable 0169
		static Delegate GetGetTafStatusHandler ()
		{
			if (cb_getTafStatus == null)
				cb_getTafStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTafStatus);
			return cb_getTafStatus;
		}

		static IntPtr n_GetTafStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.TafStatus);
		}
#pragma warning restore 0169

		static Delegate cb_setTafStatus_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetTafStatus_Ljava_util_Map_Handler ()
		{
			if (cb_setTafStatus_Ljava_util_Map_ == null)
				cb_setTafStatus_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTafStatus_Ljava_util_Map_);
			return cb_setTafStatus_Ljava_util_Map_;
		}

		static void n_SetTafStatus_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TafStatus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafStatus;
		static IntPtr id_setTafStatus_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> TafStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafStatus' and count(parameter)=0]"
			[Register ("getTafStatus", "()Ljava/util/Map;", "GetGetTafStatusHandler")]
			get {
				if (id_getTafStatus == IntPtr.Zero)
					id_getTafStatus = JNIEnv.GetMethodID (class_ref, "getTafStatus", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTafStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafStatus", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafStatus' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setTafStatus", "(Ljava/util/Map;)V", "GetSetTafStatus_Ljava_util_Map_Handler")]
			set {
				if (id_setTafStatus_Ljava_util_Map_ == IntPtr.Zero)
					id_setTafStatus_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setTafStatus", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafStatus_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafStatus", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTafTimeout;
#pragma warning disable 0169
		static Delegate GetGetTafTimeoutHandler ()
		{
			if (cb_getTafTimeout == null)
				cb_getTafTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTafTimeout);
			return cb_getTafTimeout;
		}

		static int n_GetTafTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TafTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTafTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTafTimeout_IHandler ()
		{
			if (cb_setTafTimeout_I == null)
				cb_setTafTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTafTimeout_I);
			return cb_setTafTimeout_I;
		}

		static void n_SetTafTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TafTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafTimeout;
		static IntPtr id_setTafTimeout_I;
		public virtual unsafe int TafTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafTimeout' and count(parameter)=0]"
			[Register ("getTafTimeout", "()I", "GetGetTafTimeoutHandler")]
			get {
				if (id_getTafTimeout == IntPtr.Zero)
					id_getTafTimeout = JNIEnv.GetMethodID (class_ref, "getTafTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTafTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTafTimeout", "(I)V", "GetSetTafTimeout_IHandler")]
			set {
				if (id_setTafTimeout_I == IntPtr.Zero)
					id_setTafTimeout_I = JNIEnv.GetMethodID (class_ref, "setTafTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTafVersion;
#pragma warning disable 0169
		static Delegate GetGetTafVersionHandler ()
		{
			if (cb_getTafVersion == null)
				cb_getTafVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTafVersion);
			return cb_getTafVersion;
		}

		static short n_GetTafVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TafVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setTafVersion_S;
#pragma warning disable 0169
		static Delegate GetSetTafVersion_SHandler ()
		{
			if (cb_setTafVersion_S == null)
				cb_setTafVersion_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTafVersion_S);
			return cb_setTafVersion_S;
		}

		static void n_SetTafVersion_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TafVersion = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTafVersion;
		static IntPtr id_setTafVersion_S;
		public virtual unsafe short TafVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafVersion' and count(parameter)=0]"
			[Register ("getTafVersion", "()S", "GetGetTafVersionHandler")]
			get {
				if (id_getTafVersion == IntPtr.Zero)
					id_getTafVersion = JNIEnv.GetMethodID (class_ref, "getTafVersion", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod  (Handle, id_getTafVersion);
					else
						return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafVersion", "()S"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafVersion' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setTafVersion", "(S)V", "GetSetTafVersion_SHandler")]
			set {
				if (id_setTafVersion_S == IntPtr.Zero)
					id_setTafVersion_S = JNIEnv.GetMethodID (class_ref, "setTafVersion", "(S)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTafVersion_S, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafVersion", "(S)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTafBuffer;
#pragma warning disable 0169
		static Delegate GetGetTafBufferHandler ()
		{
			if (cb_getTafBuffer == null)
				cb_getTafBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTafBuffer);
			return cb_getTafBuffer;
		}

		static IntPtr n_GetTafBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTafBuffer ());
		}
#pragma warning restore 0169

		static IntPtr id_getTafBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='getTafBuffer' and count(parameter)=0]"
		[Register ("getTafBuffer", "()[B", "GetGetTafBufferHandler")]
		public virtual unsafe byte[] GetTafBuffer ()
		{
			if (id_getTafBuffer == IntPtr.Zero)
				id_getTafBuffer = JNIEnv.GetMethodID (class_ref, "getTafBuffer", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTafBuffer), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTafBuffer", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setTafBuffer_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTafBuffer_arrayBHandler ()
		{
			if (cb_setTafBuffer_arrayB == null)
				cb_setTafBuffer_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTafBuffer_arrayB);
			return cb_setTafBuffer_arrayB;
		}

		static void n_SetTafBuffer_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.QQ.Jce.Wup.TafUniPacket __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Jce.Wup.TafUniPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTafBuffer (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTafBuffer_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.jce.wup']/class[@name='TafUniPacket']/method[@name='setTafBuffer' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setTafBuffer", "([B)V", "GetSetTafBuffer_arrayBHandler")]
		public virtual unsafe void SetTafBuffer (byte[] p0)
		{
			if (id_setTafBuffer_arrayB == IntPtr.Zero)
				id_setTafBuffer_arrayB = JNIEnv.GetMethodID (class_ref, "setTafBuffer", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTafBuffer_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTafBuffer", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
