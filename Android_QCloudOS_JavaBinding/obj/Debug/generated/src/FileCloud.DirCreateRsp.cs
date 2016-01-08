using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']"
	[global::Android.Runtime.Register ("FileCloud/DirCreateRsp", DoNotGenerateAcw=true)]
	public sealed partial class DirCreateRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr access_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/field[@name='access_url']"
		[Register ("access_url")]
		public string AccessUrl {
			get {
				if (access_url_jfieldId == IntPtr.Zero)
					access_url_jfieldId = JNIEnv.GetFieldID (class_ref, "access_url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, access_url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (access_url_jfieldId == IntPtr.Zero)
					access_url_jfieldId = JNIEnv.GetFieldID (class_ref, "access_url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, access_url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ctime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/field[@name='ctime']"
		[Register ("ctime")]
		public long Ctime {
			get {
				if (ctime_jfieldId == IntPtr.Zero)
					ctime_jfieldId = JNIEnv.GetFieldID (class_ref, "ctime", "J");
				return JNIEnv.GetLongField (Handle, ctime_jfieldId);
			}
			set {
				if (ctime_jfieldId == IntPtr.Zero)
					ctime_jfieldId = JNIEnv.GetFieldID (class_ref, "ctime", "J");
				try {
					JNIEnv.SetField (Handle, ctime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr is_over_write_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/field[@name='is_over_write']"
		[Register ("is_over_write")]
		public bool IsOverWrite {
			get {
				if (is_over_write_jfieldId == IntPtr.Zero)
					is_over_write_jfieldId = JNIEnv.GetFieldID (class_ref, "is_over_write", "Z");
				return JNIEnv.GetBooleanField (Handle, is_over_write_jfieldId);
			}
			set {
				if (is_over_write_jfieldId == IntPtr.Zero)
					is_over_write_jfieldId = JNIEnv.GetFieldID (class_ref, "is_over_write", "Z");
				try {
					JNIEnv.SetField (Handle, is_over_write_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/field[@name='path']"
		[Register ("path")]
		public string Path {
			get {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, path_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, path_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/field[@name='result']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/DirCreateRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirCreateRsp); }
		}

		internal DirCreateRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/constructor[@name='DirCreateRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirCreateRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DirCreateRsp)) {
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

		static IntPtr id_ctor_LFileCloud_stResult_ZJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/constructor[@name='DirCreateRsp' and count(parameter)=5 and parameter[1][@type='FileCloud.stResult'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(LFileCloud/stResult;ZJLjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DirCreateRsp (global::FileCloud.StResult p0, bool p1, long p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (DirCreateRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stResult;ZJLjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stResult;ZJLjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stResult_ZJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_LFileCloud_stResult_ZJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stResult;ZJLjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stResult_ZJLjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stResult_ZJLjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
