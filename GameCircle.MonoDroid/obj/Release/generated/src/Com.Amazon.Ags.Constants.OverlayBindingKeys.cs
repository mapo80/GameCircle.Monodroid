using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/OverlayBindingKeys", DoNotGenerateAcw=true)]
	public sealed partial class OverlayBindingKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_ACTION_CODE_KEY']"
		[Register ("OVERLAY_ACTION_CODE_KEY")]
		public const string OverlayActionCodeKey = (string) "OVERLAY_ACTION_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_DATA_BUNDLE_KEY']"
		[Register ("OVERLAY_DATA_BUNDLE_KEY")]
		public const string OverlayDataBundleKey = (string) "OVERLAY_DATA_BUNDLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_APPLICATION_NAME_KEY']"
		[Register ("OVERLAY_SESSION_APPLICATION_NAME_KEY")]
		public const string OverlaySessionApplicationNameKey = (string) "OVERLAY_SESSION_APPLICATION_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_CLIENT_VERSION_KEY']"
		[Register ("OVERLAY_SESSION_CLIENT_VERSION_KEY")]
		public const string OverlaySessionClientVersionKey = (string) "OVERLAY_SESSION_CLIENT_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_CONTENT_VERSION_KEY']"
		[Register ("OVERLAY_SESSION_CONTENT_VERSION_KEY")]
		public const string OverlaySessionContentVersionKey = (string) "OVERLAY_SESSION_CONTENT_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_COUNTRY_CODE_KEY']"
		[Register ("OVERLAY_SESSION_COUNTRY_CODE_KEY")]
		public const string OverlaySessionCountryCodeKey = (string) "OVERLAY_SESSION_COUNTRY_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_DEVICE_IDENTIFIER_KEY']"
		[Register ("OVERLAY_SESSION_DEVICE_IDENTIFIER_KEY")]
		public const string OverlaySessionDeviceIdentifierKey = (string) "OVERLAY_SESSION_DEVICE_IDENTIFIER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_DEVICE_MANUFACTURER_KEY']"
		[Register ("OVERLAY_SESSION_DEVICE_MANUFACTURER_KEY")]
		public const string OverlaySessionDeviceManufacturerKey = (string) "OVERLAY_SESSION_DEVICE_MANUFACTURER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_DEVICE_MODEL_KEY']"
		[Register ("OVERLAY_SESSION_DEVICE_MODEL_KEY")]
		public const string OverlaySessionDeviceModelKey = (string) "OVERLAY_SESSION_DEVICE_MODEL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_DEVICE_TYPE_KEY']"
		[Register ("OVERLAY_SESSION_DEVICE_TYPE_KEY")]
		public const string OverlaySessionDeviceTypeKey = (string) "OVERLAY_SESSION_DEVICE_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_LANGUAGE_CODE_KEY']"
		[Register ("OVERLAY_SESSION_LANGUAGE_CODE_KEY")]
		public const string OverlaySessionLanguageCodeKey = (string) "OVERLAY_SESSION_LANGUAGE_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayBindingKeys']/field[@name='OVERLAY_SESSION_VARIATION_CACHE']"
		[Register ("OVERLAY_SESSION_VARIATION_CACHE")]
		public const string OverlaySessionVariationCache = (string) "OVERLAY_SESSION_VARIATION_CACHE";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/OverlayBindingKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayBindingKeys); }
		}

		internal OverlayBindingKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
