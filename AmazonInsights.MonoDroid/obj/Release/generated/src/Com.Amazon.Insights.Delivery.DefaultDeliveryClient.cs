using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']"
	[global::Android.Runtime.Register ("com/amazon/insights/delivery/DefaultDeliveryClient", DoNotGenerateAcw=true)]
	public partial class DefaultDeliveryClient : global::Java.Lang.Object, global::Com.Amazon.Insights.Delivery.IDeliveryClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/field[@name='EVENTS_DIRECTORY']"
		[Register ("EVENTS_DIRECTORY")]
		public const string EventsDirectory = (string) "events";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/delivery/DefaultDeliveryClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultDeliveryClient); }
		}

		protected DefaultDeliveryClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_delivery_policy_DeliveryPolicyFactory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_amazon_insights_delivery_ERSRequestBuilder_Lcom_amazon_insights_delivery_EventStore_Lcom_amazon_insights_event_adapter_EventAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/constructor[@name='DefaultDeliveryClient' and count(parameter)=7 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='com.amazon.insights.delivery.policy.DeliveryPolicyFactory'] and parameter[3][@type='java.util.concurrent.ExecutorService'] and parameter[4][@type='java.util.concurrent.ExecutorService'] and parameter[5][@type='com.amazon.insights.delivery.ERSRequestBuilder'] and parameter[6][@type='com.amazon.insights.delivery.EventStore'] and parameter[7][@type='com.amazon.insights.event.adapter.EventAdapter']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/delivery/policy/DeliveryPolicyFactory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/amazon/insights/delivery/ERSRequestBuilder;Lcom/amazon/insights/delivery/EventStore;Lcom/amazon/insights/event/adapter/EventAdapter;)V", "")]
		public DefaultDeliveryClient (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory p1, global::Java.Util.Concurrent.IExecutorService p2, global::Java.Util.Concurrent.IExecutorService p3, global::Com.Amazon.Insights.Delivery.ERSRequestBuilder p4, global::Com.Amazon.Insights.Delivery.IEventStore p5, global::Com.Amazon.Insights.Event.Adapter.IEventAdapter p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultDeliveryClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/delivery/policy/DeliveryPolicyFactory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/amazon/insights/delivery/ERSRequestBuilder;Lcom/amazon/insights/delivery/EventStore;Lcom/amazon/insights/event/adapter/EventAdapter;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/delivery/policy/DeliveryPolicyFactory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/amazon/insights/delivery/ERSRequestBuilder;Lcom/amazon/insights/delivery/EventStore;Lcom/amazon/insights/event/adapter/EventAdapter;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_delivery_policy_DeliveryPolicyFactory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_amazon_insights_delivery_ERSRequestBuilder_Lcom_amazon_insights_delivery_EventStore_Lcom_amazon_insights_event_adapter_EventAdapter_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_delivery_policy_DeliveryPolicyFactory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_amazon_insights_delivery_ERSRequestBuilder_Lcom_amazon_insights_delivery_EventStore_Lcom_amazon_insights_event_adapter_EventAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/delivery/policy/DeliveryPolicyFactory;Ljava/util/concurrent/ExecutorService;Ljava/util/concurrent/ExecutorService;Lcom/amazon/insights/delivery/ERSRequestBuilder;Lcom/amazon/insights/delivery/EventStore;Lcom/amazon/insights/event/adapter/EventAdapter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_delivery_policy_DeliveryPolicyFactory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_amazon_insights_delivery_ERSRequestBuilder_Lcom_amazon_insights_delivery_EventStore_Lcom_amazon_insights_event_adapter_EventAdapter_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_delivery_policy_DeliveryPolicyFactory_Ljava_util_concurrent_ExecutorService_Ljava_util_concurrent_ExecutorService_Lcom_amazon_insights_delivery_ERSRequestBuilder_Lcom_amazon_insights_delivery_EventStore_Lcom_amazon_insights_event_adapter_EventAdapter_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
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
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttemptDelivery ();
		}
#pragma warning restore 0169

		static IntPtr id_attemptDelivery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='attemptDelivery' and count(parameter)=0]"
		[Register ("attemptDelivery", "()V", "GetAttemptDeliveryHandler")]
		public virtual void AttemptDelivery ()
		{
			if (id_attemptDelivery == IntPtr.Zero)
				id_attemptDelivery = JNIEnv.GetMethodID (class_ref, "attemptDelivery", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_attemptDelivery);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_attemptDelivery);
		}

		static Delegate cb_attemptDelivery_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAttemptDelivery_Ljava_util_List_Handler ()
		{
			if (cb_attemptDelivery_Ljava_util_List_ == null)
				cb_attemptDelivery_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AttemptDelivery_Ljava_util_List_);
			return cb_attemptDelivery_Ljava_util_List_;
		}

		static void n_AttemptDelivery_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AttemptDelivery (p0);
		}
#pragma warning restore 0169

		static IntPtr id_attemptDelivery_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='attemptDelivery' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("attemptDelivery", "(Ljava/util/List;)V", "GetAttemptDelivery_Ljava_util_List_Handler")]
		public virtual void AttemptDelivery (global::System.Collections.Generic.IList<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> p0)
		{
			if (id_attemptDelivery_Ljava_util_List_ == IntPtr.Zero)
				id_attemptDelivery_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "attemptDelivery", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_attemptDelivery_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_attemptDelivery_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BatchedEvents ());
		}
#pragma warning restore 0169

		static IntPtr id_batchedEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='batchedEvents' and count(parameter)=0]"
		[Register ("batchedEvents", "()[Ljava/lang/String;", "GetBatchedEventsHandler")]
		public virtual string[] BatchedEvents ()
		{
			if (id_batchedEvents == IntPtr.Zero)
				id_batchedEvents = JNIEnv.GetMethodID (class_ref, "batchedEvents", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_batchedEvents), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_batchedEvents), JniHandleOwnership.TransferLocalRef, typeof (string));
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
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnqueueEventForDelivery (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='enqueueEventForDelivery' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("enqueueEventForDelivery", "(Lcom/amazon/insights/event/InternalEvent;)V", "GetEnqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_Handler")]
		public virtual void EnqueueEventForDelivery (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "enqueueEventForDelivery", "(Lcom/amazon/insights/event/InternalEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_enqueueEventForDelivery_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='boolean']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Z)Lcom/amazon/insights/delivery/DefaultDeliveryClient;", "")]
		public static global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, bool p1)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Z)Lcom/amazon/insights/delivery/DefaultDeliveryClient;");
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.DefaultDeliveryClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notify (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notify_Lcom_amazon_insights_event_InternalEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='DefaultDeliveryClient']/method[@name='notify' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("notify", "(Lcom/amazon/insights/event/InternalEvent;)V", "GetNotify_Lcom_amazon_insights_event_InternalEvent_Handler")]
		public virtual void Notify (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_notify_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_notify_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "notify", "(Lcom/amazon/insights/event/InternalEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notify_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notify_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
		}

	}
}
