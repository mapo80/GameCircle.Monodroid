using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Shared {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.shared']/interface[@name='APIListener']"
	[Register ("com/amazon/identity/auth/device/shared/APIListener", "", "Com.Amazon.Identity.Auth.Device.Shared.IAPIListenerInvoker")]
	public partial interface IAPIListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.shared']/interface[@name='APIListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("onError", "(Lcom/amazon/identity/auth/device/AuthError;)V", "GetOnError_Lcom_amazon_identity_auth_device_AuthError_Handler:Com.Amazon.Identity.Auth.Device.Shared.IAPIListenerInvoker, AmazonLogin.MonoDroid")]
		void OnError (global::Com.Amazon.Identity.Auth.Device.AuthError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.shared']/interface[@name='APIListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler:Com.Amazon.Identity.Auth.Device.Shared.IAPIListenerInvoker, AmazonLogin.MonoDroid")]
		void OnSuccess (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/shared/APIListener", DoNotGenerateAcw=true)]
	internal class IAPIListenerInvoker : global::Java.Lang.Object, IAPIListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/shared/APIListener");
		IntPtr class_ref;

		public static IAPIListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAPIListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.shared.APIListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAPIListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAPIListenerInvoker); }
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
			global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Identity.Auth.Device.AuthError p0;
		public global::Com.Amazon.Identity.Auth.Device.AuthError P0 {
			get { return p0; }
		}
	}

	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Android.OS.Bundle p0)
		{
			this.p0 = p0;
		}

		global::Android.OS.Bundle p0;
		public global::Android.OS.Bundle P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/identity/auth/device/shared/APIListenerImplementor")]
	internal sealed class IAPIListenerImplementor : global::Java.Lang.Object, IAPIListener {

		object sender;

		public IAPIListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/identity/auth/device/shared/APIListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Android.OS.Bundle p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IAPIListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
