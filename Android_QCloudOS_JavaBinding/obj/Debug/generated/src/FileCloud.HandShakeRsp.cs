using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']"
	[global::Android.Runtime.Register ("FileCloud/HandShakeRsp", DoNotGenerateAcw=true)]
	public sealed partial class HandShakeRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr clientip_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='clientip']"
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

		static IntPtr config_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='config']"
		[Register ("config")]
		public global::System.Collections.IDictionary Config {
			get {
				if (config_jfieldId == IntPtr.Zero)
					config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, config_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (config_jfieldId == IntPtr.Zero)
					config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, config_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr download_svr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='download_svr']"
		[Register ("download_svr")]
		public global::System.Collections.IList DownloadSvr {
			get {
				if (download_svr_jfieldId == IntPtr.Zero)
					download_svr_jfieldId = JNIEnv.GetFieldID (class_ref, "download_svr", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, download_svr_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (download_svr_jfieldId == IntPtr.Zero)
					download_svr_jfieldId = JNIEnv.GetFieldID (class_ref, "download_svr", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, download_svr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr last_update_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='last_update']"
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

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='result']"
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

		static IntPtr upload_svr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/field[@name='upload_svr']"
		[Register ("upload_svr")]
		public global::System.Collections.IList UploadSvr {
			get {
				if (upload_svr_jfieldId == IntPtr.Zero)
					upload_svr_jfieldId = JNIEnv.GetFieldID (class_ref, "upload_svr", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, upload_svr_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (upload_svr_jfieldId == IntPtr.Zero)
					upload_svr_jfieldId = JNIEnv.GetFieldID (class_ref, "upload_svr", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, upload_svr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/HandShakeRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandShakeRsp); }
		}

		internal HandShakeRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/constructor[@name='HandShakeRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandShakeRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HandShakeRsp)) {
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

		static IntPtr id_ctor_LFileCloud_stResult_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/constructor[@name='HandShakeRsp' and count(parameter)=6 and parameter[1][@type='FileCloud.stResult'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(LFileCloud/stResult;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/Map;Ljava/lang/String;)V", "")]
		public unsafe HandShakeRsp (global::FileCloud.StResult p0, string p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IList<string> p3, global::System.Collections.Generic.IDictionary<string, string> p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (HandShakeRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stResult;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/Map;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stResult;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/Map;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stResult_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_LFileCloud_stResult_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stResult;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/Map;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_Map_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stResult_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_Map_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='HandShakeRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
