using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.event']/class[@name='WhispersyncJavascriptEventListener']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/event/WhispersyncJavascriptEventListener", DoNotGenerateAcw=true)]
	public partial class WhispersyncJavascriptEventListener : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Javascript.Event.IJavascriptEventListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/event/WhispersyncJavascriptEventListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncJavascriptEventListener); }
		}

		protected WhispersyncJavascriptEventListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_SynchronizationManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.event']/class[@name='WhispersyncJavascriptEventListener']/constructor[@name='WhispersyncJavascriptEventListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.SynchronizationManager']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/SynchronizationManager;)V", "")]
		public WhispersyncJavascriptEventListener (global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncJavascriptEventListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/SynchronizationManager;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/SynchronizationManager;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_SynchronizationManager_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_SynchronizationManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/SynchronizationManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_SynchronizationManager_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_SynchronizationManager_, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Whispersync.Event.WhispersyncJavascriptEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Event.WhispersyncJavascriptEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnJavascriptEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onJavascriptEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.event']/class[@name='WhispersyncJavascriptEventListener']/method[@name='onJavascriptEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onJavascriptEvent", "(Ljava/lang/String;)V", "GetOnJavascriptEvent_Ljava_lang_String_Handler")]
		public virtual void OnJavascriptEvent (string p0)
		{
			if (id_onJavascriptEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onJavascriptEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onJavascriptEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onJavascriptEvent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onJavascriptEvent_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
