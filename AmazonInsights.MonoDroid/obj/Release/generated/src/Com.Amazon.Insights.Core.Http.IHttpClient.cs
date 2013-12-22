using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpClient.HttpMethod']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpClient$HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpClientHttpMethod : global::Java.Lang.Enum {


		static IntPtr GET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpClient.HttpMethod']/field[@name='GET']"
		[Register ("GET")]
		public static global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod Get {
			get {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GET_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpClient.HttpMethod']/field[@name='POST']"
		[Register ("POST")]
		public static global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod Post {
			get {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/HttpClient$HttpMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientHttpMethod); }
		}

		internal HttpClientHttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpClient.HttpMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$HttpMethod;", "")]
		public static global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='HttpClient.HttpMethod']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/insights/core/http/HttpClient$HttpMethod;", "")]
		public static global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
			return (global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Interceptor']"
	[Register ("com/amazon/insights/core/http/HttpClient$Interceptor", "", "Com.Amazon.Insights.Core.Http.IHttpClientInterceptorInvoker")]
	public partial interface IHttpClientInterceptor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Interceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "GetAfter_Lcom_amazon_insights_core_http_HttpClient_Response_Handler:Com.Amazon.Insights.Core.Http.IHttpClientInterceptorInvoker, AmazonInsights.MonoDroid")]
		void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Interceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "GetBefore_Lcom_amazon_insights_core_http_HttpClient_Request_Handler:Com.Amazon.Insights.Core.Http.IHttpClientInterceptorInvoker, AmazonInsights.MonoDroid")]
		void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpClient$Interceptor", DoNotGenerateAcw=true)]
	internal class IHttpClientInterceptorInvoker : global::Java.Lang.Object, IHttpClientInterceptor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/http/HttpClient$Interceptor");
		IntPtr class_ref;

		public static IHttpClientInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpClientInterceptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.http.HttpClient.Interceptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpClientInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpClientInterceptorInvoker); }
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
			global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.After (p0);
		}
#pragma warning restore 0169

		IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		public void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");
			JNIEnv.CallVoidMethod (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
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
			global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Before (p0);
		}
#pragma warning restore 0169

		IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		public void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");
			JNIEnv.CallVoidMethod (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']"
	[Register ("com/amazon/insights/core/http/HttpClient$Request", "", "Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker")]
	public partial interface IHttpClientRequest : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Lcom/amazon/insights/core/http/HttpClient$HttpMethod;", "GetGetMethodHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::System.Collections.Generic.IDictionary<string, string> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")] get;
		}

		string PostBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getPostBody' and count(parameter)=0]"
			[Register ("getPostBody", "()Ljava/lang/String;", "GetGetPostBodyHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")] get;
		}

		string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddHeader (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddParam (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='getPostBodyBytes' and count(parameter)=0]"
		[Register ("getPostBodyBytes", "()[B", "GetGetPostBodyBytesHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		byte[] GetPostBodyBytes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeHeader", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetRemoveHeader_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest RemoveHeader (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.HttpMethod']]"
		[Register ("setMethod", "(Lcom/amazon/insights/core/http/HttpClient$HttpMethod;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetMethod (global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='setPostBody' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPostBody", "([B)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetPostBody_arrayBHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='setPostBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPostBody", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetPostBody_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrl", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetUrl_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetUrl (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Request']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Com.Amazon.Insights.Core.Http.IHttpClientRequestInvoker, AmazonInsights.MonoDroid")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpClient$Request", DoNotGenerateAcw=true)]
	internal class IHttpClientRequestInvoker : global::Java.Lang.Object, IHttpClientRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/http/HttpClient$Request");
		IntPtr class_ref;

		public static IHttpClientRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpClientRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.http.HttpClient.Request"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpClientRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpClientRequestInvoker); }
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		public global::System.Collections.Generic.IDictionary<string, string> Headers {
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Method);
		}
#pragma warning restore 0169

		IntPtr id_getMethod;
		public global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod Method {
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (JNIEnv.CallObjectMethod (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		IntPtr id_getParams;
		public global::System.Collections.Generic.IDictionary<string, string> Params {
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPostBody;
#pragma warning disable 0169
		static Delegate GetGetPostBodyHandler ()
		{
			if (cb_getPostBody == null)
				cb_getPostBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostBody);
			return cb_getPostBody;
		}

		static IntPtr n_GetPostBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostBody);
		}
#pragma warning restore 0169

		IntPtr id_getPostBody;
		public string PostBody {
			get {
				if (id_getPostBody == IntPtr.Zero)
					id_getPostBody = JNIEnv.GetMethodID (class_ref, "getPostBody", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPostBody), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		IntPtr id_getUrl;
		public string Url {
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_addParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_addParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddParam (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addParam_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddParam (string p0, string p1)
		{
			if (id_addParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_addParam_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getPostBodyBytes;
#pragma warning disable 0169
		static Delegate GetGetPostBodyBytesHandler ()
		{
			if (cb_getPostBodyBytes == null)
				cb_getPostBodyBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostBodyBytes);
			return cb_getPostBodyBytes;
		}

		static IntPtr n_GetPostBodyBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPostBodyBytes ());
		}
#pragma warning restore 0169

		IntPtr id_getPostBodyBytes;
		public byte[] GetPostBodyBytes ()
		{
			if (id_getPostBodyBytes == IntPtr.Zero)
				id_getPostBodyBytes = JNIEnv.GetMethodID (class_ref, "getPostBodyBytes", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getPostBodyBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_removeHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveHeader_Ljava_lang_String_Handler ()
		{
			if (cb_removeHeader_Ljava_lang_String_ == null)
				cb_removeHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveHeader_Ljava_lang_String_);
			return cb_removeHeader_Ljava_lang_String_;
		}

		static IntPtr n_RemoveHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeHeader_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest RemoveHeader (string p0)
		{
			if (id_removeHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_removeHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_removeHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_Handler ()
		{
			if (cb_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ == null)
				cb_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_);
			return cb_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_;
		}

		static IntPtr n_SetMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMethod (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetMethod (global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod p0)
		{
			if (id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ == IntPtr.Zero)
				id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ = JNIEnv.GetMethodID (class_ref, "setMethod", "(Lcom/amazon/insights/core/http/HttpClient$HttpMethod;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setPostBody_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPostBody_arrayBHandler ()
		{
			if (cb_setPostBody_arrayB == null)
				cb_setPostBody_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostBody_arrayB);
			return cb_setPostBody_arrayB;
		}

		static IntPtr n_SetPostBody_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostBody (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPostBody_arrayB;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (byte[] p0)
		{
			if (id_setPostBody_arrayB == IntPtr.Zero)
				id_setPostBody_arrayB = JNIEnv.GetMethodID (class_ref, "setPostBody", "([B)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_setPostBody_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setPostBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPostBody_Ljava_lang_String_Handler ()
		{
			if (cb_setPostBody_Ljava_lang_String_ == null)
				cb_setPostBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostBody_Ljava_lang_String_);
			return cb_setPostBody_Ljava_lang_String_;
		}

		static IntPtr n_SetPostBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPostBody_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (string p0)
		{
			if (id_setPostBody_Ljava_lang_String_ == IntPtr.Zero)
				id_setPostBody_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostBody", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_setPostBody_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUrl_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetUrl (string p0)
		{
			if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_setUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']"
	[Register ("com/amazon/insights/core/http/HttpClient$Response", "", "Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker")]
	public partial interface IHttpClientResponse : IJavaObject {

		int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest OriginatingRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getOriginatingRequest' and count(parameter)=0]"
			[Register ("getOriginatingRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;", "GetGetOriginatingRequestHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		long RequestSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getRequestSize' and count(parameter)=0]"
			[Register ("getRequestSize", "()J", "GetGetRequestSizeHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		long ResponseSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getResponseSize' and count(parameter)=0]"
			[Register ("getResponseSize", "()J", "GetGetResponseSizeHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse AddHeader (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='getHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeader", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeader_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		string GetHeader (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCode", "(I)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetCode_IHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetCode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetMessage_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetMessage (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setOriginatingRequest' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("setOriginatingRequest", "(Lcom/amazon/insights/core/http/HttpClient$Request;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_Handler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetOriginatingRequest (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setRequestSize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setRequestSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetRequestSize_JHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetRequestSize (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResponse", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetResponse_Ljava_lang_String_Handler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponse (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='setResponseSize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setResponseSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetResponseSize_JHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponseSize (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient.Response']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Com.Amazon.Insights.Core.Http.IHttpClientResponseInvoker, AmazonInsights.MonoDroid")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpClient$Response", DoNotGenerateAcw=true)]
	internal class IHttpClientResponseInvoker : global::Java.Lang.Object, IHttpClientResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/http/HttpClient$Response");
		IntPtr class_ref;

		public static IHttpClientResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpClientResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.http.HttpClient.Response"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpClientResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpClientResponseInvoker); }
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		IntPtr id_getCode;
		public int Code {
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCode);
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		public global::System.Collections.Generic.IDictionary<string, string> Headers {
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOriginatingRequest;
#pragma warning disable 0169
		static Delegate GetGetOriginatingRequestHandler ()
		{
			if (cb_getOriginatingRequest == null)
				cb_getOriginatingRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginatingRequest);
			return cb_getOriginatingRequest;
		}

		static IntPtr n_GetOriginatingRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OriginatingRequest);
		}
#pragma warning restore 0169

		IntPtr id_getOriginatingRequest;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest OriginatingRequest {
			get {
				if (id_getOriginatingRequest == IntPtr.Zero)
					id_getOriginatingRequest = JNIEnv.GetMethodID (class_ref, "getOriginatingRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_getOriginatingRequest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestSize;
#pragma warning disable 0169
		static Delegate GetGetRequestSizeHandler ()
		{
			if (cb_getRequestSize == null)
				cb_getRequestSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestSize);
			return cb_getRequestSize;
		}

		static long n_GetRequestSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestSize;
		}
#pragma warning restore 0169

		IntPtr id_getRequestSize;
		public long RequestSize {
			get {
				if (id_getRequestSize == IntPtr.Zero)
					id_getRequestSize = JNIEnv.GetMethodID (class_ref, "getRequestSize", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRequestSize);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public string Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponseSize;
#pragma warning disable 0169
		static Delegate GetGetResponseSizeHandler ()
		{
			if (cb_getResponseSize == null)
				cb_getResponseSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetResponseSize);
			return cb_getResponseSize;
		}

		static long n_GetResponseSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseSize;
		}
#pragma warning restore 0169

		IntPtr id_getResponseSize;
		public long ResponseSize {
			get {
				if (id_getResponseSize == IntPtr.Zero)
					id_getResponseSize = JNIEnv.GetMethodID (class_ref, "getResponseSize", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getResponseSize);
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHeader_Ljava_lang_String_Handler ()
		{
			if (cb_getHeader_Ljava_lang_String_ == null)
				cb_getHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeader_Ljava_lang_String_);
			return cb_getHeader_Ljava_lang_String_;
		}

		static IntPtr n_GetHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeader_Ljava_lang_String_;
		public string GetHeader (string p0)
		{
			if (id_getHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeader", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setCode_I;
#pragma warning disable 0169
		static Delegate GetSetCode_IHandler ()
		{
			if (cb_setCode_I == null)
				cb_setCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCode_I);
			return cb_setCode_I;
		}

		static IntPtr n_SetCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCode (p0));
		}
#pragma warning restore 0169

		IntPtr id_setCode_I;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetCode (int p0)
		{
			if (id_setCode_I == IntPtr.Zero)
				id_setCode_I = JNIEnv.GetMethodID (class_ref, "setCode", "(I)Lcom/amazon/insights/core/http/HttpClient$Response;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setMessage_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetMessage (string p0)
		{
			if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_;
#pragma warning disable 0169
		static Delegate GetSetOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_Handler ()
		{
			if (cb_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ == null)
				cb_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_);
			return cb_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_;
		}

		static IntPtr n_SetOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOriginatingRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetOriginatingRequest (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "setOriginatingRequest", "(Lcom/amazon/insights/core/http/HttpClient$Request;)Lcom/amazon/insights/core/http/HttpClient$Response;");
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRequestSize_J;
#pragma warning disable 0169
		static Delegate GetSetRequestSize_JHandler ()
		{
			if (cb_setRequestSize_J == null)
				cb_setRequestSize_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetRequestSize_J);
			return cb_setRequestSize_J;
		}

		static IntPtr n_SetRequestSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRequestSize (p0));
		}
#pragma warning restore 0169

		IntPtr id_setRequestSize_J;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetRequestSize (long p0)
		{
			if (id_setRequestSize_J == IntPtr.Zero)
				id_setRequestSize_J = JNIEnv.GetMethodID (class_ref, "setRequestSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setRequestSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setResponse_Ljava_lang_String_ == null)
				cb_setResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResponse_Ljava_lang_String_);
			return cb_setResponse_Ljava_lang_String_;
		}

		static IntPtr n_SetResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setResponse_Ljava_lang_String_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponse (string p0)
		{
			if (id_setResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_setResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setResponse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setResponseSize_J;
#pragma warning disable 0169
		static Delegate GetSetResponseSize_JHandler ()
		{
			if (cb_setResponseSize_J == null)
				cb_setResponseSize_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetResponseSize_J);
			return cb_setResponseSize_J;
		}

		static IntPtr n_SetResponseSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetResponseSize (p0));
		}
#pragma warning restore 0169

		IntPtr id_setResponseSize_J;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponseSize (long p0)
		{
			if (id_setResponseSize_J == IntPtr.Zero)
				id_setResponseSize_J = JNIEnv.GetMethodID (class_ref, "setResponseSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_setResponseSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient']"
	[Register ("com/amazon/insights/core/http/HttpClient", "", "Com.Amazon.Insights.Core.Http.IHttpClientInvoker")]
	public partial interface IHttpClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient']/method[@name='addInterceptor' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Interceptor']]"
		[Register ("addInterceptor", "(Lcom/amazon/insights/core/http/HttpClient$Interceptor;)V", "GetAddInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_Handler:Com.Amazon.Insights.Core.Http.IHttpClientInvoker, AmazonInsights.MonoDroid")]
		void AddInterceptor (global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("execute", "(Lcom/amazon/insights/core/http/HttpClient$Request;Ljava/lang/Integer;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetExecute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_Handler:Com.Amazon.Insights.Core.Http.IHttpClientInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientResponse Execute (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0, global::Java.Lang.Integer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/interface[@name='HttpClient']/method[@name='newRequest' and count(parameter)=0]"
		[Register ("newRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;", "GetNewRequestHandler:Com.Amazon.Insights.Core.Http.IHttpClientInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Http.IHttpClientRequest NewRequest ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/http/HttpClient", DoNotGenerateAcw=true)]
	internal class IHttpClientInvoker : global::Java.Lang.Object, IHttpClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/http/HttpClient");
		IntPtr class_ref;

		public static IHttpClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.http.HttpClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpClientInvoker); }
		}

		static Delegate cb_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_;
#pragma warning disable 0169
		static Delegate GetAddInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_Handler ()
		{
			if (cb_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ == null)
				cb_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_);
			return cb_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_;
		}

		static void n_AddInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInterceptor (p0);
		}
#pragma warning restore 0169

		IntPtr id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_;
		public void AddInterceptor (global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor p0)
		{
			if (id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ == IntPtr.Zero)
				id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ = JNIEnv.GetMethodID (class_ref, "addInterceptor", "(Lcom/amazon/insights/core/http/HttpClient$Interceptor;)V");
			JNIEnv.CallVoidMethod (Handle, id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_, new JValue (p0));
		}

		static Delegate cb_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_Handler ()
		{
			if (cb_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ == null)
				cb_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_);
			return cb_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_;
		}

		static IntPtr n_Execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientResponse Execute (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0, global::Java.Lang.Integer p1)
		{
			if (id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ == IntPtr.Zero)
				id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/amazon/insights/core/http/HttpClient$Request;Ljava/lang/Integer;)Lcom/amazon/insights/core/http/HttpClient$Response;");
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod (Handle, id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newRequest;
#pragma warning disable 0169
		static Delegate GetNewRequestHandler ()
		{
			if (cb_newRequest == null)
				cb_newRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewRequest);
			return cb_newRequest;
		}

		static IntPtr n_NewRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.IHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewRequest ());
		}
#pragma warning restore 0169

		IntPtr id_newRequest;
		public global::Com.Amazon.Insights.Core.Http.IHttpClientRequest NewRequest ()
		{
			if (id_newRequest == IntPtr.Zero)
				id_newRequest = JNIEnv.GetMethodID (class_ref, "newRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod (Handle, id_newRequest), JniHandleOwnership.TransferLocalRef);
		}

	}

}
