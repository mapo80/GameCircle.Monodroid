using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/whispersync/SynchronizeResultKey", DoNotGenerateAcw=true)]
	public sealed partial class SynchronizeResultKey : global::Java.Lang.Enum {


		static IntPtr ALREADY_SYNCHRONIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/field[@name='ALREADY_SYNCHRONIZED']"
		[Register ("ALREADY_SYNCHRONIZED")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey AlreadySynchronized {
			get {
				if (ALREADY_SYNCHRONIZED_jfieldId == IntPtr.Zero)
					ALREADY_SYNCHRONIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_SYNCHRONIZED", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALREADY_SYNCHRONIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALREADY_SYNCHRONIZED_jfieldId == IntPtr.Zero)
					ALREADY_SYNCHRONIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_SYNCHRONIZED", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ALREADY_SYNCHRONIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CONFLICT_DEFERRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/field[@name='CONFLICT_DEFERRED']"
		[Register ("CONFLICT_DEFERRED")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey ConflictDeferred {
			get {
				if (CONFLICT_DEFERRED_jfieldId == IntPtr.Zero)
					CONFLICT_DEFERRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT_DEFERRED", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFLICT_DEFERRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONFLICT_DEFERRED_jfieldId == IntPtr.Zero)
					CONFLICT_DEFERRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT_DEFERRED", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CONFLICT_DEFERRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DOWNLOAD_SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/field[@name='DOWNLOAD_SUCCESS']"
		[Register ("DOWNLOAD_SUCCESS")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey DownloadSuccess {
			get {
				if (DOWNLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					DOWNLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOAD_SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DOWNLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					DOWNLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DOWNLOAD_SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey Failure {
			get {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FAILURE_jfieldId == IntPtr.Zero)
					FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FAILURE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UPLOAD_SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/field[@name='UPLOAD_SUCCESS']"
		[Register ("UPLOAD_SUCCESS")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey UploadSuccess {
			get {
				if (UPLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					UPLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOAD_SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UPLOAD_SUCCESS_jfieldId == IntPtr.Zero)
					UPLOAD_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD_SUCCESS", "Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UPLOAD_SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/whispersync/SynchronizeResultKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronizeResultKey); }
		}

		internal SynchronizeResultKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='SynchronizeResultKey']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/whispersync/SynchronizeResultKey;");
			return (global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Whispersync.SynchronizeResultKey));
		}

	}
}
