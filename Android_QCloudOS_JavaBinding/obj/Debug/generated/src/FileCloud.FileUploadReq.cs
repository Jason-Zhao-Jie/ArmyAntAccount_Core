using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']"
	[global::Android.Runtime.Register ("FileCloud/FileUploadReq", DoNotGenerateAcw=true)]
	public sealed partial class FileUploadReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr check_sum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/field[@name='check_sum']"
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

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/field[@name='data']"
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

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/field[@name='offset']"
		[Register ("offset")]
		public long Offset {
			get {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				return JNIEnv.GetLongField (Handle, offset_jfieldId);
			}
			set {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				try {
					JNIEnv.SetField (Handle, offset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr session_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/field[@name='session']"
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

		static IntPtr trailing_data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/field[@name='trailing_data']"
		[Register ("trailing_data")]
		public long TrailingData {
			get {
				if (trailing_data_jfieldId == IntPtr.Zero)
					trailing_data_jfieldId = JNIEnv.GetFieldID (class_ref, "trailing_data", "J");
				return JNIEnv.GetLongField (Handle, trailing_data_jfieldId);
			}
			set {
				if (trailing_data_jfieldId == IntPtr.Zero)
					trailing_data_jfieldId = JNIEnv.GetFieldID (class_ref, "trailing_data", "J");
				try {
					JNIEnv.SetField (Handle, trailing_data_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/FileUploadReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUploadReq); }
		}

		internal FileUploadReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/constructor[@name='FileUploadReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUploadReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileUploadReq)) {
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

		static IntPtr id_ctor_Ljava_lang_String_JarrayBLjava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/constructor[@name='FileUploadReq' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;J[BLjava/lang/String;J)V", "")]
		public unsafe FileUploadReq (string p0, long p1, byte[] p2, string p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (FileUploadReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;J[BLjava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;J[BLjava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JarrayBLjava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JarrayBLjava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;J[BLjava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JarrayBLjava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JarrayBLjava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
