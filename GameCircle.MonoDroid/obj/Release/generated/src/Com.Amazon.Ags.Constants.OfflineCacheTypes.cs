using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OfflineCacheTypes']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/OfflineCacheTypes", DoNotGenerateAcw=true)]
	public partial class OfflineCacheTypes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OfflineCacheTypes']/field[@name='ACHIEVEMENTS_CACHE']"
		[Register ("ACHIEVEMENTS_CACHE")]
		public const string AchievementsCache = (string) "AchievementsCache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OfflineCacheTypes']/field[@name='LEADERBOARDS_CACHE']"
		[Register ("LEADERBOARDS_CACHE")]
		public const string LeaderboardsCache = (string) "LeaderboardsCache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OfflineCacheTypes']/field[@name='PLAYER_PROFILE_CACHE']"
		[Register ("PLAYER_PROFILE_CACHE")]
		public const string PlayerProfileCache = (string) "PlayerProfileCache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OfflineCacheTypes']/field[@name='SETTINGS_CACHE']"
		[Register ("SETTINGS_CACHE")]
		public const string SettingsCache = (string) "SettingsCache";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/OfflineCacheTypes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineCacheTypes); }
		}

		protected OfflineCacheTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
