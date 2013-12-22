using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractTokenRequest", DoNotGenerateAcw=true)]
	public abstract partial class AbstractTokenRequest : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		public const string AccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='ANDROID_OS_NAME']"
		[Register ("ANDROID_OS_NAME")]
		public const string AndroidOsName = (string) "Android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='APP_NAME']"
		[Register ("APP_NAME")]
		public const string AppName = (string) "app_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='APP_VERSION']"
		[Register ("APP_VERSION")]
		public const string AppVersion = (string) "app_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='AUTH_COOKIES']"
		[Register ("AUTH_COOKIES")]
		public const string AuthCookies = (string) "auth_cookies";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DEFAULT_DOMAIN']"
		[Register ("DEFAULT_DOMAIN")]
		public const string DefaultDomain = (string) ".amazon.com";

		static IntPtr DEFAULT_USER_AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DEFAULT_USER_AGENT']"
		[Register ("DEFAULT_USER_AGENT")]
		public static string DefaultUserAgent {
			get {
				if (DEFAULT_USER_AGENT_jfieldId == IntPtr.Zero)
					DEFAULT_USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_USER_AGENT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_USER_AGENT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_USER_AGENT_jfieldId == IntPtr.Zero)
					DEFAULT_USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_USER_AGENT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_USER_AGENT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEFAULT_WEBVIEW_USER_AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DEFAULT_WEBVIEW_USER_AGENT']"
		[Register ("DEFAULT_WEBVIEW_USER_AGENT")]
		public static string DefaultWebviewUserAgent {
			get {
				if (DEFAULT_WEBVIEW_USER_AGENT_jfieldId == IntPtr.Zero)
					DEFAULT_WEBVIEW_USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_WEBVIEW_USER_AGENT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_WEBVIEW_USER_AGENT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_WEBVIEW_USER_AGENT_jfieldId == IntPtr.Zero)
					DEFAULT_WEBVIEW_USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_WEBVIEW_USER_AGENT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_WEBVIEW_USER_AGENT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DEVO_PREFIX']"
		[Register ("DEVO_PREFIX")]
		public const string DevoPrefix = (string) "development";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DEV_PORT']"
		[Register ("DEV_PORT")]
		public const int DevPort = (int) 443;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DI_HW_NAME']"
		[Register ("DI_HW_NAME")]
		public const string DiHwName = (string) "di.hw.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DI_HW_VERSION']"
		[Register ("DI_HW_VERSION")]
		public const string DiHwVersion = (string) "di.hw.version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DI_OS_NAME']"
		[Register ("DI_OS_NAME")]
		public const string DiOsName = (string) "di.os.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DI_OS_VERSION']"
		[Register ("DI_OS_VERSION")]
		public const string DiOsVersion = (string) "di.os.version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DI_SDK_VERSION']"
		[Register ("DI_SDK_VERSION")]
		public const string DiSdkVersion = (string) "di.sdk.version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='DMS_TOKEN']"
		[Register ("DMS_TOKEN")]
		public const string DmsToken = (string) "dms_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='EXCHANGE_END_POINT']"
		[Register ("EXCHANGE_END_POINT")]
		public const string ExchangeEndPoint = (string) "/ap/exchangetoken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='HTTPS']"
		[Register ("HTTPS")]
		public const string Https = (string) "https";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='MAX_NUM_POST_PARAMS']"
		[Register ("MAX_NUM_POST_PARAMS")]
		protected const int MaxNumPostParams = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='NUM_RETRY_ATTEMPTS']"
		[Register ("NUM_RETRY_ATTEMPTS")]
		protected const int NumRetryAttempts = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='PORT_SEPERATOR']"
		[Register ("PORT_SEPERATOR")]
		protected const string PortSeperator = (string) ":";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='POST']"
		[Register ("POST")]
		protected const string Post = (string) "POST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='PRE_PROD_PREFIX']"
		[Register ("PRE_PROD_PREFIX")]
		public const string PreProdPrefix = (string) "pre-prod";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='PROD_PORT']"
		[Register ("PROD_PORT")]
		public const int ProdPort = (int) 443;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='PROD_PREFIX']"
		[Register ("PROD_PREFIX")]
		public const string ProdPrefix = (string) "www";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='REFRESH_TOKEN']"
		[Register ("REFRESH_TOKEN")]
		public const string RefreshToken = (string) "refresh_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='REQUESTED_TOKEN_TYPE']"
		[Register ("REQUESTED_TOKEN_TYPE")]
		public const string RequestedTokenType = (string) "requested_token_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='RESP_COOKIES']"
		[Register ("RESP_COOKIES")]
		public const string RespCookies = (string) "cookies";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='RESP_TOKENS']"
		[Register ("RESP_TOKENS")]
		public const string RespTokens = (string) "tokens";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='REVOKE_END_POINT']"
		[Register ("REVOKE_END_POINT")]
		public const string RevokeEndPoint = (string) "/auth/signout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='SOURCE_TOKEN']"
		[Register ("SOURCE_TOKEN")]
		public const string SourceToken = (string) "source_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='SOURCE_TOKEN_TYPE']"
		[Register ("SOURCE_TOKEN_TYPE")]
		public const string SourceTokenType = (string) "source_token_type";

		static IntPtr _headers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='_headers']"
		[Register ("_headers")]
		protected global::System.Collections.IList Headers {
			get {
				if (_headers_jfieldId == IntPtr.Zero)
					_headers_jfieldId = JNIEnv.GetFieldID (class_ref, "_headers", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, _headers_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (_headers_jfieldId == IntPtr.Zero)
					_headers_jfieldId = JNIEnv.GetFieldID (class_ref, "_headers", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, _headers_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr httpClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='httpClient']"
		[Register ("httpClient")]
		protected global::Org.Apache.Http.Client.IHttpClient HttpClient {
			get {
				if (httpClient_jfieldId == IntPtr.Zero)
					httpClient_jfieldId = JNIEnv.GetFieldID (class_ref, "httpClient", "Lorg/apache/http/client/HttpClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, httpClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (httpClient_jfieldId == IntPtr.Zero)
					httpClient_jfieldId = JNIEnv.GetFieldID (class_ref, "httpClient", "Lorg/apache/http/client/HttpClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, httpClient_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mHttpRequest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/field[@name='mHttpRequest']"
		[Register ("mHttpRequest")]
		protected global::Org.Apache.Http.Client.Methods.HttpRequestBase MHttpRequest {
			get {
				if (mHttpRequest_jfieldId == IntPtr.Zero)
					mHttpRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "mHttpRequest", "Lorg/apache/http/client/methods/HttpRequestBase;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHttpRequest_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHttpRequest_jfieldId == IntPtr.Zero)
					mHttpRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "mHttpRequest", "Lorg/apache/http/client/methods/HttpRequestBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mHttpRequest_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest.GzipDecompressingEntity']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractTokenRequest$GzipDecompressingEntity", DoNotGenerateAcw=true)]
		public partial class GzipDecompressingEntity : global::Org.Apache.Http.Entity.HttpEntityWrapper {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/AbstractTokenRequest$GzipDecompressingEntity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GzipDecompressingEntity); }
			}

			protected GzipDecompressingEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_apache_http_HttpEntity_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest.GzipDecompressingEntity']/constructor[@name='AbstractTokenRequest.GzipDecompressingEntity' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpEntity']]"
			[Register (".ctor", "(Lorg/apache/http/HttpEntity;)V", "")]
			public GzipDecompressingEntity (global::Org.Apache.Http.IHttpEntity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (GzipDecompressingEntity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/HttpEntity;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/HttpEntity;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lorg_apache_http_HttpEntity_ == IntPtr.Zero)
					id_ctor_Lorg_apache_http_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/HttpEntity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_HttpEntity_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_HttpEntity_, new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/AbstractTokenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractTokenRequest); }
		}

		protected AbstractTokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/constructor[@name='AbstractTokenRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public AbstractTokenRequest (string p0, string p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (AbstractTokenRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getDefaultHeaders;
#pragma warning disable 0169
		static Delegate GetGetDefaultHeadersHandler ()
		{
			if (cb_getDefaultHeaders == null)
				cb_getDefaultHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultHeaders);
			return cb_getDefaultHeaders;
		}

		static IntPtr n_GetDefaultHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Http.IHeader>.ToLocalJniHandle (__this.DefaultHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultHeaders;
		protected virtual global::System.Collections.Generic.IList<global::Org.Apache.Http.IHeader> DefaultHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getDefaultHeaders' and count(parameter)=0]"
			[Register ("getDefaultHeaders", "()Ljava/util/List;", "GetGetDefaultHeadersHandler")]
			get {
				if (id_getDefaultHeaders == IntPtr.Zero)
					id_getDefaultHeaders = JNIEnv.GetMethodID (class_ref, "getDefaultHeaders", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Apache.Http.IHeader>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDefaultHeaders), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Apache.Http.IHeader>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDefaultHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDefaultHttpResponseInterceptor;
#pragma warning disable 0169
		static Delegate GetGetDefaultHttpResponseInterceptorHandler ()
		{
			if (cb_getDefaultHttpResponseInterceptor == null)
				cb_getDefaultHttpResponseInterceptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultHttpResponseInterceptor);
			return cb_getDefaultHttpResponseInterceptor;
		}

		static IntPtr n_GetDefaultHttpResponseInterceptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultHttpResponseInterceptor);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultHttpResponseInterceptor;
		protected virtual global::Org.Apache.Http.IHttpResponseInterceptor DefaultHttpResponseInterceptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getDefaultHttpResponseInterceptor' and count(parameter)=0]"
			[Register ("getDefaultHttpResponseInterceptor", "()Lorg/apache/http/HttpResponseInterceptor;", "GetGetDefaultHttpResponseInterceptorHandler")]
			get {
				if (id_getDefaultHttpResponseInterceptor == IntPtr.Zero)
					id_getDefaultHttpResponseInterceptor = JNIEnv.GetMethodID (class_ref, "getDefaultHttpResponseInterceptor", "()Lorg/apache/http/HttpResponseInterceptor;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponseInterceptor> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultHttpResponseInterceptor), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponseInterceptor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDefaultHttpResponseInterceptor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static Delegate cb_setDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDomain_Ljava_lang_String_Handler ()
		{
			if (cb_setDomain_Ljava_lang_String_ == null)
				cb_setDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDomain_Ljava_lang_String_);
			return cb_setDomain_Ljava_lang_String_;
		}

		static void n_SetDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Domain = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		static IntPtr id_setDomain_Ljava_lang_String_;
		public virtual string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDomain), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDomain", "(Ljava/lang/String;)V", "GetSetDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDomain_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDomain_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getEndPoint;
#pragma warning disable 0169
		static Delegate GetGetEndPointHandler ()
		{
			if (cb_getEndPoint == null)
				cb_getEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndPoint);
			return cb_getEndPoint;
		}

		static IntPtr n_GetEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndPoint);
		}
#pragma warning restore 0169

		public abstract string EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Ljava/lang/String;", "GetGetEndPointHandler")] get;
		}

		static Delegate cb_getEntity;
#pragma warning disable 0169
		static Delegate GetGetEntityHandler ()
		{
			if (cb_getEntity == null)
				cb_getEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntity);
			return cb_getEntity;
		}

		static IntPtr n_GetEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Entity);
		}
#pragma warning restore 0169

		static IntPtr id_getEntity;
		public virtual global::Org.Apache.Http.Entity.StringEntity Entity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getEntity' and count(parameter)=0]"
			[Register ("getEntity", "()Lorg/apache/http/entity/StringEntity;", "GetGetEntityHandler")]
			get {
				if (id_getEntity == IntPtr.Zero)
					id_getEntity = JNIEnv.GetMethodID (class_ref, "getEntity", "()Lorg/apache/http/entity/StringEntity;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Entity.StringEntity> (JNIEnv.CallObjectMethod  (Handle, id_getEntity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Entity.StringEntity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEntity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static IntPtr id_getPort;
		public virtual int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPort);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getPort);
			}
		}

		static Delegate cb_getPostParameters;
#pragma warning disable 0169
		static Delegate GetGetPostParametersHandler ()
		{
			if (cb_getPostParameters == null)
				cb_getPostParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostParameters);
			return cb_getPostParameters;
		}

		static IntPtr n_GetPostParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (__this.PostParameters);
		}
#pragma warning restore 0169

		static IntPtr id_getPostParameters;
		public virtual global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> PostParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getPostParameters' and count(parameter)=0]"
			[Register ("getPostParameters", "()Ljava/util/List;", "GetGetPostParametersHandler")]
			get {
				if (id_getPostParameters == IntPtr.Zero)
					id_getPostParameters = JNIEnv.GetMethodID (class_ref, "getPostParameters", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPostParameters), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPostParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		public virtual global::Org.Apache.Http.Client.Methods.HttpRequestBase Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lorg/apache/http/client/methods/HttpRequestBase;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lorg/apache/http/client/methods/HttpRequestBase;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallObjectMethod  (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRequest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRequestPort;
		public static int RequestPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getRequestPort' and count(parameter)=0]"
			[Register ("getRequestPort", "()I", "GetGetRequestPortHandler")]
			get {
				if (id_getRequestPort == IntPtr.Zero)
					id_getRequestPort = JNIEnv.GetStaticMethodID (class_ref, "getRequestPort", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getRequestPort);
			}
		}

		static Delegate cb_getRequestUrl;
#pragma warning disable 0169
		static Delegate GetGetRequestUrlHandler ()
		{
			if (cb_getRequestUrl == null)
				cb_getRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrl);
			return cb_getRequestUrl;
		}

		static IntPtr n_GetRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestUrl;
		public virtual string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler")]
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVerbAsString;
#pragma warning disable 0169
		static Delegate GetGetVerbAsStringHandler ()
		{
			if (cb_getVerbAsString == null)
				cb_getVerbAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerbAsString);
			return cb_getVerbAsString;
		}

		static IntPtr n_GetVerbAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerbAsString);
		}
#pragma warning restore 0169

		static IntPtr id_getVerbAsString;
		public virtual string VerbAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getVerbAsString' and count(parameter)=0]"
			[Register ("getVerbAsString", "()Ljava/lang/String;", "GetGetVerbAsStringHandler")]
			get {
				if (id_getVerbAsString == IntPtr.Zero)
					id_getVerbAsString = JNIEnv.GetMethodID (class_ref, "getVerbAsString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVerbAsString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVerbAsString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAppInfoParameters;
#pragma warning disable 0169
		static Delegate GetAddAppInfoParametersHandler ()
		{
			if (cb_addAppInfoParameters == null)
				cb_addAppInfoParameters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddAppInfoParameters);
			return cb_addAppInfoParameters;
		}

		static void n_AddAppInfoParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddAppInfoParameters ();
		}
#pragma warning restore 0169

		static IntPtr id_addAppInfoParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addAppInfoParameters' and count(parameter)=0]"
		[Register ("addAppInfoParameters", "()V", "GetAddAppInfoParametersHandler")]
		protected virtual void AddAppInfoParameters ()
		{
			if (id_addAppInfoParameters == IntPtr.Zero)
				id_addAppInfoParameters = JNIEnv.GetMethodID (class_ref, "addAppInfoParameters", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAppInfoParameters);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addAppInfoParameters);
		}

		static Delegate cb_addDeviceParams;
#pragma warning disable 0169
		static Delegate GetAddDeviceParamsHandler ()
		{
			if (cb_addDeviceParams == null)
				cb_addDeviceParams = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddDeviceParams);
			return cb_addDeviceParams;
		}

		static void n_AddDeviceParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddDeviceParams ();
		}
#pragma warning restore 0169

		static IntPtr id_addDeviceParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addDeviceParams' and count(parameter)=0]"
		[Register ("addDeviceParams", "()V", "GetAddDeviceParamsHandler")]
		protected virtual void AddDeviceParams ()
		{
			if (id_addDeviceParams == IntPtr.Zero)
				id_addDeviceParams = JNIEnv.GetMethodID (class_ref, "addDeviceParams", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addDeviceParams);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addDeviceParams);
		}

		static Delegate cb_addHeader_Lorg_apache_http_Header_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Lorg_apache_http_Header_Handler ()
		{
			if (cb_addHeader_Lorg_apache_http_Header_ == null)
				cb_addHeader_Lorg_apache_http_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeader_Lorg_apache_http_Header_);
			return cb_addHeader_Lorg_apache_http_Header_;
		}

		static void n_AddHeader_Lorg_apache_http_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHeader p0 = (global::Org.Apache.Http.IHeader)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Lorg_apache_http_Header_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addHeader' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header']]"
		[Register ("addHeader", "(Lorg/apache/http/Header;)V", "GetAddHeader_Lorg_apache_http_Header_Handler")]
		protected virtual void AddHeader (global::Org.Apache.Http.IHeader p0)
		{
			if (id_addHeader_Lorg_apache_http_Header_ == IntPtr.Zero)
				id_addHeader_Lorg_apache_http_Header_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Lorg/apache/http/Header;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addHeader_Lorg_apache_http_Header_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addHeader_Lorg_apache_http_Header_, new JValue (p0));
		}

		static Delegate cb_addRequestInfoParameters;
#pragma warning disable 0169
		static Delegate GetAddRequestInfoParametersHandler ()
		{
			if (cb_addRequestInfoParameters == null)
				cb_addRequestInfoParameters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddRequestInfoParameters);
			return cb_addRequestInfoParameters;
		}

		static void n_AddRequestInfoParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddRequestInfoParameters ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addRequestInfoParameters' and count(parameter)=0]"
		[Register ("addRequestInfoParameters", "()V", "GetAddRequestInfoParametersHandler")]
		protected abstract void AddRequestInfoParameters ();

		static Delegate cb_consumeRequestContent;
#pragma warning disable 0169
		static Delegate GetConsumeRequestContentHandler ()
		{
			if (cb_consumeRequestContent == null)
				cb_consumeRequestContent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConsumeRequestContent);
			return cb_consumeRequestContent;
		}

		static void n_ConsumeRequestContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeRequestContent ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeRequestContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='consumeRequestContent' and count(parameter)=0]"
		[Register ("consumeRequestContent", "()V", "GetConsumeRequestContentHandler")]
		protected virtual void ConsumeRequestContent ()
		{
			if (id_consumeRequestContent == IntPtr.Zero)
				id_consumeRequestContent = JNIEnv.GetMethodID (class_ref, "consumeRequestContent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_consumeRequestContent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_consumeRequestContent);
		}

		static Delegate cb_executeRequest;
#pragma warning disable 0169
		static Delegate GetExecuteRequestHandler ()
		{
			if (cb_executeRequest == null)
				cb_executeRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExecuteRequest);
			return cb_executeRequest;
		}

		static IntPtr n_ExecuteRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecuteRequest ());
		}
#pragma warning restore 0169

		static IntPtr id_executeRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='executeRequest' and count(parameter)=0]"
		[Register ("executeRequest", "()Lorg/apache/http/HttpResponse;", "GetExecuteRequestHandler")]
		public virtual global::Org.Apache.Http.IHttpResponse ExecuteRequest ()
		{
			if (id_executeRequest == IntPtr.Zero)
				id_executeRequest = JNIEnv.GetMethodID (class_ref, "executeRequest", "()Lorg/apache/http/HttpResponse;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_executeRequest), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_executeRequest), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_generateTokenResponse_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler ()
		{
			if (cb_generateTokenResponse_Lorg_apache_http_HttpResponse_ == null)
				cb_generateTokenResponse_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateTokenResponse_Lorg_apache_http_HttpResponse_);
			return cb_generateTokenResponse_Lorg_apache_http_HttpResponse_;
		}

		static IntPtr n_GenerateTokenResponse_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateTokenResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='generateTokenResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler")]
		protected abstract global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse GenerateTokenResponse (global::Org.Apache.Http.IHttpResponse p0);

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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaders ());
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getHeaders' and count(parameter)=0]"
		[Register ("getHeaders", "()[Lorg/apache/http/Header;", "GetGetHeadersHandler")]
		public virtual global::Org.Apache.Http.IHeader[] GetHeaders ()
		{
			if (id_getHeaders == IntPtr.Zero)
				id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()[Lorg/apache/http/Header;");

			if (GetType () == ThresholdType)
				return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
			else
				return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHeaders), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
		}

		static Delegate cb_getHost_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetHost_Landroid_os_Bundle_Handler ()
		{
			if (cb_getHost_Landroid_os_Bundle_ == null)
				cb_getHost_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHost_Landroid_os_Bundle_);
			return cb_getHost_Landroid_os_Bundle_;
		}

		static IntPtr n_GetHost_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHost (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHost_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getHost' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getHost", "(Landroid/os/Bundle;)Ljava/lang/String;", "GetGetHost_Landroid_os_Bundle_Handler")]
		public virtual string GetHost (global::Android.OS.Bundle p0)
		{
			if (id_getHost_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getHost_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getHost", "(Landroid/os/Bundle;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHost_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHost_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRequestHost_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getRequestHost' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getRequestHost", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string GetRequestHost (string p0, global::Android.OS.Bundle p1)
		{
			if (id_getRequestHost_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getRequestHost_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getRequestHost", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRequestHost_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_initializeCookies;
#pragma warning disable 0169
		static Delegate GetInitializeCookiesHandler ()
		{
			if (cb_initializeCookies == null)
				cb_initializeCookies = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeCookies);
			return cb_initializeCookies;
		}

		static void n_InitializeCookies (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeCookies ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeCookies;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='initializeCookies' and count(parameter)=0]"
		[Register ("initializeCookies", "()V", "GetInitializeCookiesHandler")]
		protected virtual void InitializeCookies ()
		{
			if (id_initializeCookies == IntPtr.Zero)
				id_initializeCookies = JNIEnv.GetMethodID (class_ref, "initializeCookies", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializeCookies);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializeCookies);
		}

		static Delegate cb_initializeHeaders;
#pragma warning disable 0169
		static Delegate GetInitializeHeadersHandler ()
		{
			if (cb_initializeHeaders == null)
				cb_initializeHeaders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeHeaders);
			return cb_initializeHeaders;
		}

		static void n_InitializeHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeHeaders ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeHeaders;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='initializeHeaders' and count(parameter)=0]"
		[Register ("initializeHeaders", "()V", "GetInitializeHeadersHandler")]
		public virtual void InitializeHeaders ()
		{
			if (id_initializeHeaders == IntPtr.Zero)
				id_initializeHeaders = JNIEnv.GetMethodID (class_ref, "initializeHeaders", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializeHeaders);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializeHeaders);
		}

		static Delegate cb_initializeHttp;
#pragma warning disable 0169
		static Delegate GetInitializeHttpHandler ()
		{
			if (cb_initializeHttp == null)
				cb_initializeHttp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeHttp);
			return cb_initializeHttp;
		}

		static void n_InitializeHttp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeHttp ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeHttp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='initializeHttp' and count(parameter)=0]"
		[Register ("initializeHttp", "()V", "GetInitializeHttpHandler")]
		public virtual void InitializeHttp ()
		{
			if (id_initializeHttp == IntPtr.Zero)
				id_initializeHttp = JNIEnv.GetMethodID (class_ref, "initializeHttp", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializeHttp);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializeHttp);
		}

		static Delegate cb_initializePostParams;
#pragma warning disable 0169
		static Delegate GetInitializePostParamsHandler ()
		{
			if (cb_initializePostParams == null)
				cb_initializePostParams = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializePostParams);
			return cb_initializePostParams;
		}

		static void n_InitializePostParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializePostParams ();
		}
#pragma warning restore 0169

		static IntPtr id_initializePostParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='initializePostParams' and count(parameter)=0]"
		[Register ("initializePostParams", "()V", "GetInitializePostParamsHandler")]
		public virtual void InitializePostParams ()
		{
			if (id_initializePostParams == IntPtr.Zero)
				id_initializePostParams = JNIEnv.GetMethodID (class_ref, "initializePostParams", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializePostParams);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializePostParams);
		}

		static Delegate cb_initializeUserAgent;
#pragma warning disable 0169
		static Delegate GetInitializeUserAgentHandler ()
		{
			if (cb_initializeUserAgent == null)
				cb_initializeUserAgent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeUserAgent);
			return cb_initializeUserAgent;
		}

		static void n_InitializeUserAgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeUserAgent ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeUserAgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='initializeUserAgent' and count(parameter)=0]"
		[Register ("initializeUserAgent", "()V", "GetInitializeUserAgentHandler")]
		public virtual void InitializeUserAgent ()
		{
			if (id_initializeUserAgent == IntPtr.Zero)
				id_initializeUserAgent = JNIEnv.GetMethodID (class_ref, "initializeUserAgent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializeUserAgent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializeUserAgent);
		}

		static Delegate cb_postExecute_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetPostExecute_Lorg_apache_http_HttpResponse_Handler ()
		{
			if (cb_postExecute_Lorg_apache_http_HttpResponse_ == null)
				cb_postExecute_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostExecute_Lorg_apache_http_HttpResponse_);
			return cb_postExecute_Lorg_apache_http_HttpResponse_;
		}

		static void n_PostExecute_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postExecute_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='postExecute' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("postExecute", "(Lorg/apache/http/HttpResponse;)V", "GetPostExecute_Lorg_apache_http_HttpResponse_Handler")]
		public virtual void PostExecute (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_postExecute_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_postExecute_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "postExecute", "(Lorg/apache/http/HttpResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postExecute_Lorg_apache_http_HttpResponse_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_postExecute_Lorg_apache_http_HttpResponse_, new JValue (p0));
		}

		static Delegate cb_preExecute;
#pragma warning disable 0169
		static Delegate GetPreExecuteHandler ()
		{
			if (cb_preExecute == null)
				cb_preExecute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PreExecute);
			return cb_preExecute;
		}

		static void n_PreExecute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreExecute ();
		}
#pragma warning restore 0169

		static IntPtr id_preExecute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='preExecute' and count(parameter)=0]"
		[Register ("preExecute", "()V", "GetPreExecuteHandler")]
		public virtual void PreExecute ()
		{
			if (id_preExecute == IntPtr.Zero)
				id_preExecute = JNIEnv.GetMethodID (class_ref, "preExecute", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_preExecute);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_preExecute);
		}

		static Delegate cb_setSocketTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetSocketTimeout_IHandler ()
		{
			if (cb_setSocketTimeout_I == null)
				cb_setSocketTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSocketTimeout_I);
			return cb_setSocketTimeout_I;
		}

		static void n_SetSocketTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSocketTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSocketTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='setSocketTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSocketTimeout", "(I)V", "GetSetSocketTimeout_IHandler")]
		public virtual void SetSocketTimeout (int p0)
		{
			if (id_setSocketTimeout_I == IntPtr.Zero)
				id_setSocketTimeout_I = JNIEnv.GetMethodID (class_ref, "setSocketTimeout", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSocketTimeout_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSocketTimeout_I, new JValue (p0));
		}

		static IntPtr id_submit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='submit' and count(parameter)=0]"
		[Register ("submit", "()Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse Submit ()
		{
			if (id_submit == IntPtr.Zero)
				id_submit = JNIEnv.GetMethodID (class_ref, "submit", "()Lcom/amazon/identity/auth/device/endpoint/TokenResponse;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallObjectMethod  (Handle, id_submit), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_updateEntity;
#pragma warning disable 0169
		static Delegate GetUpdateEntityHandler ()
		{
			if (cb_updateEntity == null)
				cb_updateEntity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateEntity);
			return cb_updateEntity;
		}

		static void n_UpdateEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateEntity ();
		}
#pragma warning restore 0169

		static IntPtr id_updateEntity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='updateEntity' and count(parameter)=0]"
		[Register ("updateEntity", "()V", "GetUpdateEntityHandler")]
		protected virtual void UpdateEntity ()
		{
			if (id_updateEntity == IntPtr.Zero)
				id_updateEntity = JNIEnv.GetMethodID (class_ref, "updateEntity", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateEntity);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_updateEntity);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractTokenRequest", DoNotGenerateAcw=true)]
	internal partial class AbstractTokenRequestInvoker : AbstractTokenRequest {

		public AbstractTokenRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractTokenRequestInvoker); }
		}

		static IntPtr id_getEndPoint;
		public override string EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Ljava/lang/String;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addRequestInfoParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addRequestInfoParameters' and count(parameter)=0]"
		[Register ("addRequestInfoParameters", "()V", "GetAddRequestInfoParametersHandler")]
		protected override void AddRequestInfoParameters ()
		{
			if (id_addRequestInfoParameters == IntPtr.Zero)
				id_addRequestInfoParameters = JNIEnv.GetMethodID (class_ref, "addRequestInfoParameters", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_addRequestInfoParameters);
		}

		static IntPtr id_generateTokenResponse_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='generateTokenResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler")]
		protected override global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse GenerateTokenResponse (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_generateTokenResponse_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_generateTokenResponse_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;");
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallObjectMethod  (Handle, id_generateTokenResponse_Lorg_apache_http_HttpResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
