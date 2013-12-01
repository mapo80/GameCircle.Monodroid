using System;
using System.Collections.Generic;
using Android.Runtime;

namespace sessionImpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Util.IJSONSerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_APPKEY_LENGTH']"
		[Register ("SESSION_ID_APPKEY_LENGTH")]
		protected const int SessionIdAppkeyLength = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_DATE_FORMAT']"
		[Register ("SESSION_ID_DATE_FORMAT")]
		protected const string SessionIdDateFormat = (string) "yyyyMMdd";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_DELIMITER']"
		[Register ("SESSION_ID_DELIMITER")]
		protected const char SessionIdDelimiter = (char) (char)45;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_PAD_CHAR']"
		[Register ("SESSION_ID_PAD_CHAR")]
		protected const char SessionIdPadChar = (char) (char)95;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_TIME_FORMAT']"
		[Register ("SESSION_ID_TIME_FORMAT")]
		protected const string SessionIdTimeFormat = (string) "HHmmssSSS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/field[@name='SESSION_ID_UNIQID_LENGTH']"
		[Register ("SESSION_ID_UNIQID_LENGTH")]
		protected const int SessionIdUniqidLength = (int) 8;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/constructor[@name='Session' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;)V", "")]
		protected Session (global::Com.Amazon.Insights.Core.IInsightsContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Session)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/constructor[@name='Session' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected Session (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (Session)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPaused);
			}
		}

		static Delegate cb_getSessionDuration;
#pragma warning disable 0169
		static Delegate GetGetSessionDurationHandler ()
		{
			if (cb_getSessionDuration == null)
				cb_getSessionDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionDuration);
			return cb_getSessionDuration;
		}

		static IntPtr n_GetSessionDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SessionDuration);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionDuration;
		public virtual global::Java.Lang.Number SessionDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='getSessionDuration' and count(parameter)=0]"
			[Register ("getSessionDuration", "()Ljava/lang/Number;", "GetGetSessionDurationHandler")]
			get {
				if (id_getSessionDuration == IntPtr.Zero)
					id_getSessionDuration = JNIEnv.GetMethodID (class_ref, "getSessionDuration", "()Ljava/lang/Number;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod  (Handle, id_getSessionDuration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSessionDuration), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSessionID;
#pragma warning disable 0169
		static Delegate GetGetSessionIDHandler ()
		{
			if (cb_getSessionID == null)
				cb_getSessionID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionID);
			return cb_getSessionID;
		}

		static IntPtr n_GetSessionID (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionID);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionID;
		public virtual string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				if (id_getSessionID == IntPtr.Zero)
					id_getSessionID = JNIEnv.GetMethodID (class_ref, "getSessionID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSessionID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTime;
		public virtual long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getStartTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getStartTime);
			}
		}

		static Delegate cb_getStopTime;
#pragma warning disable 0169
		static Delegate GetGetStopTimeHandler ()
		{
			if (cb_getStopTime == null)
				cb_getStopTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStopTime);
			return cb_getStopTime;
		}

		static IntPtr n_GetStopTime (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StopTime);
		}
#pragma warning restore 0169

		static IntPtr id_getStopTime;
		public virtual global::Java.Lang.Long StopTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='getStopTime' and count(parameter)=0]"
			[Register ("getStopTime", "()Ljava/lang/Long;", "GetGetStopTimeHandler")]
			get {
				if (id_getStopTime == IntPtr.Zero)
					id_getStopTime = JNIEnv.GetMethodID (class_ref, "getStopTime", "()Ljava/lang/Long;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getStopTime), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStopTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_generateSessionID_Lcom_amazon_insights_core_InsightsContext_;
#pragma warning disable 0169
		static Delegate GetGenerateSessionID_Lcom_amazon_insights_core_InsightsContext_Handler ()
		{
			if (cb_generateSessionID_Lcom_amazon_insights_core_InsightsContext_ == null)
				cb_generateSessionID_Lcom_amazon_insights_core_InsightsContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateSessionID_Lcom_amazon_insights_core_InsightsContext_);
			return cb_generateSessionID_Lcom_amazon_insights_core_InsightsContext_;
		}

		static IntPtr n_GenerateSessionID_Lcom_amazon_insights_core_InsightsContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.IInsightsContext p0 = (global::Com.Amazon.Insights.Core.IInsightsContext)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSessionID (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateSessionID_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='generateSessionID' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("generateSessionID", "(Lcom/amazon/insights/core/InsightsContext;)Ljava/lang/String;", "GetGenerateSessionID_Lcom_amazon_insights_core_InsightsContext_Handler")]
		public virtual string GenerateSessionID (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_generateSessionID_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_generateSessionID_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "generateSessionID", "(Lcom/amazon/insights/core/InsightsContext;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateSessionID_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_generateSessionID_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getSessionFromSerializedSession_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='getSessionFromSerializedSession' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSessionFromSerializedSession", "(Ljava/lang/String;)Lcom/amazon/insights/session/Session;", "")]
		public static global::sessionImpl.Session GetSessionFromSerializedSession (string p0)
		{
			if (id_getSessionFromSerializedSession_Ljava_lang_String_ == IntPtr.Zero)
				id_getSessionFromSerializedSession_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSessionFromSerializedSession", "(Ljava/lang/String;)Lcom/amazon/insights/session/Session;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::sessionImpl.Session __ret = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSessionFromSerializedSession_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/session/Session;", "")]
		public static global::sessionImpl.Session NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/session/Session;");
			global::sessionImpl.Session __ret = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_pause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_pause);
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resume);
		}

		static Delegate cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::sessionImpl.Session __this = global::Java.Lang.Object.GetObject<global::sessionImpl.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='Session']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
		}

	}
}
