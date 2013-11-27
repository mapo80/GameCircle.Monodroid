using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/whispersync/ConflictStrategy", DoNotGenerateAcw=true)]
	public sealed partial class ConflictStrategy : global::Java.Lang.Enum {


		static IntPtr AUTO_RESOLVE_TO_CLOUD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']/field[@name='AUTO_RESOLVE_TO_CLOUD']"
		[Register ("AUTO_RESOLVE_TO_CLOUD")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy AutoResolveToCloud {
			get {
				if (AUTO_RESOLVE_TO_CLOUD_jfieldId == IntPtr.Zero)
					AUTO_RESOLVE_TO_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_RESOLVE_TO_CLOUD", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_RESOLVE_TO_CLOUD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTO_RESOLVE_TO_CLOUD_jfieldId == IntPtr.Zero)
					AUTO_RESOLVE_TO_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_RESOLVE_TO_CLOUD", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, AUTO_RESOLVE_TO_CLOUD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr AUTO_RESOLVE_TO_IGNORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']/field[@name='AUTO_RESOLVE_TO_IGNORE']"
		[Register ("AUTO_RESOLVE_TO_IGNORE")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy AutoResolveToIgnore {
			get {
				if (AUTO_RESOLVE_TO_IGNORE_jfieldId == IntPtr.Zero)
					AUTO_RESOLVE_TO_IGNORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_RESOLVE_TO_IGNORE", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_RESOLVE_TO_IGNORE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTO_RESOLVE_TO_IGNORE_jfieldId == IntPtr.Zero)
					AUTO_RESOLVE_TO_IGNORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_RESOLVE_TO_IGNORE", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, AUTO_RESOLVE_TO_IGNORE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PLAYER_SELECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']/field[@name='PLAYER_SELECT']"
		[Register ("PLAYER_SELECT")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy PlayerSelect {
			get {
				if (PLAYER_SELECT_jfieldId == IntPtr.Zero)
					PLAYER_SELECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_SELECT", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_SELECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PLAYER_SELECT_jfieldId == IntPtr.Zero)
					PLAYER_SELECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_SELECT", "Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PLAYER_SELECT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/whispersync/ConflictStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConflictStrategy); }
		}

		internal ConflictStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/ConflictStrategy;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants.whispersync']/class[@name='ConflictStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/whispersync/ConflictStrategy;", "")]
		public static global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/whispersync/ConflictStrategy;");
			return (global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.Whispersync.ConflictStrategy));
		}

	}
}
