using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/factory/ServiceFactory", DoNotGenerateAcw=true)]
	public sealed partial class ServiceFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/factory/ServiceFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceFactory); }
		}

		internal ServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getApplicationName;
		public string ApplicationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getApplicationName' and count(parameter)=0]"
			[Register ("getApplicationName", "()Ljava/lang/String;", "GetGetApplicationNameHandler")]
			get {
				if (id_getApplicationName == IntPtr.Zero)
					id_getApplicationName = JNIEnv.GetMethodID (class_ref, "getApplicationName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isDebugLoggingEnabled;
		static IntPtr id_setDebugLoggingEnabled_Z;
		public static bool DebugLoggingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='isDebugLoggingEnabled' and count(parameter)=0]"
			[Register ("isDebugLoggingEnabled", "()Z", "GetIsDebugLoggingEnabledHandler")]
			get {
				if (id_isDebugLoggingEnabled == IntPtr.Zero)
					id_isDebugLoggingEnabled = JNIEnv.GetStaticMethodID (class_ref, "isDebugLoggingEnabled", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebugLoggingEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='setDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugLoggingEnabled", "(Z)V", "GetSetDebugLoggingEnabled_ZHandler")]
			set {
				if (id_setDebugLoggingEnabled_Z == IntPtr.Zero)
					id_setDebugLoggingEnabled_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugLoggingEnabled", "(Z)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugLoggingEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_getEventCollectorClient;
		public global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient EventCollectorClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getEventCollectorClient' and count(parameter)=0]"
			[Register ("getEventCollectorClient", "()Lcom/amazon/ags/client/metrics/EventCollectorClient;", "GetGetEventCollectorClientHandler")]
			get {
				if (id_getEventCollectorClient == IntPtr.Zero)
					id_getEventCollectorClient = JNIEnv.GetMethodID (class_ref, "getEventCollectorClient", "()Lcom/amazon/ags/client/metrics/EventCollectorClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (JNIEnv.CallObjectMethod  (Handle, id_getEventCollectorClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInitializedContentVersion;
		public global::Com.Amazon.Ags.Html5.Content.ContentVersion InitializedContentVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getInitializedContentVersion' and count(parameter)=0]"
			[Register ("getInitializedContentVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;", "GetGetInitializedContentVersionHandler")]
			get {
				if (id_getInitializedContentVersion == IntPtr.Zero)
					id_getInitializedContentVersion = JNIEnv.GetMethodID (class_ref, "getInitializedContentVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallObjectMethod  (Handle, id_getInitializedContentVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInstance;
		public static global::Com.Amazon.Ags.Html5.Factory.ServiceFactory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/amazon/ags/html5/factory/ServiceFactory;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/amazon/ags/html5/factory/ServiceFactory;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Factory.ServiceFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getJavascriptRepository;
		public global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository JavascriptRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getJavascriptRepository' and count(parameter)=0]"
			[Register ("getJavascriptRepository", "()Lcom/amazon/ags/html5/javascript/JavascriptRepository;", "GetGetJavascriptRepositoryHandler")]
			get {
				if (id_getJavascriptRepository == IntPtr.Zero)
					id_getJavascriptRepository = JNIEnv.GetMethodID (class_ref, "getJavascriptRepository", "()Lcom/amazon/ags/html5/javascript/JavascriptRepository;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository> (JNIEnv.CallObjectMethod  (Handle, id_getJavascriptRepository), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getKindleFireProxy;
		public global::Com.Amazon.Ags.Client.IKindleFireProxy KindleFireProxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getKindleFireProxy' and count(parameter)=0]"
			[Register ("getKindleFireProxy", "()Lcom/amazon/ags/client/KindleFireProxy;", "GetGetKindleFireProxyHandler")]
			get {
				if (id_getKindleFireProxy == IntPtr.Zero)
					id_getKindleFireProxy = JNIEnv.GetMethodID (class_ref, "getKindleFireProxy", "()Lcom/amazon/ags/client/KindleFireProxy;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (JNIEnv.CallObjectMethod  (Handle, id_getKindleFireProxy), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLocalizationUtil;
		public global::Com.Amazon.Ags.Html5.Util.LocalizationUtil LocalizationUtil {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getLocalizationUtil' and count(parameter)=0]"
			[Register ("getLocalizationUtil", "()Lcom/amazon/ags/html5/util/LocalizationUtil;", "GetGetLocalizationUtilHandler")]
			get {
				if (id_getLocalizationUtil == IntPtr.Zero)
					id_getLocalizationUtil = JNIEnv.GetMethodID (class_ref, "getLocalizationUtil", "()Lcom/amazon/ags/html5/util/LocalizationUtil;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (JNIEnv.CallObjectMethod  (Handle, id_getLocalizationUtil), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getNetworkClient;
		public global::Com.Amazon.Ags.Html5.Comm.INetworkClient NetworkClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getNetworkClient' and count(parameter)=0]"
			[Register ("getNetworkClient", "()Lcom/amazon/ags/html5/comm/NetworkClient;", "GetGetNetworkClientHandler")]
			get {
				if (id_getNetworkClient == IntPtr.Zero)
					id_getNetworkClient = JNIEnv.GetMethodID (class_ref, "getNetworkClient", "()Lcom/amazon/ags/html5/comm/NetworkClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.INetworkClient> (JNIEnv.CallObjectMethod  (Handle, id_getNetworkClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getOverlayClient;
		public global::Com.Amazon.Ags.Client.OverlayClient OverlayClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getOverlayClient' and count(parameter)=0]"
			[Register ("getOverlayClient", "()Lcom/amazon/ags/client/OverlayClient;", "GetGetOverlayClientHandler")]
			get {
				if (id_getOverlayClient == IntPtr.Zero)
					id_getOverlayClient = JNIEnv.GetMethodID (class_ref, "getOverlayClient", "()Lcom/amazon/ags/client/OverlayClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (JNIEnv.CallObjectMethod  (Handle, id_getOverlayClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getServiceHelper;
		public global::Com.Amazon.Ags.Html5.Service.IServiceHelper ServiceHelper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getServiceHelper' and count(parameter)=0]"
			[Register ("getServiceHelper", "()Lcom/amazon/ags/html5/service/ServiceHelper;", "GetGetServiceHelperHandler")]
			get {
				if (id_getServiceHelper == IntPtr.Zero)
					id_getServiceHelper = JNIEnv.GetMethodID (class_ref, "getServiceHelper", "()Lcom/amazon/ags/html5/service/ServiceHelper;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (JNIEnv.CallObjectMethod  (Handle, id_getServiceHelper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSessionClient;
		public global::Com.Amazon.Ags.Client.Session.SessionClient SessionClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getSessionClient' and count(parameter)=0]"
			[Register ("getSessionClient", "()Lcom/amazon/ags/client/session/SessionClient;", "GetGetSessionClientHandler")]
			get {
				if (id_getSessionClient == IntPtr.Zero)
					id_getSessionClient = JNIEnv.GetMethodID (class_ref, "getSessionClient", "()Lcom/amazon/ags/client/session/SessionClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionClient> (JNIEnv.CallObjectMethod  (Handle, id_getSessionClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getUiThreadHandler;
		public global::Android.OS.Handler UiThreadHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getUiThreadHandler' and count(parameter)=0]"
			[Register ("getUiThreadHandler", "()Landroid/os/Handler;", "GetGetUiThreadHandlerHandler")]
			get {
				if (id_getUiThreadHandler == IntPtr.Zero)
					id_getUiThreadHandler = JNIEnv.GetMethodID (class_ref, "getUiThreadHandler", "()Landroid/os/Handler;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod  (Handle, id_getUiThreadHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getWebViewFactory;
		public global::Com.Amazon.Ags.Html5.Util.WebViewFactory WebViewFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getWebViewFactory' and count(parameter)=0]"
			[Register ("getWebViewFactory", "()Lcom/amazon/ags/html5/util/WebViewFactory;", "GetGetWebViewFactoryHandler")]
			get {
				if (id_getWebViewFactory == IntPtr.Zero)
					id_getWebViewFactory = JNIEnv.GetMethodID (class_ref, "getWebViewFactory", "()Lcom/amazon/ags/html5/util/WebViewFactory;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.WebViewFactory> (JNIEnv.CallObjectMethod  (Handle, id_getWebViewFactory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getJavascriptInterface_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='getJavascriptInterface' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("getJavascriptInterface", "(Landroid/webkit/WebView;Ljava/lang/String;)Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;", "")]
		public global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface GetJavascriptInterface (global::Android.Webkit.WebView p0, string p1)
		{
			if (id_getJavascriptInterface_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
				id_getJavascriptInterface_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getJavascriptInterface", "(Landroid/webkit/WebView;Ljava/lang/String;)Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (JNIEnv.CallObjectMethod  (Handle, id_getJavascriptInterface_Landroid_webkit_WebView_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_ags_html5_content_ContentManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_html5_content_GCVariationManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='initialize' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amazon.ags.html5.content.ContentManager'] and parameter[4][@type='com.amazon.ags.client.metrics.EventCollectorClient'] and parameter[5][@type='com.amazon.ags.storage.StringObfuscator'] and parameter[6][@type='com.amazon.ags.html5.content.GCVariationManager']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/amazon/ags/html5/content/ContentManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/html5/content/GCVariationManager;)Lcom/amazon/ags/html5/factory/ServiceFactory;", "")]
		public static global::Com.Amazon.Ags.Html5.Factory.ServiceFactory Initialize (global::Android.Content.Context p0, string p1, global::Com.Amazon.Ags.Html5.Content.ContentManager p2, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p3, global::Com.Amazon.Ags.Storage.IStringObfuscator p4, global::Com.Amazon.Ags.Html5.Content.GCVariationManager p5)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_ags_html5_content_ContentManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_html5_content_GCVariationManager_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_ags_html5_content_ContentManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_html5_content_GCVariationManager_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/amazon/ags/html5/content/ContentManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/html5/content/GCVariationManager;)Lcom/amazon/ags/html5/factory/ServiceFactory;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Ags.Html5.Factory.ServiceFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Factory.ServiceFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_ags_html5_content_ContentManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_html5_content_GCVariationManager_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		public void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onPause);
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		public void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onResume);
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='ServiceFactory']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_shutdown);
		}

	}
}
