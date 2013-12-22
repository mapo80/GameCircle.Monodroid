using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastFactoryImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastFactoryImpl", DoNotGenerateAcw=true)]
	public partial class ClickableToastFactoryImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener, global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToastFactoryImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickableToastFactoryImpl); }
		}

		protected ClickableToastFactoryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_util_LocalizationUtil_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastFactoryImpl']/constructor[@name='ClickableToastFactoryImpl' and count(parameter)=4 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.amazon.ags.html5.util.WebViewFactory'] and parameter[3][@type='com.amazon.ags.html5.javascript.JavascriptRepository'] and parameter[4][@type='com.amazon.ags.html5.util.LocalizationUtil']]"
		[Register (".ctor", "(Landroid/os/Handler;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", "")]
		public ClickableToastFactoryImpl (global::Android.OS.Handler p0, global::Com.Amazon.Ags.Html5.Util.WebViewFactory p1, global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository p2, global::Com.Amazon.Ags.Html5.Util.LocalizationUtil p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClickableToastFactoryImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_os_Handler_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_util_LocalizationUtil_ == IntPtr.Zero)
				id_ctor_Landroid_os_Handler_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_util_LocalizationUtil_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/util/LocalizationUtil;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_util_LocalizationUtil_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_util_LocalizationUtil_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_getClickableWebViewToast_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClickableWebViewToast_Ljava_lang_String_Handler ()
		{
			if (cb_getClickableWebViewToast_Ljava_lang_String_ == null)
				cb_getClickableWebViewToast_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClickableWebViewToast_Ljava_lang_String_);
			return cb_getClickableWebViewToast_Ljava_lang_String_;
		}

		static IntPtr n_GetClickableWebViewToast_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClickableWebViewToast (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClickableWebViewToast_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastFactoryImpl']/method[@name='getClickableWebViewToast' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClickableWebViewToast", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;", "GetGetClickableWebViewToast_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast GetClickableWebViewToast (string p0)
		{
			if (id_getClickableWebViewToast_Ljava_lang_String_ == IntPtr.Zero)
				id_getClickableWebViewToast_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getClickableWebViewToast", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (JNIEnv.CallObjectMethod  (Handle, id_getClickableWebViewToast_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getClickableWebViewToast_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler ()
		{
			if (cb_notifyCurrentActivityChanged_Landroid_app_Activity_ == null)
				cb_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyCurrentActivityChanged_Landroid_app_Activity_);
			return cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
		}

		static void n_NotifyCurrentActivityChanged_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCurrentActivityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyCurrentActivityChanged_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastFactoryImpl']/method[@name='notifyCurrentActivityChanged' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyCurrentActivityChanged", "(Landroid/app/Activity;)V", "GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler")]
		public virtual void NotifyCurrentActivityChanged (global::Android.App.Activity p0)
		{
			if (id_notifyCurrentActivityChanged_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "notifyCurrentActivityChanged", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
#pragma warning disable 0169
		static Delegate GetSetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_Handler ()
		{
			if (cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ == null)
				cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_);
			return cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
		}

		static void n_SetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastFactoryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0 = (global::Com.Amazon.Ags.Html5.Service.IServiceHelper)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServiceHelper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastFactoryImpl']/method[@name='setServiceHelper' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register ("setServiceHelper", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "GetSetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_Handler")]
		public virtual void SetServiceHelper (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0)
		{
			if (id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "setServiceHelper", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

	}
}
