using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']"
	[global::Android.Runtime.Register ("com/tencent/upload/impl/UploadManagerImpl", DoNotGenerateAcw=true)]
	public partial class UploadManagerImpl : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/impl/UploadManagerImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadManagerImpl); }
		}

		protected UploadManagerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/constructor[@name='UploadManagerImpl' and count(parameter)=2 and parameter[1][@type='com.tencent.upload.Const.FileType'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;)V", "")]
		public unsafe UploadManagerImpl (global::Com.Tencent.Upload.Const.FileType p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (UploadManagerImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getUploadTasks;
#pragma warning disable 0169
		static Delegate GetGetUploadTasksHandler ()
		{
			if (cb_getUploadTasks == null)
				cb_getUploadTasks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadTasks);
			return cb_getUploadTasks;
		}

		static IntPtr n_GetUploadTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Tencent.Upload.Task.UploadTask>.ToLocalJniHandle (__this.UploadTasks);
		}
#pragma warning restore 0169

		static IntPtr id_getUploadTasks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Tencent.Upload.Task.UploadTask> UploadTasks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='getUploadTasks' and count(parameter)=0]"
			[Register ("getUploadTasks", "()Ljava/util/List;", "GetGetUploadTasksHandler")]
			get {
				if (id_getUploadTasks == IntPtr.Zero)
					id_getUploadTasks = JNIEnv.GetMethodID (class_ref, "getUploadTasks", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Tencent.Upload.Task.UploadTask>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUploadTasks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Tencent.Upload.Task.UploadTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUploadTasks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel_I;
#pragma warning disable 0169
		static Delegate GetCancel_IHandler ()
		{
			if (cb_cancel_I == null)
				cb_cancel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Cancel_I);
			return cb_cancel_I;
		}

		static bool n_Cancel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cancel", "(I)Z", "GetCancel_IHandler")]
		public virtual unsafe bool Cancel (int p0)
		{
			if (id_cancel_I == IntPtr.Zero)
				id_cancel_I = JNIEnv.GetMethodID (class_ref, "cancel", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_cancel_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Clear);
			return cb_clear;
		}

		static bool n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Z", "GetClearHandler")]
		public virtual unsafe bool Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_clear);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Z"));
			} finally {
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
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_pause_I;
#pragma warning disable 0169
		static Delegate GetPause_IHandler ()
		{
			if (cb_pause_I == null)
				cb_pause_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Pause_I);
			return cb_pause_I;
		}

		static bool n_Pause_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_pause_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pause", "(I)Z", "GetPause_IHandler")]
		public virtual unsafe bool Pause (int p0)
		{
			if (id_pause_I == IntPtr.Zero)
				id_pause_I = JNIEnv.GetMethodID (class_ref, "pause", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_pause_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_pauseAll;
#pragma warning disable 0169
		static Delegate GetPauseAllHandler ()
		{
			if (cb_pauseAll == null)
				cb_pauseAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_PauseAll);
			return cb_pauseAll;
		}

		static bool n_PauseAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PauseAll ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='pauseAll' and count(parameter)=0]"
		[Register ("pauseAll", "()Z", "GetPauseAllHandler")]
		public virtual unsafe bool PauseAll ()
		{
			if (id_pauseAll == IntPtr.Zero)
				id_pauseAll = JNIEnv.GetMethodID (class_ref, "pauseAll", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_pauseAll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseAll", "()Z"));
			} finally {
			}
		}

		static Delegate cb_resume_I;
#pragma warning disable 0169
		static Delegate GetResume_IHandler ()
		{
			if (cb_resume_I == null)
				cb_resume_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Resume_I);
			return cb_resume_I;
		}

		static bool n_Resume_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Resume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resume_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='resume' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resume", "(I)Z", "GetResume_IHandler")]
		public virtual unsafe bool Resume (int p0)
		{
			if (id_resume_I == IntPtr.Zero)
				id_resume_I = JNIEnv.GetMethodID (class_ref, "resume", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_resume_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_resumeAll;
#pragma warning disable 0169
		static Delegate GetResumeAllHandler ()
		{
			if (cb_resumeAll == null)
				cb_resumeAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ResumeAll);
			return cb_resumeAll;
		}

		static bool n_ResumeAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResumeAll ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='resumeAll' and count(parameter)=0]"
		[Register ("resumeAll", "()Z", "GetResumeAllHandler")]
		public virtual unsafe bool ResumeAll ()
		{
			if (id_resumeAll == IntPtr.Zero)
				id_resumeAll = JNIEnv.GetMethodID (class_ref, "resumeAll", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_resumeAll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeAll", "()Z"));
			} finally {
			}
		}

		static Delegate cb_sendCommand_Lcom_tencent_upload_task_CommandTask_;
#pragma warning disable 0169
		static Delegate GetSendCommand_Lcom_tencent_upload_task_CommandTask_Handler ()
		{
			if (cb_sendCommand_Lcom_tencent_upload_task_CommandTask_ == null)
				cb_sendCommand_Lcom_tencent_upload_task_CommandTask_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendCommand_Lcom_tencent_upload_task_CommandTask_);
			return cb_sendCommand_Lcom_tencent_upload_task_CommandTask_;
		}

		static bool n_SendCommand_Lcom_tencent_upload_task_CommandTask_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Upload.Task.CommandTask p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendCommand (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendCommand_Lcom_tencent_upload_task_CommandTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='sendCommand' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.task.CommandTask']]"
		[Register ("sendCommand", "(Lcom/tencent/upload/task/CommandTask;)Z", "GetSendCommand_Lcom_tencent_upload_task_CommandTask_Handler")]
		public virtual unsafe bool SendCommand (global::Com.Tencent.Upload.Task.CommandTask p0)
		{
			if (id_sendCommand_Lcom_tencent_upload_task_CommandTask_ == IntPtr.Zero)
				id_sendCommand_Lcom_tencent_upload_task_CommandTask_ = JNIEnv.GetMethodID (class_ref, "sendCommand", "(Lcom/tencent/upload/task/CommandTask;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_sendCommand_Lcom_tencent_upload_task_CommandTask_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCommand", "(Lcom/tencent/upload/task/CommandTask;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setBackgroundMode_Z;
#pragma warning disable 0169
		static Delegate GetSetBackgroundMode_ZHandler ()
		{
			if (cb_setBackgroundMode_Z == null)
				cb_setBackgroundMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBackgroundMode_Z);
			return cb_setBackgroundMode_Z;
		}

		static void n_SetBackgroundMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='setBackgroundMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBackgroundMode", "(Z)V", "GetSetBackgroundMode_ZHandler")]
		public virtual unsafe void SetBackgroundMode (bool p0)
		{
			if (id_setBackgroundMode_Z == IntPtr.Zero)
				id_setBackgroundMode_Z = JNIEnv.GetMethodID (class_ref, "setBackgroundMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBackgroundMode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundMode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_;
#pragma warning disable 0169
		static Delegate GetSetServerEnv_Lcom_tencent_upload_Const_ServerEnv_Handler ()
		{
			if (cb_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_ == null)
				cb_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerEnv_Lcom_tencent_upload_Const_ServerEnv_);
			return cb_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_;
		}

		static void n_SetServerEnv_Lcom_tencent_upload_Const_ServerEnv_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Upload.Const.ServerEnv p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.ServerEnv> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServerEnv (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='setServerEnv' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.Const.ServerEnv']]"
		[Register ("setServerEnv", "(Lcom/tencent/upload/Const$ServerEnv;)V", "GetSetServerEnv_Lcom_tencent_upload_Const_ServerEnv_Handler")]
		public virtual unsafe void SetServerEnv (global::Com.Tencent.Upload.Const.ServerEnv p0)
		{
			if (id_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_ == IntPtr.Zero)
				id_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_ = JNIEnv.GetMethodID (class_ref, "setServerEnv", "(Lcom/tencent/upload/Const$ServerEnv;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setServerEnv_Lcom_tencent_upload_Const_ServerEnv_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerEnv", "(Lcom/tencent/upload/Const$ServerEnv;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_upload_Lcom_tencent_upload_task_UploadTask_;
#pragma warning disable 0169
		static Delegate GetUpload_Lcom_tencent_upload_task_UploadTask_Handler ()
		{
			if (cb_upload_Lcom_tencent_upload_task_UploadTask_ == null)
				cb_upload_Lcom_tencent_upload_task_UploadTask_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Upload_Lcom_tencent_upload_task_UploadTask_);
			return cb_upload_Lcom_tencent_upload_task_UploadTask_;
		}

		static bool n_Upload_Lcom_tencent_upload_task_UploadTask_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Impl.UploadManagerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.UploadManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Upload.Task.UploadTask p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Upload (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_upload_Lcom_tencent_upload_task_UploadTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='upload' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.task.UploadTask']]"
		[Register ("upload", "(Lcom/tencent/upload/task/UploadTask;)Z", "GetUpload_Lcom_tencent_upload_task_UploadTask_Handler")]
		public virtual unsafe bool Upload (global::Com.Tencent.Upload.Task.UploadTask p0)
		{
			if (id_upload_Lcom_tencent_upload_task_UploadTask_ == IntPtr.Zero)
				id_upload_Lcom_tencent_upload_task_UploadTask_ = JNIEnv.GetMethodID (class_ref, "upload", "(Lcom/tencent/upload/task/UploadTask;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_upload_Lcom_tencent_upload_task_UploadTask_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "upload", "(Lcom/tencent/upload/task/UploadTask;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.impl']/class[@name='UploadManagerImpl']/method[@name='uploadLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date']]"
		[Register ("uploadLog", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)Z", "")]
		public static unsafe bool UploadLog (string p0, global::Java.Util.Date p1, global::Java.Util.Date p2)
		{
			if (id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "uploadLog", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_uploadLog_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
