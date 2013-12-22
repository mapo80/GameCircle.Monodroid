using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/achievements/AchievementsClientImpl", DoNotGenerateAcw=true)]
	public partial class AchievementsClientImpl : global::Com.Amazon.Ags.Client.ClientBase, global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/achievements/AchievementsClientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AchievementsClientImpl); }
		}

		protected AchievementsClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/constructor[@name='AchievementsClientImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AchievementsClientImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AchievementsClientImpl)) {
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

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/constructor[@name='AchievementsClientImpl' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper'] and parameter[2][@type='com.amazon.ags.client.OverlayClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", "")]
		public AchievementsClientImpl (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0, global::Com.Amazon.Ags.Client.OverlayClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AchievementsClientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_convertToAchievement_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='convertToAchievement' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("convertToAchievement", "(Lorg/json/JSONObject;)Lcom/amazon/ags/api/achievements/Achievement;", "")]
		public static global::Com.Amazon.Ags.Api.Achievements.IAchievement ConvertToAchievement (global::Org.Json.JSONObject p0)
		{
			if (id_convertToAchievement_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_convertToAchievement_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "convertToAchievement", "(Lorg/json/JSONObject;)Lcom/amazon/ags/api/achievements/Achievement;");
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertToAchievement_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAchievement_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAchievement_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetAchievement_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAchievement (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='getAchievement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetAchievement_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievement (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getAchievements_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAchievements_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getAchievements_arrayLjava_lang_Object_ == null)
				cb_getAchievements_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAchievements_arrayLjava_lang_Object_);
			return cb_getAchievements_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetAchievements_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAchievements (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAchievements_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='getAchievements' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetAchievements_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievements (params global:: Java.Lang.Object[] p0)
		{
			if (id_getAchievements_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievements_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getAchievements_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAchievements_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
#pragma warning disable 0169
		static Delegate GetSetOverlayClient_Lcom_amazon_ags_client_OverlayClient_Handler ()
		{
			if (cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ == null)
				cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverlayClient_Lcom_amazon_ags_client_OverlayClient_);
			return cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
		}

		static void n_SetOverlayClient_Lcom_amazon_ags_client_OverlayClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.OverlayClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='setOverlayClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.OverlayClient']]"
		[Register ("setOverlayClient", "(Lcom/amazon/ags/client/OverlayClient;)V", "GetSetOverlayClient_Lcom_amazon_ags_client_OverlayClient_Handler")]
		public virtual void SetOverlayClient (global::Com.Amazon.Ags.Client.OverlayClient p0)
		{
			if (id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ == IntPtr.Zero)
				id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ = JNIEnv.GetMethodID (class_ref, "setOverlayClient", "(Lcom/amazon/ags/client/OverlayClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowAchievementsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showAchievementsOverlay_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='showAchievementsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
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
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='shutdown' and count(parameter)=0]"
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

		static Delegate cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_Handler ()
		{
			if (cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ == null)
				cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr, IntPtr>) n_UpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_);
			return cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
		}

		static IntPtr n_UpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateProgress (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementsClientImpl']/method[@name='updateProgress' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetUpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle UpdateProgress (string p0, float p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ == IntPtr.Zero)
				id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}
