using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SDKInfoInterceptor']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/SDKInfoInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class SDKInfoInterceptor : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/SDKInfoInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SDKInfoInterceptor); }
		}

		internal SDKInfoInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_util_SDKInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SDKInfoInterceptor']/constructor[@name='SDKInfoInterceptor' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.util.SDKInfo']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/util/SDKInfo;)V", "")]
		public SDKInfoInterceptor (global::Com.Amazon.Insights.Core.Util.SDKInfo p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SDKInfoInterceptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/util/SDKInfo;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/util/SDKInfo;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_util_SDKInfo_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_util_SDKInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/util/SDKInfo;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_util_SDKInfo_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_util_SDKInfo_, new JValue (p0));
		}

		static IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SDKInfoInterceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "")]
		public void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");
			JNIEnv.CallVoidMethod  (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
		}

		static IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SDKInfoInterceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "")]
		public void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");
			JNIEnv.CallVoidMethod  (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}
}
