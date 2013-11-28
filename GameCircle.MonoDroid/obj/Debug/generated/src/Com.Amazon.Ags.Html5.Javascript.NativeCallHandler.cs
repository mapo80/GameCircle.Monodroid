using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeCallHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/NativeCallHandler", DoNotGenerateAcw=true)]
	public partial class NativeCallHandler : global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/NativeCallHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeCallHandler); }
		}

		protected NativeCallHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_util_BrowserUtil_Lcom_amazon_ags_html5_util_EmailUtil_Lcom_amazon_ags_storage_OfflineEventManager_Lcom_amazon_ags_html5_util_ImageManager_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_content_GCVariationManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeCallHandler']/constructor[@name='NativeCallHandler' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[4][@type='com.amazon.ags.html5.util.BrowserUtil'] and parameter[5][@type='com.amazon.ags.html5.util.EmailUtil'] and parameter[6][@type='com.amazon.ags.storage.OfflineEventManager'] and parameter[7][@type='com.amazon.ags.html5.util.ImageManager'] and parameter[8][@type='com.amazon.ags.html5.util.LocalizationUtil'] and parameter[9][@type='com.amazon.ags.html5.content.GCVariationManager']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/util/BrowserUtil;Lcom/amazon/ags/html5/util/EmailUtil;Lcom/amazon/ags/storage/OfflineEventManager;Lcom/amazon/ags/html5/util/ImageManager;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/content/GCVariationManager;)V", "")]
		public NativeCallHandler (global::Android.Content.Context p0, global::Android.OS.Handler p1, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p2, global::Com.Amazon.Ags.Html5.Util.BrowserUtil p3, global::Com.Amazon.Ags.Html5.Util.EmailUtil p4, global::Com.Amazon.Ags.Storage.IOfflineEventManager p5, global::Com.Amazon.Ags.Html5.Util.ImageManager p6, global::Com.Amazon.Ags.Html5.Util.LocalizationUtil p7, global::Com.Amazon.Ags.Html5.Content.GCVariationManager p8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NativeCallHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/util/BrowserUtil;Lcom/amazon/ags/html5/util/EmailUtil;Lcom/amazon/ags/storage/OfflineEventManager;Lcom/amazon/ags/html5/util/ImageManager;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/content/GCVariationManager;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/util/BrowserUtil;Lcom/amazon/ags/html5/util/EmailUtil;Lcom/amazon/ags/storage/OfflineEventManager;Lcom/amazon/ags/html5/util/ImageManager;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/content/GCVariationManager;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_util_BrowserUtil_Lcom_amazon_ags_html5_util_EmailUtil_Lcom_amazon_ags_storage_OfflineEventManager_Lcom_amazon_ags_html5_util_ImageManager_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_content_GCVariationManager_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_util_BrowserUtil_Lcom_amazon_ags_html5_util_EmailUtil_Lcom_amazon_ags_storage_OfflineEventManager_Lcom_amazon_ags_html5_util_ImageManager_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_content_GCVariationManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/util/BrowserUtil;Lcom/amazon/ags/html5/util/EmailUtil;Lcom/amazon/ags/storage/OfflineEventManager;Lcom/amazon/ags/html5/util/ImageManager;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/content/GCVariationManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_util_BrowserUtil_Lcom_amazon_ags_html5_util_EmailUtil_Lcom_amazon_ags_storage_OfflineEventManager_Lcom_amazon_ags_html5_util_ImageManager_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_content_GCVariationManager_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_util_BrowserUtil_Lcom_amazon_ags_html5_util_EmailUtil_Lcom_amazon_ags_storage_OfflineEventManager_Lcom_amazon_ags_html5_util_ImageManager_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_content_GCVariationManager_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8));
		}

		static Delegate cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static bool n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Javascript.NativeCallHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.NativeCallHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeCallHandler']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z", "GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected override bool HandleMessage (string p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
