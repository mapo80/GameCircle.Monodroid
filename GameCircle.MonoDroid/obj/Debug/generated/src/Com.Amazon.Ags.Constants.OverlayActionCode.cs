using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/OverlayActionCode", DoNotGenerateAcw=true)]
	public partial class OverlayActionCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_ACHIEVEMENTS']"
		[Register ("SHOW_ACHIEVEMENTS")]
		public const int ShowAchievements = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_AGE_VERIFICATION']"
		[Register ("SHOW_AGE_VERIFICATION")]
		public const string ShowAgeVerification = (string) "SHOW_AGE_VERIFICATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_AGE_VIOLATION']"
		[Register ("SHOW_AGE_VIOLATION")]
		public const string ShowAgeViolation = (string) "SHOW_AGE_VIOLATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_COR_SELECTION']"
		[Register ("SHOW_COR_SELECTION")]
		public const string ShowCorSelection = (string) "SHOW_COR_SELECTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_COR_UNSUPPORTED']"
		[Register ("SHOW_COR_UNSUPPORTED")]
		public const string ShowCorUnsupported = (string) "SHOW_COR_UNSUPPORTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_LEADERBOARDS']"
		[Register ("SHOW_LEADERBOARDS")]
		public const int ShowLeaderboards = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_LOGIN']"
		[Register ("SHOW_LOGIN")]
		public const string ShowLogin = (string) "SHOW_LOGIN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_PROFILE']"
		[Register ("SHOW_PROFILE")]
		public const int ShowProfile = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_SETTINGS']"
		[Register ("SHOW_SETTINGS")]
		public const int ShowSettings = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_SUMMARY']"
		[Register ("SHOW_SUMMARY")]
		public const int ShowSummary = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_TERMS_OF_SERVICE']"
		[Register ("SHOW_TERMS_OF_SERVICE")]
		public const string ShowTermsOfService = (string) "SHOW_TOS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlayActionCode']/field[@name='SHOW_TOP_ALL_TIME_LEADERBOARD']"
		[Register ("SHOW_TOP_ALL_TIME_LEADERBOARD")]
		public const int ShowTopAllTimeLeaderboard = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/OverlayActionCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayActionCode); }
		}

		protected OverlayActionCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
