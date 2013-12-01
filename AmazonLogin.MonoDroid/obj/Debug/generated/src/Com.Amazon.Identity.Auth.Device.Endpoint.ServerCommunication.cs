using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/ServerCommunication", DoNotGenerateAcw=true)]
	public partial class ServerCommunication : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/ServerCommunication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerCommunication); }
		}

		protected ServerCommunication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/constructor[@name='ServerCommunication' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ServerCommunication () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ServerCommunication)) {
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

		static Delegate cb_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == null)
				cb_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_);
			return cb_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		}

		static void n_Authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='authorize' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='android.content.Context']]"
		[Register ("authorize", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)V", "GetAuthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler")]
		public virtual void Authorize (string p0, string p1, string[] p2, global::Android.Content.Context p3)
		{
			if (id_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_authorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_checkNetwork_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='checkNetwork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkNetwork", "(Landroid/content/Context;)V", "")]
		public static void CheckNetwork (global::Android.Content.Context p0)
		{
			if (id_checkNetwork_Landroid_content_Context_ == IntPtr.Zero)
				id_checkNetwork_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkNetwork", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNetwork_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDeauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == null)
				cb_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_);
			return cb_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		}

		static void n_Deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Deauthorize (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='deauthorize' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='android.content.Context']]"
		[Register ("deauthorize", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)V", "GetDeauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler")]
		public virtual void Deauthorize (string p0, string p1, string[] p2, global::Android.Content.Context p3)
		{
			if (id_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "deauthorize", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deauthorize_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::tokenImpl.RefreshAtzToken p0 = global::Java.Lang.Object.GetObject<global::tokenImpl.RefreshAtzToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p5 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccessAuthorizationToken (p0, p1, p2, p3, p4, p5));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='getAccessAuthorizationToken' and count(parameter)=6 and parameter[1][@type='com.amazon.identity.auth.device.token.RefreshAtzToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.content.Context']]"
		[Register ("getAccessAuthorizationToken", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;", "GetGetAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken GetAccessAuthorizationToken (global::tokenImpl.RefreshAtzToken p0, string p1, string p2, string[] p3, string p4, global::Android.Content.Context p5)
		{
			if (id_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAccessAuthorizationToken", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (JNIEnv.CallObjectMethod  (Handle, id_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAccessAuthorizationToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::tokenImpl.RefreshAtzToken p0 = global::Java.Lang.Object.GetObject<global::tokenImpl.RefreshAtzToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p5 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAuthorizationTokens (p0, p1, p2, p3, p4, p5));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='getAuthorizationTokens' and count(parameter)=6 and parameter[1][@type='com.amazon.identity.auth.device.token.RefreshAtzToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.content.Context']]"
		[Register ("getAuthorizationTokens", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;", "GetGetAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[] GetAuthorizationTokens (global::tokenImpl.RefreshAtzToken p0, string p1, string p2, string[] p3, string p4, global::Android.Content.Context p5)
		{
			if (id_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAuthorizationTokens", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[] __ret;
			if (GetType () == ThresholdType)
				__ret = (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken));
			else
				__ret = (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAuthorizationTokens_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_getDeviceId_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetDeviceId_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getDeviceId_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getDeviceId_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDeviceId_Ljava_lang_String_Landroid_content_Context_);
			return cb_getDeviceId_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetDeviceId_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDeviceId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='getDeviceId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetDeviceId_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual string GetDeviceId (string p0, global::Android.Content.Context p1)
		{
			if (id_getDeviceId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDeviceId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getProfile_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProfile_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getProfile_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getProfile_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProfile_Landroid_content_Context_Ljava_lang_String_);
			return cb_getProfile_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetProfile_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProfile (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProfile_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='getProfile' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getProfile", "(Landroid/content/Context;Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetProfile_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONObject GetProfile (global::Android.Content.Context p0, string p1)
		{
			if (id_getProfile_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getProfile_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProfile", "(Landroid/content/Context;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getProfile_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProfile_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == null)
				cb_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_);
			return cb_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string[] p4 = (string[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.Content.Context p5 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetTokensFromCode (p0, p1, p2, p3, p4, p5));
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='getTokensFromCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='android.content.Context']]"
		[Register ("getTokensFromCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;", "GetGetTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_Handler")]
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[] GetTokensFromCode (string p0, string p1, string p2, string p3, string[] p4, global::Android.Content.Context p5)
		{
			if (id_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getTokensFromCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);

			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[] __ret;
			if (GetType () == ThresholdType)
				__ret = (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken));
			else
				__ret = (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetHasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_);
			return cb_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_HasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HasScope (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='hasScope' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
		[Register ("hasScope", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/Boolean;", "GetHasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual global::Java.Lang.Boolean HasScope (string p0, string p1, string p2, global::Android.Content.Context p3)
		{
			if (id_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "hasScope", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			global::Java.Lang.Boolean __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_hasScope_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_hasScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ServerCommunication']/method[@name='hasScopes' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='android.content.Context']]"
		[Register ("hasScopes", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> HasScopes (string p0, string p1, string[] p2, global::Android.Content.Context p3)
		{
			if (id_hasScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_hasScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "hasScopes", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_hasScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}
