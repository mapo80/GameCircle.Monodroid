using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='GameCircleAlertUserInterface']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/GameCircleAlertUserInterface", DoNotGenerateAcw=true)]
	public partial class GameCircleAlertUserInterface : global::Android.App.Activity, global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/GameCircleAlertUserInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameCircleAlertUserInterface); }
		}

		protected GameCircleAlertUserInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='GameCircleAlertUserInterface']/constructor[@name='GameCircleAlertUserInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GameCircleAlertUserInterface () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GameCircleAlertUserInterface)) {
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

		static Delegate cb_closeAlert;
#pragma warning disable 0169
		static Delegate GetCloseAlertHandler ()
		{
			if (cb_closeAlert == null)
				cb_closeAlert = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseAlert);
			return cb_closeAlert;
		}

		static void n_CloseAlert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.GameCircleAlertUserInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.GameCircleAlertUserInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAlert ();
		}
#pragma warning restore 0169

		static IntPtr id_closeAlert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='GameCircleAlertUserInterface']/method[@name='closeAlert' and count(parameter)=0]"
		[Register ("closeAlert", "()V", "GetCloseAlertHandler")]
		public virtual void CloseAlert ()
		{
			if (id_closeAlert == IntPtr.Zero)
				id_closeAlert = JNIEnv.GetMethodID (class_ref, "closeAlert", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeAlert);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_closeAlert);
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.GameCircleAlertUserInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.GameCircleAlertUserInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='GameCircleAlertUserInterface']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
