using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/content/ContentManager", DoNotGenerateAcw=true)]
	public partial class ContentManager : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.content']/interface[@name='ContentManager.ContentInitializationCallback']"
		[Register ("com/amazon/ags/html5/content/ContentManager$ContentInitializationCallback", "", "Com.Amazon.Ags.Html5.Content.ContentManager/IContentInitializationCallbackInvoker")]
		public partial interface IContentInitializationCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/interface[@name='ContentManager.ContentInitializationCallback']/method[@name='onFailure' and count(parameter)=0]"
			[Register ("onFailure", "()V", "GetOnFailureHandler:Com.Amazon.Ags.Html5.Content.ContentManager/IContentInitializationCallbackInvoker, GameCircle.MonoDroid")]
			void OnFailure ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/interface[@name='ContentManager.ContentInitializationCallback']/method[@name='onInitialized' and count(parameter)=0]"
			[Register ("onInitialized", "()V", "GetOnInitializedHandler:Com.Amazon.Ags.Html5.Content.ContentManager/IContentInitializationCallbackInvoker, GameCircle.MonoDroid")]
			void OnInitialized ();

		}

		[global::Android.Runtime.Register ("com/amazon/ags/html5/content/ContentManager$ContentInitializationCallback", DoNotGenerateAcw=true)]
		internal class IContentInitializationCallbackInvoker : global::Java.Lang.Object, IContentInitializationCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/content/ContentManager$ContentInitializationCallback");
			IntPtr class_ref;

			public static IContentInitializationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContentInitializationCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.content.ContentManager.ContentInitializationCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContentInitializationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IContentInitializationCallbackInvoker); }
			}

			static Delegate cb_onFailure;
#pragma warning disable 0169
			static Delegate GetOnFailureHandler ()
			{
				if (cb_onFailure == null)
					cb_onFailure = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailure);
				return cb_onFailure;
			}

			static void n_OnFailure (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure ();
			}
#pragma warning restore 0169

			IntPtr id_onFailure;
			public void OnFailure ()
			{
				if (id_onFailure == IntPtr.Zero)
					id_onFailure = JNIEnv.GetMethodID (class_ref, "onFailure", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFailure);
			}

			static Delegate cb_onInitialized;
#pragma warning disable 0169
			static Delegate GetOnInitializedHandler ()
			{
				if (cb_onInitialized == null)
					cb_onInitialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInitialized);
				return cb_onInitialized;
			}

			static void n_OnInitialized (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInitialized ();
			}
#pragma warning restore 0169

			IntPtr id_onInitialized;
			public void OnInitialized ()
			{
				if (id_onInitialized == IntPtr.Zero)
					id_onInitialized = JNIEnv.GetMethodID (class_ref, "onInitialized", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInitialized);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/content/ContentManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentManager); }
		}

		protected ContentManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/constructor[@name='ContentManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ContentManager (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContentManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getContentDirectory;
#pragma warning disable 0169
		static Delegate GetGetContentDirectoryHandler ()
		{
			if (cb_getContentDirectory == null)
				cb_getContentDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDirectory);
			return cb_getContentDirectory;
		}

		static IntPtr n_GetContentDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentDirectory);
		}
#pragma warning restore 0169

		static IntPtr id_getContentDirectory;
		public virtual string ContentDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='getContentDirectory' and count(parameter)=0]"
			[Register ("getContentDirectory", "()Ljava/lang/String;", "GetGetContentDirectoryHandler")]
			get {
				if (id_getContentDirectory == IntPtr.Zero)
					id_getContentDirectory = JNIEnv.GetMethodID (class_ref, "getContentDirectory", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentDirectory), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getContentDirectory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageDirectory;
#pragma warning disable 0169
		static Delegate GetGetImageDirectoryHandler ()
		{
			if (cb_getImageDirectory == null)
				cb_getImageDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageDirectory);
			return cb_getImageDirectory;
		}

		static IntPtr n_GetImageDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageDirectory);
		}
#pragma warning restore 0169

		static IntPtr id_getImageDirectory;
		public virtual string ImageDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='getImageDirectory' and count(parameter)=0]"
			[Register ("getImageDirectory", "()Ljava/lang/String;", "GetGetImageDirectoryHandler")]
			get {
				if (id_getImageDirectory == IntPtr.Zero)
					id_getImageDirectory = JNIEnv.GetMethodID (class_ref, "getImageDirectory", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageDirectory), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageDirectory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInitializedContentVersion;
#pragma warning disable 0169
		static Delegate GetGetInitializedContentVersionHandler ()
		{
			if (cb_getInitializedContentVersion == null)
				cb_getInitializedContentVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitializedContentVersion);
			return cb_getInitializedContentVersion;
		}

		static IntPtr n_GetInitializedContentVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitializedContentVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getInitializedContentVersion;
		public virtual global::Com.Amazon.Ags.Html5.Content.ContentVersion InitializedContentVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='getInitializedContentVersion' and count(parameter)=0]"
			[Register ("getInitializedContentVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;", "GetGetInitializedContentVersionHandler")]
			get {
				if (id_getInitializedContentVersion == IntPtr.Zero)
					id_getInitializedContentVersion = JNIEnv.GetMethodID (class_ref, "getInitializedContentVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallObjectMethod  (Handle, id_getInitializedContentVersion), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInitializedContentVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_;
#pragma warning disable 0169
		static Delegate GetInitializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_Handler ()
		{
			if (cb_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_ == null)
				cb_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_);
			return cb_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_;
		}

		static void n_InitializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService p0 = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Content.GCVariationManager p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.GCVariationManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback p2 = (global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitializeContent (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='initializeContent' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.ExecutorService'] and parameter[2][@type='com.amazon.ags.html5.content.GCVariationManager'] and parameter[3][@type='com.amazon.ags.html5.content.ContentManager.ContentInitializationCallback']]"
		[Register ("initializeContent", "(Ljava/util/concurrent/ExecutorService;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/content/ContentManager$ContentInitializationCallback;)V", "GetInitializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_Handler")]
		public virtual void InitializeContent (global::Java.Util.Concurrent.IExecutorService p0, global::Com.Amazon.Ags.Html5.Content.GCVariationManager p1, global::Com.Amazon.Ags.Html5.Content.ContentManager.IContentInitializationCallback p2)
		{
			if (id_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_ == IntPtr.Zero)
				id_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_ = JNIEnv.GetMethodID (class_ref, "initializeContent", "(Ljava/util/concurrent/ExecutorService;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/content/ContentManager$ContentInitializationCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initializeContent_Ljava_util_concurrent_ExecutorService_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_content_ContentManager_ContentInitializationCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_loadBackgroundJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadBackgroundJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadBackgroundJavascript_Landroid_webkit_WebView_ == null)
				cb_loadBackgroundJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadBackgroundJavascript_Landroid_webkit_WebView_);
			return cb_loadBackgroundJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadBackgroundJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadBackgroundJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadBackgroundJavascript_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='loadBackgroundJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadBackgroundJavascript", "(Landroid/webkit/WebView;)V", "GetLoadBackgroundJavascript_Landroid_webkit_WebView_Handler")]
		public virtual void LoadBackgroundJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadBackgroundJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadBackgroundJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadBackgroundJavascript", "(Landroid/webkit/WebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadBackgroundJavascript_Landroid_webkit_WebView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadBackgroundJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

		static Delegate cb_loadOverlayJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadOverlayJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadOverlayJavascript_Landroid_webkit_WebView_ == null)
				cb_loadOverlayJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadOverlayJavascript_Landroid_webkit_WebView_);
			return cb_loadOverlayJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadOverlayJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadOverlayJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadOverlayJavascript_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='loadOverlayJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadOverlayJavascript", "(Landroid/webkit/WebView;)V", "GetLoadOverlayJavascript_Landroid_webkit_WebView_Handler")]
		public virtual void LoadOverlayJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadOverlayJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadOverlayJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadOverlayJavascript", "(Landroid/webkit/WebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadOverlayJavascript_Landroid_webkit_WebView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadOverlayJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

		static Delegate cb_loadToastJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadToastJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadToastJavascript_Landroid_webkit_WebView_ == null)
				cb_loadToastJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadToastJavascript_Landroid_webkit_WebView_);
			return cb_loadToastJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadToastJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadToastJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadToastJavascript_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='loadToastJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadToastJavascript", "(Landroid/webkit/WebView;)V", "GetLoadToastJavascript_Landroid_webkit_WebView_Handler")]
		public virtual void LoadToastJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadToastJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadToastJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadToastJavascript", "(Landroid/webkit/WebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadToastJavascript_Landroid_webkit_WebView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadToastJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManager']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shutdown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_shutdown);
		}

	}
}
