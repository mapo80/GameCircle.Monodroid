using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/auth/AuthManager", DoNotGenerateAcw=true)]
	public partial class AuthManager : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/auth/AuthManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthManager); }
		}

		protected AuthManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_util_ClientConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/constructor[@name='AuthManager' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.util.ClientConfig']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/util/ClientConfig;)V", "")]
		public AuthManager (global::Com.Amazon.Ags.Html5.Util.ClientConfig p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/util/ClientConfig;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/util/ClientConfig;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_util_ClientConfig_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_util_ClientConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/util/ClientConfig;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_util_ClientConfig_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_util_ClientConfig_, new JValue (p0));
		}

		static Delegate cb_getGameId;
#pragma warning disable 0169
		static Delegate GetGetGameIdHandler ()
		{
			if (cb_getGameId == null)
				cb_getGameId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGameId);
			return cb_getGameId;
		}

		static IntPtr n_GetGameId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GameId);
		}
#pragma warning restore 0169

		static IntPtr id_getGameId;
		public virtual string GameId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='getGameId' and count(parameter)=0]"
			[Register ("getGameId", "()Ljava/lang/String;", "GetGetGameIdHandler")]
			get {
				if (id_getGameId == IntPtr.Zero)
					id_getGameId = JNIEnv.GetMethodID (class_ref, "getGameId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGameId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getGameId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isLoggedIn;
#pragma warning disable 0169
		static Delegate GetIsLoggedInHandler ()
		{
			if (cb_isLoggedIn == null)
				cb_isLoggedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoggedIn);
			return cb_isLoggedIn;
		}

		static bool n_IsLoggedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggedIn;
		}
#pragma warning restore 0169

		static IntPtr id_isLoggedIn;
		public virtual bool IsLoggedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='isLoggedIn' and count(parameter)=0]"
			[Register ("isLoggedIn", "()Z", "GetIsLoggedInHandler")]
			get {
				if (id_isLoggedIn == IntPtr.Zero)
					id_isLoggedIn = JNIEnv.GetMethodID (class_ref, "isLoggedIn", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLoggedIn);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isLoggedIn);
			}
		}

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Logout);
			return cb_logout;
		}

		static void n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Logout ();
		}
#pragma warning restore 0169

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()V", "GetLogoutHandler")]
		public virtual void Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logout);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_logout);
		}

		static Delegate cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler ()
		{
			if (cb_notifyCurrentActivityChanged_Landroid_app_Activity_ == null)
				cb_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyCurrentActivityChanged_Landroid_app_Activity_);
			return cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
		}

		static void n_NotifyCurrentActivityChanged_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCurrentActivityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyCurrentActivityChanged_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='notifyCurrentActivityChanged' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyCurrentActivityChanged", "(Landroid/app/Activity;)V", "GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler")]
		public virtual void NotifyCurrentActivityChanged (global::Android.App.Activity p0)
		{
			if (id_notifyCurrentActivityChanged_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "notifyCurrentActivityChanged", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_tryGetToken;
#pragma warning disable 0169
		static Delegate GetTryGetTokenHandler ()
		{
			if (cb_tryGetToken == null)
				cb_tryGetToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TryGetToken);
			return cb_tryGetToken;
		}

		static IntPtr n_TryGetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TryGetToken ());
		}
#pragma warning restore 0169

		static IntPtr id_tryGetToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='tryGetToken' and count(parameter)=0]"
		[Register ("tryGetToken", "()Ljava/lang/String;", "GetTryGetTokenHandler")]
		public virtual string TryGetToken ()
		{
			if (id_tryGetToken == IntPtr.Zero)
				id_tryGetToken = JNIEnv.GetMethodID (class_ref, "tryGetToken", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_tryGetToken), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_tryGetToken), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
#pragma warning disable 0169
		static Delegate GetTryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler ()
		{
			if (cb_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == null)
				cb_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_);
			return cb_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		}

		static void n_TryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Auth.AuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p0 = (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TryLogin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.auth']/class[@name='AuthManager']/method[@name='tryLogin' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.authorization.api.AuthorizationListener']]"
		[Register ("tryLogin", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", "GetTryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_Handler")]
		public virtual void TryLogin (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p0)
		{
			if (id_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == IntPtr.Zero)
				id_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNIEnv.GetMethodID (class_ref, "tryLogin", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_tryLogin_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0));
		}

	}
}
