using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/JceInputStream", DoNotGenerateAcw=true)]
	public sealed partial class JceInputStream : global::Java.Lang.Object {


		static IntPtr sServerEncoding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/field[@name='sServerEncoding']"
		[Register ("sServerEncoding")]
		protected string SServerEncoding {
			get {
				if (sServerEncoding_jfieldId == IntPtr.Zero)
					sServerEncoding_jfieldId = JNIEnv.GetFieldID (class_ref, "sServerEncoding", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sServerEncoding_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sServerEncoding_jfieldId == IntPtr.Zero)
					sServerEncoding_jfieldId = JNIEnv.GetFieldID (class_ref, "sServerEncoding", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sServerEncoding_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream.HeadData']"
		[global::Android.Runtime.Register ("com/qq/taf/jce/JceInputStream$HeadData", DoNotGenerateAcw=true)]
		public partial class HeadData : global::Java.Lang.Object {


			static IntPtr tag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream.HeadData']/field[@name='tag']"
			[Register ("tag")]
			public int Tag {
				get {
					if (tag_jfieldId == IntPtr.Zero)
						tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "I");
					return JNIEnv.GetIntField (Handle, tag_jfieldId);
				}
				set {
					if (tag_jfieldId == IntPtr.Zero)
						tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "I");
					try {
						JNIEnv.SetField (Handle, tag_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream.HeadData']/field[@name='type']"
			[Register ("type")]
			public sbyte Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "B");
					return JNIEnv.GetByteField (Handle, type_jfieldId);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "B");
					try {
						JNIEnv.SetField (Handle, type_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qq/taf/jce/JceInputStream$HeadData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeadData); }
			}

			protected HeadData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream.HeadData']/constructor[@name='JceInputStream.HeadData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HeadData ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (HeadData)) {
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

			static Delegate cb_clear;
#pragma warning disable 0169
			static Delegate GetClearHandler ()
			{
				if (cb_clear == null)
					cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
				return cb_clear;
			}

			static void n_Clear (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.QQ.Taf.Jce.JceInputStream.HeadData __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceInputStream.HeadData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream.HeadData']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual unsafe void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_clear);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/JceInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceInputStream); }
		}

		internal JceInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/constructor[@name='JceInputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JceInputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JceInputStream)) {
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

		static IntPtr id_ctor_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/constructor[@name='JceInputStream' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe JceInputStream (byte[] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JceInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BI)V", __args);
					return;
				}

				if (id_ctor_arrayBI == IntPtr.Zero)
					id_ctor_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "([BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/constructor[@name='JceInputStream' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe JceInputStream (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (JceInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/constructor[@name='JceInputStream' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JceInputStream (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JceInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getBs;
		public unsafe global::Java.Nio.ByteBuffer Bs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='getBs' and count(parameter)=0]"
			[Register ("getBs", "()Ljava/nio/ByteBuffer;", "GetGetBsHandler")]
			get {
				if (id_getBs == IntPtr.Zero)
					id_getBs = JNIEnv.GetMethodID (class_ref, "getBs", "()Ljava/nio/ByteBuffer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getBs), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_directRead_Lcom_qq_taf_jce_JceStruct_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='directRead' and count(parameter)=3 and parameter[1][@type='com.qq.taf.jce.JceStruct'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("directRead", "(Lcom/qq/taf/jce/JceStruct;IZ)Lcom/qq/taf/jce/JceStruct;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceStruct DirectRead (global::Com.QQ.Taf.Jce.JceStruct p0, int p1, bool p2)
		{
			if (id_directRead_Lcom_qq_taf_jce_JceStruct_IZ == IntPtr.Zero)
				id_directRead_Lcom_qq_taf_jce_JceStruct_IZ = JNIEnv.GetMethodID (class_ref, "directRead", "(Lcom/qq/taf/jce/JceStruct;IZ)Lcom/qq/taf/jce/JceStruct;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.QQ.Taf.Jce.JceStruct __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (JNIEnv.CallObjectMethod  (Handle, id_directRead_Lcom_qq_taf_jce_JceStruct_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_Ljava_lang_Object_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(Ljava/lang/Object;IZ)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Read (global::Java.Lang.Object p0, int p1, bool p2)
		{
			if (id_read_Ljava_lang_Object_IZ == IntPtr.Zero)
				id_read_Ljava_lang_Object_IZ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/Object;IZ)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_read_Ljava_lang_Object_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_read_ZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(ZIZ)Z", "")]
		public unsafe bool Read (bool p0, int p1, bool p2)
		{
			if (id_read_ZIZ == IntPtr.Zero)
				id_read_ZIZ = JNIEnv.GetMethodID (class_ref, "read", "(ZIZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallBooleanMethod  (Handle, id_read_ZIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([ZIZ)[Z", "")]
		public unsafe bool[] Read (bool[] p0, int p1, bool p2)
		{
			if (id_read_arrayZIZ == IntPtr.Zero)
				id_read_arrayZIZ = JNIEnv.GetMethodID (class_ref, "read", "([ZIZ)[Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayZIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_BIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(BIZ)B", "")]
		public unsafe sbyte Read (sbyte p0, int p1, bool p2)
		{
			if (id_read_BIZ == IntPtr.Zero)
				id_read_BIZ = JNIEnv.GetMethodID (class_ref, "read", "(BIZ)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallByteMethod  (Handle, id_read_BIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([BIZ)[B", "")]
		public unsafe byte[] Read (byte[] p0, int p1, bool p2)
		{
			if (id_read_arrayBIZ == IntPtr.Zero)
				id_read_arrayBIZ = JNIEnv.GetMethodID (class_ref, "read", "([BIZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_Lcom_qq_taf_jce_JceStruct_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='com.qq.taf.jce.JceStruct'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(Lcom/qq/taf/jce/JceStruct;IZ)Lcom/qq/taf/jce/JceStruct;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceStruct Read (global::Com.QQ.Taf.Jce.JceStruct p0, int p1, bool p2)
		{
			if (id_read_Lcom_qq_taf_jce_JceStruct_IZ == IntPtr.Zero)
				id_read_Lcom_qq_taf_jce_JceStruct_IZ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/qq/taf/jce/JceStruct;IZ)Lcom/qq/taf/jce/JceStruct;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.QQ.Taf.Jce.JceStruct __ret = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.JceStruct> (JNIEnv.CallObjectMethod  (Handle, id_read_Lcom_qq_taf_jce_JceStruct_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_arrayLcom_qq_taf_jce_JceStruct_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='com.qq.taf.jce.JceStruct[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([Lcom/qq/taf/jce/JceStruct;IZ)[Lcom/qq/taf/jce/JceStruct;", "")]
		public unsafe global::Com.QQ.Taf.Jce.JceStruct[] Read (global::Com.QQ.Taf.Jce.JceStruct[] p0, int p1, bool p2)
		{
			if (id_read_arrayLcom_qq_taf_jce_JceStruct_IZ == IntPtr.Zero)
				id_read_arrayLcom_qq_taf_jce_JceStruct_IZ = JNIEnv.GetMethodID (class_ref, "read", "([Lcom/qq/taf/jce/JceStruct;IZ)[Lcom/qq/taf/jce/JceStruct;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.QQ.Taf.Jce.JceStruct[] __ret = (global::Com.QQ.Taf.Jce.JceStruct[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayLcom_qq_taf_jce_JceStruct_IZ, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.QQ.Taf.Jce.JceStruct));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_DIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(DIZ)D", "")]
		public unsafe double Read (double p0, int p1, bool p2)
		{
			if (id_read_DIZ == IntPtr.Zero)
				id_read_DIZ = JNIEnv.GetMethodID (class_ref, "read", "(DIZ)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallDoubleMethod  (Handle, id_read_DIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayDIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([DIZ)[D", "")]
		public unsafe double[] Read (double[] p0, int p1, bool p2)
		{
			if (id_read_arrayDIZ == IntPtr.Zero)
				id_read_arrayDIZ = JNIEnv.GetMethodID (class_ref, "read", "([DIZ)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayDIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_FIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(FIZ)F", "")]
		public unsafe float Read (float p0, int p1, bool p2)
		{
			if (id_read_FIZ == IntPtr.Zero)
				id_read_FIZ = JNIEnv.GetMethodID (class_ref, "read", "(FIZ)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallFloatMethod  (Handle, id_read_FIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayFIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([FIZ)[F", "")]
		public unsafe float[] Read (float[] p0, int p1, bool p2)
		{
			if (id_read_arrayFIZ == IntPtr.Zero)
				id_read_arrayFIZ = JNIEnv.GetMethodID (class_ref, "read", "([FIZ)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayFIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(IIZ)I", "")]
		public unsafe int Read (int p0, int p1, bool p2)
		{
			if (id_read_IIZ == IntPtr.Zero)
				id_read_IIZ = JNIEnv.GetMethodID (class_ref, "read", "(IIZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallIntMethod  (Handle, id_read_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([IIZ)[I", "")]
		public unsafe int[] Read (int[] p0, int p1, bool p2)
		{
			if (id_read_arrayIIZ == IntPtr.Zero)
				id_read_arrayIIZ = JNIEnv.GetMethodID (class_ref, "read", "([IIZ)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayIIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(Ljava/lang/String;IZ)Ljava/lang/String;", "")]
		public unsafe string Read (string p0, int p1, bool p2)
		{
			if (id_read_Ljava_lang_String_IZ == IntPtr.Zero)
				id_read_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/String;IZ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_read_Ljava_lang_String_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_read_arrayLjava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([Ljava/lang/String;IZ)[Ljava/lang/String;", "")]
		public unsafe string[] Read (string[] p0, int p1, bool p2)
		{
			if (id_read_arrayLjava_lang_String_IZ == IntPtr.Zero)
				id_read_arrayLjava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "read", "([Ljava/lang/String;IZ)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayLjava_lang_String_IZ, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_JIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(JIZ)J", "")]
		public unsafe long Read (long p0, int p1, bool p2)
		{
			if (id_read_JIZ == IntPtr.Zero)
				id_read_JIZ = JNIEnv.GetMethodID (class_ref, "read", "(JIZ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallLongMethod  (Handle, id_read_JIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arrayJIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([JIZ)[J", "")]
		public unsafe long[] Read (long[] p0, int p1, bool p2)
		{
			if (id_read_arrayJIZ == IntPtr.Zero)
				id_read_arrayJIZ = JNIEnv.GetMethodID (class_ref, "read", "([JIZ)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arrayJIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_SIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "(SIZ)S", "")]
		public unsafe short Read (short p0, int p1, bool p2)
		{
			if (id_read_SIZ == IntPtr.Zero)
				id_read_SIZ = JNIEnv.GetMethodID (class_ref, "read", "(SIZ)S");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallShortMethod  (Handle, id_read_SIZ, __args);
			} finally {
			}
		}

		static IntPtr id_read_arraySIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("read", "([SIZ)[S", "")]
		public unsafe short[] Read (short[] p0, int p1, bool p2)
		{
			if (id_read_arraySIZ == IntPtr.Zero)
				id_read_arraySIZ = JNIEnv.GetMethodID (class_ref, "read", "([SIZ)[S");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_arraySIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readArray_arrayLjava_lang_Object_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readArray' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("readArray", "([Ljava/lang/Object;IZ)[Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object[] ReadArray (global::Java.Lang.Object[] p0, int p1, bool p2)
		{
			if (id_readArray_arrayLjava_lang_Object_IZ == IntPtr.Zero)
				id_readArray_arrayLjava_lang_Object_IZ = JNIEnv.GetMethodID (class_ref, "readArray", "([Ljava/lang/Object;IZ)[Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readArray_arrayLjava_lang_Object_IZ, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readArray_Ljava_util_List_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readArray' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("readArray", "(Ljava/util/List;IZ)Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList ReadArray (global::System.Collections.IList p0, int p1, bool p2)
		{
			if (id_readArray_Ljava_util_List_IZ == IntPtr.Zero)
				id_readArray_Ljava_util_List_IZ = JNIEnv.GetMethodID (class_ref, "readArray", "(Ljava/util/List;IZ)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_readArray_Ljava_util_List_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readByteString_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readByteString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("readByteString", "(Ljava/lang/String;IZ)Ljava/lang/String;", "")]
		public unsafe string ReadByteString (string p0, int p1, bool p2)
		{
			if (id_readByteString_Ljava_lang_String_IZ == IntPtr.Zero)
				id_readByteString_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "readByteString", "(Ljava/lang/String;IZ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readByteString_Ljava_lang_String_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readHead' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream.HeadData']]"
		[Register ("readHead", "(Lcom/qq/taf/jce/JceInputStream$HeadData;)V", "")]
		public unsafe void ReadHead (global::Com.QQ.Taf.Jce.JceInputStream.HeadData p0)
		{
			if (id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_ == IntPtr.Zero)
				id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_ = JNIEnv.GetMethodID (class_ref, "readHead", "(Lcom/qq/taf/jce/JceInputStream$HeadData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_, __args);
			} finally {
			}
		}

		static IntPtr id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readHead' and count(parameter)=2 and parameter[1][@type='com.qq.taf.jce.JceInputStream.HeadData'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("readHead", "(Lcom/qq/taf/jce/JceInputStream$HeadData;Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ReadHead (global::Com.QQ.Taf.Jce.JceInputStream.HeadData p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readHead", "(Lcom/qq/taf/jce/JceInputStream$HeadData;Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readHead_Lcom_qq_taf_jce_JceInputStream_HeadData_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readList_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("readList", "(IZ)Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList ReadList (int p0, bool p1)
		{
			if (id_readList_IZ == IntPtr.Zero)
				id_readList_IZ = JNIEnv.GetMethodID (class_ref, "readList", "(IZ)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_readList_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readMap_Ljava_util_Map_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readMap' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;K, V&gt;'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("readMap", "(Ljava/util/Map;IZ)Ljava/util/HashMap;", "")]
		public unsafe global::System.Collections.IDictionary ReadMap (global::System.Collections.IDictionary p0, int p1, bool p2)
		{
			if (id_readMap_Ljava_util_Map_IZ == IntPtr.Zero)
				id_readMap_Ljava_util_Map_IZ = JNIEnv.GetMethodID (class_ref, "readMap", "(Ljava/util/Map;IZ)Ljava/util/HashMap;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_readMap_Ljava_util_Map_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readString_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("readString", "(IZ)Ljava/lang/String;", "")]
		public unsafe string ReadString (int p0, bool p1)
		{
			if (id_readString_IZ == IntPtr.Zero)
				id_readString_IZ = JNIEnv.GetMethodID (class_ref, "readString", "(IZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readStringMap_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='readStringMap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("readStringMap", "(IZ)Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> ReadStringMap (int p0, bool p1)
		{
			if (id_readStringMap_IZ == IntPtr.Zero)
				id_readStringMap_IZ = JNIEnv.GetMethodID (class_ref, "readStringMap", "(IZ)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_readStringMap_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setServerEncoding_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='setServerEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerEncoding", "(Ljava/lang/String;)I", "")]
		public unsafe int SetServerEncoding (string p0)
		{
			if (id_setServerEncoding_Ljava_lang_String_ == IntPtr.Zero)
				id_setServerEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerEncoding", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_setServerEncoding_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_skipToStructEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='skipToStructEnd' and count(parameter)=0]"
		[Register ("skipToStructEnd", "()V", "")]
		public unsafe void SkipToStructEnd ()
		{
			if (id_skipToStructEnd == IntPtr.Zero)
				id_skipToStructEnd = JNIEnv.GetMethodID (class_ref, "skipToStructEnd", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_skipToStructEnd);
			} finally {
			}
		}

		static IntPtr id_skipToTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='skipToTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipToTag", "(I)Z", "")]
		public unsafe bool SkipToTag (int p0)
		{
			if (id_skipToTag_I == IntPtr.Zero)
				id_skipToTag_I = JNIEnv.GetMethodID (class_ref, "skipToTag", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_skipToTag_I, __args);
			} finally {
			}
		}

		static IntPtr id_warp_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='warp' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("warp", "([B)V", "")]
		public unsafe void Warp (byte[] p0)
		{
			if (id_warp_arrayB == IntPtr.Zero)
				id_warp_arrayB = JNIEnv.GetMethodID (class_ref, "warp", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_warp_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_wrap_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceInputStream']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("wrap", "([B)V", "")]
		public unsafe void Wrap (byte[] p0)
		{
			if (id_wrap_arrayB == IntPtr.Zero)
				id_wrap_arrayB = JNIEnv.GetMethodID (class_ref, "wrap", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_wrap_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
