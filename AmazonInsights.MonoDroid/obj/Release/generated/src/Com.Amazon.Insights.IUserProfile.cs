using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='UserProfile']"
	[Register ("com/amazon/insights/UserProfile", "", "Com.Amazon.Insights.IUserProfileInvoker")]
	public partial interface IUserProfile : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Dimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='UserProfile']/method[@name='getDimensions' and count(parameter)=0]"
			[Register ("getDimensions", "()Ljava/util/Map;", "GetGetDimensionsHandler:Com.Amazon.Insights.IUserProfileInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='UserProfile']/method[@name='addDimensionAsNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addDimensionAsNumber", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/UserProfile;", "GetAddDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_Handler:Com.Amazon.Insights.IUserProfileInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IUserProfile AddDimensionAsNumber (string p0, global::Java.Lang.Number p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='UserProfile']/method[@name='addDimensionAsString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addDimensionAsString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/UserProfile;", "GetAddDimensionAsString_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.IUserProfileInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IUserProfile AddDimensionAsString (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/UserProfile", DoNotGenerateAcw=true)]
	internal class IUserProfileInvoker : global::Java.Lang.Object, IUserProfile {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/UserProfile");
		IntPtr class_ref;

		public static IUserProfile GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserProfile> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.UserProfile"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserProfileInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUserProfileInvoker); }
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
			global::Com.Amazon.Insights.IUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Dimensions);
		}
#pragma warning restore 0169

		IntPtr id_getDimensions;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Dimensions {
			get {
				if (id_getDimensions == IntPtr.Zero)
					id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getDimensions), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Insights.IUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimensionAsNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_;
		public global::Com.Amazon.Insights.IUserProfile AddDimensionAsNumber (string p0, global::Java.Lang.Number p1)
		{
			if (id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addDimensionAsNumber", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/amazon/insights/UserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.IUserProfile __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod (Handle, id_addDimensionAsNumber_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.IUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDimensionAsString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Amazon.Insights.IUserProfile AddDimensionAsString (string p0, string p1)
		{
			if (id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDimensionAsString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/insights/UserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Amazon.Insights.IUserProfile __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IUserProfile> (JNIEnv.CallObjectMethod (Handle, id_addDimensionAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
