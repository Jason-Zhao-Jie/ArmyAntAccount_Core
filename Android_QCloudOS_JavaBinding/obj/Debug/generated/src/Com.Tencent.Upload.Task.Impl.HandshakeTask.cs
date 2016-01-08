using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/impl/HandshakeTask", DoNotGenerateAcw=true)]
	public partial class HandshakeTask : global::Com.Tencent.Upload.Task.CommandTask {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/HandshakeTask$HandShakeResult", DoNotGenerateAcw=true)]
		public partial class HandShakeResult : global::Java.Lang.Object {


			static IntPtr clientIp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']/field[@name='clientIp']"
			[Register ("clientIp")]
			public string ClientIp {
				get {
					if (clientIp_jfieldId == IntPtr.Zero)
						clientIp_jfieldId = JNIEnv.GetFieldID (class_ref, "clientIp", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, clientIp_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (clientIp_jfieldId == IntPtr.Zero)
						clientIp_jfieldId = JNIEnv.GetFieldID (class_ref, "clientIp", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, clientIp_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr configs_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']/field[@name='configs']"
			[Register ("configs")]
			public global::System.Collections.IDictionary Configs {
				get {
					if (configs_jfieldId == IntPtr.Zero)
						configs_jfieldId = JNIEnv.GetFieldID (class_ref, "configs", "Ljava/util/Map;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, configs_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (configs_jfieldId == IntPtr.Zero)
						configs_jfieldId = JNIEnv.GetFieldID (class_ref, "configs", "Ljava/util/Map;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, configs_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr last_update_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']/field[@name='last_update']"
			[Register ("last_update")]
			public string LastUpdate {
				get {
					if (last_update_jfieldId == IntPtr.Zero)
						last_update_jfieldId = JNIEnv.GetFieldID (class_ref, "last_update", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, last_update_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (last_update_jfieldId == IntPtr.Zero)
						last_update_jfieldId = JNIEnv.GetFieldID (class_ref, "last_update", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, last_update_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr upload_svr_list_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']/field[@name='upload_svr_list']"
			[Register ("upload_svr_list")]
			public global::System.Collections.IList UploadSvrList {
				get {
					if (upload_svr_list_jfieldId == IntPtr.Zero)
						upload_svr_list_jfieldId = JNIEnv.GetFieldID (class_ref, "upload_svr_list", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, upload_svr_list_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (upload_svr_list_jfieldId == IntPtr.Zero)
						upload_svr_list_jfieldId = JNIEnv.GetFieldID (class_ref, "upload_svr_list", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, upload_svr_list_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/impl/HandshakeTask$HandShakeResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HandShakeResult); }
			}

			protected HandShakeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask.HandShakeResult']/constructor[@name='HandshakeTask.HandShakeResult' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HandShakeResult ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (HandShakeResult)) {
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.upload.task.impl']/interface[@name='HandshakeTask.IListener']"
		[Register ("com/tencent/upload/task/impl/HandshakeTask$IListener", "", "Com.Tencent.Upload.Task.Impl.HandshakeTask/IListenerInvoker")]
		public partial interface IListener : global::Com.Tencent.Upload.Task.ICmdListener {

		}

		[global::Android.Runtime.Register ("com/tencent/upload/task/impl/HandshakeTask$IListener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/upload/task/impl/HandshakeTask$IListener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.upload.task.impl.HandshakeTask.IListener"));
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
				global::Com.Tencent.Upload.Task.Impl.HandshakeTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.HandshakeTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Tencent.Upload.Task.Impl.HandshakeTask.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.HandshakeTask.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/tencent/upload/task/impl/HandshakeTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandshakeTask); }
		}

		protected HandshakeTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_upload_Const_FileType_ZLjava_lang_String_Lcom_tencent_upload_task_impl_HandshakeTask_IListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask']/constructor[@name='HandshakeTask' and count(parameter)=4 and parameter[1][@type='com.tencent.upload.Const.FileType'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.upload.task.impl.HandshakeTask.IListener']]"
		[Register (".ctor", "(Lcom/tencent/upload/Const$FileType;ZLjava/lang/String;Lcom/tencent/upload/task/impl/HandshakeTask$IListener;)V", "")]
		public unsafe HandshakeTask (global::Com.Tencent.Upload.Const.FileType p0, bool p1, string p2, global::Com.Tencent.Upload.Task.Impl.HandshakeTask.IListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (HandshakeTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/upload/Const$FileType;ZLjava/lang/String;Lcom/tencent/upload/task/impl/HandshakeTask$IListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/upload/Const$FileType;ZLjava/lang/String;Lcom/tencent/upload/task/impl/HandshakeTask$IListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_upload_Const_FileType_ZLjava_lang_String_Lcom_tencent_upload_task_impl_HandshakeTask_IListener_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_upload_Const_FileType_ZLjava_lang_String_Lcom_tencent_upload_task_impl_HandshakeTask_IListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/upload/Const$FileType;ZLjava/lang/String;Lcom/tencent/upload/task/impl/HandshakeTask$IListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_ZLjava_lang_String_Lcom_tencent_upload_task_impl_HandshakeTask_IListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_upload_Const_FileType_ZLjava_lang_String_Lcom_tencent_upload_task_impl_HandshakeTask_IListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Tencent.Upload.Task.Impl.HandshakeTask __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Impl.HandshakeTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe global::Com.Tencent.Upload.Const.FileType FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.impl']/class[@name='HandshakeTask']/method[@name='getFileType' and count(parameter)=0]"
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

	}
}
