using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/impl/ObjectUpdateTask", DoNotGenerateAcw=true)]
	public partial class ObjectUpdateTask : global::Com.Tencent.Upload.Task.CommandTask {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask.CmdTaskRsp']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/ObjectUpdateTask$CmdTaskRsp", DoNotGenerateAcw=true)]
		public sealed partial class CmdTaskRsp : global::Com.Tencent.Upload.Task.ITaskRsp {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/impl/ObjectUpdateTask$CmdTaskRsp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CmdTaskRsp); }
			}

			internal CmdTaskRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_LFileCloud_FileDirUpdateRsp_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask.CmdTaskRsp']/constructor[@name='ObjectUpdateTask.CmdTaskRsp' and count(parameter)=1 and parameter[1][@type='FileCloud.FileDirUpdateRsp']]"
			[Register (".ctor", "(LFileCloud/FileDirUpdateRsp;)V", "")]
			public unsafe CmdTaskRsp (global::FileCloud.FileDirUpdateRsp p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CmdTaskRsp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/FileDirUpdateRsp;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/FileDirUpdateRsp;)V", __args);
						return;
					}

					if (id_ctor_LFileCloud_FileDirUpdateRsp_ == IntPtr.Zero)
						id_ctor_LFileCloud_FileDirUpdateRsp_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/FileDirUpdateRsp;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_FileDirUpdateRsp_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_FileDirUpdateRsp_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.upload.task.impl']/interface[@name='ObjectUpdateTask.IListener']"
		[Register ("com/tencent/upload/task/impl/ObjectUpdateTask$IListener", "", "Com.Tencent.Upload.Task.Impl.ObjectUpdateTask/IListenerInvoker")]
		public partial interface IListener : global::Com.Tencent.Upload.Task.ICmdListener {

		}

		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/ObjectUpdateTask$IListener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/upload/task/impl/ObjectUpdateTask$IListener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.upload.task.impl.ObjectUpdateTask.IListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onFailure_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFailure_ILjava_lang_String_Handler ()
			{
				if (cb_onFailure_ILjava_lang_String_ == null)
					cb_onFailure_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnFailure_ILjava_lang_String_);
				return cb_onFailure_ILjava_lang_String_;
			}

			static void n_OnFailure_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_ILjava_lang_String_;
			public unsafe void OnFailure (int p0, string p1)
			{
				if (id_onFailure_ILjava_lang_String_ == IntPtr.Zero)
					id_onFailure_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(ILjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (Handle, id_onFailure_ILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_Object_ == null)
					cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
				return cb_onSuccess_Ljava_lang_Object_;
			}

			static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_Object_;
			public unsafe void OnSuccess (global::Java.Lang.Object p0)
			{
				if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/impl/ObjectUpdateTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectUpdateTask); }
		}

		protected ObjectUpdateTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Lcom_tencent_upload_task_VideoAttr_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask']/constructor[@name='ObjectUpdateTask' and count(parameter)=8 and parameter[1][@type='com.tencent.upload.Const.FileType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.tencent.upload.task.VideoAttr'] and parameter[8][@type='com.tencent.upload.task.impl.ObjectUpdateTask.IListener']]"
		[Register (".ctor", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/tencent/upload/task/VideoAttr;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", "")]
		public unsafe ObjectUpdateTask (global::Com.Tencent.Upload.Const.FileType p0, string p1, string p2, int p3, int p4, string p5, global::Com.Tencent.Upload.Task.VideoAttr p6, global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (ObjectUpdateTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/tencent/upload/task/VideoAttr;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/tencent/upload/task/VideoAttr;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Lcom_tencent_upload_task_VideoAttr_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Lcom_tencent_upload_task_VideoAttr_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/tencent/upload/task/VideoAttr;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Lcom_tencent_upload_task_VideoAttr_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_IILjava_lang_String_Lcom_tencent_upload_task_VideoAttr_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask']/constructor[@name='ObjectUpdateTask' and count(parameter)=6 and parameter[1][@type='com.tencent.upload.Const.FileType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.upload.task.impl.ObjectUpdateTask.IListener']]"
		[Register (".ctor", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", "")]
		public unsafe ObjectUpdateTask (global::Com.Tencent.Upload.Const.FileType p0, string p1, string p2, int p3, string p4, global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask.IListener p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (ObjectUpdateTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/upload/task/impl/ObjectUpdateTask$IListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Lcom_tencent_upload_task_impl_ObjectUpdateTask_IListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_getFileType;
#pragma warning disable 0169
		static Delegate GetGetFileTypeHandler ()
		{
			if (cb_getFileType == null)
				cb_getFileType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileType);
			return cb_getFileType;
		}

		static IntPtr n_GetFileType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe global::Com.Tencent.Upload.Const.FileType FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask']/method[@name='getFileType' and count(parameter)=0]"
			[Register ("getFileType", "()Lcom/tencent/upload/Const$FileType;", "GetGetFileTypeHandler")]
			get {
				if (id_getFileType == IntPtr.Zero)
					id_getFileType = JNIEnv.GetMethodID (class_ref, "getFileType", "()Lcom/tencent/upload/Const$FileType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (JNIEnv.CallObjectMethod  (Handle, id_getFileType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Const.FileType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileType", "()Lcom/tencent/upload/Const$FileType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.ObjectUpdateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe global::FileCloud.FileDirUpdateRsp Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='ObjectUpdateTask']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()LFileCloud/FileDirUpdateRsp;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()LFileCloud/FileDirUpdateRsp;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::FileCloud.FileDirUpdateRsp> (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::FileCloud.FileDirUpdateRsp> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()LFileCloud/FileDirUpdateRsp;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
