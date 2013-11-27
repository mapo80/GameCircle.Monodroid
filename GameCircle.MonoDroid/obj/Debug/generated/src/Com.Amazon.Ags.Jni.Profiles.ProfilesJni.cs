using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesJni']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/profiles/ProfilesJni", DoNotGenerateAcw=true)]
	public partial class ProfilesJni : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/profiles/ProfilesJni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilesJni); }
		}

		protected ProfilesJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesJni']/constructor[@name='ProfilesJni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProfilesJni () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilesJni)) {
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

		static IntPtr id_getLocalPlayerProfileResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesJni']/method[@name='getLocalPlayerProfileResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getLocalPlayerProfileResponseFailure", "(JII)V", "")]
		public static void GetLocalPlayerProfileResponseFailure (long p0, int p1, int p2)
		{
			if (id_getLocalPlayerProfileResponseFailure_JII == IntPtr.Zero)
				id_getLocalPlayerProfileResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfileResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocalPlayerProfileResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getLocalPlayerProfileResponseSuccess_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesJni']/method[@name='getLocalPlayerProfileResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.profiles.RequestPlayerProfileResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getLocalPlayerProfileResponseSuccess", "(Lcom/amazon/ags/api/profiles/RequestPlayerProfileResponse;JI)V", "")]
		public static void GetLocalPlayerProfileResponseSuccess (global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse p0, long p1, int p2)
		{
			if (id_getLocalPlayerProfileResponseSuccess_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_JI == IntPtr.Zero)
				id_getLocalPlayerProfileResponseSuccess_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfileResponseSuccess", "(Lcom/amazon/ags/api/profiles/RequestPlayerProfileResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocalPlayerProfileResponseSuccess_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
