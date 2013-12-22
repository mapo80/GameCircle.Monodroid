using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientVersionConstants']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ClientVersionConstants", DoNotGenerateAcw=true)]
	public partial class ClientVersionConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientVersionConstants']/field[@name='CLIENT_VERSION_KEY']"
		[Register ("CLIENT_VERSION_KEY")]
		public const string ClientVersionKey = (string) "CLIENT_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientVersionConstants']/field[@name='CLIENT_VERSION_VALUE']"
		[Register ("CLIENT_VERSION_VALUE")]
		public const string ClientVersionValue = (string) "1.0.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ClientVersionConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientVersionConstants); }
		}

		protected ClientVersionConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
