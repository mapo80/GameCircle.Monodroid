using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ScopesHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ScopesHelper", DoNotGenerateAcw=true)]
	public sealed partial class ScopesHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/ScopesHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScopesHelper); }
		}

		internal ScopesHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getScopesFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ScopesHelper']/method[@name='getScopesFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScopesFromString", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetScopesFromString (string p0)
		{
			if (id_getScopesFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_getScopesFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getScopesFromString", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScopesFromString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getScopesString_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ScopesHelper']/method[@name='getScopesString' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("getScopesString", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetScopesString (string[] p0)
		{
			if (id_getScopesString_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getScopesString_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getScopesString", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScopesString_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
