using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/AmazonGamesClient", DoNotGenerateAcw=true)]
	public sealed partial class AmazonGamesClient : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.IAmazonGames {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/AmazonGamesClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonGamesClient); }
		}

		internal AmazonGamesClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAchievementsClient;
		public global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient AchievementsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='getAchievementsClient' and count(parameter)=0]"
			[Register ("getAchievementsClient", "()Lcom/amazon/ags/api/achievements/AchievementsClient;", "GetGetAchievementsClientHandler")]
			get {
				if (id_getAchievementsClient == IntPtr.Zero)
					id_getAchievementsClient = JNIEnv.GetMethodID (class_ref, "getAchievementsClient", "()Lcom/amazon/ags/api/achievements/AchievementsClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (JNIEnv.CallObjectMethod  (Handle, id_getAchievementsClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInstance;
		public static global::Com.Amazon.Ags.Api.IAmazonGames Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/amazon/ags/api/AmazonGames;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/amazon/ags/api/AmazonGames;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInitialized;
		public static bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetStaticMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInitialized);
			}
		}

		static IntPtr id_getLeaderboardsClient;
		public global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient LeaderboardsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='getLeaderboardsClient' and count(parameter)=0]"
			[Register ("getLeaderboardsClient", "()Lcom/amazon/ags/api/leaderboards/LeaderboardsClient;", "GetGetLeaderboardsClientHandler")]
			get {
				if (id_getLeaderboardsClient == IntPtr.Zero)
					id_getLeaderboardsClient = JNIEnv.GetMethodID (class_ref, "getLeaderboardsClient", "()Lcom/amazon/ags/api/leaderboards/LeaderboardsClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardsClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getProfilesClient;
		public global::Com.Amazon.Ags.Api.Profiles.IProfilesClient ProfilesClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='getProfilesClient' and count(parameter)=0]"
			[Register ("getProfilesClient", "()Lcom/amazon/ags/api/profiles/ProfilesClient;", "GetGetProfilesClientHandler")]
			get {
				if (id_getProfilesClient == IntPtr.Zero)
					id_getProfilesClient = JNIEnv.GetMethodID (class_ref, "getProfilesClient", "()Lcom/amazon/ags/api/profiles/ProfilesClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IProfilesClient> (JNIEnv.CallObjectMethod  (Handle, id_getProfilesClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getWhispersyncClient;
		public static global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient WhispersyncClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='getWhispersyncClient' and count(parameter)=0]"
			[Register ("getWhispersyncClient", "()Lcom/amazon/ags/api/whispersync/WhispersyncClient;", "GetGetWhispersyncClientHandler")]
			get {
				if (id_getWhispersyncClient == IntPtr.Zero)
					id_getWhispersyncClient = JNIEnv.GetStaticMethodID (class_ref, "getWhispersyncClient", "()Lcom/amazon/ags/api/whispersync/WhispersyncClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWhispersyncClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.amazon.ags.api.AmazonGamesCallback'] and parameter[3][@type='java.util.EnumSet']]"
		[Register ("initialize", "(Landroid/app/Activity;Lcom/amazon/ags/api/AmazonGamesCallback;Ljava/util/EnumSet;)V", "")]
		public static void Initialize (global::Android.App.Activity p0, global::Com.Amazon.Ags.Api.IAmazonGamesCallback p1, global::Java.Util.EnumSet p2)
		{
			if (id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_ == IntPtr.Zero)
				id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/app/Activity;Lcom/amazon/ags/api/AmazonGamesCallback;Ljava/util/EnumSet;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_app_Activity_Lcom_amazon_ags_api_AmazonGamesCallback_Ljava_util_EnumSet_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_initializeJni;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='initializeJni' and count(parameter)=0]"
		[Register ("initializeJni", "()V", "")]
		public void InitializeJni ()
		{
			if (id_initializeJni == IntPtr.Zero)
				id_initializeJni = JNIEnv.GetMethodID (class_ref, "initializeJni", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_initializeJni);
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public static void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetStaticMethodID (class_ref, "release", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_release);
		}

		static IntPtr id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='setPopUpLocation' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.overlay.PopUpLocation']]"
		[Register ("setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V", "")]
		public void SetPopUpLocation (global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p0)
		{
			if (id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == IntPtr.Zero)
				id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNIEnv.GetMethodID (class_ref, "setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (p0));
		}

		static IntPtr id_showGameCircle_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='showGameCircle' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowGameCircle (params global:: Java.Lang.Object[] p0)
		{
			if (id_showGameCircle_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showGameCircle_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showGameCircle_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_showSignInPage_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='showSignInPage' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowSignInPage (params global:: Java.Lang.Object[] p0)
		{
			if (id_showSignInPage_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showSignInPage_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showSignInPage_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesClient']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public static void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetStaticMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_shutdown);
		}

	}
}
