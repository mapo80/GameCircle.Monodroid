using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Session {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='SessionStore']"
	[Register ("com/amazon/insights/session/SessionStore", "", "Com.Amazon.Insights.Session.ISessionStoreInvoker")]
	public partial interface ISessionStore : IJavaObject {

		global::Com.Amazon.Insights.Session.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='SessionStore']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/amazon/insights/session/Session;", "GetGetSessionHandler:Com.Amazon.Insights.Session.ISessionStoreInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.session']/interface[@name='SessionStore']/method[@name='storeSession' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.session.Session']]"
		[Register ("storeSession", "(Lcom/amazon/insights/session/Session;)V", "GetStoreSession_Lcom_amazon_insights_session_Session_Handler:Com.Amazon.Insights.Session.ISessionStoreInvoker, AmazonInsights.MonoDroid")]
		void StoreSession (global::Com.Amazon.Insights.Session.Session p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/session/SessionStore", DoNotGenerateAcw=true)]
	internal class ISessionStoreInvoker : global::Java.Lang.Object, ISessionStore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/session/SessionStore");
		IntPtr class_ref;

		public static ISessionStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessionStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.session.SessionStore"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISessionStoreInvoker); }
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
			global::Com.Amazon.Insights.Session.ISessionStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.ISessionStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		IntPtr id_getSession;
		public global::Com.Amazon.Insights.Session.Session Session {
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/amazon/insights/session/Session;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Session> (JNIEnv.CallObjectMethod (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Session.ISessionStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.ISessionStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Session.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Session.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StoreSession (p0);
		}
#pragma warning restore 0169

		IntPtr id_storeSession_Lcom_amazon_insights_session_Session_;
		public void StoreSession (global::Com.Amazon.Insights.Session.Session p0)
		{
			if (id_storeSession_Lcom_amazon_insights_session_Session_ == IntPtr.Zero)
				id_storeSession_Lcom_amazon_insights_session_Session_ = JNIEnv.GetMethodID (class_ref, "storeSession", "(Lcom/amazon/insights/session/Session;)V");
			JNIEnv.CallVoidMethod (Handle, id_storeSession_Lcom_amazon_insights_session_Session_, new JValue (p0));
		}

	}

}
