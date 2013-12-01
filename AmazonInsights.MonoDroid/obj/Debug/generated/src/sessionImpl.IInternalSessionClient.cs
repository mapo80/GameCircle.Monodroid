using System;
using System.Collections.Generic;
using Android.Runtime;

namespace sessionImpl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='InternalSessionClient']"
	[Register ("com/amazon/insights/session/InternalSessionClient", "", "sessionImpl.IInternalSessionClientInvoker")]
	public partial interface IInternalSessionClient : global::Com.Amazon.Insights.ISessionClient {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='InternalSessionClient']/method[@name='startSession' and count(parameter)=0]"
		[Register ("startSession", "()V", "GetStartSessionHandler:sessionImpl.IInternalSessionClientInvoker, AmazonInsights.MonoDroid")]
		void StartSession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='InternalSessionClient']/method[@name='stopSession' and count(parameter)=0]"
		[Register ("stopSession", "()V", "GetStopSessionHandler:sessionImpl.IInternalSessionClientInvoker, AmazonInsights.MonoDroid")]
		void StopSession ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/session/InternalSessionClient", DoNotGenerateAcw=true)]
	internal class IInternalSessionClientInvoker : global::Java.Lang.Object, IInternalSessionClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/session/InternalSessionClient");
		IntPtr class_ref;

		public static IInternalSessionClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalSessionClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.session.InternalSessionClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalSessionClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInternalSessionClientInvoker); }
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
			global::sessionImpl.IInternalSessionClient __this = global::Java.Lang.Object.GetObject<global::sessionImpl.IInternalSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSession ();
		}
#pragma warning restore 0169

		IntPtr id_startSession;
		public void StartSession ()
		{
			if (id_startSession == IntPtr.Zero)
				id_startSession = JNIEnv.GetMethodID (class_ref, "startSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_startSession);
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
			global::sessionImpl.IInternalSessionClient __this = global::Java.Lang.Object.GetObject<global::sessionImpl.IInternalSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSession ();
		}
#pragma warning restore 0169

		IntPtr id_stopSession;
		public void StopSession ()
		{
			if (id_stopSession == IntPtr.Zero)
				id_stopSession = JNIEnv.GetMethodID (class_ref, "stopSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stopSession);
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
			global::sessionImpl.IInternalSessionClient __this = global::Java.Lang.Object.GetObject<global::sessionImpl.IInternalSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseSession ();
		}
#pragma warning restore 0169

		IntPtr id_pauseSession;
		public void PauseSession ()
		{
			if (id_pauseSession == IntPtr.Zero)
				id_pauseSession = JNIEnv.GetMethodID (class_ref, "pauseSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pauseSession);
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
			global::sessionImpl.IInternalSessionClient __this = global::Java.Lang.Object.GetObject<global::sessionImpl.IInternalSessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeSession ();
		}
#pragma warning restore 0169

		IntPtr id_resumeSession;
		public void ResumeSession ()
		{
			if (id_resumeSession == IntPtr.Zero)
				id_resumeSession = JNIEnv.GetMethodID (class_ref, "resumeSession", "()V");
			JNIEnv.CallVoidMethod (Handle, id_resumeSession);
		}

	}

}
