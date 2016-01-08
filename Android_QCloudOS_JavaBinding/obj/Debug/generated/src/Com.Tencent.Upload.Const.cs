using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const']"
	[global::Android.Runtime.Register ("com/tencent/upload/Const", DoNotGenerateAcw=true)]
	public partial class Const : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']"
		[global::Android.Runtime.Register ("com/tencent/upload/Const$FileType", DoNotGenerateAcw=true)]
		public sealed partial class FileType : global::Java.Lang.Enum {


			static IntPtr Audio_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/field[@name='Audio']"
			[Register ("Audio")]
			public static global::Com.Tencent.Upload.Const.FileType Audio {
				get {
					if (Audio_jfieldId == IntPtr.Zero)
						Audio_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Audio", "Lcom/tencent/upload/Const$FileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Audio_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr File_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/field[@name='File']"
			[Register ("File")]
			public static global::Com.Tencent.Upload.Const.FileType File {
				get {
					if (File_jfieldId == IntPtr.Zero)
						File_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "File", "Lcom/tencent/upload/Const$FileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, File_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Other_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/field[@name='Other']"
			[Register ("Other")]
			public static global::Com.Tencent.Upload.Const.FileType Other {
				get {
					if (Other_jfieldId == IntPtr.Zero)
						Other_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Other", "Lcom/tencent/upload/Const$FileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Other_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Photo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/field[@name='Photo']"
			[Register ("Photo")]
			public static global::Com.Tencent.Upload.Const.FileType Photo {
				get {
					if (Photo_jfieldId == IntPtr.Zero)
						Photo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Photo", "Lcom/tencent/upload/Const$FileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Photo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Video_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/field[@name='Video']"
			[Register ("Video")]
			public static global::Com.Tencent.Upload.Const.FileType Video {
				get {
					if (Video_jfieldId == IntPtr.Zero)
						Video_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Video", "Lcom/tencent/upload/Const$FileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Video_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/Const$FileType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileType); }
			}

			internal FileType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$FileType;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.FileType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$FileType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Upload.Const.FileType __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.FileType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/upload/Const$FileType;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.FileType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/upload/Const$FileType;");
				try {
					return (global::Com.Tencent.Upload.Const.FileType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Upload.Const.FileType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']"
		[global::Android.Runtime.Register ("com/tencent/upload/Const$RetCode", DoNotGenerateAcw=true)]
		public sealed partial class RetCode : global::Java.Lang.Enum {


			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Tencent.Upload.Const.RetCode Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAST_SUCCEED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='FAST_SUCCEED']"
			[Register ("FAST_SUCCEED")]
			public static global::Com.Tencent.Upload.Const.RetCode FastSucceed {
				get {
					if (FAST_SUCCEED_jfieldId == IntPtr.Zero)
						FAST_SUCCEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAST_SUCCEED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAST_SUCCEED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FILE_LENGTH_INVAID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='FILE_LENGTH_INVAID']"
			[Register ("FILE_LENGTH_INVAID")]
			public static global::Com.Tencent.Upload.Const.RetCode FileLengthInvaid {
				get {
					if (FILE_LENGTH_INVAID_jfieldId == IntPtr.Zero)
						FILE_LENGTH_INVAID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_LENGTH_INVAID", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_LENGTH_INVAID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FILE_NOT_EXIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='FILE_NOT_EXIST']"
			[Register ("FILE_NOT_EXIST")]
			public static global::Com.Tencent.Upload.Const.RetCode FileNotExist {
				get {
					if (FILE_NOT_EXIST_jfieldId == IntPtr.Zero)
						FILE_NOT_EXIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_NOT_EXIST", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_NOT_EXIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HANDSHAKE_FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='HANDSHAKE_FAILED']"
			[Register ("HANDSHAKE_FAILED")]
			public static global::Com.Tencent.Upload.Const.RetCode HandshakeFailed {
				get {
					if (HANDSHAKE_FAILED_jfieldId == IntPtr.Zero)
						HANDSHAKE_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANDSHAKE_FAILED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANDSHAKE_FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HANDSHAKE_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='HANDSHAKE_TIMEOUT']"
			[Register ("HANDSHAKE_TIMEOUT")]
			public static global::Com.Tencent.Upload.Const.RetCode HandshakeTimeout {
				get {
					if (HANDSHAKE_TIMEOUT_jfieldId == IntPtr.Zero)
						HANDSHAKE_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANDSHAKE_TIMEOUT", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANDSHAKE_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IO_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='IO_EXCEPTION']"
			[Register ("IO_EXCEPTION")]
			public static global::Com.Tencent.Upload.Const.RetCode IoException {
				get {
					if (IO_EXCEPTION_jfieldId == IntPtr.Zero)
						IO_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_EXCEPTION", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NDK_NETWORK_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='NDK_NETWORK_ERROR']"
			[Register ("NDK_NETWORK_ERROR")]
			public static global::Com.Tencent.Upload.Const.RetCode NdkNetworkError {
				get {
					if (NDK_NETWORK_ERROR_jfieldId == IntPtr.Zero)
						NDK_NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NDK_NETWORK_ERROR", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NDK_NETWORK_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_NOT_AVAILABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='NETWORK_NOT_AVAILABLE']"
			[Register ("NETWORK_NOT_AVAILABLE")]
			public static global::Com.Tencent.Upload.Const.RetCode NetworkNotAvailable {
				get {
					if (NETWORK_NOT_AVAILABLE_jfieldId == IntPtr.Zero)
						NETWORK_NOT_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_NOT_AVAILABLE", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_NOT_AVAILABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_ROUTE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='NO_ROUTE']"
			[Register ("NO_ROUTE")]
			public static global::Com.Tencent.Upload.Const.RetCode NoRoute {
				get {
					if (NO_ROUTE_jfieldId == IntPtr.Zero)
						NO_ROUTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ROUTE", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ROUTE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_SESSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='NO_SESSION']"
			[Register ("NO_SESSION")]
			public static global::Com.Tencent.Upload.Const.RetCode NoSession {
				get {
					if (NO_SESSION_jfieldId == IntPtr.Zero)
						NO_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_SESSION", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_SESSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='OOM']"
			[Register ("OOM")]
			public static global::Com.Tencent.Upload.Const.RetCode Oom {
				get {
					if (OOM_jfieldId == IntPtr.Zero)
						OOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OOM", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Tencent.Upload.Const.RetCode Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Tencent.Upload.Const.RetCode Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='REQUEST_TIMEOUT']"
			[Register ("REQUEST_TIMEOUT")]
			public static global::Com.Tencent.Upload.Const.RetCode RequestTimeout {
				get {
					if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
						REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESPONSE_IS_NULL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='RESPONSE_IS_NULL']"
			[Register ("RESPONSE_IS_NULL")]
			public static global::Com.Tencent.Upload.Const.RetCode ResponseIsNull {
				get {
					if (RESPONSE_IS_NULL_jfieldId == IntPtr.Zero)
						RESPONSE_IS_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESPONSE_IS_NULL", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESPONSE_IS_NULL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_ALL_ROUTE_FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_ALL_ROUTE_FAILED']"
			[Register ("SESSION_ALL_ROUTE_FAILED")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionAllRouteFailed {
				get {
					if (SESSION_ALL_ROUTE_FAILED_jfieldId == IntPtr.Zero)
						SESSION_ALL_ROUTE_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_ALL_ROUTE_FAILED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_ALL_ROUTE_FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_CONN_SEND_FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_CONN_SEND_FAILED']"
			[Register ("SESSION_CONN_SEND_FAILED")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionConnSendFailed {
				get {
					if (SESSION_CONN_SEND_FAILED_jfieldId == IntPtr.Zero)
						SESSION_CONN_SEND_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_CONN_SEND_FAILED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_CONN_SEND_FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_DETECT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_DETECT_ERROR']"
			[Register ("SESSION_DETECT_ERROR")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionDetectError {
				get {
					if (SESSION_DETECT_ERROR_jfieldId == IntPtr.Zero)
						SESSION_DETECT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_DETECT_ERROR", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_DETECT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_DISCONNECT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_DISCONNECT']"
			[Register ("SESSION_DISCONNECT")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionDisconnect {
				get {
					if (SESSION_DISCONNECT_jfieldId == IntPtr.Zero)
						SESSION_DISCONNECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_DISCONNECT", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_DISCONNECT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_DIVIDE_PACKET_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_DIVIDE_PACKET_ERROR']"
			[Register ("SESSION_DIVIDE_PACKET_ERROR")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionDividePacketError {
				get {
					if (SESSION_DIVIDE_PACKET_ERROR_jfieldId == IntPtr.Zero)
						SESSION_DIVIDE_PACKET_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_DIVIDE_PACKET_ERROR", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_DIVIDE_PACKET_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_REQUEST_ENCODE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_REQUEST_ENCODE_ERROR']"
			[Register ("SESSION_REQUEST_ENCODE_ERROR")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionRequestEncodeError {
				get {
					if (SESSION_REQUEST_ENCODE_ERROR_jfieldId == IntPtr.Zero)
						SESSION_REQUEST_ENCODE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_REQUEST_ENCODE_ERROR", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_REQUEST_ENCODE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_STATE_INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_STATE_INVALID']"
			[Register ("SESSION_STATE_INVALID")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionStateInvalid {
				get {
					if (SESSION_STATE_INVALID_jfieldId == IntPtr.Zero)
						SESSION_STATE_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_STATE_INVALID", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_STATE_INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SESSION_WITHOUT_CONN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SESSION_WITHOUT_CONN']"
			[Register ("SESSION_WITHOUT_CONN")]
			public static global::Com.Tencent.Upload.Const.RetCode SessionWithoutConn {
				get {
					if (SESSION_WITHOUT_CONN_jfieldId == IntPtr.Zero)
						SESSION_WITHOUT_CONN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_WITHOUT_CONN", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_WITHOUT_CONN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCEED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/field[@name='SUCCEED']"
			[Register ("SUCCEED")]
			public static global::Com.Tencent.Upload.Const.RetCode Succeed {
				get {
					if (SUCCEED_jfieldId == IntPtr.Zero)
						SUCCEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCEED", "Lcom/tencent/upload/Const$RetCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCEED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/Const$RetCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RetCode); }
			}

			internal RetCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCode;
			public unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getCode);
					} finally {
					}
				}
			}

			static IntPtr id_getDesc;
			public unsafe string Desc {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/method[@name='getDesc' and count(parameter)=0]"
				[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
				get {
					if (id_getDesc == IntPtr.Zero)
						id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$RetCode;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.RetCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$RetCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Upload.Const.RetCode __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.RetCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.RetCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/upload/Const$RetCode;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.RetCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/upload/Const$RetCode;");
				try {
					return (global::Com.Tencent.Upload.Const.RetCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Upload.Const.RetCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']"
		[global::Android.Runtime.Register ("com/tencent/upload/Const$ServerEnv", DoNotGenerateAcw=true)]
		public sealed partial class ServerEnv : global::Java.Lang.Enum {


			static IntPtr DEV_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/field[@name='DEV']"
			[Register ("DEV")]
			public static global::Com.Tencent.Upload.Const.ServerEnv Dev {
				get {
					if (DEV_jfieldId == IntPtr.Zero)
						DEV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEV", "Lcom/tencent/upload/Const$ServerEnv;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEV_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.ServerEnv> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Tencent.Upload.Const.ServerEnv Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/tencent/upload/Const$ServerEnv;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.ServerEnv> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/Const$ServerEnv", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ServerEnv); }
			}

			internal ServerEnv (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCode;
			public unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getCode);
					} finally {
					}
				}
			}

			static IntPtr id_getDesc;
			public unsafe string Desc {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/method[@name='getDesc' and count(parameter)=0]"
				[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
				get {
					if (id_getDesc == IntPtr.Zero)
						id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$ServerEnv;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.ServerEnv ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/upload/Const$ServerEnv;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Upload.Const.ServerEnv __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.ServerEnv> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const.ServerEnv']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/upload/Const$ServerEnv;", "")]
			public static unsafe global::Com.Tencent.Upload.Const.ServerEnv[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/upload/Const$ServerEnv;");
				try {
					return (global::Com.Tencent.Upload.Const.ServerEnv[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Upload.Const.ServerEnv));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/Const", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Const); }
		}

		protected Const (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload']/class[@name='Const']/constructor[@name='Const' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Const ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Const)) {
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

	}
}
