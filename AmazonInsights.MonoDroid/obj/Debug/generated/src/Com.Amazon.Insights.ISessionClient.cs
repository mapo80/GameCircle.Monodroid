using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='SessionClient']"
	[Register ("com/amazon/insights/SessionClient", "", "Com.Amazon.Insights.ISessionClientInvoker")]
	public partial interface ISessionClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='SessionClient']/method[@name='pauseSession' and count(parameter)=0]"
		[Register ("pauseSession", "()V", "GetPauseSessionHandler:Com.Amazon.Insights.ISessionClientInvoker, AmazonInsights.MonoDroid")]
		void PauseSession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='SessionClient']/method[@name='resumeSession' and count(parameter)=0]"
		[Register ("resumeSession", "()V", "GetResumeSessionHandler:Com.Amazon.Insights.ISessionClientInvoker, AmazonInsights.MonoDroid")]
		void ResumeSession ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/SessionClient", DoNotGenerateAcw=true)]
	internal class ISessionClientInvoker : global::Java.Lang.Object, ISessionClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/SessionClient");
		IntPtr class_ref;

		public static ISessionClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessionClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.SessionClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISessionClientInvoker); }
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
			global::Com.Amazon.Insights.ISessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.ISessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Insights.ISessionClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.ISessionClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
