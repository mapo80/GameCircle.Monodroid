using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseHandle']"
	[Register ("com/amazon/ags/api/AGResponseHandle", "", "Com.Amazon.Ags.Api.IAGResponseHandleInvoker")]
	public partial interface IAGResponseHandle : IJavaObject {

		global::Java.Lang.Object Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseHandle']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/amazon/ags/api/RequestResponse;", "GetGetResponseHandler:Com.Amazon.Ags.Api.IAGResponseHandleInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Api.AGHandleStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseHandle']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/amazon/ags/api/AGHandleStatus;", "GetGetStatusHandler:Com.Amazon.Ags.Api.IAGResponseHandleInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='AGResponseHandle']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AGResponseCallback']]"
		[Register ("setCallback", "(Lcom/amazon/ags/api/AGResponseCallback;)V", "GetSetCallback_Lcom_amazon_ags_api_AGResponseCallback_Handler:Com.Amazon.Ags.Api.IAGResponseHandleInvoker, GameCircle.MonoDroid")]
		void SetCallback (global::Com.Amazon.Ags.Api.IAGResponseCallback p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/AGResponseHandle", DoNotGenerateAcw=true)]
	internal class IAGResponseHandleInvoker : global::Java.Lang.Object, IAGResponseHandle {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/AGResponseHandle");
		IntPtr class_ref;

		public static IAGResponseHandle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAGResponseHandle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.AGResponseHandle"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAGResponseHandleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAGResponseHandleInvoker); }
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAGResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public global::Java.Lang.Object Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lcom/amazon/ags/api/RequestResponse;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IAGResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		public global::Com.Amazon.Ags.Api.AGHandleStatus Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/amazon/ags/api/AGHandleStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (JNIEnv.CallObjectMethod (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setCallback_Lcom_amazon_ags_api_AGResponseCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_amazon_ags_api_AGResponseCallback_Handler ()
		{
			if (cb_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ == null)
				cb_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_amazon_ags_api_AGResponseCallback_);
			return cb_setCallback_Lcom_amazon_ags_api_AGResponseCallback_;
		}

		static void n_SetCallback_Lcom_amazon_ags_api_AGResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.IAGResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.IAGResponseCallback p0 = (global::Com.Amazon.Ags.Api.IAGResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_;
		public void SetCallback (global::Com.Amazon.Ags.Api.IAGResponseCallback p0)
		{
			if (id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/amazon/ags/api/AGResponseCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_, new JValue (p0));
		}

	}

}
