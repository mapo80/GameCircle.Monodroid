using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventJSONRequest']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventJSONRequest", DoNotGenerateAcw=true)]
	public partial class OfflineEventJSONRequest : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.IJSONRequest {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventJSONRequest.OfflineEventJSONCallback']"
		[Register ("com/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback", "", "Com.Amazon.Ags.Storage.OfflineEventJSONRequest/IOfflineEventJSONCallbackInvoker")]
		public partial interface IOfflineEventJSONCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventJSONRequest.OfflineEventJSONCallback']/method[@name='onRecoverableError' and count(parameter)=0]"
			[Register ("onRecoverableError", "()V", "GetOnRecoverableErrorHandler:Com.Amazon.Ags.Storage.OfflineEventJSONRequest/IOfflineEventJSONCallbackInvoker, GameCircle.MonoDroid")]
			void OnRecoverableError ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventJSONRequest.OfflineEventJSONCallback']/method[@name='onSuccess' and count(parameter)=0]"
			[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Amazon.Ags.Storage.OfflineEventJSONRequest/IOfflineEventJSONCallbackInvoker, GameCircle.MonoDroid")]
			void OnSuccess ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventJSONRequest.OfflineEventJSONCallback']/method[@name='onUnrecoverableError' and count(parameter)=0]"
			[Register ("onUnrecoverableError", "()V", "GetOnUnrecoverableErrorHandler:Com.Amazon.Ags.Storage.OfflineEventJSONRequest/IOfflineEventJSONCallbackInvoker, GameCircle.MonoDroid")]
			void OnUnrecoverableError ();

		}

		[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback", DoNotGenerateAcw=true)]
		internal class IOfflineEventJSONCallbackInvoker : global::Java.Lang.Object, IOfflineEventJSONCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback");
			IntPtr class_ref;

			public static IOfflineEventJSONCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOfflineEventJSONCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.storage.OfflineEventJSONRequest.OfflineEventJSONCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOfflineEventJSONCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOfflineEventJSONCallbackInvoker); }
			}

			static Delegate cb_onRecoverableError;
#pragma warning disable 0169
			static Delegate GetOnRecoverableErrorHandler ()
			{
				if (cb_onRecoverableError == null)
					cb_onRecoverableError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecoverableError);
				return cb_onRecoverableError;
			}

			static void n_OnRecoverableError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecoverableError ();
			}
#pragma warning restore 0169

			IntPtr id_onRecoverableError;
			public void OnRecoverableError ()
			{
				if (id_onRecoverableError == IntPtr.Zero)
					id_onRecoverableError = JNIEnv.GetMethodID (class_ref, "onRecoverableError", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onRecoverableError);
			}

			static Delegate cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onSuccess;
			public void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onSuccess);
			}

			static Delegate cb_onUnrecoverableError;
#pragma warning disable 0169
			static Delegate GetOnUnrecoverableErrorHandler ()
			{
				if (cb_onUnrecoverableError == null)
					cb_onUnrecoverableError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnrecoverableError);
				return cb_onUnrecoverableError;
			}

			static void n_OnUnrecoverableError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUnrecoverableError ();
			}
#pragma warning restore 0169

			IntPtr id_onUnrecoverableError;
			public void OnUnrecoverableError ()
			{
				if (id_onUnrecoverableError == IntPtr.Zero)
					id_onUnrecoverableError = JNIEnv.GetMethodID (class_ref, "onUnrecoverableError", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onUnrecoverableError);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventJSONRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineEventJSONRequest); }
		}

		protected OfflineEventJSONRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_Lcom_amazon_ags_storage_OfflineEventJSONRequest_OfflineEventJSONCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventJSONRequest']/constructor[@name='OfflineEventJSONRequest' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.amazon.ags.storage.OfflineEventJSONRequest.OfflineEventJSONCallback']]"
		[Register (".ctor", "(Lorg/json/JSONObject;Lcom/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback;)V", "")]
		public OfflineEventJSONRequest (global::Org.Json.JSONObject p0, global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest.IOfflineEventJSONCallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OfflineEventJSONRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;Lcom/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;Lcom/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_json_JSONObject_Lcom_amazon_ags_storage_OfflineEventJSONRequest_OfflineEventJSONCallback_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONObject_Lcom_amazon_ags_storage_OfflineEventJSONRequest_OfflineEventJSONCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;Lcom/amazon/ags/storage/OfflineEventJSONRequest$OfflineEventJSONCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_Lcom_amazon_ags_storage_OfflineEventJSONRequest_OfflineEventJSONCallback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_Lcom_amazon_ags_storage_OfflineEventJSONRequest_OfflineEventJSONCallback_, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		public virtual global::Org.Json.JSONObject Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventJSONRequest']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lorg/json/JSONObject;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRequest), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventJSONRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResponse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventJSONRequest']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setResponse", "(Lorg/json/JSONObject;)V", "GetSetResponse_Lorg_json_JSONObject_Handler")]
		public virtual void SetResponse (global::Org.Json.JSONObject p0)
		{
			if (id_setResponse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setResponse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setResponse_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setResponse_Lorg_json_JSONObject_, new JValue (p0));
		}

	}
}
