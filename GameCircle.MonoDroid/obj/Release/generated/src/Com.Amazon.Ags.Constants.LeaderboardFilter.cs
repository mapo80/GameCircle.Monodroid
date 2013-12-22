using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/LeaderboardFilter", DoNotGenerateAcw=true)]
	public sealed partial class LeaderboardFilter : global::Java.Lang.Enum {


		static IntPtr FRIENDS_ALL_TIME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/field[@name='FRIENDS_ALL_TIME']"
		[Register ("FRIENDS_ALL_TIME")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter FriendsAllTime {
			get {
				if (FRIENDS_ALL_TIME_jfieldId == IntPtr.Zero)
					FRIENDS_ALL_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRIENDS_ALL_TIME", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRIENDS_ALL_TIME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FRIENDS_ALL_TIME_jfieldId == IntPtr.Zero)
					FRIENDS_ALL_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRIENDS_ALL_TIME", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FRIENDS_ALL_TIME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GLOBAL_ALL_TIME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/field[@name='GLOBAL_ALL_TIME']"
		[Register ("GLOBAL_ALL_TIME")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter GlobalAllTime {
			get {
				if (GLOBAL_ALL_TIME_jfieldId == IntPtr.Zero)
					GLOBAL_ALL_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_ALL_TIME", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GLOBAL_ALL_TIME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GLOBAL_ALL_TIME_jfieldId == IntPtr.Zero)
					GLOBAL_ALL_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_ALL_TIME", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GLOBAL_ALL_TIME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GLOBAL_DAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/field[@name='GLOBAL_DAY']"
		[Register ("GLOBAL_DAY")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter GlobalDay {
			get {
				if (GLOBAL_DAY_jfieldId == IntPtr.Zero)
					GLOBAL_DAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_DAY", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GLOBAL_DAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GLOBAL_DAY_jfieldId == IntPtr.Zero)
					GLOBAL_DAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_DAY", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GLOBAL_DAY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GLOBAL_WEEK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/field[@name='GLOBAL_WEEK']"
		[Register ("GLOBAL_WEEK")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter GlobalWeek {
			get {
				if (GLOBAL_WEEK_jfieldId == IntPtr.Zero)
					GLOBAL_WEEK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_WEEK", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GLOBAL_WEEK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GLOBAL_WEEK_jfieldId == IntPtr.Zero)
					GLOBAL_WEEK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_WEEK", "Lcom/amazon/ags/constants/LeaderboardFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GLOBAL_WEEK_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/LeaderboardFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardFilter); }
		}

		internal LeaderboardFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromOrdinal_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/method[@name='fromOrdinal' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromOrdinal", "(I)Lcom/amazon/ags/constants/LeaderboardFilter;", "")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter FromOrdinal (int p0)
		{
			if (id_fromOrdinal_I == IntPtr.Zero)
				id_fromOrdinal_I = JNIEnv.GetStaticMethodID (class_ref, "fromOrdinal", "(I)Lcom/amazon/ags/constants/LeaderboardFilter;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromOrdinal_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/LeaderboardFilter;", "")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/LeaderboardFilter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='LeaderboardFilter']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/LeaderboardFilter;", "")]
		public static global::Com.Amazon.Ags.Constants.LeaderboardFilter[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/LeaderboardFilter;");
			return (global::Com.Amazon.Ags.Constants.LeaderboardFilter[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.LeaderboardFilter));
		}

	}
}
