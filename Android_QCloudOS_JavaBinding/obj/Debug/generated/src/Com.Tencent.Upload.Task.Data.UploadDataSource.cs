using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Upload.Task.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']"
	[global::Android.Runtime.Register ("com/tencent/upload/task/data/UploadDataSource", DoNotGenerateAcw=true)]
	public abstract partial class UploadDataSource : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/data/UploadDataSource$ByteDataSource", DoNotGenerateAcw=true)]
		public partial class ByteDataSource : global::Com.Tencent.Upload.Task.Data.UploadDataSource {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/data/UploadDataSource$ByteDataSource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ByteDataSource); }
			}

			protected ByteDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcel_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/constructor[@name='UploadDataSource.ByteDataSource' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
			public unsafe ByteDataSource (global::Android.OS.Parcel p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ByteDataSource)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/constructor[@name='UploadDataSource.ByteDataSource' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe ByteDataSource (byte[] p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (ByteDataSource)) {
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

			static Delegate cb_getDataLength;
#pragma warning disable 0169
			static Delegate GetGetDataLengthHandler ()
			{
				if (cb_getDataLength == null)
					cb_getDataLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDataLength);
				return cb_getDataLength;
			}

			static long n_GetDataLength (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLength;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLength;
			public override unsafe long DataLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='getDataLength' and count(parameter)=0]"
				[Register ("getDataLength", "()J", "GetGetDataLengthHandler")]
				get {
					if (id_getDataLength == IntPtr.Zero)
						id_getDataLength = JNIEnv.GetMethodID (class_ref, "getDataLength", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod  (Handle, id_getDataLength);
						else
							return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLength", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_calcSha1;
#pragma warning disable 0169
			static Delegate GetCalcSha1Handler ()
			{
				if (cb_calcSha1 == null)
					cb_calcSha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CalcSha1);
				return cb_calcSha1;
			}

			static IntPtr n_CalcSha1 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CalcSha1 ());
			}
#pragma warning restore 0169

			static IntPtr id_calcSha1;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='calcSha1' and count(parameter)=0]"
			[Register ("calcSha1", "()Ljava/lang/String;", "GetCalcSha1Handler")]
			public override unsafe string CalcSha1 ()
			{
				if (id_calcSha1 == IntPtr.Zero)
					id_calcSha1 = JNIEnv.GetMethodID (class_ref, "calcSha1", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_calcSha1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcSha1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public override unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_describeContents);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
				} finally {
				}
			}

			static Delegate cb_exists;
#pragma warning disable 0169
			static Delegate GetExistsHandler ()
			{
				if (cb_exists == null)
					cb_exists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Exists);
				return cb_exists;
			}

			static bool n_Exists (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Exists ();
			}
#pragma warning restore 0169

			static IntPtr id_exists;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='exists' and count(parameter)=0]"
			[Register ("exists", "()Z", "GetExistsHandler")]
			public override unsafe bool Exists ()
			{
				if (id_exists == IntPtr.Zero)
					id_exists = JNIEnv.GetMethodID (class_ref, "exists", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_exists);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exists", "()Z"));
				} finally {
				}
			}

			static Delegate cb_readData_JIarrayBI;
#pragma warning disable 0169
			static Delegate GetReadData_JIarrayBIHandler ()
			{
				if (cb_readData_JIarrayBI == null)
					cb_readData_JIarrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr, int, long>) n_ReadData_JIarrayBI);
				return cb_readData_JIarrayBI;
			}

			static long n_ReadData_JIarrayBI (IntPtr jnienv, IntPtr native__this, long p0, int p1, IntPtr native_p2, int p3)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.ReadData (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_readData_JIarrayBI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='readData' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("readData", "(JI[BI)J", "GetReadData_JIarrayBIHandler")]
			public override unsafe long ReadData (long p0, int p1, byte[] p2, int p3)
			{
				if (id_readData_JIarrayBI == IntPtr.Zero)
					id_readData_JIarrayBI = JNIEnv.GetMethodID (class_ref, "readData", "(JI[BI)J");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					long __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod  (Handle, id_readData_JIarrayBI, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readData", "(JI[BI)J"), __args);
					return __ret;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.ByteDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.ByteDataSource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public override unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']"
		[global::Android.Runtime.Register ("com/tencent/upload/task/data/UploadDataSource$FileDataSource", DoNotGenerateAcw=true)]
		public partial class FileDataSource : global::Com.Tencent.Upload.Task.Data.UploadDataSource {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/upload/task/data/UploadDataSource$FileDataSource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileDataSource); }
			}

			protected FileDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcel_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/constructor[@name='UploadDataSource.FileDataSource' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
			public unsafe FileDataSource (global::Android.OS.Parcel p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (FileDataSource)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/constructor[@name='UploadDataSource.FileDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe FileDataSource (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (FileDataSource)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getDataLength;
#pragma warning disable 0169
			static Delegate GetGetDataLengthHandler ()
			{
				if (cb_getDataLength == null)
					cb_getDataLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDataLength);
				return cb_getDataLength;
			}

			static long n_GetDataLength (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLength;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLength;
			public override unsafe long DataLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='getDataLength' and count(parameter)=0]"
				[Register ("getDataLength", "()J", "GetGetDataLengthHandler")]
				get {
					if (id_getDataLength == IntPtr.Zero)
						id_getDataLength = JNIEnv.GetMethodID (class_ref, "getDataLength", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod  (Handle, id_getDataLength);
						else
							return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLength", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getFileName;
#pragma warning disable 0169
			static Delegate GetGetFileNameHandler ()
			{
				if (cb_getFileName == null)
					cb_getFileName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileName);
				return cb_getFileName;
			}

			static IntPtr n_GetFileName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FileName);
			}
#pragma warning restore 0169

			static IntPtr id_getFileName;
			public virtual unsafe string FileName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='getFileName' and count(parameter)=0]"
				[Register ("getFileName", "()Ljava/lang/String;", "GetGetFileNameHandler")]
				get {
					if (id_getFileName == IntPtr.Zero)
						id_getFileName = JNIEnv.GetMethodID (class_ref, "getFileName", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFileName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_calcSha1;
#pragma warning disable 0169
			static Delegate GetCalcSha1Handler ()
			{
				if (cb_calcSha1 == null)
					cb_calcSha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CalcSha1);
				return cb_calcSha1;
			}

			static IntPtr n_CalcSha1 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CalcSha1 ());
			}
#pragma warning restore 0169

			static IntPtr id_calcSha1;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='calcSha1' and count(parameter)=0]"
			[Register ("calcSha1", "()Ljava/lang/String;", "GetCalcSha1Handler")]
			public override unsafe string CalcSha1 ()
			{
				if (id_calcSha1 == IntPtr.Zero)
					id_calcSha1 = JNIEnv.GetMethodID (class_ref, "calcSha1", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_calcSha1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcSha1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public override unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_describeContents);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
				} finally {
				}
			}

			static Delegate cb_exists;
#pragma warning disable 0169
			static Delegate GetExistsHandler ()
			{
				if (cb_exists == null)
					cb_exists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Exists);
				return cb_exists;
			}

			static bool n_Exists (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Exists ();
			}
#pragma warning restore 0169

			static IntPtr id_exists;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='exists' and count(parameter)=0]"
			[Register ("exists", "()Z", "GetExistsHandler")]
			public override unsafe bool Exists ()
			{
				if (id_exists == IntPtr.Zero)
					id_exists = JNIEnv.GetMethodID (class_ref, "exists", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_exists);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exists", "()Z"));
				} finally {
				}
			}

			static Delegate cb_readData_JIarrayBI;
#pragma warning disable 0169
			static Delegate GetReadData_JIarrayBIHandler ()
			{
				if (cb_readData_JIarrayBI == null)
					cb_readData_JIarrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr, int, long>) n_ReadData_JIarrayBI);
				return cb_readData_JIarrayBI;
			}

			static long n_ReadData_JIarrayBI (IntPtr jnienv, IntPtr native__this, long p0, int p1, IntPtr native_p2, int p3)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				long __ret = __this.ReadData (p0, p1, p2, p3);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_readData_JIarrayBI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='readData' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
			[Register ("readData", "(JI[BI)J", "GetReadData_JIarrayBIHandler")]
			public override unsafe long ReadData (long p0, int p1, byte[] p2, int p3)
			{
				if (id_readData_JIarrayBI == IntPtr.Zero)
					id_readData_JIarrayBI = JNIEnv.GetMethodID (class_ref, "readData", "(JI[BI)J");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					long __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod  (Handle, id_readData_JIarrayBI, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readData", "(JI[BI)J"), __args);
					return __ret;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource.FileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource.FileDataSource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public override unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/upload/task/data/UploadDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadDataSource); }
		}

		protected UploadDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/constructor[@name='UploadDataSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UploadDataSource ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UploadDataSource)) {
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

		static Delegate cb_getDataLength;
#pragma warning disable 0169
		static Delegate GetGetDataLengthHandler ()
		{
			if (cb_getDataLength == null)
				cb_getDataLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDataLength);
			return cb_getDataLength;
		}

		static long n_GetDataLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataLength;
		}
#pragma warning restore 0169

		public abstract long DataLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='getDataLength' and count(parameter)=0]"
			[Register ("getDataLength", "()J", "GetGetDataLengthHandler")] get;
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_calcSha1;
#pragma warning disable 0169
		static Delegate GetCalcSha1Handler ()
		{
			if (cb_calcSha1 == null)
				cb_calcSha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CalcSha1);
			return cb_calcSha1;
		}

		static IntPtr n_CalcSha1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CalcSha1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='calcSha1' and count(parameter)=0]"
		[Register ("calcSha1", "()Ljava/lang/String;", "GetCalcSha1Handler")]
		public abstract string CalcSha1 ();

		static Delegate cb_exists;
#pragma warning disable 0169
		static Delegate GetExistsHandler ()
		{
			if (cb_exists == null)
				cb_exists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Exists);
			return cb_exists;
		}

		static bool n_Exists (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public abstract bool Exists ();

		static Delegate cb_readData_JIarrayBI;
#pragma warning disable 0169
		static Delegate GetReadData_JIarrayBIHandler ()
		{
			if (cb_readData_JIarrayBI == null)
				cb_readData_JIarrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr, int, long>) n_ReadData_JIarrayBI);
			return cb_readData_JIarrayBI;
		}

		static long n_ReadData_JIarrayBI (IntPtr jnienv, IntPtr native__this, long p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long __ret = __this.ReadData (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='readData' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("readData", "(JI[BI)J", "GetReadData_JIarrayBIHandler")]
		public abstract long ReadData (long p0, int p1, byte[] p2, int p3);

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Tencent.Upload.Task.Data.UploadDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Upload.Task.Data.UploadDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/tencent/upload/task/data/UploadDataSource", DoNotGenerateAcw=true)]
	internal partial class UploadDataSourceInvoker : UploadDataSource {

		public UploadDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadDataSourceInvoker); }
		}

		static IntPtr id_getDataLength;
		public override unsafe long DataLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='getDataLength' and count(parameter)=0]"
			[Register ("getDataLength", "()J", "GetGetDataLengthHandler")]
			get {
				if (id_getDataLength == IntPtr.Zero)
					id_getDataLength = JNIEnv.GetMethodID (class_ref, "getDataLength", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getDataLength);
				} finally {
				}
			}
		}

		static IntPtr id_calcSha1;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='calcSha1' and count(parameter)=0]"
		[Register ("calcSha1", "()Ljava/lang/String;", "GetCalcSha1Handler")]
		public override unsafe string CalcSha1 ()
		{
			if (id_calcSha1 == IntPtr.Zero)
				id_calcSha1 = JNIEnv.GetMethodID (class_ref, "calcSha1", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_calcSha1), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_exists;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public override unsafe bool Exists ()
		{
			if (id_exists == IntPtr.Zero)
				id_exists = JNIEnv.GetMethodID (class_ref, "exists", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_exists);
			} finally {
			}
		}

		static IntPtr id_readData_JIarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='readData' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("readData", "(JI[BI)J", "GetReadData_JIarrayBIHandler")]
		public override unsafe long ReadData (long p0, int p1, byte[] p2, int p3)
		{
			if (id_readData_JIarrayBI == IntPtr.Zero)
				id_readData_JIarrayBI = JNIEnv.GetMethodID (class_ref, "readData", "(JI[BI)J");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_readData_JIarrayBI, __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.upload.task.data']/class[@name='UploadDataSource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}

}
