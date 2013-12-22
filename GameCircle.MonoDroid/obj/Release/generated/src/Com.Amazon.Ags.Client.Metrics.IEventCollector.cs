using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Metrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']"
	[Register ("com/amazon/ags/client/metrics/EventCollector", "", "Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker")]
	public partial interface IEventCollector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='pauseInsightsSession' and count(parameter)=0]"
		[Register ("pauseInsightsSession", "()V", "GetPauseInsightsSessionHandler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void PauseInsightsSession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='reportGenericEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.events.GameCircleGenericEvent']]"
		[Register ("reportGenericEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)V", "GetReportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_Handler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void ReportGenericEvent (global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='resumeInsightsSession' and count(parameter)=0]"
		[Register ("resumeInsightsSession", "()V", "GetResumeInsightsSessionHandler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void ResumeInsightsSession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='setIsGuest' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsGuest", "(Z)V", "GetSetIsGuest_ZHandler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void SetIsGuest (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='setPlayerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlayerId", "(Ljava/lang/String;)V", "GetSetPlayerId_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void SetPlayerId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics']/interface[@name='EventCollector']/method[@name='submitEvents' and count(parameter)=0]"
		[Register ("submitEvents", "()V", "GetSubmitEventsHandler:Com.Amazon.Ags.Client.Metrics.IEventCollectorInvoker, GameCircle.MonoDroid")]
		void SubmitEvents ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/metrics/EventCollector", DoNotGenerateAcw=true)]
	internal class IEventCollectorInvoker : global::Java.Lang.Object, IEventCollector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/metrics/EventCollector");
		IntPtr class_ref;

		public static IEventCollector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventCollector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.metrics.EventCollector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventCollectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventCollectorInvoker); }
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseInsightsSession ();
		}
#pragma warning restore 0169

		IntPtr id_pauseInsightsSession;
		public void PauseInsightsSession ()
		{
			if (id_pauseInsightsSession == IntPtr.Zero)
				id_pauseInsightsSession = JNIEnv.GetMethodID (class_ref, "pauseInsightsSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pauseInsightsSession);
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportGenericEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_;
		public void ReportGenericEvent (global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent p0)
		{
			if (id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ == IntPtr.Zero)
				id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_ = JNIEnv.GetMethodID (class_ref, "reportGenericEvent", "(Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_reportGenericEvent_Lcom_amazon_ags_client_metrics_events_GameCircleGenericEvent_, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeInsightsSession ();
		}
#pragma warning restore 0169

		IntPtr id_resumeInsightsSession;
		public void ResumeInsightsSession ()
		{
			if (id_resumeInsightsSession == IntPtr.Zero)
				id_resumeInsightsSession = JNIEnv.GetMethodID (class_ref, "resumeInsightsSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_resumeInsightsSession);
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsGuest (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIsGuest_Z;
		public void SetIsGuest (bool p0)
		{
			if (id_setIsGuest_Z == IntPtr.Zero)
				id_setIsGuest_Z = JNIEnv.GetMethodID (class_ref, "setIsGuest", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setIsGuest_Z, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerId (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayerId_Ljava_lang_String_;
		public void SetPlayerId (string p0)
		{
			if (id_setPlayerId_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlayerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayerId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setPlayerId_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Client.Metrics.IEventCollector __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.IEventCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitEvents ();
		}
#pragma warning restore 0169

		IntPtr id_submitEvents;
		public void SubmitEvents ()
		{
			if (id_submitEvents == IntPtr.Zero)
				id_submitEvents = JNIEnv.GetMethodID (class_ref, "submitEvents", "()V");
			JNIEnv.CallVoidMethod (Handle, id_submitEvents);
		}

	}

}
