using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/AmazonGamesFeature", DoNotGenerateAcw=true)]
	public sealed partial class AmazonGamesFeature : global::Java.Lang.Enum {


		static IntPtr Achievements_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/field[@name='Achievements']"
		[Register ("Achievements")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature Achievements {
			get {
				if (Achievements_jfieldId == IntPtr.Zero)
					Achievements_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Achievements", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Achievements_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesFeature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Achievements_jfieldId == IntPtr.Zero)
					Achievements_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Achievements", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, Achievements_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr Leaderboards_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/field[@name='Leaderboards']"
		[Register ("Leaderboards")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature Leaderboards {
			get {
				if (Leaderboards_jfieldId == IntPtr.Zero)
					Leaderboards_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Leaderboards", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Leaderboards_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesFeature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Leaderboards_jfieldId == IntPtr.Zero)
					Leaderboards_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Leaderboards", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, Leaderboards_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr Progress_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/field[@name='Progress']"
		[Register ("Progress")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature Progress {
			get {
				if (Progress_jfieldId == IntPtr.Zero)
					Progress_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Progress", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Progress_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesFeature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Progress_jfieldId == IntPtr.Zero)
					Progress_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Progress", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, Progress_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr Whispersync_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/field[@name='Whispersync']"
		[Register ("Whispersync")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature Whispersync {
			get {
				if (Whispersync_jfieldId == IntPtr.Zero)
					Whispersync_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Whispersync", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Whispersync_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesFeature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Whispersync_jfieldId == IntPtr.Zero)
					Whispersync_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Whispersync", "Lcom/amazon/ags/api/AmazonGamesFeature;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, Whispersync_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/AmazonGamesFeature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonGamesFeature); }
		}

		internal AmazonGamesFeature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_all;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/method[@name='all' and count(parameter)=0]"
		[Register ("all", "()Ljava/util/EnumSet;", "")]
		public static global::Java.Util.EnumSet All ()
		{
			if (id_all == IntPtr.Zero)
				id_all = JNIEnv.GetStaticMethodID (class_ref, "all", "()Ljava/util/EnumSet;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_all), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AmazonGamesFeature;", "")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AmazonGamesFeature;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.AmazonGamesFeature __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesFeature> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesFeature']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/AmazonGamesFeature;", "")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesFeature[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/AmazonGamesFeature;");
			return (global::Com.Amazon.Ags.Api.AmazonGamesFeature[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.AmazonGamesFeature));
		}

	}
}
