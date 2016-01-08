using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stSession']"
	[global::Android.Runtime.Register ("FileCloud/stSession", DoNotGenerateAcw=true)]
	public sealed partial class StSession : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr process_ip_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/field[@name='process_ip']"
		[Register ("process_ip")]
		public long ProcessIp {
			get {
				if (process_ip_jfieldId == IntPtr.Zero)
					process_ip_jfieldId = JNIEnv.GetFieldID (class_ref, "process_ip", "J");
				return JNIEnv.GetLongField (Handle, process_ip_jfieldId);
			}
			set {
				if (process_ip_jfieldId == IntPtr.Zero)
					process_ip_jfieldId = JNIEnv.GetFieldID (class_ref, "process_ip", "J");
				try {
					JNIEnv.SetField (Handle, process_ip_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr process_port_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/field[@name='process_port']"
		[Register ("process_port")]
		public short ProcessPort {
			get {
				if (process_port_jfieldId == IntPtr.Zero)
					process_port_jfieldId = JNIEnv.GetFieldID (class_ref, "process_port", "S");
				return JNIEnv.GetShortField (Handle, process_port_jfieldId);
			}
			set {
				if (process_port_jfieldId == IntPtr.Zero)
					process_port_jfieldId = JNIEnv.GetFieldID (class_ref, "process_port", "S");
				try {
					JNIEnv.SetField (Handle, process_port_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/field[@name='sid']"
		[Register ("sid")]
		public string Sid {
			get {
				if (sid_jfieldId == IntPtr.Zero)
					sid_jfieldId = JNIEnv.GetFieldID (class_ref, "sid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sid_jfieldId == IntPtr.Zero)
					sid_jfieldId = JNIEnv.GetFieldID (class_ref, "sid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StSession); }
		}

		internal StSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/constructor[@name='stSession' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StSession ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StSession)) {
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

		static IntPtr id_ctor_Ljava_lang_String_JS;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/constructor[@name='stSession' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='short']]"
		[Register (".ctor", "(Ljava/lang/String;JS)V", "")]
		public unsafe StSession (string p0, long p1, short p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (StSession)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JS)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JS)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JS == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JS = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JS)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JS, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JS, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stSession']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
