using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseCallback']"
	[Register ("com/amazon/ags/api/GCResponseCallback", "", "Com.Amazon.Ags.Api.IGCResponseCallbackInvoker")]
	public partial interface IGCResponseCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseCallback']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register ("onFailure", "(ILcom/amazon/ags/api/ErrorCode;)V", "GetOnFailure_ILcom_amazon_ags_api_ErrorCode_Handler:Com.Amazon.Ags.Api.IGCResponseCallbackInvoker, GameCircle.MonoDroid")]
		void OnFailure (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSuccess", "(Lcom/amazon/ags/api/RequestResponse;)V", "GetOnSuccess_Lcom_amazon_ags_api_RequestResponse_Handler:Com.Amazon.Ags.Api.IGCResponseCallbackInvoker, GameCircle.MonoDroid")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/GCResponseCallback", DoNotGenerateAcw=true)]
	internal class IGCResponseCallbackInvoker : global::Java.Lang.Object, IGCResponseCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/GCResponseCallback");
		IntPtr class_ref;

		public static IGCResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGCResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.GCResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGCResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGCResponseCallbackInvoker); }
		}

		static Delegate cb_onFailure_ILcom_amazon_ags_api_ErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnFailure_ILcom_amazon_ags_api_ErrorCode_Handler ()
		{
			if (cb_onFailure_ILcom_amazon_ags_api_ErrorCode_ == null)
				cb_onFailure_ILcom_amazon_ags_api_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnFailure_ILcom_amazon_ags_api_ErrorCode_);
			return cb_onFailure_ILcom_amazon_ags_api_ErrorCode_;
		}

		static void n_OnFailure_ILcom_amazon_ags_api_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.IGCResponseCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IGCResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_ILcom_amazon_ags_api_ErrorCode_;
		public void OnFailure (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1)
		{
			if (id_onFailure_ILcom_amazon_ags_api_ErrorCode_ == IntPtr.Zero)
				id_onFailure_ILcom_amazon_ags_api_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(ILcom/amazon/ags/api/ErrorCode;)V");
			JNIEnv.CallVoidMethod (Handle, id_onFailure_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onSuccess_Lcom_amazon_ags_api_RequestResponse_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_amazon_ags_api_RequestResponse_Handler ()
		{
			if (cb_onSuccess_Lcom_amazon_ags_api_RequestResponse_ == null)
				cb_onSuccess_Lcom_amazon_ags_api_RequestResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_amazon_ags_api_RequestResponse_);
			return cb_onSuccess_Lcom_amazon_ags_api_RequestResponse_;
		}

		static void n_OnSuccess_Lcom_amazon_ags_api_RequestResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IGCResponseCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IGCResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_amazon_ags_api_RequestResponse_;
		public void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Lcom_amazon_ags_api_RequestResponse_ == IntPtr.Zero)
				id_onSuccess_Lcom_amazon_ags_api_RequestResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/amazon/ags/api/RequestResponse;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Lcom_amazon_ags_api_RequestResponse_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
