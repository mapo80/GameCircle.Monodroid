using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='CloseOverlayListener']"
	[Register ("com/amazon/ags/html5/javascript/domain/CloseOverlayListener", "", "Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerInvoker")]
	public partial interface ICloseOverlayListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='CloseOverlayListener']/method[@name='closeOverlay' and count(parameter)=0]"
		[Register ("closeOverlay", "()V", "GetCloseOverlayHandler:Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerInvoker, GameCircle.MonoDroid")]
		void CloseOverlay ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/domain/CloseOverlayListener", DoNotGenerateAcw=true)]
	internal class ICloseOverlayListenerInvoker : global::Java.Lang.Object, ICloseOverlayListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/javascript/domain/CloseOverlayListener");
		IntPtr class_ref;

		public static ICloseOverlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloseOverlayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.javascript.domain.CloseOverlayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloseOverlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICloseOverlayListenerInvoker); }
		}

		static Delegate cb_closeOverlay;
#pragma warning disable 0169
		static Delegate GetCloseOverlayHandler ()
		{
			if (cb_closeOverlay == null)
				cb_closeOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseOverlay);
			return cb_closeOverlay;
		}

		static void n_CloseOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseOverlay ();
		}
#pragma warning restore 0169

		IntPtr id_closeOverlay;
		public void CloseOverlay ()
		{
			if (id_closeOverlay == IntPtr.Zero)
				id_closeOverlay = JNIEnv.GetMethodID (class_ref, "closeOverlay", "()V");
			JNIEnv.CallVoidMethod (Handle, id_closeOverlay);
		}

	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/javascript/domain/CloseOverlayListenerImplementor")]
	internal sealed class ICloseOverlayListenerImplementor : global::Java.Lang.Object, ICloseOverlayListener {

		object sender;

		public ICloseOverlayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/javascript/domain/CloseOverlayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void CloseOverlay ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICloseOverlayListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
