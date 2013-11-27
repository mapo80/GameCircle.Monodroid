using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/achievements/AchievementsJni", DoNotGenerateAcw=true)]
	public partial class AchievementsJni : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/achievements/AchievementsJni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AchievementsJni); }
		}

		protected AchievementsJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/constructor[@name='AchievementsJni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AchievementsJni () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AchievementsJni)) {
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

		static IntPtr id_getAchievementResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='getAchievementResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getAchievementResponseFailure", "(JII)V", "")]
		public static void GetAchievementResponseFailure (long p0, int p1, int p2)
		{
			if (id_getAchievementResponseFailure_JII == IntPtr.Zero)
				id_getAchievementResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getAchievementResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievementResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getAchievementResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='getAchievementResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.achievements.GetAchievementResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getAchievementResponseSuccess", "(Lcom/amazon/ags/api/achievements/GetAchievementResponse;JI)V", "")]
		public static void GetAchievementResponseSuccess (global::Com.Amazon.Ags.Api.Achievements.IGetAchievementResponse p0, long p1, int p2)
		{
			if (id_getAchievementResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementResponse_JI == IntPtr.Zero)
				id_getAchievementResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getAchievementResponseSuccess", "(Lcom/amazon/ags/api/achievements/GetAchievementResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievementResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getAchievementsResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='getAchievementsResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getAchievementsResponseFailure", "(JII)V", "")]
		public static void GetAchievementsResponseFailure (long p0, int p1, int p2)
		{
			if (id_getAchievementsResponseFailure_JII == IntPtr.Zero)
				id_getAchievementsResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getAchievementsResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievementsResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getAchievementsResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementsResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='getAchievementsResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.achievements.GetAchievementsResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getAchievementsResponseSuccess", "(Lcom/amazon/ags/api/achievements/GetAchievementsResponse;JI)V", "")]
		public static void GetAchievementsResponseSuccess (global::Com.Amazon.Ags.Api.Achievements.IGetAchievementsResponse p0, long p1, int p2)
		{
			if (id_getAchievementsResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementsResponse_JI == IntPtr.Zero)
				id_getAchievementsResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementsResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getAchievementsResponseSuccess", "(Lcom/amazon/ags/api/achievements/GetAchievementsResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getAchievementsResponseSuccess_Lcom_amazon_ags_api_achievements_GetAchievementsResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_updateProgressResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='updateProgressResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("updateProgressResponseFailure", "(JII)V", "")]
		public static void UpdateProgressResponseFailure (long p0, int p1, int p2)
		{
			if (id_updateProgressResponseFailure_JII == IntPtr.Zero)
				id_updateProgressResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "updateProgressResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateProgressResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_updateProgressResponseSuccess_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsJni']/method[@name='updateProgressResponseSuccess' and count(parameter)=4 and parameter[1][@type='com.amazon.ags.api.achievements.UpdateProgressResponse'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register ("updateProgressResponseSuccess", "(Lcom/amazon/ags/api/achievements/UpdateProgressResponse;Ljava/lang/String;JI)V", "")]
		public static void UpdateProgressResponseSuccess (global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse p0, string p1, long p2, int p3)
		{
			if (id_updateProgressResponseSuccess_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Ljava_lang_String_JI == IntPtr.Zero)
				id_updateProgressResponseSuccess_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Ljava_lang_String_JI = JNIEnv.GetStaticMethodID (class_ref, "updateProgressResponseSuccess", "(Lcom/amazon/ags/api/achievements/UpdateProgressResponse;Ljava/lang/String;JI)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateProgressResponseSuccess_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Ljava_lang_String_JI, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
