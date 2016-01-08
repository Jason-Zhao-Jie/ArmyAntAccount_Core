using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']"
	[global::Android.Runtime.Register ("FileCloud/stVideoUploadRsp", DoNotGenerateAcw=true)]
	public sealed partial class StVideoUploadRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr cover_fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/field[@name='cover_fileid']"
		[Register ("cover_fileid")]
		public string CoverFileid {
			get {
				if (cover_fileid_jfieldId == IntPtr.Zero)
					cover_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "cover_fileid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cover_fileid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cover_fileid_jfieldId == IntPtr.Zero)
					cover_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "cover_fileid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, cover_fileid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cover_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/field[@name='cover_url']"
		[Register ("cover_url")]
		public string CoverUrl {
			get {
				if (cover_url_jfieldId == IntPtr.Zero)
					cover_url_jfieldId = JNIEnv.GetFieldID (class_ref, "cover_url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cover_url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cover_url_jfieldId == IntPtr.Zero)
					cover_url_jfieldId = JNIEnv.GetFieldID (class_ref, "cover_url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, cover_url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/field[@name='fileid']"
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

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/field[@name='url']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stVideoUploadRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StVideoUploadRsp); }
		}

		internal StVideoUploadRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/constructor[@name='stVideoUploadRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StVideoUploadRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StVideoUploadRsp)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/constructor[@name='stVideoUploadRsp' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe StVideoUploadRsp (string p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (StVideoUploadRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stVideoUploadRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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