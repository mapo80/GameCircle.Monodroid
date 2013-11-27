using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='FileSessionStore']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/FileSessionStore", DoNotGenerateAcw=true)]
	public partial class FileSessionStore : global::Java.Lang.Object, global::Com.Amazon.Insights.Session.ISessionStore {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/FileSessionStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileSessionStore); }
		}

		protected FileSessionStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='FileSessionStore']/constructor[@name='FileSessionStore' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;)V", "")]
		public FileSessionStore (global::Com.Amazon.Insights.Core.IInsightsContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileSessionStore)) {
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
			global::Com.Amazon.Insights.Session.FileSessionStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.FileSessionStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		static IntPtr id_getSession;
		public virtual global::Com.Amazon.Insights.Session.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='FileSessionStore']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/amazon/insights/session/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/amazon/insights/session/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSession), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_storeSession_Lcom_amazon_insights_session_Session_;
#pragma warning disable 0169
		static Delegate GetStoreSession_Lcom_amazon_insights_session_Session_Handler ()
		{
			if (cb_storeSession_Lcom_amazon_insights_session_Session_ == null)
				cb_storeSession_Lcom_amazon_insights_session_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StoreSession_Lcom_amazon_insights_session_Session_);
			return cb_storeSession_Lcom_amazon_insights_session_Session_;
		}

		static void n_StoreSession_Lcom_amazon_insights_session_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Session.FileSessionStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.FileSessionStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Session.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StoreSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_storeSession_Lcom_amazon_insights_session_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/class[@name='FileSessionStore']/method[@name='storeSession' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.Session']]"
		[Register ("storeSession", "(Lcom/amazon/insights/session/Session;)V", "GetStoreSession_Lcom_amazon_insights_session_Session_Handler")]
		public virtual void StoreSession (global::Com.Amazon.Insights.Session.Session p0)
		{
			if (id_storeSession_Lcom_amazon_insights_session_Session_ == IntPtr.Zero)
				id_storeSession_Lcom_amazon_insights_session_Session_ = JNIEnv.GetMethodID (class_ref, "storeSession", "(Lcom/amazon/insights/session/Session;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_storeSession_Lcom_amazon_insights_session_Session_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_storeSession_Lcom_amazon_insights_session_Session_, new JValue (p0));
		}

	}
}
