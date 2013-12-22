using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/BindingKeys", DoNotGenerateAcw=true)]
	public sealed partial class BindingKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='AUTHENTICATE_RESULT_BUNDLE_KEY']"
		[Register ("AUTHENTICATE_RESULT_BUNDLE_KEY")]
		public const string AuthenticateResultBundleKey = (string) "AUTHENTICATE_RESULT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='AUTHORIZE_RESULT_BUNDLE_KEY']"
		[Register ("AUTHORIZE_RESULT_BUNDLE_KEY")]
		public const string AuthorizeResultBundleKey = (string) "AUTH_RESULT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='BIND_ASYNCHRONOUS']"
		[Register ("BIND_ASYNCHRONOUS")]
		public const string BindAsynchronous = (string) "BindAsynchronous";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='BIND_SYNCHRONOUS']"
		[Register ("BIND_SYNCHRONOUS")]
		public const string BindSynchronous = (string) "BindSynchronous";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='COUNTRY_OF_RESIDENCE']"
		[Register ("COUNTRY_OF_RESIDENCE")]
		public const string CountryOfResidence = (string) "COR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='FEATURE_LIST']"
		[Register ("FEATURE_LIST")]
		public const string FeatureList = (string) "FEATURE_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='GAME_ID_KEY']"
		[Register ("GAME_ID_KEY")]
		public const string GameIdKey = (string) "GAME_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='OVERLAY_ACTION_CODE']"
		[Register ("OVERLAY_ACTION_CODE")]
		public const string OverlayActionCode = (string) "OVERLAY_ACTION_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='PACKAGE_NAME_KEY']"
		[Register ("PACKAGE_NAME_KEY")]
		public const string PackageNameKey = (string) "PACKAGE_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='POP_UP_LOCATION']"
		[Register ("POP_UP_LOCATION")]
		public const string PopUpLocation = (string) "POP_UP_LOCATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='REQUEST_ID_KEY']"
		[Register ("REQUEST_ID_KEY")]
		public const string RequestIdKey = (string) "REQUEST_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='REQUEST_TIMESTAMP']"
		[Register ("REQUEST_TIMESTAMP")]
		public const string RequestTimestamp = (string) "REQUEST_TIMESTAMP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='SESSION_ID']"
		[Register ("SESSION_ID")]
		public const string SessionId = (string) "SESSION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='WELCOME_BACK_TOAST']"
		[Register ("WELCOME_BACK_TOAST")]
		public const string WelcomeBackToast = (string) "WELCOME_BACK_TOAST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='BindingKeys']/field[@name='WHISPERSYNC_ENABLED']"
		[Register ("WHISPERSYNC_ENABLED")]
		public const string WhispersyncEnabled = (string) "WHISPERSYNC_ENABLED";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/BindingKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BindingKeys); }
		}

		internal BindingKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
