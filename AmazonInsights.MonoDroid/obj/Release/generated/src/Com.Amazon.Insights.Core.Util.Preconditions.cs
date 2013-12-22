using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/util/Preconditions", DoNotGenerateAcw=true)]
	public sealed partial class Preconditions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/util/Preconditions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preconditions); }
		}

		internal Preconditions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkArgument_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static void CheckArgument (bool p0)
		{
			if (id_checkArgument_Z == IntPtr.Zero)
				id_checkArgument_Z = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_Z, new JValue (p0));
		}

		static IntPtr id_checkArgument_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static void CheckArgument (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkArgument_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/Object;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_Object_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void CheckArgument (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_checkElementIndex_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkElementIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("checkElementIndex", "(II)I", "")]
		public static int CheckElementIndex (int p0, int p1)
		{
			if (id_checkElementIndex_II == IntPtr.Zero)
				id_checkElementIndex_II = JNIEnv.GetStaticMethodID (class_ref, "checkElementIndex", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_checkElementIndex_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_checkElementIndex_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkElementIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkElementIndex", "(IILjava/lang/String;)I", "")]
		public static int CheckElementIndex (int p0, int p1, string p2)
		{
			if (id_checkElementIndex_IILjava_lang_String_ == IntPtr.Zero)
				id_checkElementIndex_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkElementIndex", "(IILjava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkElementIndex_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0)
		{
			if (id_checkNotNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_checkPositionIndex_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkPositionIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("checkPositionIndex", "(II)I", "")]
		public static int CheckPositionIndex (int p0, int p1)
		{
			if (id_checkPositionIndex_II == IntPtr.Zero)
				id_checkPositionIndex_II = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndex", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_checkPositionIndex_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_checkPositionIndex_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkPositionIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkPositionIndex", "(IILjava/lang/String;)I", "")]
		public static int CheckPositionIndex (int p0, int p1, string p2)
		{
			if (id_checkPositionIndex_IILjava_lang_String_ == IntPtr.Zero)
				id_checkPositionIndex_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndex", "(IILjava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkPositionIndex_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_checkPositionIndexes_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkPositionIndexes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPositionIndexes", "(III)V", "")]
		public static void CheckPositionIndexes (int p0, int p1, int p2)
		{
			if (id_checkPositionIndexes_III == IntPtr.Zero)
				id_checkPositionIndexes_III = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndexes", "(III)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkPositionIndexes_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_checkState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static void CheckState (bool p0)
		{
			if (id_checkState_Z == IntPtr.Zero)
				id_checkState_Z = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_Z, new JValue (p0));
		}

		static IntPtr id_checkState_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static void CheckState (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkState_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/Object;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_Object_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void CheckState (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
