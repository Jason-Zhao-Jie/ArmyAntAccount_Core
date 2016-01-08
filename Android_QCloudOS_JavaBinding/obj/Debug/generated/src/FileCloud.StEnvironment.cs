using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']"
	[global::Android.Runtime.Register ("FileCloud/stEnvironment", DoNotGenerateAcw=true)]
	public sealed partial class StEnvironment : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr device_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='device']"
		[Register ("device")]
		public string Device {
			get {
				if (device_jfieldId == IntPtr.Zero)
					device_jfieldId = JNIEnv.GetFieldID (class_ref, "device", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, device_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (device_jfieldId == IntPtr.Zero)
					device_jfieldId = JNIEnv.GetFieldID (class_ref, "device", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, device_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr net_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='net']"
		[Register ("net")]
		public int Net {
			get {
				if (net_jfieldId == IntPtr.Zero)
					net_jfieldId = JNIEnv.GetFieldID (class_ref, "net", "I");
				return JNIEnv.GetIntField (Handle, net_jfieldId);
			}
			set {
				if (net_jfieldId == IntPtr.Zero)
					net_jfieldId = JNIEnv.GetFieldID (class_ref, "net", "I");
				try {
					JNIEnv.SetField (Handle, net_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr operators_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='operators']"
		[Register ("operators")]
		public string Operators {
			get {
				if (operators_jfieldId == IntPtr.Zero)
					operators_jfieldId = JNIEnv.GetFieldID (class_ref, "operators", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, operators_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (operators_jfieldId == IntPtr.Zero)
					operators_jfieldId = JNIEnv.GetFieldID (class_ref, "operators", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, operators_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr os_version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='os_version']"
		[Register ("os_version")]
		public string OsVersion {
			get {
				if (os_version_jfieldId == IntPtr.Zero)
					os_version_jfieldId = JNIEnv.GetFieldID (class_ref, "os_version", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, os_version_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (os_version_jfieldId == IntPtr.Zero)
					os_version_jfieldId = JNIEnv.GetFieldID (class_ref, "os_version", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, os_version_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr qua_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='qua']"
		[Register ("qua")]
		public string Qua {
			get {
				if (qua_jfieldId == IntPtr.Zero)
					qua_jfieldId = JNIEnv.GetFieldID (class_ref, "qua", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, qua_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (qua_jfieldId == IntPtr.Zero)
					qua_jfieldId = JNIEnv.GetFieldID (class_ref, "qua", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, qua_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr refer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='refer']"
		[Register ("refer")]
		public string Refer {
			get {
				if (refer_jfieldId == IntPtr.Zero)
					refer_jfieldId = JNIEnv.GetFieldID (class_ref, "refer", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, refer_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (refer_jfieldId == IntPtr.Zero)
					refer_jfieldId = JNIEnv.GetFieldID (class_ref, "refer", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, refer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sdk_version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='sdk_version']"
		[Register ("sdk_version")]
		public string SdkVersion {
			get {
				if (sdk_version_jfieldId == IntPtr.Zero)
					sdk_version_jfieldId = JNIEnv.GetFieldID (class_ref, "sdk_version", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sdk_version_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sdk_version_jfieldId == IntPtr.Zero)
					sdk_version_jfieldId = JNIEnv.GetFieldID (class_ref, "sdk_version", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sdk_version_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr source_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/field[@name='source']"
		[Register ("source")]
		public int Source {
			get {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "I");
				return JNIEnv.GetIntField (Handle, source_jfieldId);
			}
			set {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "I");
				try {
					JNIEnv.SetField (Handle, source_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stEnvironment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StEnvironment); }
		}

		internal StEnvironment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/constructor[@name='stEnvironment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StEnvironment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StEnvironment)) {
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

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/constructor[@name='stEnvironment' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe StEnvironment (int p0, string p1, string p2, string p3, int p4, string p5, string p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				if (GetType () != typeof (StEnvironment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stEnvironment']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
