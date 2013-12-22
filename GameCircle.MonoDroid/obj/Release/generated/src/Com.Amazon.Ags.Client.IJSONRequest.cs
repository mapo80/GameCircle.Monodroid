using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='JSONRequest']"
	[Register ("com/amazon/ags/client/JSONRequest", "", "Com.Amazon.Ags.Client.IJSONRequestInvoker")]
	public partial interface IJSONRequest : IJavaObject {

		global::Org.Json.JSONObject Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='JSONRequest']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lorg/json/JSONObject;", "GetGetRequestHandler:Com.Amazon.Ags.Client.IJSONRequestInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='JSONRequest']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setResponse", "(Lorg/json/JSONObject;)V", "GetSetResponse_Lorg_json_JSONObject_Handler:Com.Amazon.Ags.Client.IJSONRequestInvoker, GameCircle.MonoDroid")]
		void SetResponse (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/JSONRequest", DoNotGenerateAcw=true)]
	internal class IJSONRequestInvoker : global::Java.Lang.Object, IJSONRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/JSONRequest");
		IntPtr class_ref;

		public static IJSONRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSONRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.JSONRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSONRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJSONRequestInvoker); }
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IJSONRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IJSONRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		IntPtr id_getRequest;
		public global::Org.Json.JSONObject Request {
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setResponse_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setResponse_Lorg_json_JSONObject_ == null)
				cb_setResponse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Lorg_json_JSONObject_);
			return cb_setResponse_Lorg_json_JSONObject_;
		}

		static void n_SetResponse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.IJSONRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IJSONRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_setResponse_Lorg_json_JSONObject_;
		public void SetResponse (global::Org.Json.JSONObject p0)
		{
			if (id_setResponse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setResponse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallVoidMethod (Handle, id_setResponse_Lorg_json_JSONObject_, new JValue (p0));
		}

	}

}
