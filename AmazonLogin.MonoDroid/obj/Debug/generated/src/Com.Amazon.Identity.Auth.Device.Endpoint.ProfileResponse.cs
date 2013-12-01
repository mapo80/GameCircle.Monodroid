using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileResponse']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/ProfileResponse", DoNotGenerateAcw=true)]
	public partial class ProfileResponse : global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/ProfileResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileResponse); }
		}

		protected ProfileResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileResponse']/constructor[@name='ProfileResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register (".ctor", "(Lorg/apache/http/HttpResponse;)V", "")]
		public ProfileResponse (global::Org.Apache.Http.IHttpResponse p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfileResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/HttpResponse;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/HttpResponse;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_ctor_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/HttpResponse;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_HttpResponse_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_HttpResponse_, new JValue (p0));
		}

		static Delegate cb_createPrimaryToken_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetCreatePrimaryToken_Ljava_lang_String_JHandler ()
		{
			if (cb_createPrimaryToken_Ljava_lang_String_J == null)
				cb_createPrimaryToken_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_CreatePrimaryToken_Ljava_lang_String_J);
			return cb_createPrimaryToken_Ljava_lang_String_J;
		}

		static IntPtr n_CreatePrimaryToken_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePrimaryToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPrimaryToken_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileResponse']/method[@name='createPrimaryToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createPrimaryToken", "(Ljava/lang/String;J)Lcom/amazon/identity/auth/device/token/Token;", "GetCreatePrimaryToken_Ljava_lang_String_JHandler")]
		public override global::tokenImpl.IToken CreatePrimaryToken (string p0, long p1)
		{
			if (id_createPrimaryToken_Ljava_lang_String_J == IntPtr.Zero)
				id_createPrimaryToken_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "createPrimaryToken", "(Ljava/lang/String;J)Lcom/amazon/identity/auth/device/token/Token;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::tokenImpl.IToken __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::tokenImpl.IToken> (JNIEnv.CallObjectMethod  (Handle, id_createPrimaryToken_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::tokenImpl.IToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createPrimaryToken_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_doParse_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDoParse_Lorg_json_JSONObject_Handler ()
		{
			if (cb_doParse_Lorg_json_JSONObject_ == null)
				cb_doParse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoParse_Lorg_json_JSONObject_);
			return cb_doParse_Lorg_json_JSONObject_;
		}

		static void n_DoParse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoParse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doParse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileResponse']/method[@name='doParse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("doParse", "(Lorg/json/JSONObject;)V", "GetDoParse_Lorg_json_JSONObject_Handler")]
		protected override void DoParse (global::Org.Json.JSONObject p0)
		{
			if (id_doParse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_doParse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "doParse", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doParse_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_doParse_Lorg_json_JSONObject_, new JValue (p0));
		}

		static Delegate cb_getProfileResponse;
#pragma warning disable 0169
		static Delegate GetGetProfileResponseHandler ()
		{
			if (cb_getProfileResponse == null)
				cb_getProfileResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfileResponse);
			return cb_getProfileResponse;
		}

		static IntPtr n_GetProfileResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetProfileResponse ());
		}
#pragma warning restore 0169

		static IntPtr id_getProfileResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileResponse']/method[@name='getProfileResponse' and count(parameter)=0]"
		[Register ("getProfileResponse", "()Lorg/json/JSONObject;", "GetGetProfileResponseHandler")]
		public virtual global::Org.Json.JSONObject GetProfileResponse ()
		{
			if (id_getProfileResponse == IntPtr.Zero)
				id_getProfileResponse = JNIEnv.GetMethodID (class_ref, "getProfileResponse", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getProfileResponse), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProfileResponse), JniHandleOwnership.TransferLocalRef);
		}

	}
}
