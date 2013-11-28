using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesNativeHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/profiles/ProfilesNativeHandler", DoNotGenerateAcw=true)]
	public partial class ProfilesNativeHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/profiles/ProfilesNativeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilesNativeHandler); }
		}

		protected ProfilesNativeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesNativeHandler']/constructor[@name='ProfilesNativeHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProfilesNativeHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilesNativeHandler)) {
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

		static IntPtr id_getLocalPlayerProfile_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesNativeHandler']/method[@name='getLocalPlayerProfile' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("getLocalPlayerProfile", "(IJ)V", "")]
		public static void GetLocalPlayerProfile (int p0, long p1)
		{
			if (id_getLocalPlayerProfile_IJ == IntPtr.Zero)
				id_getLocalPlayerProfile_IJ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfile", "(IJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocalPlayerProfile_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getLocalPlayerProfileHandle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesNativeHandler']/method[@name='getLocalPlayerProfileHandle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLocalPlayerProfileHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerProfileHandle (int p0)
		{
			if (id_getLocalPlayerProfileHandle_I == IntPtr.Zero)
				id_getLocalPlayerProfileHandle_I = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfileHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalPlayerProfileHandle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='ProfilesNativeHandler']/method[@name='initializeNativeHandler' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesClient']]"
		[Register ("initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V", "")]
		public static void InitializeNativeHandler (global::Com.Amazon.Ags.Api.AmazonGamesClient p0)
		{
			if (id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ == IntPtr.Zero)
				id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ = JNIEnv.GetStaticMethodID (class_ref, "initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_, new JValue (p0));
		}

	}
}
