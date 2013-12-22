using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/client/ActiveSessionState", DoNotGenerateAcw=true)]
	public sealed partial class ActiveSessionState : global::Com.Amazon.Insights.Session.Client.SessionClientState {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/client/ActiveSessionState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActiveSessionState); }
		}

		internal ActiveSessionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']/constructor[@name='ActiveSessionState' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.client.DefaultSessionClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V", "")]
		public ActiveSessionState (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActiveSessionState)) {
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

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public override void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_pause);
		}

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "")]
		public override void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_resume);
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public override void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_start);
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='ActiveSessionState']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public override void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_stop);
		}

	}
}
