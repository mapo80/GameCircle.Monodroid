using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractOauthTokenRequest", DoNotGenerateAcw=true)]
	public abstract partial class AbstractOauthTokenRequest : global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='API_PREFIX']"
		[Register ("API_PREFIX")]
		public const string ApiPrefix = (string) "api";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='API_PREFIX_DEVO']"
		[Register ("API_PREFIX_DEVO")]
		public const string ApiPrefixDevo = (string) "api.integ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='API_PREFIX_PRE_PROD']"
		[Register ("API_PREFIX_PRE_PROD")]
		public const string ApiPrefixPreProd = (string) "api.pre-prod";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='APP_APP_ID_PARAM']"
		[Register ("APP_APP_ID_PARAM")]
		public const string AppAppIdParam = (string) "app_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='APP_CLIENT_ID_PARAM']"
		[Register ("APP_CLIENT_ID_PARAM")]
		public const string AppClientIdParam = (string) "client_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='AUTHORIZATION_CODE_GRANT']"
		[Register ("AUTHORIZATION_CODE_GRANT")]
		public const string AuthorizationCodeGrant = (string) "authorization_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='AUTHORIZATION_CODE_PARAM']"
		[Register ("AUTHORIZATION_CODE_PARAM")]
		public const string AuthorizationCodeParam = (string) "code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='GRANT_TYPE_PARAM']"
		[Register ("GRANT_TYPE_PARAM")]
		public const string GrantTypeParam = (string) "grant_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='OAUTH_END_POINT']"
		[Register ("OAUTH_END_POINT")]
		public const string OauthEndPoint = (string) "/auth/O2/token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='REDIRECT_URI_PARAM']"
		[Register ("REDIRECT_URI_PARAM")]
		public const string RedirectUriParam = (string) "redirect_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='REFRESH_TOKEN_GRANT']"
		[Register ("REFRESH_TOKEN_GRANT")]
		public const string RefreshTokenGrant = (string) "refresh_token";

		static IntPtr mClientId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='mClientId']"
		[Register ("mClientId")]
		protected string MClientId {
			get {
				if (mClientId_jfieldId == IntPtr.Zero)
					mClientId_jfieldId = JNIEnv.GetFieldID (class_ref, "mClientId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mClientId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClientId_jfieldId == IntPtr.Zero)
					mClientId_jfieldId = JNIEnv.GetFieldID (class_ref, "mClientId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mClientId_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/AbstractOauthTokenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOauthTokenRequest); }
		}

		protected AbstractOauthTokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/constructor[@name='AbstractOauthTokenRequest' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.content.Context'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public AbstractOauthTokenRequest (string p0, string p1, string p2, string p3, global::Android.Content.Context p4, string p5, global::Android.OS.Bundle p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			IntPtr native_p5 = JNIEnv.NewString (p5);;
			if (GetType () != typeof (AbstractOauthTokenRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_getAppFamilyId;
#pragma warning disable 0169
		static Delegate GetGetAppFamilyIdHandler ()
		{
			if (cb_getAppFamilyId == null)
				cb_getAppFamilyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppFamilyId);
			return cb_getAppFamilyId;
		}

		static IntPtr n_GetAppFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		protected virtual string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/method[@name='getAppFamilyId' and count(parameter)=0]"
			[Register ("getAppFamilyId", "()Ljava/lang/String;", "GetGetAppFamilyIdHandler")]
			get {
				if (id_getAppFamilyId == IntPtr.Zero)
					id_getAppFamilyId = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEndPoint;
#pragma warning disable 0169
		static Delegate GetGetEndPointHandler ()
		{
			if (cb_getEndPoint == null)
				cb_getEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndPoint);
			return cb_getEndPoint;
		}

		static IntPtr n_GetEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndPoint;
		public override string EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Ljava/lang/String;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGrantType;
#pragma warning disable 0169
		static Delegate GetGetGrantTypeHandler ()
		{
			if (cb_getGrantType == null)
				cb_getGrantType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantType);
			return cb_getGrantType;
		}

		static IntPtr n_GetGrantType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantType);
		}
#pragma warning restore 0169

		public abstract string GrantType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/method[@name='getGrantType' and count(parameter)=0]"
			[Register ("getGrantType", "()Ljava/lang/String;", "GetGetGrantTypeHandler")] get;
		}

		static Delegate cb_addRequestInfoParameters;
#pragma warning disable 0169
		static Delegate GetAddRequestInfoParametersHandler ()
		{
			if (cb_addRequestInfoParameters == null)
				cb_addRequestInfoParameters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddRequestInfoParameters);
			return cb_addRequestInfoParameters;
		}

		static void n_AddRequestInfoParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractOauthTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddRequestInfoParameters ();
		}
#pragma warning restore 0169

		static IntPtr id_addRequestInfoParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/method[@name='addRequestInfoParameters' and count(parameter)=0]"
		[Register ("addRequestInfoParameters", "()V", "GetAddRequestInfoParametersHandler")]
		protected override void AddRequestInfoParameters ()
		{
			if (id_addRequestInfoParameters == IntPtr.Zero)
				id_addRequestInfoParameters = JNIEnv.GetMethodID (class_ref, "addRequestInfoParameters", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addRequestInfoParameters);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addRequestInfoParameters);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractOauthTokenRequest", DoNotGenerateAcw=true)]
	internal partial class AbstractOauthTokenRequestInvoker : AbstractOauthTokenRequest {

		public AbstractOauthTokenRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOauthTokenRequestInvoker); }
		}

		static IntPtr id_getGrantType;
		public override string GrantType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractOauthTokenRequest']/method[@name='getGrantType' and count(parameter)=0]"
			[Register ("getGrantType", "()Ljava/lang/String;", "GetGetGrantTypeHandler")]
			get {
				if (id_getGrantType == IntPtr.Zero)
					id_getGrantType = JNIEnv.GetMethodID (class_ref, "getGrantType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGrantType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_generateTokenResponse_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='generateTokenResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler")]
		protected override global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse GenerateTokenResponse (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_generateTokenResponse_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_generateTokenResponse_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;");
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallObjectMethod  (Handle, id_generateTokenResponse_Lorg_apache_http_HttpResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
