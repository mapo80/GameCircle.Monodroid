using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableWebViewToast", DoNotGenerateAcw=true)]
	public partial class ClickableWebViewToast : global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableWebViewToast", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickableWebViewToast); }
		}

		protected ClickableWebViewToast (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_LocalizationUtil_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']/constructor[@name='ClickableWebViewToast' and count(parameter)=7 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='com.amazon.ags.html5.overlay.toasts.ClickableToastImpl.ToastParams'] and parameter[4][@type='com.amazon.ags.html5.util.WebViewFactory'] and parameter[5][@type='com.amazon.ags.html5.javascript.JavascriptRepository'] and parameter[6][@type='com.amazon.ags.html5.service.ServiceHelper'] and parameter[7][@type='com.amazon.ags.html5.util.LocalizationUtil']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", "")]
		public ClickableWebViewToast (global::Android.App.Activity p0, global::Android.OS.Handler p1, global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams p2, global::Com.Amazon.Ags.Html5.Util.WebViewFactory p3, global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository p4, global::Com.Amazon.Ags.Html5.Service.IServiceHelper p5, global::Com.Amazon.Ags.Html5.Util.LocalizationUtil p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClickableWebViewToast)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/LocalizationUtil;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
				return;
			}

			if (id_ctor_Landroid_app_Activity_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_LocalizationUtil_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_LocalizationUtil_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;Lcom/amazon/ags/html5/util/WebViewFactory;Lcom/amazon/ags/html5/javascript/JavascriptRepository;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/LocalizationUtil;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_LocalizationUtil_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_Lcom_amazon_ags_html5_util_WebViewFactory_Lcom_amazon_ags_html5_javascript_JavascriptRepository_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_LocalizationUtil_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
		}

		static Delegate cb_initView;
#pragma warning disable 0169
		static Delegate GetInitViewHandler ()
		{
			if (cb_initView == null)
				cb_initView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InitView);
			return cb_initView;
		}

		static IntPtr n_InitView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitView ());
		}
#pragma warning restore 0169

		static IntPtr id_initView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']/method[@name='initView' and count(parameter)=0]"
		[Register ("initView", "()Landroid/view/View;", "GetInitViewHandler")]
		protected override global::Android.Views.View InitView ()
		{
			if (id_initView == IntPtr.Zero)
				id_initView = JNIEnv.GetMethodID (class_ref, "initView", "()Landroid/view/View;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_initView), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_initView), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0 = (global::Com.Amazon.Ags.Html5.Service.IServiceHelper)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServiceHelper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']/method[@name='setServiceHelper' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
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

		static Delegate cb_setToastData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToastData_Ljava_lang_String_Handler ()
		{
			if (cb_setToastData_Ljava_lang_String_ == null)
				cb_setToastData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToastData_Ljava_lang_String_);
			return cb_setToastData_Ljava_lang_String_;
		}

		static void n_SetToastData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetToastData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setToastData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']/method[@name='setToastData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToastData", "(Ljava/lang/String;)V", "GetSetToastData_Ljava_lang_String_Handler")]
		public override void SetToastData (string p0)
		{
			if (id_setToastData_Ljava_lang_String_ == IntPtr.Zero)
				id_setToastData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToastData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setToastData_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setToastData_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_update_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_String_IHandler ()
		{
			if (cb_update_Ljava_lang_String_I == null)
				cb_update_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Update_Ljava_lang_String_I);
			return cb_update_Ljava_lang_String_I;
		}

		static void n_Update_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableWebViewToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableWebViewToast']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("update", "(Ljava/lang/String;I)V", "GetUpdate_Ljava_lang_String_IHandler")]
		public override void Update (string p0, int p1)
		{
			if (id_update_Ljava_lang_String_I == IntPtr.Zero)
				id_update_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_update_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
