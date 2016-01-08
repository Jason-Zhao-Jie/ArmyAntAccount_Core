using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']"
	[global::Android.Runtime.Register ("com/tencent/upload/impl/TaskManager", DoNotGenerateAcw=true)]
	public partial class TaskManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/field[@name='IDLE_PROTECT_TIME']"
		[Register ("IDLE_PROTECT_TIME")]
		public const long IdleProtectTime = (long) 300000L;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']"
		[global::Android.Runtime.Register ("com/tencent/upload/impl/TaskManager$TaskType", DoNotGenerateAcw=true)]
		public sealed partial class TaskType : global::Java.Lang.Enum {


			static IntPtr COMMON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/field[@name='COMMON']"
			[Register ("COMMON")]
			public static global::Com.Tencent.Upload.Impl.TaskManager.TaskType Common {
				get {
					if (COMMON_jfieldId == IntPtr.Zero)
						COMMON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMON", "Lcom/tencent/upload/impl/TaskManager$TaskType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPLOAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/field[@name='UPLOAD']"
			[Register ("UPLOAD")]
			public static global::Com.Tencent.Upload.Impl.TaskManager.TaskType Upload {
				get {
					if (UPLOAD_jfieldId == IntPtr.Zero)
						UPLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD", "Lcom/tencent/upload/impl/TaskManager$TaskType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/impl/TaskManager$TaskType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TaskType); }
			}

			internal TaskType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCode;
			public unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getCode);
					} finally {
					}
				}
			}

			static IntPtr id_getDesc;
			public unsafe string Desc {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/method[@name='getDesc' and count(parameter)=0]"
				[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
				get {
					if (id_getDesc == IntPtr.Zero)
						id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/impl/TaskManager$TaskType;", "")]
			public static unsafe global::Com.Tencent.Upload.Impl.TaskManager.TaskType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/impl/TaskManager$TaskType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Upload.Impl.TaskManager.TaskType __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager.TaskType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager.TaskType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/upload/impl/TaskManager$TaskType;", "")]
			public static unsafe global::Com.Tencent.Upload.Impl.TaskManager.TaskType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/upload/impl/TaskManager$TaskType;");
				try {
					return (global::Com.Tencent.Upload.Impl.TaskManager.TaskType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Upload.Impl.TaskManager.TaskType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/impl/TaskManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskManager); }
		}

		protected TaskManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/constructor[@name='TaskManager' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.upload.Const.FileType'] and parameter[3][@type='com.tencent.upload.impl.TaskManager.TaskType']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;)V", "")]
		public unsafe TaskManager (string p0, global::Com.Tencent.Upload.Const.FileType p1, global::Com.Tencent.Upload.Impl.TaskManager.TaskType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TaskManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_Lcom_tencent_upload_Const_ServerEnv_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/constructor[@name='TaskManager' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.upload.Const.FileType'] and parameter[3][@type='com.tencent.upload.impl.TaskManager.TaskType'] and parameter[4][@type='com.tencent.upload.Const.ServerEnv']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;Lcom/tencent/upload/Const$ServerEnv;)V", "")]
		public unsafe TaskManager (string p0, global::Com.Tencent.Upload.Const.FileType p1, global::Com.Tencent.Upload.Impl.TaskManager.TaskType p2, global::Com.Tencent.Upload.Const.ServerEnv p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (TaskManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;Lcom/tencent/upload/Const$ServerEnv;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;Lcom/tencent/upload/Const$ServerEnv;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_Lcom_tencent_upload_Const_ServerEnv_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_Lcom_tencent_upload_Const_ServerEnv_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/tencent/upload/Const$FileType;Lcom/tencent/upload/impl/TaskManager$TaskType;Lcom/tencent/upload/Const$ServerEnv;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_Lcom_tencent_upload_Const_ServerEnv_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_tencent_upload_Const_FileType_Lcom_tencent_upload_impl_TaskManager_TaskType_Lcom_tencent_upload_Const_ServerEnv_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isBusy;
#pragma warning disable 0169
		static Delegate GetIsBusyHandler ()
		{
			if (cb_isBusy == null)
				cb_isBusy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBusy);
			return cb_isBusy;
		}

		static bool n_IsBusy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.TaskManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBusy;
		}
#pragma warning restore 0169

		static IntPtr id_isBusy;
		public virtual unsafe bool IsBusy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/method[@name='isBusy' and count(parameter)=0]"
			[Register ("isBusy", "()Z", "GetIsBusyHandler")]
			get {
				if (id_isBusy == IntPtr.Zero)
					id_isBusy = JNIEnv.GetMethodID (class_ref, "isBusy", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBusy);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBusy", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLooper;
#pragma warning disable 0169
		static Delegate GetGetLooperHandler ()
		{
			if (cb_getLooper == null)
				cb_getLooper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLooper);
			return cb_getLooper;
		}

		static IntPtr n_GetLooper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.TaskManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Looper);
		}
#pragma warning restore 0169

		static IntPtr id_getLooper;
		public virtual unsafe global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler")]
			get {
				if (id_getLooper == IntPtr.Zero)
					id_getLooper = JNIEnv.GetMethodID (class_ref, "getLooper", "()Landroid/os/Looper;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallObjectMethod  (Handle, id_getLooper), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLooper", "()Landroid/os/Looper;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Tencent.Upload.Impl.TaskManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_removeAllTask;
#pragma warning disable 0169
		static Delegate GetRemoveAllTaskHandler ()
		{
			if (cb_removeAllTask == null)
				cb_removeAllTask = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllTask);
			return cb_removeAllTask;
		}

		static void n_RemoveAllTask (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.TaskManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllTask ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllTask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/method[@name='removeAllTask' and count(parameter)=0]"
		[Register ("removeAllTask", "()V", "GetRemoveAllTaskHandler")]
		public virtual unsafe void RemoveAllTask ()
		{
			if (id_removeAllTask == IntPtr.Zero)
				id_removeAllTask = JNIEnv.GetMethodID (class_ref, "removeAllTask", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllTask);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllTask", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendIfHasTask;
#pragma warning disable 0169
		static Delegate GetSendIfHasTaskHandler ()
		{
			if (cb_sendIfHasTask == null)
				cb_sendIfHasTask = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendIfHasTask);
			return cb_sendIfHasTask;
		}

		static void n_SendIfHasTask (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.TaskManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.TaskManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendIfHasTask ();
		}
#pragma warning restore 0169

		static IntPtr id_sendIfHasTask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='TaskManager']/method[@name='sendIfHasTask' and count(parameter)=0]"
		[Register ("sendIfHasTask", "()V", "GetSendIfHasTaskHandler")]
		public virtual unsafe void SendIfHasTask ()
		{
			if (id_sendIfHasTask == IntPtr.Zero)
				id_sendIfHasTask = JNIEnv.GetMethodID (class_ref, "sendIfHasTask", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendIfHasTask);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendIfHasTask", "()V"));
			} finally {
			}
		}

	}
}
