using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/AGResponseHandleImpl", DoNotGenerateAcw=true)]
	public partial class AGResponseHandleImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.IAGResponseHandle {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/AGResponseHandleImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGResponseHandleImpl); }
		}

		protected AGResponseHandleImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']/constructor[@name='AGResponseHandleImpl' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public AGResponseHandleImpl (global::Java.Lang.Object[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (AGResponseHandleImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Ljava/lang/Object;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Ljava/lang/Object;)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ctor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Amazon.Ags.Client.AGResponseHandleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.AGResponseHandleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static Delegate cb_setResponse_Lcom_amazon_ags_api_RequestResponse_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Lcom_amazon_ags_api_RequestResponse_Handler ()
		{
			if (cb_setResponse_Lcom_amazon_ags_api_RequestResponse_ == null)
				cb_setResponse_Lcom_amazon_ags_api_RequestResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Lcom_amazon_ags_api_RequestResponse_);
			return cb_setResponse_Lcom_amazon_ags_api_RequestResponse_;
		}

		static void n_SetResponse_Lcom_amazon_ags_api_RequestResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.AGResponseHandleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.AGResponseHandleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Response = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Lcom_amazon_ags_api_RequestResponse_;
		public virtual global::Java.Lang.Object Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/amazon/ags/api/RequestResponse;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lcom/amazon/ags/api/RequestResponse;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setResponse", "(Lcom/amazon/ags/api/RequestResponse;)V", "GetSetResponse_Lcom_amazon_ags_api_RequestResponse_Handler")]
			set {
				if (id_setResponse_Lcom_amazon_ags_api_RequestResponse_ == IntPtr.Zero)
					id_setResponse_Lcom_amazon_ags_api_RequestResponse_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Lcom/amazon/ags/api/RequestResponse;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResponse_Lcom_amazon_ags_api_RequestResponse_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setResponse_Lcom_amazon_ags_api_RequestResponse_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Ags.Client.AGResponseHandleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.AGResponseHandleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual global::Com.Amazon.Ags.Api.AGHandleStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/amazon/ags/api/AGHandleStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/amazon/ags/api/AGHandleStatus;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStatus), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.AGResponseHandleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.AGResponseHandleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.IAGResponseCallback p0 = (global::Com.Amazon.Ags.Api.IAGResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='AGResponseHandleImpl']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AGResponseCallback']]"
		[Register ("setCallback", "(Lcom/amazon/ags/api/AGResponseCallback;)V", "GetSetCallback_Lcom_amazon_ags_api_AGResponseCallback_Handler")]
		public virtual void SetCallback (global::Com.Amazon.Ags.Api.IAGResponseCallback p0)
		{
			if (id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/amazon/ags/api/AGResponseCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCallback_Lcom_amazon_ags_api_AGResponseCallback_, new JValue (p0));
		}

	}
}
