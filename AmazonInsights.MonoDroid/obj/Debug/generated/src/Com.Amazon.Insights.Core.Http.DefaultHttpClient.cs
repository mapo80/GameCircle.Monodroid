using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/DefaultHttpClient", DoNotGenerateAcw=true)]
	public partial class DefaultHttpClient : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/field[@name='DATE_HEADER']"
		[Register ("DATE_HEADER")]
		public const string DateHeader = (string) "Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/field[@name='IO_EXCEPTION_RESPONSE_CODE']"
		[Register ("IO_EXCEPTION_RESPONSE_CODE")]
		public const int IoExceptionResponseCode = (int) -1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/field[@name='REQUESTATTEMPTS_HEADER']"
		[Register ("REQUESTATTEMPTS_HEADER")]
		public const string RequestattemptsHeader = (string) "x-amzn-RequestAttempts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/field[@name='REQUESTTIME_HEADER']"
		[Register ("REQUESTTIME_HEADER")]
		public const string RequesttimeHeader = (string) "x-amzn-RequestTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/field[@name='SERVERINFO_HEADER']"
		[Register ("SERVERINFO_HEADER")]
		public const string ServerinfoHeader = (string) "x-amzn-ServerInfo";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/http/DefaultHttpClient$DefaultRequest", DoNotGenerateAcw=true)]
		public partial class DefaultRequest : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientRequest {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/http/DefaultHttpClient$DefaultRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultRequest); }
			}

			protected DefaultRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/constructor[@name='DefaultHttpClient.DefaultRequest' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public DefaultRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DefaultRequest)) {
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
			}
#pragma warning restore 0169

			static IntPtr id_getHeaders;
			public virtual global::System.Collections.Generic.IDictionary<string, string> Headers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getHeaders' and count(parameter)=0]"
				[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
				get {
					if (id_getHeaders == IntPtr.Zero)
						id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHeaders), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Method);
			}
#pragma warning restore 0169

			static IntPtr id_getMethod;
			public virtual global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod Method {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getMethod' and count(parameter)=0]"
				[Register ("getMethod", "()Lcom/amazon/insights/core/http/HttpClient$HttpMethod;", "GetGetMethodHandler")]
				get {
					if (id_getMethod == IntPtr.Zero)
						id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Lcom/amazon/insights/core/http/HttpClient$HttpMethod;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (JNIEnv.CallObjectMethod  (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMethod), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Params);
			}
#pragma warning restore 0169

			static IntPtr id_getParams;
			public virtual global::System.Collections.Generic.IDictionary<string, string> Params {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getParams' and count(parameter)=0]"
				[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler")]
				get {
					if (id_getParams == IntPtr.Zero)
						id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/Map;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getParams), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PostBody);
			}
#pragma warning restore 0169

			static IntPtr id_getPostBody;
			public virtual string PostBody {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getPostBody' and count(parameter)=0]"
				[Register ("getPostBody", "()Ljava/lang/String;", "GetGetPostBodyHandler")]
				get {
					if (id_getPostBody == IntPtr.Zero)
						id_getPostBody = JNIEnv.GetMethodID (class_ref, "getPostBody", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPostBody), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPostBody), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Url);
			}
#pragma warning restore 0169

			static IntPtr id_getUrl;
			public virtual string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
				get {
					if (id_getUrl == IntPtr.Zero)
						id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUrl), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddHeader (string p0, string p1)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddParam (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addParam_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest AddParam (string p0, string p1)
			{
				if (id_addParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_addParam_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addParam_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetPostBodyBytes ());
			}
#pragma warning restore 0169

			static IntPtr id_getPostBodyBytes;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='getPostBodyBytes' and count(parameter)=0]"
			[Register ("getPostBodyBytes", "()[B", "GetGetPostBodyBytesHandler")]
			public virtual byte[] GetPostBodyBytes ()
			{
				if (id_getPostBodyBytes == IntPtr.Zero)
					id_getPostBodyBytes = JNIEnv.GetMethodID (class_ref, "getPostBodyBytes", "()[B");

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPostBodyBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPostBodyBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveHeader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_removeHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetRemoveHeader_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest RemoveHeader (string p0)
			{
				if (id_removeHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_removeHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_removeHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_removeHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMethod (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.HttpMethod']]"
			[Register ("setMethod", "(Lcom/amazon/insights/core/http/HttpClient$HttpMethod;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetMethod (global::Com.Amazon.Insights.Core.Http.HttpClientHttpMethod p0)
			{
				if (id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ == IntPtr.Zero)
					id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_ = JNIEnv.GetMethodID (class_ref, "setMethod", "(Lcom/amazon/insights/core/http/HttpClient$HttpMethod;)Lcom/amazon/insights/core/http/HttpClient$Request;");

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setMethod_Lcom_amazon_insights_core_http_HttpClient_HttpMethod_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostBody (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPostBody_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='setPostBody' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setPostBody", "([B)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetPostBody_arrayBHandler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (byte[] p0)
			{
				if (id_setPostBody_arrayB == IntPtr.Zero)
					id_setPostBody_arrayB = JNIEnv.GetMethodID (class_ref, "setPostBody", "([B)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_setPostBody_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPostBody_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostBody (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPostBody_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='setPostBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPostBody", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetPostBody_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetPostBody (string p0)
			{
				if (id_setPostBody_Ljava_lang_String_ == IntPtr.Zero)
					id_setPostBody_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostBody", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_setPostBody_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setPostBody_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultRequest']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;", "GetSetUrl_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest SetUrl (string p0)
			{
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Request;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_setUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/http/DefaultHttpClient$DefaultResponse", DoNotGenerateAcw=true)]
		public partial class DefaultResponse : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientResponse {


			static IntPtr headersMap_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/field[@name='headersMap']"
			[Register ("headersMap")]
			protected global::System.Collections.IDictionary HeadersMap {
				get {
					if (headersMap_jfieldId == IntPtr.Zero)
						headersMap_jfieldId = JNIEnv.GetFieldID (class_ref, "headersMap", "Ljava/util/Map;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, headersMap_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (headersMap_jfieldId == IntPtr.Zero)
						headersMap_jfieldId = JNIEnv.GetFieldID (class_ref, "headersMap", "Ljava/util/Map;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, headersMap_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/http/DefaultHttpClient$DefaultResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultResponse); }
			}

			protected DefaultResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/constructor[@name='DefaultHttpClient.DefaultResponse' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public DefaultResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DefaultResponse)) {
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Code;
			}
#pragma warning restore 0169

			static IntPtr id_getCode;
			public virtual int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getCode);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
			}
#pragma warning restore 0169

			static IntPtr id_getHeaders;
			public virtual global::System.Collections.Generic.IDictionary<string, string> Headers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getHeaders' and count(parameter)=0]"
				[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
				get {
					if (id_getHeaders == IntPtr.Zero)
						id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHeaders), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			static IntPtr id_getMessage;
			public virtual string Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					if (id_getMessage == IntPtr.Zero)
						id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OriginatingRequest);
			}
#pragma warning restore 0169

			static IntPtr id_getOriginatingRequest;
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest OriginatingRequest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getOriginatingRequest' and count(parameter)=0]"
				[Register ("getOriginatingRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;", "GetGetOriginatingRequestHandler")]
				get {
					if (id_getOriginatingRequest == IntPtr.Zero)
						id_getOriginatingRequest = JNIEnv.GetMethodID (class_ref, "getOriginatingRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_getOriginatingRequest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOriginatingRequest), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RequestSize;
			}
#pragma warning restore 0169

			static IntPtr id_getRequestSize;
			public virtual long RequestSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getRequestSize' and count(parameter)=0]"
				[Register ("getRequestSize", "()J", "GetGetRequestSizeHandler")]
				get {
					if (id_getRequestSize == IntPtr.Zero)
						id_getRequestSize = JNIEnv.GetMethodID (class_ref, "getRequestSize", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getRequestSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getRequestSize);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Response);
			}
#pragma warning restore 0169

			static IntPtr id_getResponse;
			public virtual string Response {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getResponse' and count(parameter)=0]"
				[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
				get {
					if (id_getResponse == IntPtr.Zero)
						id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponse), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ResponseSize;
			}
#pragma warning restore 0169

			static IntPtr id_getResponseSize;
			public virtual long ResponseSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getResponseSize' and count(parameter)=0]"
				[Register ("getResponseSize", "()J", "GetGetResponseSizeHandler")]
				get {
					if (id_getResponseSize == IntPtr.Zero)
						id_getResponseSize = JNIEnv.GetMethodID (class_ref, "getResponseSize", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getResponseSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getResponseSize);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse AddHeader (string p0, string p1)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetHeader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='getHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getHeader", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeader_Ljava_lang_String_Handler")]
			public virtual string GetHeader (string p0)
			{
				if (id_getHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_getHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeader", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCode (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setCode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCode", "(I)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetCode_IHandler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetCode (int p0)
			{
				if (id_setCode_I == IntPtr.Zero)
					id_setCode_I = JNIEnv.GetMethodID (class_ref, "setCode", "(I)Lcom/amazon/insights/core/http/HttpClient$Response;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMessage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetMessage_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetMessage (string p0)
			{
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOriginatingRequest (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setOriginatingRequest' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
			[Register ("setOriginatingRequest", "(Lcom/amazon/insights/core/http/HttpClient$Request;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetOriginatingRequest (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
			{
				if (id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
					id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "setOriginatingRequest", "(Lcom/amazon/insights/core/http/HttpClient$Request;)Lcom/amazon/insights/core/http/HttpClient$Response;");

				global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setOriginatingRequest_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRequestSize (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setRequestSize_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setRequestSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRequestSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetRequestSize_JHandler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetRequestSize (long p0)
			{
				if (id_setRequestSize_J == IntPtr.Zero)
					id_setRequestSize_J = JNIEnv.GetMethodID (class_ref, "setRequestSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setRequestSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setRequestSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponse (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setResponse_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponse", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetResponse_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponse (string p0)
			{
				if (id_setResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Ljava/lang/String;)Lcom/amazon/insights/core/http/HttpClient$Response;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setResponse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setResponse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient.DefaultResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetResponseSize (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setResponseSize_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient.DefaultResponse']/method[@name='setResponseSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setResponseSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetSetResponseSize_JHandler")]
			public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse SetResponseSize (long p0)
			{
				if (id_setResponseSize_J == IntPtr.Zero)
					id_setResponseSize_J = JNIEnv.GetMethodID (class_ref, "setResponseSize", "(J)Lcom/amazon/insights/core/http/HttpClient$Response;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_setResponseSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setResponseSize_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/DefaultHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultHttpClient); }
		}

		protected DefaultHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/constructor[@name='DefaultHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultHttpClient () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultHttpClient)) {
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
			global::Com.Amazon.Insights.Core.Http.DefaultHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInterceptor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/method[@name='addInterceptor' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Interceptor']]"
		[Register ("addInterceptor", "(Lcom/amazon/insights/core/http/HttpClient$Interceptor;)V", "GetAddInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_Handler")]
		public virtual void AddInterceptor (global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor p0)
		{
			if (id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ == IntPtr.Zero)
				id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_ = JNIEnv.GetMethodID (class_ref, "addInterceptor", "(Lcom/amazon/insights/core/http/HttpClient$Interceptor;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addInterceptor_Lcom_amazon_insights_core_http_HttpClient_Interceptor_, new JValue (p0));
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
			global::Com.Amazon.Insights.Core.Http.DefaultHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("execute", "(Lcom/amazon/insights/core/http/HttpClient$Request;Ljava/lang/Integer;)Lcom/amazon/insights/core/http/HttpClient$Response;", "GetExecute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_Handler")]
		public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientResponse Execute (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0, global::Java.Lang.Integer p1)
		{
			if (id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ == IntPtr.Zero)
				id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/amazon/insights/core/http/HttpClient$Request;Ljava/lang/Integer;)Lcom/amazon/insights/core/http/HttpClient$Response;");

			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallObjectMethod  (Handle, id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_execute_Lcom_amazon_insights_core_http_HttpClient_Request_Ljava_lang_Integer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.Http.DefaultHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.DefaultHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewRequest ());
		}
#pragma warning restore 0169

		static IntPtr id_newRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='DefaultHttpClient']/method[@name='newRequest' and count(parameter)=0]"
		[Register ("newRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;", "GetNewRequestHandler")]
		public virtual global::Com.Amazon.Insights.Core.Http.IHttpClientRequest NewRequest ()
		{
			if (id_newRequest == IntPtr.Zero)
				id_newRequest = JNIEnv.GetMethodID (class_ref, "newRequest", "()Lcom/amazon/insights/core/http/HttpClient$Request;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallObjectMethod  (Handle, id_newRequest), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newRequest), JniHandleOwnership.TransferLocalRef);
		}

	}
}
