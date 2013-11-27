using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/RequestTimingInterceptor", DoNotGenerateAcw=true)]
	public partial class RequestTimingInterceptor : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/field[@name='REQUESTATTEMPTS_HEADER']"
		[Register ("REQUESTATTEMPTS_HEADER")]
		public const string RequestattemptsHeader = (string) "x-amzn-RequestAttempts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/field[@name='REQUESTTIME_HEADER']"
		[Register ("REQUESTTIME_HEADER")]
		public const string RequesttimeHeader = (string) "x-amzn-RequestTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/field[@name='SERVERINFO_HEADER']"
		[Register ("SERVERINFO_HEADER")]
		public const string ServerinfoHeader = (string) "x-amzn-ServerInfo";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/RequestTimingInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestTimingInterceptor); }
		}

		protected RequestTimingInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_system_Connectivity_Lcom_amazon_insights_event_InternalEventClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/constructor[@name='RequestTimingInterceptor' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.system.Connectivity'] and parameter[2][@type='com.amazon.insights.event.InternalEventClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/system/Connectivity;Lcom/amazon/insights/event/InternalEventClient;)V", "")]
		public RequestTimingInterceptor (global::com.amazon.insights.core.system.amazon.IConnectivity p0, global::Com.Amazon.Insights.Event.IInternalEventClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestTimingInterceptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/system/Connectivity;Lcom/amazon/insights/event/InternalEventClient;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/system/Connectivity;Lcom/amazon/insights/event/InternalEventClient;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_system_Connectivity_Lcom_amazon_insights_event_InternalEventClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_system_Connectivity_Lcom_amazon_insights_event_InternalEventClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/system/Connectivity;Lcom/amazon/insights/event/InternalEventClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_system_Connectivity_Lcom_amazon_insights_event_InternalEventClient_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_system_Connectivity_Lcom_amazon_insights_event_InternalEventClient_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
#pragma warning disable 0169
		static Delegate GetAfter_Lcom_amazon_insights_core_http_HttpClient_Response_Handler ()
		{
			if (cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == null)
				cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_After_Lcom_amazon_insights_core_http_HttpClient_Response_);
			return cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		}

		static void n_After_Lcom_amazon_insights_core_http_HttpClient_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.RequestTimingInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.RequestTimingInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.After (p0);
		}
#pragma warning restore 0169

		static IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "GetAfter_Lcom_amazon_insights_core_http_HttpClient_Response_Handler")]
		public virtual void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
		}

		static Delegate cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
#pragma warning disable 0169
		static Delegate GetBefore_Lcom_amazon_insights_core_http_HttpClient_Request_Handler ()
		{
			if (cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == null)
				cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Before_Lcom_amazon_insights_core_http_HttpClient_Request_);
			return cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		}

		static void n_Before_Lcom_amazon_insights_core_http_HttpClient_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.RequestTimingInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.RequestTimingInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Before (p0);
		}
#pragma warning restore 0169

		static IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='RequestTimingInterceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "GetBefore_Lcom_amazon_insights_core_http_HttpClient_Request_Handler")]
		public virtual void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}
}
