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
