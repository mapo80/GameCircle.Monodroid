using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/ClientBase", DoNotGenerateAcw=true)]
	public abstract partial class ClientBase : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/field[@name='TAG']"
		[Register ("TAG")]
		protected string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr isReady_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/field[@name='isReady']"
		[Register ("isReady")]
		protected bool IsReady {
			get {
				if (isReady_jfieldId == IntPtr.Zero)
					isReady_jfieldId = JNIEnv.GetFieldID (class_ref, "isReady", "Z");
				return JNIEnv.GetBooleanField (Handle, isReady_jfieldId);
			}
			set {
				if (isReady_jfieldId == IntPtr.Zero)
					isReady_jfieldId = JNIEnv.GetFieldID (class_ref, "isReady", "Z");
				JNIEnv.SetField (Handle, isReady_jfieldId, value);
			}
		}

		static IntPtr serviceHelper_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/field[@name='serviceHelper']"
		[Register ("serviceHelper")]
		protected global::Com.Amazon.Ags.Html5.Service.IServiceHelper ServiceHelper {
			get {
				if (serviceHelper_jfieldId == IntPtr.Zero)
					serviceHelper_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceHelper", "Lcom/amazon/ags/html5/service/ServiceHelper;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, serviceHelper_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (serviceHelper_jfieldId == IntPtr.Zero)
					serviceHelper_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceHelper", "Lcom/amazon/ags/html5/service/ServiceHelper;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, serviceHelper_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']"
		[global::Android.Runtime.Register ("com/amazon/ags/client/ClientBase$AsyncTaskWrapper", DoNotGenerateAcw=true)]
		protected internal abstract partial class AsyncTaskWrapper : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.IJSONRequest {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/client/ClientBase$AsyncTaskWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AsyncTaskWrapper); }
			}

			protected AsyncTaskWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_amazon_ags_client_ClientBase_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/constructor[@name='ClientBase.AsyncTaskWrapper' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.ClientBase'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/amazon/ags/client/ClientBase;Ljava/lang/String;)V", "")]
			public AsyncTaskWrapper (global::Com.Amazon.Ags.Client.ClientBase __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (AsyncTaskWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_amazon_ags_client_ClientBase_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_ags_client_ClientBase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/ClientBase;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_ClientBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_ClientBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
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
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Request);
			}
#pragma warning restore 0169

			static IntPtr id_getRequest;
			public virtual global::Org.Json.JSONObject Request {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='getRequest' and count(parameter)=0]"
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

			static Delegate cb_buildRequest;
#pragma warning disable 0169
			static Delegate GetBuildRequestHandler ()
			{
				if (cb_buildRequest == null)
					cb_buildRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildRequest);
				return cb_buildRequest;
			}

			static IntPtr n_BuildRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildRequest ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='buildRequest' and count(parameter)=0]"
			[Register ("buildRequest", "()Lorg/json/JSONObject;", "GetBuildRequestHandler")]
			protected abstract global::Org.Json.JSONObject BuildRequest ();

			static Delegate cb_buildRequestForServiceAction_I;
#pragma warning disable 0169
			static Delegate GetBuildRequestForServiceAction_IHandler ()
			{
				if (cb_buildRequestForServiceAction_I == null)
					cb_buildRequestForServiceAction_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_BuildRequestForServiceAction_I);
				return cb_buildRequestForServiceAction_I;
			}

			static IntPtr n_BuildRequestForServiceAction_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildRequestForServiceAction (p0));
			}
#pragma warning restore 0169

			static IntPtr id_buildRequestForServiceAction_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='buildRequestForServiceAction' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buildRequestForServiceAction", "(I)Lorg/json/JSONObject;", "GetBuildRequestForServiceAction_IHandler")]
			public virtual global::Org.Json.JSONObject BuildRequestForServiceAction (int p0)
			{
				if (id_buildRequestForServiceAction_I == IntPtr.Zero)
					id_buildRequestForServiceAction_I = JNIEnv.GetMethodID (class_ref, "buildRequestForServiceAction", "(I)Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_buildRequestForServiceAction_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_buildRequestForServiceAction_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_buildRequestForServiceAction_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetBuildRequestForServiceAction_Ljava_lang_String_Handler ()
			{
				if (cb_buildRequestForServiceAction_Ljava_lang_String_ == null)
					cb_buildRequestForServiceAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildRequestForServiceAction_Ljava_lang_String_);
				return cb_buildRequestForServiceAction_Ljava_lang_String_;
			}

			static IntPtr n_BuildRequestForServiceAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildRequestForServiceAction (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_buildRequestForServiceAction_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='buildRequestForServiceAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("buildRequestForServiceAction", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetBuildRequestForServiceAction_Ljava_lang_String_Handler")]
			public virtual global::Org.Json.JSONObject BuildRequestForServiceAction (string p0)
			{
				if (id_buildRequestForServiceAction_Ljava_lang_String_ == IntPtr.Zero)
					id_buildRequestForServiceAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "buildRequestForServiceAction", "(Ljava/lang/String;)Lorg/json/JSONObject;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_buildRequestForServiceAction_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_buildRequestForServiceAction_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_convertResponse_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetConvertResponse_Lorg_json_JSONObject_Handler ()
			{
				if (cb_convertResponse_Lorg_json_JSONObject_ == null)
					cb_convertResponse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConvertResponse_Lorg_json_JSONObject_);
				return cb_convertResponse_Lorg_json_JSONObject_;
			}

			static IntPtr n_ConvertResponse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertResponse (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='convertResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("convertResponse", "(Lorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;", "GetConvertResponse_Lorg_json_JSONObject_Handler")]
			protected abstract global::Java.Lang.Object ConvertResponse (global::Org.Json.JSONObject p0);

			static Delegate cb_execute_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetExecute_arrayLjava_lang_Object_Handler ()
			{
				if (cb_execute_arrayLjava_lang_Object_ == null)
					cb_execute_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_arrayLjava_lang_Object_);
				return cb_execute_arrayLjava_lang_Object_;
			}

			static IntPtr n_Execute_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_execute_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("execute", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetExecute_arrayLjava_lang_Object_Handler")]
			public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle Execute (global::Java.Lang.Object[] p0)
			{
				if (id_execute_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_execute_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_execute_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_execute_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_getFailureResponse_ILorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetGetFailureResponse_ILorg_json_JSONObject_Handler ()
			{
				if (cb_getFailureResponse_ILorg_json_JSONObject_ == null)
					cb_getFailureResponse_ILorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetFailureResponse_ILorg_json_JSONObject_);
				return cb_getFailureResponse_ILorg_json_JSONObject_;
			}

			static IntPtr n_GetFailureResponse_ILorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFailureResponse (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='getFailureResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.json.JSONObject']]"
			[Register ("getFailureResponse", "(ILorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;", "GetGetFailureResponse_ILorg_json_JSONObject_Handler")]
			protected abstract global::Java.Lang.Object GetFailureResponse (int p0, global::Org.Json.JSONObject p1);

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
				global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase.AsyncTaskWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetResponse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setResponse_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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

		[global::Android.Runtime.Register ("com/amazon/ags/client/ClientBase$AsyncTaskWrapper", DoNotGenerateAcw=true)]
		internal partial class AsyncTaskWrapperInvoker : AsyncTaskWrapper {

			public AsyncTaskWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (AsyncTaskWrapperInvoker); }
			}

			static IntPtr id_buildRequest;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='buildRequest' and count(parameter)=0]"
			[Register ("buildRequest", "()Lorg/json/JSONObject;", "GetBuildRequestHandler")]
			protected override global::Org.Json.JSONObject BuildRequest ()
			{
				if (id_buildRequest == IntPtr.Zero)
					id_buildRequest = JNIEnv.GetMethodID (class_ref, "buildRequest", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_buildRequest), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_convertResponse_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='convertResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("convertResponse", "(Lorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;", "GetConvertResponse_Lorg_json_JSONObject_Handler")]
			protected override global::Java.Lang.Object ConvertResponse (global::Org.Json.JSONObject p0)
			{
				if (id_convertResponse_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_convertResponse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "convertResponse", "(Lorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_convertResponse_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getFailureResponse_ILorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase.AsyncTaskWrapper']/method[@name='getFailureResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.json.JSONObject']]"
			[Register ("getFailureResponse", "(ILorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;", "GetGetFailureResponse_ILorg_json_JSONObject_Handler")]
			protected override global::Java.Lang.Object GetFailureResponse (int p0, global::Org.Json.JSONObject p1)
			{
				if (id_getFailureResponse_ILorg_json_JSONObject_ == IntPtr.Zero)
					id_getFailureResponse_ILorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getFailureResponse", "(ILorg/json/JSONObject;)Lcom/amazon/ags/api/RequestResponse;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFailureResponse_ILorg_json_JSONObject_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/ClientBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientBase); }
		}

		protected ClientBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/constructor[@name='ClientBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ClientBase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClientBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/constructor[@name='ClientBase' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "")]
		public ClientBase (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClientBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

		static Delegate cb_isClientReady;
#pragma warning disable 0169
		static Delegate GetIsClientReadyHandler ()
		{
			if (cb_isClientReady == null)
				cb_isClientReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClientReady);
			return cb_isClientReady;
		}

		static bool n_IsClientReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.ClientBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClientReady;
		}
#pragma warning restore 0169

		static IntPtr id_isClientReady;
		protected virtual bool IsClientReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/method[@name='isClientReady' and count(parameter)=0]"
			[Register ("isClientReady", "()Z", "GetIsClientReadyHandler")]
			get {
				if (id_isClientReady == IntPtr.Zero)
					id_isClientReady = JNIEnv.GetMethodID (class_ref, "isClientReady", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isClientReady);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isClientReady);
			}
		}

		static Delegate cb_getInt_Lorg_json_JSONObject_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Lorg_json_JSONObject_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Lorg_json_JSONObject_Ljava_lang_String_I == null)
				cb_getInt_Lorg_json_JSONObject_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_GetInt_Lorg_json_JSONObject_Ljava_lang_String_I);
			return cb_getInt_Lorg_json_JSONObject_Ljava_lang_String_I;
		}

		static int n_GetInt_Lorg_json_JSONObject_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Amazon.Ags.Client.ClientBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)I", "GetGetInt_Lorg_json_JSONObject_Ljava_lang_String_IHandler")]
		protected virtual int GetInt (global::Org.Json.JSONObject p0, string p1, int p2)
		{
			if (id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getInt_Lorg_json_JSONObject_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getLong_Lorg_json_JSONObject_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Lorg_json_JSONObject_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Lorg_json_JSONObject_Ljava_lang_String_J == null)
				cb_getLong_Lorg_json_JSONObject_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_GetLong_Lorg_json_JSONObject_Ljava_lang_String_J);
			return cb_getLong_Lorg_json_JSONObject_Ljava_lang_String_J;
		}

		static long n_GetLong_Lorg_json_JSONObject_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Amazon.Ags.Client.ClientBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Lorg_json_JSONObject_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Lorg/json/JSONObject;Ljava/lang/String;J)J", "GetGetLong_Lorg_json_JSONObject_Ljava_lang_String_JHandler")]
		protected virtual long GetLong (global::Org.Json.JSONObject p0, string p1, long p2)
		{
			if (id_getLong_Lorg_json_JSONObject_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Lorg_json_JSONObject_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Lorg/json/JSONObject;Ljava/lang/String;J)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Lorg_json_JSONObject_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getLong_Lorg_json_JSONObject_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
#pragma warning disable 0169
		static Delegate GetSetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_Handler ()
		{
			if (cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ == null)
				cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_);
			return cb_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
		}

		static void n_SetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.ClientBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.ClientBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0 = (global::Com.Amazon.Ags.Html5.Service.IServiceHelper)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServiceHelper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='ClientBase']/method[@name='setServiceHelper' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register ("setServiceHelper", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "GetSetServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_Handler")]
		public virtual void SetServiceHelper (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0)
		{
			if (id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "setServiceHelper", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setServiceHelper_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/ClientBase", DoNotGenerateAcw=true)]
	internal partial class ClientBaseInvoker : ClientBase {

		public ClientBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientBaseInvoker); }
		}

	}

}
