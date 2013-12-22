using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/whispersync/RevertResultKey", DoNotGenerateAcw=true)]
	public sealed partial class RevertResultKey : global::Java.Lang.Enum {


		static IntPtr DOWNLOAD_SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']/field[@name='DOWNLOAD_SUCCESS']"
		[Register ("DOWNLOAD_SUCCESS")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey DownloadSuccess {
			get {
				if (DOWNLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					DOWNLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOAD_SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DOWNLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					DOWNLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DOWNLOAD_SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey Failure {
			get {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FAILURE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PLAYER_CANCELLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']/field[@name='PLAYER_CANCELLED']"
		[Register ("PLAYER_CANCELLED")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey PlayerCancelled {
			get {
				if (PLAYER_CANCELLED_jfieldId == IntPtr.Zero)
					PLAYER_CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_CANCELLED", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_CANCELLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PLAYER_CANCELLED_jfieldId == IntPtr.Zero)
					PLAYER_CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_CANCELLED", "Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PLAYER_CANCELLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/whispersync/RevertResultKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RevertResultKey); }
		}

		internal RevertResultKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/RevertResultKey;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='RevertResultKey']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/whispersync/RevertResultKey;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/whispersync/RevertResultKey;");
			return (global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Whispersync.RevertResultKey));
		}

	}
}
