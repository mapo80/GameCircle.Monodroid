using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='WebViewServiceHelper']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/service/WebViewServiceHelper", DoNotGenerateAcw=true)]
	public partial class WebViewServiceHelper : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener, global::Com.Amazon.Ags.Html5.Service.IServiceHelper {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/service/WebViewServiceHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewServiceHelper); }
		}

		protected WebViewServiceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Landroid_webkit_WebView_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='WebViewServiceHelper']/constructor[@name='WebViewServiceHelper' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.html5.javascript.JavascriptRepository'] and parameter[3][@type='com.amazon.ags.html5.javascript.domain.JavascriptInterface'] and parameter[4][@type='com.amazon.ags.html5.service.AsynchronousReplyMessenger'] and parameter[5][@type='android.webkit.WebView'] and parameter[6][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Landroid/webkit/WebView;Landroid/os/Handler;)V", "")]
		public WebViewServiceHelper (global::Android.Content.Context p0, global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository p1, global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface p2, global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger p3, global::Android.Webkit.WebView p4, global::Android.OS.Handler p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WebViewServiceHelper)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Landroid/webkit/WebView;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Landroid/webkit/WebView;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Landroid_webkit_WebView_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Landroid_webkit_WebView_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Landroid/webkit/WebView;Landroid/os/Handler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Landroid_webkit_WebView_Landroid_os_Handler_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Landroid_webkit_WebView_Landroid_os_Handler_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static Delegate cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
#pragma warning disable 0169
		static Delegate GetHandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_Handler ()
		{
			if (cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ == null)
				cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_);
			return cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
		}

		static void n_HandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Service.WebViewServiceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.WebViewServiceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.IJSONRequest p0 = (global::Com.Amazon.Ags.Client.IJSONRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IJSONRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleRequestAsync (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='WebViewServiceHelper']/method[@name='handleRequestAsync' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.JSONRequest']]"
		[Register ("handleRequestAsync", "(Lcom/amazon/ags/client/JSONRequest;)V", "GetHandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_Handler")]
		public virtual void HandleRequestAsync (global::Com.Amazon.Ags.Client.IJSONRequest p0)
		{
			if (id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ == IntPtr.Zero)
				id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ = JNIEnv.GetMethodID (class_ref, "handleRequestAsync", "(Lcom/amazon/ags/client/JSONRequest;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_, new JValue (p0));
		}

		static Delegate cb_messageHandlerReady;
#pragma warning disable 0169
		static Delegate GetMessageHandlerReadyHandler ()
		{
			if (cb_messageHandlerReady == null)
				cb_messageHandlerReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MessageHandlerReady);
			return cb_messageHandlerReady;
		}

		static void n_MessageHandlerReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Service.WebViewServiceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.WebViewServiceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageHandlerReady ();
		}
#pragma warning restore 0169

		static IntPtr id_messageHandlerReady;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='WebViewServiceHelper']/method[@name='messageHandlerReady' and count(parameter)=0]"
		[Register ("messageHandlerReady", "()V", "GetMessageHandlerReadyHandler")]
		public virtual void MessageHandlerReady ()
		{
			if (id_messageHandlerReady == IntPtr.Zero)
				id_messageHandlerReady = JNIEnv.GetMethodID (class_ref, "messageHandlerReady", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_messageHandlerReady);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_messageHandlerReady);
		}

	}
}
