using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='GetScoreJniResponseHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/leaderboards/GetScoreJniResponseHandler", DoNotGenerateAcw=true)]
	public partial class GetScoreJniResponseHandler : global::Com.Amazon.Ags.Jni.JniResponseHandler, global::Com.Amazon.Ags.Api.IAGResponseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/leaderboards/GetScoreJniResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetScoreJniResponseHandler); }
		}

		protected GetScoreJniResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='GetScoreJniResponseHandler']/constructor[@name='GetScoreJniResponseHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;IJ)V", "")]
		public GetScoreJniResponseHandler (string p0, int p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (GetScoreJniResponseHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IJ)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;IJ)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_IJ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Handler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_ == null)
				cb_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_);
			return cb_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Jni.Leaderboards.GetScoreJniResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Leaderboards.GetScoreJniResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse p0 = (global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='GetScoreJniResponseHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.leaderboards.GetPlayerScoreResponse']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/leaderboards/GetPlayerScoreResponse;)V", "GetOnComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Handler")]
		public virtual void OnComplete (global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse p0)
		{
			if (id_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/leaderboards/GetPlayerScoreResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onComplete_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_, new JValue (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Api.IAGResponseCallback
		void global::Com.Amazon.Ags.Api.IAGResponseCallback.OnComplete (global::Java.Lang.Object p0)
		{
			OnComplete (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse>(p0));
		}

	}
}
