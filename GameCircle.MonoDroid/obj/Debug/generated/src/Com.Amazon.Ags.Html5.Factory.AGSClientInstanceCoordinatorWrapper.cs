using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/factory/AGSClientInstanceCoordinator", DoNotGenerateAcw=true)]
	public sealed partial class AGSClientInstanceCoordinatorWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/factory/AGSClientInstanceCoordinator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSClientInstanceCoordinatorWrapper); }
		}

		internal AGSClientInstanceCoordinatorWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentActivity;
		public global::Android.App.Activity CurrentActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='getCurrentActivity' and count(parameter)=0]"
			[Register ("getCurrentActivity", "()Landroid/app/Activity;", "GetGetCurrentActivityHandler")]
			get {
				if (id_getCurrentActivity == IntPtr.Zero)
					id_getCurrentActivity = JNIEnv.GetMethodID (class_ref, "getCurrentActivity", "()Landroid/app/Activity;");
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentActivity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEnabledFeatures;
		public global::Java.Util.EnumSet EnabledFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='getEnabledFeatures' and count(parameter)=0]"
			[Register ("getEnabledFeatures", "()Ljava/util/EnumSet;", "GetGetEnabledFeaturesHandler")]
			get {
				if (id_getEnabledFeatures == IntPtr.Zero)
					id_getEnabledFeatures = JNIEnv.GetMethodID (class_ref, "getEnabledFeatures", "()Ljava/util/EnumSet;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (JNIEnv.CallObjectMethod  (Handle, id_getEnabledFeatures), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInstance;
		public static global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinator;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinator;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLatestCallback;
		public global::Com.Amazon.Ags.Api.IAmazonGamesCallback LatestCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='getLatestCallback' and count(parameter)=0]"
			[Register ("getLatestCallback", "()Lcom/amazon/ags/api/AmazonGamesCallback;", "GetGetLatestCallbackHandler")]
			get {
				if (id_getLatestCallback == IntPtr.Zero)
					id_getLatestCallback = JNIEnv.GetMethodID (class_ref, "getLatestCallback", "()Lcom/amazon/ags/api/AmazonGamesCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGamesCallback> (JNIEnv.CallObjectMethod  (Handle, id_getLatestCallback), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addAGSClientInstanceCoordinatorListener_Lcom_amazon_ags_html5_factory_AGSClientInstanceCoordinatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='addAGSClientInstanceCoordinatorListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.factory.AGSClientInstanceCoordinatorListener']]"
		[Register ("addAGSClientInstanceCoordinatorListener", "(Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListener;)V", "")]
		public void AddAGSClientInstanceCoordinatorListener (global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener p0)
		{
			if (id_addAGSClientInstanceCoordinatorListener_Lcom_amazon_ags_html5_factory_AGSClientInstanceCoordinatorListener_ == IntPtr.Zero)
				id_addAGSClientInstanceCoordinatorListener_Lcom_amazon_ags_html5_factory_AGSClientInstanceCoordinatorListener_ = JNIEnv.GetMethodID (class_ref, "addAGSClientInstanceCoordinatorListener", "(Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinatorListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addAGSClientInstanceCoordinatorListener_Lcom_amazon_ags_html5_factory_AGSClientInstanceCoordinatorListener_, new JValue (p0));
		}

		static IntPtr id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.amazon.ags.api.AmazonGamesCallback'] and parameter[3][@type='java.util.EnumSet']]"
		[Register ("initialize", "(Landroid/app/Activity;Lcom/amazon/ags/api/AmazonGamesCallback;Ljava/util/EnumSet;)Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinator;", "")]
		public static global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper Initialize (global::Android.App.Activity p0, global::Com.Amazon.Ags.Api.IAmazonGamesCallback p1, global::Java.Util.EnumSet p2)
		{
			if (id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_ == IntPtr.Zero)
				id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/app/Activity;Lcom/amazon/ags/api/AmazonGamesCallback;Ljava/util/EnumSet;)Lcom/amazon/ags/html5/factory/AGSClientInstanceCoordinator;");
			global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_updateActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='updateActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("updateActivity", "(Landroid/app/Activity;)V", "")]
		public void UpdateActivity (global::Android.App.Activity p0)
		{
			if (id_updateActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_updateActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "updateActivity", "(Landroid/app/Activity;)V");
			JNIEnv.CallVoidMethod  (Handle, id_updateActivity_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_updateCallback_Lcom_amazon_ags_api_AmazonGamesCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='updateCallback' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesCallback']]"
		[Register ("updateCallback", "(Lcom/amazon/ags/api/AmazonGamesCallback;)V", "")]
		public void UpdateCallback (global::Com.Amazon.Ags.Api.IAmazonGamesCallback p0)
		{
			if (id_updateCallback_Lcom_amazon_ags_api_AmazonGamesCallback_ == IntPtr.Zero)
				id_updateCallback_Lcom_amazon_ags_api_AmazonGamesCallback_ = JNIEnv.GetMethodID (class_ref, "updateCallback", "(Lcom/amazon/ags/api/AmazonGamesCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_updateCallback_Lcom_amazon_ags_api_AmazonGamesCallback_, new JValue (p0));
		}

		static IntPtr id_updateFeatures_Ljava_util_EnumSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.factory']/class[@name='AGSClientInstanceCoordinator']/method[@name='updateFeatures' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet']]"
		[Register ("updateFeatures", "(Ljava/util/EnumSet;)V", "")]
		public void UpdateFeatures (global::Java.Util.EnumSet p0)
		{
			if (id_updateFeatures_Ljava_util_EnumSet_ == IntPtr.Zero)
				id_updateFeatures_Ljava_util_EnumSet_ = JNIEnv.GetMethodID (class_ref, "updateFeatures", "(Ljava/util/EnumSet;)V");
			JNIEnv.CallVoidMethod  (Handle, id_updateFeatures_Ljava_util_EnumSet_, new JValue (p0));
		}

#region "Event implementation for Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener"
		public event EventHandler<global::Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorEventArgs> AGSClientInstanceCoordinator {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener, global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerImplementor>(
						ref weak_implementor_AddAGSClientInstanceCoordinatorListener,
						__CreateIAGSClientInstanceCoordinatorListenerImplementor,
						AddAGSClientInstanceCoordinatorListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener, global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerImplementor>(
						ref weak_implementor_AddAGSClientInstanceCoordinatorListener,
						global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener.AddAGSClientInstanceCoordinatorListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddAGSClientInstanceCoordinatorListener;

		global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerImplementor __CreateIAGSClientInstanceCoordinatorListenerImplementor ()
		{
			return new global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListenerImplementor (this);
		}
#endregion
	}
}
