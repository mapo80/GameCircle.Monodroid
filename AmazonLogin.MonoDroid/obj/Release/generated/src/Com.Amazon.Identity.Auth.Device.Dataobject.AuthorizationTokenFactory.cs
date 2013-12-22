using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationTokenFactory']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationTokenFactory", DoNotGenerateAcw=true)]
	public sealed partial class AuthorizationTokenFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationTokenFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationTokenFactory); }
		}

		internal AuthorizationTokenFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationTokenFactory']/method[@name='getAuthorizationToken' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE']]"
		[Register ("getAuthorizationToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken GetAuthorizationToken (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE p0)
		{
			if (id_getAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_ == IntPtr.Zero)
				id_getAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_ = JNIEnv.GetStaticMethodID (class_ref, "getAuthorizationToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;");
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getCopyAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationTokenFactory']/method[@name='getCopyAuthorizationToken' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AuthorizationToken']]"
		[Register ("getCopyAuthorizationToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken GetCopyAuthorizationToken (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken p0)
		{
			if (id_getCopyAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_ == IntPtr.Zero)
				id_getCopyAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_ = JNIEnv.GetStaticMethodID (class_ref, "getCopyAuthorizationToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;");
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCopyAuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
