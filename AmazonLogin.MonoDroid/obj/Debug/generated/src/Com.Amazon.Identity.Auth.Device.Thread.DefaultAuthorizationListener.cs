using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='DefaultAuthorizationListener']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/thread/DefaultAuthorizationListener", DoNotGenerateAcw=true)]
	public partial class DefaultAuthorizationListener : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/thread/DefaultAuthorizationListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultAuthorizationListener); }
		}

		protected DefaultAuthorizationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='DefaultAuthorizationListener']/constructor[@name='DefaultAuthorizationListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultAuthorizationListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultAuthorizationListener)) {
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
			global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancel_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='DefaultAuthorizationListener']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.AuthError p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Lcom_amazon_identity_auth_device_AuthError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='DefaultAuthorizationListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("onError", "(Lcom/amazon/identity/auth/device/AuthError;)V", "GetOnError_Lcom_amazon_identity_auth_device_AuthError_Handler")]
		public virtual void OnError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_onError_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_onError_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/amazon/identity/auth/device/AuthError;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
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
			global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.DefaultAuthorizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='DefaultAuthorizationListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler")]
		public virtual void OnSuccess (global::Android.OS.Bundle p0)
		{
			if (id_onSuccess_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSuccess_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onSuccess_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
