using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProgressBindingKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ProgressBindingKeys", DoNotGenerateAcw=true)]
	public sealed partial class ProgressBindingKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProgressBindingKeys']/field[@name='MAX_PROGRESS_KEY']"
		[Register ("MAX_PROGRESS_KEY")]
		public const string MaxProgressKey = (string) "MAX_PROGRESS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ProgressBindingKeys']/field[@name='PLAYER_PROGRESS_KEY']"
		[Register ("PLAYER_PROGRESS_KEY")]
		public const string PlayerProgressKey = (string) "PLAYER_PROGRESS";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ProgressBindingKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProgressBindingKeys); }
		}

		internal ProgressBindingKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
