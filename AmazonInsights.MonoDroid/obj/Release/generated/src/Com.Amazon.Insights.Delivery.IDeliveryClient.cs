using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='DeliveryClient']"
	[Register ("com/amazon/insights/delivery/DeliveryClient", "", "Com.Amazon.Insights.Delivery.IDeliveryClientInvoker")]
	public partial interface IDeliveryClient : global::Com.Amazon.Insights.Event.IEventObserver {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='DeliveryClient']/method[@name='attemptDelivery' and count(parameter)=0]"
		[Register ("attemptDelivery", "()V", "GetAttemptDeliveryHandler:Com.Amazon.Insights.Delivery.IDeliveryClientInvoker, AmazonInsights.MonoDroid")]
		void AttemptDelivery ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='DeliveryClient']/method[@name='batchedEvents' and count(parameter)=0]"
		[Register ("batchedEvents", "()[Ljava/lang/String;", "GetBatchedEventsHandler:Com.Amazon.Insights.Delivery.IDeliveryClientInvoker, AmazonInsights.MonoDroid")]
		string[] BatchedEvents ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='DeliveryClient']/method[@name='enqueueEventForDelivery' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("enqueueEventForDelivery", "(Lcom/amazon/insights/event/InternalEvent;)V", "GetEnqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_Handler:Com.Amazon.Insights.Delivery.IDeliveryClientInvoker, AmazonInsights.MonoDroid")]
		void EnqueueEventForDelivery (global::Com.Amazon.Insights.Event.IInternalEvent p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/delivery/DeliveryClient", DoNotGenerateAcw=true)]
	internal class IDeliveryClientInvoker : global::Java.Lang.Object, IDeliveryClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/delivery/DeliveryClient");
		IntPtr class_ref;

		public static IDeliveryClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeliveryClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.delivery.DeliveryClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeliveryClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeliveryClientInvoker); }
		}

		static Delegate cb_attemptDelivery;
#pragma warning disable 0169
		static Delegate GetAttemptDeliveryHandler ()
		{
			if (cb_attemptDelivery == null)
				cb_attemptDelivery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttemptDelivery);
			return cb_attemptDelivery;
		}

		static void n_AttemptDelivery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttemptDelivery ();
		}
#pragma warning restore 0169

		IntPtr id_attemptDelivery;
		public void AttemptDelivery ()
		{
			if (id_attemptDelivery == IntPtr.Zero)
				id_attemptDelivery = JNIEnv.GetMethodID (class_ref, "attemptDelivery", "()V");
			JNIEnv.CallVoidMethod (Handle, id_attemptDelivery);
		}

		static Delegate cb_batchedEvents;
#pragma warning disable 0169
		static Delegate GetBatchedEventsHandler ()
		{
			if (cb_batchedEvents == null)
				cb_batchedEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BatchedEvents);
			return cb_batchedEvents;
		}

		static IntPtr n_BatchedEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BatchedEvents ());
		}
#pragma warning restore 0169

		IntPtr id_batchedEvents;
		public string[] BatchedEvents ()
		{
			if (id_batchedEvents == IntPtr.Zero)
				id_batchedEvents = JNIEnv.GetMethodID (class_ref, "batchedEvents", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_batchedEvents), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_;
#pragma warning disable 0169
		static Delegate GetEnqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_Handler ()
		{
			if (cb_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ == null)
				cb_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_);
			return cb_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_;
		}

		static void n_EnqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Delivery.IDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnqueueEventForDelivery (p0);
		}
#pragma warning restore 0169

		IntPtr id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_;
		public void EnqueueEventForDelivery (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "enqueueEventForDelivery", "(Lcom/amazon/insights/event/InternalEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
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
			global::Com.Amazon.Insights.Delivery.IDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
