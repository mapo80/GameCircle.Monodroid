using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']"
	[global::Android.Runtime.Register ("com/amazon/insights/session/client/SessionClientState", DoNotGenerateAcw=true)]
	public abstract partial class SessionClientState : global::Java.Lang.Object {


		static IntPtr client_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/field[@name='client']"
		[Register ("client")]
		protected global::Com.Amazon.Insights.Session.Client.DefaultSessionClient Client {
			get {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lcom/amazon/insights/session/client/DefaultSessionClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, client_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.DefaultSessionClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lcom/amazon/insights/session/client/DefaultSessionClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, client_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/session/client/SessionClientState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionClientState); }
		}

		protected SessionClientState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_session_client_DefaultSessionClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/constructor[@name='SessionClientState' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.client.DefaultSessionClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/session/client/DefaultSessionClient;)V", "")]
		public SessionClientState (global::Com.Amazon.Insights.Session.Client.DefaultSessionClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionClientState)) {
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

		static Delegate cb_executePause;
#pragma warning disable 0169
		static Delegate GetExecutePauseHandler ()
		{
			if (cb_executePause == null)
				cb_executePause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecutePause);
			return cb_executePause;
		}

		static void n_ExecutePause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecutePause ();
		}
#pragma warning restore 0169

		static IntPtr id_executePause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='executePause' and count(parameter)=0]"
		[Register ("executePause", "()V", "GetExecutePauseHandler")]
		protected virtual void ExecutePause ()
		{
			if (id_executePause == IntPtr.Zero)
				id_executePause = JNIEnv.GetMethodID (class_ref, "executePause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executePause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_executePause);
		}

		static Delegate cb_executeResume;
#pragma warning disable 0169
		static Delegate GetExecuteResumeHandler ()
		{
			if (cb_executeResume == null)
				cb_executeResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecuteResume);
			return cb_executeResume;
		}

		static void n_ExecuteResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteResume ();
		}
#pragma warning restore 0169

		static IntPtr id_executeResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='executeResume' and count(parameter)=0]"
		[Register ("executeResume", "()V", "GetExecuteResumeHandler")]
		protected virtual void ExecuteResume ()
		{
			if (id_executeResume == IntPtr.Zero)
				id_executeResume = JNIEnv.GetMethodID (class_ref, "executeResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executeResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_executeResume);
		}

		static Delegate cb_executeStart;
#pragma warning disable 0169
		static Delegate GetExecuteStartHandler ()
		{
			if (cb_executeStart == null)
				cb_executeStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecuteStart);
			return cb_executeStart;
		}

		static void n_ExecuteStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteStart ();
		}
#pragma warning restore 0169

		static IntPtr id_executeStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='executeStart' and count(parameter)=0]"
		[Register ("executeStart", "()V", "GetExecuteStartHandler")]
		protected virtual void ExecuteStart ()
		{
			if (id_executeStart == IntPtr.Zero)
				id_executeStart = JNIEnv.GetMethodID (class_ref, "executeStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executeStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_executeStart);
		}

		static Delegate cb_executeStop;
#pragma warning disable 0169
		static Delegate GetExecuteStopHandler ()
		{
			if (cb_executeStop == null)
				cb_executeStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecuteStop);
			return cb_executeStop;
		}

		static void n_ExecuteStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteStop ();
		}
#pragma warning restore 0169

		static IntPtr id_executeStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='executeStop' and count(parameter)=0]"
		[Register ("executeStop", "()V", "GetExecuteStopHandler")]
		protected virtual void ExecuteStop ()
		{
			if (id_executeStop == IntPtr.Zero)
				id_executeStop = JNIEnv.GetMethodID (class_ref, "executeStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_executeStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_executeStop);
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
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public abstract void Pause ();

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
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public abstract void Resume ();

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
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

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
			global::Com.Amazon.Insights.Session.Client.SessionClientState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Client.SessionClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public abstract void Stop ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/session/client/SessionClientState", DoNotGenerateAcw=true)]
	internal partial class SessionClientStateInvoker : SessionClientState {

		public SessionClientStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionClientStateInvoker); }
		}

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_pause);
		}

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public override void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_resume);
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_start);
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session.client']/class[@name='SessionClientState']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_stop);
		}

	}

}
