using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='EventObserver']"
	[Register ("com/amazon/insights/event/EventObserver", "", "Com.Amazon.Insights.Event.IEventObserverInvoker")]
	public partial interface IEventObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='EventObserver']/method[@name='notify' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("notify", "(Lcom/amazon/insights/event/InternalEvent;)V", "GetNotify_Lcom_amazon_insights_event_InternalEvent_Handler:Com.Amazon.Insights.Event.IEventObserverInvoker, AmazonInsights.MonoDroid")]
		void Notify (global::Com.Amazon.Insights.Event.IInternalEvent p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/event/EventObserver", DoNotGenerateAcw=true)]
	internal class IEventObserverInvoker : global::Java.Lang.Object, IEventObserver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/event/EventObserver");
		IntPtr class_ref;

		public static IEventObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.event.EventObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventObserverInvoker); }
		}

		static Delegate cb_notify_Lcom_amazon_insights_event_InternalEvent_;
#pragma warning disable 0169
		static Delegate GetNotify_Lcom_amazon_insights_event_InternalEvent_Handler ()
		{
			if (cb_notify_Lcom_amazon_insights_event_InternalEvent_ == null)
				cb_notify_Lcom_amazon_insights_event_InternalEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Notify_Lcom_amazon_insights_event_InternalEvent_);
			return cb_notify_Lcom_amazon_insights_event_InternalEvent_;
		}

		static void n_Notify_Lcom_amazon_insights_event_InternalEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.IEventObserver __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IEventObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notify (p0);
		}
#pragma warning restore 0169

		IntPtr id_notify_Lcom_amazon_insights_event_InternalEvent_;
		public void Notify (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_notify_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_notify_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "notify", "(Lcom/amazon/insights/event/InternalEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_notify_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
		}

	}

}
