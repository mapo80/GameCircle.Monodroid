using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']"
	[Register ("com/amazon/insights/core/InsightsContext", "", "Com.Amazon.Insights.Core.IInsightsContextInvoker")]
	public partial interface IInsightsContext : IJavaObject {

		global::Com.Amazon.Insights.Core.Configuration.IConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lcom/amazon/insights/core/configuration/Configuration;", "GetGetConfigurationHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.IInsightsCredentials Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Lcom/amazon/insights/InsightsCredentials;", "GetGetCredentialsHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Delivery.IDeliveryClient DeliveryClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getDeliveryClient' and count(parameter)=0]"
			[Register ("getDeliveryClient", "()Lcom/amazon/insights/delivery/DeliveryClient;", "GetGetDeliveryClientHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Core.Http.IHttpClient HttpClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getHttpClient' and count(parameter)=0]"
			[Register ("getHttpClient", "()Lcom/amazon/insights/core/http/HttpClient;", "GetGetHttpClientHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Core.Util.SDKInfo SDKInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getSDKInfo' and count(parameter)=0]"
			[Register ("getSDKInfo", "()Lcom/amazon/insights/core/util/SDKInfo;", "GetGetSDKInfoHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::com.amazon.insights.core.system.amazon.ISystem System {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getSystem' and count(parameter)=0]"
			[Register ("getSystem", "()Lcom/amazon/insights/core/system/System;", "GetGetSystemHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueIdHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::Com.Amazon.Insights.IUserProfile UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/amazon/insights/UserProfile;", "GetGetUserProfileHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/interface[@name='InsightsContext']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "GetSynchronizeHandler:Com.Amazon.Insights.Core.IInsightsContextInvoker, AmazonInsights.MonoDroid")]
		void Synchronize ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/InsightsContext", DoNotGenerateAcw=true)]
	internal class IInsightsContextInvoker : global::Java.Lang.Object, IInsightsContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/InsightsContext");
		IntPtr class_ref;

		public static IInsightsContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsightsContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.InsightsContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsightsContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInsightsContextInvoker); }
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		IntPtr id_getConfiguration;
		public global::Com.Amazon.Insights.Core.Configuration.IConfiguration Configuration {
			get {
				if (id_getConfiguration == IntPtr.Zero)
					id_getConfiguration = JNIEnv.GetMethodID (class_ref, "getConfiguration", "()Lcom/amazon/insights/core/configuration/Configuration;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Configuration.IConfiguration> (JNIEnv.CallObjectMethod (Handle, id_getConfiguration), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		IntPtr id_getCredentials;
		public global::Com.Amazon.Insights.IInsightsCredentials Credentials {
			get {
				if (id_getCredentials == IntPtr.Zero)
					id_getCredentials = JNIEnv.GetMethodID (class_ref, "getCredentials", "()Lcom/amazon/insights/InsightsCredentials;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (JNIEnv.CallObjectMethod (Handle, id_getCredentials), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeliveryClient);
		}
#pragma warning restore 0169

		IntPtr id_getDeliveryClient;
		public global::Com.Amazon.Insights.Delivery.IDeliveryClient DeliveryClient {
			get {
				if (id_getDeliveryClient == IntPtr.Zero)
					id_getDeliveryClient = JNIEnv.GetMethodID (class_ref, "getDeliveryClient", "()Lcom/amazon/insights/delivery/DeliveryClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IDeliveryClient> (JNIEnv.CallObjectMethod (Handle, id_getDeliveryClient), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HttpClient);
		}
#pragma warning restore 0169

		IntPtr id_getHttpClient;
		public global::Com.Amazon.Insights.Core.Http.IHttpClient HttpClient {
			get {
				if (id_getHttpClient == IntPtr.Zero)
					id_getHttpClient = JNIEnv.GetMethodID (class_ref, "getHttpClient", "()Lcom/amazon/insights/core/http/HttpClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClient> (JNIEnv.CallObjectMethod (Handle, id_getHttpClient), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SDKInfo);
		}
#pragma warning restore 0169

		IntPtr id_getSDKInfo;
		public global::Com.Amazon.Insights.Core.Util.SDKInfo SDKInfo {
			get {
				if (id_getSDKInfo == IntPtr.Zero)
					id_getSDKInfo = JNIEnv.GetMethodID (class_ref, "getSDKInfo", "()Lcom/amazon/insights/core/util/SDKInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.SDKInfo> (JNIEnv.CallObjectMethod (Handle, id_getSDKInfo), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.System);
		}
#pragma warning restore 0169

		IntPtr id_getSystem;
		public global::com.amazon.insights.core.system.amazon.ISystem System {
			get {
				if (id_getSystem == IntPtr.Zero)
					id_getSystem = JNIEnv.GetMethodID (class_ref, "getSystem", "()Lcom/amazon/insights/core/system/System;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (JNIEnv.CallObjectMethod (Handle, id_getSystem), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UniqueId);
		}
#pragma warning restore 0169

		IntPtr id_getUniqueId;
		public global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserProfile);
		}
#pragma warning restore 0169

		IntPtr id_getUserProfile;
		public global::Com.Amazon.Insights.IUserProfile UserProfile {
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Lcom/amazon/insights/UserProfile;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod (Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Insights.Core.IInsightsContext __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Synchronize ();
		}
#pragma warning restore 0169

		IntPtr id_synchronize;
		public void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetMethodID (class_ref, "synchronize", "()V");
			JNIEnv.CallVoidMethod (Handle, id_synchronize);
		}

	}

}
