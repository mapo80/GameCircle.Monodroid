using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/interface[@name='JavascriptEventListener']"
	[Register ("com/amazon/ags/html5/javascript/event/JavascriptEventListener", "", "Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListenerInvoker")]
	public partial interface IJavascriptEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/interface[@name='JavascriptEventListener']/method[@name='onJavascriptEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onJavascriptEvent", "(Ljava/lang/String;)V", "GetOnJavascriptEvent_Ljava_lang_String_Handler:Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListenerInvoker, GameCircle.MonoDroid")]
		void OnJavascriptEvent (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/event/JavascriptEventListener", DoNotGenerateAcw=true)]
	internal class IJavascriptEventListenerInvoker : global::Java.Lang.Object, IJavascriptEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/javascript/event/JavascriptEventListener");
		IntPtr class_ref;

		public static IJavascriptEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJavascriptEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.javascript.event.JavascriptEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJavascriptEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJavascriptEventListenerInvoker); }
		}

		static Delegate cb_onJavascriptEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnJavascriptEvent_Ljava_lang_String_Handler ()
		{
			if (cb_onJavascriptEvent_Ljava_lang_String_ == null)
				cb_onJavascriptEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnJavascriptEvent_Ljava_lang_String_);
			return cb_onJavascriptEvent_Ljava_lang_String_;
		}

		static void n_OnJavascriptEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnJavascriptEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onJavascriptEvent_Ljava_lang_String_;
		public void OnJavascriptEvent (string p0)
		{
			if (id_onJavascriptEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onJavascriptEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onJavascriptEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onJavascriptEvent_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class JavascriptEventEventArgs : global::System.EventArgs {

		public JavascriptEventEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/javascript/event/JavascriptEventListenerImplementor")]
	internal sealed class IJavascriptEventListenerImplementor : global::Java.Lang.Object, IJavascriptEventListener {

		object sender;

		public IJavascriptEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/javascript/event/JavascriptEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<JavascriptEventEventArgs> Handler;
#pragma warning restore 0649

		public void OnJavascriptEvent (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new JavascriptEventEventArgs (p0));
		}

		internal static bool __IsEmpty (IJavascriptEventListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
