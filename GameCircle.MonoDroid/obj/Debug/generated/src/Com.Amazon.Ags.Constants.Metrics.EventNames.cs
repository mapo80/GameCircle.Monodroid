using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/metrics/EventNames", DoNotGenerateAcw=true)]
	public sealed partial class EventNames : global::Java.Lang.Enum {


		static IntPtr GameCircleInitialization_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/field[@name='GameCircleInitialization']"
		[Register ("GameCircleInitialization")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames GameCircleInitialization {
			get {
				if (GameCircleInitialization_jfieldId == IntPtr.Zero)
					GameCircleInitialization_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleInitialization", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GameCircleInitialization_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GameCircleInitialization_jfieldId == IntPtr.Zero)
					GameCircleInitialization_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleInitialization", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GameCircleInitialization_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GameCircleReinitialization_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/field[@name='GameCircleReinitialization']"
		[Register ("GameCircleReinitialization")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames GameCircleReinitialization {
			get {
				if (GameCircleReinitialization_jfieldId == IntPtr.Zero)
					GameCircleReinitialization_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleReinitialization", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GameCircleReinitialization_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GameCircleReinitialization_jfieldId == IntPtr.Zero)
					GameCircleReinitialization_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleReinitialization", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GameCircleReinitialization_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GameCircleServiceCall_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/field[@name='GameCircleServiceCall']"
		[Register ("GameCircleServiceCall")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames GameCircleServiceCall {
			get {
				if (GameCircleServiceCall_jfieldId == IntPtr.Zero)
					GameCircleServiceCall_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleServiceCall", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GameCircleServiceCall_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GameCircleServiceCall_jfieldId == IntPtr.Zero)
					GameCircleServiceCall_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameCircleServiceCall", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GameCircleServiceCall_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GameSession_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/field[@name='GameSession']"
		[Register ("GameSession")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames GameSession {
			get {
				if (GameSession_jfieldId == IntPtr.Zero)
					GameSession_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameSession", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GameSession_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GameSession_jfieldId == IntPtr.Zero)
					GameSession_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GameSession", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GameSession_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr OfflineCacheAccess_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/field[@name='OfflineCacheAccess']"
		[Register ("OfflineCacheAccess")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames OfflineCacheAccess {
			get {
				if (OfflineCacheAccess_jfieldId == IntPtr.Zero)
					OfflineCacheAccess_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OfflineCacheAccess", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OfflineCacheAccess_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OfflineCacheAccess_jfieldId == IntPtr.Zero)
					OfflineCacheAccess_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OfflineCacheAccess", "Lcom/amazon/ags/constants/metrics/EventNames;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, OfflineCacheAccess_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/metrics/EventNames", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventNames); }
		}

		internal EventNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/EventNames;", "")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/metrics/EventNames;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.Metrics.EventNames __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Metrics.EventNames> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.metrics']/class[@name='EventNames']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/metrics/EventNames;", "")]
		public static global::Com.Amazon.Ags.Constants.Metrics.EventNames[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/metrics/EventNames;");
			return (global::Com.Amazon.Ags.Constants.Metrics.EventNames[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Metrics.EventNames));
		}

	}
}
