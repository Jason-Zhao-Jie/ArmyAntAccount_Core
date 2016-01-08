using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/UploadTask", DoNotGenerateAcw=true)]
	public abstract partial class UploadTask : global::Com.Tencent.Upload.Task.CommandTask, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='DEFAULT_MAX_RETRY_TIMES']"
		[Register ("DEFAULT_MAX_RETRY_TIMES")]
		protected const int DefaultMaxRetryTimes = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='DEFAULT_MD5_FILE_LIMIT']"
		[Register ("DEFAULT_MD5_FILE_LIMIT")]
		protected const int DefaultMd5FileLimit = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='DEFAULT_PHOTO_SLICE_SIZE']"
		[Register ("DEFAULT_PHOTO_SLICE_SIZE")]
		protected const int DefaultPhotoSliceSize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='DEFAULT_VIDEO_SLICE_SIZE']"
		[Register ("DEFAULT_VIDEO_SLICE_SIZE")]
		protected const int DefaultVideoSliceSize = (int) 64;

		static IntPtr mConnectedIp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='mConnectedIp']"
		[Register ("mConnectedIp")]
		protected string MConnectedIp {
			get {
				if (mConnectedIp_jfieldId == IntPtr.Zero)
					mConnectedIp_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectedIp", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mConnectedIp_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectedIp_jfieldId == IntPtr.Zero)
					mConnectedIp_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectedIp", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mConnectedIp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConnectedPort_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='mConnectedPort']"
		[Register ("mConnectedPort")]
		protected int MConnectedPort {
			get {
				if (mConnectedPort_jfieldId == IntPtr.Zero)
					mConnectedPort_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectedPort", "I");
				return JNIEnv.GetIntField (Handle, mConnectedPort_jfieldId);
			}
			set {
				if (mConnectedPort_jfieldId == IntPtr.Zero)
					mConnectedPort_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectedPort", "I");
				try {
					JNIEnv.SetField (Handle, mConnectedPort_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/field[@name='mUrl']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask.FileCheckInfo']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/UploadTask$FileCheckInfo", DoNotGenerateAcw=true)]
		public partial class FileCheckInfo : global::Java.Lang.Object {


			static IntPtr check_content_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask.FileCheckInfo']/field[@name='check_content']"
			[Register ("check_content")]
			public string CheckContent {
				get {
					if (check_content_jfieldId == IntPtr.Zero)
						check_content_jfieldId = JNIEnv.GetFieldID (class_ref, "check_content", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, check_content_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (check_content_jfieldId == IntPtr.Zero)
						check_content_jfieldId = JNIEnv.GetFieldID (class_ref, "check_content", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, check_content_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr check_type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask.FileCheckInfo']/field[@name='check_type']"
			[Register ("check_type")]
			public int CheckType {
				get {
					if (check_type_jfieldId == IntPtr.Zero)
						check_type_jfieldId = JNIEnv.GetFieldID (class_ref, "check_type", "I");
					return JNIEnv.GetIntField (Handle, check_type_jfieldId);
				}
				set {
					if (check_type_jfieldId == IntPtr.Zero)
						check_type_jfieldId = JNIEnv.GetFieldID (class_ref, "check_type", "I");
					try {
						JNIEnv.SetField (Handle, check_type_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/UploadTask$FileCheckInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileCheckInfo); }
			}

			protected FileCheckInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_upload_task_UploadTask_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask.FileCheckInfo']/constructor[@name='UploadTask.FileCheckInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.task.UploadTask']]"
			[Register (".ctor", "(Lcom/tencent/upload/task/UploadTask;)V", "")]
			public unsafe FileCheckInfo (global::Com.Tencent.Upload.Task.UploadTask __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (FileCheckInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_upload_task_UploadTask_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_upload_task_UploadTask_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/task/UploadTask;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_task_UploadTask_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_task_UploadTask_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/UploadTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadTask); }
		}

		protected UploadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/constructor[@name='UploadTask' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UploadTask (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UploadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/constructor[@name='UploadTask' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe UploadTask (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UploadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/constructor[@name='UploadTask' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe UploadTask (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UploadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getBucketSize;
#pragma warning disable 0169
		static Delegate GetGetBucketSizeHandler ()
		{
			if (cb_getBucketSize == null)
				cb_getBucketSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBucketSize);
			return cb_getBucketSize;
		}

		static int n_GetBucketSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BucketSize;
		}
#pragma warning restore 0169

		protected abstract int BucketSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='getBucketSize' and count(parameter)=0]"
			[Register ("getBucketSize", "()I", "GetGetBucketSizeHandler")] get;
		}

		static Delegate cb_getDataSource;
#pragma warning disable 0169
		static Delegate GetGetDataSourceHandler ()
		{
			if (cb_getDataSource == null)
				cb_getDataSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSource);
			return cb_getDataSource;
		}

		static IntPtr n_GetDataSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSource);
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource;
		public virtual unsafe global::Com.Tencent.Upload.Task.Data.UploadDataSource DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Lcom/tencent/upload/task/data/UploadDataSource;", "GetGetDataSourceHandler")]
			get {
				if (id_getDataSource == IntPtr.Zero)
					id_getDataSource = JNIEnv.GetMethodID (class_ref, "getDataSource", "()Lcom/tencent/upload/task/data/UploadDataSource;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "()Lcom/tencent/upload/task/data/UploadDataSource;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDataSourceValid;
#pragma warning disable 0169
		static Delegate GetIsDataSourceValidHandler ()
		{
			if (cb_isDataSourceValid == null)
				cb_isDataSourceValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataSourceValid);
			return cb_isDataSourceValid;
		}

		static bool n_IsDataSourceValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataSourceValid;
		}
#pragma warning restore 0169

		static IntPtr id_isDataSourceValid;
		public virtual unsafe bool IsDataSourceValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='isDataSourceValid' and count(parameter)=0]"
			[Register ("isDataSourceValid", "()Z", "GetIsDataSourceValidHandler")]
			get {
				if (id_isDataSourceValid == IntPtr.Zero)
					id_isDataSourceValid = JNIEnv.GetMethodID (class_ref, "isDataSourceValid", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDataSourceValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDataSourceValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getUpoadProgress;
#pragma warning disable 0169
		static Delegate GetGetUpoadProgressHandler ()
		{
			if (cb_getUpoadProgress == null)
				cb_getUpoadProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetUpoadProgress);
			return cb_getUpoadProgress;
		}

		static float n_GetUpoadProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpoadProgress;
		}
#pragma warning restore 0169

		static IntPtr id_getUpoadProgress;
		public virtual unsafe float UpoadProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='getUpoadProgress' and count(parameter)=0]"
			[Register ("getUpoadProgress", "()F", "GetGetUpoadProgressHandler")]
			get {
				if (id_getUpoadProgress == IntPtr.Zero)
					id_getUpoadProgress = JNIEnv.GetMethodID (class_ref, "getUpoadProgress", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getUpoadProgress);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpoadProgress", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Cancel);
			return cb_cancel;
		}

		static bool n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()Z", "GetCancelHandler")]
		public virtual unsafe bool Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_cancel);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()Z"));
			} finally {
			}
		}

		static IntPtr id_cancelForError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='cancelForError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("cancelForError", "(ILjava/lang/String;)V", "")]
		protected unsafe void CancelForError (int p0, string p1)
		{
			if (id_cancelForError_ILjava_lang_String_ == IntPtr.Zero)
				id_cancelForError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cancelForError", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_cancelForError_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_onServerError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnServerError_ILjava_lang_String_Handler ()
		{
			if (cb_onServerError_ILjava_lang_String_ == null)
				cb_onServerError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnServerError_ILjava_lang_String_);
			return cb_onServerError_ILjava_lang_String_;
		}

		static void n_OnServerError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServerError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onServerError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onServerError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onServerError", "(ILjava/lang/String;)V", "GetOnServerError_ILjava_lang_String_Handler")]
		public virtual unsafe void OnServerError (int p0, string p1)
		{
			if (id_onServerError_ILjava_lang_String_ == IntPtr.Zero)
				id_onServerError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onServerError", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onServerError_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServerError", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onUploadError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUploadError_ILjava_lang_String_Handler ()
		{
			if (cb_onUploadError_ILjava_lang_String_ == null)
				cb_onUploadError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnUploadError_ILjava_lang_String_);
			return cb_onUploadError_ILjava_lang_String_;
		}

		static void n_OnUploadError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadError (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onUploadError", "(ILjava/lang/String;)V", "GetOnUploadError_ILjava_lang_String_Handler")]
		protected abstract void OnUploadError (int p0, string p1);

		static Delegate cb_onUploadProgress_JJ;
#pragma warning disable 0169
		static Delegate GetOnUploadProgress_JJHandler ()
		{
			if (cb_onUploadProgress_JJ == null)
				cb_onUploadProgress_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnUploadProgress_JJ);
			return cb_onUploadProgress_JJ;
		}

		static void n_OnUploadProgress_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadProgress (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onUploadProgress", "(JJ)V", "GetOnUploadProgress_JJHandler")]
		protected abstract void OnUploadProgress (long p0, long p1);

		static Delegate cb_onUploadSucceed_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnUploadSucceed_Ljava_lang_Object_Handler ()
		{
			if (cb_onUploadSucceed_Ljava_lang_Object_ == null)
				cb_onUploadSucceed_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUploadSucceed_Ljava_lang_Object_);
			return cb_onUploadSucceed_Ljava_lang_Object_;
		}

		static void n_OnUploadSucceed_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadSucceed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadSucceed' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUploadSucceed", "(Ljava/lang/Object;)V", "GetOnUploadSucceed_Ljava_lang_Object_Handler")]
		protected abstract void OnUploadSucceed (global::Java.Lang.Object p0);

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Pause);
			return cb_pause;
		}

		static bool n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()Z", "GetPauseHandler")]
		public virtual unsafe bool Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_pause);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()Z"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Resume);
			return cb_resume;
		}

		static bool n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()Z", "GetResumeHandler")]
		public virtual unsafe bool Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_resume);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setBusiMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBusiMsg_Ljava_lang_String_Handler ()
		{
			if (cb_setBusiMsg_Ljava_lang_String_ == null)
				cb_setBusiMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBusiMsg_Ljava_lang_String_);
			return cb_setBusiMsg_Ljava_lang_String_;
		}

		static void n_SetBusiMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBusiMsg (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBusiMsg_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='setBusiMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBusiMsg", "(Ljava/lang/String;)V", "GetSetBusiMsg_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBusiMsg (string p0)
		{
			if (id_setBusiMsg_Ljava_lang_String_ == IntPtr.Zero)
				id_setBusiMsg_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBusiMsg", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBusiMsg_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBusiMsg", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Tencent.Upload.Task.UploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.UploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/tencent/upload/task/UploadTask", DoNotGenerateAcw=true)]
	internal partial class UploadTaskInvoker : UploadTask {

		public UploadTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadTaskInvoker); }
		}

		static IntPtr id_getBucketSize;
		protected override unsafe int BucketSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='getBucketSize' and count(parameter)=0]"
			[Register ("getBucketSize", "()I", "GetGetBucketSizeHandler")]
			get {
				if (id_getBucketSize == IntPtr.Zero)
					id_getBucketSize = JNIEnv.GetMethodID (class_ref, "getBucketSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getBucketSize);
				} finally {
				}
			}
		}

		static IntPtr id_onUploadError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onUploadError", "(ILjava/lang/String;)V", "GetOnUploadError_ILjava_lang_String_Handler")]
		protected override unsafe void OnUploadError (int p0, string p1)
		{
			if (id_onUploadError_ILjava_lang_String_ == IntPtr.Zero)
				id_onUploadError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUploadError", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_onUploadError_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onUploadProgress_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onUploadProgress", "(JJ)V", "GetOnUploadProgress_JJHandler")]
		protected override unsafe void OnUploadProgress (long p0, long p1)
		{
			if (id_onUploadProgress_JJ == IntPtr.Zero)
				id_onUploadProgress_JJ = JNIEnv.GetMethodID (class_ref, "onUploadProgress", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_onUploadProgress_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_onUploadSucceed_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='UploadTask']/method[@name='onUploadSucceed' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUploadSucceed", "(Ljava/lang/Object;)V", "GetOnUploadSucceed_Ljava_lang_Object_Handler")]
		protected override unsafe void OnUploadSucceed (global::Java.Lang.Object p0)
		{
			if (id_onUploadSucceed_Ljava_lang_Object_ == IntPtr.Zero)
				id_onUploadSucceed_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onUploadSucceed", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onUploadSucceed_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}

}
