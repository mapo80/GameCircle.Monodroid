using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='RequestLocalPlayerProfileJniResponseHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/profiles/RequestLocalPlayerProfileJniResponseHandler", DoNotGenerateAcw=true)]
	public partial class RequestLocalPlayerProfileJniResponseHandler : global::Com.Amazon.Ags.Jni.JniResponseHandler, global::Com.Amazon.Ags.Api.IAGResponseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/profiles/RequestLocalPlayerProfileJniResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestLocalPlayerProfileJniResponseHandler); }
		}

		protected RequestLocalPlayerProfileJniResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='RequestLocalPlayerProfileJniResponseHandler']/constructor[@name='RequestLocalPlayerProfileJniResponseHandler' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public RequestLocalPlayerProfileJniResponseHandler (int p0, long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestLocalPlayerProfileJniResponseHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IJ)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IJ)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_IJ == IntPtr.Zero)
				id_ctor_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_Handler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_ == null)
				cb_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_);
			return cb_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Jni.Profiles.RequestLocalPlayerProfileJniResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Profiles.RequestLocalPlayerProfileJniResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse p0 = (global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.profiles']/class[@name='RequestLocalPlayerProfileJniResponseHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.profiles.RequestPlayerProfileResponse']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/profiles/RequestPlayerProfileResponse;)V", "GetOnComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_Handler")]
		public virtual void OnComplete (global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse p0)
		{
			if (id_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/profiles/RequestPlayerProfileResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onComplete_Lcom_amazon_ags_api_profiles_RequestPlayerProfileResponse_, new JValue (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Api.IAGResponseCallback
		void global::Com.Amazon.Ags.Api.IAGResponseCallback.OnComplete (global::Java.Lang.Object p0)
		{
			OnComplete (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse>(p0));
		}

	}
}
