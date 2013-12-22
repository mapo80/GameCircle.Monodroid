using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AmazonAuthorizationManager", DoNotGenerateAcw=true)]
	public partial class AmazonAuthorizationManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AmazonAuthorizationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonAuthorizationManager); }
		}

		protected AmazonAuthorizationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/constructor[@name='AmazonAuthorizationManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public AmazonAuthorizationManager (global::Android.Content.Context p0, global::Android.OS.Bundle p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AmazonAuthorizationManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Bundle_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		public virtual string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAppVariantId;
#pragma warning disable 0169
		static Delegate GetGetAppVariantIdHandler ()
		{
			if (cb_getAppVariantId == null)
				cb_getAppVariantId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVariantId);
			return cb_getAppVariantId;
		}

		static IntPtr n_GetAppVariantId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVariantId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppVariantId;
		public virtual string AppVariantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='getAppVariantId' and count(parameter)=0]"
			[Register ("getAppVariantId", "()Ljava/lang/String;", "GetGetAppVariantIdHandler")]
			get {
				if (id_getAppVariantId == IntPtr.Zero)
					id_getAppVariantId = JNIEnv.GetMethodID (class_ref, "getAppVariantId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVariantId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppVariantId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler ()
		{
			if (cb_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == null)
				cb_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_);
			return cb_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		}

		static IntPtr n_Authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p2 = (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authorize (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.amazon.identity.auth.device.authorization.api.AuthorizationListener']]"
		[Register ("authorize", "([Ljava/lang/String;Landroid/os/Bundle;Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)Ljava/util/concurrent/Future;", "GetAuthorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler")]
		public virtual global::Java.Util.Concurrent.IFuture Authorize (string[] p0, global::Android.OS.Bundle p1, global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p2)
		{
			if (id_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == IntPtr.Zero)
				id_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "([Ljava/lang/String;Landroid/os/Bundle;Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)Ljava/util/concurrent/Future;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Java.Util.Concurrent.IFuture __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_authorize_arrayLjava_lang_String_Landroid_os_Bundle_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_;
#pragma warning disable 0169
		static Delegate GetClearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_Handler ()
		{
			if (cb_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_ == null)
				cb_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_);
			return cb_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_;
		}

		static IntPtr n_ClearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p0 = (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearAuthorizationState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='clearAuthorizationState' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register ("clearAuthorizationState", "(Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;", "GetClearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_Handler")]
		public virtual global::Java.Util.Concurrent.IFuture ClearAuthorizationState (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p0)
		{
			if (id_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetMethodID (class_ref, "clearAuthorizationState", "(Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;");

			global::Java.Util.Concurrent.IFuture __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clearAuthorizationState_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_;
#pragma warning disable 0169
		static Delegate GetGetProfile_Lcom_amazon_identity_auth_device_shared_APIListener_Handler ()
		{
			if (cb_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_ == null)
				cb_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProfile_Lcom_amazon_identity_auth_device_shared_APIListener_);
			return cb_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_;
		}

		static IntPtr n_GetProfile_Lcom_amazon_identity_auth_device_shared_APIListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p0 = (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='getProfile' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register ("getProfile", "(Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;", "GetGetProfile_Lcom_amazon_identity_auth_device_shared_APIListener_Handler")]
		public virtual global::Java.Util.Concurrent.IFuture GetProfile (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p0)
		{
			if (id_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetMethodID (class_ref, "getProfile", "(Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;");

			global::Java.Util.Concurrent.IFuture __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProfile_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_;
#pragma warning disable 0169
		static Delegate GetGetToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_Handler ()
		{
			if (cb_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ == null)
				cb_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_);
			return cb_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_;
		}

		static IntPtr n_GetToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AmazonAuthorizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p1 = (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AmazonAuthorizationManager']/method[@name='getToken' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register ("getToken", "([Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;", "GetGetToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_Handler")]
		public virtual global::Java.Util.Concurrent.IFuture GetToken (string[] p0, global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p1)
		{
			if (id_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetMethodID (class_ref, "getToken", "([Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)Ljava/util/concurrent/Future;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Java.Util.Concurrent.IFuture __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getToken_arrayLjava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
