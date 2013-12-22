using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/migration/MigrationResultCode", DoNotGenerateAcw=true)]
	public sealed partial class MigrationResultCode : global::Java.Lang.Enum {


		static IntPtr FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode Failure {
			get {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FAILURE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/field[@name='NETWORK_FAILURE']"
		[Register ("NETWORK_FAILURE")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode NetworkFailure {
			get {
				if (NETWORK_FAILURE_jfieldId == IntPtr.Zero)
					NETWORK_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_FAILURE", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_FAILURE_jfieldId == IntPtr.Zero)
					NETWORK_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_FAILURE", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_FAILURE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NO_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/field[@name='NO_DATA']"
		[Register ("NO_DATA")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode NoData {
			get {
				if (NO_DATA_jfieldId == IntPtr.Zero)
					NO_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_DATA", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NO_DATA_jfieldId == IntPtr.Zero)
					NO_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_DATA", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NO_DATA_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr WHISPERSYNC_OFF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/field[@name='WHISPERSYNC_OFF']"
		[Register ("WHISPERSYNC_OFF")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode WhispersyncOff {
			get {
				if (WHISPERSYNC_OFF_jfieldId == IntPtr.Zero)
					WHISPERSYNC_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WHISPERSYNC_OFF", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WHISPERSYNC_OFF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WHISPERSYNC_OFF_jfieldId == IntPtr.Zero)
					WHISPERSYNC_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WHISPERSYNC_OFF", "Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, WHISPERSYNC_OFF_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/whispersync/migration/MigrationResultCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MigrationResultCode); }
		}

		internal MigrationResultCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;", "")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/class[@name='MigrationResultCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;", "")]
		public static global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");
			return (global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode));
		}

	}
}
