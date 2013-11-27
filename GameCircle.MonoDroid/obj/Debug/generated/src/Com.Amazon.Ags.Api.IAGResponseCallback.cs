using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseCallback']"
	[Register ("com/amazon/ags/api/AGResponseCallback", "", "Com.Amazon.Ags.Api.IAGResponseCallbackInvoker")]
	public partial interface IAGResponseCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseCallback']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/RequestResponse;)V", "GetOnComplete_Lcom_amazon_ags_api_RequestResponse_Handler:Com.Amazon.Ags.Api.IAGResponseCallbackInvoker, GameCircle.MonoDroid")]
		void OnComplete (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/AGResponseCallback", DoNotGenerateAcw=true)]
	internal class IAGResponseCallbackInvoker : global::Java.Lang.Object, IAGResponseCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/AGResponseCallback");
		IntPtr class_ref;

		public static IAGResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAGResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.AGResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAGResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAGResponseCallbackInvoker); }
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_RequestResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_RequestResponse_Handler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_RequestResponse_ == null)
				cb_onComplete_Lcom_amazon_ags_api_RequestResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_RequestResponse_);
			return cb_onComplete_Lcom_amazon_ags_api_RequestResponse_;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_RequestResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAGResponseCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_amazon_ags_api_RequestResponse_;
		public void OnComplete (global::Java.Lang.Object p0)
		{
			if (id_onComplete_Lcom_amazon_ags_api_RequestResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_RequestResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/RequestResponse;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_Lcom_amazon_ags_api_RequestResponse_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
