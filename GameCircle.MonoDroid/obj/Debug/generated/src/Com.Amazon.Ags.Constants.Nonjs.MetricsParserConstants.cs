using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Nonjs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/nonjs/MetricsParserConstants", DoNotGenerateAcw=true)]
	public partial class MetricsParserConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/field[@name='COUNT_METRIC_KEY_PREFIX']"
		[Register ("COUNT_METRIC_KEY_PREFIX")]
		public const string CountMetricKeyPrefix = (string) "Count";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/field[@name='METRIC_KEY_PREFIX_DELIMITER']"
		[Register ("METRIC_KEY_PREFIX_DELIMITER")]
		public const string MetricKeyPrefixDelimiter = (string) "::";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/field[@name='TIME_METRIC_KEY_PREFIX']"
		[Register ("TIME_METRIC_KEY_PREFIX")]
		public const string TimeMetricKeyPrefix = (string) "Time";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/nonjs/MetricsParserConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetricsParserConstants); }
		}

		protected MetricsParserConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/constructor[@name='MetricsParserConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MetricsParserConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MetricsParserConstants)) {
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
		}

		static IntPtr id_convertCountKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/method[@name='convertCountKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertCountKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ConvertCountKey (string p0)
		{
			if (id_convertCountKey_Ljava_lang_String_ == IntPtr.Zero)
				id_convertCountKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertCountKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertCountKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_convertTimeKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.nonjs']/class[@name='MetricsParserConstants']/method[@name='convertTimeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertTimeKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ConvertTimeKey (string p0)
		{
			if (id_convertTimeKey_Ljava_lang_String_ == IntPtr.Zero)
				id_convertTimeKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertTimeKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertTimeKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
