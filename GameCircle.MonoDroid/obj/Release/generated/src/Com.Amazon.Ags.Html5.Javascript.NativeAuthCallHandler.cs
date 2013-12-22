using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeAuthCallHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/NativeAuthCallHandler", DoNotGenerateAcw=true)]
	public partial class NativeAuthCallHandler : global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/NativeAuthCallHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAuthCallHandler); }
		}

		protected NativeAuthCallHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_Lcom_amazon_ags_auth_AuthManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeAuthCallHandler']/constructor[@name='NativeAuthCallHandler' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.amazon.ags.auth.AuthManager']]"
		[Register (".ctor", "(Landroid/os/Handler;Lcom/amazon/ags/auth/AuthManager;)V", "")]
		public NativeAuthCallHandler (global::Android.OS.Handler p0, global::Com.Amazon.Ags.Auth.AuthManager p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NativeAuthCallHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;Lcom/amazon/ags/auth/AuthManager;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;Lcom/amazon/ags/auth/AuthManager;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_os_Handler_Lcom_amazon_ags_auth_AuthManager_ == IntPtr.Zero)
				id_ctor_Landroid_os_Handler_Lcom_amazon_ags_auth_AuthManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;Lcom/amazon/ags/auth/AuthManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_Lcom_amazon_ags_auth_AuthManager_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_Lcom_amazon_ags_auth_AuthManager_, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Ags.Html5.Javascript.NativeAuthCallHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.NativeAuthCallHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='NativeAuthCallHandler']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
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
