using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Network.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']"
	[global::Android.Runtime.Register ("com/tencent/upload/network/base/ConnectionImpl", DoNotGenerateAcw=true)]
	public partial class ConnectionImpl : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/network/base/ConnectionImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionImpl); }
		}

		protected ConnectionImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/constructor[@name='ConnectionImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe ConnectionImpl (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ConnectionImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_isLibraryPrepared;
		public static unsafe bool IsLibraryPrepared {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='isLibraryPrepared' and count(parameter)=0]"
			[Register ("isLibraryPrepared", "()Z", "GetIsLibraryPreparedHandler")]
			get {
				if (id_isLibraryPrepared == IntPtr.Zero)
					id_isLibraryPrepared = JNIEnv.GetStaticMethodID (class_ref, "isLibraryPrepared", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLibraryPrepared);
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_PostMessage_ILjava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetPostMessage_ILjava_lang_Object_IHandler ()
		{
			if (cb_PostMessage_ILjava_lang_Object_I == null)
				cb_PostMessage_ILjava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, bool>) n_PostMessage_ILjava_lang_Object_I);
			return cb_PostMessage_ILjava_lang_Object_I;
		}

		static bool n_PostMessage_ILjava_lang_Object_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PostMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_PostMessage_ILjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='PostMessage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("PostMessage", "(ILjava/lang/Object;I)Z", "GetPostMessage_ILjava_lang_Object_IHandler")]
		public virtual unsafe bool PostMessage (int p0, global::Java.Lang.Object p1, int p2)
		{
			if (id_PostMessage_ILjava_lang_Object_I == IntPtr.Zero)
				id_PostMessage_ILjava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "PostMessage", "(ILjava/lang/Object;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_PostMessage_ILjava_lang_Object_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PostMessage", "(ILjava/lang/Object;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SendData_arrayBIII;
#pragma warning disable 0169
		static Delegate GetSendData_arrayBIIIHandler ()
		{
			if (cb_SendData_arrayBIII == null)
				cb_SendData_arrayBIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, bool>) n_SendData_arrayBIII);
			return cb_SendData_arrayBIII;
		}

		static bool n_SendData_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SendData (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendData_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='SendData' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("SendData", "([BIII)Z", "GetSendData_arrayBIIIHandler")]
		public virtual unsafe bool SendData (byte[] p0, int p1, int p2, int p3)
		{
			if (id_SendData_arrayBIII == IntPtr.Zero)
				id_SendData_arrayBIII = JNIEnv.GetMethodID (class_ref, "SendData", "([BIII)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SendData_arrayBIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendData", "([BIII)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_connect_Ljava_lang_String_ILjava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_ILjava_lang_String_IIIHandler ()
		{
			if (cb_connect_Ljava_lang_String_ILjava_lang_String_III == null)
				cb_connect_Ljava_lang_String_ILjava_lang_String_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, int, bool>) n_Connect_Ljava_lang_String_ILjava_lang_String_III);
			return cb_connect_Ljava_lang_String_ILjava_lang_String_III;
		}

		static bool n_Connect_Ljava_lang_String_ILjava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, int p4, int p5)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_ILjava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='connect' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("connect", "(Ljava/lang/String;ILjava/lang/String;III)Z", "GetConnect_Ljava_lang_String_ILjava_lang_String_IIIHandler")]
		public virtual unsafe bool Connect (string p0, int p1, string p2, int p3, int p4, int p5)
		{
			if (id_connect_Ljava_lang_String_ILjava_lang_String_III == IntPtr.Zero)
				id_connect_Ljava_lang_String_ILjava_lang_String_III = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;ILjava/lang/String;III)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_connect_Ljava_lang_String_ILjava_lang_String_III, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;ILjava/lang/String;III)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Disconnect);
			return cb_disconnect;
		}

		static bool n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Z", "GetDisconnectHandler")]
		public virtual unsafe bool Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_disconnect);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()Z"));
			} finally {
			}
		}

		static IntPtr id_getHashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='getHashCode' and count(parameter)=0]"
		[Register ("getHashCode", "()I", "")]
		public unsafe int GetHashCode ()
		{
			if (id_getHashCode == IntPtr.Zero)
				id_getHashCode = JNIEnv.GetMethodID (class_ref, "getHashCode", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_getHashCode);
			} finally {
			}
		}

		static Delegate cb_isSendDone_I;
#pragma warning disable 0169
		static Delegate GetIsSendDone_IHandler ()
		{
			if (cb_isSendDone_I == null)
				cb_isSendDone_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsSendDone_I);
			return cb_isSendDone_I;
		}

		static bool n_IsSendDone_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSendDone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isSendDone_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='isSendDone' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSendDone", "(I)Z", "GetIsSendDone_IHandler")]
		public virtual unsafe bool IsSendDone (int p0)
		{
			if (id_isSendDone_I == IntPtr.Zero)
				id_isSendDone_I = JNIEnv.GetMethodID (class_ref, "isSendDone", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSendDone_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSendDone", "(I)Z"), __args);
			} finally {
			}
		}

		static IntPtr id_printLog_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='printLog' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("printLog", "(ILjava/lang/String;)V", "")]
		public static unsafe void PrintLog (int p0, string p1)
		{
			if (id_printLog_ILjava_lang_String_ == IntPtr.Zero)
				id_printLog_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printLog", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printLog_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeAllSendData;
#pragma warning disable 0169
		static Delegate GetRemoveAllSendDataHandler ()
		{
			if (cb_removeAllSendData == null)
				cb_removeAllSendData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllSendData);
			return cb_removeAllSendData;
		}

		static void n_RemoveAllSendData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllSendData ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllSendData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='removeAllSendData' and count(parameter)=0]"
		[Register ("removeAllSendData", "()V", "GetRemoveAllSendDataHandler")]
		public virtual unsafe void RemoveAllSendData ()
		{
			if (id_removeAllSendData == IntPtr.Zero)
				id_removeAllSendData = JNIEnv.GetMethodID (class_ref, "removeAllSendData", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllSendData);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllSendData", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeSendData_I;
#pragma warning disable 0169
		static Delegate GetRemoveSendData_IHandler ()
		{
			if (cb_removeSendData_I == null)
				cb_removeSendData_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveSendData_I);
			return cb_removeSendData_I;
		}

		static void n_RemoveSendData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSendData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSendData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='removeSendData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeSendData", "(I)V", "GetRemoveSendData_IHandler")]
		public virtual unsafe void RemoveSendData (int p0)
		{
			if (id_removeSendData_I == IntPtr.Zero)
				id_removeSendData_I = JNIEnv.GetMethodID (class_ref, "removeSendData", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeSendData_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSendData", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Start);
			return cb_start;
		}

		static bool n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()Z", "GetStartHandler")]
		public virtual unsafe bool Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_start);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()Z"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Stop);
			return cb_stop;
		}

		static bool n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()Z", "GetStopHandler")]
		public virtual unsafe bool Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_stop);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()Z"));
			} finally {
			}
		}

		static Delegate cb_wakeUp;
#pragma warning disable 0169
		static Delegate GetWakeUpHandler ()
		{
			if (cb_wakeUp == null)
				cb_wakeUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WakeUp);
			return cb_wakeUp;
		}

		static void n_WakeUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Network.Base.ConnectionImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Network.Base.ConnectionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WakeUp ();
		}
#pragma warning restore 0169

		static IntPtr id_wakeUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.network.base']/class[@name='ConnectionImpl']/method[@name='wakeUp' and count(parameter)=0]"
		[Register ("wakeUp", "()V", "GetWakeUpHandler")]
		public virtual unsafe void WakeUp ()
		{
			if (id_wakeUp == IntPtr.Zero)
				id_wakeUp = JNIEnv.GetMethodID (class_ref, "wakeUp", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_wakeUp);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wakeUp", "()V"));
			} finally {
			}
		}

	}
}
