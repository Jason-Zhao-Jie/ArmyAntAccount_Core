using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']"
	[global::Android.Runtime.Register ("com/qq/taf/RequestPacket", DoNotGenerateAcw=true)]
	public sealed partial class RequestPacket : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr cPacketType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='cPacketType']"
		[Register ("cPacketType")]
		public sbyte CPacketType {
			get {
				if (cPacketType_jfieldId == IntPtr.Zero)
					cPacketType_jfieldId = JNIEnv.GetFieldID (class_ref, "cPacketType", "B");
				return JNIEnv.GetByteField (Handle, cPacketType_jfieldId);
			}
			set {
				if (cPacketType_jfieldId == IntPtr.Zero)
					cPacketType_jfieldId = JNIEnv.GetFieldID (class_ref, "cPacketType", "B");
				try {
					JNIEnv.SetField (Handle, cPacketType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='context']"
		[Register ("context")]
		public global::System.Collections.IDictionary Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, context_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr iMessageType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='iMessageType']"
		[Register ("iMessageType")]
		public int IMessageType {
			get {
				if (iMessageType_jfieldId == IntPtr.Zero)
					iMessageType_jfieldId = JNIEnv.GetFieldID (class_ref, "iMessageType", "I");
				return JNIEnv.GetIntField (Handle, iMessageType_jfieldId);
			}
			set {
				if (iMessageType_jfieldId == IntPtr.Zero)
					iMessageType_jfieldId = JNIEnv.GetFieldID (class_ref, "iMessageType", "I");
				try {
					JNIEnv.SetField (Handle, iMessageType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iRequestId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='iRequestId']"
		[Register ("iRequestId")]
		public int IRequestId {
			get {
				if (iRequestId_jfieldId == IntPtr.Zero)
					iRequestId_jfieldId = JNIEnv.GetFieldID (class_ref, "iRequestId", "I");
				return JNIEnv.GetIntField (Handle, iRequestId_jfieldId);
			}
			set {
				if (iRequestId_jfieldId == IntPtr.Zero)
					iRequestId_jfieldId = JNIEnv.GetFieldID (class_ref, "iRequestId", "I");
				try {
					JNIEnv.SetField (Handle, iRequestId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='iTimeout']"
		[Register ("iTimeout")]
		public int ITimeout {
			get {
				if (iTimeout_jfieldId == IntPtr.Zero)
					iTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "iTimeout", "I");
				return JNIEnv.GetIntField (Handle, iTimeout_jfieldId);
			}
			set {
				if (iTimeout_jfieldId == IntPtr.Zero)
					iTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "iTimeout", "I");
				try {
					JNIEnv.SetField (Handle, iTimeout_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='iVersion']"
		[Register ("iVersion")]
		public short IVersion {
			get {
				if (iVersion_jfieldId == IntPtr.Zero)
					iVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "iVersion", "S");
				return JNIEnv.GetShortField (Handle, iVersion_jfieldId);
			}
			set {
				if (iVersion_jfieldId == IntPtr.Zero)
					iVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "iVersion", "S");
				try {
					JNIEnv.SetField (Handle, iVersion_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='sBuffer']"
		[Register ("sBuffer")]
		public IList<byte> SBuffer {
			get {
				if (sBuffer_jfieldId == IntPtr.Zero)
					sBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "sBuffer", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, sBuffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sBuffer_jfieldId == IntPtr.Zero)
					sBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "sBuffer", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, sBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sFuncName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='sFuncName']"
		[Register ("sFuncName")]
		public string SFuncName {
			get {
				if (sFuncName_jfieldId == IntPtr.Zero)
					sFuncName_jfieldId = JNIEnv.GetFieldID (class_ref, "sFuncName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sFuncName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sFuncName_jfieldId == IntPtr.Zero)
					sFuncName_jfieldId = JNIEnv.GetFieldID (class_ref, "sFuncName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sFuncName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sServantName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='sServantName']"
		[Register ("sServantName")]
		public string SServantName {
			get {
				if (sServantName_jfieldId == IntPtr.Zero)
					sServantName_jfieldId = JNIEnv.GetFieldID (class_ref, "sServantName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sServantName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sServantName_jfieldId == IntPtr.Zero)
					sServantName_jfieldId = JNIEnv.GetFieldID (class_ref, "sServantName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sServantName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/field[@name='status']"
		[Register ("status")]
		public global::System.Collections.IDictionary Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, status_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, status_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/RequestPacket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestPacket); }
		}

		internal RequestPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/constructor[@name='RequestPacket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestPacket ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RequestPacket)) {
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

		static IntPtr id_ctor_SBIILjava_lang_String_Ljava_lang_String_arrayBILjava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/constructor[@name='RequestPacket' and count(parameter)=10 and parameter[1][@type='short'] and parameter[2][@type='byte'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='byte[]'] and parameter[8][@type='int'] and parameter[9][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[10][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(SBIILjava/lang/String;Ljava/lang/String;[BILjava/util/Map;Ljava/util/Map;)V", "")]
		public unsafe RequestPacket (short p0, sbyte p1, int p2, int p3, string p4, string p5, byte[] p6, int p7, global::System.Collections.Generic.IDictionary<string, string> p8, global::System.Collections.Generic.IDictionary<string, string> p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p8 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p8);
			IntPtr native_p9 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				if (GetType () != typeof (RequestPacket)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(SBIILjava/lang/String;Ljava/lang/String;[BILjava/util/Map;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(SBIILjava/lang/String;Ljava/lang/String;[BILjava/util/Map;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_SBIILjava_lang_String_Ljava_lang_String_arrayBILjava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_SBIILjava_lang_String_Ljava_lang_String_arrayBILjava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(SBIILjava/lang/String;Ljava/lang/String;[BILjava/util/Map;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_SBIILjava_lang_String_Ljava_lang_String_arrayBILjava_util_Map_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_SBIILjava_lang_String_Ljava_lang_String_arrayBILjava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
		[Register ("readFrom", "(Lcom/qq/taf/jce/JceInputStream;)V", "")]
		public override unsafe void ReadFrom (global::Com.QQ.Taf.Jce.JceInputStream p0)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf']/class[@name='RequestPacket']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
		[Register ("writeTo", "(Lcom/qq/taf/jce/JceOutputStream;)V", "")]
		public override unsafe void WriteTo (global::Com.QQ.Taf.Jce.JceOutputStream p0)
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
