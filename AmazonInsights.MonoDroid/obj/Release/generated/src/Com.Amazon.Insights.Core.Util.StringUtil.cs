using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/util/StringUtil", DoNotGenerateAcw=true)]
	public sealed partial class StringUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public const string Utf8 = (string) "UTF-8";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/util/StringUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtil); }
		}

		internal StringUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_clipString_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='clipString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("clipString", "(Ljava/lang/String;IZ)Ljava/lang/String;", "")]
		public static string ClipString (string p0, int p1, bool p2)
		{
			if (id_clipString_Ljava_lang_String_IZ == IntPtr.Zero)
				id_clipString_Ljava_lang_String_IZ = JNIEnv.GetStaticMethodID (class_ref, "clipString", "(Ljava/lang/String;IZ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_clipString_Ljava_lang_String_IZ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_convertArrayToString_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='convertArrayToString' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("convertArrayToString", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ConvertArrayToString (string[] p0)
		{
			if (id_convertArrayToString_arrayLjava_lang_String_ == IntPtr.Zero)
				id_convertArrayToString_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertArrayToString", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertArrayToString_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_convertSetToString_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='convertSetToString' and count(parameter)=1 and parameter[1][@type='java.util.Set']]"
		[Register ("convertSetToString", "(Ljava/util/Set;)Ljava/lang/String;", "")]
		public static string ConvertSetToString (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_convertSetToString_Ljava_util_Set_ == IntPtr.Zero)
				id_convertSetToString_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "convertSetToString", "(Ljava/util/Set;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertSetToString_Ljava_util_Set_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='convertStreamToString' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static string ConvertStreamToString (global::System.IO.Stream p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_Ljava_nio_charset_Charset_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToString_Ljava_io_InputStream_Ljava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_convertStreamToUTF8String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='convertStreamToUTF8String' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToUTF8String", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string ConvertStreamToUTF8String (global::System.IO.Stream p0)
		{
			if (id_convertStreamToUTF8String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToUTF8String_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToUTF8String", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToUTF8String_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isBlank_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='isBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBlank", "(Ljava/lang/String;)Z", "")]
		public static bool IsBlank (string p0)
		{
			if (id_isBlank_Ljava_lang_String_ == IntPtr.Zero)
				id_isBlank_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isBlank", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBlank_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isNullOrEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/String;)Z", "")]
		public static bool IsNullOrEmpty (string p0)
		{
			if (id_isNullOrEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_trimOrPadString_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='StringUtil']/method[@name='trimOrPadString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("trimOrPadString", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static string TrimOrPadString (string p0, int p1, char p2)
		{
			if (id_trimOrPadString_Ljava_lang_String_IC == IntPtr.Zero)
				id_trimOrPadString_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "trimOrPadString", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimOrPadString_Ljava_lang_String_IC, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
