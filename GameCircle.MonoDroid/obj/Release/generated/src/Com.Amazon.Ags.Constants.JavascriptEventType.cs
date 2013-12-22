using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='JavascriptEventType']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/JavascriptEventType", DoNotGenerateAcw=true)]
	public partial class JavascriptEventType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='JavascriptEventType']/field[@name='SIGN_IN_EVENT']"
		[Register ("SIGN_IN_EVENT")]
		public const string SignInEvent = (string) "signInEvent";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/JavascriptEventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavascriptEventType); }
		}

		protected JavascriptEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
