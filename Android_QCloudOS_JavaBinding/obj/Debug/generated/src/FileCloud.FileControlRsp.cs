using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']"
	[global::Android.Runtime.Register ("FileCloud/FileControlRsp", DoNotGenerateAcw=true)]
	public sealed partial class FileControlRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr biz_rsp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/field[@name='biz_rsp']"
		[Register ("biz_rsp")]
		public IList<byte> BizRsp {
			get {
				if (biz_rsp_jfieldId == IntPtr.Zero)
					biz_rsp_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_rsp", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, biz_rsp_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (biz_rsp_jfieldId == IntPtr.Zero)
					biz_rsp_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_rsp", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, biz_rsp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/field[@name='offset']"
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

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/field[@name='result']"
		[Register ("result")]
		public global::FileCloud.StResult Result {
			get {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "LFileCloud/stResult;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, result_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.StResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "LFileCloud/stResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, result_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr session_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/field[@name='session']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/field[@name='slice_size']"
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
				return JNIEnv.FindClass ("FileCloud/FileControlRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileControlRsp); }
		}

		internal FileControlRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/constructor[@name='FileControlRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileControlRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileControlRsp)) {
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

		static IntPtr id_ctor_LFileCloud_stResult_Ljava_lang_String_JarrayBJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/constructor[@name='FileControlRsp' and count(parameter)=5 and parameter[1][@type='FileCloud.stResult'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='byte[]'] and parameter[5][@type='long']]"
		[Register (".ctor", "(LFileCloud/stResult;Ljava/lang/String;J[BJ)V", "")]
		public unsafe FileControlRsp (global::FileCloud.StResult p0, string p1, long p2, byte[] p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (FileControlRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stResult;Ljava/lang/String;J[BJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stResult;Ljava/lang/String;J[BJ)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stResult_Ljava_lang_String_JarrayBJ == IntPtr.Zero)
					id_ctor_LFileCloud_stResult_Ljava_lang_String_JarrayBJ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stResult;Ljava/lang/String;J[BJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_JarrayBJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_JarrayBJ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileControlRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
