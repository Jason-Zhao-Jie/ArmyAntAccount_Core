using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']"
	[global::Android.Runtime.Register ("FileCloud/DirListRsp", DoNotGenerateAcw=true)]
	public sealed partial class DirListRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr content_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='content']"
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

		static IntPtr dir_count_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='dir_count']"
		[Register ("dir_count")]
		public long DirCount {
			get {
				if (dir_count_jfieldId == IntPtr.Zero)
					dir_count_jfieldId = JNIEnv.GetFieldID (class_ref, "dir_count", "J");
				return JNIEnv.GetLongField (Handle, dir_count_jfieldId);
			}
			set {
				if (dir_count_jfieldId == IntPtr.Zero)
					dir_count_jfieldId = JNIEnv.GetFieldID (class_ref, "dir_count", "J");
				try {
					JNIEnv.SetField (Handle, dir_count_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr file_count_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='file_count']"
		[Register ("file_count")]
		public long FileCount {
			get {
				if (file_count_jfieldId == IntPtr.Zero)
					file_count_jfieldId = JNIEnv.GetFieldID (class_ref, "file_count", "J");
				return JNIEnv.GetLongField (Handle, file_count_jfieldId);
			}
			set {
				if (file_count_jfieldId == IntPtr.Zero)
					file_count_jfieldId = JNIEnv.GetFieldID (class_ref, "file_count", "J");
				try {
					JNIEnv.SetField (Handle, file_count_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hasmore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='hasmore']"
		[Register ("hasmore")]
		public bool Hasmore {
			get {
				if (hasmore_jfieldId == IntPtr.Zero)
					hasmore_jfieldId = JNIEnv.GetFieldID (class_ref, "hasmore", "Z");
				return JNIEnv.GetBooleanField (Handle, hasmore_jfieldId);
			}
			set {
				if (hasmore_jfieldId == IntPtr.Zero)
					hasmore_jfieldId = JNIEnv.GetFieldID (class_ref, "hasmore", "Z");
				try {
					JNIEnv.SetField (Handle, hasmore_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr infos_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='infos']"
		[Register ("infos")]
		public global::System.Collections.IList Infos {
			get {
				if (infos_jfieldId == IntPtr.Zero)
					infos_jfieldId = JNIEnv.GetFieldID (class_ref, "infos", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, infos_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (infos_jfieldId == IntPtr.Zero)
					infos_jfieldId = JNIEnv.GetFieldID (class_ref, "infos", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, infos_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/field[@name='result']"
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
				return JNIEnv.FindClass ("FileCloud/DirListRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirListRsp); }
		}

		internal DirListRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/constructor[@name='DirListRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirListRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DirListRsp)) {
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

		static IntPtr id_ctor_LFileCloud_stResult_JJLjava_util_ArrayList_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/constructor[@name='DirListRsp' and count(parameter)=6 and parameter[1][@type='FileCloud.stResult'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.ArrayList&lt;FileCloud.FileDirInfo&gt;'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(LFileCloud/stResult;JJLjava/util/ArrayList;Ljava/lang/String;Z)V", "")]
		public unsafe DirListRsp (global::FileCloud.StResult p0, long p1, long p2, global::System.Collections.Generic.IList<global::FileCloud.FileDirInfo> p3, string p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaList<global::FileCloud.FileDirInfo>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (DirListRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/stResult;JJLjava/util/ArrayList;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/stResult;JJLjava/util/ArrayList;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_LFileCloud_stResult_JJLjava_util_ArrayList_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_LFileCloud_stResult_JJLjava_util_ArrayList_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/stResult;JJLjava/util/ArrayList;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_stResult_JJLjava_util_ArrayList_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_stResult_JJLjava_util_ArrayList_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='DirListRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
