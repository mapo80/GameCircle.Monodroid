using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='WebViewFactory']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/WebViewFactory", DoNotGenerateAcw=true)]
	public partial class WebViewFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/WebViewFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewFactory); }
		}

		protected WebViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='WebViewFactory']/constructor[@name='WebViewFactory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.html5.javascript.JavascriptRepository']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;)V", "")]
		public WebViewFactory (global::Android.Content.Context p0, global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WebViewFactory)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/ags/html5/javascript/JavascriptRepository;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_html5_javascript_JavascriptRepository_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getBackgroundWebview;
#pragma warning disable 0169
		static Delegate GetGetBackgroundWebviewHandler ()
		{
			if (cb_getBackgroundWebview == null)
				cb_getBackgroundWebview = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgroundWebview);
			return cb_getBackgroundWebview;
		}

		static IntPtr n_GetBackgroundWebview (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.WebViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.WebViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackgroundWebview);
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundWebview;
		public virtual global::Android.Webkit.WebView BackgroundWebview {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='WebViewFactory']/method[@name='getBackgroundWebview' and count(parameter)=0]"
			[Register ("getBackgroundWebview", "()Landroid/webkit/WebView;", "GetGetBackgroundWebviewHandler")]
			get {
				if (id_getBackgroundWebview == IntPtr.Zero)
					id_getBackgroundWebview = JNIEnv.GetMethodID (class_ref, "getBackgroundWebview", "()Landroid/webkit/WebView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallObjectMethod  (Handle, id_getBackgroundWebview), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBackgroundWebview), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_newOverlayWebView_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetNewOverlayWebView_Landroid_app_Activity_Handler ()
		{
			if (cb_newOverlayWebView_Landroid_app_Activity_ == null)
				cb_newOverlayWebView_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewOverlayWebView_Landroid_app_Activity_);
			return cb_newOverlayWebView_Landroid_app_Activity_;
		}

		static IntPtr n_NewOverlayWebView_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.WebViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.WebViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewOverlayWebView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newOverlayWebView_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='WebViewFactory']/method[@name='newOverlayWebView' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("newOverlayWebView", "(Landroid/app/Activity;)Landroid/webkit/WebView;", "GetNewOverlayWebView_Landroid_app_Activity_Handler")]
		public virtual global::Android.Webkit.WebView NewOverlayWebView (global::Android.App.Activity p0)
		{
			if (id_newOverlayWebView_Landroid_app_Activity_ == IntPtr.Zero)
				id_newOverlayWebView_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "newOverlayWebView", "(Landroid/app/Activity;)Landroid/webkit/WebView;");

			global::Android.Webkit.WebView __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallObjectMethod  (Handle, id_newOverlayWebView_Landroid_app_Activity_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newOverlayWebView_Landroid_app_Activity_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newToastWebView;
#pragma warning disable 0169
		static Delegate GetNewToastWebViewHandler ()
		{
			if (cb_newToastWebView == null)
				cb_newToastWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewToastWebView);
			return cb_newToastWebView;
		}

		static IntPtr n_NewToastWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.WebViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.WebViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewToastWebView ());
		}
#pragma warning restore 0169

		static IntPtr id_newToastWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='WebViewFactory']/method[@name='newToastWebView' and count(parameter)=0]"
		[Register ("newToastWebView", "()Landroid/webkit/WebView;", "GetNewToastWebViewHandler")]
		public virtual global::Android.Webkit.WebView NewToastWebView ()
		{
			if (id_newToastWebView == IntPtr.Zero)
				id_newToastWebView = JNIEnv.GetMethodID (class_ref, "newToastWebView", "()Landroid/webkit/WebView;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallObjectMethod  (Handle, id_newToastWebView), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newToastWebView), JniHandleOwnership.TransferLocalRef);
		}

	}
}
