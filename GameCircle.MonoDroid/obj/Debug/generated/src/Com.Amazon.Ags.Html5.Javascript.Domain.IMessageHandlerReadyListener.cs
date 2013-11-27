using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='MessageHandlerReadyListener']"
	[Register ("com/amazon/ags/html5/javascript/domain/MessageHandlerReadyListener", "", "Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerInvoker")]
	public partial interface IMessageHandlerReadyListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/interface[@name='MessageHandlerReadyListener']/method[@name='messageHandlerReady' and count(parameter)=0]"
		[Register ("messageHandlerReady", "()V", "GetMessageHandlerReadyHandler:Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerInvoker, GameCircle.MonoDroid")]
		void MessageHandlerReady ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/domain/MessageHandlerReadyListener", DoNotGenerateAcw=true)]
	internal class IMessageHandlerReadyListenerInvoker : global::Java.Lang.Object, IMessageHandlerReadyListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/javascript/domain/MessageHandlerReadyListener");
		IntPtr class_ref;

		public static IMessageHandlerReadyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageHandlerReadyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.javascript.domain.MessageHandlerReadyListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageHandlerReadyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMessageHandlerReadyListenerInvoker); }
		}

		static Delegate cb_messageHandlerReady;
#pragma warning disable 0169
		static Delegate GetMessageHandlerReadyHandler ()
		{
			if (cb_messageHandlerReady == null)
				cb_messageHandlerReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MessageHandlerReady);
			return cb_messageHandlerReady;
		}

		static void n_MessageHandlerReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageHandlerReady ();
		}
#pragma warning restore 0169

		IntPtr id_messageHandlerReady;
		public void MessageHandlerReady ()
		{
			if (id_messageHandlerReady == IntPtr.Zero)
				id_messageHandlerReady = JNIEnv.GetMethodID (class_ref, "messageHandlerReady", "()V");
			JNIEnv.CallVoidMethod (Handle, id_messageHandlerReady);
		}

	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/javascript/domain/MessageHandlerReadyListenerImplementor")]
	internal sealed class IMessageHandlerReadyListenerImplementor : global::Java.Lang.Object, IMessageHandlerReadyListener {

		object sender;

		public IMessageHandlerReadyListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/javascript/domain/MessageHandlerReadyListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void MessageHandlerReady ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IMessageHandlerReadyListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
