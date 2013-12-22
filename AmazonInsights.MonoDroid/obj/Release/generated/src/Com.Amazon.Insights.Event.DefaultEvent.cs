using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']"
	[global::Android.Runtime.Register ("com/amazon/insights/event/DefaultEvent", DoNotGenerateAcw=true)]
	public sealed partial class DefaultEvent : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Util.IJSONSerializable, global::Com.Amazon.Insights.Event.IInternalEvent {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/event/DefaultEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultEvent); }
		}

		internal DefaultEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAllAttributes;
		public global::System.Collections.Generic.IDictionary<string, string> AllAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getAllAttributes' and count(parameter)=0]"
			[Register ("getAllAttributes", "()Ljava/util/Map;", "GetGetAllAttributesHandler")]
			get {
				if (id_getAllAttributes == IntPtr.Zero)
					id_getAllAttributes = JNIEnv.GetMethodID (class_ref, "getAllAttributes", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllAttributes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAllMetrics;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> AllMetrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getAllMetrics' and count(parameter)=0]"
			[Register ("getAllMetrics", "()Ljava/util/Map;", "GetGetAllMetricsHandler")]
			get {
				if (id_getAllMetrics == IntPtr.Zero)
					id_getAllMetrics = JNIEnv.GetMethodID (class_ref, "getAllMetrics", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllMetrics), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getApplicationKey;
		public string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventTimestamp;
		public global::Java.Lang.Long EventTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getEventTimestamp' and count(parameter)=0]"
			[Register ("getEventTimestamp", "()Ljava/lang/Long;", "GetGetEventTimestampHandler")]
			get {
				if (id_getEventTimestamp == IntPtr.Zero)
					id_getEventTimestamp = JNIEnv.GetMethodID (class_ref, "getEventTimestamp", "()Ljava/lang/Long;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getEventTimestamp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventType;
		public string EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()Ljava/lang/String;", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEventType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSdkName;
		public string SdkName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getSdkName' and count(parameter)=0]"
			[Register ("getSdkName", "()Ljava/lang/String;", "GetGetSdkNameHandler")]
			get {
				if (id_getSdkName == IntPtr.Zero)
					id_getSdkName = JNIEnv.GetMethodID (class_ref, "getSdkName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSdkName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSdkVersion;
		public string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getUniqueId;
		public global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void AddAttribute (string p0, string p1)
		{
			if (id_addAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_addAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_addMetric_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='addMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addMetric", "(Ljava/lang/String;Ljava/lang/Number;)V", "")]
		public void AddMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_addMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addMetric", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_addMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_createFromEvent_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Lcom_amazon_insights_Event_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='createFromEvent' and count(parameter)=3 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.amazon.insights.Event']]"
		[Register ("createFromEvent", "(Lcom/amazon/insights/core/InsightsContext;Ljava/lang/Long;Lcom/amazon/insights/Event;)Lcom/amazon/insights/event/DefaultEvent;", "")]
		public static global::Com.Amazon.Insights.Event.DefaultEvent CreateFromEvent (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Java.Lang.Long p1, global::Com.Amazon.Insights.IEvent p2)
		{
			if (id_createFromEvent_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Lcom_amazon_insights_Event_ == IntPtr.Zero)
				id_createFromEvent_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Lcom_amazon_insights_Event_ = JNIEnv.GetStaticMethodID (class_ref, "createFromEvent", "(Lcom/amazon/insights/core/InsightsContext;Ljava/lang/Long;Lcom/amazon/insights/Event;)Lcom/amazon/insights/event/DefaultEvent;");
			global::Com.Amazon.Insights.Event.DefaultEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromEvent_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Lcom_amazon_insights_Event_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public string GetAttribute (string p0)
		{
			if (id_getAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAttribute_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMetric_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='getMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMetric", "(Ljava/lang/String;)Ljava/lang/Number;", "")]
		public global::Java.Lang.Number GetMetric (string p0)
		{
			if (id_getMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMetric", "(Ljava/lang/String;)Ljava/lang/Number;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Number __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod  (Handle, id_getMetric_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_hasAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='hasAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasAttribute", "(Ljava/lang/String;)Z", "")]
		public bool HasAttribute (string p0)
		{
			if (id_hasAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_hasAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasAttribute", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasAttribute_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_hasMetric_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='hasMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasMetric", "(Ljava/lang/String;)Z", "")]
		public bool HasMetric (string p0)
		{
			if (id_hasMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_hasMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasMetric", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasMetric_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Ljava/lang/Long;Ljava/lang/String;)Lcom/amazon/insights/event/DefaultEvent;", "")]
		public static global::Com.Amazon.Insights.Event.DefaultEvent NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Java.Lang.Long p1, string p2)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Ljava/lang/Long;Ljava/lang/String;)Lcom/amazon/insights/event/DefaultEvent;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Amazon.Insights.Event.DefaultEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Event.DefaultEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_lang_Long_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
		public global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");
			return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_withAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='withAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("withAttribute", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/event/DefaultEvent;", "")]
		public global::Com.Amazon.Insights.IEvent WithAttribute (string p0, string p1)
		{
			if (id_withAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_withAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAttribute", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/event/DefaultEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.IEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod  (Handle, id_withAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_withMetric_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.event']/class[@name='DefaultEvent']/method[@name='withMetric' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("withMetric", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/event/DefaultEvent;", "")]
		public global::Com.Amazon.Insights.IEvent WithMetric (string p0, global::Java.Lang.Number p1)
		{
			if (id_withMetric_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_withMetric_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "withMetric", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/event/DefaultEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.IEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod  (Handle, id_withMetric_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
