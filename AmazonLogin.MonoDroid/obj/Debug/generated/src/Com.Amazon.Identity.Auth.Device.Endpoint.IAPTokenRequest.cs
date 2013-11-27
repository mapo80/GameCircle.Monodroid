using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']"
	[Register ("com/amazon/identity/auth/device/endpoint/APTokenRequest", "", "Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker")]
	public partial interface IAPTokenRequest : global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder {

		global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> PostParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='getPostParameters' and count(parameter)=0]"
			[Register ("getPostParameters", "()Ljava/util/List;", "GetGetPostParametersHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")] get;
		}

		string VerbAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='getVerbAsString' and count(parameter)=0]"
			[Register ("getVerbAsString", "()Ljava/lang/String;", "GetGetVerbAsStringHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='executeRequest' and count(parameter)=0]"
		[Register ("executeRequest", "()Lorg/apache/http/HttpResponse;", "GetExecuteRequestHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		global::Org.Apache.Http.IHttpResponse ExecuteRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='getHeaders' and count(parameter)=0]"
		[Register ("getHeaders", "()[Lorg/apache/http/Header;", "GetGetHeadersHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		global::Org.Apache.Http.IHeader[] GetHeaders ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='getHost' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getHost", "(Landroid/os/Bundle;)Ljava/lang/String;", "GetGetHost_Landroid_os_Bundle_Handler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		string GetHost (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='initializeHeaders' and count(parameter)=0]"
		[Register ("initializeHeaders", "()V", "GetInitializeHeadersHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void InitializeHeaders ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='initializeHttp' and count(parameter)=0]"
		[Register ("initializeHttp", "()V", "GetInitializeHttpHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void InitializeHttp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='initializePostParams' and count(parameter)=0]"
		[Register ("initializePostParams", "()V", "GetInitializePostParamsHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void InitializePostParams ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='initializeUserAgent' and count(parameter)=0]"
		[Register ("initializeUserAgent", "()V", "GetInitializeUserAgentHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void InitializeUserAgent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='postExecute' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("postExecute", "(Lorg/apache/http/HttpResponse;)V", "GetPostExecute_Lorg_apache_http_HttpResponse_Handler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void PostExecute (global::Org.Apache.Http.IHttpResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='preExecute' and count(parameter)=0]"
		[Register ("preExecute", "()V", "GetPreExecuteHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void PreExecute ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='setSocketTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSocketTimeout", "(I)V", "GetSetSocketTimeout_IHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		void SetSocketTimeout (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='APTokenRequest']/method[@name='submit' and count(parameter)=0]"
		[Register ("submit", "()Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "GetSubmitHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequestInvoker, AmazonLogin.MonoDroid")]
		global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse Submit ();

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/APTokenRequest", DoNotGenerateAcw=true)]
	internal class IAPTokenRequestInvoker : global::Java.Lang.Object, IAPTokenRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/APTokenRequest");
		IntPtr class_ref;

		public static IAPTokenRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAPTokenRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.endpoint.APTokenRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAPTokenRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAPTokenRequestInvoker); }
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (__this.PostParameters);
		}
#pragma warning restore 0169

		IntPtr id_getPostParameters;
		public global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> PostParameters {
			get {
				if (id_getPostParameters == IntPtr.Zero)
					id_getPostParameters = JNIEnv.GetMethodID (class_ref, "getPostParameters", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPostParameters), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerbAsString);
		}
#pragma warning restore 0169

		IntPtr id_getVerbAsString;
		public string VerbAsString {
			get {
				if (id_getVerbAsString == IntPtr.Zero)
					id_getVerbAsString = JNIEnv.GetMethodID (class_ref, "getVerbAsString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getVerbAsString), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecuteRequest ());
		}
#pragma warning restore 0169

		IntPtr id_executeRequest;
		public global::Org.Apache.Http.IHttpResponse ExecuteRequest ()
		{
			if (id_executeRequest == IntPtr.Zero)
				id_executeRequest = JNIEnv.GetMethodID (class_ref, "executeRequest", "()Lorg/apache/http/HttpResponse;");
			return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallObjectMethod (Handle, id_executeRequest), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaders ());
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		public global::Org.Apache.Http.IHeader[] GetHeaders ()
		{
			if (id_getHeaders == IntPtr.Zero)
				id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()[Lorg/apache/http/Header;");
			return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHost (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHost_Landroid_os_Bundle_;
		public string GetHost (global::Android.OS.Bundle p0)
		{
			if (id_getHost_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getHost_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getHost", "(Landroid/os/Bundle;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHost_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeHeaders ();
		}
#pragma warning restore 0169

		IntPtr id_initializeHeaders;
		public void InitializeHeaders ()
		{
			if (id_initializeHeaders == IntPtr.Zero)
				id_initializeHeaders = JNIEnv.GetMethodID (class_ref, "initializeHeaders", "()V");
			JNIEnv.CallVoidMethod (Handle, id_initializeHeaders);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeHttp ();
		}
#pragma warning restore 0169

		IntPtr id_initializeHttp;
		public void InitializeHttp ()
		{
			if (id_initializeHttp == IntPtr.Zero)
				id_initializeHttp = JNIEnv.GetMethodID (class_ref, "initializeHttp", "()V");
			JNIEnv.CallVoidMethod (Handle, id_initializeHttp);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializePostParams ();
		}
#pragma warning restore 0169

		IntPtr id_initializePostParams;
		public void InitializePostParams ()
		{
			if (id_initializePostParams == IntPtr.Zero)
				id_initializePostParams = JNIEnv.GetMethodID (class_ref, "initializePostParams", "()V");
			JNIEnv.CallVoidMethod (Handle, id_initializePostParams);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeUserAgent ();
		}
#pragma warning restore 0169

		IntPtr id_initializeUserAgent;
		public void InitializeUserAgent ()
		{
			if (id_initializeUserAgent == IntPtr.Zero)
				id_initializeUserAgent = JNIEnv.GetMethodID (class_ref, "initializeUserAgent", "()V");
			JNIEnv.CallVoidMethod (Handle, id_initializeUserAgent);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostExecute (p0);
		}
#pragma warning restore 0169

		IntPtr id_postExecute_Lorg_apache_http_HttpResponse_;
		public void PostExecute (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_postExecute_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_postExecute_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "postExecute", "(Lorg/apache/http/HttpResponse;)V");
			JNIEnv.CallVoidMethod (Handle, id_postExecute_Lorg_apache_http_HttpResponse_, new JValue (p0));
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreExecute ();
		}
#pragma warning restore 0169

		IntPtr id_preExecute;
		public void PreExecute ()
		{
			if (id_preExecute == IntPtr.Zero)
				id_preExecute = JNIEnv.GetMethodID (class_ref, "preExecute", "()V");
			JNIEnv.CallVoidMethod (Handle, id_preExecute);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSocketTimeout (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSocketTimeout_I;
		public void SetSocketTimeout (int p0)
		{
			if (id_setSocketTimeout_I == IntPtr.Zero)
				id_setSocketTimeout_I = JNIEnv.GetMethodID (class_ref, "setSocketTimeout", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_setSocketTimeout_I, new JValue (p0));
		}

		static Delegate cb_submit;
#pragma warning disable 0169
		static Delegate GetSubmitHandler ()
		{
			if (cb_submit == null)
				cb_submit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Submit);
			return cb_submit;
		}

		static IntPtr n_Submit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Submit ());
		}
#pragma warning restore 0169

		IntPtr id_submit;
		public global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse Submit ()
		{
			if (id_submit == IntPtr.Zero)
				id_submit = JNIEnv.GetMethodID (class_ref, "submit", "()Lcom/amazon/identity/auth/device/endpoint/TokenResponse;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallObjectMethod (Handle, id_submit), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		IntPtr id_getDomain;
		public string Domain {
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		IntPtr id_getPort;
		public int Port {
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPort);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IAPTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUrl);
		}
#pragma warning restore 0169

		IntPtr id_getRequestUrl;
		public string RequestUrl {
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
