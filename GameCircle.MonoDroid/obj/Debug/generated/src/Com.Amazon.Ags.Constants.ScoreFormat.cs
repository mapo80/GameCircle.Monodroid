using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ScoreFormat", DoNotGenerateAcw=true)]
	public sealed partial class ScoreFormat : global::Java.Lang.Enum {


		static IntPtr DURATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']/field[@name='DURATION']"
		[Register ("DURATION")]
		public static global::Com.Amazon.Ags.Constants.ScoreFormat Duration {
			get {
				if (DURATION_jfieldId == IntPtr.Zero)
					DURATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DURATION", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DURATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DURATION_jfieldId == IntPtr.Zero)
					DURATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DURATION", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DURATION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NUMERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Amazon.Ags.Constants.ScoreFormat Numeric {
			get {
				if (NUMERIC_jfieldId == IntPtr.Zero)
					NUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMERIC", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NUMERIC_jfieldId == IntPtr.Zero)
					NUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMERIC", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NUMERIC_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Amazon.Ags.Constants.ScoreFormat Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/amazon/ags/constants/ScoreFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ScoreFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScoreFormat); }
		}

		internal ScoreFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/ScoreFormat;", "")]
		public static global::Com.Amazon.Ags.Constants.ScoreFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/ScoreFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.ScoreFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ScoreFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/ScoreFormat;", "")]
		public static global::Com.Amazon.Ags.Constants.ScoreFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/ScoreFormat;");
			return (global::Com.Amazon.Ags.Constants.ScoreFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.ScoreFormat));
		}

	}
}
