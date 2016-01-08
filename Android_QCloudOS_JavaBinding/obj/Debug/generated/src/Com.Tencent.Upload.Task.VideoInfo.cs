using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/VideoInfo", DoNotGenerateAcw=true)]
	public partial class VideoInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='CHECKFAIL']"
		[Register ("CHECKFAIL")]
		public const int Checkfail = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='CHECKNOTPASS']"
		[Register ("CHECKNOTPASS")]
		public const int Checknotpass = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='CHECKPASS']"
		[Register ("CHECKPASS")]
		public const int Checkpass = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public const int Default = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='F0']"
		[Register ("F0")]
		public const int F0 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='F10']"
		[Register ("F10")]
		public const int F10 = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='F20']"
		[Register ("F20")]
		public const int F20 = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='F30']"
		[Register ("F30")]
		public const int F30 = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='INVALID']"
		[Register ("INVALID")]
		public const int Invalid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='MaskAll']"
		[Register ("MaskAll")]
		public const int MaskAll = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='MaskBizAttr']"
		[Register ("MaskBizAttr")]
		public const int MaskBizAttr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='MaskDesc']"
		[Register ("MaskDesc")]
		public const int MaskDesc = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='MaskTitle']"
		[Register ("MaskTitle")]
		public const int MaskTitle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='MaskVideoCover']"
		[Register ("MaskVideoCover")]
		public const int MaskVideoCover = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='TRANSCODEDONE']"
		[Register ("TRANSCODEDONE")]
		public const int Transcodedone = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='TRANSCODEFAIL']"
		[Register ("TRANSCODEFAIL")]
		public const int Transcodefail = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='TRANSCODING']"
		[Register ("TRANSCODING")]
		public const int Transcoding = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='UPLOADING']"
		[Register ("UPLOADING")]
		public const int Uploading = (int) 1;

		static IntPtr playUrlList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='playUrlList']"
		[Register ("playUrlList")]
		public global::System.Collections.IDictionary PlayUrlList {
			get {
				if (playUrlList_jfieldId == IntPtr.Zero)
					playUrlList_jfieldId = JNIEnv.GetFieldID (class_ref, "playUrlList", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, playUrlList_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (playUrlList_jfieldId == IntPtr.Zero)
					playUrlList_jfieldId = JNIEnv.GetFieldID (class_ref, "playUrlList", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, playUrlList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr transStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='transStatus']"
		[Register ("transStatus")]
		public global::System.Collections.IDictionary TransStatus {
			get {
				if (transStatus_jfieldId == IntPtr.Zero)
					transStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "transStatus", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, transStatus_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (transStatus_jfieldId == IntPtr.Zero)
					transStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "transStatus", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, transStatus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr videoAttr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='videoAttr']"
		[Register ("videoAttr")]
		public global::Com.Tencent.Upload.Task.VideoAttr VideoAttr {
			get {
				if (videoAttr_jfieldId == IntPtr.Zero)
					videoAttr_jfieldId = JNIEnv.GetFieldID (class_ref, "videoAttr", "Lcom/tencent/upload/task/VideoAttr;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, videoAttr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.VideoAttr> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (videoAttr_jfieldId == IntPtr.Zero)
					videoAttr_jfieldId = JNIEnv.GetFieldID (class_ref, "videoAttr", "Lcom/tencent/upload/task/VideoAttr;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, videoAttr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr videoStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/field[@name='videoStatus']"
		[Register ("videoStatus")]
		public int VideoStatus {
			get {
				if (videoStatus_jfieldId == IntPtr.Zero)
					videoStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "videoStatus", "I");
				return JNIEnv.GetIntField (Handle, videoStatus_jfieldId);
			}
			set {
				if (videoStatus_jfieldId == IntPtr.Zero)
					videoStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "videoStatus", "I");
				try {
					JNIEnv.SetField (Handle, videoStatus_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/VideoInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoInfo); }
		}

		protected VideoInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task']/class[@name='VideoInfo']/constructor[@name='VideoInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoInfo)) {
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
