using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']"
	[global::Android.Runtime.Register ("FileCloud/FileMoveReq", DoNotGenerateAcw=true)]
	public sealed partial class FileMoveReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr auth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='auth']"
		[Register ("auth")]
		public global::FileCloud.StAuth Auth {
			get {
				if (auth_jfieldId == IntPtr.Zero)
					auth_jfieldId = JNIEnv.GetFieldID (class_ref, "auth", "LFileCloud/stAuth;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, auth_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.StAuth> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (auth_jfieldId == IntPtr.Zero)
					auth_jfieldId = JNIEnv.GetFieldID (class_ref, "auth", "LFileCloud/stAuth;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, auth_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bucket_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='bucket']"
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

		static IntPtr delete_src_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='delete_src']"
		[Register ("delete_src")]
		public int DeleteSrc {
			get {
				if (delete_src_jfieldId == IntPtr.Zero)
					delete_src_jfieldId = JNIEnv.GetFieldID (class_ref, "delete_src", "I");
				return JNIEnv.GetIntField (Handle, delete_src_jfieldId);
			}
			set {
				if (delete_src_jfieldId == IntPtr.Zero)
					delete_src_jfieldId = JNIEnv.GetFieldID (class_ref, "delete_src", "I");
				try {
					JNIEnv.SetField (Handle, delete_src_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dst_directory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='dst_directory']"
		[Register ("dst_directory")]
		public string DstDirectory {
			get {
				if (dst_directory_jfieldId == IntPtr.Zero)
					dst_directory_jfieldId = JNIEnv.GetFieldID (class_ref, "dst_directory", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, dst_directory_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dst_directory_jfieldId == IntPtr.Zero)
					dst_directory_jfieldId = JNIEnv.GetFieldID (class_ref, "dst_directory", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, dst_directory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr dst_fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='dst_fileid']"
		[Register ("dst_fileid")]
		public string DstFileid {
			get {
				if (dst_fileid_jfieldId == IntPtr.Zero)
					dst_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "dst_fileid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, dst_fileid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dst_fileid_jfieldId == IntPtr.Zero)
					dst_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "dst_fileid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, dst_fileid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr src_fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='src_fileid']"
		[Register ("src_fileid")]
		public string SrcFileid {
			get {
				if (src_fileid_jfieldId == IntPtr.Zero)
					src_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "src_fileid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, src_fileid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (src_fileid_jfieldId == IntPtr.Zero)
					src_fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "src_fileid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, src_fileid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr src_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='src_url']"
		[Register ("src_url")]
		public string SrcUrl {
			get {
				if (src_url_jfieldId == IntPtr.Zero)
					src_url_jfieldId = JNIEnv.GetFieldID (class_ref, "src_url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, src_url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (src_url_jfieldId == IntPtr.Zero)
					src_url_jfieldId = JNIEnv.GetFieldID (class_ref, "src_url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, src_url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/field[@name='type']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/FileMoveReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileMoveReq); }
		}

		internal FileMoveReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/constructor[@name='FileMoveReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileMoveReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileMoveReq)) {
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

		static IntPtr id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/constructor[@name='FileMoveReq' and count(parameter)=8 and parameter[1][@type='FileCloud.stAuth'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FileMoveReq (global::FileCloud.StAuth p0, string p1, string p2, int p3, int p4, string p5, string p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				if (GetType () != typeof (FileMoveReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileMoveReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
