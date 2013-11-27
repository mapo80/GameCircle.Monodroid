using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenRequest']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenRequest", DoNotGenerateAcw=true)]
	public abstract partial class AbstractJSONTokenRequest : global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractTokenRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractJSONTokenRequest); }
		}

		protected AbstractJSONTokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenRequest']/constructor[@name='AbstractJSONTokenRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public AbstractJSONTokenRequest (string p0, string p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (AbstractJSONTokenRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getJSONString;
#pragma warning disable 0169
		static Delegate GetGetJSONStringHandler ()
		{
			if (cb_getJSONString == null)
				cb_getJSONString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSONString);
			return cb_getJSONString;
		}

		static IntPtr n_GetJSONString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.AbstractJSONTokenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JSONString);
		}
#pragma warning restore 0169

		public abstract string JSONString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenRequest']/method[@name='getJSONString' and count(parameter)=0]"
			[Register ("getJSONString", "()Ljava/lang/String;", "GetGetJSONStringHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/AbstractJSONTokenRequest", DoNotGenerateAcw=true)]
	internal partial class AbstractJSONTokenRequestInvoker : AbstractJSONTokenRequest {

		public AbstractJSONTokenRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractJSONTokenRequestInvoker); }
		}

		static IntPtr id_getJSONString;
		public override string JSONString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractJSONTokenRequest']/method[@name='getJSONString' and count(parameter)=0]"
			[Register ("getJSONString", "()Ljava/lang/String;", "GetGetJSONStringHandler")]
			get {
				if (id_getJSONString == IntPtr.Zero)
					id_getJSONString = JNIEnv.GetMethodID (class_ref, "getJSONString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getJSONString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEndPoint;
		public override string EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Ljava/lang/String;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addRequestInfoParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='AbstractTokenRequest']/method[@name='addRequestInfoParameters' and count(parameter)=0]"
		[Register ("addRequestInfoParameters", "()V", "GetAddRequestInfoParametersHandler")]
		protected override void AddRequestInfoParameters ()
		{
			if (id_addRequestInfoParameters == IntPtr.Zero)
				id_addRequestInfoParameters = JNIEnv.GetMethodID (class_ref, "addRequestInfoParameters", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_addRequestInfoParameters);
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
