using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/http/SignatureInterceptor", DoNotGenerateAcw=true)]
	public partial class SignatureInterceptor : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Http.IHttpClientInterceptor {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='AUTH_HEADER_SIGNATURE']"
		[Register ("AUTH_HEADER_SIGNATURE")]
		protected const string AuthHeaderSignature = (string) "x-amzn-Request-Signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='AUTH_HEADER_SIGNATURE_TIMESTAMP']"
		[Register ("AUTH_HEADER_SIGNATURE_TIMESTAMP")]
		protected const string AuthHeaderSignatureTimestamp = (string) "x-amzn-Request-Signature-Timestamp";

		static IntPtr df_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/field[@name='df']"
		[Register ("df")]
		protected global::Java.Text.DateFormat Df {
			get {
				if (df_jfieldId == IntPtr.Zero)
					df_jfieldId = JNIEnv.GetFieldID (class_ref, "df", "Ljava/text/DateFormat;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, df_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (df_jfieldId == IntPtr.Zero)
					df_jfieldId = JNIEnv.GetFieldID (class_ref, "df", "Ljava/text/DateFormat;");
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

		protected SignatureInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static IntPtr n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Http.SignatureInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.SignatureInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeStamp);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		protected virtual string TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTimeStamp), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTimeStamp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
#pragma warning disable 0169
		static Delegate GetAfter_Lcom_amazon_insights_core_http_HttpClient_Response_Handler ()
		{
			if (cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == null)
				cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_After_Lcom_amazon_insights_core_http_HttpClient_Response_);
			return cb_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		}

		static void n_After_Lcom_amazon_insights_core_http_HttpClient_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.SignatureInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.SignatureInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.After (p0);
		}
#pragma warning restore 0169

		static IntPtr id_after_Lcom_amazon_insights_core_http_HttpClient_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Response']]"
		[Register ("after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V", "GetAfter_Lcom_amazon_insights_core_http_HttpClient_Response_Handler")]
		public virtual void After (global::Com.Amazon.Insights.Core.Http.IHttpClientResponse p0)
		{
			if (id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ == IntPtr.Zero)
				id_after_Lcom_amazon_insights_core_http_HttpClient_Response_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/amazon/insights/core/http/HttpClient$Response;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_after_Lcom_amazon_insights_core_http_HttpClient_Response_, new JValue (p0));
		}

		static Delegate cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
#pragma warning disable 0169
		static Delegate GetBefore_Lcom_amazon_insights_core_http_HttpClient_Request_Handler ()
		{
			if (cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == null)
				cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Before_Lcom_amazon_insights_core_http_HttpClient_Request_);
			return cb_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		}

		static void n_Before_Lcom_amazon_insights_core_http_HttpClient_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Http.SignatureInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.SignatureInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0 = (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Http.IHttpClientRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Before (p0);
		}
#pragma warning restore 0169

		static IntPtr id_before_Lcom_amazon_insights_core_http_HttpClient_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.http']/class[@name='SignatureInterceptor']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.http.HttpClient.Request']]"
		[Register ("before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V", "GetBefore_Lcom_amazon_insights_core_http_HttpClient_Request_Handler")]
		public virtual void Before (global::Com.Amazon.Insights.Core.Http.IHttpClientRequest p0)
		{
			if (id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ == IntPtr.Zero)
				id_before_Lcom_amazon_insights_core_http_HttpClient_Request_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/amazon/insights/core/http/HttpClient$Request;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_before_Lcom_amazon_insights_core_http_HttpClient_Request_, new JValue (p0));
		}

	}
}
