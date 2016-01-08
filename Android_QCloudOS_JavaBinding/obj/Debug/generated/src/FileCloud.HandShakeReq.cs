using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']"
	[global::Android.Runtime.Register ("FileCloud/HandShakeReq", DoNotGenerateAcw=true)]
	public sealed partial class HandShakeReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr auth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='auth']"
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

		static IntPtr clientip_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='clientip']"
		[Register ("clientip")]
		public string Clientip {
			get {
				if (clientip_jfieldId == IntPtr.Zero)
					clientip_jfieldId = JNIEnv.GetFieldID (class_ref, "clientip", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, clientip_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (clientip_jfieldId == IntPtr.Zero)
					clientip_jfieldId = JNIEnv.GetFieldID (class_ref, "clientip", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, clientip_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr download_domain_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='download_domain']"
		[Register ("download_domain")]
		public string DownloadDomain {
			get {
				if (download_domain_jfieldId == IntPtr.Zero)
					download_domain_jfieldId = JNIEnv.GetFieldID (class_ref, "download_domain", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, download_domain_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (download_domain_jfieldId == IntPtr.Zero)
					download_domain_jfieldId = JNIEnv.GetFieldID (class_ref, "download_domain", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, download_domain_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr download_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='download_url']"
		[Register ("download_url")]
		public string DownloadUrl {
			get {
				if (download_url_jfieldId == IntPtr.Zero)
					download_url_jfieldId = JNIEnv.GetFieldID (class_ref, "download_url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, download_url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (download_url_jfieldId == IntPtr.Zero)
					download_url_jfieldId = JNIEnv.GetFieldID (class_ref, "download_url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, download_url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr env_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='env']"
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

		static IntPtr flag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='flag']"
		[Register ("flag")]
		public int Flag {
			get {
				if (flag_jfieldId == IntPtr.Zero)
					flag_jfieldId = JNIEnv.GetFieldID (class_ref, "flag", "I");
				return JNIEnv.GetIntField (Handle, flag_jfieldId);
			}
			set {
				if (flag_jfieldId == IntPtr.Zero)
					flag_jfieldId = JNIEnv.GetFieldID (class_ref, "flag", "I");
				try {
					JNIEnv.SetField (Handle, flag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr last_update_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='last_update']"
		[Register ("last_update")]
		public string LastUpdate {
			get {
				if (last_update_jfieldId == IntPtr.Zero)
					last_update_jfieldId = JNIEnv.GetFieldID (class_ref, "last_update", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, last_update_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (last_update_jfieldId == IntPtr.Zero)
					last_update_jfieldId = JNIEnv.GetFieldID (class_ref, "last_update", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, last_update_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/field[@name='type']"
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
				return JNIEnv.FindClass ("FileCloud/HandShakeReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandShakeReq); }
		}

		internal HandShakeReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/constructor[@name='HandShakeReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandShakeReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HandShakeReq)) {
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

		static IntPtr id_ctor_LFileCloud_stAuth_LFileCloud_stEnvironment_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/constructor[@name='HandShakeReq' and count(parameter)=8 and parameter[1][@type='FileCloud.stAuth'] and parameter[2][@type='FileCloud.stEnvironment'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(LFileCloud/stAuth;LFileCloud/stEnvironment;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe HandShakeReq (global::FileCloud.StAuth p0, global::FileCloud.StEnvironment p1, int p2, string p3, string p4, string p5, int p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				if (GetType () != typeof (HandShakeReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stAuth;LFileCloud/stEnvironment;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stAuth;LFileCloud/stEnvironment;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stAuth_LFileCloud_stEnvironment_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_LFileCloud_stAuth_LFileCloud_stEnvironment_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stAuth;LFileCloud/stEnvironment;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stAuth_LFileCloud_stEnvironment_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stAuth_LFileCloud_stEnvironment_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
