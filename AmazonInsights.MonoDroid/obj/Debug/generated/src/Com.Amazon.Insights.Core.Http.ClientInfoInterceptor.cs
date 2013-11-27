using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/ClientInfoInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class ClientInfoInterceptor : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/http/ClientInfoInterceptor$ClientInfo", DoNotGenerateAcw=true)]
		public sealed partial class ClientInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/http/ClientInfoInterceptor$ClientInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClientInfo); }
			}

			internal ClientInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/constructor[@name='ClientInfoInterceptor.ClientInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public ClientInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ClientInfo)) {
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

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/constructor[@name='ClientInfoInterceptor.ClientInfo' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public ClientInfo (string p0, string p1, string p2, string p3, string p4, string p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				IntPtr native_p3 = JNIEnv.NewString (p3);;
				IntPtr native_p4 = JNIEnv.NewString (p4);;
				IntPtr native_p5 = JNIEnv.NewString (p5);;
				if (GetType () != typeof (ClientInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5));
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
					JNIEnv.DeleteLocalRef (native_p5);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}

			static IntPtr id_getCarrier;
			static IntPtr id_setCarrier_Ljava_lang_String_;
			public string Carrier {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getCarrier' and count(parameter)=0]"
				[Register ("getCarrier", "()Ljava/lang/String;", "GetGetCarrierHandler")]
				get {
					if (id_getCarrier == IntPtr.Zero)
						id_getCarrier = JNIEnv.GetMethodID (class_ref, "getCarrier", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCarrier), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setCarrier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCarrier", "(Ljava/lang/String;)V", "GetSetCarrier_Ljava_lang_String_Handler")]
				set {
					if (id_setCarrier_Ljava_lang_String_ == IntPtr.Zero)
						id_setCarrier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCarrier", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setCarrier_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_getManufacturer;
			static IntPtr id_setManufacturer_Ljava_lang_String_;
			public string Manufacturer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getManufacturer' and count(parameter)=0]"
				[Register ("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
				get {
					if (id_getManufacturer == IntPtr.Zero)
						id_getManufacturer = JNIEnv.GetMethodID (class_ref, "getManufacturer", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getManufacturer), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setManufacturer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setManufacturer", "(Ljava/lang/String;)V", "GetSetManufacturer_Ljava_lang_String_Handler")]
				set {
					if (id_setManufacturer_Ljava_lang_String_ == IntPtr.Zero)
						id_setManufacturer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setManufacturer", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setManufacturer_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_getModel;
			static IntPtr id_setModel_Ljava_lang_String_;
			public string Model {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getModel' and count(parameter)=0]"
				[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
				get {
					if (id_getModel == IntPtr.Zero)
						id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setModel", "(Ljava/lang/String;)V", "GetSetModel_Ljava_lang_String_Handler")]
				set {
					if (id_setModel_Ljava_lang_String_ == IntPtr.Zero)
						id_setModel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModel", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setModel_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_getNetworkType;
			static IntPtr id_setNetworkType_Ljava_lang_String_;
			public string NetworkType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getNetworkType' and count(parameter)=0]"
				[Register ("getNetworkType", "()Ljava/lang/String;", "GetGetNetworkTypeHandler")]
				get {
					if (id_getNetworkType == IntPtr.Zero)
						id_getNetworkType = JNIEnv.GetMethodID (class_ref, "getNetworkType", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkType), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setNetworkType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNetworkType", "(Ljava/lang/String;)V", "GetSetNetworkType_Ljava_lang_String_Handler")]
				set {
					if (id_setNetworkType_Ljava_lang_String_ == IntPtr.Zero)
						id_setNetworkType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkType", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setNetworkType_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_getOS;
			static IntPtr id_setOS_Ljava_lang_String_;
			public string OS {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getOS' and count(parameter)=0]"
				[Register ("getOS", "()Ljava/lang/String;", "GetGetOSHandler")]
				get {
					if (id_getOS == IntPtr.Zero)
						id_getOS = JNIEnv.GetMethodID (class_ref, "getOS", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOS), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setOS' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setOS", "(Ljava/lang/String;)V", "GetSetOS_Ljava_lang_String_Handler")]
				set {
					if (id_setOS_Ljava_lang_String_ == IntPtr.Zero)
						id_setOS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOS", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setOS_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_getOSVersion;
			static IntPtr id_setOSVersion_Ljava_lang_String_;
			public string OSVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='getOSVersion' and count(parameter)=0]"
				[Register ("getOSVersion", "()Ljava/lang/String;", "GetGetOSVersionHandler")]
				get {
					if (id_getOSVersion == IntPtr.Zero)
						id_getOSVersion = JNIEnv.GetMethodID (class_ref, "getOSVersion", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOSVersion), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='setOSVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setOSVersion", "(Ljava/lang/String;)V", "GetSetOSVersion_Ljava_lang_String_Handler")]
				set {
					if (id_setOSVersion_Ljava_lang_String_ == IntPtr.Zero)
						id_setOSVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOSVersion", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod  (Handle, id_setOSVersion_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_toJsonObject;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor.ClientInfo']/method[@name='toJsonObject' and count(parameter)=0]"
			[Register ("toJsonObject", "()Lorg/json/JSONObject;", "")]
			protected global::Org.Json.JSONObject ToJsonObject ()
			{
				if (id_toJsonObject == IntPtr.Zero)
					id_toJsonObject = JNIEnv.GetMethodID (class_ref, "toJsonObject", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJsonObject), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/ClientInfoInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientInfoInterceptor); }
		}

		internal ClientInfoInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor']/constructor[@name='ClientInfoInterceptor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ClientInfoInterceptor (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClientInfoInterceptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "")]
		public void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");
			JNIEnv.CallVoidMethod  (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
		}

		static IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='ClientInfoInterceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "")]
		public void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");
			JNIEnv.CallVoidMethod  (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}
}
