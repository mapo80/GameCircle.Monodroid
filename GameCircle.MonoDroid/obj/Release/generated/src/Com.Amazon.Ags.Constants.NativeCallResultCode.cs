using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/NativeCallResultCode", DoNotGenerateAcw=true)]
	public partial class NativeCallResultCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']/field[@name='AUTHORIZATION_ERROR']"
		[Register ("AUTHORIZATION_ERROR")]
		public const string AuthorizationError = (string) "AUTHORIZATION_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const string Error = (string) "ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const string NetworkError = (string) "NETWORK_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']/field[@name='REQUEST_ERROR']"
		[Register ("REQUEST_ERROR")]
		public const string RequestError = (string) "REQUEST_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='NativeCallResultCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const string Success = (string) "SUCCESS";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/NativeCallResultCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeCallResultCode); }
		}

		protected NativeCallResultCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
