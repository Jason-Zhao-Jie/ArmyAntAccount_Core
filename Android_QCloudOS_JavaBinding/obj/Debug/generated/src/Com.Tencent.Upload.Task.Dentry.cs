using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/Dentry", DoNotGenerateAcw=true)]
	public partial class Dentry : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='BUCKET']"
		[Register ("BUCKET")]
		public const int Bucket = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='DIR']"
		[Register ("DIR")]
		public const int Dir = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='FILE']"
		[Register ("FILE")]
		public const int File = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='ListBoth']"
		[Register ("ListBoth")]
		public const int ListBoth = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='ListDirOnly']"
		[Register ("ListDirOnly")]
		public const int ListDirOnly = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='ListFileOnly']"
		[Register ("ListFileOnly")]
		public const int ListFileOnly = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='MORE']"
		[Register ("MORE")]
		public const int More = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public const int Video = (int) 3;

		static IntPtr accessUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='accessUrl']"
		[Register ("accessUrl")]
		public string AccessUrl {
			get {
				if (accessUrl_jfieldId == IntPtr.Zero)
					accessUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "accessUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, accessUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (accessUrl_jfieldId == IntPtr.Zero)
					accessUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "accessUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, accessUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr attribute_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='attribute']"
		[Register ("attribute")]
		public string Attribute {
			get {
				if (attribute_jfieldId == IntPtr.Zero)
					attribute_jfieldId = JNIEnv.GetFieldID (class_ref, "attribute", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, attribute_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (attribute_jfieldId == IntPtr.Zero)
					attribute_jfieldId = JNIEnv.GetFieldID (class_ref, "attribute", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, attribute_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr createTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='createTime']"
		[Register ("createTime")]
		public long CreateTime {
			get {
				if (createTime_jfieldId == IntPtr.Zero)
					createTime_jfieldId = JNIEnv.GetFieldID (class_ref, "createTime", "J");
				return JNIEnv.GetLongField (Handle, createTime_jfieldId);
			}
			set {
				if (createTime_jfieldId == IntPtr.Zero)
					createTime_jfieldId = JNIEnv.GetFieldID (class_ref, "createTime", "J");
				try {
					JNIEnv.SetField (Handle, createTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fileLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='fileLength']"
		[Register ("fileLength")]
		public long FileLength {
			get {
				if (fileLength_jfieldId == IntPtr.Zero)
					fileLength_jfieldId = JNIEnv.GetFieldID (class_ref, "fileLength", "J");
				return JNIEnv.GetLongField (Handle, fileLength_jfieldId);
			}
			set {
				if (fileLength_jfieldId == IntPtr.Zero)
					fileLength_jfieldId = JNIEnv.GetFieldID (class_ref, "fileLength", "J");
				try {
					JNIEnv.SetField (Handle, fileLength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fileSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='fileSize']"
		[Register ("fileSize")]
		public long FileSize {
			get {
				if (fileSize_jfieldId == IntPtr.Zero)
					fileSize_jfieldId = JNIEnv.GetFieldID (class_ref, "fileSize", "J");
				return JNIEnv.GetLongField (Handle, fileSize_jfieldId);
			}
			set {
				if (fileSize_jfieldId == IntPtr.Zero)
					fileSize_jfieldId = JNIEnv.GetFieldID (class_ref, "fileSize", "J");
				try {
					JNIEnv.SetField (Handle, fileSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr modifyTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='modifyTime']"
		[Register ("modifyTime")]
		public long ModifyTime {
			get {
				if (modifyTime_jfieldId == IntPtr.Zero)
					modifyTime_jfieldId = JNIEnv.GetFieldID (class_ref, "modifyTime", "J");
				return JNIEnv.GetLongField (Handle, modifyTime_jfieldId);
			}
			set {
				if (modifyTime_jfieldId == IntPtr.Zero)
					modifyTime_jfieldId = JNIEnv.GetFieldID (class_ref, "modifyTime", "J");
				try {
					JNIEnv.SetField (Handle, modifyTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='path']"
		[Register ("path")]
		public string Path {
			get {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, path_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, path_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='sha']"
		[Register ("sha")]
		public string Sha {
			get {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sha_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sha_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				return JNIEnv.GetIntField (Handle, type_jfieldId);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				try {
					JNIEnv.SetField (Handle, type_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/Dentry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dentry); }
		}

		protected Dentry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/constructor[@name='Dentry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Dentry (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Dentry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_LFileCloud_FileDirInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/constructor[@name='Dentry' and count(parameter)=1 and parameter[1][@type='FileCloud.FileDirInfo']]"
		[Register (".ctor", "(LFileCloud/FileDirInfo;)V", "")]
		public unsafe Dentry (global::FileCloud.FileDirInfo p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Dentry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/FileDirInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/FileDirInfo;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_FileDirInfo_ == IntPtr.Zero)
					id_ctor_LFileCloud_FileDirInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/FileDirInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_FileDirInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_FileDirInfo_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/constructor[@name='Dentry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dentry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Dentry)) {
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

		static Delegate cb_getVideoInfo;
#pragma warning disable 0169
		static Delegate GetGetVideoInfoHandler ()
		{
			if (cb_getVideoInfo == null)
				cb_getVideoInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoInfo);
			return cb_getVideoInfo;
		}

		static IntPtr n_GetVideoInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoInfo;
		public virtual unsafe global::Com.Tencent.Upload.Task.VideoInfo VideoInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='getVideoInfo' and count(parameter)=0]"
			[Register ("getVideoInfo", "()Lcom/tencent/upload/task/VideoInfo;", "GetGetVideoInfoHandler")]
			get {
				if (id_getVideoInfo == IntPtr.Zero)
					id_getVideoInfo = JNIEnv.GetMethodID (class_ref, "getVideoInfo", "()Lcom/tencent/upload/task/VideoInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.VideoInfo> (JNIEnv.CallObjectMethod  (Handle, id_getVideoInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.VideoInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoInfo", "()Lcom/tencent/upload/task/VideoInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_copy_Lcom_tencent_upload_task_Dentry_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_tencent_upload_task_Dentry_Handler ()
		{
			if (cb_copy_Lcom_tencent_upload_task_Dentry_ == null)
				cb_copy_Lcom_tencent_upload_task_Dentry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_tencent_upload_task_Dentry_);
			return cb_copy_Lcom_tencent_upload_task_Dentry_;
		}

		static IntPtr n_Copy_Lcom_tencent_upload_task_Dentry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Upload.Task.Dentry p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Copy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_copy_Lcom_tencent_upload_task_Dentry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.tencent.upload.task.Dentry']]"
		[Register ("copy", "(Lcom/tencent/upload/task/Dentry;)Lcom/tencent/upload/task/Dentry;", "GetCopy_Lcom_tencent_upload_task_Dentry_Handler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry Copy (global::Com.Tencent.Upload.Task.Dentry p0)
		{
			if (id_copy_Lcom_tencent_upload_task_Dentry_ == IntPtr.Zero)
				id_copy_Lcom_tencent_upload_task_Dentry_ = JNIEnv.GetMethodID (class_ref, "copy", "(Lcom/tencent/upload/task/Dentry;)Lcom/tencent/upload/task/Dentry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Tencent.Upload.Task.Dentry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_copy_Lcom_tencent_upload_task_Dentry_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "(Lcom/tencent/upload/task/Dentry;)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAccessUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessUrl_Ljava_lang_String_ == null)
				cb_setAccessUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessUrl_Ljava_lang_String_);
			return cb_setAccessUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetAccessUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccessUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAccessUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setAccessUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccessUrl", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;", "GetSetAccessUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetAccessUrl (string p0)
		{
			if (id_setAccessUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessUrl", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Upload.Task.Dentry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setAccessUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessUrl", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_setAttribute_Ljava_lang_String_ == null)
				cb_setAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttribute_Ljava_lang_String_);
			return cb_setAttribute_Ljava_lang_String_;
		}

		static IntPtr n_SetAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAttribute (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAttribute", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;", "GetSetAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetAttribute (string p0)
		{
			if (id_setAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_setAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAttribute", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Upload.Task.Dentry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setAttribute_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttribute", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCreateTime_J;
#pragma warning disable 0169
		static Delegate GetSetCreateTime_JHandler ()
		{
			if (cb_setCreateTime_J == null)
				cb_setCreateTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetCreateTime_J);
			return cb_setCreateTime_J;
		}

		static IntPtr n_SetCreateTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCreateTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCreateTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setCreateTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setCreateTime", "(J)Lcom/tencent/upload/task/Dentry;", "GetSetCreateTime_JHandler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetCreateTime (long p0)
		{
			if (id_setCreateTime_J == IntPtr.Zero)
				id_setCreateTime_J = JNIEnv.GetMethodID (class_ref, "setCreateTime", "(J)Lcom/tencent/upload/task/Dentry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setCreateTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreateTime", "(J)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFileLength_J;
#pragma warning disable 0169
		static Delegate GetSetFileLength_JHandler ()
		{
			if (cb_setFileLength_J == null)
				cb_setFileLength_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetFileLength_J);
			return cb_setFileLength_J;
		}

		static IntPtr n_SetFileLength_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFileLength (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setFileLength_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setFileLength' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFileLength", "(J)Lcom/tencent/upload/task/Dentry;", "GetSetFileLength_JHandler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetFileLength (long p0)
		{
			if (id_setFileLength_J == IntPtr.Zero)
				id_setFileLength_J = JNIEnv.GetMethodID (class_ref, "setFileLength", "(J)Lcom/tencent/upload/task/Dentry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setFileLength_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileLength", "(J)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setModifyTime_J;
#pragma warning disable 0169
		static Delegate GetSetModifyTime_JHandler ()
		{
			if (cb_setModifyTime_J == null)
				cb_setModifyTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetModifyTime_J);
			return cb_setModifyTime_J;
		}

		static IntPtr n_SetModifyTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetModifyTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setModifyTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setModifyTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setModifyTime", "(J)Lcom/tencent/upload/task/Dentry;", "GetSetModifyTime_JHandler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetModifyTime (long p0)
		{
			if (id_setModifyTime_J == IntPtr.Zero)
				id_setModifyTime_J = JNIEnv.GetMethodID (class_ref, "setModifyTime", "(J)Lcom/tencent/upload/task/Dentry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setModifyTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModifyTime", "(J)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetName (string p0)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Upload.Task.Dentry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static IntPtr n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPath", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;", "GetSetPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetPath (string p0)
		{
			if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
				id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Upload.Task.Dentry __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPath", "(Ljava/lang/String;)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetType_I);
			return cb_setType_I;
		}

		static IntPtr n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Upload.Task.Dentry __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetType (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='Dentry']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)Lcom/tencent/upload/task/Dentry;", "GetSetType_IHandler")]
		public virtual unsafe global::Com.Tencent.Upload.Task.Dentry SetType (int p0)
		{
			if (id_setType_I == IntPtr.Zero)
				id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)Lcom/tencent/upload/task/Dentry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallObjectMethod  (Handle, id_setType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Dentry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)Lcom/tencent/upload/task/Dentry;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
