using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='ThirdPartyResourceParser']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/ThirdPartyResourceParser", DoNotGenerateAcw=true)]
	public partial class ThirdPartyResourceParser : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='ThirdPartyResourceParser']/field[@name='KEY_API_KEY']"
		[Register ("KEY_API_KEY")]
		public const string KeyApiKey = (string) "APIKey";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/ThirdPartyResourceParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThirdPartyResourceParser); }
		}

		protected ThirdPartyResourceParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='ThirdPartyResourceParser']/constructor[@name='ThirdPartyResourceParser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public ThirdPartyResourceParser (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (ThirdPartyResourceParser)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getApiKey;
#pragma warning disable 0169
		static Delegate GetGetApiKeyHandler ()
		{
			if (cb_getApiKey == null)
				cb_getApiKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiKey);
			return cb_getApiKey;
		}

		static IntPtr n_GetApiKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.ThirdPartyResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.ThirdPartyResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiKey);
		}
#pragma warning restore 0169

		static IntPtr id_getApiKey;
		public virtual string ApiKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='ThirdPartyResourceParser']/method[@name='getApiKey' and count(parameter)=0]"
			[Register ("getApiKey", "()Ljava/lang/String;", "GetGetApiKeyHandler")]
			get {
				if (id_getApiKey == IntPtr.Zero)
					id_getApiKey = JNIEnv.GetMethodID (class_ref, "getApiKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApiKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApiKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isApiKeyInAssest;
#pragma warning disable 0169
		static Delegate GetIsApiKeyInAssestHandler ()
		{
			if (cb_isApiKeyInAssest == null)
				cb_isApiKeyInAssest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsApiKeyInAssest);
			return cb_isApiKeyInAssest;
		}

		static bool n_IsApiKeyInAssest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.ThirdPartyResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.ThirdPartyResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsApiKeyInAssest;
		}
#pragma warning restore 0169

		static IntPtr id_isApiKeyInAssest;
		public virtual bool IsApiKeyInAssest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='ThirdPartyResourceParser']/method[@name='isApiKeyInAssest' and count(parameter)=0]"
			[Register ("isApiKeyInAssest", "()Z", "GetIsApiKeyInAssestHandler")]
			get {
				if (id_isApiKeyInAssest == IntPtr.Zero)
					id_isApiKeyInAssest = JNIEnv.GetMethodID (class_ref, "isApiKeyInAssest", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isApiKeyInAssest);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isApiKeyInAssest);
			}
		}

	}
}
