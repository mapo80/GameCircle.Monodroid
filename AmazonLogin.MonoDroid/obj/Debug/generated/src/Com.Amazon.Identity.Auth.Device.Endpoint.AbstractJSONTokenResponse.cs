using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenResponse", DoNotGenerateAcw=true)]
	public abstract partial class AbstractJSONTokenResponse : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		public const string AccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='COOKIE']"
		[Register ("COOKIE")]
		protected const string Cookie = (string) "cookie";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='EXPIRES_IN']"
		[Register ("EXPIRES_IN")]
		public const string ExpiresIn = (string) "expires_in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='FORCE_UPDATE']"
		[Register ("FORCE_UPDATE")]
		protected const string ForceUpdate = (string) "force_update";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='JSON_ERROR_FIELD']"
		[Register ("JSON_ERROR_FIELD")]
		protected const string JsonErrorField = (string) "error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='REFRESH_TOKEN']"
		[Register ("REFRESH_TOKEN")]
		public const string RefreshToken = (string) "refresh_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='REQUEST_ID']"
		[Register ("REQUEST_ID")]
		public const string RequestId = (string) "request_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='TOKEN']"
		[Register ("TOKEN")]
		protected const string Token = (string) "token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='TOKEN_EXPIRES_IN']"
		[Register ("TOKEN_EXPIRES_IN")]
		public const string TokenExpiresIn = (string) "token_expires_in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='TOKEN_TYPE']"
		[Register ("TOKEN_TYPE")]
		public const string TokenType = (string) "token_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/field[@name='VER_UNKOWN']"
		[Register ("VER_UNKOWN")]
		public const string VerUnkown = (string) "Unkown";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractJSONTokenResponse); }
		}

		protected AbstractJSONTokenResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/constructor[@name='AbstractJSONTokenResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register (".ctor", "(Lorg/apache/http/HttpResponse;)V", "")]
		public AbstractJSONTokenResponse (global::Org.Apache.Http.IHttpResponse p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractJSONTokenResponse)) {
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

		static Delegate cb_getEntity;
#pragma warning disable 0169
		static Delegate GetGetEntityHandler ()
		{
			if (cb_getEntity == null)
				cb_getEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntity);
			return cb_getEntity;
		}

		static IntPtr n_GetEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Entity);
		}
#pragma warning restore 0169

		static IntPtr id_getEntity;
		protected virtual string Entity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getEntity' and count(parameter)=0]"
			[Register ("getEntity", "()Ljava/lang/String;", "GetGetEntityHandler")]
			get {
				if (id_getEntity == IntPtr.Zero)
					id_getEntity = JNIEnv.GetMethodID (class_ref, "getEntity", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEntity), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEntity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getJSONResponse;
#pragma warning disable 0169
		static Delegate GetGetJSONResponseHandler ()
		{
			if (cb_getJSONResponse == null)
				cb_getJSONResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSONResponse);
			return cb_getJSONResponse;
		}

		static IntPtr n_GetJSONResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSONResponse);
		}
#pragma warning restore 0169

		static IntPtr id_getJSONResponse;
		protected virtual global::Org.Json.JSONObject JSONResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getJSONResponse' and count(parameter)=0]"
			[Register ("getJSONResponse", "()Lorg/json/JSONObject;", "GetGetJSONResponseHandler")]
			get {
				if (id_getJSONResponse == IntPtr.Zero)
					id_getJSONResponse = JNIEnv.GetMethodID (class_ref, "getJSONResponse", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSONResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getJSONResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		protected virtual global::Org.Apache.Http.IHttpResponse Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lorg/apache/http/HttpResponse;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lorg/apache/http/HttpResponse;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		public virtual int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getStatusCode);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePrimaryToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='createPrimaryToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createPrimaryToken", "(Ljava/lang/String;J)Lcom/amazon/identity/auth/device/token/Token;", "GetCreatePrimaryToken_Ljava_lang_String_JHandler")]
		public abstract global::tokenImpl.IToken CreatePrimaryToken (string p0, long p1);

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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoParse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='doParse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("doParse", "(Lorg/json/JSONObject;)V", "GetDoParse_Lorg_json_JSONObject_Handler")]
		protected abstract void DoParse (global::Org.Json.JSONObject p0);

		static Delegate cb_extractPrimaryToken_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetExtractPrimaryToken_Lorg_json_JSONObject_Handler ()
		{
			if (cb_extractPrimaryToken_Lorg_json_JSONObject_ == null)
				cb_extractPrimaryToken_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractPrimaryToken_Lorg_json_JSONObject_);
			return cb_extractPrimaryToken_Lorg_json_JSONObject_;
		}

		static IntPtr n_ExtractPrimaryToken_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractPrimaryToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractPrimaryToken_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='extractPrimaryToken' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("extractPrimaryToken", "(Lorg/json/JSONObject;)Lcom/amazon/identity/auth/device/token/Token;", "GetExtractPrimaryToken_Lorg_json_JSONObject_Handler")]
		protected virtual global::tokenImpl.IToken ExtractPrimaryToken (global::Org.Json.JSONObject p0)
		{
			if (id_extractPrimaryToken_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_extractPrimaryToken_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "extractPrimaryToken", "(Lorg/json/JSONObject;)Lcom/amazon/identity/auth/device/token/Token;");

			global::tokenImpl.IToken __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::tokenImpl.IToken> (JNIEnv.CallObjectMethod  (Handle, id_extractPrimaryToken_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::tokenImpl.IToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_extractPrimaryToken_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_extractResponseJSONObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetExtractResponseJSONObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_extractResponseJSONObject_Lorg_json_JSONObject_ == null)
				cb_extractResponseJSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractResponseJSONObject_Lorg_json_JSONObject_);
			return cb_extractResponseJSONObject_Lorg_json_JSONObject_;
		}

		static IntPtr n_ExtractResponseJSONObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractResponseJSONObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractResponseJSONObject_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='extractResponseJSONObject' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("extractResponseJSONObject", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetExtractResponseJSONObject_Lorg_json_JSONObject_Handler")]
		protected virtual global::Org.Json.JSONObject ExtractResponseJSONObject (global::Org.Json.JSONObject p0)
		{
			if (id_extractResponseJSONObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_extractResponseJSONObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "extractResponseJSONObject", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;");

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_extractResponseJSONObject_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_extractResponseJSONObject_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getExpiresIn_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetExpiresIn_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getExpiresIn_Lorg_json_JSONObject_ == null)
				cb_getExpiresIn_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetExpiresIn_Lorg_json_JSONObject_);
			return cb_getExpiresIn_Lorg_json_JSONObject_;
		}

		static long n_GetExpiresIn_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetExpiresIn (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresIn_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='getExpiresIn' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getExpiresIn", "(Lorg/json/JSONObject;)J", "GetGetExpiresIn_Lorg_json_JSONObject_Handler")]
		protected virtual long GetExpiresIn (global::Org.Json.JSONObject p0)
		{
			if (id_getExpiresIn_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getExpiresIn_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getExpiresIn", "(Lorg/json/JSONObject;)J");

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getExpiresIn_Lorg_json_JSONObject_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getExpiresIn_Lorg_json_JSONObject_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_handleForceUpdate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleForceUpdate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleForceUpdate_Lorg_json_JSONObject_ == null)
				cb_handleForceUpdate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleForceUpdate_Lorg_json_JSONObject_);
			return cb_handleForceUpdate_Lorg_json_JSONObject_;
		}

		static void n_HandleForceUpdate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleForceUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleForceUpdate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='handleForceUpdate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("handleForceUpdate", "(Lorg/json/JSONObject;)V", "GetHandleForceUpdate_Lorg_json_JSONObject_Handler")]
		protected virtual void HandleForceUpdate (global::Org.Json.JSONObject p0)
		{
			if (id_handleForceUpdate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleForceUpdate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleForceUpdate", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleForceUpdate_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_handleForceUpdate_Lorg_json_JSONObject_, new JValue (p0));
		}

		static Delegate cb_handleJSONError_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleJSONError_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleJSONError_Lorg_json_JSONObject_ == null)
				cb_handleJSONError_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleJSONError_Lorg_json_JSONObject_);
			return cb_handleJSONError_Lorg_json_JSONObject_;
		}

		static void n_HandleJSONError_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleJSONError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleJSONError_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='handleJSONError' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("handleJSONError", "(Lorg/json/JSONObject;)V", "GetHandleJSONError_Lorg_json_JSONObject_Handler")]
		protected virtual void HandleJSONError (global::Org.Json.JSONObject p0)
		{
			if (id_handleJSONError_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleJSONError_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleJSONError", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleJSONError_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_handleJSONError_Lorg_json_JSONObject_, new JValue (p0));
		}

		static IntPtr id_hasReceived500Error_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='hasReceived500Error' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("hasReceived500Error", "(Lorg/apache/http/HttpResponse;)Z", "")]
		public static bool HasReceived500Error (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_hasReceived500Error_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_hasReceived500Error_Lorg_apache_http_HttpResponse_ = JNIEnv.GetStaticMethodID (class_ref, "hasReceived500Error", "(Lorg/apache/http/HttpResponse;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasReceived500Error_Lorg_apache_http_HttpResponse_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_logRequestId_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLogRequestId_Lorg_json_JSONObject_Handler ()
		{
			if (cb_logRequestId_Lorg_json_JSONObject_ == null)
				cb_logRequestId_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogRequestId_Lorg_json_JSONObject_);
			return cb_logRequestId_Lorg_json_JSONObject_;
		}

		static void n_LogRequestId_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogRequestId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logRequestId_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='logRequestId' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("logRequestId", "(Lorg/json/JSONObject;)V", "GetLogRequestId_Lorg_json_JSONObject_Handler")]
		protected virtual void LogRequestId (global::Org.Json.JSONObject p0)
		{
			if (id_logRequestId_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_logRequestId_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "logRequestId", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logRequestId_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_logRequestId_Lorg_json_JSONObject_, new JValue (p0));
		}

		static Delegate cb_parse;
#pragma warning disable 0169
		static Delegate GetParseHandler ()
		{
			if (cb_parse == null)
				cb_parse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Parse);
			return cb_parse;
		}

		static void n_Parse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Parse ();
		}
#pragma warning restore 0169

		static IntPtr id_parse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()V", "GetParseHandler")]
		public virtual void Parse ()
		{
			if (id_parse == IntPtr.Zero)
				id_parse = JNIEnv.GetMethodID (class_ref, "parse", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_parse);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_parse);
		}

		static Delegate cb_throwUnknownAuthError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetThrowUnknownAuthError_Ljava_lang_String_Handler ()
		{
			if (cb_throwUnknownAuthError_Ljava_lang_String_ == null)
				cb_throwUnknownAuthError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ThrowUnknownAuthError_Ljava_lang_String_);
			return cb_throwUnknownAuthError_Ljava_lang_String_;
		}

		static void n_ThrowUnknownAuthError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ThrowUnknownAuthError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_throwUnknownAuthError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='throwUnknownAuthError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("throwUnknownAuthError", "(Ljava/lang/String;)V", "GetThrowUnknownAuthError_Ljava_lang_String_Handler")]
		public virtual void ThrowUnknownAuthError (string p0)
		{
			if (id_throwUnknownAuthError_Ljava_lang_String_ == IntPtr.Zero)
				id_throwUnknownAuthError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "throwUnknownAuthError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_throwUnknownAuthError_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_throwUnknownAuthError_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenResponse", DoNotGenerateAcw=true)]
	internal partial class AbstractJSONTokenResponseInvoker : AbstractJSONTokenResponse {

		public AbstractJSONTokenResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractJSONTokenResponseInvoker); }
		}

		static IntPtr id_createPrimaryToken_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='createPrimaryToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createPrimaryToken", "(Ljava/lang/String;J)Lcom/amazon/identity/auth/device/token/Token;", "GetCreatePrimaryToken_Ljava_lang_String_JHandler")]
		public override global::tokenImpl.IToken CreatePrimaryToken (string p0, long p1)
		{
			if (id_createPrimaryToken_Ljava_lang_String_J == IntPtr.Zero)
				id_createPrimaryToken_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "createPrimaryToken", "(Ljava/lang/String;J)Lcom/amazon/identity/auth/device/token/Token;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::tokenImpl.IToken __ret = global::Java.Lang.Object.GetObject<global::tokenImpl.IToken> (JNIEnv.CallObjectMethod  (Handle, id_createPrimaryToken_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_doParse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenResponse']/method[@name='doParse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("doParse", "(Lorg/json/JSONObject;)V", "GetDoParse_Lorg_json_JSONObject_Handler")]
		protected override void DoParse (global::Org.Json.JSONObject p0)
		{
			if (id_doParse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_doParse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "doParse", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallVoidMethod  (Handle, id_doParse_Lorg_json_JSONObject_, new JValue (p0));
		}

	}

}
