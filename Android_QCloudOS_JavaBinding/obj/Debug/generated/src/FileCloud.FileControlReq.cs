using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']"
	[global::Android.Runtime.Register ("FileCloud/FileControlReq", DoNotGenerateAcw=true)]
	public sealed partial class FileControlReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr auth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='auth']"
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

		static IntPtr biz_req_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='biz_req']"
		[Register ("biz_req")]
		public IList<byte> BizReq {
			get {
				if (biz_req_jfieldId == IntPtr.Zero)
					biz_req_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_req", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, biz_req_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (biz_req_jfieldId == IntPtr.Zero)
					biz_req_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_req", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, biz_req_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr check_sum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='check_sum']"
		[Register ("check_sum")]
		public string CheckSum {
			get {
				if (check_sum_jfieldId == IntPtr.Zero)
					check_sum_jfieldId = JNIEnv.GetFieldID (class_ref, "check_sum", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, check_sum_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (check_sum_jfieldId == IntPtr.Zero)
					check_sum_jfieldId = JNIEnv.GetFieldID (class_ref, "check_sum", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, check_sum_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr check_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='check_type']"
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

		static IntPtr compress_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='compress']"
		[Register ("compress")]
		public int Compress {
			get {
				if (compress_jfieldId == IntPtr.Zero)
					compress_jfieldId = JNIEnv.GetFieldID (class_ref, "compress", "I");
				return JNIEnv.GetIntField (Handle, compress_jfieldId);
			}
			set {
				if (compress_jfieldId == IntPtr.Zero)
					compress_jfieldId = JNIEnv.GetFieldID (class_ref, "compress", "I");
				try {
					JNIEnv.SetField (Handle, compress_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr env_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='env']"
		[Register ("env")]
		public global::FileCloud.StEnvironment Env {
			get {
				if (env_jfieldId == IntPtr.Zero)
					env_jfieldId = JNIEnv.GetFieldID (class_ref, "env", "LFileCloud/stEnvironment;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, env_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.StEnvironment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (env_jfieldId == IntPtr.Zero)
					env_jfieldId = JNIEnv.GetFieldID (class_ref, "env", "LFileCloud/stEnvironment;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, env_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr file_len_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='file_len']"
		[Register ("file_len")]
		public long FileLen {
			get {
				if (file_len_jfieldId == IntPtr.Zero)
					file_len_jfieldId = JNIEnv.GetFieldID (class_ref, "file_len", "J");
				return JNIEnv.GetLongField (Handle, file_len_jfieldId);
			}
			set {
				if (file_len_jfieldId == IntPtr.Zero)
					file_len_jfieldId = JNIEnv.GetFieldID (class_ref, "file_len", "J");
				try {
					JNIEnv.SetField (Handle, file_len_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr file_name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='file_name']"
		[Register ("file_name")]
		public string FileName {
			get {
				if (file_name_jfieldId == IntPtr.Zero)
					file_name_jfieldId = JNIEnv.GetFieldID (class_ref, "file_name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, file_name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (file_name_jfieldId == IntPtr.Zero)
					file_name_jfieldId = JNIEnv.GetFieldID (class_ref, "file_name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, file_name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr file_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='file_type']"
		[Register ("file_type")]
		public int FileType {
			get {
				if (file_type_jfieldId == IntPtr.Zero)
					file_type_jfieldId = JNIEnv.GetFieldID (class_ref, "file_type", "I");
				return JNIEnv.GetIntField (Handle, file_type_jfieldId);
			}
			set {
				if (file_type_jfieldId == IntPtr.Zero)
					file_type_jfieldId = JNIEnv.GetFieldID (class_ref, "file_type", "I");
				try {
					JNIEnv.SetField (Handle, file_type_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr magic_context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='magic_context']"
		[Register ("magic_context")]
		public string MagicContext {
			get {
				if (magic_context_jfieldId == IntPtr.Zero)
					magic_context_jfieldId = JNIEnv.GetFieldID (class_ref, "magic_context", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, magic_context_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (magic_context_jfieldId == IntPtr.Zero)
					magic_context_jfieldId = JNIEnv.GetFieldID (class_ref, "magic_context", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, magic_context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr preupload_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='preupload']"
		[Register ("preupload")]
		public int Preupload {
			get {
				if (preupload_jfieldId == IntPtr.Zero)
					preupload_jfieldId = JNIEnv.GetFieldID (class_ref, "preupload", "I");
				return JNIEnv.GetIntField (Handle, preupload_jfieldId);
			}
			set {
				if (preupload_jfieldId == IntPtr.Zero)
					preupload_jfieldId = JNIEnv.GetFieldID (class_ref, "preupload", "I");
				try {
					JNIEnv.SetField (Handle, preupload_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr session_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='session']"
		[Register ("session")]
		public string Session {
			get {
				if (session_jfieldId == IntPtr.Zero)
					session_jfieldId = JNIEnv.GetFieldID (class_ref, "session", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, session_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (session_jfieldId == IntPtr.Zero)
					session_jfieldId = JNIEnv.GetFieldID (class_ref, "session", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, session_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr slice_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/field[@name='slice_size']"
		[Register ("slice_size")]
		public long SliceSize {
			get {
				if (slice_size_jfieldId == IntPtr.Zero)
					slice_size_jfieldId = JNIEnv.GetFieldID (class_ref, "slice_size", "J");
				return JNIEnv.GetLongField (Handle, slice_size_jfieldId);
			}
			set {
				if (slice_size_jfieldId == IntPtr.Zero)
					slice_size_jfieldId = JNIEnv.GetFieldID (class_ref, "slice_size", "J");
				try {
					JNIEnv.SetField (Handle, slice_size_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/FileControlReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileControlReq); }
		}

		internal FileControlReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/constructor[@name='FileControlReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileControlReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileControlReq)) {
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

		static IntPtr id_ctor_LFileCloud_stAuth_Ljava_lang_String_LFileCloud_stEnvironment_IILjava_lang_String_IJJILjava_lang_String_Ljava_lang_String_arrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/constructor[@name='FileControlReq' and count(parameter)=14 and parameter[1][@type='FileCloud.stAuth'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='FileCloud.stEnvironment'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='long'] and parameter[9][@type='long'] and parameter[10][@type='int'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String'] and parameter[13][@type='byte[]'] and parameter[14][@type='byte[]']]"
		[Register (".ctor", "(LFileCloud/stAuth;Ljava/lang/String;LFileCloud/stEnvironment;IILjava/lang/String;IJJILjava/lang/String;Ljava/lang/String;[B[B)V", "")]
		public unsafe FileControlReq (global::FileCloud.StAuth p0, string p1, global::FileCloud.StEnvironment p2, int p3, int p4, string p5, int p6, long p7, long p8, int p9, string p10, string p11, byte[] p12, byte[] p13)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			IntPtr native_p11 = JNIEnv.NewString (p11);
			IntPtr native_p12 = JNIEnv.NewArray (p12);
			IntPtr native_p13 = JNIEnv.NewArray (p13);
			try {
				JValue* __args = stackalloc JValue [14];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (native_p10);
				__args [11] = new JValue (native_p11);
				__args [12] = new JValue (native_p12);
				__args [13] = new JValue (native_p13);
				if (GetType () != typeof (FileControlReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stAuth;Ljava/lang/String;LFileCloud/stEnvironment;IILjava/lang/String;IJJILjava/lang/String;Ljava/lang/String;[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stAuth;Ljava/lang/String;LFileCloud/stEnvironment;IILjava/lang/String;IJJILjava/lang/String;Ljava/lang/String;[B[B)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stAuth_Ljava_lang_String_LFileCloud_stEnvironment_IILjava_lang_String_IJJILjava_lang_String_Ljava_lang_String_arrayBarrayB == IntPtr.Zero)
					id_ctor_LFileCloud_stAuth_Ljava_lang_String_LFileCloud_stEnvironment_IILjava_lang_String_IJJILjava_lang_String_Ljava_lang_String_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stAuth;Ljava/lang/String;LFileCloud/stEnvironment;IILjava/lang/String;IJJILjava/lang/String;Ljava/lang/String;[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_LFileCloud_stEnvironment_IILjava_lang_String_IJJILjava_lang_String_Ljava_lang_String_arrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_LFileCloud_stEnvironment_IILjava_lang_String_IJJILjava_lang_String_Ljava_lang_String_arrayBarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p10);
				JNIEnv.DeleteLocalRef (native_p11);
				if (p12 != null) {
					JNIEnv.CopyArray (native_p12, p12);
					JNIEnv.DeleteLocalRef (native_p12);
				}
				if (p13 != null) {
					JNIEnv.CopyArray (native_p13, p13);
					JNIEnv.DeleteLocalRef (native_p13);
				}
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileControlReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
