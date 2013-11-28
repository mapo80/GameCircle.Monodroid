using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/achievements/AchievementsNativeHandler", DoNotGenerateAcw=true)]
	public partial class AchievementsNativeHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/achievements/AchievementsNativeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AchievementsNativeHandler); }
		}

		protected AchievementsNativeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/constructor[@name='AchievementsNativeHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AchievementsNativeHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AchievementsNativeHandler)) {
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

		static IntPtr id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='initializeNativeHandler' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesClient']]"
		[Register ("initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V", "")]
		public static void InitializeNativeHandler (global::Com.Amazon.Ags.Api.AmazonGamesClient p0)
		{
			if (id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ == IntPtr.Zero)
				id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ = JNIEnv.GetStaticMethodID (class_ref, "initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_, new JValue (p0));
		}

		static IntPtr id_requestAchievement_Ljava_lang_String_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='requestAchievement' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("requestAchievement", "(Ljava/lang/String;IJ)V", "")]
		public static void RequestAchievement (string p0, int p1, long p2)
		{
			if (id_requestAchievement_Ljava_lang_String_IJ == IntPtr.Zero)
				id_requestAchievement_Ljava_lang_String_IJ = JNIEnv.GetStaticMethodID (class_ref, "requestAchievement", "(Ljava/lang/String;IJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestAchievement_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_requestAchievementHandle_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='requestAchievementHandle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("requestAchievementHandle", "(Ljava/lang/String;I)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle RequestAchievementHandle (string p0, int p1)
		{
			if (id_requestAchievementHandle_Ljava_lang_String_I == IntPtr.Zero)
				id_requestAchievementHandle_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "requestAchievementHandle", "(Ljava/lang/String;I)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestAchievementHandle_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_requestAchievements_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='requestAchievements' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("requestAchievements", "(IJ)V", "")]
		public static void RequestAchievements (int p0, long p1)
		{
			if (id_requestAchievements_IJ == IntPtr.Zero)
				id_requestAchievements_IJ = JNIEnv.GetStaticMethodID (class_ref, "requestAchievements", "(IJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestAchievements_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_requestAchievementsHandle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='requestAchievementsHandle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestAchievementsHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle RequestAchievementsHandle (int p0)
		{
			if (id_requestAchievementsHandle_I == IntPtr.Zero)
				id_requestAchievementsHandle_I = JNIEnv.GetStaticMethodID (class_ref, "requestAchievementsHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestAchievementsHandle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_showAchievementsOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='showAchievementsOverlay' and count(parameter)=0]"
		[Register ("showAchievementsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowAchievementsOverlay ()
		{
			if (id_showAchievementsOverlay == IntPtr.Zero)
				id_showAchievementsOverlay = JNIEnv.GetStaticMethodID (class_ref, "showAchievementsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showAchievementsOverlay), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_updateProgress_Ljava_lang_String_FIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='updateProgress' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("updateProgress", "(Ljava/lang/String;FIJ)V", "")]
		public static void UpdateProgress (string p0, float p1, int p2, long p3)
		{
			if (id_updateProgress_Ljava_lang_String_FIJ == IntPtr.Zero)
				id_updateProgress_Ljava_lang_String_FIJ = JNIEnv.GetStaticMethodID (class_ref, "updateProgress", "(Ljava/lang/String;FIJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateProgress_Ljava_lang_String_FIJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_updateProgressHandle_Ljava_lang_String_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='AchievementsNativeHandler']/method[@name='updateProgressHandle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("updateProgressHandle", "(Ljava/lang/String;FI)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle UpdateProgressHandle (string p0, float p1, int p2)
		{
			if (id_updateProgressHandle_Ljava_lang_String_FI == IntPtr.Zero)
				id_updateProgressHandle_Ljava_lang_String_FI = JNIEnv.GetStaticMethodID (class_ref, "updateProgressHandle", "(Ljava/lang/String;FI)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_updateProgressHandle_Ljava_lang_String_FI, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
