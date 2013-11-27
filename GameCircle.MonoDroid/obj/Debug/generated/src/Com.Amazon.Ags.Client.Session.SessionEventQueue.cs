using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEventQueue']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/session/SessionEventQueue", DoNotGenerateAcw=true)]
	public partial class SessionEventQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/session/SessionEventQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionEventQueue); }
		}

		protected SessionEventQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEventQueue']/constructor[@name='SessionEventQueue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SessionEventQueue () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionEventQueue)) {
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

		static Delegate cb_enqueue_Lcom_amazon_ags_client_session_SessionEvent_;
#pragma warning disable 0169
		static Delegate GetEnqueue_Lcom_amazon_ags_client_session_SessionEvent_Handler ()
		{
			if (cb_enqueue_Lcom_amazon_ags_client_session_SessionEvent_ == null)
				cb_enqueue_Lcom_amazon_ags_client_session_SessionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Enqueue_Lcom_amazon_ags_client_session_SessionEvent_);
			return cb_enqueue_Lcom_amazon_ags_client_session_SessionEvent_;
		}

		static void n_Enqueue_Lcom_amazon_ags_client_session_SessionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Session.SessionEventQueue __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEventQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Session.SessionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enqueue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enqueue_Lcom_amazon_ags_client_session_SessionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEventQueue']/method[@name='enqueue' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.session.SessionEvent']]"
		[Register ("enqueue", "(Lcom/amazon/ags/client/session/SessionEvent;)V", "GetEnqueue_Lcom_amazon_ags_client_session_SessionEvent_Handler")]
		public virtual void Enqueue (global::Com.Amazon.Ags.Client.Session.SessionEvent p0)
		{
			if (id_enqueue_Lcom_amazon_ags_client_session_SessionEvent_ == IntPtr.Zero)
				id_enqueue_Lcom_amazon_ags_client_session_SessionEvent_ = JNIEnv.GetMethodID (class_ref, "enqueue", "(Lcom/amazon/ags/client/session/SessionEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enqueue_Lcom_amazon_ags_client_session_SessionEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_enqueue_Lcom_amazon_ags_client_session_SessionEvent_, new JValue (p0));
		}

		static Delegate cb_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
		static Delegate GetSetSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_Handler ()
		{
			if (cb_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_ == null)
				cb_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_);
			return cb_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_;
		}

		static void n_SetSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Session.SessionEventQueue __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEventQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Session.SessionClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService p1 = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSessionClient (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEventQueue']/method[@name='setSessionClient' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.session.SessionClient'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
		[Register ("setSessionClient", "(Lcom/amazon/ags/client/session/SessionClient;Ljava/util/concurrent/ExecutorService;)V", "GetSetSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_Handler")]
		public virtual void SetSessionClient (global::Com.Amazon.Ags.Client.Session.SessionClient p0, global::Java.Util.Concurrent.IExecutorService p1)
		{
			if (id_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
				id_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "setSessionClient", "(Lcom/amazon/ags/client/session/SessionClient;Ljava/util/concurrent/ExecutorService;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSessionClient_Lcom_amazon_ags_client_session_SessionClient_Ljava_util_concurrent_ExecutorService_, new JValue (p0), new JValue (p1));
		}

	}
}
