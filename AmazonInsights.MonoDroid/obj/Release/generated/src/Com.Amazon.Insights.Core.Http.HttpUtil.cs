using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpUtil']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpUtil", DoNotGenerateAcw=true)]
	public partial class HttpUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/HttpUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUtil); }
		}

		protected HttpUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMessageForResponse_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpUtil']/method[@name='getMessageForResponse' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("getMessageForResponse", "(Lcom/amazon/insights/core/http/HttpClient$Response;)Ljava/lang/String;", "")]
		public static string GetMessageForResponse (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_getMessageForResponse_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_getMessageForResponse_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageForResponse", "(Lcom/amazon/insights/core/http/HttpClient$Response;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageForResponse_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
