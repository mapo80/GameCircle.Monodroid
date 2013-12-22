using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AppIdentifierHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AppIdentifierHelper", DoNotGenerateAcw=true)]
	public sealed partial class AppIdentifierHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AppIdentifierHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppIdentifierHelper); }
		}

		internal AppIdentifierHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAppInfo_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AppIdentifierHelper']/method[@name='getAppInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppInfo", "(Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo GetAppInfo (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppInfo_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppInfo_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppInfo", "(Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppInfo_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AppIdentifierHelper']/method[@name='isAPIKeyValid' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("isAPIKeyValid", "(Ljava/lang/String;Landroid/content/Context;)Z", "")]
		public static bool IsAPIKeyValid (string p0, global::Android.Content.Context p1)
		{
			if (id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isAPIKeyValid", "(Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
