using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.settings']/class[@name='WebOverlayWhispersyncSettingsManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/settings/WebOverlayWhispersyncSettingsManager", DoNotGenerateAcw=true)]
	public partial class WebOverlayWhispersyncSettingsManager : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManager {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/settings/WebOverlayWhispersyncSettingsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebOverlayWhispersyncSettingsManager); }
		}

		protected WebOverlayWhispersyncSettingsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_session_SessionClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.settings']/class[@name='WebOverlayWhispersyncSettingsManager']/constructor[@name='WebOverlayWhispersyncSettingsManager' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.session.SessionClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/session/SessionClient;)V", "")]
		public WebOverlayWhispersyncSettingsManager (global::Com.Amazon.Ags.Client.Session.SessionClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WebOverlayWhispersyncSettingsManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/session/SessionClient;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/session/SessionClient;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_session_SessionClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_session_SessionClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/session/SessionClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_session_SessionClient_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_session_SessionClient_, new JValue (p0));
		}

		static Delegate cb_isWhispersyncEnabled;
#pragma warning disable 0169
		static Delegate GetIsWhispersyncEnabledHandler ()
		{
			if (cb_isWhispersyncEnabled == null)
				cb_isWhispersyncEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWhispersyncEnabled);
			return cb_isWhispersyncEnabled;
		}

		static bool n_IsWhispersyncEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Settings.WebOverlayWhispersyncSettingsManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Settings.WebOverlayWhispersyncSettingsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWhispersyncEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isWhispersyncEnabled;
		public virtual bool IsWhispersyncEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.settings']/class[@name='WebOverlayWhispersyncSettingsManager']/method[@name='isWhispersyncEnabled' and count(parameter)=0]"
			[Register ("isWhispersyncEnabled", "()Z", "GetIsWhispersyncEnabledHandler")]
			get {
				if (id_isWhispersyncEnabled == IntPtr.Zero)
					id_isWhispersyncEnabled = JNIEnv.GetMethodID (class_ref, "isWhispersyncEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isWhispersyncEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isWhispersyncEnabled);
			}
		}

	}
}
