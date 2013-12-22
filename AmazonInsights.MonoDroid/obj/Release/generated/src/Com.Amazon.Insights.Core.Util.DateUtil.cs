using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='DateUtil']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/util/DateUtil", DoNotGenerateAcw=true)]
	public partial class DateUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/util/DateUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateUtil); }
		}

		protected DateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createLocaleIndependentDateFormatter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='DateUtil']/method[@name='createLocaleIndependentDateFormatter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createLocaleIndependentDateFormatter", "(Ljava/lang/String;)Ljava/text/DateFormat;", "")]
		public static global::Java.Text.DateFormat CreateLocaleIndependentDateFormatter (string p0)
		{
			if (id_createLocaleIndependentDateFormatter_Ljava_lang_String_ == IntPtr.Zero)
				id_createLocaleIndependentDateFormatter_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createLocaleIndependentDateFormatter", "(Ljava/lang/String;)Ljava/text/DateFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Text.DateFormat __ret = global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLocaleIndependentDateFormatter_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isoDateFromMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='DateUtil']/method[@name='isoDateFromMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isoDateFromMillis", "(J)Ljava/lang/String;", "")]
		public static string IsoDateFromMillis (long p0)
		{
			if (id_isoDateFromMillis_J == IntPtr.Zero)
				id_isoDateFromMillis_J = JNIEnv.GetStaticMethodID (class_ref, "isoDateFromMillis", "(J)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_isoDateFromMillis_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
