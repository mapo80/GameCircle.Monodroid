using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/RequestResponseImpl", DoNotGenerateAcw=true)]
	public partial class RequestResponseImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.IRequestResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/RequestResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestResponseImpl); }
		}

		protected RequestResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/constructor[@name='RequestResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public RequestResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILcom_amazon_ags_api_ErrorCode_ == IntPtr.Zero)
				id_ctor_ILcom_amazon_ags_api_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/amazon/ags/api/ErrorCode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/constructor[@name='RequestResponseImpl' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public RequestResponseImpl (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/constructor[@name='RequestResponseImpl' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public RequestResponseImpl (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0));
		}

		static IntPtr id_getError;
		public global::Com.Amazon.Ags.Api.ErrorCode Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/amazon/ags/api/ErrorCode;", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Lcom/amazon/ags/api/ErrorCode;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (JNIEnv.CallObjectMethod  (Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEventType;
#pragma warning disable 0169
		static Delegate GetGetEventTypeHandler ()
		{
			if (cb_getEventType == null)
				cb_getEventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEventType);
			return cb_getEventType;
		}

		static int n_GetEventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.RequestResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.RequestResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EventType;
		}
#pragma warning restore 0169

		static IntPtr id_getEventType;
		public virtual int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getEventType);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getEventType);
			}
		}

		static IntPtr id_isError;
		public bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler")]
			get {
				if (id_isError == IntPtr.Zero)
					id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isError);
			}
		}

		static IntPtr id_getResponseCode;
		public int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getResponseCode);
			}
		}

		static IntPtr id_getUserData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='getUserData' and count(parameter)=0]"
		[Register ("getUserData", "()[Ljava/lang/Object;", "")]
		public global::Java.Lang.Object[] GetUserData ()
		{
			if (id_getUserData == IntPtr.Zero)
				id_getUserData = JNIEnv.GetMethodID (class_ref, "getUserData", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getUserData), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static IntPtr id_setUserData_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='RequestResponseImpl']/method[@name='setUserData' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("setUserData", "([Ljava/lang/Object;)V", "")]
		public void SetUserData (global::Java.Lang.Object[] p0)
		{
			if (id_setUserData_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setUserData_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setUserData", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setUserData_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
