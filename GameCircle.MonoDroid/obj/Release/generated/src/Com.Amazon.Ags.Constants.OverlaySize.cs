using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlaySize']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/OverlaySize", DoNotGenerateAcw=true)]
	public sealed partial class OverlaySize : global::Java.Lang.Object {


		static IntPtr ALERT_HEIGHT_PIXELS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlaySize']/field[@name='ALERT_HEIGHT_PIXELS']"
		[Register ("ALERT_HEIGHT_PIXELS")]
		public static int AlertHeightPixels {
			get {
				if (ALERT_HEIGHT_PIXELS_jfieldId == IntPtr.Zero)
					ALERT_HEIGHT_PIXELS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALERT_HEIGHT_PIXELS", "I");
				return JNIEnv.GetStaticIntField (class_ref, ALERT_HEIGHT_PIXELS_jfieldId);
			}
			set {
				if (ALERT_HEIGHT_PIXELS_jfieldId == IntPtr.Zero)
					ALERT_HEIGHT_PIXELS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALERT_HEIGHT_PIXELS", "I");
				JNIEnv.SetStaticField (class_ref, ALERT_HEIGHT_PIXELS_jfieldId, value);
			}
		}

		static IntPtr ALERT_WIDTH_PIXELS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlaySize']/field[@name='ALERT_WIDTH_PIXELS']"
		[Register ("ALERT_WIDTH_PIXELS")]
		public static int AlertWidthPixels {
			get {
				if (ALERT_WIDTH_PIXELS_jfieldId == IntPtr.Zero)
					ALERT_WIDTH_PIXELS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALERT_WIDTH_PIXELS", "I");
				return JNIEnv.GetStaticIntField (class_ref, ALERT_WIDTH_PIXELS_jfieldId);
			}
			set {
				if (ALERT_WIDTH_PIXELS_jfieldId == IntPtr.Zero)
					ALERT_WIDTH_PIXELS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALERT_WIDTH_PIXELS", "I");
				JNIEnv.SetStaticField (class_ref, ALERT_WIDTH_PIXELS_jfieldId, value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlaySize']/field[@name='TOAST_HEIGHT_PIXELS']"
		[Register ("TOAST_HEIGHT_PIXELS")]
		public const int ToastHeightPixels = (int) 73;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='OverlaySize']/field[@name='TOAST_WIDTH_PIXELS']"
		[Register ("TOAST_WIDTH_PIXELS")]
		public const int ToastWidthPixels = (int) 320;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/OverlaySize", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlaySize); }
		}

		internal OverlaySize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
