using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']"
	[Register ("com/amazon/ags/api/AmazonGames", "", "Com.Amazon.Ags.Api.IAmazonGamesInvoker")]
	public partial interface IAmazonGames : IJavaObject {

		global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient AchievementsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='getAchievementsClient' and count(parameter)=0]"
			[Register ("getAchievementsClient", "()Lcom/amazon/ags/api/achievements/AchievementsClient;", "GetGetAchievementsClientHandler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient LeaderboardsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='getLeaderboardsClient' and count(parameter)=0]"
			[Register ("getLeaderboardsClient", "()Lcom/amazon/ags/api/leaderboards/LeaderboardsClient;", "GetGetLeaderboardsClientHandler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Api.Profiles.IProfilesClient ProfilesClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='getProfilesClient' and count(parameter)=0]"
			[Register ("getProfilesClient", "()Lcom/amazon/ags/api/profiles/ProfilesClient;", "GetGetProfilesClientHandler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='initializeJni' and count(parameter)=0]"
		[Register ("initializeJni", "()V", "GetInitializeJniHandler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")]
		void InitializeJni ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='setPopUpLocation' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.overlay.PopUpLocation']]"
		[Register ("setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V", "GetSetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_Handler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")]
		void SetPopUpLocation (global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='showGameCircle' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowGameCircle_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle ShowGameCircle (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGames']/method[@name='showSignInPage' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowSignInPage_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.IAmazonGamesInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle ShowSignInPage (params global:: Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/AmazonGames", DoNotGenerateAcw=true)]
	internal class IAmazonGamesInvoker : global::Java.Lang.Object, IAmazonGames {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/AmazonGames");
		IntPtr class_ref;

		public static IAmazonGames GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmazonGames> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.AmazonGames"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmazonGamesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAmazonGamesInvoker); }
		}

		static Delegate cb_getAchievementsClient;
#pragma warning disable 0169
		static Delegate GetGetAchievementsClientHandler ()
		{
			if (cb_getAchievementsClient == null)
				cb_getAchievementsClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAchievementsClient);
			return cb_getAchievementsClient;
		}

		static IntPtr n_GetAchievementsClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AchievementsClient);
		}
#pragma warning restore 0169

		IntPtr id_getAchievementsClient;
		public global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient AchievementsClient {
			get {
				if (id_getAchievementsClient == IntPtr.Zero)
					id_getAchievementsClient = JNIEnv.GetMethodID (class_ref, "getAchievementsClient", "()Lcom/amazon/ags/api/achievements/AchievementsClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (JNIEnv.CallObjectMethod (Handle, id_getAchievementsClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLeaderboardsClient;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardsClientHandler ()
		{
			if (cb_getLeaderboardsClient == null)
				cb_getLeaderboardsClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboardsClient);
			return cb_getLeaderboardsClient;
		}

		static IntPtr n_GetLeaderboardsClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LeaderboardsClient);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboardsClient;
		public global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient LeaderboardsClient {
			get {
				if (id_getLeaderboardsClient == IntPtr.Zero)
					id_getLeaderboardsClient = JNIEnv.GetMethodID (class_ref, "getLeaderboardsClient", "()Lcom/amazon/ags/api/leaderboards/LeaderboardsClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (JNIEnv.CallObjectMethod (Handle, id_getLeaderboardsClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProfilesClient;
#pragma warning disable 0169
		static Delegate GetGetProfilesClientHandler ()
		{
			if (cb_getProfilesClient == null)
				cb_getProfilesClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfilesClient);
			return cb_getProfilesClient;
		}

		static IntPtr n_GetProfilesClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProfilesClient);
		}
#pragma warning restore 0169

		IntPtr id_getProfilesClient;
		public global::Com.Amazon.Ags.Api.Profiles.IProfilesClient ProfilesClient {
			get {
				if (id_getProfilesClient == IntPtr.Zero)
					id_getProfilesClient = JNIEnv.GetMethodID (class_ref, "getProfilesClient", "()Lcom/amazon/ags/api/profiles/ProfilesClient;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IProfilesClient> (JNIEnv.CallObjectMethod (Handle, id_getProfilesClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_initializeJni;
#pragma warning disable 0169
		static Delegate GetInitializeJniHandler ()
		{
			if (cb_initializeJni == null)
				cb_initializeJni = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeJni);
			return cb_initializeJni;
		}

		static void n_InitializeJni (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeJni ();
		}
#pragma warning restore 0169

		IntPtr id_initializeJni;
		public void InitializeJni ()
		{
			if (id_initializeJni == IntPtr.Zero)
				id_initializeJni = JNIEnv.GetMethodID (class_ref, "initializeJni", "()V");
			JNIEnv.CallVoidMethod (Handle, id_initializeJni);
		}

		static Delegate cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
#pragma warning disable 0169
		static Delegate GetSetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_Handler ()
		{
			if (cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == null)
				cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_);
			return cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
		}

		static void n_SetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPopUpLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
		public void SetPopUpLocation (global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p0)
		{
			if (id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == IntPtr.Zero)
				id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNIEnv.GetMethodID (class_ref, "setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (p0));
		}

		static Delegate cb_showGameCircle_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowGameCircle_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showGameCircle_arrayLjava_lang_Object_ == null)
				cb_showGameCircle_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowGameCircle_arrayLjava_lang_Object_);
			return cb_showGameCircle_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowGameCircle_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowGameCircle (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showGameCircle_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowGameCircle (params global:: Java.Lang.Object[] p0)
		{
			if (id_showGameCircle_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showGameCircle_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_showGameCircle_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_showSignInPage_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowSignInPage_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showSignInPage_arrayLjava_lang_Object_ == null)
				cb_showSignInPage_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowSignInPage_arrayLjava_lang_Object_);
			return cb_showSignInPage_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowSignInPage_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAmazonGames __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowSignInPage (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showSignInPage_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowSignInPage (params global:: Java.Lang.Object[] p0)
		{
			if (id_showSignInPage_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showSignInPage_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_showSignInPage_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
