using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']"
	[global::Android.Runtime.Register ("com/amazon/insights/AmazonInsights", DoNotGenerateAcw=true)]
	public abstract partial class AmazonInsights : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights.DefaultAmazonInsights']"
		[global::Android.Runtime.Register ("com/amazon/insights/AmazonInsights$DefaultAmazonInsights", DoNotGenerateAcw=true)]
		public sealed partial class DefaultAmazonInsights : global::Com.Amazon.Insights.AmazonInsights {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/AmazonInsights$DefaultAmazonInsights", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultAmazonInsights); }
			}

			internal DefaultAmazonInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getABTestClient;
			public override global::Com.Amazon.Insights.IABTestClient ABTestClient {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights.DefaultAmazonInsights']/method[@name='getABTestClient' and count(parameter)=0]"
				[Register ("getABTestClient", "()Lcom/amazon/insights/ABTestClient;", "GetGetABTestClientHandler")]
				get {
					if (id_getABTestClient == IntPtr.Zero)
						id_getABTestClient = JNIEnv.GetMethodID (class_ref, "getABTestClient", "()Lcom/amazon/insights/ABTestClient;");
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IABTestClient> (JNIEnv.CallObjectMethod  (Handle, id_getABTestClient), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getEventClient;
			public override global::Com.Amazon.Insights.IEventClient EventClient {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights.DefaultAmazonInsights']/method[@name='getEventClient' and count(parameter)=0]"
				[Register ("getEventClient", "()Lcom/amazon/insights/EventClient;", "GetGetEventClientHandler")]
				get {
					if (id_getEventClient == IntPtr.Zero)
						id_getEventClient = JNIEnv.GetMethodID (class_ref, "getEventClient", "()Lcom/amazon/insights/EventClient;");
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEventClient> (JNIEnv.CallObjectMethod  (Handle, id_getEventClient), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getSessionClient;
			public override global::Com.Amazon.Insights.ISessionClient SessionClient {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights.DefaultAmazonInsights']/method[@name='getSessionClient' and count(parameter)=0]"
				[Register ("getSessionClient", "()Lcom/amazon/insights/SessionClient;", "GetGetSessionClientHandler")]
				get {
					if (id_getSessionClient == IntPtr.Zero)
						id_getSessionClient = JNIEnv.GetMethodID (class_ref, "getSessionClient", "()Lcom/amazon/insights/SessionClient;");
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.ISessionClient> (JNIEnv.CallObjectMethod  (Handle, id_getSessionClient), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getUserProfile;
			public override global::Com.Amazon.Insights.IUserProfile UserProfile {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights.DefaultAmazonInsights']/method[@name='getUserProfile' and count(parameter)=0]"
				[Register ("getUserProfile", "()Lcom/amazon/insights/UserProfile;", "GetGetUserProfileHandler")]
				get {
					if (id_getUserProfile == IntPtr.Zero)
						id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Lcom/amazon/insights/UserProfile;");
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/AmazonInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonInsights); }
		}

		protected AmazonInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/constructor[@name='AmazonInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected AmazonInsights () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AmazonInsights)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getABTestClient;
#pragma warning disable 0169
		static Delegate GetGetABTestClientHandler ()
		{
			if (cb_getABTestClient == null)
				cb_getABTestClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetABTestClient);
			return cb_getABTestClient;
		}

		static IntPtr n_GetABTestClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.AmazonInsights __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ABTestClient);
		}
#pragma warning restore 0169

		public abstract global::Com.Amazon.Insights.IABTestClient ABTestClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getABTestClient' and count(parameter)=0]"
			[Register ("getABTestClient", "()Lcom/amazon/insights/ABTestClient;", "GetGetABTestClientHandler")] get;
		}

		static Delegate cb_getEventClient;
#pragma warning disable 0169
		static Delegate GetGetEventClientHandler ()
		{
			if (cb_getEventClient == null)
				cb_getEventClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventClient);
			return cb_getEventClient;
		}

		static IntPtr n_GetEventClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.AmazonInsights __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventClient);
		}
#pragma warning restore 0169

		public abstract global::Com.Amazon.Insights.IEventClient EventClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getEventClient' and count(parameter)=0]"
			[Register ("getEventClient", "()Lcom/amazon/insights/EventClient;", "GetGetEventClientHandler")] get;
		}

		static Delegate cb_getSessionClient;
#pragma warning disable 0169
		static Delegate GetGetSessionClientHandler ()
		{
			if (cb_getSessionClient == null)
				cb_getSessionClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionClient);
			return cb_getSessionClient;
		}

		static IntPtr n_GetSessionClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.AmazonInsights __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SessionClient);
		}
#pragma warning restore 0169

		public abstract global::Com.Amazon.Insights.ISessionClient SessionClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getSessionClient' and count(parameter)=0]"
			[Register ("getSessionClient", "()Lcom/amazon/insights/SessionClient;", "GetGetSessionClientHandler")] get;
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
			global::Com.Amazon.Insights.AmazonInsights __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserProfile);
		}
#pragma warning restore 0169

		public abstract global::Com.Amazon.Insights.IUserProfile UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/amazon/insights/UserProfile;", "GetGetUserProfileHandler")] get;
		}

		static IntPtr id_getInstance_Lcom_amazon_insights_InsightsCredentials_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.InsightsCredentials']]"
		[Register ("getInstance", "(Lcom/amazon/insights/InsightsCredentials;)Lcom/amazon/insights/AmazonInsights;", "")]
		public static global::Com.Amazon.Insights.AmazonInsights GetInstance (global::Com.Amazon.Insights.IInsightsCredentials p0)
		{
			if (id_getInstance_Lcom_amazon_insights_InsightsCredentials_ == IntPtr.Zero)
				id_getInstance_Lcom_amazon_insights_InsightsCredentials_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Lcom/amazon/insights/InsightsCredentials;)Lcom/amazon/insights/AmazonInsights;");
			global::Com.Amazon.Insights.AmazonInsights __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Lcom_amazon_insights_InsightsCredentials_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newCredentials_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newCredentials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("newCredentials", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/InsightsCredentials;", "")]
		public static global::Com.Amazon.Insights.IInsightsCredentials NewCredentials (string p0, string p1)
		{
			if (id_newCredentials_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_newCredentials_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newCredentials", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/InsightsCredentials;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.IInsightsCredentials __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newCredentials_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newDefaultOptions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newDefaultOptions' and count(parameter)=0]"
		[Register ("newDefaultOptions", "()Lcom/amazon/insights/InsightsOptions;", "")]
		public static global::Com.Amazon.Insights.IInsightsOptions NewDefaultOptions ()
		{
			if (id_newDefaultOptions == IntPtr.Zero)
				id_newDefaultOptions = JNIEnv.GetStaticMethodID (class_ref, "newDefaultOptions", "()Lcom/amazon/insights/InsightsOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newDefaultOptions), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context']]"
		[Register ("newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;)Lcom/amazon/insights/AmazonInsights;", "")]
		public static global::Com.Amazon.Insights.AmazonInsights NewInstance (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1)
		{
			if (id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;)Lcom/amazon/insights/AmazonInsights;");
			global::Com.Amazon.Insights.AmazonInsights __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.amazon.insights.InsightsCallback']]"
		[Register ("newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsCallback;)Lcom/amazon/insights/AmazonInsights;", "")]
		public static global::Com.Amazon.Insights.AmazonInsights NewInstance (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1, global::Com.Amazon.Insights.InsightsCallback p2)
		{
			if (id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsCallback_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsCallback;)Lcom/amazon/insights/AmazonInsights;");
			global::Com.Amazon.Insights.AmazonInsights __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsCallback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.amazon.insights.InsightsOptions']]"
		[Register ("newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsOptions;)Lcom/amazon/insights/AmazonInsights;", "")]
		public static global::Com.Amazon.Insights.AmazonInsights NewInstance (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1, global::Com.Amazon.Insights.IInsightsOptions p2)
		{
			if (id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsOptions;)Lcom/amazon/insights/AmazonInsights;");
			global::Com.Amazon.Insights.AmazonInsights __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_Lcom_amazon_insights_InsightsCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newInstance' and count(parameter)=4 and parameter[1][@type='com.amazon.insights.InsightsCredentials'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.amazon.insights.InsightsOptions'] and parameter[4][@type='com.amazon.insights.InsightsCallback']]"
		[Register ("newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsOptions;Lcom/amazon/insights/InsightsCallback;)Lcom/amazon/insights/AmazonInsights;", "")]
		public static global::Com.Amazon.Insights.AmazonInsights NewInstance (global::Com.Amazon.Insights.IInsightsCredentials p0, global::Android.Content.Context p1, global::Com.Amazon.Insights.IInsightsOptions p2, global::Com.Amazon.Insights.InsightsCallback p3)
		{
			if (id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_Lcom_amazon_insights_InsightsCallback_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_Lcom_amazon_insights_InsightsCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/InsightsCredentials;Landroid/content/Context;Lcom/amazon/insights/InsightsOptions;Lcom/amazon/insights/InsightsCallback;)Lcom/amazon/insights/AmazonInsights;");
			global::Com.Amazon.Insights.AmazonInsights __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.AmazonInsights> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_InsightsCredentials_Landroid_content_Context_Lcom_amazon_insights_InsightsOptions_Lcom_amazon_insights_InsightsCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newOptions_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='newOptions' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("newOptions", "(ZZ)Lcom/amazon/insights/InsightsOptions;", "")]
		public static global::Com.Amazon.Insights.IInsightsOptions NewOptions (bool p0, bool p1)
		{
			if (id_newOptions_ZZ == IntPtr.Zero)
				id_newOptions_ZZ = JNIEnv.GetStaticMethodID (class_ref, "newOptions", "(ZZ)Lcom/amazon/insights/InsightsOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newOptions_ZZ, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/AmazonInsights", DoNotGenerateAcw=true)]
	internal partial class AmazonInsightsInvoker : AmazonInsights {

		public AmazonInsightsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonInsightsInvoker); }
		}

		static IntPtr id_getABTestClient;
		public override global::Com.Amazon.Insights.IABTestClient ABTestClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getABTestClient' and count(parameter)=0]"
			[Register ("getABTestClient", "()Lcom/amazon/insights/ABTestClient;", "GetGetABTestClientHandler")]
			get {
				if (id_getABTestClient == IntPtr.Zero)
					id_getABTestClient = JNIEnv.GetMethodID (class_ref, "getABTestClient", "()Lcom/amazon/insights/ABTestClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IABTestClient> (JNIEnv.CallObjectMethod  (Handle, id_getABTestClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventClient;
		public override global::Com.Amazon.Insights.IEventClient EventClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getEventClient' and count(parameter)=0]"
			[Register ("getEventClient", "()Lcom/amazon/insights/EventClient;", "GetGetEventClientHandler")]
			get {
				if (id_getEventClient == IntPtr.Zero)
					id_getEventClient = JNIEnv.GetMethodID (class_ref, "getEventClient", "()Lcom/amazon/insights/EventClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEventClient> (JNIEnv.CallObjectMethod  (Handle, id_getEventClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSessionClient;
		public override global::Com.Amazon.Insights.ISessionClient SessionClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getSessionClient' and count(parameter)=0]"
			[Register ("getSessionClient", "()Lcom/amazon/insights/SessionClient;", "GetGetSessionClientHandler")]
			get {
				if (id_getSessionClient == IntPtr.Zero)
					id_getSessionClient = JNIEnv.GetMethodID (class_ref, "getSessionClient", "()Lcom/amazon/insights/SessionClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.ISessionClient> (JNIEnv.CallObjectMethod  (Handle, id_getSessionClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getUserProfile;
		public override global::Com.Amazon.Insights.IUserProfile UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='AmazonInsights']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/amazon/insights/UserProfile;", "GetGetUserProfileHandler")]
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Lcom/amazon/insights/UserProfile;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
