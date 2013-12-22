using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGamesCallback']"
	[Register ("com/amazon/ags/api/AmazonGamesCallback", "", "Com.Amazon.Ags.Api.IAmazonGamesCallbackInvoker")]
	public partial interface IAmazonGamesCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGamesCallback']/method[@name='onServiceNotReady' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesStatus']]"
		[Register ("onServiceNotReady", "(Lcom/amazon/ags/api/AmazonGamesStatus;)V", "GetOnServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_Handler:Com.Amazon.Ags.Api.IAmazonGamesCallbackInvoker, GameCircle.MonoDroid")]
		void OnServiceNotReady (global::Com.Amazon.Ags.Api.AmazonGamesStatus p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AmazonGamesCallback']/method[@name='onServiceReady' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesClient']]"
		[Register ("onServiceReady", "(Lcom/amazon/ags/api/AmazonGamesClient;)V", "GetOnServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_Handler:Com.Amazon.Ags.Api.IAmazonGamesCallbackInvoker, GameCircle.MonoDroid")]
		void OnServiceReady (global::Com.Amazon.Ags.Api.AmazonGamesClient p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/AmazonGamesCallback", DoNotGenerateAcw=true)]
	internal class IAmazonGamesCallbackInvoker : global::Java.Lang.Object, IAmazonGamesCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/AmazonGamesCallback");
		IntPtr class_ref;

		public static IAmazonGamesCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmazonGamesCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.AmazonGamesCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmazonGamesCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAmazonGamesCallbackInvoker); }
		}

		static Delegate cb_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_;
#pragma warning disable 0169
		static Delegate GetOnServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_Handler ()
		{
			if (cb_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_ == null)
				cb_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_);
			return cb_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_;
		}

		static void n_OnServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAmazonGamesCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGamesCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.AmazonGamesStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceNotReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_;
		public void OnServiceNotReady (global::Com.Amazon.Ags.Api.AmazonGamesStatus p0)
		{
			if (id_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_ == IntPtr.Zero)
				id_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_ = JNIEnv.GetMethodID (class_ref, "onServiceNotReady", "(Lcom/amazon/ags/api/AmazonGamesStatus;)V");
			JNIEnv.CallVoidMethod (Handle, id_onServiceNotReady_Lcom_amazon_ags_api_AmazonGamesStatus_, new JValue (p0));
		}

		static Delegate cb_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_;
#pragma warning disable 0169
		static Delegate GetOnServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_Handler ()
		{
			if (cb_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_ == null)
				cb_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_);
			return cb_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_;
		}

		static void n_OnServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAmazonGamesCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAmazonGamesCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.AmazonGamesClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_;
		public void OnServiceReady (global::Com.Amazon.Ags.Api.AmazonGamesClient p0)
		{
			if (id_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_ == IntPtr.Zero)
				id_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_ = JNIEnv.GetMethodID (class_ref, "onServiceReady", "(Lcom/amazon/ags/api/AmazonGamesClient;)V");
			JNIEnv.CallVoidMethod (Handle, id_onServiceReady_Lcom_amazon_ags_api_AmazonGamesClient_, new JValue (p0));
		}

	}

}
