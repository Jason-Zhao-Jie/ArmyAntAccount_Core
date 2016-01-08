using System;
using System.Collections.Generic;
using Android.Runtime;

namespace FileCloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']"
	[global::Android.Runtime.Register ("FileCloud/stPicInfo", DoNotGenerateAcw=true)]
	public sealed partial class StPicInfo : global::Com.QQ.Taf.Jce.JceStruct {


		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/field[@name='height']"
		[Register ("height")]
		public long Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "J");
				return JNIEnv.GetLongField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "J");
				try {
					JNIEnv.SetField (Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/field[@name='tag']"
		[Register ("tag")]
		public long Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "J");
				return JNIEnv.GetLongField (Handle, tag_jfieldId);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "J");
				try {
					JNIEnv.SetField (Handle, tag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/field[@name='width']"
		[Register ("width")]
		public long Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "J");
				return JNIEnv.GetLongField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "J");
				try {
					JNIEnv.SetField (Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("FileCloud/stPicInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StPicInfo); }
		}

		internal StPicInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/constructor[@name='stPicInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StPicInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StPicInfo)) {
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

		static IntPtr id_ctor_JJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/constructor[@name='stPicInfo' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(JJJ)V", "")]
		public unsafe StPicInfo (long p0, long p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (StPicInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JJJ)V", __args);
					return;
				}

				if (id_ctor_JJJ == IntPtr.Zero)
					id_ctor_JJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JJJ, __args);
			} finally {
			}
		}

		static IntPtr id_readFrom_Lcom_qq_taf_jce_JceInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceInputStream']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='FileCloud']/class[@name='stPicInfo']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceOutputStream']]"
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
