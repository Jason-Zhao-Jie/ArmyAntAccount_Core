using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/impl/VideoUploadTask", DoNotGenerateAcw=true)]
	public partial class VideoUploadTask : global::Com.Tencent.Upload.Task.UploadTask {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/impl/VideoUploadTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoUploadTask); }
		}

		protected VideoUploadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/constructor[@name='VideoUploadTask' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe VideoUploadTask (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoUploadTask)) {
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
			global::Com.Tencent.Upload.Task.Impl.VideoUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.VideoUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BucketSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBucketSize;
		protected override unsafe int BucketSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='getBucketSize' and count(parameter)=0]"
			[Register ("getBucketSize", "()I", "GetGetBucketSizeHandler")]
			get {
				if (id_getBucketSize == IntPtr.Zero)
					id_getBucketSize = JNIEnv.GetMethodID (class_ref, "getBucketSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBucketSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBucketSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFileType;
#pragma warning disable 0169
		static Delegate GetGetFileTypeHandler ()
		{
			if (cb_getFileType == null)
				cb_getFileType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileType);
			return cb_getFileType;
		}

		static IntPtr n_GetFileType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Impl.VideoUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.VideoUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe global::Com.Tencent.Upload.Const.FileType FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='getFileType' and count(parameter)=0]"
			[Register ("getFileType", "()Lcom/tencent/upload/Const$FileType;", "GetGetFileTypeHandler")]
			get {
				if (id_getFileType == IntPtr.Zero)
					id_getFileType = JNIEnv.GetMethodID (class_ref, "getFileType", "()Lcom/tencent/upload/Const$FileType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (JNIEnv.CallObjectMethod  (Handle, id_getFileType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileType", "()Lcom/tencent/upload/Const$FileType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFileSha1_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='getFileSha1' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileSha1", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string GetFileSha1 (global::Java.IO.File p0)
		{
			if (id_getFileSha1_Ljava_io_File_ == IntPtr.Zero)
				id_getFileSha1_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getFileSha1", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileSha1_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Tencent.Upload.Task.Impl.VideoUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.VideoUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUploadError_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='onUploadError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUploadError_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUploadError", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

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
			global::Com.Tencent.Upload.Task.Impl.VideoUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.VideoUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadProgress (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUploadProgress_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='onUploadProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onUploadProgress", "(JJ)V", "GetOnUploadProgress_JJHandler")]
		protected override unsafe void OnUploadProgress (long p0, long p1)
		{
			if (id_onUploadProgress_JJ == IntPtr.Zero)
				id_onUploadProgress_JJ = JNIEnv.GetMethodID (class_ref, "onUploadProgress", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUploadProgress_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUploadProgress", "(JJ)V"), __args);
			} finally {
			}
		}

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
			global::Com.Tencent.Upload.Task.Impl.VideoUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.VideoUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadSucceed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUploadSucceed_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='VideoUploadTask']/method[@name='onUploadSucceed' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUploadSucceed", "(Ljava/lang/Object;)V", "GetOnUploadSucceed_Ljava_lang_Object_Handler")]
		protected override unsafe void OnUploadSucceed (global::Java.Lang.Object p0)
		{
			if (id_onUploadSucceed_Ljava_lang_Object_ == IntPtr.Zero)
				id_onUploadSucceed_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onUploadSucceed", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUploadSucceed_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUploadSucceed", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
