using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/OverlayClient", DoNotGenerateAcw=true)]
	public partial class OverlayClient : global::Com.Amazon.Ags.Client.ClientBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/OverlayClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayClient); }
		}

		protected OverlayClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/constructor[@name='OverlayClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "")]
		public OverlayClient (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OverlayClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

		static Delegate cb_showAchievementsOverlay_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowAchievementsOverlay_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showAchievementsOverlay_arrayLjava_lang_Object_ == null)
				cb_showAchievementsOverlay_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowAchievementsOverlay_arrayLjava_lang_Object_);
			return cb_showAchievementsOverlay_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowAchievementsOverlay_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.OverlayClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowAchievementsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showAchievementsOverlay_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/method[@name='showAchievementsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showAchievementsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowAchievementsOverlay_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowAchievementsOverlay (params global:: Java.Lang.Object[] p0)
		{
			if (id_showAchievementsOverlay_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showAchievementsOverlay_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showAchievementsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showAchievementsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showAchievementsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			global::Com.Amazon.Ags.Client.OverlayClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowGameCircle (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showGameCircle_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/method[@name='showGameCircle' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowGameCircle_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowGameCircle (params global:: Java.Lang.Object[] p0)
		{
			if (id_showGameCircle_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showGameCircle_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showGameCircle", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showGameCircle_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showGameCircle_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.OverlayClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardOverlay (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/method[@name='showLeaderboardOverlay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardOverlay (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_showLeaderboardsOverlay_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowLeaderboardsOverlay_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showLeaderboardsOverlay_arrayLjava_lang_Object_ == null)
				cb_showLeaderboardsOverlay_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowLeaderboardsOverlay_arrayLjava_lang_Object_);
			return cb_showLeaderboardsOverlay_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowLeaderboardsOverlay_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.OverlayClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showLeaderboardsOverlay_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/method[@name='showLeaderboardsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardsOverlay_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay (params global:: Java.Lang.Object[] p0)
		{
			if (id_showLeaderboardsOverlay_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardsOverlay_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showLeaderboardsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showLeaderboardsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.OverlayClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowSignInPage (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showSignInPage_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='OverlayClient']/method[@name='showSignInPage' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowSignInPage_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowSignInPage (params global:: Java.Lang.Object[] p0)
		{
			if (id_showSignInPage_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showSignInPage_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showSignInPage", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showSignInPage_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showSignInPage_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
