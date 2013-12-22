using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/OverlayManager", DoNotGenerateAcw=true)]
	public partial class OverlayManager : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Factory.IAGSClientInstanceCoordinatorListener, global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager.InGameToastWrapper']"
		[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/OverlayManager$InGameToastWrapper", DoNotGenerateAcw=true)]
		public partial class InGameToastWrapper : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/OverlayManager$InGameToastWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InGameToastWrapper); }
			}

			protected InGameToastWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_html5_overlay_toasts_ClickableToast_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager.InGameToastWrapper']/constructor[@name='OverlayManager.InGameToastWrapper' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set'] and parameter[3][@type='com.amazon.ags.html5.overlay.toasts.ClickableToast']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;)V", "")]
			public InGameToastWrapper (string p0, global::System.Collections.Generic.ICollection<string> p1, global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);;
				if (GetType () != typeof (InGameToastWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_html5_overlay_toasts_ClickableToast_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_html5_overlay_toasts_ClickableToast_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_html5_overlay_toasts_ClickableToast_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_html5_overlay_toasts_ClickableToast_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_getToast;
#pragma warning disable 0169
			static Delegate GetGetToastHandler ()
			{
				if (cb_getToast == null)
					cb_getToast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToast);
				return cb_getToast;
			}

			static IntPtr n_GetToast (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Toast);
			}
#pragma warning restore 0169

			static IntPtr id_getToast;
			public virtual global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast Toast {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager.InGameToastWrapper']/method[@name='getToast' and count(parameter)=0]"
				[Register ("getToast", "()Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;", "GetGetToastHandler")]
				get {
					if (id_getToast == IntPtr.Zero)
						id_getToast = JNIEnv.GetMethodID (class_ref, "getToast", "()Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (JNIEnv.CallObjectMethod  (Handle, id_getToast), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getToast), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_aggregate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAggregate_Ljava_lang_String_Handler ()
			{
				if (cb_aggregate_Ljava_lang_String_ == null)
					cb_aggregate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Aggregate_Ljava_lang_String_);
				return cb_aggregate_Ljava_lang_String_;
			}

			static void n_Aggregate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Aggregate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_aggregate_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager.InGameToastWrapper']/method[@name='aggregate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("aggregate", "(Ljava/lang/String;)V", "GetAggregate_Ljava_lang_String_Handler")]
			public virtual void Aggregate (string p0)
			{
				if (id_aggregate_Ljava_lang_String_ == IntPtr.Zero)
					id_aggregate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "aggregate", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_aggregate_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_aggregate_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_isDedupeCompatibleWithType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIsDedupeCompatibleWithType_Ljava_lang_String_Handler ()
			{
				if (cb_isDedupeCompatibleWithType_Ljava_lang_String_ == null)
					cb_isDedupeCompatibleWithType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDedupeCompatibleWithType_Ljava_lang_String_);
				return cb_isDedupeCompatibleWithType_Ljava_lang_String_;
			}

			static bool n_IsDedupeCompatibleWithType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager.InGameToastWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsDedupeCompatibleWithType (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_isDedupeCompatibleWithType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager.InGameToastWrapper']/method[@name='isDedupeCompatibleWithType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isDedupeCompatibleWithType", "(Ljava/lang/String;)Z", "GetIsDedupeCompatibleWithType_Ljava_lang_String_Handler")]
			public virtual bool IsDedupeCompatibleWithType (string p0)
			{
				if (id_isDedupeCompatibleWithType_Ljava_lang_String_ == IntPtr.Zero)
					id_isDedupeCompatibleWithType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isDedupeCompatibleWithType", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDedupeCompatibleWithType_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isDedupeCompatibleWithType_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/OverlayManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayManager); }
		}

		protected OverlayManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastFactory_Lcom_amazon_ags_client_KindleFireProxy_Lcom_amazon_ags_html5_overlay_OverlaySessionInformation_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_util_ImageManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/constructor[@name='OverlayManager' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='com.amazon.ags.html5.overlay.toasts.ClickableToastFactory'] and parameter[4][@type='com.amazon.ags.client.KindleFireProxy'] and parameter[5][@type='com.amazon.ags.html5.overlay.OverlaySessionInformation'] and parameter[6][@type='com.amazon.ags.html5.content.GCVariationManager'] and parameter[7][@type='com.amazon.ags.html5.util.ImageManager']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastFactory;Lcom/amazon/ags/client/KindleFireProxy;Lcom/amazon/ags/html5/overlay/OverlaySessionInformation;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/util/ImageManager;)V", "")]
		public OverlayManager (global::Android.Content.Context p0, global::Android.OS.Handler p1, global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactory p2, global::Com.Amazon.Ags.Client.IKindleFireProxy p3, global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation p4, global::Com.Amazon.Ags.Html5.Content.GCVariationManager p5, global::Com.Amazon.Ags.Html5.Util.ImageManager p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OverlayManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastFactory;Lcom/amazon/ags/client/KindleFireProxy;Lcom/amazon/ags/html5/overlay/OverlaySessionInformation;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/util/ImageManager;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastFactory;Lcom/amazon/ags/client/KindleFireProxy;Lcom/amazon/ags/html5/overlay/OverlaySessionInformation;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/util/ImageManager;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastFactory_Lcom_amazon_ags_client_KindleFireProxy_Lcom_amazon_ags_html5_overlay_OverlaySessionInformation_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_util_ImageManager_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastFactory_Lcom_amazon_ags_client_KindleFireProxy_Lcom_amazon_ags_html5_overlay_OverlaySessionInformation_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_util_ImageManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastFactory;Lcom/amazon/ags/client/KindleFireProxy;Lcom/amazon/ags/html5/overlay/OverlaySessionInformation;Lcom/amazon/ags/html5/content/GCVariationManager;Lcom/amazon/ags/html5/util/ImageManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastFactory_Lcom_amazon_ags_client_KindleFireProxy_Lcom_amazon_ags_html5_overlay_OverlaySessionInformation_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_util_ImageManager_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastFactory_Lcom_amazon_ags_client_KindleFireProxy_Lcom_amazon_ags_html5_overlay_OverlaySessionInformation_Lcom_amazon_ags_html5_content_GCVariationManager_Lcom_amazon_ags_html5_util_ImageManager_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
		}

		static Delegate cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler ()
		{
			if (cb_notifyCurrentActivityChanged_Landroid_app_Activity_ == null)
				cb_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyCurrentActivityChanged_Landroid_app_Activity_);
			return cb_notifyCurrentActivityChanged_Landroid_app_Activity_;
		}

		static void n_NotifyCurrentActivityChanged_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCurrentActivityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyCurrentActivityChanged_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/method[@name='notifyCurrentActivityChanged' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyCurrentActivityChanged", "(Landroid/app/Activity;)V", "GetNotifyCurrentActivityChanged_Landroid_app_Activity_Handler")]
		public virtual void NotifyCurrentActivityChanged (global::Android.App.Activity p0)
		{
			if (id_notifyCurrentActivityChanged_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyCurrentActivityChanged_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "notifyCurrentActivityChanged", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyCurrentActivityChanged_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_notifyToastDestroyed;
#pragma warning disable 0169
		static Delegate GetNotifyToastDestroyedHandler ()
		{
			if (cb_notifyToastDestroyed == null)
				cb_notifyToastDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyToastDestroyed);
			return cb_notifyToastDestroyed;
		}

		static void n_NotifyToastDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyToastDestroyed ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyToastDestroyed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/method[@name='notifyToastDestroyed' and count(parameter)=0]"
		[Register ("notifyToastDestroyed", "()V", "GetNotifyToastDestroyedHandler")]
		public virtual void NotifyToastDestroyed ()
		{
			if (id_notifyToastDestroyed == IntPtr.Zero)
				id_notifyToastDestroyed = JNIEnv.GetMethodID (class_ref, "notifyToastDestroyed", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyToastDestroyed);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyToastDestroyed);
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
			global::Com.Amazon.Ags.Html5.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowAlert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showAlert_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/method[@name='showAlert' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Amazon.Ags.Html5.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowOverlay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showOverlay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/method[@name='showOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Amazon.Ags.Html5.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowToast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showToast_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlayManager']/method[@name='showToast' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
