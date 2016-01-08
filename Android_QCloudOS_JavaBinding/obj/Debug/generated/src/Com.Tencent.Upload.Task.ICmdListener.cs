using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.upload.task']/interface[@name='ICmdListener']"
	[Register ("com/tencent/upload/task/ICmdListener", "", "Com.Tencent.Upload.Task.ICmdListenerInvoker")]
	public partial interface ICmdListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/interface[@name='ICmdListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailure", "(ILjava/lang/String;)V", "GetOnFailure_ILjava_lang_String_Handler:Com.Tencent.Upload.Task.ICmdListenerInvoker, Android_QCloudOS_JavaBinding")]
		void OnFailure (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task']/interface[@name='ICmdListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Tencent.Upload.Task.ICmdListenerInvoker, Android_QCloudOS_JavaBinding")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/tencent/upload/task/ICmdListener", DoNotGenerateAcw=true)]
	internal class ICmdListenerInvoker : global::Java.Lang.Object, ICmdListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/upload/task/ICmdListener");
		IntPtr class_ref;

		public static ICmdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICmdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.upload.task.ICmdListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICmdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICmdListenerInvoker); }
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
			global::Com.Tencent.Upload.Task.ICmdListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.ICmdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Upload.Task.ICmdListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.ICmdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class FailureEventArgs : global::System.EventArgs {

		public FailureEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/upload/task/ICmdListenerImplementor")]
	internal sealed partial class ICmdListenerImplementor : global::Java.Lang.Object, ICmdListener {

		object sender;

		public ICmdListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/upload/task/ICmdListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

		public void OnFailure (int p0, string p1)
		{
			var __h = OnFailureHandler;
			if (__h != null)
				__h (sender, new FailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Java.Lang.Object p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (ICmdListenerImplementor value)
		{
			return value.OnFailureHandler == null && value.OnSuccessHandler == null;
		}
	}

}
