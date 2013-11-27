using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ToastKeys", DoNotGenerateAcw=true)]
	public sealed partial class ToastKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='ACTION_MAPPINGS_KEY']"
		[Register ("ACTION_MAPPINGS_KEY")]
		public const string ActionMappingsKey = (string) "ACTION_MAPPINGS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_BUTTON_TEXT']"
		[Register ("TOAST_BUTTON_TEXT")]
		public const string ToastButtonText = (string) "buttonText";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_CLICK_DATA_KEY']"
		[Register ("TOAST_CLICK_DATA_KEY")]
		public const string ToastClickDataKey = (string) "TOAST_CLICK_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_DEDUPE_KEY']"
		[Register ("TOAST_DEDUPE_KEY")]
		public const string ToastDedupeKey = (string) "dedupeTypes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_DESCRIPTION_KEY']"
		[Register ("TOAST_DESCRIPTION_KEY")]
		public const string ToastDescriptionKey = (string) "description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_HEIGHT_KEY']"
		[Register ("TOAST_HEIGHT_KEY")]
		public const string ToastHeightKey = (string) "TOAST_HEIGHT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_HEIGHT_PIXELS']"
		[Register ("TOAST_HEIGHT_PIXELS")]
		public const int ToastHeightPixels = (int) 73;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_ICON_KEY']"
		[Register ("TOAST_ICON_KEY")]
		public const string ToastIconKey = (string) "icon";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_IS_GUEST_KEY']"
		[Register ("TOAST_IS_GUEST_KEY")]
		public const string ToastIsGuestKey = (string) "isGuest";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_METHOD_KEY']"
		[Register ("TOAST_METHOD_KEY")]
		public const string ToastMethodKey = (string) "method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_REQUEST_DISPLAYED']"
		[Register ("TOAST_REQUEST_DISPLAYED")]
		public const string ToastRequestDisplayed = (string) "toastRequestDisplayed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_SHOW_BUTTON_KEY']"
		[Register ("TOAST_SHOW_BUTTON_KEY")]
		public const string ToastShowButtonKey = (string) "showButton";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_TARGET_KEY']"
		[Register ("TOAST_TARGET_KEY")]
		public const string ToastTargetKey = (string) "target";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_TITLE_KEY']"
		[Register ("TOAST_TITLE_KEY")]
		public const string ToastTitleKey = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_TOUCH_X_KEY']"
		[Register ("TOAST_TOUCH_X_KEY")]
		public const string ToastTouchXKey = (string) "TOAST_TOUCH_X";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_TOUCH_Y_KEY']"
		[Register ("TOAST_TOUCH_Y_KEY")]
		public const string ToastTouchYKey = (string) "TOAST_TOUCH_Y";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_TYPE_KEY']"
		[Register ("TOAST_TYPE_KEY")]
		public const string ToastTypeKey = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_WIDTH_KEY']"
		[Register ("TOAST_WIDTH_KEY")]
		public const string ToastWidthKey = (string) "TOAST_WIDTH";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ToastKeys']/field[@name='TOAST_WIDTH_PIXELS']"
		[Register ("TOAST_WIDTH_PIXELS")]
		public const int ToastWidthPixels = (int) 320;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ToastKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToastKeys); }
		}

		internal ToastKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
