using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']"
	[global::Android.Runtime.Register ("FileCloud/DirListReq", DoNotGenerateAcw=true)]
	public sealed partial class DirListReq : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr auth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='auth']"
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

		static IntPtr content_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='content']"
		[Register ("content")]
		public string Content {
			get {
				if (content_jfieldId == IntPtr.Zero)
					content_jfieldId = JNIEnv.GetFieldID (class_ref, "content", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, content_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (content_jfieldId == IntPtr.Zero)
					content_jfieldId = JNIEnv.GetFieldID (class_ref, "content", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, content_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr num_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='num']"
		[Register ("num")]
		public long Num {
			get {
				if (num_jfieldId == IntPtr.Zero)
					num_jfieldId = JNIEnv.GetFieldID (class_ref, "num", "J");
				return JNIEnv.GetLongField (Handle, num_jfieldId);
			}
			set {
				if (num_jfieldId == IntPtr.Zero)
					num_jfieldId = JNIEnv.GetFieldID (class_ref, "num", "J");
				try {
					JNIEnv.SetField (Handle, num_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr order_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='order']"
		[Register ("order")]
		public bool Order {
			get {
				if (order_jfieldId == IntPtr.Zero)
					order_jfieldId = JNIEnv.GetFieldID (class_ref, "order", "Z");
				return JNIEnv.GetBooleanField (Handle, order_jfieldId);
			}
			set {
				if (order_jfieldId == IntPtr.Zero)
					order_jfieldId = JNIEnv.GetFieldID (class_ref, "order", "Z");
				try {
					JNIEnv.SetField (Handle, order_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pattern_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='pattern']"
		[Register ("pattern")]
		public int Pattern {
			get {
				if (pattern_jfieldId == IntPtr.Zero)
					pattern_jfieldId = JNIEnv.GetFieldID (class_ref, "pattern", "I");
				return JNIEnv.GetIntField (Handle, pattern_jfieldId);
			}
			set {
				if (pattern_jfieldId == IntPtr.Zero)
					pattern_jfieldId = JNIEnv.GetFieldID (class_ref, "pattern", "I");
				try {
					JNIEnv.SetField (Handle, pattern_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr startpath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/field[@name='startpath']"
		[Register ("startpath")]
		public string Startpath {
			get {
				if (startpath_jfieldId == IntPtr.Zero)
					startpath_jfieldId = JNIEnv.GetFieldID (class_ref, "startpath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, startpath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (startpath_jfieldId == IntPtr.Zero)
					startpath_jfieldId = JNIEnv.GetFieldID (class_ref, "startpath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, startpath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/DirListReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirListReq); }
		}

		internal DirListReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/constructor[@name='DirListReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirListReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DirListReq)) {
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

		static IntPtr id_ctor_LFileCloud_stAuth_Ljava_lang_String_JIZLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/constructor[@name='DirListReq' and count(parameter)=6 and parameter[1][@type='FileCloud.stAuth'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(LFileCloud/stAuth;Ljava/lang/String;JIZLjava/lang/String;)V", "")]
		public unsafe DirListReq (global::FileCloud.StAuth p0, string p1, long p2, int p3, bool p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (DirListReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stAuth;Ljava/lang/String;JIZLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stAuth;Ljava/lang/String;JIZLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stAuth_Ljava_lang_String_JIZLjava_lang_String_ == IntPtr.Zero)
					id_ctor_LFileCloud_stAuth_Ljava_lang_String_JIZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stAuth;Ljava/lang/String;JIZLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_JIZLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stAuth_Ljava_lang_String_JIZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirListReq']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
