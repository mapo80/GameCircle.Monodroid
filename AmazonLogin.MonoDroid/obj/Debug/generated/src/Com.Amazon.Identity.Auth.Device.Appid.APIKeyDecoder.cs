using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Appid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='APIKeyDecoder']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/appid/APIKeyDecoder", DoNotGenerateAcw=true)]
	public sealed partial class APIKeyDecoder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='APIKeyDecoder']/field[@name='CERTIFICATE_TYPE']"
		[Register ("CERTIFICATE_TYPE")]
		public const string CertificateType = (string) "X.509";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/appid/APIKeyDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (APIKeyDecoder); }
		}

		internal APIKeyDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='APIKeyDecoder']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("decode", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo Decode (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_decode_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getSignatureFingerprint_Ljava_lang_String_Landroid_content_pm_Signature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='APIKeyDecoder']/method[@name='getSignatureFingerprint' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.pm.Signature']]"
		[Register ("getSignatureFingerprint", "(Ljava/lang/String;Landroid/content/pm/Signature;)Ljava/lang/String;", "")]
		public static string GetSignatureFingerprint (string p0, global::Android.Content.PM.Signature p1)
		{
			if (id_getSignatureFingerprint_Ljava_lang_String_Landroid_content_pm_Signature_ == IntPtr.Zero)
				id_getSignatureFingerprint_Ljava_lang_String_Landroid_content_pm_Signature_ = JNIEnv.GetStaticMethodID (class_ref, "getSignatureFingerprint", "(Ljava/lang/String;Landroid/content/pm/Signature;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSignatureFingerprint_Ljava_lang_String_Landroid_content_pm_Signature_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
