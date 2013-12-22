using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']"
	[Register ("com/amazon/insights/Event", "", "Com.Amazon.Insights.IEventInvoker")]
	public partial interface IEvent : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> AllAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='getAllAttributes' and count(parameter)=0]"
			[Register ("getAllAttributes", "()Ljava/util/Map;", "GetGetAllAttributesHandler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> AllMetrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='getAllMetrics' and count(parameter)=0]"
			[Register ("getAllMetrics", "()Ljava/util/Map;", "GetGetAllMetricsHandler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")] get;
		}

		string EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()Ljava/lang/String;", "GetGetEventTypeHandler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddAttribute_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		void AddAttribute (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='addMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addMetric", "(Ljava/lang/String;Ljava/lang/Number;)V", "GetAddMetric_Ljava_lang_String_Ljava_lang_Number_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		void AddMetric (string p0, global::Java.Lang.Number p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAttribute_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		string GetAttribute (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='getMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMetric", "(Ljava/lang/String;)Ljava/lang/Number;", "GetGetMetric_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Number GetMetric (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='hasAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasAttribute", "(Ljava/lang/String;)Z", "GetHasAttribute_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		bool HasAttribute (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='hasMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasMetric", "(Ljava/lang/String;)Z", "GetHasMetric_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		bool HasMetric (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='withAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("withAttribute", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/Event;", "GetWithAttribute_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IEvent WithAttribute (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Event']/method[@name='withMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("withMetric", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/Event;", "GetWithMetric_Ljava_lang_String_Ljava_lang_Number_Handler:Com.Amazon.Insights.IEventInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IEvent WithMetric (string p0, global::Java.Lang.Number p1);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/Event", DoNotGenerateAcw=true)]
	internal class IEventInvoker : global::Java.Lang.Object, IEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/Event");
		IntPtr class_ref;

		public static IEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.Event"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventInvoker); }
		}

		static Delegate cb_getAllAttributes;
#pragma warning disable 0169
		static Delegate GetGetAllAttributesHandler ()
		{
			if (cb_getAllAttributes == null)
				cb_getAllAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllAttributes);
			return cb_getAllAttributes;
		}

		static IntPtr n_GetAllAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllAttributes);
		}
#pragma warning restore 0169

		IntPtr id_getAllAttributes;
		public global::System.Collections.Generic.IDictionary<string, string> AllAttributes {
			get {
				if (id_getAllAttributes == IntPtr.Zero)
					id_getAllAttributes = JNIEnv.GetMethodID (class_ref, "getAllAttributes", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllAttributes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAllMetrics;
#pragma warning disable 0169
		static Delegate GetGetAllMetricsHandler ()
		{
			if (cb_getAllMetrics == null)
				cb_getAllMetrics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllMetrics);
			return cb_getAllMetrics;
		}

		static IntPtr n_GetAllMetrics (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.ToLocalJniHandle (__this.AllMetrics);
		}
#pragma warning restore 0169

		IntPtr id_getAllMetrics;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> AllMetrics {
			get {
				if (id_getAllMetrics == IntPtr.Zero)
					id_getAllMetrics = JNIEnv.GetMethodID (class_ref, "getAllMetrics", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllMetrics), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEventType;
#pragma warning disable 0169
		static Delegate GetGetEventTypeHandler ()
		{
			if (cb_getEventType == null)
				cb_getEventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventType);
			return cb_getEventType;
		}

		static IntPtr n_GetEventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventType);
		}
#pragma warning restore 0169

		IntPtr id_getEventType;
		public string EventType {
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getEventType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_addAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAttribute (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addAttribute_Ljava_lang_String_Ljava_lang_String_;
		public void AddAttribute (string p0, string p1)
		{
			if (id_addAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_addAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addMetric_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddMetric_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_addMetric_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_addMetric_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMetric_Ljava_lang_String_Ljava_lang_Number_);
			return cb_addMetric_Ljava_lang_String_Ljava_lang_Number_;
		}

		static void n_AddMetric_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddMetric (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addMetric_Ljava_lang_String_Ljava_lang_Number_;
		public void AddMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_addMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addMetric", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_addMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_getAttribute_Ljava_lang_String_ == null)
				cb_getAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttribute_Ljava_lang_String_);
			return cb_getAttribute_Ljava_lang_String_;
		}

		static IntPtr n_GetAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAttribute (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAttribute_Ljava_lang_String_;
		public string GetAttribute (string p0)
		{
			if (id_getAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAttribute_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMetric_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMetric_Ljava_lang_String_Handler ()
		{
			if (cb_getMetric_Ljava_lang_String_ == null)
				cb_getMetric_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMetric_Ljava_lang_String_);
			return cb_getMetric_Ljava_lang_String_;
		}

		static IntPtr n_GetMetric_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMetric (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMetric_Ljava_lang_String_;
		public global::Java.Lang.Number GetMetric (string p0)
		{
			if (id_getMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMetric", "(Ljava/lang/String;)Ljava/lang/Number;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Number __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod (Handle, id_getMetric_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_hasAttribute_Ljava_lang_String_ == null)
				cb_hasAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasAttribute_Ljava_lang_String_);
			return cb_hasAttribute_Ljava_lang_String_;
		}

		static bool n_HasAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasAttribute (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hasAttribute_Ljava_lang_String_;
		public bool HasAttribute (string p0)
		{
			if (id_hasAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_hasAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasAttribute", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_hasAttribute_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasMetric_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasMetric_Ljava_lang_String_Handler ()
		{
			if (cb_hasMetric_Ljava_lang_String_ == null)
				cb_hasMetric_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasMetric_Ljava_lang_String_);
			return cb_hasMetric_Ljava_lang_String_;
		}

		static bool n_HasMetric_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasMetric (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hasMetric_Ljava_lang_String_;
		public bool HasMetric (string p0)
		{
			if (id_hasMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_hasMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasMetric", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_hasMetric_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_withAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_withAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_withAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WithAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAttribute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withAttribute_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Amazon.Insights.IEvent WithAttribute (string p0, string p1)
		{
			if (id_withAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_withAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAttribute", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/Event;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.IEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod (Handle, id_withAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_withMetric_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetWithMetric_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_withMetric_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_withMetric_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMetric_Ljava_lang_String_Ljava_lang_Number_);
			return cb_withMetric_Ljava_lang_String_Ljava_lang_Number_;
		}

		static IntPtr n_WithMetric_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMetric (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withMetric_Ljava_lang_String_Ljava_lang_Number_;
		public global::Com.Amazon.Insights.IEvent WithMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_withMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_withMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "withMetric", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/Event;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.IEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod (Handle, id_withMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
