using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Appid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/appid/ThirdPartyAppIdentifier", DoNotGenerateAcw=true)]
	public sealed partial class ThirdPartyAppIdentifier : global::Com.Amazon.Identity.Auth.Device.Appid.AbstractAppIdentifier {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/appid/ThirdPartyAppIdentifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThirdPartyAppIdentifier); }
		}

		internal ThirdPartyAppIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/constructor[@name='ThirdPartyAppIdentifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ThirdPartyAppIdentifier () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ThirdPartyAppIdentifier)) {
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

		static IntPtr id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getAllowedScopes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAllowedScopes", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "")]
		public override string[] GetAllowedScopes (string p0, global::Android.Content.Context p1)
		{
			if (id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAllowedScopes", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getAppFamilyId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppFamilyId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public override string GetAppFamilyId (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAppInfoByApiKey_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getAppInfoByApiKey' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("getAppInfoByApiKey", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo GetAppInfoByApiKey (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_getAppInfoByApiKey_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppInfoByApiKey_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppInfoByApiKey", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_getAppInfoByApiKey_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getAppPermissions' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppPermissions", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "")]
		public override string[] GetAppPermissions (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppPermissions", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getAppVariantId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppVariantId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public override string GetAppVariantId (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppVariantId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getPackageName_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getPackageName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageName", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public override string GetPackageName (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageName_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageName_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageName", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageName_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getPackageNameByVariant' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageNameByVariant", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public override string GetPackageNameByVariant (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageNameByVariant", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getPackageNames_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='getPackageNames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageNames", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "")]
		public override string[] GetPackageNames (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageNames_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageNames_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageNames", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPackageNames_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isAPIKeyValidFormat_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/class[@name='ThirdPartyAppIdentifier']/method[@name='isAPIKeyValidFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("isAPIKeyValidFormat", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Z", "")]
		public bool IsAPIKeyValidFormat (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_isAPIKeyValidFormat_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAPIKeyValidFormat_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isAPIKeyValidFormat", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isAPIKeyValidFormat_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
