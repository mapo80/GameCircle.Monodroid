using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='CallbackErrorException']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/thread/CallbackErrorException", DoNotGenerateAcw=true)]
	public partial class CallbackErrorException : global::Java.Util.Concurrent.ExecutionException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/thread/CallbackErrorException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallbackErrorException); }
		}

		protected CallbackErrorException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='CallbackErrorException']/constructor[@name='CallbackErrorException' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public CallbackErrorException (global::Android.OS.Bundle p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CallbackErrorException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_getErrorBundle;
#pragma warning disable 0169
		static Delegate GetGetErrorBundleHandler ()
		{
			if (cb_getErrorBundle == null)
				cb_getErrorBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorBundle);
			return cb_getErrorBundle;
		}

		static IntPtr n_GetErrorBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.CallbackErrorException __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.CallbackErrorException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorBundle;
		public virtual global::Android.OS.Bundle ErrorBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='CallbackErrorException']/method[@name='getErrorBundle' and count(parameter)=0]"
			[Register ("getErrorBundle", "()Landroid/os/Bundle;", "GetGetErrorBundleHandler")]
			get {
				if (id_getErrorBundle == IntPtr.Zero)
					id_getErrorBundle = JNIEnv.GetMethodID (class_ref, "getErrorBundle", "()Landroid/os/Bundle;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getErrorBundle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getErrorBundle), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
