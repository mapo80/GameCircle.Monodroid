using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/client/DefaultSessionClient", DoNotGenerateAcw=true)]
	public partial class DefaultSessionClient : global::Java.Lang.Object, global::sessionImpl.IInternalSessionClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='DEFAULT_RESTART_DELAY']"
		[Register ("DEFAULT_RESTART_DELAY")]
		protected const long DefaultRestartDelay = (long) 30000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='DEFAULT_RESUME_DELAY']"
		[Register ("DEFAULT_RESUME_DELAY")]
		protected const long DefaultResumeDelay = (long) 5000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='RESTART_DELAY_CONFIG_KEY']"
		[Register ("RESTART_DELAY_CONFIG_KEY")]
		protected const string RestartDelayConfigKey = (string) "sessionRestartDelay";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='RESUME_DELAY_CONFIG_KEY']"
		[Register ("RESUME_DELAY_CONFIG_KEY")]
		protected const string ResumeDelayConfigKey = (string) "sessionResumeDelay";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_DURATION_METRIC_KEY']"
		[Register ("SESSION_DURATION_METRIC_KEY")]
		public const string SessionDurationMetricKey = (string) "_session.duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_ID_ATTRIBUTE_KEY']"
		[Register ("SESSION_ID_ATTRIBUTE_KEY")]
		public const string SessionIdAttributeKey = (string) "_session.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_PAUSE_EVENT_TYPE']"
		[Register ("SESSION_PAUSE_EVENT_TYPE")]
		public const string SessionPauseEventType = (string) "_session.pause";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_RESUME_EVENT_TYPE']"
		[Register ("SESSION_RESUME_EVENT_TYPE")]
		public const string SessionResumeEventType = (string) "_session.resume";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_START_EVENT_TYPE']"
		[Register ("SESSION_START_EVENT_TYPE")]
		public const string SessionStartEventType = (string) "_session.start";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='SESSION_STOP_EVENT_TYPE']"
		[Register ("SESSION_STOP_EVENT_TYPE")]
		public const string SessionStopEventType = (string) "_session.stop";

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='context']"
		[Register ("context")]
		protected global::Com.Amazon.Insights.Core.IInsightsContext Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Lcom/amazon/insights/core/InsightsContext;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Lcom/amazon/insights/core/InsightsContext;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, context_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr eventClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='eventClient']"
		[Register ("eventClient")]
		protected global::Com.Amazon.Insights.Event.IInternalEventClient EventClient {
			get {
				if (eventClient_jfieldId == IntPtr.Zero)
					eventClient_jfieldId = JNIEnv.GetFieldID (class_ref, "eventClient", "Lcom/amazon/insights/event/InternalEventClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, eventClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (eventClient_jfieldId == IntPtr.Zero)
					eventClient_jfieldId = JNIEnv.GetFieldID (class_ref, "eventClient", "Lcom/amazon/insights/event/InternalEventClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, eventClient_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr logger_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='logger']"
		[Register ("logger")]
		protected static global::Com.Amazon.Insights.Core.Log.Logger Logger {
			get {
				if (logger_jfieldId == IntPtr.Zero)
					logger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logger", "Lcom/amazon/insights/core/log/Logger;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logger_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (logger_jfieldId == IntPtr.Zero)
					logger_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logger", "Lcom/amazon/insights/core/log/Logger;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, logger_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr sessionStore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='sessionStore']"
		[Register ("sessionStore")]
		protected global::sessionImpl.ISessionStore SessionStore {
			get {
				if (sessionStore_jfieldId == IntPtr.Zero)
					sessionStore_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionStore", "Lcom/amazon/insights/session/SessionStore;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sessionStore_jfieldId);
				return global::Java.Lang.Object.GetObject<global::sessionImpl.ISessionStore> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sessionStore_jfieldId == IntPtr.Zero)
					sessionStore_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionStore", "Lcom/amazon/insights/session/SessionStore;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, sessionStore_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/field[@name='state']"
		[Register ("state")]
		protected global::Com.Amazon.Insights.Session.Client.SessionClientState State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/amazon/insights/session/client/SessionClientState;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, state_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/amazon/insights/session/client/SessionClientState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, state_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']"
		[global::Android.Runtime.Register ("com/amazon/insights/session/client/DefaultSessionClient$SessionState", DoNotGenerateAcw=true)]
		protected internal sealed partial class SessionState : global::Java.Lang.Enum {


			static IntPtr ACTIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']/field[@name='ACTIVE']"
			[Register ("ACTIVE")]
			public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState Active {
				get {
					if (ACTIVE_jfieldId == IntPtr.Zero)
						ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ACTIVE_jfieldId == IntPtr.Zero)
						ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ACTIVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INACTIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']/field[@name='INACTIVE']"
			[Register ("INACTIVE")]
			public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState Inactive {
				get {
					if (INACTIVE_jfieldId == IntPtr.Zero)
						INACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INACTIVE", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INACTIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INACTIVE_jfieldId == IntPtr.Zero)
						INACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INACTIVE", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INACTIVE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PAUSED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/session/client/DefaultSessionClient$SessionState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SessionState); }
			}

			internal SessionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;", "")]
			public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient.SessionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;", "")]
			public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");
				return (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/client/DefaultSessionClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultSessionClient); }
		}

		protected DefaultSessionClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_Lcom_amazon_insights_session_SessionStore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/constructor[@name='DefaultSessionClient' and count(parameter)=3 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='com.amazon.insights.event.InternalEventClient'] and parameter[3][@type='com.amazon.insights.session.SessionStore']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;Lcom/amazon/insights/session/SessionStore;)V", "")]
		protected DefaultSessionClient (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Com.Amazon.Insights.Event.IInternalEventClient p1, global::sessionImpl.ISessionStore p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultSessionClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;Lcom/amazon/insights/session/SessionStore;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;Lcom/amazon/insights/session/SessionStore;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_Lcom_amazon_insights_session_SessionStore_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_Lcom_amazon_insights_session_SessionStore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;Lcom/amazon/insights/session/SessionStore;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_Lcom_amazon_insights_session_SessionStore_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_Lcom_amazon_insights_session_SessionStore_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getRestartDelay;
#pragma warning disable 0169
		static Delegate GetGetRestartDelayHandler ()
		{
			if (cb_getRestartDelay == null)
				cb_getRestartDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRestartDelay);
			return cb_getRestartDelay;
		}

		static long n_GetRestartDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RestartDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getRestartDelay;
		public virtual long RestartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='getRestartDelay' and count(parameter)=0]"
			[Register ("getRestartDelay", "()J", "GetGetRestartDelayHandler")]
			get {
				if (id_getRestartDelay == IntPtr.Zero)
					id_getRestartDelay = JNIEnv.GetMethodID (class_ref, "getRestartDelay", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRestartDelay);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getRestartDelay);
			}
		}

		static Delegate cb_getResumeDelay;
#pragma warning disable 0169
		static Delegate GetGetResumeDelayHandler ()
		{
			if (cb_getResumeDelay == null)
				cb_getResumeDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetResumeDelay);
			return cb_getResumeDelay;
		}

		static long n_GetResumeDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResumeDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getResumeDelay;
		public virtual long ResumeDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='getResumeDelay' and count(parameter)=0]"
			[Register ("getResumeDelay", "()J", "GetGetResumeDelayHandler")]
			get {
				if (id_getResumeDelay == IntPtr.Zero)
					id_getResumeDelay = JNIEnv.GetMethodID (class_ref, "getResumeDelay", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getResumeDelay);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getResumeDelay);
			}
		}

		static Delegate cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		static IntPtr id_getSession;
		protected virtual global::sessionImpl.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/amazon/insights/session/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/amazon/insights/session/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSession), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_;
#pragma warning disable 0169
		static Delegate GetChangeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_Handler ()
		{
			if (cb_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_ == null)
				cb_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_);
			return cb_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_;
		}

		static void n_ChangeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='changeState' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.client.DefaultSessionClient.SessionState']]"
		[Register ("changeState", "(Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;)V", "GetChangeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_Handler")]
		protected virtual void ChangeState (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState p0)
		{
			if (id_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_ == IntPtr.Zero)
				id_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_ = JNIEnv.GetMethodID (class_ref, "changeState", "(Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_changeState_Lcom_amazon_insights_session_client_DefaultSessionClient_SessionState_, new JValue (p0));
		}

		static Delegate cb_getSessionState;
#pragma warning disable 0169
		static Delegate GetGetSessionStateHandler ()
		{
			if (cb_getSessionState == null)
				cb_getSessionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionState);
			return cb_getSessionState;
		}

		static IntPtr n_GetSessionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSessionState ());
		}
#pragma warning restore 0169

		static IntPtr id_getSessionState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='getSessionState' and count(parameter)=0]"
		[Register ("getSessionState", "()Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;", "GetGetSessionStateHandler")]
		protected virtual global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState GetSessionState ()
		{
			if (id_getSessionState == IntPtr.Zero)
				id_getSessionState = JNIEnv.GetMethodID (class_ref, "getSessionState", "()Lcom/amazon/insights/session/client/DefaultSessionClient$SessionState;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (JNIEnv.CallObjectMethod  (Handle, id_getSessionState), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient.SessionState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSessionState), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='com.amazon.insights.event.InternalEventClient']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;)Lcom/amazon/insights/session/client/DefaultSessionClient;", "")]
		public static global::Com.Amazon.Insights.Session.Client.DefaultSessionClient NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Com.Amazon.Insights.Event.IInternalEventClient p1)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;)Lcom/amazon/insights/session/client/DefaultSessionClient;");
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pauseSession;
#pragma warning disable 0169
		static Delegate GetPauseSessionHandler ()
		{
			if (cb_pauseSession == null)
				cb_pauseSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseSession);
			return cb_pauseSession;
		}

		static void n_PauseSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseSession ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='pauseSession' and count(parameter)=0]"
		[Register ("pauseSession", "()V", "GetPauseSessionHandler")]
		public virtual void PauseSession ()
		{
			if (id_pauseSession == IntPtr.Zero)
				id_pauseSession = JNIEnv.GetMethodID (class_ref, "pauseSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_pauseSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_pauseSession);
		}

		static Delegate cb_resumeSession;
#pragma warning disable 0169
		static Delegate GetResumeSessionHandler ()
		{
			if (cb_resumeSession == null)
				cb_resumeSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeSession);
			return cb_resumeSession;
		}

		static void n_ResumeSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeSession ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='resumeSession' and count(parameter)=0]"
		[Register ("resumeSession", "()V", "GetResumeSessionHandler")]
		public virtual void ResumeSession ()
		{
			if (id_resumeSession == IntPtr.Zero)
				id_resumeSession = JNIEnv.GetMethodID (class_ref, "resumeSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resumeSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resumeSession);
		}

		static Delegate cb_startSession;
#pragma warning disable 0169
		static Delegate GetStartSessionHandler ()
		{
			if (cb_startSession == null)
				cb_startSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartSession);
			return cb_startSession;
		}

		static void n_StartSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSession ();
		}
#pragma warning restore 0169

		static IntPtr id_startSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='startSession' and count(parameter)=0]"
		[Register ("startSession", "()V", "GetStartSessionHandler")]
		public virtual void StartSession ()
		{
			if (id_startSession == IntPtr.Zero)
				id_startSession = JNIEnv.GetMethodID (class_ref, "startSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startSession);
		}

		static Delegate cb_stopSession;
#pragma warning disable 0169
		static Delegate GetStopSessionHandler ()
		{
			if (cb_stopSession == null)
				cb_stopSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopSession);
			return cb_stopSession;
		}

		static void n_StopSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.DefaultSessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSession ();
		}
#pragma warning restore 0169

		static IntPtr id_stopSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='DefaultSessionClient']/method[@name='stopSession' and count(parameter)=0]"
		[Register ("stopSession", "()V", "GetStopSessionHandler")]
		public virtual void StopSession ()
		{
			if (id_stopSession == IntPtr.Zero)
				id_stopSession = JNIEnv.GetMethodID (class_ref, "stopSession", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopSession);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_stopSession);
		}

	}
}
