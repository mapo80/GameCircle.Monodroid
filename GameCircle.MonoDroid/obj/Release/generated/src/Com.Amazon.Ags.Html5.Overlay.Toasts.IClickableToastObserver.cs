using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToastObserver']"
	[Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastObserver", "", "Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserverInvoker")]
	public partial interface IClickableToastObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToastObserver']/method[@name='notifyToastDestroyed' and count(parameter)=0]"
		[Register ("notifyToastDestroyed", "()V", "GetNotifyToastDestroyedHandler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserverInvoker, GameCircle.MonoDroid")]
		void NotifyToastDestroyed ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastObserver", DoNotGenerateAcw=true)]
	internal class IClickableToastObserverInvoker : global::Java.Lang.Object, IClickableToastObserver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToastObserver");
		IntPtr class_ref;

		public static IClickableToastObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClickableToastObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.overlay.toasts.ClickableToastObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClickableToastObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IClickableToastObserverInvoker); }
		}

		static Delegate cb_notifyToastDestroyed;
#pragma warning disable 0169
		static Delegate GetNotifyToastDestroyedHandler ()
		{
			if (cb_notifyToastDestroyed == null)
				cb_notifyToastDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyToastDestroyed);
			return cb_notifyToastDestroyed;
		}

		static void n_NotifyToastDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyToastDestroyed ();
		}
#pragma warning restore 0169

		IntPtr id_notifyToastDestroyed;
		public void NotifyToastDestroyed ()
		{
			if (id_notifyToastDestroyed == IntPtr.Zero)
				id_notifyToastDestroyed = JNIEnv.GetMethodID (class_ref, "notifyToastDestroyed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_notifyToastDestroyed);
		}

	}

}
