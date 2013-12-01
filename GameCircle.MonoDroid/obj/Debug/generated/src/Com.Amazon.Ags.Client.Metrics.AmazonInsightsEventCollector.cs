using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/metrics/AmazonInsightsEventCollector", DoNotGenerateAcw=true)]
	public partial class AmazonInsightsEventCollector : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Metrics.IEventCollector {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/metrics/AmazonInsightsEventCollector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonInsightsEventCollector); }
		}

		protected AmazonInsightsEventCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/constructor[@name='AmazonInsightsEventCollector' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public AmazonInsightsEventCollector (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AmazonInsightsEventCollector)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
#pragma warning disable 0169
		static Delegate GetConvertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_Handler ()
		{
			if (cb_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ == null)
				cb_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConvertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_);
			return cb_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		}

		static IntPtr n_ConvertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToInsightsEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='convertToInsightsEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.events.GameCircleGenericEvent']]"
		[Register ("convertToInsightsEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)Lcom/amazon/insights/Event;", "GetConvertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_Handler")]
		protected virtual global::Com.Amazon.Insights.IEvent ConvertToInsightsEvent (global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0)
		{
			if (id_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ == IntPtr.Zero)
				id_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ = JNIEnv.GetMethodID (class_ref, "convertToInsightsEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)Lcom/amazon/insights/Event;");

			global::Com.Amazon.Insights.IEvent __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod  (Handle, id_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_convertToInsightsEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initialize_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_ == null)
				cb_initialize_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_content_Context_);
			return cb_initialize_Landroid_content_Context_;
		}

		static IntPtr n_Initialize_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Initialize (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)Lcom/amazon/insights/EventClient;", "GetInitialize_Landroid_content_Context_Handler")]
		protected virtual global::Com.Amazon.Insights.IEventClient Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/content/Context;)Lcom/amazon/insights/EventClient;");

			global::Com.Amazon.Insights.IEventClient __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEventClient> (JNIEnv.CallObjectMethod  (Handle, id_initialize_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEventClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_initialize_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseInsightsSession ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseInsightsSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='pauseInsightsSession' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportGenericEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='reportGenericEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.events.GameCircleGenericEvent']]"
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
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeInsightsSession ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeInsightsSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='resumeInsightsSession' and count(parameter)=0]"
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

		static Delegate cb_setIsGuest_Z;
#pragma warning disable 0169
		static Delegate GetSetIsGuest_ZHandler ()
		{
			if (cb_setIsGuest_Z == null)
				cb_setIsGuest_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsGuest_Z);
			return cb_setIsGuest_Z;
		}

		static void n_SetIsGuest_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsGuest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsGuest_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='setIsGuest' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsGuest", "(Z)V", "GetSetIsGuest_ZHandler")]
		public virtual void SetIsGuest (bool p0)
		{
			if (id_setIsGuest_Z == IntPtr.Zero)
				id_setIsGuest_Z = JNIEnv.GetMethodID (class_ref, "setIsGuest", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIsGuest_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setIsGuest_Z, new JValue (p0));
		}

		static Delegate cb_setPlayerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlayerId_Ljava_lang_String_Handler ()
		{
			if (cb_setPlayerId_Ljava_lang_String_ == null)
				cb_setPlayerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayerId_Ljava_lang_String_);
			return cb_setPlayerId_Ljava_lang_String_;
		}

		static void n_SetPlayerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlayerId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='setPlayerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlayerId", "(Ljava/lang/String;)V", "GetSetPlayerId_Ljava_lang_String_Handler")]
		public virtual void SetPlayerId (string p0)
		{
			if (id_setPlayerId_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlayerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayerId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPlayerId_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPlayerId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.AmazonInsightsEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitEvents ();
		}
#pragma warning restore 0169

		static IntPtr id_submitEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/class[@name='AmazonInsightsEventCollector']/method[@name='submitEvents' and count(parameter)=0]"
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
