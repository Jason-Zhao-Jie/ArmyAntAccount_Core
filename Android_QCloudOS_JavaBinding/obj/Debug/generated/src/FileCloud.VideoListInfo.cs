using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']"
	[global::Android.Runtime.Register ("FileCloud/VideoListInfo", DoNotGenerateAcw=true)]
	public sealed partial class VideoListInfo : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr play_url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/field[@name='play_url']"
		[Register ("play_url")]
		public global::System.Collections.IDictionary PlayUrl {
			get {
				if (play_url_jfieldId == IntPtr.Zero)
					play_url_jfieldId = JNIEnv.GetFieldID (class_ref, "play_url", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, play_url_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (play_url_jfieldId == IntPtr.Zero)
					play_url_jfieldId = JNIEnv.GetFieldID (class_ref, "play_url", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, play_url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr time_len_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/field[@name='time_len']"
		[Register ("time_len")]
		public long TimeLen {
			get {
				if (time_len_jfieldId == IntPtr.Zero)
					time_len_jfieldId = JNIEnv.GetFieldID (class_ref, "time_len", "J");
				return JNIEnv.GetLongField (Handle, time_len_jfieldId);
			}
			set {
				if (time_len_jfieldId == IntPtr.Zero)
					time_len_jfieldId = JNIEnv.GetFieldID (class_ref, "time_len", "J");
				try {
					JNIEnv.SetField (Handle, time_len_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr trans_status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/field[@name='trans_status']"
		[Register ("trans_status")]
		public global::System.Collections.IDictionary TransStatus {
			get {
				if (trans_status_jfieldId == IntPtr.Zero)
					trans_status_jfieldId = JNIEnv.GetFieldID (class_ref, "trans_status", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, trans_status_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (trans_status_jfieldId == IntPtr.Zero)
					trans_status_jfieldId = JNIEnv.GetFieldID (class_ref, "trans_status", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, trans_status_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr video_file_info_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/field[@name='video_file_info']"
		[Register ("video_file_info")]
		public global::FileCloud.VideoFileInfo VideoFileInfo {
			get {
				if (video_file_info_jfieldId == IntPtr.Zero)
					video_file_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_file_info", "LFileCloud/VideoFileInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, video_file_info_jfieldId);
				return global::Java.Lang.Object.GetObject<global::FileCloud.VideoFileInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (video_file_info_jfieldId == IntPtr.Zero)
					video_file_info_jfieldId = JNIEnv.GetFieldID (class_ref, "video_file_info", "LFileCloud/VideoFileInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, video_file_info_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr video_status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/field[@name='video_status']"
		[Register ("video_status")]
		public int VideoStatus {
			get {
				if (video_status_jfieldId == IntPtr.Zero)
					video_status_jfieldId = JNIEnv.GetFieldID (class_ref, "video_status", "I");
				return JNIEnv.GetIntField (Handle, video_status_jfieldId);
			}
			set {
				if (video_status_jfieldId == IntPtr.Zero)
					video_status_jfieldId = JNIEnv.GetFieldID (class_ref, "video_status", "I");
				try {
					JNIEnv.SetField (Handle, video_status_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/VideoListInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoListInfo); }
		}

		internal VideoListInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/constructor[@name='VideoListInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoListInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoListInfo)) {
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

		static IntPtr id_ctor_Ljava_util_Map_IJLjava_util_Map_LFileCloud_VideoFileInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/constructor[@name='VideoListInfo' and count(parameter)=5 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.lang.Integer&gt;'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.Map&lt;java.lang.Integer, java.lang.String&gt;'] and parameter[5][@type='FileCloud.VideoFileInfo']]"
		[Register (".ctor", "(Ljava/util/Map;IJLjava/util/Map;LFileCloud/VideoFileInfo;)V", "")]
		public unsafe VideoListInfo (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Lang.Integer> p0, int p1, long p2, global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, string> p3, global::FileCloud.VideoFileInfo p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (VideoListInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;IJLjava/util/Map;LFileCloud/VideoFileInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;IJLjava/util/Map;LFileCloud/VideoFileInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_IJLjava_util_Map_LFileCloud_VideoFileInfo_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_IJLjava_util_Map_LFileCloud_VideoFileInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;IJLjava/util/Map;LFileCloud/VideoFileInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_IJLjava_util_Map_LFileCloud_VideoFileInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_IJLjava_util_Map_LFileCloud_VideoFileInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='VideoListInfo']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
