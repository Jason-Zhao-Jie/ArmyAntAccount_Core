using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/impl/DirCreateTask", DoNotGenerateAcw=true)]
	public partial class DirCreateTask : global::Com.Tencent.Upload.Task.CommandTask {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask.CmdTaskRsp']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/DirCreateTask$CmdTaskRsp", DoNotGenerateAcw=true)]
		public sealed partial class CmdTaskRsp : global::Com.Tencent.Upload.Task.ITaskRsp {


			static IntPtr accessUrl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask.CmdTaskRsp']/field[@name='accessUrl']"
			[Register ("accessUrl")]
			public string AccessUrl {
				get {
					if (accessUrl_jfieldId == IntPtr.Zero)
						accessUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "accessUrl", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, accessUrl_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (accessUrl_jfieldId == IntPtr.Zero)
						accessUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "accessUrl", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, accessUrl_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr ctime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask.CmdTaskRsp']/field[@name='ctime']"
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

			static IntPtr path_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask.CmdTaskRsp']/field[@name='path']"
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
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/impl/DirCreateTask$CmdTaskRsp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CmdTaskRsp); }
			}

			internal CmdTaskRsp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_LFileCloud_DirCreateRsp_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask.CmdTaskRsp']/constructor[@name='DirCreateTask.CmdTaskRsp' and count(parameter)=1 and parameter[1][@type='FileCloud.DirCreateRsp']]"
			[Register (".ctor", "(LFileCloud/DirCreateRsp;)V", "")]
			public unsafe CmdTaskRsp (global::FileCloud.DirCreateRsp p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CmdTaskRsp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(LFileCloud/DirCreateRsp;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(LFileCloud/DirCreateRsp;)V", __args);
						return;
					}

					if (id_ctor_LFileCloud_DirCreateRsp_ == IntPtr.Zero)
						id_ctor_LFileCloud_DirCreateRsp_ = JNIEnv.GetMethodID (class_ref, "<init>", "(LFileCloud/DirCreateRsp;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_LFileCloud_DirCreateRsp_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_LFileCloud_DirCreateRsp_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.upload.task.impl']/interface[@name='DirCreateTask.IListener']"
		[Register ("com/tencent/upload/task/impl/DirCreateTask$IListener", "", "Com.Tencent.Upload.Task.Impl.DirCreateTask/IListenerInvoker")]
		public partial interface IListener : global::Com.Tencent.Upload.Task.ICmdListener {

		}

		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/DirCreateTask$IListener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/upload/task/impl/DirCreateTask$IListener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.upload.task.impl.DirCreateTask.IListener"));
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
				global::Com.Tencent.Upload.Task.Impl.DirCreateTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.DirCreateTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Tencent.Upload.Task.Impl.DirCreateTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.DirCreateTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/tencent/upload/task/impl/DirCreateTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirCreateTask); }
		}

		protected DirCreateTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_upload_task_impl_DirCreateTask_IListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask']/constructor[@name='DirCreateTask' and count(parameter)=5 and parameter[1][@type='com.tencent.upload.Const.FileType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.tencent.upload.task.impl.DirCreateTask.IListener']]"
		[Register (".ctor", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/upload/task/impl/DirCreateTask$IListener;)V", "")]
		public unsafe DirCreateTask (global::Com.Tencent.Upload.Const.FileType p0, string p1, string p2, string p3, global::Com.Tencent.Upload.Task.Impl.DirCreateTask.IListener p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (DirCreateTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/upload/task/impl/DirCreateTask$IListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/upload/task/impl/DirCreateTask$IListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_upload_task_impl_DirCreateTask_IListener_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_upload_task_impl_DirCreateTask_IListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/Const$FileType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/upload/task/impl/DirCreateTask$IListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_upload_task_impl_DirCreateTask_IListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_upload_task_impl_DirCreateTask_IListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Tencent.Upload.Task.Impl.DirCreateTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.DirCreateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe global::Com.Tencent.Upload.Const.FileType FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask']/method[@name='getFileType' and count(parameter)=0]"
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
			global::Com.Tencent.Upload.Task.Impl.DirCreateTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.DirCreateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe global::FileCloud.DirCreateRsp Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='DirCreateTask']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()LFileCloud/DirCreateRsp;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()LFileCloud/DirCreateRsp;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::FileCloud.DirCreateRsp> (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::FileCloud.DirCreateRsp> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()LFileCloud/DirCreateRsp;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
