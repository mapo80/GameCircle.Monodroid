using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/overlay/PopUpLocation", DoNotGenerateAcw=true)]
	public sealed partial class PopUpLocation : global::Java.Lang.Enum {


		static IntPtr BOTTOM_CENTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='BOTTOM_CENTER']"
		[Register ("BOTTOM_CENTER")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation BottomCenter {
			get {
				if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
					BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_CENTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
					BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BOTTOM_CENTER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr BOTTOM_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='BOTTOM_LEFT']"
		[Register ("BOTTOM_LEFT")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation BottomLeft {
			get {
				if (BOTTOM_LEFT_jfieldId == IntPtr.Zero)
					BOTTOM_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_LEFT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BOTTOM_LEFT_jfieldId == IntPtr.Zero)
					BOTTOM_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_LEFT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BOTTOM_LEFT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr BOTTOM_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='BOTTOM_RIGHT']"
		[Register ("BOTTOM_RIGHT")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation BottomRight {
			get {
				if (BOTTOM_RIGHT_jfieldId == IntPtr.Zero)
					BOTTOM_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_RIGHT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BOTTOM_RIGHT_jfieldId == IntPtr.Zero)
					BOTTOM_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_RIGHT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BOTTOM_RIGHT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEFAULT_POPUP_LOCATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='DEFAULT_POPUP_LOCATION']"
		[Register ("DEFAULT_POPUP_LOCATION")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation DefaultPopupLocation {
			get {
				if (DEFAULT_POPUP_LOCATION_jfieldId == IntPtr.Zero)
					DEFAULT_POPUP_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_POPUP_LOCATION", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_POPUP_LOCATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_POPUP_LOCATION_jfieldId == IntPtr.Zero)
					DEFAULT_POPUP_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_POPUP_LOCATION", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_POPUP_LOCATION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TOP_CENTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='TOP_CENTER']"
		[Register ("TOP_CENTER")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation TopCenter {
			get {
				if (TOP_CENTER_jfieldId == IntPtr.Zero)
					TOP_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_CENTER", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_CENTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TOP_CENTER_jfieldId == IntPtr.Zero)
					TOP_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_CENTER", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TOP_CENTER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TOP_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='TOP_LEFT']"
		[Register ("TOP_LEFT")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation TopLeft {
			get {
				if (TOP_LEFT_jfieldId == IntPtr.Zero)
					TOP_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_LEFT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TOP_LEFT_jfieldId == IntPtr.Zero)
					TOP_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_LEFT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TOP_LEFT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TOP_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/field[@name='TOP_RIGHT']"
		[Register ("TOP_RIGHT")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation TopRight {
			get {
				if (TOP_RIGHT_jfieldId == IntPtr.Zero)
					TOP_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_RIGHT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TOP_RIGHT_jfieldId == IntPtr.Zero)
					TOP_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_RIGHT", "Lcom/amazon/ags/api/overlay/PopUpLocation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TOP_RIGHT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/overlay/PopUpLocation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PopUpLocation); }
		}

		internal PopUpLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLocationFromString_Ljava_lang_String_Lcom_amazon_ags_api_overlay_PopUpLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/method[@name='getLocationFromString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.api.overlay.PopUpLocation']]"
		[Register ("getLocationFromString", "(Ljava/lang/String;Lcom/amazon/ags/api/overlay/PopUpLocation;)Lcom/amazon/ags/api/overlay/PopUpLocation;", "")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation GetLocationFromString (string p0, global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p1)
		{
			if (id_getLocationFromString_Ljava_lang_String_Lcom_amazon_ags_api_overlay_PopUpLocation_ == IntPtr.Zero)
				id_getLocationFromString_Ljava_lang_String_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNIEnv.GetStaticMethodID (class_ref, "getLocationFromString", "(Ljava/lang/String;Lcom/amazon/ags/api/overlay/PopUpLocation;)Lcom/amazon/ags/api/overlay/PopUpLocation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Overlay.PopUpLocation __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocationFromString_Ljava_lang_String_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/overlay/PopUpLocation;", "")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/overlay/PopUpLocation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Overlay.PopUpLocation __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.overlay']/class[@name='PopUpLocation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/overlay/PopUpLocation;", "")]
		public static global::Com.Amazon.Ags.Api.Overlay.PopUpLocation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/overlay/PopUpLocation;");
			return (global::Com.Amazon.Ags.Api.Overlay.PopUpLocation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.Overlay.PopUpLocation));
		}

	}
}
