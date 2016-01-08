using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']"
	[global::Android.Runtime.Register ("FileCloud/DirCreateReq", DoNotGenerateAcw=true)]
	public sealed partial class DirCreateReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr auth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/field[@name='auth']"
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

		static IntPtr biz_attr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/field[@name='biz_attr']"
		[Register ("biz_attr")]
		public string BizAttr {
			get {
				if (biz_attr_jfieldId == IntPtr.Zero)
					biz_attr_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_attr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, biz_attr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (biz_attr_jfieldId == IntPtr.Zero)
					biz_attr_jfieldId = JNIEnv.GetFieldID (class_ref, "biz_attr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, biz_attr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/field[@name='path']"
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

		static IntPtr to_over_write_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/field[@name='to_over_write']"
		[Register ("to_over_write")]
		public bool ToOverWrite {
			get {
				if (to_over_write_jfieldId == IntPtr.Zero)
					to_over_write_jfieldId = JNIEnv.GetFieldID (class_ref, "to_over_write", "Z");
				return JNIEnv.GetBooleanField (Handle, to_over_write_jfieldId);
			}
			set {
				if (to_over_write_jfieldId == IntPtr.Zero)
					to_over_write_jfieldId = JNIEnv.GetFieldID (class_ref, "to_over_write", "Z");
				try {
					JNIEnv.SetField (Handle, to_over_write_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/DirCreateReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirCreateReq); }
		}

		internal DirCreateReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/constructor[@name='DirCreateReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirCreateReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DirCreateReq)) {
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

		static IntPtr id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/constructor[@name='DirCreateReq' and count(parameter)=4 and parameter[1][@type='FileCloud.stAuth'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe DirCreateReq (global::FileCloud.StAuth p0, string p1, string p2, bool p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (DirCreateReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stAuth;Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirCreateReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
