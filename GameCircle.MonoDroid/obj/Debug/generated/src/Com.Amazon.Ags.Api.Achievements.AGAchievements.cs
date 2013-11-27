using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/achievements/AGAchievements", DoNotGenerateAcw=true)]
	public partial class AGAchievements : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/achievements/AGAchievements", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGAchievements); }
		}

		protected AGAchievements (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAchievement_Ljava_lang_String_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='getAchievement' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getAchievement", "(Ljava/lang/String;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetAchievement (string p0, global::Com.Amazon.Ags.Api.IAGResponseCallback p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getAchievement_Ljava_lang_String_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievement_Ljava_lang_String_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getAchievement", "(Ljava/lang/String;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievement_Ljava_lang_String_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='getAchievement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievement (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_getAchievements_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='getAchievements' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getAchievements", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetAchievements (global::Com.Amazon.Ags.Api.IAGResponseCallback p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getAchievements_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievements_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getAchievements", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievements_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAchievements_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='getAchievements' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievements (params global:: Java.Lang.Object[] p0)
		{
			if (id_getAchievements_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievements_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAchievements_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_showAchievementsOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='showAchievementsOverlay' and count(parameter)=0]"
		[Register ("showAchievementsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowAchievementsOverlay ()
		{
			if (id_showAchievementsOverlay == IntPtr.Zero)
				id_showAchievementsOverlay = JNIEnv.GetStaticMethodID (class_ref, "showAchievementsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showAchievementsOverlay), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_updateProgress_Ljava_lang_String_FLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='updateProgress' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("updateProgress", "(Ljava/lang/String;FLcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void UpdateProgress (string p0, float p1, global::Com.Amazon.Ags.Api.IAGResponseCallback p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_updateProgress_Ljava_lang_String_FLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_updateProgress_Ljava_lang_String_FLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "updateProgress", "(Ljava/lang/String;FLcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateProgress_Ljava_lang_String_FLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/class[@name='AGAchievements']/method[@name='updateProgress' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle UpdateProgress (string p0, float p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ == IntPtr.Zero)
				id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}
