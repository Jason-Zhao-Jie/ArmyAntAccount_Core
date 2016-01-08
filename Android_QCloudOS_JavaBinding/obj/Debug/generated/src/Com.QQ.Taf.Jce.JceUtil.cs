using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.QQ.Taf.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']"
	[global::Android.Runtime.Register ("com/qq/taf/jce/JceUtil", DoNotGenerateAcw=true)]
	public sealed partial class JceUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qq/taf/jce/JceUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JceUtil); }
		}

		internal JceUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/constructor[@name='JceUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JceUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JceUtil)) {
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

		static IntPtr id_compareTo_Ljava_lang_Comparable_Ljava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("compareTo", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)I", "")]
		public static unsafe int CompareTo (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_compareTo_Ljava_lang_Comparable_Ljava_lang_Comparable_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Comparable_Ljava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_Ljava_lang_Comparable_Ljava_lang_Comparable_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_compareTo_arrayLjava_lang_Comparable_arrayLjava_lang_Comparable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T[]']]"
		[Register ("compareTo", "([Ljava/lang/Comparable;[Ljava/lang/Comparable;)I", "")]
		public static unsafe int CompareTo (global::Java.Lang.Object[] p0, global::Java.Lang.Object[] p1)
		{
			if (id_compareTo_arrayLjava_lang_Comparable_arrayLjava_lang_Comparable_ == IntPtr.Zero)
				id_compareTo_arrayLjava_lang_Comparable_arrayLjava_lang_Comparable_ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([Ljava/lang/Comparable;[Ljava/lang/Comparable;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayLjava_lang_Comparable_arrayLjava_lang_Comparable_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("compareTo", "(ZZ)I", "")]
		public static unsafe int CompareTo (bool p0, bool p1)
		{
			if (id_compareTo_ZZ == IntPtr.Zero)
				id_compareTo_ZZ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(ZZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_ZZ, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayZarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]']]"
		[Register ("compareTo", "([Z[Z)I", "")]
		public static unsafe int CompareTo (bool[] p0, bool[] p1)
		{
			if (id_compareTo_arrayZarrayZ == IntPtr.Zero)
				id_compareTo_arrayZarrayZ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([Z[Z)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayZarrayZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("compareTo", "(BB)I", "")]
		public static unsafe int CompareTo (sbyte p0, sbyte p1)
		{
			if (id_compareTo_BB == IntPtr.Zero)
				id_compareTo_BB = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(BB)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_BB, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("compareTo", "([B[B)I", "")]
		public static unsafe int CompareTo (byte[] p0, byte[] p1)
		{
			if (id_compareTo_arrayBarrayB == IntPtr.Zero)
				id_compareTo_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayBarrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("compareTo", "(CC)I", "")]
		public static unsafe int CompareTo (char p0, char p1)
		{
			if (id_compareTo_CC == IntPtr.Zero)
				id_compareTo_CC = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(CC)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_CC, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayCarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='char[]']]"
		[Register ("compareTo", "([C[C)I", "")]
		public static unsafe int CompareTo (char[] p0, char[] p1)
		{
			if (id_compareTo_arrayCarrayC == IntPtr.Zero)
				id_compareTo_arrayCarrayC = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([C[C)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayCarrayC, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("compareTo", "(DD)I", "")]
		public static unsafe int CompareTo (double p0, double p1)
		{
			if (id_compareTo_DD == IntPtr.Zero)
				id_compareTo_DD = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(DD)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_DD, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("compareTo", "([D[D)I", "")]
		public static unsafe int CompareTo (double[] p0, double[] p1)
		{
			if (id_compareTo_arrayDarrayD == IntPtr.Zero)
				id_compareTo_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([D[D)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayDarrayD, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("compareTo", "(FF)I", "")]
		public static unsafe int CompareTo (float p0, float p1)
		{
			if (id_compareTo_FF == IntPtr.Zero)
				id_compareTo_FF = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(FF)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_FF, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("compareTo", "([F[F)I", "")]
		public static unsafe int CompareTo (float[] p0, float[] p1)
		{
			if (id_compareTo_arrayFarrayF == IntPtr.Zero)
				id_compareTo_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([F[F)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayFarrayF, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compareTo", "(II)I", "")]
		public static unsafe int CompareTo (int p0, int p1)
		{
			if (id_compareTo_II == IntPtr.Zero)
				id_compareTo_II = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_II, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("compareTo", "([I[I)I", "")]
		public static unsafe int CompareTo (int[] p0, int[] p1)
		{
			if (id_compareTo_arrayIarrayI == IntPtr.Zero)
				id_compareTo_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([I[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayIarrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;T&gt;']]"
		[Register ("compareTo", "(Ljava/util/List;Ljava/util/List;)I", "")]
		public static unsafe int CompareTo (global::System.Collections.IList p0, global::System.Collections.IList p1)
		{
			if (id_compareTo_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_compareTo_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(Ljava/util/List;Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_Ljava_util_List_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_compareTo_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compareTo", "(JJ)I", "")]
		public static unsafe int CompareTo (long p0, long p1)
		{
			if (id_compareTo_JJ == IntPtr.Zero)
				id_compareTo_JJ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(JJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arrayJarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
		[Register ("compareTo", "([J[J)I", "")]
		public static unsafe int CompareTo (long[] p0, long[] p1)
		{
			if (id_compareTo_arrayJarrayJ == IntPtr.Zero)
				id_compareTo_arrayJarrayJ = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([J[J)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arrayJarrayJ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_compareTo_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("compareTo", "(SS)I", "")]
		public static unsafe int CompareTo (short p0, short p1)
		{
			if (id_compareTo_SS == IntPtr.Zero)
				id_compareTo_SS = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "(SS)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_SS, __args);
			} finally {
			}
		}

		static IntPtr id_compareTo_arraySarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='short[]']]"
		[Register ("compareTo", "([S[S)I", "")]
		public static unsafe int CompareTo (short[] p0, short[] p1)
		{
			if (id_compareTo_arraySarrayS == IntPtr.Zero)
				id_compareTo_arraySarrayS = JNIEnv.GetStaticMethodID (class_ref, "compareTo", "([S[S)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareTo_arraySarrayS, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_equals_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("equals", "(ZZ)Z", "")]
		public static unsafe bool Equals (bool p0, bool p1)
		{
			if (id_equals_ZZ == IntPtr.Zero)
				id_equals_ZZ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(ZZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_ZZ, __args);
			} finally {
			}
		}

		static IntPtr id_equals_BB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("equals", "(BB)Z", "")]
		public static unsafe bool Equals (sbyte p0, sbyte p1)
		{
			if (id_equals_BB == IntPtr.Zero)
				id_equals_BB = JNIEnv.GetStaticMethodID (class_ref, "equals", "(BB)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_BB, __args);
			} finally {
			}
		}

		static IntPtr id_equals_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("equals", "(CC)Z", "")]
		public static unsafe bool Equals (char p0, char p1)
		{
			if (id_equals_CC == IntPtr.Zero)
				id_equals_CC = JNIEnv.GetStaticMethodID (class_ref, "equals", "(CC)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_CC, __args);
			} finally {
			}
		}

		static IntPtr id_equals_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("equals", "(DD)Z", "")]
		public static unsafe bool Equals (double p0, double p1)
		{
			if (id_equals_DD == IntPtr.Zero)
				id_equals_DD = JNIEnv.GetStaticMethodID (class_ref, "equals", "(DD)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_DD, __args);
			} finally {
			}
		}

		static IntPtr id_equals_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("equals", "(FF)Z", "")]
		public static unsafe bool Equals (float p0, float p1)
		{
			if (id_equals_FF == IntPtr.Zero)
				id_equals_FF = JNIEnv.GetStaticMethodID (class_ref, "equals", "(FF)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_FF, __args);
			} finally {
			}
		}

		static IntPtr id_equals_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("equals", "(II)Z", "")]
		public static unsafe bool Equals (int p0, int p1)
		{
			if (id_equals_II == IntPtr.Zero)
				id_equals_II = JNIEnv.GetStaticMethodID (class_ref, "equals", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_II, __args);
			} finally {
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_equals_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equals_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("equals", "(JJ)Z", "")]
		public static unsafe bool Equals (long p0, long p1)
		{
			if (id_equals_JJ == IntPtr.Zero)
				id_equals_JJ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(JJ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_equals_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("equals", "(SS)Z", "")]
		public static unsafe bool Equals (short p0, short p1)
		{
			if (id_equals_SS == IntPtr.Zero)
				id_equals_SS = JNIEnv.GetStaticMethodID (class_ref, "equals", "(SS)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_SS, __args);
			} finally {
			}
		}

		static IntPtr id_getHexdump_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='getHexdump' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHexdump", "([B)Ljava/lang/String;", "")]
		public static unsafe string GetHexdump (byte[] p0)
		{
			if (id_getHexdump_arrayB == IntPtr.Zero)
				id_getHexdump_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getHexdump", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHexdump_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getHexdump_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='getHexdump' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getHexdump", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "")]
		public static unsafe string GetHexdump (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getHexdump_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getHexdump_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getHexdump", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHexdump_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getJceBufArray_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='getJceBufArray' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getJceBufArray", "(Ljava/nio/ByteBuffer;)[B", "")]
		public static unsafe byte[] GetJceBufArray (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getJceBufArray_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getJceBufArray_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getJceBufArray", "(Ljava/nio/ByteBuffer;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJceBufArray_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("hashCode", "(Z)I", "")]
		public static unsafe int HashCode (bool p0)
		{
			if (id_hashCode_Z == IntPtr.Zero)
				id_hashCode_Z = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Z)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Z, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("hashCode", "([Z)I", "")]
		public static unsafe int HashCode (bool[] p0)
		{
			if (id_hashCode_arrayZ == IntPtr.Zero)
				id_hashCode_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([Z)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("hashCode", "(B)I", "")]
		public static unsafe int HashCode (sbyte p0)
		{
			if (id_hashCode_B == IntPtr.Zero)
				id_hashCode_B = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_B, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("hashCode", "([B)I", "")]
		public static unsafe int HashCode (byte[] p0)
		{
			if (id_hashCode_arrayB == IntPtr.Zero)
				id_hashCode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("hashCode", "(C)I", "")]
		public static unsafe int HashCode (char p0)
		{
			if (id_hashCode_C == IntPtr.Zero)
				id_hashCode_C = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_C, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("hashCode", "([C)I", "")]
		public static unsafe int HashCode (char[] p0)
		{
			if (id_hashCode_arrayC == IntPtr.Zero)
				id_hashCode_arrayC = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([C)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayC, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_arrayLcom_qq_taf_jce_JceStruct_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='com.qq.taf.jce.JceStruct[]']]"
		[Register ("hashCode", "([Lcom/qq/taf/jce/JceStruct;)I", "")]
		public static unsafe int HashCode (global::Com.QQ.Taf.Jce.JceStruct[] p0)
		{
			if (id_hashCode_arrayLcom_qq_taf_jce_JceStruct_ == IntPtr.Zero)
				id_hashCode_arrayLcom_qq_taf_jce_JceStruct_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([Lcom/qq/taf/jce/JceStruct;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayLcom_qq_taf_jce_JceStruct_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("hashCode", "(D)I", "")]
		public static unsafe int HashCode (double p0)
		{
			if (id_hashCode_D == IntPtr.Zero)
				id_hashCode_D = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(D)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_D, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("hashCode", "([D)I", "")]
		public static unsafe int HashCode (double[] p0)
		{
			if (id_hashCode_arrayD == IntPtr.Zero)
				id_hashCode_arrayD = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([D)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayD, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("hashCode", "(F)I", "")]
		public static unsafe int HashCode (float p0)
		{
			if (id_hashCode_F == IntPtr.Zero)
				id_hashCode_F = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_F, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("hashCode", "([F)I", "")]
		public static unsafe int HashCode (float[] p0)
		{
			if (id_hashCode_arrayF == IntPtr.Zero)
				id_hashCode_arrayF = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([F)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayF, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hashCode", "(I)I", "")]
		public static unsafe int HashCode (int p0)
		{
			if (id_hashCode_I == IntPtr.Zero)
				id_hashCode_I = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_I, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("hashCode", "([I)I", "")]
		public static unsafe int HashCode (int[] p0)
		{
			if (id_hashCode_arrayI == IntPtr.Zero)
				id_hashCode_arrayI = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("hashCode", "(Ljava/lang/Object;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Object p0)
		{
			if (id_hashCode_Ljava_lang_Object_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("hashCode", "(J)I", "")]
		public static unsafe int HashCode (long p0)
		{
			if (id_hashCode_J == IntPtr.Zero)
				id_hashCode_J = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_J, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("hashCode", "([J)I", "")]
		public static unsafe int HashCode (long[] p0)
		{
			if (id_hashCode_arrayJ == IntPtr.Zero)
				id_hashCode_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([J)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayJ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("hashCode", "(S)I", "")]
		public static unsafe int HashCode (short p0)
		{
			if (id_hashCode_S == IntPtr.Zero)
				id_hashCode_S = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(S)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_S, __args);
			} finally {
			}
		}

		static IntPtr id_hashCode_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qq.taf.jce']/class[@name='JceUtil']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("hashCode", "([S)I", "")]
		public static unsafe int HashCode (short[] p0)
		{
			if (id_hashCode_arrayS == IntPtr.Zero)
				id_hashCode_arrayS = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "([S)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_arrayS, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
