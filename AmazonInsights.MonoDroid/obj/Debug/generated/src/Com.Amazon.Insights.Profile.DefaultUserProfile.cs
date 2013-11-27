using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Profile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']"
	[global::Android.Runtime.Register ("com/amazon/insights/profile/DefaultUserProfile", DoNotGenerateAcw=true)]
	public partial class DefaultUserProfile : global::Java.Lang.Object, global::Com.Amazon.Insights.IUserProfile, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/profile/DefaultUserProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultUserProfile); }
		}

		protected DefaultUserProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/constructor[@name='DefaultUserProfile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultUserProfile () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultUserProfile)) {
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

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDimensions);
			return cb_getDimensions;
		}

		static IntPtr n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Profile.DefaultUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Dimensions);
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Dimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='getDimensions' and count(parameter)=0]"
			[Register ("getDimensions", "()Ljava/util/Map;", "GetGetDimensionsHandler")]
			get {
				if (id_getDimensions == IntPtr.Zero)
					id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDimensions), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDimensions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addDimensionAsBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddDimensionAsBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_addDimensionAsBoolean_Ljava_lang_String_Z == null)
				cb_addDimensionAsBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_AddDimensionAsBoolean_Ljava_lang_String_Z);
			return cb_addDimensionAsBoolean_Ljava_lang_String_Z;
		}

		static IntPtr n_AddDimensionAsBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Amazon.Insights.Profile.DefaultUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimensionAsBoolean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimensionAsBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='addDimensionAsBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addDimensionAsBoolean", "(Ljava/lang/String;Z)Lcom/amazon/insights/UserProfile;", "GetAddDimensionAsBoolean_Ljava_lang_String_ZHandler")]
		public virtual global::Com.Amazon.Insights.IUserProfile AddDimensionAsBoolean (string p0, bool p1)
		{
			if (id_addDimensionAsBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_addDimensionAsBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "addDimensionAsBoolean", "(Ljava/lang/String;Z)Lcom/amazon/insights/UserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.IUserProfile __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_addDimensionAsBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addDimensionAsBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_);
			return cb_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_;
		}

		static IntPtr n_AddDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Profile.DefaultUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimensionAsNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='addDimensionAsNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addDimensionAsNumber", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/UserProfile;", "GetAddDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_Handler")]
		public virtual global::Com.Amazon.Insights.IUserProfile AddDimensionAsNumber (string p0, global::Java.Lang.Number p1)
		{
			if (id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addDimensionAsNumber", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/UserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.IUserProfile __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDimensionAsString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDimensionAsString_Ljava_lang_String_Ljava_lang_String_);
			return cb_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddDimensionAsString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Profile.DefaultUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimensionAsString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='addDimensionAsString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addDimensionAsString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/UserProfile;", "GetAddDimensionAsString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.IUserProfile AddDimensionAsString (string p0, string p1)
		{
			if (id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDimensionAsString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/UserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Amazon.Insights.IUserProfile __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod  (Handle, id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_insights_profile_DefaultUserProfile_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_ == null)
				cb_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_insights_profile_DefaultUserProfile_);
			return cb_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_;
		}

		static int n_CompareTo_Lcom_amazon_insights_profile_DefaultUserProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Profile.DefaultUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Profile.DefaultUserProfile p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Profile.DefaultUserProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.profile.DefaultUserProfile']]"
		[Register ("compareTo", "(Lcom/amazon/insights/profile/DefaultUserProfile;)I", "GetCompareTo_Lcom_amazon_insights_profile_DefaultUserProfile_Handler")]
		public virtual int CompareTo (global::Java.Lang.Object p0)
		{
			if (id_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/insights/profile/DefaultUserProfile;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_compareTo_Lcom_amazon_insights_profile_DefaultUserProfile_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.profile']/class[@name='DefaultUserProfile']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/amazon/insights/UserProfile;", "")]
		public static global::Com.Amazon.Insights.IUserProfile NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/amazon/insights/UserProfile;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
