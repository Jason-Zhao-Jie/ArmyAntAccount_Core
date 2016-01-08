using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']"
	[global::Android.Runtime.Register ("FileCloud/FileUploadRsp", DoNotGenerateAcw=true)]
	public sealed partial class FileUploadRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr biz_rsp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='biz_rsp']"
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

		static IntPtr finish_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='finish']"
		[Register ("finish")]
		public int Finish {
			get {
				if (finish_jfieldId == IntPtr.Zero)
					finish_jfieldId = JNIEnv.GetFieldID (class_ref, "finish", "I");
				return JNIEnv.GetIntField (Handle, finish_jfieldId);
			}
			set {
				if (finish_jfieldId == IntPtr.Zero)
					finish_jfieldId = JNIEnv.GetFieldID (class_ref, "finish", "I");
				try {
					JNIEnv.SetField (Handle, finish_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='offset']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='result']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='session']"
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

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/field[@name='size']"
		[Register ("size")]
		public long Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "J");
				return JNIEnv.GetLongField (Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "J");
				try {
					JNIEnv.SetField (Handle, size_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/FileUploadRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUploadRsp); }
		}

		internal FileUploadRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/constructor[@name='FileUploadRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUploadRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileUploadRsp)) {
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

		static IntPtr id_ctor_LFileCloud_stResult_Ljava_lang_String_JJIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/constructor[@name='FileUploadRsp' and count(parameter)=6 and parameter[1][@type='FileCloud.stResult'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
		[Register (".ctor", "(LFileCloud/stResult;Ljava/lang/String;JJI[B)V", "")]
		public unsafe FileUploadRsp (global::FileCloud.StResult p0, string p1, long p2, long p3, int p4, byte[] p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (FileUploadRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stResult;Ljava/lang/String;JJI[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stResult;Ljava/lang/String;JJI[B)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stResult_Ljava_lang_String_JJIarrayB == IntPtr.Zero)
					id_ctor_LFileCloud_stResult_Ljava_lang_String_JJIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stResult;Ljava/lang/String;JJI[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_JJIarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_JJIarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileUploadRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
