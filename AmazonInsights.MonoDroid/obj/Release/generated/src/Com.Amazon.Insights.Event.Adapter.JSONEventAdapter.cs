using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.event.adapter']/class[@name='JSONEventAdapter']"
	[global::Android.Runtime.Register ("com/amazon/insights/event/adapter/JSONEventAdapter", DoNotGenerateAcw=true)]
	public partial class JSONEventAdapter : global::Java.Lang.Object, global::Com.Amazon.Insights.Event.Adapter.IEventAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/event/adapter/JSONEventAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSONEventAdapter); }
		}

		protected JSONEventAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.event.adapter']/class[@name='JSONEventAdapter']/constructor[@name='JSONEventAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public JSONEventAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JSONEventAdapter)) {
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
			global::Com.Amazon.Insights.Event.Adapter.JSONEventAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.Adapter.JSONEventAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TranslateFromEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event.adapter']/class[@name='JSONEventAdapter']/method[@name='translateFromEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("translateFromEvent", "(Lcom/amazon/insights/event/InternalEvent;)Lorg/json/JSONObject;", "GetTranslateFromEvent_Lcom_amazon_insights_event_InternalEvent_Handler")]
		public virtual global::Org.Json.JSONObject TranslateFromEvent (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "translateFromEvent", "(Lcom/amazon/insights/event/InternalEvent;)Lorg/json/JSONObject;");

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_translateFromEvent_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Insights.Event.Adapter.IEventAdapter
		global::Java.Lang.Object global::Com.Amazon.Insights.Event.Adapter.IEventAdapter.TranslateFromEvent (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(TranslateFromEvent (p0));
		}

	}
}
