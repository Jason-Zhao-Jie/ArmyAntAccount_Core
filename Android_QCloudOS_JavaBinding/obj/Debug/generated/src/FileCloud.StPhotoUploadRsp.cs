using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']"
	[global::Android.Runtime.Register ("FileCloud/stPhotoUploadRsp", DoNotGenerateAcw=true)]
	public sealed partial class StPhotoUploadRsp : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr analyze_flag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/field[@name='analyze_flag']"
		[Register ("analyze_flag")]
		public int AnalyzeFlag {
			get {
				if (analyze_flag_jfieldId == IntPtr.Zero)
					analyze_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "analyze_flag", "I");
				return JNIEnv.GetIntField (Handle, analyze_flag_jfieldId);
			}
			set {
				if (analyze_flag_jfieldId == IntPtr.Zero)
					analyze_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "analyze_flag", "I");
				try {
					JNIEnv.SetField (Handle, analyze_flag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fileid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/field[@name='fileid']"
		[Register ("fileid")]
		public string Fileid {
			get {
				if (fileid_jfieldId == IntPtr.Zero)
					fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "fileid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, fileid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileid_jfieldId == IntPtr.Zero)
					fileid_jfieldId = JNIEnv.GetFieldID (class_ref, "fileid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, fileid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pic_info_list_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/field[@name='pic_info_list']"
		[Register ("pic_info_list")]
		public global::System.Collections.IList PicInfoList {
			get {
				if (pic_info_list_jfieldId == IntPtr.Zero)
					pic_info_list_jfieldId = JNIEnv.GetFieldID (class_ref, "pic_info_list", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pic_info_list_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pic_info_list_jfieldId == IntPtr.Zero)
					pic_info_list_jfieldId = JNIEnv.GetFieldID (class_ref, "pic_info_list", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, pic_info_list_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr stats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/field[@name='stats']"
		[Register ("stats")]
		public global::System.Collections.IDictionary Stats {
			get {
				if (stats_jfieldId == IntPtr.Zero)
					stats_jfieldId = JNIEnv.GetFieldID (class_ref, "stats", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, stats_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (stats_jfieldId == IntPtr.Zero)
					stats_jfieldId = JNIEnv.GetFieldID (class_ref, "stats", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, stats_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stPhotoUploadRsp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StPhotoUploadRsp); }
		}

		internal StPhotoUploadRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_ILjava_util_ArrayList_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/constructor[@name='stPhotoUploadRsp' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.ArrayList&lt;FileCloud.stPicInfo&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/ArrayList;Ljava/util/Map;)V", "")]
		public unsafe StPhotoUploadRsp (string p0, string p1, int p2, global::System.Collections.Generic.IList<global::FileCloud.StPicInfo> p3, global::System.Collections.Generic.IDictionary<string, string> p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::FileCloud.StPicInfo>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (StPhotoUploadRsp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;ILjava/util/ArrayList;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;ILjava/util/ArrayList;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ILjava_util_ArrayList_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ILjava_util_ArrayList_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/ArrayList;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ILjava_util_ArrayList_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ILjava_util_ArrayList_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/constructor[@name='stPhotoUploadRsp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StPhotoUploadRsp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StPhotoUploadRsp)) {
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

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPhotoUploadRsp']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
