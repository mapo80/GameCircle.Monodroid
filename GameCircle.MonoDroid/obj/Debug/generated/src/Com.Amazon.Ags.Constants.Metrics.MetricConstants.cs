using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/MetricConstants", DoNotGenerateAcw=true)]
	public partial class MetricConstants : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']"
		[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys", DoNotGenerateAcw=true)]
		public sealed partial class MetricDecoratedValueAttributeKeys : global::Java.Lang.Enum {


			static IntPtr COUNTRY_SUPPORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='COUNTRY_SUPPORT']"
			[Register ("COUNTRY_SUPPORT")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys CountrySupport {
				get {
					if (COUNTRY_SUPPORT_jfieldId == IntPtr.Zero)
						COUNTRY_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTRY_SUPPORT", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COUNTRY_SUPPORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (COUNTRY_SUPPORT_jfieldId == IntPtr.Zero)
						COUNTRY_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTRY_SUPPORT", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, COUNTRY_SUPPORT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='DEVICE_ID']"
			[Register ("DEVICE_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys DeviceId {
				get {
					if (DEVICE_ID_jfieldId == IntPtr.Zero)
						DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_ID_jfieldId == IntPtr.Zero)
						DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_MANUFACTURER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='DEVICE_MANUFACTURER']"
			[Register ("DEVICE_MANUFACTURER")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys DeviceManufacturer {
				get {
					if (DEVICE_MANUFACTURER_jfieldId == IntPtr.Zero)
						DEVICE_MANUFACTURER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_MANUFACTURER", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_MANUFACTURER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_MANUFACTURER_jfieldId == IntPtr.Zero)
						DEVICE_MANUFACTURER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_MANUFACTURER", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_MANUFACTURER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_MODEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='DEVICE_MODEL']"
			[Register ("DEVICE_MODEL")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys DeviceModel {
				get {
					if (DEVICE_MODEL_jfieldId == IntPtr.Zero)
						DEVICE_MODEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_MODEL", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_MODEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_MODEL_jfieldId == IntPtr.Zero)
						DEVICE_MODEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_MODEL", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_MODEL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GAME_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='GAME_ID']"
			[Register ("GAME_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys GameId {
				get {
					if (GAME_ID_jfieldId == IntPtr.Zero)
						GAME_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GAME_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GAME_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GAME_ID_jfieldId == IntPtr.Zero)
						GAME_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GAME_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GAME_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='HIDDEN']"
			[Register ("HIDDEN")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys Hidden {
				get {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HIDDEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr JAVASCRIPT_VERSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='JAVASCRIPT_VERSION']"
			[Register ("JAVASCRIPT_VERSION")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys JavascriptVersion {
				get {
					if (JAVASCRIPT_VERSION_jfieldId == IntPtr.Zero)
						JAVASCRIPT_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVASCRIPT_VERSION", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVASCRIPT_VERSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (JAVASCRIPT_VERSION_jfieldId == IntPtr.Zero)
						JAVASCRIPT_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVASCRIPT_VERSION", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, JAVASCRIPT_VERSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NATIVE_VERSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='NATIVE_VERSION']"
			[Register ("NATIVE_VERSION")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys NativeVersion {
				get {
					if (NATIVE_VERSION_jfieldId == IntPtr.Zero)
						NATIVE_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_VERSION", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_VERSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NATIVE_VERSION_jfieldId == IntPtr.Zero)
						NATIVE_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_VERSION", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NATIVE_VERSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PLATFORM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='PLATFORM']"
			[Register ("PLATFORM")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys Platform {
				get {
					if (PLATFORM_jfieldId == IntPtr.Zero)
						PLATFORM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLATFORM", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLATFORM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PLATFORM_jfieldId == IntPtr.Zero)
						PLATFORM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLATFORM", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PLATFORM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PLAYER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='PLAYER_ID']"
			[Register ("PLAYER_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys PlayerId {
				get {
					if (PLAYER_ID_jfieldId == IntPtr.Zero)
						PLAYER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PLAYER_ID_jfieldId == IntPtr.Zero)
						PLAYER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PLAYER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PLAYING_ANONYMOUSLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/field[@name='PLAYING_ANONYMOUSLY']"
			[Register ("PLAYING_ANONYMOUSLY")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys PlayingAnonymously {
				get {
					if (PLAYING_ANONYMOUSLY_jfieldId == IntPtr.Zero)
						PLAYING_ANONYMOUSLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING_ANONYMOUSLY", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_ANONYMOUSLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PLAYING_ANONYMOUSLY_jfieldId == IntPtr.Zero)
						PLAYING_ANONYMOUSLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING_ANONYMOUSLY", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PLAYING_ANONYMOUSLY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetricDecoratedValueAttributeKeys); }
			}

			internal MetricDecoratedValueAttributeKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricDecoratedValueAttributeKeys']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricDecoratedValueAttributeKeys;");
				return (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricDecoratedValueAttributeKeys));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricRestrictedStringValueAttributeKeys']"
		[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys", DoNotGenerateAcw=true)]
		public sealed partial class MetricRestrictedStringValueAttributeKeys : global::Java.Lang.Enum {


			static IntPtr EVENT_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricRestrictedStringValueAttributeKeys']/field[@name='EVENT_NAME']"
			[Register ("EVENT_NAME")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys EventName {
				get {
					if (EVENT_NAME_jfieldId == IntPtr.Zero)
						EVENT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NAME", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_NAME_jfieldId == IntPtr.Zero)
						EVENT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NAME", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_NAME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PAGE_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricRestrictedStringValueAttributeKeys']/field[@name='PAGE_TYPE']"
			[Register ("PAGE_TYPE")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys PageType {
				get {
					if (PAGE_TYPE_jfieldId == IntPtr.Zero)
						PAGE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_TYPE", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAGE_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PAGE_TYPE_jfieldId == IntPtr.Zero)
						PAGE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_TYPE", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PAGE_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetricRestrictedStringValueAttributeKeys); }
			}

			internal MetricRestrictedStringValueAttributeKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricRestrictedStringValueAttributeKeys']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricRestrictedStringValueAttributeKeys']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricRestrictedStringValueAttributeKeys;");
				return (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricRestrictedStringValueAttributeKeys));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']"
		[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys", DoNotGenerateAcw=true)]
		public sealed partial class MetricStringValueAttributesKeys : global::Java.Lang.Enum {


			static IntPtr COUNTRY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='COUNTRY']"
			[Register ("COUNTRY")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys Country {
				get {
					if (COUNTRY_jfieldId == IntPtr.Zero)
						COUNTRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTRY", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COUNTRY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (COUNTRY_jfieldId == IntPtr.Zero)
						COUNTRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTRY", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, COUNTRY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GAME_DATA_SIZE_KB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='GAME_DATA_SIZE_KB']"
			[Register ("GAME_DATA_SIZE_KB")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys GameDataSizeKb {
				get {
					if (GAME_DATA_SIZE_KB_jfieldId == IntPtr.Zero)
						GAME_DATA_SIZE_KB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GAME_DATA_SIZE_KB", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GAME_DATA_SIZE_KB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GAME_DATA_SIZE_KB_jfieldId == IntPtr.Zero)
						GAME_DATA_SIZE_KB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GAME_DATA_SIZE_KB", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GAME_DATA_SIZE_KB_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OBJECT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='OBJECT_ID']"
			[Register ("OBJECT_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys ObjectId {
				get {
					if (OBJECT_ID_jfieldId == IntPtr.Zero)
						OBJECT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECT_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OBJECT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OBJECT_ID_jfieldId == IntPtr.Zero)
						OBJECT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECT_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OBJECT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PAGE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='PAGE_ID']"
			[Register ("PAGE_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys PageId {
				get {
					if (PAGE_ID_jfieldId == IntPtr.Zero)
						PAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAGE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PAGE_ID_jfieldId == IntPtr.Zero)
						PAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PAGE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SESSION_LENGTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='SESSION_LENGTH']"
			[Register ("SESSION_LENGTH")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys SessionLength {
				get {
					if (SESSION_LENGTH_jfieldId == IntPtr.Zero)
						SESSION_LENGTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_LENGTH", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_LENGTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SESSION_LENGTH_jfieldId == IntPtr.Zero)
						SESSION_LENGTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_LENGTH", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SESSION_LENGTH_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STATUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='STATUS']"
			[Register ("STATUS")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys Status {
				get {
					if (STATUS_jfieldId == IntPtr.Zero)
						STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STATUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STATUS_jfieldId == IntPtr.Zero)
						STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STATUS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TARGET_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/field[@name='TARGET_ID']"
			[Register ("TARGET_ID")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys TargetId {
				get {
					if (TARGET_ID_jfieldId == IntPtr.Zero)
						TARGET_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TARGET_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TARGET_ID_jfieldId == IntPtr.Zero)
						TARGET_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_ID", "Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TARGET_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetricStringValueAttributesKeys); }
			}

			internal MetricStringValueAttributesKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.MetricStringValueAttributesKeys']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$MetricStringValueAttributesKeys;");
				return (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.MetricStringValueAttributesKeys));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']"
		[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/MetricConstants$PageTypes", DoNotGenerateAcw=true)]
		public sealed partial class PageTypes : global::Java.Lang.Enum {


			static IntPtr GC_APP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']/field[@name='GC_APP']"
			[Register ("GC_APP")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes GcApp {
				get {
					if (GC_APP_jfieldId == IntPtr.Zero)
						GC_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GC_APP", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GC_APP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GC_APP_jfieldId == IntPtr.Zero)
						GC_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GC_APP", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GC_APP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IN_GAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']/field[@name='IN_GAME']"
			[Register ("IN_GAME")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes InGame {
				get {
					if (IN_GAME_jfieldId == IntPtr.Zero)
						IN_GAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_GAME", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_GAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IN_GAME_jfieldId == IntPtr.Zero)
						IN_GAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_GAME", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IN_GAME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr POPUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']/field[@name='POPUP']"
			[Register ("POPUP")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes Popup {
				get {
					if (POPUP_jfieldId == IntPtr.Zero)
						POPUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POPUP", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POPUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (POPUP_jfieldId == IntPtr.Zero)
						POPUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POPUP", "Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, POPUP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/MetricConstants$PageTypes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PageTypes); }
			}

			internal PageTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants.PageTypes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;", "")]
			public static global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/metrics/MetricConstants$PageTypes;");
				return (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Metrics.MetricConstants.PageTypes));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/MetricConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetricConstants); }
		}

		protected MetricConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='MetricConstants']/constructor[@name='MetricConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MetricConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MetricConstants)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
