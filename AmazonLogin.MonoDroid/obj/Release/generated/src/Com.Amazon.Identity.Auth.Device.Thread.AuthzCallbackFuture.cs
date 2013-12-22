using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='AuthzCallbackFuture']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/thread/AuthzCallbackFuture", DoNotGenerateAcw=true)]
	public partial class AuthzCallbackFuture : global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture, global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/thread/AuthzCallbackFuture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthzCallbackFuture); }
		}

		protected AuthzCallbackFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='AuthzCallbackFuture']/constructor[@name='AuthzCallbackFuture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthzCallbackFuture () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthzCallbackFuture)) {
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

		static IntPtr id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='AuthzCallbackFuture']/constructor[@name='AuthzCallbackFuture' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.authorization.api.AuthorizationListener']]"
		[Register (".ctor", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", "")]
		public AuthzCallbackFuture (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthzCallbackFuture)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0));
		}

		static IntPtr id_ctor_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='AuthzCallbackFuture']/constructor[@name='AuthzCallbackFuture' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register (".ctor", "(Lcom/amazon/identity/auth/device/shared/APIListener;)V", "")]
		public AuthzCallbackFuture (global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthzCallbackFuture)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/identity/auth/device/shared/APIListener;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/identity/auth/device/shared/APIListener;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/shared/APIListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0));
		}

		static Delegate cb_onCancel_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCancel_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCancel_Landroid_os_Bundle_ == null)
				cb_onCancel_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Landroid_os_Bundle_);
			return cb_onCancel_Landroid_os_Bundle_;
		}

		static void n_OnCancel_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.AuthzCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.AuthzCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancel_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='AuthzCallbackFuture']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCancel", "(Landroid/os/Bundle;)V", "GetOnCancel_Landroid_os_Bundle_Handler")]
		public virtual void OnCancel (global::Android.OS.Bundle p0)
		{
			if (id_onCancel_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCancel_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCancel_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCancel_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
