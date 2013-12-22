using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ProfileHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ProfileHelper", DoNotGenerateAcw=true)]
	public partial class ProfileHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/ProfileHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileHelper); }
		}

		protected ProfileHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ProfileHelper']/constructor[@name='ProfileHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProfileHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfileHelper)) {
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

		static IntPtr id_getProfile_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ProfileHelper']/method[@name='getProfile' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amazon.identity.auth.device.shared.APIListener']]"
		[Register ("getProfile", "(Landroid/content/Context;Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)V", "")]
		public static void GetProfile (global::Android.Content.Context p0, string p1, global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener p2)
		{
			if (id_getProfile_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ == IntPtr.Zero)
				id_getProfile_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_ = JNIEnv.GetStaticMethodID (class_ref, "getProfile", "(Landroid/content/Context;Ljava/lang/String;Lcom/amazon/identity/auth/device/shared/APIListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getProfile_Landroid_content_Context_Ljava_lang_String_Lcom_amazon_identity_auth_device_shared_APIListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
