using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/domain/JavascriptInterface", DoNotGenerateAcw=true)]
	public partial class JavascriptInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/domain/JavascriptInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavascriptInterface); }
		}

		protected JavascriptInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Lcom_amazon_ags_html5_overlay_OverlayManager_Ljava_util_List_Ljava_util_concurrent_ExecutorService_Landroid_webkit_WebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/constructor[@name='JavascriptInterface' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.html5.service.AsynchronousReplyMessenger'] and parameter[3][@type='com.amazon.ags.html5.overlay.OverlayManager'] and parameter[4][@type='java.util.List'] and parameter[5][@type='java.util.concurrent.ExecutorService'] and parameter[6][@type='android.webkit.WebView']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Lcom/amazon/ags/html5/overlay/OverlayManager;Ljava/util/List;Ljava/util/concurrent/ExecutorService;Landroid/webkit/WebView;)V", "")]
		public JavascriptInterface (string p0, global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger p1, global::Com.Amazon.Ags.Html5.Overlay.OverlayManager p2, global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> p3, global::Java.Util.Concurrent.IExecutorService p4, global::Android.Webkit.WebView p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase>.ToLocalJniHandle (p3);;
			if (GetType () != typeof (JavascriptInterface)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Lcom/amazon/ags/html5/overlay/OverlayManager;Ljava/util/List;Ljava/util/concurrent/ExecutorService;Landroid/webkit/WebView;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Lcom/amazon/ags/html5/overlay/OverlayManager;Ljava/util/List;Ljava/util/concurrent/ExecutorService;Landroid/webkit/WebView;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)), new JValue (p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Lcom_amazon_ags_html5_overlay_OverlayManager_Ljava_util_List_Ljava_util_concurrent_ExecutorService_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Lcom_amazon_ags_html5_overlay_OverlayManager_Ljava_util_List_Ljava_util_concurrent_ExecutorService_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/amazon/ags/html5/service/AsynchronousReplyMessenger;Lcom/amazon/ags/html5/overlay/OverlayManager;Ljava/util/List;Ljava/util/concurrent/ExecutorService;Landroid/webkit/WebView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Lcom_amazon_ags_html5_overlay_OverlayManager_Ljava_util_List_Ljava_util_concurrent_ExecutorService_Landroid_webkit_WebView_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_ags_html5_service_AsynchronousReplyMessenger_Lcom_amazon_ags_html5_overlay_OverlayManager_Ljava_util_List_Ljava_util_concurrent_ExecutorService_Landroid_webkit_WebView_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isReady);
			}
		}

		static Delegate cb_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_;
#pragma warning disable 0169
		static Delegate GetAddCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_Handler ()
		{
			if (cb_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_ == null)
				cb_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_);
			return cb_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_;
		}

		static void n_AddCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener p0 = (global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCloseAlertListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='addCloseAlertListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.javascript.domain.CloseAlertListener']]"
		[Register ("addCloseAlertListener", "(Lcom/amazon/ags/html5/javascript/domain/CloseAlertListener;)V", "GetAddCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_Handler")]
		public virtual void AddCloseAlertListener (global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener p0)
		{
			if (id_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_ == IntPtr.Zero)
				id_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_ = JNIEnv.GetMethodID (class_ref, "addCloseAlertListener", "(Lcom/amazon/ags/html5/javascript/domain/CloseAlertListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addCloseAlertListener_Lcom_amazon_ags_html5_javascript_domain_CloseAlertListener_, new JValue (p0));
		}

		static Delegate cb_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_;
#pragma warning disable 0169
		static Delegate GetAddCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_Handler ()
		{
			if (cb_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_ == null)
				cb_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_);
			return cb_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_;
		}

		static void n_AddCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener p0 = (global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCloseOverlayListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='addCloseOverlayListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.javascript.domain.CloseOverlayListener']]"
		[Register ("addCloseOverlayListener", "(Lcom/amazon/ags/html5/javascript/domain/CloseOverlayListener;)V", "GetAddCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_Handler")]
		public virtual void AddCloseOverlayListener (global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener p0)
		{
			if (id_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_ == IntPtr.Zero)
				id_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_ = JNIEnv.GetMethodID (class_ref, "addCloseOverlayListener", "(Lcom/amazon/ags/html5/javascript/domain/CloseOverlayListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addCloseOverlayListener_Lcom_amazon_ags_html5_javascript_domain_CloseOverlayListener_, new JValue (p0));
		}

		static Delegate cb_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_;
#pragma warning disable 0169
		static Delegate GetAddMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_Handler ()
		{
			if (cb_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_ == null)
				cb_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_);
			return cb_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_;
		}

		static void n_AddMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener p0 = (global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMessageHandlerReadyListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='addMessageHandlerReadyListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.javascript.domain.MessageHandlerReadyListener']]"
		[Register ("addMessageHandlerReadyListener", "(Lcom/amazon/ags/html5/javascript/domain/MessageHandlerReadyListener;)V", "GetAddMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_Handler")]
		public virtual void AddMessageHandlerReadyListener (global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener p0)
		{
			if (id_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_ == IntPtr.Zero)
				id_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_ = JNIEnv.GetMethodID (class_ref, "addMessageHandlerReadyListener", "(Lcom/amazon/ags/html5/javascript/domain/MessageHandlerReadyListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addMessageHandlerReadyListener_Lcom_amazon_ags_html5_javascript_domain_MessageHandlerReadyListener_, new JValue (p0));
		}

		static Delegate cb_closeAlert;
#pragma warning disable 0169
		static Delegate GetCloseAlertHandler ()
		{
			if (cb_closeAlert == null)
				cb_closeAlert = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseAlert);
			return cb_closeAlert;
		}

		static void n_CloseAlert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAlert ();
		}
#pragma warning restore 0169

		static IntPtr id_closeAlert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='closeAlert' and count(parameter)=0]"
		[Register ("closeAlert", "()V", "GetCloseAlertHandler")]
		public virtual void CloseAlert ()
		{
			if (id_closeAlert == IntPtr.Zero)
				id_closeAlert = JNIEnv.GetMethodID (class_ref, "closeAlert", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeAlert);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_closeAlert);
		}

		static Delegate cb_closeOverlay;
#pragma warning disable 0169
		static Delegate GetCloseOverlayHandler ()
		{
			if (cb_closeOverlay == null)
				cb_closeOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseOverlay);
			return cb_closeOverlay;
		}

		static void n_CloseOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseOverlay ();
		}
#pragma warning restore 0169

		static IntPtr id_closeOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='closeOverlay' and count(parameter)=0]"
		[Register ("closeOverlay", "()V", "GetCloseOverlayHandler")]
		public virtual void CloseOverlay ()
		{
			if (id_closeOverlay == IntPtr.Zero)
				id_closeOverlay = JNIEnv.GetMethodID (class_ref, "closeOverlay", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeOverlay);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_closeOverlay);
		}

		static Delegate cb_handleMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Ljava_lang_String_Handler ()
		{
			if (cb_handleMessage_Ljava_lang_String_ == null)
				cb_handleMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleMessage_Ljava_lang_String_);
			return cb_handleMessage_Ljava_lang_String_;
		}

		static void n_HandleMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleMessage", "(Ljava/lang/String;)V", "GetHandleMessage_Ljava_lang_String_Handler")]
		public virtual void HandleMessage (string p0)
		{
			if (id_handleMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_handleMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleMessage_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_handleMessage_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_logMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogMessage_Ljava_lang_String_Handler ()
		{
			if (cb_logMessage_Ljava_lang_String_ == null)
				cb_logMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogMessage_Ljava_lang_String_);
			return cb_logMessage_Ljava_lang_String_;
		}

		static void n_LogMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='logMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logMessage", "(Ljava/lang/String;)V", "GetLogMessage_Ljava_lang_String_Handler")]
		public virtual void LogMessage (string p0)
		{
			if (id_logMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_logMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logMessage_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_logMessage_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendJSReply (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='sendJSReply' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendJSReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SendJSReply (string p0, string p1, string p2)
		{
			if (id_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendJSReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendJSReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendReply_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendReply_Ljava_lang_String_Handler ()
		{
			if (cb_sendReply_Ljava_lang_String_ == null)
				cb_sendReply_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendReply_Ljava_lang_String_);
			return cb_sendReply_Ljava_lang_String_;
		}

		static void n_SendReply_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendReply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendReply_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='sendReply' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendReply", "(Ljava/lang/String;)V", "GetSendReply_Ljava_lang_String_Handler")]
		public virtual void SendReply (string p0)
		{
			if (id_sendReply_Ljava_lang_String_ == IntPtr.Zero)
				id_sendReply_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendReply", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendReply_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendReply_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setReadyForMessages;
#pragma warning disable 0169
		static Delegate GetSetReadyForMessagesHandler ()
		{
			if (cb_setReadyForMessages == null)
				cb_setReadyForMessages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetReadyForMessages);
			return cb_setReadyForMessages;
		}

		static void n_SetReadyForMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadyForMessages ();
		}
#pragma warning restore 0169

		static IntPtr id_setReadyForMessages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='setReadyForMessages' and count(parameter)=0]"
		[Register ("setReadyForMessages", "()V", "GetSetReadyForMessagesHandler")]
		public virtual void SetReadyForMessages ()
		{
			if (id_setReadyForMessages == IntPtr.Zero)
				id_setReadyForMessages = JNIEnv.GetMethodID (class_ref, "setReadyForMessages", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setReadyForMessages);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setReadyForMessages);
		}

		static Delegate cb_showAlert_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowAlert_Ljava_lang_String_Handler ()
		{
			if (cb_showAlert_Ljava_lang_String_ == null)
				cb_showAlert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAlert_Ljava_lang_String_);
			return cb_showAlert_Ljava_lang_String_;
		}

		static void n_ShowAlert_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowAlert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showAlert_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='showAlert' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showAlert", "(Ljava/lang/String;)V", "GetShowAlert_Ljava_lang_String_Handler")]
		public virtual void ShowAlert (string p0)
		{
			if (id_showAlert_Ljava_lang_String_ == IntPtr.Zero)
				id_showAlert_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showAlert", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showAlert_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_showAlert_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_showOverlay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowOverlay_Ljava_lang_String_Handler ()
		{
			if (cb_showOverlay_Ljava_lang_String_ == null)
				cb_showOverlay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowOverlay_Ljava_lang_String_);
			return cb_showOverlay_Ljava_lang_String_;
		}

		static void n_ShowOverlay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowOverlay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showOverlay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='showOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showOverlay", "(Ljava/lang/String;)V", "GetShowOverlay_Ljava_lang_String_Handler")]
		public virtual void ShowOverlay (string p0)
		{
			if (id_showOverlay_Ljava_lang_String_ == IntPtr.Zero)
				id_showOverlay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showOverlay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showOverlay_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_showOverlay_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_showToast_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowToast_Ljava_lang_String_Handler ()
		{
			if (cb_showToast_Ljava_lang_String_ == null)
				cb_showToast_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowToast_Ljava_lang_String_);
			return cb_showToast_Ljava_lang_String_;
		}

		static void n_ShowToast_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowToast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showToast_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript.domain']/class[@name='JavascriptInterface']/method[@name='showToast' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showToast", "(Ljava/lang/String;)V", "GetShowToast_Ljava_lang_String_Handler")]
		public virtual void ShowToast (string p0)
		{
			if (id_showToast_Ljava_lang_String_ == IntPtr.Zero)
				id_showToast_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showToast", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showToast_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_showToast_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

#region "Event implementation for Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener"
		public event EventHandler CloseAlertEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerImplementor>(
						ref weak_implementor_AddCloseAlertListener,
						__CreateICloseAlertListenerImplementor,
						AddCloseAlertListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerImplementor>(
						ref weak_implementor_AddCloseAlertListener,
						global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListener.AddCloseAlertListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddCloseAlertListener;

		global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerImplementor __CreateICloseAlertListenerImplementor ()
		{
			return new global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseAlertListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener"
		public event EventHandler CloseOverlayEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerImplementor>(
						ref weak_implementor_AddCloseOverlayListener,
						__CreateICloseOverlayListenerImplementor,
						AddCloseOverlayListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerImplementor>(
						ref weak_implementor_AddCloseOverlayListener,
						global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListener.AddCloseOverlayListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddCloseOverlayListener;

		global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerImplementor __CreateICloseOverlayListenerImplementor ()
		{
			return new global::Com.Amazon.Ags.Html5.Javascript.Domain.ICloseOverlayListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener"
		public event EventHandler MessageHandlerReady {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerImplementor>(
						ref weak_implementor_AddMessageHandlerReadyListener,
						__CreateIMessageHandlerReadyListenerImplementor,
						AddMessageHandlerReadyListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener, global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerImplementor>(
						ref weak_implementor_AddMessageHandlerReadyListener,
						global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListener.AddMessageHandlerReadyListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddMessageHandlerReadyListener;

		global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerImplementor __CreateIMessageHandlerReadyListenerImplementor ()
		{
			return new global::Com.Amazon.Ags.Html5.Javascript.Domain.IMessageHandlerReadyListenerImplementor (this);
		}
#endregion
	}
}
