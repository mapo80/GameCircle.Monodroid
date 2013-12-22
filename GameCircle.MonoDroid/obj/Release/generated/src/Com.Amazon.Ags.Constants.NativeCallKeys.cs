using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/NativeCallKeys", DoNotGenerateAcw=true)]
	public partial class NativeCallKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='AUTHENTICATE']"
		[Register ("AUTHENTICATE")]
		public const string Authenticate = (string) "authenticate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='BODY']"
		[Register ("BODY")]
		public const string Body = (string) "body";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='CACHE_REQUEST']"
		[Register ("CACHE_REQUEST")]
		public const string CacheRequest = (string) "cacheRequest";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='CACHE_REQUESTS']"
		[Register ("CACHE_REQUESTS")]
		public const string CacheRequests = (string) "cacheRequests";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public const string Connected = (string) "connected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='COUNTRY_CODE']"
		[Register ("COUNTRY_CODE")]
		public const string CountryCode = (string) "countryCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='COUNTRY_SUPPORT']"
		[Register ("COUNTRY_SUPPORT")]
		public const string CountrySupport = (string) "countrySupport";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='DEV_FEATURES']"
		[Register ("DEV_FEATURES")]
		public const string DevFeatures = (string) "devFeatures";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='END_POINT']"
		[Register ("END_POINT")]
		public const string EndPoint = (string) "endPoint";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='EVENT_ATTRIBUTES']"
		[Register ("EVENT_ATTRIBUTES")]
		public const string EventAttributes = (string) "eventAttributes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='EVENT_COUNT_METRICS']"
		[Register ("EVENT_COUNT_METRICS")]
		public const string EventCountMetrics = (string) "eventCountMetrics";

		static IntPtr EVENT_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='EVENT_NAME']"
		[Register ("EVENT_NAME")]
		public static string EventName {
			get {
				if (EVENT_NAME_jfieldId == IntPtr.Zero)
					EVENT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVENT_NAME_jfieldId == IntPtr.Zero)
					EVENT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, EVENT_NAME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='EVENT_TIME_METRICS']"
		[Register ("EVENT_TIME_METRICS")]
		public const string EventTimeMetrics = (string) "eventTimeMetrics";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='GUEST_MODE']"
		[Register ("GUEST_MODE")]
		public const string GuestMode = (string) "guestMode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='HAS_OPTED_IN']"
		[Register ("HAS_OPTED_IN")]
		public const string HasOptedIn = (string) "hasOptedIn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='HIDDEN_FLAG']"
		[Register ("HIDDEN_FLAG")]
		public const string HiddenFlag = (string) "hidden";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='HTTP_HEADERS']"
		[Register ("HTTP_HEADERS")]
		public const string HttpHeaders = (string) "httpHeaders";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='HTTP_METHOD']"
		[Register ("HTTP_METHOD")]
		public const string HttpMethod = (string) "httpMethod";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='HTTP_PAYLOAD']"
		[Register ("HTTP_PAYLOAD")]
		public const string HttpPayload = (string) "httpPayload";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='JAVASCRIPT_EVENT_TYPE']"
		[Register ("JAVASCRIPT_EVENT_TYPE")]
		public const string JavascriptEventType = (string) "javascriptEventType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='JSON_DATA']"
		[Register ("JSON_DATA")]
		public const string JsonData = (string) "jsonData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='LANGUAGE_CODE']"
		[Register ("LANGUAGE_CODE")]
		public const string LanguageCode = (string) "languageCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='LOGGED_IN_STATUS']"
		[Register ("LOGGED_IN_STATUS")]
		public const string LoggedInStatus = (string) "loggedInStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='MAIL_TO']"
		[Register ("MAIL_TO")]
		public const string MailTo = (string) "mailTo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='METHOD']"
		[Register ("METHOD")]
		public const string Method = (string) "method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='NATIVE_CALL']"
		[Register ("NATIVE_CALL")]
		public const string NativeCall = (string) "nativeCall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='PARAMETERS']"
		[Register ("PARAMETERS")]
		public const string Parameters = (string) "parameters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='PLAYER_ID']"
		[Register ("PLAYER_ID")]
		public const string PlayerId = (string) "playerId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='PRIMARY_KEY']"
		[Register ("PRIMARY_KEY")]
		public const string PrimaryKey = (string) "primaryKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='REQUEST_ID']"
		[Register ("REQUEST_ID")]
		public const string RequestId = (string) "rid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='ROAMING']"
		[Register ("ROAMING")]
		public const string Roaming = (string) "roaming";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='SECONDARY_KEY']"
		[Register ("SECONDARY_KEY")]
		public const string SecondaryKey = (string) "secondaryKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='SUBJECT']"
		[Register ("SUBJECT")]
		public const string Subject = (string) "subject";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='TARGET']"
		[Register ("TARGET")]
		public const string Target = (string) "target";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='VALUE']"
		[Register ("VALUE")]
		public const string Value = (string) "value";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='VARIATION']"
		[Register ("VARIATION")]
		public const string Variation = (string) "variation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='VARIATION_VARIABLE']"
		[Register ("VARIATION_VARIABLE")]
		public const string VariationVariable = (string) "variationVariable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallKeys']/field[@name='VARIATION_VARIABLE_DEFAULT_VALUE']"
		[Register ("VARIATION_VARIABLE_DEFAULT_VALUE")]
		public const string VariationVariableDefaultValue = (string) "variationVariableDefaultValue";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/NativeCallKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeCallKeys); }
		}

		protected NativeCallKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
