using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']"
	[global::Android.Runtime.Register ("com/amazon/insights/event/DefaultEventClient", DoNotGenerateAcw=true)]
	public partial class DefaultEventClient : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Util.IJSONSerializable, global::Com.Amazon.Insights.Event.IInternalEventClient {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/event/DefaultEventClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultEventClient); }
		}

		protected DefaultEventClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllowEventCollection;
#pragma warning disable 0169
		static Delegate GetGetAllowEventCollectionHandler ()
		{
			if (cb_getAllowEventCollection == null)
				cb_getAllowEventCollection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAllowEventCollection);
			return cb_getAllowEventCollection;
		}

		static bool n_GetAllowEventCollection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowEventCollection;
		}
#pragma warning restore 0169

		static IntPtr id_getAllowEventCollection;
		public virtual bool AllowEventCollection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='getAllowEventCollection' and count(parameter)=0]"
			[Register ("getAllowEventCollection", "()Z", "GetGetAllowEventCollectionHandler")]
			get {
				if (id_getAllowEventCollection == IntPtr.Zero)
					id_getAllowEventCollection = JNIEnv.GetMethodID (class_ref, "getAllowEventCollection", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAllowEventCollection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getAllowEventCollection);
			}
		}

		static Delegate cb_getEventObservers;
#pragma warning disable 0169
		static Delegate GetGetEventObserversHandler ()
		{
			if (cb_getEventObservers == null)
				cb_getEventObservers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventObservers);
			return cb_getEventObservers;
		}

		static IntPtr n_GetEventObservers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Insights.Event.IEventObserver>.ToLocalJniHandle (__this.EventObservers);
		}
#pragma warning restore 0169

		static IntPtr id_getEventObservers;
		protected virtual global::System.Collections.Generic.IList<global::Com.Amazon.Insights.Event.IEventObserver> EventObservers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='getEventObservers' and count(parameter)=0]"
			[Register ("getEventObservers", "()Ljava/util/List;", "GetGetEventObserversHandler")]
			get {
				if (id_getEventObservers == IntPtr.Zero)
					id_getEventObservers = JNIEnv.GetMethodID (class_ref, "getEventObservers", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Amazon.Insights.Event.IEventObserver>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getEventObservers), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Amazon.Insights.Event.IEventObserver>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEventObservers), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addEventObserver_Lcom_amazon_insights_event_EventObserver_;
#pragma warning disable 0169
		static Delegate GetAddEventObserver_Lcom_amazon_insights_event_EventObserver_Handler ()
		{
			if (cb_addEventObserver_Lcom_amazon_insights_event_EventObserver_ == null)
				cb_addEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEventObserver_Lcom_amazon_insights_event_EventObserver_);
			return cb_addEventObserver_Lcom_amazon_insights_event_EventObserver_;
		}

		static void n_AddEventObserver_Lcom_amazon_insights_event_EventObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IEventObserver p0 = (global::Com.Amazon.Insights.Event.IEventObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IEventObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEventObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEventObserver_Lcom_amazon_insights_event_EventObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='addEventObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.EventObserver']]"
		[Register ("addEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V", "GetAddEventObserver_Lcom_amazon_insights_event_EventObserver_Handler")]
		public virtual void AddEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0)
		{
			if (id_addEventObserver_Lcom_amazon_insights_event_EventObserver_ == IntPtr.Zero)
				id_addEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNIEnv.GetMethodID (class_ref, "addEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
		}

		static Delegate cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalAttribute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='addGlobalAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddGlobalAttribute (string p0, string p1)
		{
			if (id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalAttribute (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='addGlobalAttribute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetAddGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddGlobalAttribute (string p0, string p1, string p2)
		{
			if (id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddGlobalMetric_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGlobalMetric_Ljava_lang_String_Ljava_lang_Number_);
			return cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_;
		}

		static void n_AddGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalMetric (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='addGlobalMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addGlobalMetric", "(Ljava/lang/String;Ljava/lang/Number;)V", "GetAddGlobalMetric_Ljava_lang_String_Ljava_lang_Number_Handler")]
		public virtual void AddGlobalMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addGlobalMetric", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_);
			return cb_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_;
		}

		static void n_AddGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalMetric (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='addGlobalMetric' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Number']]"
		[Register ("addGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Number;)V", "GetAddGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_Handler")]
		public virtual void AddGlobalMetric (string p0, string p1, global::Java.Lang.Number p2)
		{
			if (id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_createEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateEvent_Ljava_lang_String_Handler ()
		{
			if (cb_createEvent_Ljava_lang_String_ == null)
				cb_createEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateEvent_Ljava_lang_String_);
			return cb_createEvent_Ljava_lang_String_;
		}

		static IntPtr n_CreateEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='createEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createEvent", "(Ljava/lang/String;)Lcom/amazon/insights/Event;", "GetCreateEvent_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.IEvent CreateEvent (string p0)
		{
			if (id_createEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_createEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createEvent", "(Ljava/lang/String;)Lcom/amazon/insights/Event;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.IEvent __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod  (Handle, id_createEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_createInternalEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateInternalEvent_Ljava_lang_String_Handler ()
		{
			if (cb_createInternalEvent_Ljava_lang_String_ == null)
				cb_createInternalEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateInternalEvent_Ljava_lang_String_);
			return cb_createInternalEvent_Ljava_lang_String_;
		}

		static IntPtr n_CreateInternalEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateInternalEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createInternalEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='createInternalEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInternalEvent", "(Ljava/lang/String;)Lcom/amazon/insights/event/InternalEvent;", "GetCreateInternalEvent_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.Event.IInternalEvent CreateInternalEvent (string p0)
		{
			if (id_createInternalEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_createInternalEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createInternalEvent", "(Ljava/lang/String;)Lcom/amazon/insights/event/InternalEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.Event.IInternalEvent __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (JNIEnv.CallObjectMethod  (Handle, id_createInternalEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createInternalEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='boolean']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Z)Lcom/amazon/insights/event/DefaultEventClient;", "")]
		public static global::Com.Amazon.Insights.Event.DefaultEventClient NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, bool p1)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Z)Lcom/amazon/insights/event/DefaultEventClient;");
			global::Com.Amazon.Insights.Event.DefaultEventClient __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_notifyObservers_Lcom_amazon_insights_event_InternalEvent_;
#pragma warning disable 0169
		static Delegate GetNotifyObservers_Lcom_amazon_insights_event_InternalEvent_Handler ()
		{
			if (cb_notifyObservers_Lcom_amazon_insights_event_InternalEvent_ == null)
				cb_notifyObservers_Lcom_amazon_insights_event_InternalEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyObservers_Lcom_amazon_insights_event_InternalEvent_);
			return cb_notifyObservers_Lcom_amazon_insights_event_InternalEvent_;
		}

		static void n_NotifyObservers_Lcom_amazon_insights_event_InternalEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IInternalEvent p0 = (global::Com.Amazon.Insights.Event.IInternalEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyObservers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyObservers_Lcom_amazon_insights_event_InternalEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='notifyObservers' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.InternalEvent']]"
		[Register ("notifyObservers", "(Lcom/amazon/insights/event/InternalEvent;)V", "GetNotifyObservers_Lcom_amazon_insights_event_InternalEvent_Handler")]
		protected virtual void NotifyObservers (global::Com.Amazon.Insights.Event.IInternalEvent p0)
		{
			if (id_notifyObservers_Lcom_amazon_insights_event_InternalEvent_ == IntPtr.Zero)
				id_notifyObservers_Lcom_amazon_insights_event_InternalEvent_ = JNIEnv.GetMethodID (class_ref, "notifyObservers", "(Lcom/amazon/insights/event/InternalEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyObservers_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyObservers_Lcom_amazon_insights_event_InternalEvent_, new JValue (p0));
		}

		static Delegate cb_recordEvent_Lcom_amazon_insights_Event_;
#pragma warning disable 0169
		static Delegate GetRecordEvent_Lcom_amazon_insights_Event_Handler ()
		{
			if (cb_recordEvent_Lcom_amazon_insights_Event_ == null)
				cb_recordEvent_Lcom_amazon_insights_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordEvent_Lcom_amazon_insights_Event_);
			return cb_recordEvent_Lcom_amazon_insights_Event_;
		}

		static void n_RecordEvent_Lcom_amazon_insights_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.IEvent p0 = (global::Com.Amazon.Insights.IEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recordEvent_Lcom_amazon_insights_Event_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='recordEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.Event']]"
		[Register ("recordEvent", "(Lcom/amazon/insights/Event;)V", "GetRecordEvent_Lcom_amazon_insights_Event_Handler")]
		public virtual void RecordEvent (global::Com.Amazon.Insights.IEvent p0)
		{
			if (id_recordEvent_Lcom_amazon_insights_Event_ == IntPtr.Zero)
				id_recordEvent_Lcom_amazon_insights_Event_ = JNIEnv.GetMethodID (class_ref, "recordEvent", "(Lcom/amazon/insights/Event;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordEvent_Lcom_amazon_insights_Event_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordEvent_Lcom_amazon_insights_Event_, new JValue (p0));
		}

		static Delegate cb_recordEvent_Lcom_amazon_insights_Event_Z;
#pragma warning disable 0169
		static Delegate GetRecordEvent_Lcom_amazon_insights_Event_ZHandler ()
		{
			if (cb_recordEvent_Lcom_amazon_insights_Event_Z == null)
				cb_recordEvent_Lcom_amazon_insights_Event_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RecordEvent_Lcom_amazon_insights_Event_Z);
			return cb_recordEvent_Lcom_amazon_insights_Event_Z;
		}

		static void n_RecordEvent_Lcom_amazon_insights_Event_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.IEvent p0 = (global::Com.Amazon.Insights.IEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_recordEvent_Lcom_amazon_insights_Event_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='recordEvent' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.Event'] and parameter[2][@type='boolean']]"
		[Register ("recordEvent", "(Lcom/amazon/insights/Event;Z)V", "GetRecordEvent_Lcom_amazon_insights_Event_ZHandler")]
		public virtual void RecordEvent (global::Com.Amazon.Insights.IEvent p0, bool p1)
		{
			if (id_recordEvent_Lcom_amazon_insights_Event_Z == IntPtr.Zero)
				id_recordEvent_Lcom_amazon_insights_Event_Z = JNIEnv.GetMethodID (class_ref, "recordEvent", "(Lcom/amazon/insights/Event;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordEvent_Lcom_amazon_insights_Event_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordEvent_Lcom_amazon_insights_Event_Z, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removeEventObserver_Lcom_amazon_insights_event_EventObserver_;
#pragma warning disable 0169
		static Delegate GetRemoveEventObserver_Lcom_amazon_insights_event_EventObserver_Handler ()
		{
			if (cb_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ == null)
				cb_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEventObserver_Lcom_amazon_insights_event_EventObserver_);
			return cb_removeEventObserver_Lcom_amazon_insights_event_EventObserver_;
		}

		static void n_RemoveEventObserver_Lcom_amazon_insights_event_EventObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IEventObserver p0 = (global::Com.Amazon.Insights.Event.IEventObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IEventObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='removeEventObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.EventObserver']]"
		[Register ("removeEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V", "GetRemoveEventObserver_Lcom_amazon_insights_event_EventObserver_Handler")]
		public virtual void RemoveEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0)
		{
			if (id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ == IntPtr.Zero)
				id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNIEnv.GetMethodID (class_ref, "removeEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
		}

		static Delegate cb_removeGlobalAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGlobalAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_removeGlobalAttribute_Ljava_lang_String_ == null)
				cb_removeGlobalAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveGlobalAttribute_Ljava_lang_String_);
			return cb_removeGlobalAttribute_Ljava_lang_String_;
		}

		static void n_RemoveGlobalAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalAttribute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeGlobalAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='removeGlobalAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeGlobalAttribute", "(Ljava/lang/String;)V", "GetRemoveGlobalAttribute_Ljava_lang_String_Handler")]
		public virtual void RemoveGlobalAttribute (string p0)
		{
			if (id_removeGlobalAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalAttribute", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGlobalAttribute_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGlobalAttribute_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveGlobalAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalAttribute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='removeGlobalAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void RemoveGlobalAttribute (string p0, string p1)
		{
			if (id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_removeGlobalMetric_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGlobalMetric_Ljava_lang_String_Handler ()
		{
			if (cb_removeGlobalMetric_Ljava_lang_String_ == null)
				cb_removeGlobalMetric_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveGlobalMetric_Ljava_lang_String_);
			return cb_removeGlobalMetric_Ljava_lang_String_;
		}

		static void n_RemoveGlobalMetric_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalMetric (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeGlobalMetric_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='removeGlobalMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeGlobalMetric", "(Ljava/lang/String;)V", "GetRemoveGlobalMetric_Ljava_lang_String_Handler")]
		public virtual void RemoveGlobalMetric (string p0)
		{
			if (id_removeGlobalMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalMetric", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGlobalMetric_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGlobalMetric_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGlobalMetric_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveGlobalMetric_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveGlobalMetric_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalMetric (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='removeGlobalMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveGlobalMetric_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void RemoveGlobalMetric (string p0, string p1)
		{
			if (id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_submitEvents;
#pragma warning disable 0169
		static Delegate GetSubmitEventsHandler ()
		{
			if (cb_submitEvents == null)
				cb_submitEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SubmitEvents);
			return cb_submitEvents;
		}

		static void n_SubmitEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitEvents ();
		}
#pragma warning restore 0169

		static IntPtr id_submitEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='submitEvents' and count(parameter)=0]"
		[Register ("submitEvents", "()V", "GetSubmitEventsHandler")]
		public virtual void SubmitEvents ()
		{
			if (id_submitEvents == IntPtr.Zero)
				id_submitEvents = JNIEnv.GetMethodID (class_ref, "submitEvents", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_submitEvents);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_submitEvents);
		}

		static Delegate cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Event.DefaultEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEventClient']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
		}

	}
}
