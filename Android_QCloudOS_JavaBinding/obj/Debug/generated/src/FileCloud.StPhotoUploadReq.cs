using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']"
	[global::Android.Runtime.Register ("FileCloud/stPhotoUploadReq", DoNotGenerateAcw=true)]
	public sealed partial class StPhotoUploadReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr analyze_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='analyze_mode']"
		[Register ("analyze_mode")]
		public int AnalyzeMode {
			get {
				if (analyze_mode_jfieldId == IntPtr.Zero)
					analyze_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "analyze_mode", "I");
				return JNIEnv.GetIntField (Handle, analyze_mode_jfieldId);
			}
			set {
				if (analyze_mode_jfieldId == IntPtr.Zero)
					analyze_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "analyze_mode", "I");
				try {
					JNIEnv.SetField (Handle, analyze_mode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bind_info_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='bind_info']"
		[Register ("bind_info")]
		public string BindInfo {
			get {
				if (bind_info_jfieldId == IntPtr.Zero)
					bind_info_jfieldId = JNIEnv.GetFieldID (class_ref, "bind_info", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bind_info_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bind_info_jfieldId == IntPtr.Zero)
					bind_info_jfieldId = JNIEnv.GetFieldID (class_ref, "bind_info", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, bind_info_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bucket_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='bucket']"
		[Register ("bucket")]
		public string Bucket {
			get {
				if (bucket_jfieldId == IntPtr.Zero)
					bucket_jfieldId = JNIEnv.GetFieldID (class_ref, "bucket", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bucket_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bucket_jfieldId == IntPtr.Zero)
					bucket_jfieldId = JNIEnv.GetFieldID (class_ref, "bucket", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, bucket_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr directory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='directory']"
		[Register ("directory")]
		public string Directory {
			get {
				if (directory_jfieldId == IntPtr.Zero)
					directory_jfieldId = JNIEnv.GetFieldID (class_ref, "directory", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, directory_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (directory_jfieldId == IntPtr.Zero)
					directory_jfieldId = JNIEnv.GetFieldID (class_ref, "directory", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, directory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr expired_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='expired']"
		[Register ("expired")]
		public long Expired {
			get {
				if (expired_jfieldId == IntPtr.Zero)
					expired_jfieldId = JNIEnv.GetFieldID (class_ref, "expired", "J");
				return JNIEnv.GetLongField (Handle, expired_jfieldId);
			}
			set {
				if (expired_jfieldId == IntPtr.Zero)
					expired_jfieldId = JNIEnv.GetFieldID (class_ref, "expired", "J");
				try {
					JNIEnv.SetField (Handle, expired_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/field[@name='fileid']"
		[Register ("fileid")]
		public string Fileid {
			get {
				if (fileid_jfieldId == IntPtr.Zero)
					fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "fileid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, fileid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileid_jfieldId == IntPtr.Zero)
					fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "fileid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, fileid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stPhotoUploadReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StPhotoUploadReq); }
		}

		internal StPhotoUploadReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/constructor[@name='stPhotoUploadReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StPhotoUploadReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StPhotoUploadReq)) {
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

		static IntPtr id_ctor_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/constructor[@name='stPhotoUploadReq' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe StPhotoUploadReq (string p0, long p1, string p2, string p3, string p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (StPhotoUploadReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
