using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='TokenHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/TokenHelper", DoNotGenerateAcw=true)]
	public sealed partial class TokenHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/TokenHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenHelper); }
		}

		internal TokenHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='TokenHelper']/method[@name='getToken' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register ("getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)V", "")]
		public static void GetToken (global::Android.Content.Context p0, string p1, string p2, string[] p3, global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p4)
		{
			if (id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetStaticMethodID (class_ref, "getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
