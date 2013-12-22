using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Factory {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.factory']/interface[@name='AGSClientInstanceCoordinatorListener']"
	[Register ("com/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListener", "", "Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerInvoker")]
	public partial interface IAGSClientInstanceCoordinatorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/interface[@name='AGSClientInstanceCoordinatorListener']/method[@name='notifyCurrentActivityChanged' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyCurrentActivityChanged", "(Landroid/app/Activity;)V", "GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler:Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerInvoker, GameCircle.MonoDroid")]
		void NotifyCurrentActivityChanged (global::Android.App.Activity p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListener", DoNotGenerateAcw=true)]
	internal class IAGSClientInstanceCoordinatorListenerInvoker : global::Java.Lang.Object, IAGSClientInstanceCoordinatorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListener");
		IntPtr class_ref;

		public static IAGSClientInstanceCoordinatorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAGSClientInstanceCoordinatorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.factory.AGSClientInstanceCoordinatorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAGSClientInstanceCoordinatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAGSClientInstanceCoordinatorListenerInvoker); }
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
			global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCurrentActivityChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_notifyCurrentActivityChanged_Landroid_app_Activity_;
		public void NotifyCurrentActivityChanged (global::Android.App.Activity p0)
		{
			if (id_notifyCurrentActivityChanged_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "notifyCurrentActivityChanged", "(Landroid/app/Activity;)V");
			JNIEnv.CallVoidMethod (Handle, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
		}

	}

	public partial class AGSClientInstanceCoordinatorEventArgs : global::System.EventArgs {

		public AGSClientInstanceCoordinatorEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListenerImplementor")]
	internal sealed class IAGSClientInstanceCoordinatorListenerImplementor : global::Java.Lang.Object, IAGSClientInstanceCoordinatorListener {

		object sender;

		public IAGSClientInstanceCoordinatorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AGSClientInstanceCoordinatorEventArgs> Handler;
#pragma warning restore 0649

		public void NotifyCurrentActivityChanged (global::Android.App.Activity p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AGSClientInstanceCoordinatorEventArgs (p0));
		}

		internal static bool __IsEmpty (IAGSClientInstanceCoordinatorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
