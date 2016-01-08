using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/data/FileInfo", DoNotGenerateAcw=true)]
	public partial class FileInfo : global::Java.Lang.Object {


		static IntPtr extendInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']/field[@name='extendInfo']"
		[Register ("extendInfo")]
		public global::System.Collections.IDictionary ExtendInfo {
			get {
				if (extendInfo_jfieldId == IntPtr.Zero)
					extendInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "extendInfo", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, extendInfo_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (extendInfo_jfieldId == IntPtr.Zero)
					extendInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "extendInfo", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, extendInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fileId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']/field[@name='fileId']"
		[Register ("fileId")]
		public string FileId {
			get {
				if (fileId_jfieldId == IntPtr.Zero)
					fileId_jfieldId = JNIEnv.GetFieldID (class_ref, "fileId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, fileId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileId_jfieldId == IntPtr.Zero)
					fileId_jfieldId = JNIEnv.GetFieldID (class_ref, "fileId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, fileId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fileType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']/field[@name='fileType']"
		[Register ("fileType")]
		public global::Com.Tencent.Upload.Const.FileType FileType {
			get {
				if (fileType_jfieldId == IntPtr.Zero)
					fileType_jfieldId = JNIEnv.GetFieldID (class_ref, "fileType", "Lcom/tencent/upload/Const$FileType;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, fileType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileType_jfieldId == IntPtr.Zero)
					fileType_jfieldId = JNIEnv.GetFieldID (class_ref, "fileType", "Lcom/tencent/upload/Const$FileType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, fileType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/data/FileInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileInfo); }
		}

		protected FileInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='FileInfo']/constructor[@name='FileInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileInfo)) {
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

	}
}
