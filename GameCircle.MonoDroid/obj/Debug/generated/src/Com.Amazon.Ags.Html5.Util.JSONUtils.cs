using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='JSONUtils']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/JSONUtils", DoNotGenerateAcw=true)]
	public partial class JSONUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/JSONUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSONUtils); }
		}

		protected JSONUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_sanitize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='JSONUtils']/method[@name='sanitize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sanitize", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Sanitize (string p0)
		{
			if (id_sanitize_Ljava_lang_String_ == IntPtr.Zero)
				id_sanitize_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sanitize_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
