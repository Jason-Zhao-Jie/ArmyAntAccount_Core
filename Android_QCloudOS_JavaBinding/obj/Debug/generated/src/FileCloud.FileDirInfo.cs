using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']"
	[global::Android.Runtime.Register ("FileCloud/FileDirInfo", DoNotGenerateAcw=true)]
	public sealed partial class FileDirInfo : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr access_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='access_url']"
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

		static IntPtr biz_attr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='biz_attr']"
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

		static IntPtr ctime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='ctime']"
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

		static IntPtr file_length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='file_length']"
		[Register ("file_length")]
		public long FileLength {
			get {
				if (file_length_jfieldId == IntPtr.Zero)
					file_length_jfieldId = JNIEnv.GetFieldID (class_ref, "file_length", "J");
				return JNIEnv.GetLongField (Handle, file_length_jfieldId);
			}
			set {
				if (file_length_jfieldId == IntPtr.Zero)
					file_length_jfieldId = JNIEnv.GetFieldID (class_ref, "file_length", "J");
				try {
					JNIEnv.SetField (Handle, file_length_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr file_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='file_size']"
		[Register ("file_size")]
		public long FileSize {
			get {
				if (file_size_jfieldId == IntPtr.Zero)
					file_size_jfieldId = JNIEnv.GetFieldID (class_ref, "file_size", "J");
				return JNIEnv.GetLongField (Handle, file_size_jfieldId);
			}
			set {
				if (file_size_jfieldId == IntPtr.Zero)
					file_size_jfieldId = JNIEnv.GetFieldID (class_ref, "file_size", "J");
				try {
					JNIEnv.SetField (Handle, file_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mtime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='mtime']"
		[Register ("mtime")]
		public long Mtime {
			get {
				if (mtime_jfieldId == IntPtr.Zero)
					mtime_jfieldId = JNIEnv.GetFieldID (class_ref, "mtime", "J");
				return JNIEnv.GetLongField (Handle, mtime_jfieldId);
			}
			set {
				if (mtime_jfieldId == IntPtr.Zero)
					mtime_jfieldId = JNIEnv.GetFieldID (class_ref, "mtime", "J");
				try {
					JNIEnv.SetField (Handle, mtime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='path']"
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

		static IntPtr sha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='sha']"
		[Register ("sha")]
		public string Sha {
			get {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sha_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sha_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='type']"
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

		static IntPtr video_list_info_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/field[@name='video_list_info']"
		[Register ("video_list_info")]
		public global::FileCloud.VideoListInfo VideoListInfo {
			get {
				if (video_list_info_jfieldId == IntPtr.Zero)
					video_list_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_list_info", "LFileCloud/VideoListInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, video_list_info_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.VideoListInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (video_list_info_jfieldId == IntPtr.Zero)
					video_list_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_list_info", "LFileCloud/VideoListInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, video_list_info_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/FileDirInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileDirInfo); }
		}

		internal FileDirInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/constructor[@name='FileDirInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileDirInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileDirInfo)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_JJLjava_lang_String_ILjava_lang_String_LFileCloud_VideoListInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/constructor[@name='FileDirInfo' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='int'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='FileCloud.VideoListInfo']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;JJLjava/lang/String;ILjava/lang/String;LFileCloud/VideoListInfo;)V", "")]
		public unsafe FileDirInfo (string p0, string p1, long p2, long p3, string p4, long p5, long p6, string p7, int p8, string p9, global::FileCloud.VideoListInfo p10)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (native_p9);
				__args [10] = new JValue (p10);
				if (GetType () != typeof (FileDirInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;JJLjava/lang/String;ILjava/lang/String;LFileCloud/VideoListInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;JJLjava/lang/String;ILjava/lang/String;LFileCloud/VideoListInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_JJLjava_lang_String_ILjava_lang_String_LFileCloud_VideoListInfo_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_JJLjava_lang_String_ILjava_lang_String_LFileCloud_VideoListInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;JJLjava/lang/String;ILjava/lang/String;LFileCloud/VideoListInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_JJLjava_lang_String_ILjava_lang_String_LFileCloud_VideoListInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_JJLjava_lang_String_ILjava_lang_String_LFileCloud_VideoListInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='FileDirInfo']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
