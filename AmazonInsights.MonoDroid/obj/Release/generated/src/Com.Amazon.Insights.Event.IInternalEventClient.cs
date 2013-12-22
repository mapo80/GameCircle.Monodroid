using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='InternalEventClient']"
	[Register ("com/amazon/insights/event/InternalEventClient", "", "Com.Amazon.Insights.Event.IInternalEventClientInvoker")]
	public partial interface IInternalEventClient : global::Com.Amazon.Insights.IEventClient {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='InternalEventClient']/method[@name='addEventObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.EventObserver']]"
		[Register ("addEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V", "GetAddEventObserver_Lcom_amazon_insights_event_EventObserver_Handler:Com.Amazon.Insights.Event.IInternalEventClientInvoker, AmazonInsights.MonoDroid")]
		void AddEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='InternalEventClient']/method[@name='createInternalEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInternalEvent", "(Ljava/lang/String;)Lcom/amazon/insights/event/InternalEvent;", "GetCreateInternalEvent_Ljava_lang_String_Handler:Com.Amazon.Insights.Event.IInternalEventClientInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Event.IInternalEvent CreateInternalEvent (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='InternalEventClient']/method[@name='recordEvent' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.Event'] and parameter[2][@type='boolean']]"
		[Register ("recordEvent", "(Lcom/amazon/insights/Event;Z)V", "GetRecordEvent_Lcom_amazon_insights_Event_ZHandler:Com.Amazon.Insights.Event.IInternalEventClientInvoker, AmazonInsights.MonoDroid")]
		void RecordEvent (global::Com.Amazon.Insights.IEvent p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/interface[@name='InternalEventClient']/method[@name='removeEventObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.event.EventObserver']]"
		[Register ("removeEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V", "GetRemoveEventObserver_Lcom_amazon_insights_event_EventObserver_Handler:Com.Amazon.Insights.Event.IInternalEventClientInvoker, AmazonInsights.MonoDroid")]
		void RemoveEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/event/InternalEventClient", DoNotGenerateAcw=true)]
	internal class IInternalEventClientInvoker : global::Java.Lang.Object, IInternalEventClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/event/InternalEventClient");
		IntPtr class_ref;

		public static IInternalEventClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalEventClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.event.InternalEventClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalEventClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInternalEventClientInvoker); }
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IEventObserver p0 = (global::Com.Amazon.Insights.Event.IEventObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IEventObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEventObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_addEventObserver_Lcom_amazon_insights_event_EventObserver_;
		public void AddEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0)
		{
			if (id_addEventObserver_Lcom_amazon_insights_event_EventObserver_ == IntPtr.Zero)
				id_addEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNIEnv.GetMethodID (class_ref, "addEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V");
			JNIEnv.CallVoidMethod (Handle, id_addEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateInternalEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createInternalEvent_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Event.IInternalEvent CreateInternalEvent (string p0)
		{
			if (id_createInternalEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_createInternalEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createInternalEvent", "(Ljava/lang/String;)Lcom/amazon/insights/event/InternalEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Event.IInternalEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEvent> (JNIEnv.CallObjectMethod (Handle, id_createInternalEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.IEvent p0 = (global::Com.Amazon.Insights.IEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_recordEvent_Lcom_amazon_insights_Event_Z;
		public void RecordEvent (global::Com.Amazon.Insights.IEvent p0, bool p1)
		{
			if (id_recordEvent_Lcom_amazon_insights_Event_Z == IntPtr.Zero)
				id_recordEvent_Lcom_amazon_insights_Event_Z = JNIEnv.GetMethodID (class_ref, "recordEvent", "(Lcom/amazon/insights/Event;Z)V");
			JNIEnv.CallVoidMethod (Handle, id_recordEvent_Lcom_amazon_insights_Event_Z, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Event.IEventObserver p0 = (global::Com.Amazon.Insights.Event.IEventObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IEventObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_;
		public void RemoveEventObserver (global::Com.Amazon.Insights.Event.IEventObserver p0)
		{
			if (id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ == IntPtr.Zero)
				id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_ = JNIEnv.GetMethodID (class_ref, "removeEventObserver", "(Lcom/amazon/insights/event/EventObserver;)V");
			JNIEnv.CallVoidMethod (Handle, id_removeEventObserver_Lcom_amazon_insights_event_EventObserver_, new JValue (p0));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalAttribute (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		public void AddGlobalAttribute (string p0, string p1)
		{
			if (id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalAttribute (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public void AddGlobalAttribute (string p0, string p1, string p2)
		{
			if (id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod (Handle, id_addGlobalAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalMetric (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_;
		public void AddGlobalMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addGlobalMetric", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalMetric (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_;
		public void AddGlobalMetric (string p0, string p1, global::Java.Lang.Number p2)
		{
			if (id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_addGlobalMetric_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createEvent_Ljava_lang_String_;
		public global::Com.Amazon.Insights.IEvent CreateEvent (string p0)
		{
			if (id_createEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_createEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createEvent", "(Ljava/lang/String;)Lcom/amazon/insights/Event;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.IEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod (Handle, id_createEvent_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.IEvent p0 = (global::Com.Amazon.Insights.IEvent)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_recordEvent_Lcom_amazon_insights_Event_;
		public void RecordEvent (global::Com.Amazon.Insights.IEvent p0)
		{
			if (id_recordEvent_Lcom_amazon_insights_Event_ == IntPtr.Zero)
				id_recordEvent_Lcom_amazon_insights_Event_ = JNIEnv.GetMethodID (class_ref, "recordEvent", "(Lcom/amazon/insights/Event;)V");
			JNIEnv.CallVoidMethod (Handle, id_recordEvent_Lcom_amazon_insights_Event_, new JValue (p0));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalAttribute (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeGlobalAttribute_Ljava_lang_String_;
		public void RemoveGlobalAttribute (string p0)
		{
			if (id_removeGlobalAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalAttribute", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeGlobalAttribute_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalAttribute (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_;
		public void RemoveGlobalAttribute (string p0, string p1)
		{
			if (id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_removeGlobalAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalMetric (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeGlobalMetric_Ljava_lang_String_;
		public void RemoveGlobalMetric (string p0)
		{
			if (id_removeGlobalMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalMetric", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeGlobalMetric_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGlobalMetric (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_;
		public void RemoveGlobalMetric (string p0, string p1)
		{
			if (id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGlobalMetric", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_removeGlobalMetric_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Amazon.Insights.Event.IInternalEventClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.IInternalEventClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitEvents ();
		}
#pragma warning restore 0169

		IntPtr id_submitEvents;
		public void SubmitEvents ()
		{
			if (id_submitEvents == IntPtr.Zero)
				id_submitEvents = JNIEnv.GetMethodID (class_ref, "submitEvents", "()V");
			JNIEnv.CallVoidMethod (Handle, id_submitEvents);
		}

	}

}
