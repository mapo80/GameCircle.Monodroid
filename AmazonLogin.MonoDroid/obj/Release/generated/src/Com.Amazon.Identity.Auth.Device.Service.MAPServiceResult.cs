using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.service']/class[@name='MAPServiceResult']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/service/MAPServiceResult", DoNotGenerateAcw=true)]
	public sealed partial class MAPServiceResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/service/MAPServiceResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPServiceResult); }
		}

		internal MAPServiceResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getOnCancelBundle_IarrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.service']/class[@name='MAPServiceResult']/method[@name='getOnCancelBundle' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getOnCancelBundle", "(I[Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetOnCancelBundle (int p0, string[] p1)
		{
			if (id_getOnCancelBundle_IarrayLjava_lang_String_ == IntPtr.Zero)
				id_getOnCancelBundle_IarrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOnCancelBundle", "(I[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnCancelBundle_IarrayLjava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_getOnErrorBundle_Lcom_amazon_identity_auth_device_AuthError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.service']/class[@name='MAPServiceResult']/method[@name='getOnErrorBundle' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("getOnErrorBundle", "(Lcom/amazon/identity/auth/device/AuthError;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetOnErrorBundle (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_getOnErrorBundle_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_getOnErrorBundle_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetStaticMethodID (class_ref, "getOnErrorBundle", "(Lcom/amazon/identity/auth/device/AuthError;)Landroid/os/Bundle;");
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnErrorBundle_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getOnSuccessBundle_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.service']/class[@name='MAPServiceResult']/method[@name='getOnSuccessBundle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getOnSuccessBundle", "(Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetOnSuccessBundle (string p0, string p1)
		{
			if (id_getOnSuccessBundle_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getOnSuccessBundle_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOnSuccessBundle", "(Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnSuccessBundle_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
