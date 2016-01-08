using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/CommandTask", DoNotGenerateAcw=true)]
	public abstract partial class CommandTask : global::Java.Lang.Object {


		static IntPtr mEndTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mEndTime']"
		[Register ("mEndTime")]
		protected long MEndTime {
			get {
				if (mEndTime_jfieldId == IntPtr.Zero)
					mEndTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndTime", "J");
				return JNIEnv.GetLongField (Handle, mEndTime_jfieldId);
			}
			set {
				if (mEndTime_jfieldId == IntPtr.Zero)
					mEndTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndTime", "J");
				try {
					JNIEnv.SetField (Handle, mEndTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mRetCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mRetCode']"
		[Register ("mRetCode")]
		protected int MRetCode {
			get {
				if (mRetCode_jfieldId == IntPtr.Zero)
					mRetCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetCode", "I");
				return JNIEnv.GetIntField (Handle, mRetCode_jfieldId);
			}
			set {
				if (mRetCode_jfieldId == IntPtr.Zero)
					mRetCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetCode", "I");
				try {
					JNIEnv.SetField (Handle, mRetCode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mRetMsg_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mRetMsg']"
		[Register ("mRetMsg")]
		protected string MRetMsg {
			get {
				if (mRetMsg_jfieldId == IntPtr.Zero)
					mRetMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetMsg", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRetMsg_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRetMsg_jfieldId == IntPtr.Zero)
					mRetMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetMsg", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mRetMsg_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSessionManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mSessionManager']"
		[Register ("mSessionManager")]
		protected global::Com.Tencent.Upload.Impl.SessionManager MSessionManager {
			get {
				if (mSessionManager_jfieldId == IntPtr.Zero)
					mSessionManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mSessionManager", "Lcom/tencent/upload/impl/SessionManager;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSessionManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Impl.SessionManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSessionManager_jfieldId == IntPtr.Zero)
					mSessionManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mSessionManager", "Lcom/tencent/upload/impl/SessionManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mSessionManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStartTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mStartTime']"
		[Register ("mStartTime")]
		protected long MStartTime {
			get {
				if (mStartTime_jfieldId == IntPtr.Zero)
					mStartTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartTime", "J");
				return JNIEnv.GetLongField (Handle, mStartTime_jfieldId);
			}
			set {
				if (mStartTime_jfieldId == IntPtr.Zero)
					mStartTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartTime", "J");
				try {
					JNIEnv.SetField (Handle, mStartTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTaskId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mTaskId']"
		[Register ("mTaskId")]
		protected int MTaskId {
			get {
				if (mTaskId_jfieldId == IntPtr.Zero)
					mTaskId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTaskId", "I");
				return JNIEnv.GetIntField (Handle, mTaskId_jfieldId);
			}
			set {
				if (mTaskId_jfieldId == IntPtr.Zero)
					mTaskId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTaskId", "I");
				try {
					JNIEnv.SetField (Handle, mTaskId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/field[@name='mUrl']"
		[Register ("mUrl")]
		protected string MUrl {
			get {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/CommandTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommandTask); }
		}

		protected CommandTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_upload_task_ICmdListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/constructor[@name='CommandTask' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.task.ICmdListener']]"
		[Register (".ctor", "(Lcom/tencent/upload/task/ICmdListener;)V", "")]
		public unsafe CommandTask (global::Com.Tencent.Upload.Task.ICmdListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CommandTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/task/ICmdListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/task/ICmdListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_task_ICmdListener_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_task_ICmdListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/task/ICmdListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_task_ICmdListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_task_ICmdListener_, __args);
			} finally {
			}
		}

		static Delegate cb_getAuth;
#pragma warning disable 0169
		static Delegate GetGetAuthHandler ()
		{
			if (cb_getAuth == null)
				cb_getAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuth);
			return cb_getAuth;
		}

		static IntPtr n_GetAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Auth);
		}
#pragma warning restore 0169

		static IntPtr id_getAuth;
		protected virtual unsafe global::FileCloud.StAuth Auth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getAuth' and count(parameter)=0]"
			[Register ("getAuth", "()LFileCloud/stAuth;", "GetGetAuthHandler")]
			get {
				if (id_getAuth == IntPtr.Zero)
					id_getAuth = JNIEnv.GetMethodID (class_ref, "getAuth", "()LFileCloud/stAuth;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::FileCloud.StAuth> (JNIEnv.CallObjectMethod  (Handle, id_getAuth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::FileCloud.StAuth> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuth", "()LFileCloud/stAuth;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBucket;
#pragma warning disable 0169
		static Delegate GetGetBucketHandler ()
		{
			if (cb_getBucket == null)
				cb_getBucket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBucket);
			return cb_getBucket;
		}

		static IntPtr n_GetBucket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Bucket);
		}
#pragma warning restore 0169

		static Delegate cb_setBucket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBucket_Ljava_lang_String_Handler ()
		{
			if (cb_setBucket_Ljava_lang_String_ == null)
				cb_setBucket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBucket_Ljava_lang_String_);
			return cb_setBucket_Ljava_lang_String_;
		}

		static void n_SetBucket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bucket = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBucket;
		static IntPtr id_setBucket_Ljava_lang_String_;
		public virtual unsafe string Bucket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getBucket' and count(parameter)=0]"
			[Register ("getBucket", "()Ljava/lang/String;", "GetGetBucketHandler")]
			get {
				if (id_getBucket == IntPtr.Zero)
					id_getBucket = JNIEnv.GetMethodID (class_ref, "getBucket", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBucket), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBucket", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='setBucket' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBucket", "(Ljava/lang/String;)V", "GetSetBucket_Ljava_lang_String_Handler")]
			set {
				if (id_setBucket_Ljava_lang_String_ == IntPtr.Zero)
					id_setBucket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBucket", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBucket_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBucket", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReportBiz;
#pragma warning disable 0169
		static Delegate GetGetReportBizHandler ()
		{
			if (cb_getReportBiz == null)
				cb_getReportBiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReportBiz);
			return cb_getReportBiz;
		}

		static IntPtr n_GetReportBiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReportBiz);
		}
#pragma warning restore 0169

		static IntPtr id_getReportBiz;
		protected virtual unsafe string ReportBiz {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getReportBiz' and count(parameter)=0]"
			[Register ("getReportBiz", "()Ljava/lang/String;", "GetGetReportBizHandler")]
			get {
				if (id_getReportBiz == IntPtr.Zero)
					id_getReportBiz = JNIEnv.GetMethodID (class_ref, "getReportBiz", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getReportBiz), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReportBiz", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetCode;
#pragma warning disable 0169
		static Delegate GetGetRetCodeHandler ()
		{
			if (cb_getRetCode == null)
				cb_getRetCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetCode);
			return cb_getRetCode;
		}

		static int n_GetRetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetCode;
		}
#pragma warning restore 0169

		static IntPtr id_getRetCode;
		public virtual unsafe int RetCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getRetCode' and count(parameter)=0]"
			[Register ("getRetCode", "()I", "GetGetRetCodeHandler")]
			get {
				if (id_getRetCode == IntPtr.Zero)
					id_getRetCode = JNIEnv.GetMethodID (class_ref, "getRetCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRetCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRetMsg;
#pragma warning disable 0169
		static Delegate GetGetRetMsgHandler ()
		{
			if (cb_getRetMsg == null)
				cb_getRetMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetMsg);
			return cb_getRetMsg;
		}

		static IntPtr n_GetRetMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RetMsg);
		}
#pragma warning restore 0169

		static IntPtr id_getRetMsg;
		public virtual unsafe string RetMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getRetMsg' and count(parameter)=0]"
			[Register ("getRetMsg", "()Ljava/lang/String;", "GetGetRetMsgHandler")]
			get {
				if (id_getRetMsg == IntPtr.Zero)
					id_getRetMsg = JNIEnv.GetMethodID (class_ref, "getRetMsg", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRetMsg), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetMsg", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTaskId;
#pragma warning disable 0169
		static Delegate GetGetTaskIdHandler ()
		{
			if (cb_getTaskId == null)
				cb_getTaskId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTaskId);
			return cb_getTaskId;
		}

		static int n_GetTaskId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskId;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskId;
		public virtual unsafe int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getTaskId' and count(parameter)=0]"
			[Register ("getTaskId", "()I", "GetGetTaskIdHandler")]
			get {
				if (id_getTaskId == IntPtr.Zero)
					id_getTaskId = JNIEnv.GetMethodID (class_ref, "getTaskId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTaskId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaskId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_authIsEmpty;
#pragma warning disable 0169
		static Delegate GetAuthIsEmptyHandler ()
		{
			if (cb_authIsEmpty == null)
				cb_authIsEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AuthIsEmpty);
			return cb_authIsEmpty;
		}

		static bool n_AuthIsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuthIsEmpty ();
		}
#pragma warning restore 0169

		static IntPtr id_authIsEmpty;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='authIsEmpty' and count(parameter)=0]"
		[Register ("authIsEmpty", "()Z", "GetAuthIsEmptyHandler")]
		public virtual unsafe bool AuthIsEmpty ()
		{
			if (id_authIsEmpty == IntPtr.Zero)
				id_authIsEmpty = JNIEnv.GetMethodID (class_ref, "authIsEmpty", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_authIsEmpty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authIsEmpty", "()Z"));
			} finally {
			}
		}

		static Delegate cb_checkTaskValidity_Lcom_tencent_upload_Const_FileType_;
#pragma warning disable 0169
		static Delegate GetCheckTaskValidity_Lcom_tencent_upload_Const_FileType_Handler ()
		{
			if (cb_checkTaskValidity_Lcom_tencent_upload_Const_FileType_ == null)
				cb_checkTaskValidity_Lcom_tencent_upload_Const_FileType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CheckTaskValidity_Lcom_tencent_upload_Const_FileType_);
			return cb_checkTaskValidity_Lcom_tencent_upload_Const_FileType_;
		}

		static bool n_CheckTaskValidity_Lcom_tencent_upload_Const_FileType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Upload.Const.FileType p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckTaskValidity (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkTaskValidity_Lcom_tencent_upload_Const_FileType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='checkTaskValidity' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.Const.FileType']]"
		[Register ("checkTaskValidity", "(Lcom/tencent/upload/Const$FileType;)Z", "GetCheckTaskValidity_Lcom_tencent_upload_Const_FileType_Handler")]
		public virtual unsafe bool CheckTaskValidity (global::Com.Tencent.Upload.Const.FileType p0)
		{
			if (id_checkTaskValidity_Lcom_tencent_upload_Const_FileType_ == IntPtr.Zero)
				id_checkTaskValidity_Lcom_tencent_upload_Const_FileType_ = JNIEnv.GetMethodID (class_ref, "checkTaskValidity", "(Lcom/tencent/upload/Const$FileType;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_checkTaskValidity_Lcom_tencent_upload_Const_FileType_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkTaskValidity", "(Lcom/tencent/upload/Const$FileType;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static IntPtr n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecrypt_Ljava_lang_String_Handler")]
		protected virtual unsafe string Decrypt (string p0)
		{
			if (id_decrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrypt", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_encrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_lang_String_Handler ()
		{
			if (cb_encrypt_Ljava_lang_String_ == null)
				cb_encrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encrypt_Ljava_lang_String_);
			return cb_encrypt_Ljava_lang_String_;
		}

		static IntPtr n_Encrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encrypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncrypt_Ljava_lang_String_Handler")]
		protected virtual unsafe string Encrypt (string p0)
		{
			if (id_encrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_encrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encrypt", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAbsolutePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAbsolutePath_Ljava_lang_String_Handler ()
		{
			if (cb_getAbsolutePath_Ljava_lang_String_ == null)
				cb_getAbsolutePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAbsolutePath_Ljava_lang_String_);
			return cb_getAbsolutePath_Ljava_lang_String_;
		}

		static IntPtr n_GetAbsolutePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAbsolutePath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAbsolutePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='getAbsolutePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAbsolutePath", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAbsolutePath_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetAbsolutePath (string p0)
		{
			if (id_getAbsolutePath_Ljava_lang_String_ == IntPtr.Zero)
				id_getAbsolutePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAbsolutePath", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAbsolutePath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAbsolutePath", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onCancel_I;
#pragma warning disable 0169
		static Delegate GetOnCancel_IHandler ()
		{
			if (cb_onCancel_I == null)
				cb_onCancel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnCancel_I);
			return cb_onCancel_I;
		}

		static void n_OnCancel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCancel", "(I)V", "GetOnCancel_IHandler")]
		public virtual unsafe void OnCancel (int p0)
		{
			if (id_onCancel_I == IntPtr.Zero)
				id_onCancel_I = JNIEnv.GetMethodID (class_ref, "onCancel", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCancel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancel", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnecting;
#pragma warning disable 0169
		static Delegate GetOnConnectingHandler ()
		{
			if (cb_onConnecting == null)
				cb_onConnecting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnecting);
			return cb_onConnecting;
		}

		static void n_OnConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnecting ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='onConnecting' and count(parameter)=0]"
		[Register ("onConnecting", "()V", "GetOnConnectingHandler")]
		public virtual unsafe void OnConnecting ()
		{
			if (id_onConnecting == IntPtr.Zero)
				id_onConnecting = JNIEnv.GetMethodID (class_ref, "onConnecting", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnecting);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnecting", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_ZHandler ()
		{
			if (cb_onError_ILjava_lang_String_Z == null)
				cb_onError_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_OnError_ILjava_lang_String_Z);
			return cb_onError_ILjava_lang_String_Z;
		}

		static void n_OnError_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onError_ILjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("onError", "(ILjava/lang/String;Z)V", "GetOnError_ILjava_lang_String_ZHandler")]
		public virtual unsafe void OnError (int p0, string p1, bool p2)
		{
			if (id_onError_ILjava_lang_String_Z == IntPtr.Zero)
				id_onError_ILjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onError_ILjava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(ILjava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onTaskFinished_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnTaskFinished_ILjava_lang_String_Handler ()
		{
			if (cb_onTaskFinished_ILjava_lang_String_ == null)
				cb_onTaskFinished_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnTaskFinished_ILjava_lang_String_);
			return cb_onTaskFinished_ILjava_lang_String_;
		}

		static void n_OnTaskFinished_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskFinished (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onTaskFinished_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='onTaskFinished' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onTaskFinished", "(ILjava/lang/String;)V", "GetOnTaskFinished_ILjava_lang_String_Handler")]
		protected virtual unsafe void OnTaskFinished (int p0, string p1)
		{
			if (id_onTaskFinished_ILjava_lang_String_ == IntPtr.Zero)
				id_onTaskFinished_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onTaskFinished", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTaskFinished_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTaskFinished", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setAppid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppid_Ljava_lang_String_Handler ()
		{
			if (cb_setAppid_Ljava_lang_String_ == null)
				cb_setAppid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppid_Ljava_lang_String_);
			return cb_setAppid_Ljava_lang_String_;
		}

		static void n_SetAppid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='setAppid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppid", "(Ljava/lang/String;)V", "GetSetAppid_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppid (string p0)
		{
			if (id_setAppid_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppid", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppid_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppid", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAuth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuth_Ljava_lang_String_Handler ()
		{
			if (cb_setAuth_Ljava_lang_String_ == null)
				cb_setAuth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuth_Ljava_lang_String_);
			return cb_setAuth_Ljava_lang_String_;
		}

		static void n_SetAuth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.CommandTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.CommandTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAuth_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='CommandTask']/method[@name='setAuth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuth", "(Ljava/lang/String;)V", "GetSetAuth_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAuth (string p0)
		{
			if (id_setAuth_Ljava_lang_String_ == IntPtr.Zero)
				id_setAuth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuth", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAuth_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuth", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/tencent/upload/task/CommandTask", DoNotGenerateAcw=true)]
	internal partial class CommandTaskInvoker : CommandTask {

		public CommandTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommandTaskInvoker); }
		}

	}

}
