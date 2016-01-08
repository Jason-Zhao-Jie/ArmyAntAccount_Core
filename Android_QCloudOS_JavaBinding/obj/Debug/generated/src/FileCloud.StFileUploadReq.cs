using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']"
	[global::Android.Runtime.Register ("FileCloud/stFileUploadReq", DoNotGenerateAcw=true)]
	public sealed partial class StFileUploadReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr biz_attr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/field[@name='biz_attr']"
		[Register ("biz_attr")]
		public string BizAttr {
			get {
				if (biz_attr_jfieldId == IntPtr.Zero)
					biz_attr_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_attr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, biz_attr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (biz_attr_jfieldId == IntPtr.Zero)
					biz_attr_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_attr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, biz_attr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr video_file_info_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/field[@name='video_file_info']"
		[Register ("video_file_info")]
		public global::FileCloud.VideoFileInfo VideoFileInfo {
			get {
				if (video_file_info_jfieldId == IntPtr.Zero)
					video_file_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_file_info", "LFileCloud/VideoFileInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, video_file_info_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.VideoFileInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (video_file_info_jfieldId == IntPtr.Zero)
					video_file_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_file_info", "LFileCloud/VideoFileInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, video_file_info_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stFileUploadReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StFileUploadReq); }
		}

		internal StFileUploadReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/constructor[@name='stFileUploadReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StFileUploadReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StFileUploadReq)) {
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

		static IntPtr id_ctor_Ljava_lang_String_LFileCloud_VideoFileInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/constructor[@name='stFileUploadReq' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='FileCloud.VideoFileInfo']]"
		[Register (".ctor", "(Ljava/lang/String;LFileCloud/VideoFileInfo;)V", "")]
		public unsafe StFileUploadReq (string p0, global::FileCloud.VideoFileInfo p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (StFileUploadReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;LFileCloud/VideoFileInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;LFileCloud/VideoFileInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_LFileCloud_VideoFileInfo_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_LFileCloud_VideoFileInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;LFileCloud/VideoFileInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_LFileCloud_VideoFileInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_LFileCloud_VideoFileInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
		[Register ("readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V", "")]
		public override sealed unsafe void ReadFrom (global::Com.QQ.Taf.Jce.JceInputStream p0)
		{
			if (id_readFrom_Lcom_qq_taf_jce_JceInputStream_ == IntPtr.Zero)
				id_readFrom_Lcom_qq_taf_jce_JceInputStream_ = JNIEnv.GetMethodID (class_ref, "readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_readFrom_Lcom_qq_taf_jce_JceInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_writeTo_Lcom_qq_taf_jce_JceOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stFileUploadReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
		[Register ("writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V", "")]
		public override sealed unsafe void WriteTo (global::Com.QQ.Taf.Jce.JceOutputStream p0)
		{
			if (id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_qq_taf_jce_JceOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_qq_taf_jce_JceOutputStream_, __args);
			} finally {
			}
		}

	}
}
