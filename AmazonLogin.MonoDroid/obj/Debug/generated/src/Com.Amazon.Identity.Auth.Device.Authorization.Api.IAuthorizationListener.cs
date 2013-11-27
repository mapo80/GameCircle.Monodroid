using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/interface[@name='AuthorizationListener']"
	[Register ("com/amazon/identity/auth/device/authorization/api/AuthorizationListener", "", "Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListenerInvoker")]
	public partial interface IAuthorizationListener : global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/interface[@name='AuthorizationListener']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCancel", "(Landroid/os/Bundle;)V", "GetOnCancel_Landroid_os_Bundle_Handler:Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListenerInvoker, AmazonLogin.MonoDroid")]
		void OnCancel (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AuthorizationListener", DoNotGenerateAcw=true)]
	internal class IAuthorizationListenerInvoker : global::Java.Lang.Object, IAuthorizationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AuthorizationListener");
		IntPtr class_ref;

		public static IAuthorizationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthorizationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.authorization.api.AuthorizationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthorizationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAuthorizationListenerInvoker); }
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
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCancel_Landroid_os_Bundle_;
		public void OnCancel (global::Android.OS.Bundle p0)
		{
			if (id_onCancel_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCancel_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onCancel_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_onError_Lcom_amazon_identity_auth_device_AuthError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_amazon_identity_auth_device_AuthError_Handler ()
		{
			if (cb_onError_Lcom_amazon_identity_auth_device_AuthError_ == null)
				cb_onError_Lcom_amazon_identity_auth_device_AuthError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_amazon_identity_auth_device_AuthError_);
			return cb_onError_Lcom_amazon_identity_auth_device_AuthError_;
		}

		static void n_OnError_Lcom_amazon_identity_auth_device_AuthError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.AuthError p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_amazon_identity_auth_device_AuthError_;
		public void OnError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_onError_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_onError_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/amazon/identity/auth/device/AuthError;)V");
			JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
		}

		static Delegate cb_onSuccess_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSuccess_Landroid_os_Bundle_ == null)
				cb_onSuccess_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Landroid_os_Bundle_);
			return cb_onSuccess_Landroid_os_Bundle_;
		}

		static void n_OnSuccess_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Landroid_os_Bundle_;
		public void OnSuccess (global::Android.OS.Bundle p0)
		{
			if (id_onSuccess_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSuccess_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Landroid_os_Bundle_, new JValue (p0));
		}

	}

}
