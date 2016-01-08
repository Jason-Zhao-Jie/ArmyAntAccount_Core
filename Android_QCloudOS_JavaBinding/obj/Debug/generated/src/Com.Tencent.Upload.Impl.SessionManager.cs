using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']"
	[global::Android.Runtime.Register ("com/tencent/upload/impl/SessionManager", DoNotGenerateAcw=true)]
	public partial class SessionManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/impl/SessionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionManager); }
		}

		protected SessionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnectedIp;
#pragma warning disable 0169
		static Delegate GetGetConnectedIpHandler ()
		{
			if (cb_getConnectedIp == null)
				cb_getConnectedIp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedIp);
			return cb_getConnectedIp;
		}

		static IntPtr n_GetConnectedIp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConnectedIp);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedIp;
		public virtual unsafe string ConnectedIp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']/method[@name='getConnectedIp' and count(parameter)=0]"
			[Register ("getConnectedIp", "()Ljava/lang/String;", "GetGetConnectedIpHandler")]
			get {
				if (id_getConnectedIp == IntPtr.Zero)
					id_getConnectedIp = JNIEnv.GetMethodID (class_ref, "getConnectedIp", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConnectedIp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedIp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIdle;
#pragma warning disable 0169
		static Delegate GetIsIdleHandler ()
		{
			if (cb_isIdle == null)
				cb_isIdle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIdle);
			return cb_isIdle;
		}

		static bool n_IsIdle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIdle;
		}
#pragma warning restore 0169

		static IntPtr id_isIdle;
		public virtual unsafe bool IsIdle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']/method[@name='isIdle' and count(parameter)=0]"
			[Register ("isIdle", "()Z", "GetIsIdleHandler")]
			get {
				if (id_isIdle == IntPtr.Zero)
					id_isIdle = JNIEnv.GetMethodID (class_ref, "isIdle", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isIdle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIdle", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_onNetworkConnect_Z;
#pragma warning disable 0169
		static Delegate GetOnNetworkConnect_ZHandler ()
		{
			if (cb_onNetworkConnect_Z == null)
				cb_onNetworkConnect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnNetworkConnect_Z);
			return cb_onNetworkConnect_Z;
		}

		static void n_OnNetworkConnect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Upload.Impl.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkConnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNetworkConnect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']/method[@name='onNetworkConnect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onNetworkConnect", "(Z)V", "GetOnNetworkConnect_ZHandler")]
		public virtual unsafe void OnNetworkConnect (bool p0)
		{
			if (id_onNetworkConnect_Z == IntPtr.Zero)
				id_onNetworkConnect_Z = JNIEnv.GetMethodID (class_ref, "onNetworkConnect", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onNetworkConnect_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNetworkConnect", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_releaseCurrTask;
#pragma warning disable 0169
		static Delegate GetReleaseCurrTaskHandler ()
		{
			if (cb_releaseCurrTask == null)
				cb_releaseCurrTask = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseCurrTask);
			return cb_releaseCurrTask;
		}

		static void n_ReleaseCurrTask (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseCurrTask ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseCurrTask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='SessionManager']/method[@name='releaseCurrTask' and count(parameter)=0]"
		[Register ("releaseCurrTask", "()V", "GetReleaseCurrTaskHandler")]
		public virtual unsafe void ReleaseCurrTask ()
		{
			if (id_releaseCurrTask == IntPtr.Zero)
				id_releaseCurrTask = JNIEnv.GetMethodID (class_ref, "releaseCurrTask", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_releaseCurrTask);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseCurrTask", "()V"));
			} finally {
			}
		}

	}
}
