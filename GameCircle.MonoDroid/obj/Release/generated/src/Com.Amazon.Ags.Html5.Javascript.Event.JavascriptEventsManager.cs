using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/class[@name='JavascriptEventsManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/event/JavascriptEventsManager", DoNotGenerateAcw=true)]
	public partial class JavascriptEventsManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/event/JavascriptEventsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavascriptEventsManager); }
		}

		protected JavascriptEventsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/class[@name='JavascriptEventsManager']/constructor[@name='JavascriptEventsManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public JavascriptEventsManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JavascriptEventsManager)) {
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

		static Delegate cb_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_Handler ()
		{
			if (cb_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_ == null)
				cb_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_);
			return cb_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_;
		}

		static void n_AddEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Event.JavascriptEventsManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Event.JavascriptEventsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener p1 = (global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddEventListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/class[@name='JavascriptEventsManager']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.html5.javascript.event.JavascriptEventListener']]"
		[Register ("addEventListener", "(Ljava/lang/String;Lcom/amazon/ags/html5/javascript/event/JavascriptEventListener;)V", "GetAddEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_Handler")]
		public virtual void AddEventListener (string p0, global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener p1)
		{
			if (id_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_ == IntPtr.Zero)
				id_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Ljava/lang/String;Lcom/amazon/ags/html5/javascript/event/JavascriptEventListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addEventListener_Ljava_lang_String_Lcom_amazon_ags_html5_javascript_event_JavascriptEventListener_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_notifyListeners_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyListeners_Ljava_lang_String_Handler ()
		{
			if (cb_notifyListeners_Ljava_lang_String_ == null)
				cb_notifyListeners_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyListeners_Ljava_lang_String_);
			return cb_notifyListeners_Ljava_lang_String_;
		}

		static void n_NotifyListeners_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Event.JavascriptEventsManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Event.JavascriptEventsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyListeners (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyListeners_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.event']/class[@name='JavascriptEventsManager']/method[@name='notifyListeners' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notifyListeners", "(Ljava/lang/String;)V", "GetNotifyListeners_Ljava_lang_String_Handler")]
		public virtual void NotifyListeners (string p0)
		{
			if (id_notifyListeners_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyListeners_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyListeners", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyListeners_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyListeners_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
