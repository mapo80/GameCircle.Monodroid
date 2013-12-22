using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProfilesBindingKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ProfilesBindingKeys", DoNotGenerateAcw=true)]
	public sealed partial class ProfilesBindingKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProfilesBindingKeys']/field[@name='ALIAS_KEY']"
		[Register ("ALIAS_KEY")]
		public const string AliasKey = (string) "ALIAS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProfilesBindingKeys']/field[@name='PLAYER_ID_KEY']"
		[Register ("PLAYER_ID_KEY")]
		public const string PlayerIdKey = (string) "playerId";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ProfilesBindingKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilesBindingKeys); }
		}

		internal ProfilesBindingKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
