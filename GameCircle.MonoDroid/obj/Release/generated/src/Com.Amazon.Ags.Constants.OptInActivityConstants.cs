using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/OptInActivityConstants", DoNotGenerateAcw=true)]
	public sealed partial class OptInActivityConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_GAME_FEATURES']"
		[Register ("OPT_IN_ACTIVITY_GAME_FEATURES")]
		public const string OptInActivityGameFeatures = (string) "GAME_FEATURES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_GAME_ID']"
		[Register ("OPT_IN_ACTIVITY_GAME_ID")]
		public const string OptInActivityGameId = (string) "GAME_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_GAME_NAME_BUNDLE_KEY']"
		[Register ("OPT_IN_ACTIVITY_GAME_NAME_BUNDLE_KEY")]
		public const string OptInActivityGameNameBundleKey = (string) "GAME_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_MESSAGE_BUNDLE_KEY']"
		[Register ("OPT_IN_ACTIVITY_MESSAGE_BUNDLE_KEY")]
		public const string OptInActivityMessageBundleKey = (string) "MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_PACKAGE_NAME_BUNDLE_KEY']"
		[Register ("OPT_IN_ACTIVITY_PACKAGE_NAME_BUNDLE_KEY")]
		public const string OptInActivityPackageNameBundleKey = (string) "PACKAGE_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_STATUS_BUNDLE_KEY']"
		[Register ("OPT_IN_ACTIVITY_STATUS_BUNDLE_KEY")]
		public const string OptInActivityStatusBundleKey = (string) "STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_ACTIVITY_TYPE_BUNDLE_KEY']"
		[Register ("OPT_IN_ACTIVITY_TYPE_BUNDLE_KEY")]
		public const string OptInActivityTypeBundleKey = (string) "ACTIVITY_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_OPERATION_BUNDLE_KEY']"
		[Register ("OPT_IN_OPERATION_BUNDLE_KEY")]
		public const string OptInOperationBundleKey = (string) "OPERATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_STATUS_BROADCAST_ACTION']"
		[Register ("OPT_IN_STATUS_BROADCAST_ACTION")]
		public const string OptInStatusBroadcastAction = (string) "OPT_IN_STATUS_BROADCAST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='OPT_IN_STATUS_EXTRA_KEY']"
		[Register ("OPT_IN_STATUS_EXTRA_KEY")]
		public const string OptInStatusExtraKey = (string) "OPT_IN_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OptInActivityConstants']/field[@name='PREFS_NAME']"
		[Register ("PREFS_NAME")]
		public const string PrefsName = (string) "OptInPrefs";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/OptInActivityConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OptInActivityConstants); }
		}

		internal OptInActivityConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
