using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AuthorizationHelper", DoNotGenerateAcw=true)]
	public partial class AuthorizationHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AuthorizationHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationHelper); }
		}

		protected AuthorizationHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationHelper']/constructor[@name='AuthorizationHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthorizationHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthorizationHelper)) {
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

		static Delegate cb_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler ()
		{
			if (cb_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == null)
				cb_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_);
			return cb_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		}

		static void n_Authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4, IntPtr native_p5)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p5 = (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationHelper']/method[@name='authorize' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='boolean'] and parameter[6][@type='com.amazon.identity.auth.device.authorization.api.AuthorizationListener']]"
		[Register ("authorize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;ZLcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", "GetAuthorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler")]
		public virtual void Authorize (global::Android.Content.Context p0, string p1, string p2, string[] p3, bool p4, global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p5)
		{
			if (id_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == IntPtr.Zero)
				id_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;ZLcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_authorize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ZLcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getOAuth2Url_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationHelper']/method[@name='getOAuth2Url' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("getOAuth2Url", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public static string GetOAuth2Url (global::Android.Content.Context p0, string p1, string p2, string[] p3, string p4, bool p5)
		{
			if (id_getOAuth2Url_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getOAuth2Url_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getOAuth2Url", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOAuth2Url_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

	}
}
