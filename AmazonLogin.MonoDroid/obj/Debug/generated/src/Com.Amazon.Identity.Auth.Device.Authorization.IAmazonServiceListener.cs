using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonServiceListener']"
	[Register ("com/amazon/identity/auth/device/authorization/AmazonServiceListener", "", "Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerInvoker")]
	public partial interface IAmazonServiceListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonServiceListener']/method[@name='onBindError' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("onBindError", "(Lcom/amazon/identity/auth/device/AuthError;)V", "GetOnBindError_Lcom_amazon_identity_auth_device_AuthError_Handler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerInvoker, AmazonLogin.MonoDroid")]
		void OnBindError (global::Com.Amazon.Identity.Auth.Device.AuthError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonServiceListener']/method[@name='onBindSuccess' and count(parameter)=1 and parameter[1][@type='android.os.IInterface']]"
		[Register ("onBindSuccess", "(Landroid/os/IInterface;)V", "GetOnBindSuccess_Landroid_os_IInterface_Handler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerInvoker, AmazonLogin.MonoDroid")]
		void OnBindSuccess (global::Android.OS.IInterface p0);

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AmazonServiceListener", DoNotGenerateAcw=true)]
	internal class IAmazonServiceListenerInvoker : global::Java.Lang.Object, IAmazonServiceListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AmazonServiceListener");
		IntPtr class_ref;

		public static IAmazonServiceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmazonServiceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.authorization.AmazonServiceListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmazonServiceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAmazonServiceListenerInvoker); }
		}

		static Delegate cb_onBindError_Lcom_amazon_identity_auth_device_AuthError_;
#pragma warning disable 0169
		static Delegate GetOnBindError_Lcom_amazon_identity_auth_device_AuthError_Handler ()
		{
			if (cb_onBindError_Lcom_amazon_identity_auth_device_AuthError_ == null)
				cb_onBindError_Lcom_amazon_identity_auth_device_AuthError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBindError_Lcom_amazon_identity_auth_device_AuthError_);
			return cb_onBindError_Lcom_amazon_identity_auth_device_AuthError_;
		}

		static void n_OnBindError_Lcom_amazon_identity_auth_device_AuthError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.AuthError p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBindError_Lcom_amazon_identity_auth_device_AuthError_;
		public void OnBindError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_onBindError_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_onBindError_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetMethodID (class_ref, "onBindError", "(Lcom/amazon/identity/auth/device/AuthError;)V");
			JNIEnv.CallVoidMethod (Handle, id_onBindError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
		}

		static Delegate cb_onBindSuccess_Landroid_os_IInterface_;
#pragma warning disable 0169
		static Delegate GetOnBindSuccess_Landroid_os_IInterface_Handler ()
		{
			if (cb_onBindSuccess_Landroid_os_IInterface_ == null)
				cb_onBindSuccess_Landroid_os_IInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBindSuccess_Landroid_os_IInterface_);
			return cb_onBindSuccess_Landroid_os_IInterface_;
		}

		static void n_OnBindSuccess_Landroid_os_IInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IInterface p0 = (global::Android.OS.IInterface)global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBindSuccess_Landroid_os_IInterface_;
		public void OnBindSuccess (global::Android.OS.IInterface p0)
		{
			if (id_onBindSuccess_Landroid_os_IInterface_ == IntPtr.Zero)
				id_onBindSuccess_Landroid_os_IInterface_ = JNIEnv.GetMethodID (class_ref, "onBindSuccess", "(Landroid/os/IInterface;)V");
			JNIEnv.CallVoidMethod (Handle, id_onBindSuccess_Landroid_os_IInterface_, new JValue (p0));
		}

	}

	public partial class BindErrorEventArgs : global::System.EventArgs {

		public BindErrorEventArgs (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Identity.Auth.Device.AuthError p0;
		public global::Com.Amazon.Identity.Auth.Device.AuthError P0 {
			get { return p0; }
		}
	}

	public partial class BindSuccessEventArgs : global::System.EventArgs {

		public BindSuccessEventArgs (global::Android.OS.IInterface p0)
		{
			this.p0 = p0;
		}

		global::Android.OS.IInterface p0;
		public global::Android.OS.IInterface P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/identity/auth/device/authorization/AmazonServiceListenerImplementor")]
	internal sealed class IAmazonServiceListenerImplementor : global::Java.Lang.Object, IAmazonServiceListener {

		object sender;

		public IAmazonServiceListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/identity/auth/device/authorization/AmazonServiceListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BindErrorEventArgs> OnBindErrorHandler;
#pragma warning restore 0649

		public void OnBindError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			var __h = OnBindErrorHandler;
			if (__h != null)
				__h (sender, new BindErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<BindSuccessEventArgs> OnBindSuccessHandler;
#pragma warning restore 0649

		public void OnBindSuccess (global::Android.OS.IInterface p0)
		{
			var __h = OnBindSuccessHandler;
			if (__h != null)
				__h (sender, new BindSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IAmazonServiceListenerImplementor value)
		{
			return value.OnBindErrorHandler == null && value.OnBindSuccessHandler == null;
		}
	}

}
