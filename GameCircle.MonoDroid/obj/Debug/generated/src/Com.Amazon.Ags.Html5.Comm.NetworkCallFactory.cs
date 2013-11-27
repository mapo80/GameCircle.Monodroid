using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/NetworkCallFactory", DoNotGenerateAcw=true)]
	public partial class NetworkCallFactory : global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory.RequestResult']"
		[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/NetworkCallFactory$RequestResult", DoNotGenerateAcw=true)]
		public partial class RequestResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/html5/comm/NetworkCallFactory$RequestResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestResult); }
			}

			protected RequestResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_amazon_ags_html5_comm_NetworkCallFactory_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory.RequestResult']/constructor[@name='NetworkCallFactory.RequestResult' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.html5.comm.NetworkCallFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/amazon/ags/html5/comm/NetworkCallFactory;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public RequestResult (global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory __self, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (RequestResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Lcom_amazon_ags_html5_comm_NetworkCallFactory_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_ags_html5_comm_NetworkCallFactory_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/comm/NetworkCallFactory;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_comm_NetworkCallFactory_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_comm_NetworkCallFactory_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_getResponseCode;
#pragma warning disable 0169
			static Delegate GetGetResponseCodeHandler ()
			{
				if (cb_getResponseCode == null)
					cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseCode);
				return cb_getResponseCode;
			}

			static IntPtr n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory.RequestResult __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory.RequestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ResponseCode);
			}
#pragma warning restore 0169

			static IntPtr id_getResponseCode;
			public virtual string ResponseCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory.RequestResult']/method[@name='getResponseCode' and count(parameter)=0]"
				[Register ("getResponseCode", "()Ljava/lang/String;", "GetGetResponseCodeHandler")]
				get {
					if (id_getResponseCode == IntPtr.Zero)
						id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponseCode), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getResponseJSON;
#pragma warning disable 0169
			static Delegate GetGetResponseJSONHandler ()
			{
				if (cb_getResponseJSON == null)
					cb_getResponseJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseJSON);
				return cb_getResponseJSON;
			}

			static IntPtr n_GetResponseJSON (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory.RequestResult __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory.RequestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ResponseJSON);
			}
#pragma warning restore 0169

			static IntPtr id_getResponseJSON;
			public virtual string ResponseJSON {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory.RequestResult']/method[@name='getResponseJSON' and count(parameter)=0]"
				[Register ("getResponseJSON", "()Ljava/lang/String;", "GetGetResponseJSONHandler")]
				get {
					if (id_getResponseJSON == IntPtr.Zero)
						id_getResponseJSON = JNIEnv.GetMethodID (class_ref, "getResponseJSON", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseJSON), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponseJSON), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/NetworkCallFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkCallFactory); }
		}

		protected NetworkCallFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static bool n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.NetworkCallFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='NetworkCallFactory']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z", "GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected override bool HandleMessage (string p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
