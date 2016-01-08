using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qq.taf.jce']/interface[@name='OnIllegalArgumentException']"
	[Register ("com/qq/taf/jce/OnIllegalArgumentException", "", "Com.QQ.Taf.Jce.IOnIllegalArgumentExceptionInvoker")]
	public partial interface IOnIllegalArgumentException : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/interface[@name='OnIllegalArgumentException']/method[@name='onException' and count(parameter)=4 and parameter[1][@type='java.lang.IllegalArgumentException'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onException", "(Ljava/lang/IllegalArgumentException;Ljava/nio/ByteBuffer;II)V", "GetOnException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_IIHandler:Com.QQ.Taf.Jce.IOnIllegalArgumentExceptionInvoker, Android_QCloudOS_JavaBinding")]
		void OnException (global::Java.Lang.IllegalArgumentException p0, global::Java.Nio.ByteBuffer p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/qq/taf/jce/OnIllegalArgumentException", DoNotGenerateAcw=true)]
	internal class IOnIllegalArgumentExceptionInvoker : global::Java.Lang.Object, IOnIllegalArgumentException {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qq/taf/jce/OnIllegalArgumentException");
		IntPtr class_ref;

		public static IOnIllegalArgumentException GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnIllegalArgumentException> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qq.taf.jce.OnIllegalArgumentException"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnIllegalArgumentExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnIllegalArgumentExceptionInvoker); }
		}

		static Delegate cb_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_IIHandler ()
		{
			if (cb_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II == null)
				cb_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_OnException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II);
			return cb_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II;
		}

		static void n_OnException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.QQ.Taf.Jce.IOnIllegalArgumentException __this = global::Java.Lang.Object.GetObject<global::Com.QQ.Taf.Jce.IOnIllegalArgumentException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IllegalArgumentException p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.IllegalArgumentException> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II;
		public unsafe void OnException (global::Java.Lang.IllegalArgumentException p0, global::Java.Nio.ByteBuffer p1, int p2, int p3)
		{
			if (id_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II == IntPtr.Zero)
				id_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/IllegalArgumentException;Ljava/nio/ByteBuffer;II)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onException_Ljava_lang_IllegalArgumentException_Ljava_nio_ByteBuffer_II, __args);
		}

	}

}
