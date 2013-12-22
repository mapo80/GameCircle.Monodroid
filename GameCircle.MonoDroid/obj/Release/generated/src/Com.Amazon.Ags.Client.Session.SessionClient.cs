using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/session/SessionClient", DoNotGenerateAcw=true)]
	public partial class SessionClient : global::Com.Amazon.Ags.Client.ClientBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/session/SessionClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionClient); }
		}

		protected SessionClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']/constructor[@name='SessionClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SessionClient () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']/constructor[@name='SessionClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "")]
		public SessionClient (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

		static Delegate cb_initializeSession;
#pragma warning disable 0169
		static Delegate GetInitializeSessionHandler ()
		{
			if (cb_initializeSession == null)
				cb_initializeSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InitializeSession);
			return cb_initializeSession;
		}

		static IntPtr n_InitializeSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.SessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitializeSession ());
		}
#pragma warning restore 0169

		static IntPtr id_initializeSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']/method[@name='initializeSession' and count(parameter)=0]"
		[Register ("initializeSession", "()Lcom/amazon/ags/api/AGResponseHandle;", "GetInitializeSessionHandler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle InitializeSession ()
		{
			if (id_initializeSession == IntPtr.Zero)
				id_initializeSession = JNIEnv.GetMethodID (class_ref, "initializeSession", "()Lcom/amazon/ags/api/AGResponseHandle;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_initializeSession), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_initializeSession), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isWhispersyncEnabled;
#pragma warning disable 0169
		static Delegate GetIsWhispersyncEnabledHandler ()
		{
			if (cb_isWhispersyncEnabled == null)
				cb_isWhispersyncEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsWhispersyncEnabled);
			return cb_isWhispersyncEnabled;
		}

		static IntPtr n_IsWhispersyncEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.SessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsWhispersyncEnabled ());
		}
#pragma warning restore 0169

		static IntPtr id_isWhispersyncEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']/method[@name='isWhispersyncEnabled' and count(parameter)=0]"
		[Register ("isWhispersyncEnabled", "()Lcom/amazon/ags/api/AGResponseHandle;", "GetIsWhispersyncEnabledHandler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle IsWhispersyncEnabled ()
		{
			if (id_isWhispersyncEnabled == IntPtr.Zero)
				id_isWhispersyncEnabled = JNIEnv.GetMethodID (class_ref, "isWhispersyncEnabled", "()Lcom/amazon/ags/api/AGResponseHandle;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_isWhispersyncEnabled), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_isWhispersyncEnabled), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_;
#pragma warning disable 0169
		static Delegate GetProcessSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_Handler ()
		{
			if (cb_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_ == null)
				cb_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_);
			return cb_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_;
		}

		static IntPtr n_ProcessSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Session.SessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Session.SessionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessSessionEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionClient']/method[@name='processSessionEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.session.SessionEvent']]"
		[Register ("processSessionEvent", "(Lcom/amazon/ags/client/session/SessionEvent;)Lcom/amazon/ags/api/AGResponseHandle;", "GetProcessSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ProcessSessionEvent (global::Com.Amazon.Ags.Client.Session.SessionEvent p0)
		{
			if (id_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_ == IntPtr.Zero)
				id_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_ = JNIEnv.GetMethodID (class_ref, "processSessionEvent", "(Lcom/amazon/ags/client/session/SessionEvent;)Lcom/amazon/ags/api/AGResponseHandle;");

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_processSessionEvent_Lcom_amazon_ags_client_session_SessionEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
