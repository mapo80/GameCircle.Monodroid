using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/client/InactiveSessionState", DoNotGenerateAcw=true)]
	public partial class InactiveSessionState : global::Com.Amazon.Insights.Session.Client.SessionClientState {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/client/InactiveSessionState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InactiveSessionState); }
		}

		protected InactiveSessionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']/constructor[@name='InactiveSessionState' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.client.DefaultSessionClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V", "")]
		public InactiveSessionState (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InactiveSessionState)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_, new JValue (p0));
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
			global::Com.Amazon.Insights.Session.Client.InactiveSessionState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.InactiveSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override void Pause ()
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
			global::Com.Amazon.Insights.Session.Client.InactiveSessionState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.InactiveSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public override void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resume);
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.InactiveSessionState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.InactiveSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_start);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.InactiveSessionState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.InactiveSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='InactiveSessionState']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_stop);
		}

	}
}
