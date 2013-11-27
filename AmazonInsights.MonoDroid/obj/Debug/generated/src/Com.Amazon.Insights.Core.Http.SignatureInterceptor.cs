using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/SignatureInterceptor", DoNotGenerateAcw=true)]
	public sealed partial class SignatureInterceptor : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='AUTH_HEADER_SIGNATURE']"
		[Register ("AUTH_HEADER_SIGNATURE")]
		protected const string AuthHeaderSignature = (string) "x-amzn-Request-Signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='AUTH_HEADER_SIGNATURE_TIMESTAMP']"
		[Register ("AUTH_HEADER_SIGNATURE_TIMESTAMP")]
		protected const string AuthHeaderSignatureTimestamp = (string) "x-amzn-Request-Signature-Timestamp";

		static IntPtr df_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='df']"
		[Register ("df")]
		protected global::Java.Text.SimpleDateFormat Df {
			get {
				if (df_jfieldId == IntPtr.Zero)
					df_jfieldId = JNIEnv.GetFieldID (class_ref, "df", "Ljava/text/SimpleDateFormat;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, df_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (df_jfieldId == IntPtr.Zero)
					df_jfieldId = JNIEnv.GetFieldID (class_ref, "df", "Ljava/text/SimpleDateFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, df_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr timeZone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='timeZone']"
		[Register ("timeZone")]
		protected global::Java.Util.TimeZone TimeZone {
			get {
				if (timeZone_jfieldId == IntPtr.Zero)
					timeZone_jfieldId = JNIEnv.GetFieldID (class_ref, "timeZone", "Ljava/util/TimeZone;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, timeZone_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (timeZone_jfieldId == IntPtr.Zero)
					timeZone_jfieldId = JNIEnv.GetFieldID (class_ref, "timeZone", "Ljava/util/TimeZone;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, timeZone_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor.SignatureBuilder']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/http/SignatureInterceptor$SignatureBuilder", DoNotGenerateAcw=true)]
		public sealed partial class SignatureBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/http/SignatureInterceptor$SignatureBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SignatureBuilder); }
			}

			internal SignatureBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_createSignature;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor.SignatureBuilder']/method[@name='createSignature' and count(parameter)=0]"
			[Register ("createSignature", "()Ljava/lang/String;", "")]
			public string CreateSignature ()
			{
				if (id_createSignature == IntPtr.Zero)
					id_createSignature = JNIEnv.GetMethodID (class_ref, "createSignature", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_createSignature), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/http/SignatureInterceptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignatureInterceptor); }
		}

		internal SignatureInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/constructor[@name='SignatureInterceptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public SignatureInterceptor (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (SignatureInterceptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "")]
		public void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");
			JNIEnv.CallVoidMethod  (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
		}

		static IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "")]
		public void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");
			JNIEnv.CallVoidMethod  (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}
}
