using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/ProfileRequest", DoNotGenerateAcw=true)]
	public partial class ProfileRequest : global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/field[@name='API_PREFIX_DEVO']"
		[Register ("API_PREFIX_DEVO")]
		public const string ApiPrefixDevo = (string) "api.integ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/field[@name='API_PREFIX_PRE_PROD']"
		[Register ("API_PREFIX_PRE_PROD")]
		public const string ApiPrefixPreProd = (string) "api.pre-prod";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/ProfileRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileRequest); }
		}

		protected ProfileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/constructor[@name='ProfileRequest' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public ProfileRequest (string p0, string p1, string p2, global::Android.OS.Bundle p3, string p4, global::Android.Content.Context p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p4 = JNIEnv.NewString (p4);;
			if (GetType () != typeof (ProfileRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/Context;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/Context;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndPoint;
		public override string EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/method[@name='getEndPoint' and count(parameter)=0]"
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
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddRequestInfoParameters ();
		}
#pragma warning restore 0169

		static IntPtr id_addRequestInfoParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/method[@name='addRequestInfoParameters' and count(parameter)=0]"
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

		static Delegate cb_generateTokenResponse_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler ()
		{
			if (cb_generateTokenResponse_Lorg_apache_http_HttpResponse_ == null)
				cb_generateTokenResponse_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateTokenResponse_Lorg_apache_http_HttpResponse_);
			return cb_generateTokenResponse_Lorg_apache_http_HttpResponse_;
		}

		static IntPtr n_GenerateTokenResponse_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateTokenResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateTokenResponse_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='ProfileRequest']/method[@name='generateTokenResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;", "GetGenerateTokenResponse_Lorg_apache_http_HttpResponse_Handler")]
		protected override global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse GenerateTokenResponse (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_generateTokenResponse_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_generateTokenResponse_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "generateTokenResponse", "(Lorg/apache/http/HttpResponse;)Lcom/amazon/identity/auth/device/endpoint/TokenResponse;");

			global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallObjectMethod  (Handle, id_generateTokenResponse_Lorg_apache_http_HttpResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_generateTokenResponse_Lorg_apache_http_HttpResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
