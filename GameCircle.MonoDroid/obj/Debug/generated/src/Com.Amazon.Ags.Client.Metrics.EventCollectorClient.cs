using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/metrics/EventCollectorClient", DoNotGenerateAcw=true)]
	public partial class EventCollectorClient : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/metrics/EventCollectorClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventCollectorClient); }
		}

		protected EventCollectorClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_metrics_EventCollector_Lcom_amazon_ags_html5_util_GlobalState_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_content_ContentVersion_Lcom_amazon_ags_html5_util_DeviceInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/constructor[@name='EventCollectorClient' and count(parameter)=5 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollector'] and parameter[2][@type='com.amazon.ags.html5.util.GlobalState'] and parameter[3][@type='com.amazon.ags.auth.AuthManager'] and parameter[4][@type='com.amazon.ags.html5.content.ContentVersion'] and parameter[5][@type='com.amazon.ags.html5.util.DeviceInfo']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/metrics/EventCollector;Lcom/amazon/ags/html5/util/GlobalState;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/content/ContentVersion;Lcom/amazon/ags/html5/util/DeviceInfo;)V", "")]
		public EventCollectorClient (global::Com.Amazon.Ags.Client.Metrics.IEventCollector p0, global::Com.Amazon.Ags.Html5.Util.GlobalState p1, global::Com.Amazon.Ags.Auth.AuthManager p2, global::Com.Amazon.Ags.Html5.Content.ContentVersion p3, global::Com.Amazon.Ags.Html5.Util.DeviceInfo p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (EventCollectorClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/metrics/EventCollector;Lcom/amazon/ags/html5/util/GlobalState;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/content/ContentVersion;Lcom/amazon/ags/html5/util/DeviceInfo;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/metrics/EventCollector;Lcom/amazon/ags/html5/util/GlobalState;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/content/ContentVersion;Lcom/amazon/ags/html5/util/DeviceInfo;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_metrics_EventCollector_Lcom_amazon_ags_html5_util_GlobalState_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_content_ContentVersion_Lcom_amazon_ags_html5_util_DeviceInfo_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_metrics_EventCollector_Lcom_amazon_ags_html5_util_GlobalState_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_content_ContentVersion_Lcom_amazon_ags_html5_util_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/metrics/EventCollector;Lcom/amazon/ags/html5/util/GlobalState;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/content/ContentVersion;Lcom/amazon/ags/html5/util/DeviceInfo;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollector_Lcom_amazon_ags_html5_util_GlobalState_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_content_ContentVersion_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollector_Lcom_amazon_ags_html5_util_GlobalState_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_content_ContentVersion_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_getInstance;
		public static global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/amazon/ags/client/metrics/EventCollectorClient;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/amazon/ags/client/metrics/EventCollectorClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isReportingEnabled;
#pragma warning disable 0169
		static Delegate GetIsReportingEnabledHandler ()
		{
			if (cb_isReportingEnabled == null)
				cb_isReportingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReportingEnabled);
			return cb_isReportingEnabled;
		}

		static bool n_IsReportingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReportingEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isReportingEnabled;
		public virtual bool IsReportingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='isReportingEnabled' and count(parameter)=0]"
			[Register ("isReportingEnabled", "()Z", "GetIsReportingEnabledHandler")]
			get {
				if (id_isReportingEnabled == IntPtr.Zero)
					id_isReportingEnabled = JNIEnv.GetMethodID (class_ref, "isReportingEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReportingEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isReportingEnabled);
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)Lcom/amazon/ags/client/metrics/EventCollectorClient;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)Lcom/amazon/ags/client/metrics/EventCollectorClient;");
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initialize_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_notifyIsGuestModeSet_Z;
#pragma warning disable 0169
		static Delegate GetNotifyIsGuestModeSet_ZHandler ()
		{
			if (cb_notifyIsGuestModeSet_Z == null)
				cb_notifyIsGuestModeSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_NotifyIsGuestModeSet_Z);
			return cb_notifyIsGuestModeSet_Z;
		}

		static void n_NotifyIsGuestModeSet_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyIsGuestModeSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyIsGuestModeSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='notifyIsGuestModeSet' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("notifyIsGuestModeSet", "(Z)V", "GetNotifyIsGuestModeSet_ZHandler")]
		public virtual void NotifyIsGuestModeSet (bool p0)
		{
			if (id_notifyIsGuestModeSet_Z == IntPtr.Zero)
				id_notifyIsGuestModeSet_Z = JNIEnv.GetMethodID (class_ref, "notifyIsGuestModeSet", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyIsGuestModeSet_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyIsGuestModeSet_Z, new JValue (p0));
		}

		static Delegate cb_notifyPlayerIdSet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyPlayerIdSet_Ljava_lang_String_Handler ()
		{
			if (cb_notifyPlayerIdSet_Ljava_lang_String_ == null)
				cb_notifyPlayerIdSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyPlayerIdSet_Ljava_lang_String_);
			return cb_notifyPlayerIdSet_Ljava_lang_String_;
		}

		static void n_NotifyPlayerIdSet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyPlayerIdSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyPlayerIdSet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='notifyPlayerIdSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notifyPlayerIdSet", "(Ljava/lang/String;)V", "GetNotifyPlayerIdSet_Ljava_lang_String_Handler")]
		public virtual void NotifyPlayerIdSet (string p0)
		{
			if (id_notifyPlayerIdSet_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyPlayerIdSet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyPlayerIdSet", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyPlayerIdSet_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyPlayerIdSet_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyStateSet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyStateSet_Ljava_lang_String_Ljava_lang_String_);
			return cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_NotifyStateSet_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyStateSet (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='notifyStateSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyStateSet", "(Ljava/lang/String;Ljava/lang/String;)V", "GetNotifyStateSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void NotifyStateSet (string p0, string p1)
		{
			if (id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyStateSet", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_pauseInsightsSession;
#pragma warning disable 0169
		static Delegate GetPauseInsightsSessionHandler ()
		{
			if (cb_pauseInsightsSession == null)
				cb_pauseInsightsSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseInsightsSession);
			return cb_pauseInsightsSession;
		}

		static void n_PauseInsightsSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseInsightsSession ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseInsightsSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='pauseInsightsSession' and count(parameter)=0]"
		[Register ("pauseInsightsSession", "()V", "GetPauseInsightsSessionHandler")]
		public virtual void PauseInsightsSession ()
		{
			if (id_pauseInsightsSession == IntPtr.Zero)
				id_pauseInsightsSession = JNIEnv.GetMethodID (class_ref, "pauseInsightsSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_pauseInsightsSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_pauseInsightsSession);
		}

		static Delegate cb_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
#pragma warning disable 0169
		static Delegate GetReportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_Handler ()
		{
			if (cb_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ == null)
				cb_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_);
			return cb_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		}

		static void n_ReportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportGenericEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='reportGenericEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.events.GameCircleGenericEvent']]"
		[Register ("reportGenericEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)V", "GetReportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_Handler")]
		public virtual void ReportGenericEvent (global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0)
		{
			if (id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ == IntPtr.Zero)
				id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ = JNIEnv.GetMethodID (class_ref, "reportGenericEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_, new JValue (p0));
		}

		static Delegate cb_resumeInsightsSession;
#pragma warning disable 0169
		static Delegate GetResumeInsightsSessionHandler ()
		{
			if (cb_resumeInsightsSession == null)
				cb_resumeInsightsSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeInsightsSession);
			return cb_resumeInsightsSession;
		}

		static void n_ResumeInsightsSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeInsightsSession ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeInsightsSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='resumeInsightsSession' and count(parameter)=0]"
		[Register ("resumeInsightsSession", "()V", "GetResumeInsightsSessionHandler")]
		public virtual void ResumeInsightsSession ()
		{
			if (id_resumeInsightsSession == IntPtr.Zero)
				id_resumeInsightsSession = JNIEnv.GetMethodID (class_ref, "resumeInsightsSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resumeInsightsSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resumeInsightsSession);
		}

		static Delegate cb_setAuthManager_Lcom_amazon_ags_auth_AuthManager_;
#pragma warning disable 0169
		static Delegate GetSetAuthManager_Lcom_amazon_ags_auth_AuthManager_Handler ()
		{
			if (cb_setAuthManager_Lcom_amazon_ags_auth_AuthManager_ == null)
				cb_setAuthManager_Lcom_amazon_ags_auth_AuthManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthManager_Lcom_amazon_ags_auth_AuthManager_);
			return cb_setAuthManager_Lcom_amazon_ags_auth_AuthManager_;
		}

		static void n_SetAuthManager_Lcom_amazon_ags_auth_AuthManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Auth.AuthManager p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Auth.AuthManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAuthManager_Lcom_amazon_ags_auth_AuthManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='setAuthManager' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.auth.AuthManager']]"
		[Register ("setAuthManager", "(Lcom/amazon/ags/auth/AuthManager;)V", "GetSetAuthManager_Lcom_amazon_ags_auth_AuthManager_Handler")]
		public virtual void SetAuthManager (global::Com.Amazon.Ags.Auth.AuthManager p0)
		{
			if (id_setAuthManager_Lcom_amazon_ags_auth_AuthManager_ == IntPtr.Zero)
				id_setAuthManager_Lcom_amazon_ags_auth_AuthManager_ = JNIEnv.GetMethodID (class_ref, "setAuthManager", "(Lcom/amazon/ags/auth/AuthManager;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAuthManager_Lcom_amazon_ags_auth_AuthManager_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAuthManager_Lcom_amazon_ags_auth_AuthManager_, new JValue (p0));
		}

		static Delegate cb_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_;
#pragma warning disable 0169
		static Delegate GetSetContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_Handler ()
		{
			if (cb_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_ == null)
				cb_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_);
			return cb_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_;
		}

		static void n_SetContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Content.ContentVersion p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='setContentVersion' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.content.ContentVersion']]"
		[Register ("setContentVersion", "(Lcom/amazon/ags/html5/content/ContentVersion;)V", "GetSetContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_Handler")]
		public virtual void SetContentVersion (global::Com.Amazon.Ags.Html5.Content.ContentVersion p0)
		{
			if (id_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_ == IntPtr.Zero)
				id_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_ = JNIEnv.GetMethodID (class_ref, "setContentVersion", "(Lcom/amazon/ags/html5/content/ContentVersion;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setContentVersion_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0));
		}

		static Delegate cb_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_Handler ()
		{
			if (cb_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_ == null)
				cb_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_);
			return cb_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_;
		}

		static void n_SetDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Util.DeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.DeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.util.DeviceInfo']]"
		[Register ("setDeviceInfo", "(Lcom/amazon/ags/html5/util/DeviceInfo;)V", "GetSetDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_Handler")]
		public virtual void SetDeviceInfo (global::Com.Amazon.Ags.Html5.Util.DeviceInfo p0)
		{
			if (id_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_ == IntPtr.Zero)
				id_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "setDeviceInfo", "(Lcom/amazon/ags/html5/util/DeviceInfo;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDeviceInfo_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (p0));
		}

		static Delegate cb_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_;
#pragma warning disable 0169
		static Delegate GetSetGlobalState_Lcom_amazon_ags_html5_util_GlobalState_Handler ()
		{
			if (cb_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_ == null)
				cb_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGlobalState_Lcom_amazon_ags_html5_util_GlobalState_);
			return cb_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_;
		}

		static void n_SetGlobalState_Lcom_amazon_ags_html5_util_GlobalState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Util.GlobalState p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGlobalState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='setGlobalState' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.util.GlobalState']]"
		[Register ("setGlobalState", "(Lcom/amazon/ags/html5/util/GlobalState;)V", "GetSetGlobalState_Lcom_amazon_ags_html5_util_GlobalState_Handler")]
		public virtual void SetGlobalState (global::Com.Amazon.Ags.Html5.Util.GlobalState p0)
		{
			if (id_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_ == IntPtr.Zero)
				id_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_ = JNIEnv.GetMethodID (class_ref, "setGlobalState", "(Lcom/amazon/ags/html5/util/GlobalState;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setGlobalState_Lcom_amazon_ags_html5_util_GlobalState_, new JValue (p0));
		}

		static Delegate cb_submitEvents;
#pragma warning disable 0169
		static Delegate GetSubmitEventsHandler ()
		{
			if (cb_submitEvents == null)
				cb_submitEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SubmitEvents);
			return cb_submitEvents;
		}

		static void n_SubmitEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitEvents ();
		}
#pragma warning restore 0169

		static IntPtr id_submitEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='EventCollectorClient']/method[@name='submitEvents' and count(parameter)=0]"
		[Register ("submitEvents", "()V", "GetSubmitEventsHandler")]
		public virtual void SubmitEvents ()
		{
			if (id_submitEvents == IntPtr.Zero)
				id_submitEvents = JNIEnv.GetMethodID (class_ref, "submitEvents", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_submitEvents);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_submitEvents);
		}

	}
}
