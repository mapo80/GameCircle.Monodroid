using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/DefaultInsightsContext", DoNotGenerateAcw=true)]
	public partial class DefaultInsightsContext : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.IInsightsContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/DefaultInsightsContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInsightsContext); }
		}

		protected DefaultInsightsContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_UserProfile_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/constructor[@name='DefaultInsightsContext' and count(parameter)=6 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.amazon.insights.UserProfile'] and parameter[4][@type='com.amazon.insights.core.util.SDKInfo'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.Map']]"
		[Register (".ctor", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/UserProfile;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)V", "")]
		public DefaultInsightsContext (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1, global::Com.Amazon.Insights.IUserProfile p2, global::Com.Amazon.Insights.Core.Util.SDKInfo p3, bool p4, global::System.Collections.Generic.IDictionary<string, string> p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p5);;
			if (GetType () != typeof (DefaultInsightsContext)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/UserProfile;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p5))),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/UserProfile;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p5)));
				JNIEnv.DeleteLocalRef (native_p5);
				return;
			}

			if (id_ctor_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_UserProfile_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_UserProfile_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/UserProfile;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_UserProfile_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p5))),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_UserProfile_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p5)));
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfiguration);
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		static IntPtr id_getConfiguration;
		public virtual global::configurationImpl.IConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lcom/amazon/insights/core/configuration/Configuration;", "GetGetConfigurationHandler")]
			get {
				if (id_getConfiguration == IntPtr.Zero)
					id_getConfiguration = JNIEnv.GetMethodID (class_ref, "getConfiguration", "()Lcom/amazon/insights/core/configuration/Configuration;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (JNIEnv.CallObjectMethod  (Handle, id_getConfiguration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConfiguration), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCredentials;
#pragma warning disable 0169
		static Delegate GetGetCredentialsHandler ()
		{
			if (cb_getCredentials == null)
				cb_getCredentials = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCredentials);
			return cb_getCredentials;
		}

		static IntPtr n_GetCredentials (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		static IntPtr id_getCredentials;
		public virtual global::Com.Amazon.Insights.IInsightsCredentials Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Lcom/amazon/insights/InsightsCredentials;", "GetGetCredentialsHandler")]
			get {
				if (id_getCredentials == IntPtr.Zero)
					id_getCredentials = JNIEnv.GetMethodID (class_ref, "getCredentials", "()Lcom/amazon/insights/InsightsCredentials;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (JNIEnv.CallObjectMethod  (Handle, id_getCredentials), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCredentials), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeliveryClient;
#pragma warning disable 0169
		static Delegate GetGetDeliveryClientHandler ()
		{
			if (cb_getDeliveryClient == null)
				cb_getDeliveryClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeliveryClient);
			return cb_getDeliveryClient;
		}

		static IntPtr n_GetDeliveryClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeliveryClient);
		}
#pragma warning restore 0169

		static IntPtr id_getDeliveryClient;
		public virtual global::Com.Amazon.Insights.Delivery.IDeliveryClient DeliveryClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getDeliveryClient' and count(parameter)=0]"
			[Register ("getDeliveryClient", "()Lcom/amazon/insights/delivery/DeliveryClient;", "GetGetDeliveryClientHandler")]
			get {
				if (id_getDeliveryClient == IntPtr.Zero)
					id_getDeliveryClient = JNIEnv.GetMethodID (class_ref, "getDeliveryClient", "()Lcom/amazon/insights/delivery/DeliveryClient;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (JNIEnv.CallObjectMethod  (Handle, id_getDeliveryClient), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeliveryClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHttpClient;
#pragma warning disable 0169
		static Delegate GetGetHttpClientHandler ()
		{
			if (cb_getHttpClient == null)
				cb_getHttpClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHttpClient);
			return cb_getHttpClient;
		}

		static IntPtr n_GetHttpClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HttpClient);
		}
#pragma warning restore 0169

		static IntPtr id_getHttpClient;
		public virtual global::Com.Amazon.Insights.Core.Http.IHttpClient HttpClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getHttpClient' and count(parameter)=0]"
			[Register ("getHttpClient", "()Lcom/amazon/insights/core/http/HttpClient;", "GetGetHttpClientHandler")]
			get {
				if (id_getHttpClient == IntPtr.Zero)
					id_getHttpClient = JNIEnv.GetMethodID (class_ref, "getHttpClient", "()Lcom/amazon/insights/core/http/HttpClient;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (JNIEnv.CallObjectMethod  (Handle, id_getHttpClient), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHttpClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSDKInfo;
#pragma warning disable 0169
		static Delegate GetGetSDKInfoHandler ()
		{
			if (cb_getSDKInfo == null)
				cb_getSDKInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKInfo);
			return cb_getSDKInfo;
		}

		static IntPtr n_GetSDKInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SDKInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getSDKInfo;
		public virtual global::Com.Amazon.Insights.Core.Util.SDKInfo SDKInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getSDKInfo' and count(parameter)=0]"
			[Register ("getSDKInfo", "()Lcom/amazon/insights/core/util/SDKInfo;", "GetGetSDKInfoHandler")]
			get {
				if (id_getSDKInfo == IntPtr.Zero)
					id_getSDKInfo = JNIEnv.GetMethodID (class_ref, "getSDKInfo", "()Lcom/amazon/insights/core/util/SDKInfo;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.SDKInfo> (JNIEnv.CallObjectMethod  (Handle, id_getSDKInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.SDKInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSDKInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSystem;
#pragma warning disable 0169
		static Delegate GetGetSystemHandler ()
		{
			if (cb_getSystem == null)
				cb_getSystem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSystem);
			return cb_getSystem;
		}

		static IntPtr n_GetSystem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.System);
		}
#pragma warning restore 0169

		static IntPtr id_getSystem;
		public virtual global::com.amazon.insights.core.system.amazon.ISystem System {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getSystem' and count(parameter)=0]"
			[Register ("getSystem", "()Lcom/amazon/insights/core/system/System;", "GetGetSystemHandler")]
			get {
				if (id_getSystem == IntPtr.Zero)
					id_getSystem = JNIEnv.GetMethodID (class_ref, "getSystem", "()Lcom/amazon/insights/core/system/System;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (JNIEnv.CallObjectMethod  (Handle, id_getSystem), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSystem), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UniqueId);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId;
		public virtual global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserProfile;
#pragma warning disable 0169
		static Delegate GetGetUserProfileHandler ()
		{
			if (cb_getUserProfile == null)
				cb_getUserProfile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserProfile);
			return cb_getUserProfile;
		}

		static IntPtr n_GetUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserProfile);
		}
#pragma warning restore 0169

		static IntPtr id_getUserProfile;
		public virtual global::Com.Amazon.Insights.IUserProfile UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/amazon/insights/UserProfile;", "GetGetUserProfileHandler")]
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Lcom/amazon/insights/UserProfile;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='newInstance' and count(parameter)=5 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.amazon.insights.core.util.SDKInfo'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.Map']]"
		[Register ("newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)Lcom/amazon/insights/core/InsightsContext;", "")]
		public static global::Com.Amazon.Insights.Core.IInsightsContext NewInstance (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1, global::Com.Amazon.Insights.Core.Util.SDKInfo p2, bool p3, global::System.Collections.Generic.IDictionary<string, string> p4)
		{
			if (id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/core/util/SDKInfo;ZLjava/util/Map;)Lcom/amazon/insights/core/InsightsContext;");
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			global::Com.Amazon.Insights.Core.IInsightsContext __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_core_util_SDKInfo_ZLjava_util_Map_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p4))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_synchronize;
#pragma warning disable 0169
		static Delegate GetSynchronizeHandler ()
		{
			if (cb_synchronize == null)
				cb_synchronize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Synchronize);
			return cb_synchronize;
		}

		static void n_Synchronize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Synchronize ();
		}
#pragma warning restore 0169

		static IntPtr id_synchronize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsContext']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "GetSynchronizeHandler")]
		public virtual void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetMethodID (class_ref, "synchronize", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_synchronize);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_synchronize);
		}

	}
}
