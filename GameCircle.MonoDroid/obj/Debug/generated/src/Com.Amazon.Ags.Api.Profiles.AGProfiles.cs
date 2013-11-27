using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.profiles']/class[@name='AGProfiles']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/profiles/AGProfiles", DoNotGenerateAcw=true)]
	public partial class AGProfiles : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/profiles/AGProfiles", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGProfiles); }
		}

		protected AGProfiles (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLocalPlayerProfile_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.profiles']/class[@name='AGProfiles']/method[@name='getLocalPlayerProfile' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerProfile", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetLocalPlayerProfile (global::Com.Amazon.Ags.Api.IAGResponseCallback p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getLocalPlayerProfile_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerProfile_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfile", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocalPlayerProfile_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getLocalPlayerProfile_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.profiles']/class[@name='AGProfiles']/method[@name='getLocalPlayerProfile' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerProfile (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLocalPlayerProfile_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerProfile_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalPlayerProfile_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
