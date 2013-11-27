using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='CloseAlertListener']"
	[Register ("com/amazon/ags/html5/javascript/domain/CloseAlertListener", "", "Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerInvoker")]
	public partial interface ICloseAlertListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='CloseAlertListener']/method[@name='closeAlert' and count(parameter)=0]"
		[Register ("closeAlert", "()V", "GetCloseAlertHandler:Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerInvoker, GameCircle.MonoDroid")]
		void CloseAlert ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/domain/CloseAlertListener", DoNotGenerateAcw=true)]
	internal class ICloseAlertListenerInvoker : global::Java.Lang.Object, ICloseAlertListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/javascript/domain/CloseAlertListener");
		IntPtr class_ref;

		public static ICloseAlertListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloseAlertListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.javascript.domain.CloseAlertListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloseAlertListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICloseAlertListenerInvoker); }
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
			global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAlert ();
		}
#pragma warning restore 0169

		IntPtr id_closeAlert;
		public void CloseAlert ()
		{
			if (id_closeAlert == IntPtr.Zero)
				id_closeAlert = JNIEnv.GetMethodID (class_ref, "closeAlert", "()V");
			JNIEnv.CallVoidMethod (Handle, id_closeAlert);
		}

	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/javascript/domain/CloseAlertListenerImplementor")]
	internal sealed class ICloseAlertListenerImplementor : global::Java.Lang.Object, ICloseAlertListener {

		object sender;

		public ICloseAlertListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/javascript/domain/CloseAlertListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void CloseAlert ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICloseAlertListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
