using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.event.adapter']/interface[@name='EventAdapter']"
	[Register ("com/amazon/insights/event/adapter/EventAdapter", "", "Com.Amazon.Insights.Event.Adapter.IEventAdapterInvoker")]
	public partial interface IEventAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event.adapter']/interface[@name='EventAdapter']/method[@name='translateFromEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("translateFromEvent", "(Lcom/amazon/insights/event/InternalEvent;)Ljava/lang/Object;", "GetTranslateFromEvent_Lcom_amazon_insights_event_InternalEvent_Handler:Com.Amazon.Insights.Event.Adapter.IEventAdapterInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Object TranslateFromEvent (global::Com.Amazon.Insights.Event.IInternalEvent p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/event/adapter/EventAdapter", DoNotGenerateAcw=true)]
	internal class IEventAdapterInvoker : global::Java.Lang.Object, IEventAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/event/adapter/EventAdapter");
		IntPtr class_ref;

		public static IEventAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.event.adapter.EventAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventAdapterInvoker); }
		}

		static Delegate cb_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_;
#pragma warning disable 0169
		static Delegate GetTranslateFromEvent_Lcom_amazon_insights_event_InternalEvent_Handler ()
		{
			if (cb_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ == null)
				cb_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateFromEvent_Lcom_amazon_insights_event_InternalEvent_);
			return cb_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_;
		}

		static IntPtr n_TranslateFromEvent_Lcom_amazon_insights_event_InternalEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.Adapter.IEventAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.Adapter.IEventAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TranslateFromEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_;
		public global::Java.Lang.Object TranslateFromEvent (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "translateFromEvent", "(Lcom/amazon/insights/event/InternalEvent;)Ljava/lang/Object;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
