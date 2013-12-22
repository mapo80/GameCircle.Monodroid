using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='SubmitScoreResultJSONKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/SubmitScoreResultJSONKeys", DoNotGenerateAcw=true)]
	public sealed partial class SubmitScoreResultJSONKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='SubmitScoreResultJSONKeys']/field[@name='FILTER']"
		[Register ("FILTER")]
		public const string Filter = (string) "Scope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='SubmitScoreResultJSONKeys']/field[@name='IS_IMPROVED']"
		[Register ("IS_IMPROVED")]
		public const string IsImproved = (string) "IsImproved";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='SubmitScoreResultJSONKeys']/field[@name='PLAYER_RANK']"
		[Register ("PLAYER_RANK")]
		public const string PlayerRank = (string) "PlayerRank";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/SubmitScoreResultJSONKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitScoreResultJSONKeys); }
		}

		internal SubmitScoreResultJSONKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
