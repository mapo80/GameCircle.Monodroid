using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/achievements/AchievementImpl", DoNotGenerateAcw=true)]
	public partial class AchievementImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Achievements.IAchievement {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/achievements/AchievementImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AchievementImpl); }
		}

		protected AchievementImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IZZFILjava_util_Date_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/constructor[@name='AchievementImpl' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='float'] and parameter[8][@type='int'] and parameter[9][@type='java.util.Date'] and parameter[10][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZZFILjava/util/Date;Ljava/lang/String;)V", "")]
		public AchievementImpl (string p0, string p1, string p2, int p3, bool p4, bool p5, float p6, int p7, global::Java.Util.Date p8, string p9) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p9 = JNIEnv.NewString (p9);;
			if (GetType () != typeof (AchievementImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZZFILjava/util/Date;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (native_p9)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZZFILjava/util/Date;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (native_p9));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p9);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IZZFILjava_util_Date_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IZZFILjava_util_Date_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZZFILjava/util/Date;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IZZFILjava_util_Date_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (native_p9)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IZZFILjava_util_Date_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (native_p9));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p9);
		}

		static IntPtr id_getDateUnlocked;
		public global::Java.Util.Date DateUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getDateUnlocked' and count(parameter)=0]"
			[Register ("getDateUnlocked", "()Ljava/util/Date;", "GetGetDateUnlockedHandler")]
			get {
				if (id_getDateUnlocked == IntPtr.Zero)
					id_getDateUnlocked = JNIEnv.GetMethodID (class_ref, "getDateUnlocked", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getDateUnlocked), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDescription;
		public string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageURL;
#pragma warning disable 0169
		static Delegate GetGetImageURLHandler ()
		{
			if (cb_getImageURL == null)
				cb_getImageURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageURL);
			return cb_getImageURL;
		}

		static IntPtr n_GetImageURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Achievements.AchievementImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.AchievementImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		static IntPtr id_getImageURL;
		public virtual string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getImageURL' and count(parameter)=0]"
			[Register ("getImageURL", "()Ljava/lang/String;", "GetGetImageURLHandler")]
			get {
				if (id_getImageURL == IntPtr.Zero)
					id_getImageURL = JNIEnv.GetMethodID (class_ref, "getImageURL", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageURL), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isHidden;
		public bool IsHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='isHidden' and count(parameter)=0]"
			[Register ("isHidden", "()Z", "GetIsHiddenHandler")]
			get {
				if (id_isHidden == IntPtr.Zero)
					id_isHidden = JNIEnv.GetMethodID (class_ref, "isHidden", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isHidden);
			}
		}

		static IntPtr id_isUnlocked;
		public bool IsUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='isUnlocked' and count(parameter)=0]"
			[Register ("isUnlocked", "()Z", "GetIsUnlockedHandler")]
			get {
				if (id_isUnlocked == IntPtr.Zero)
					id_isUnlocked = JNIEnv.GetMethodID (class_ref, "isUnlocked", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isUnlocked);
			}
		}

		static IntPtr id_getPointValue;
		public int PointValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getPointValue' and count(parameter)=0]"
			[Register ("getPointValue", "()I", "GetGetPointValueHandler")]
			get {
				if (id_getPointValue == IntPtr.Zero)
					id_getPointValue = JNIEnv.GetMethodID (class_ref, "getPointValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getPointValue);
			}
		}

		static IntPtr id_getPosition;
		public int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getPosition);
			}
		}

		static IntPtr id_getProgress;
		public float Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()F", "GetGetProgressHandler")]
			get {
				if (id_getProgress == IntPtr.Zero)
					id_getProgress = JNIEnv.GetMethodID (class_ref, "getProgress", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getProgress);
			}
		}

		static IntPtr id_getTitle;
		public string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_copyWithNewProgress_Lcom_amazon_ags_api_achievements_Achievement_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='AchievementImpl']/method[@name='copyWithNewProgress' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.achievements.Achievement'] and parameter[2][@type='float']]"
		[Register ("copyWithNewProgress", "(Lcom/amazon/ags/api/achievements/Achievement;F)Lcom/amazon/ags/api/achievements/Achievement;", "")]
		public static global::Com.Amazon.Ags.Api.Achievements.IAchievement CopyWithNewProgress (global::Com.Amazon.Ags.Api.Achievements.IAchievement p0, float p1)
		{
			if (id_copyWithNewProgress_Lcom_amazon_ags_api_achievements_Achievement_F == IntPtr.Zero)
				id_copyWithNewProgress_Lcom_amazon_ags_api_achievements_Achievement_F = JNIEnv.GetStaticMethodID (class_ref, "copyWithNewProgress", "(Lcom/amazon/ags/api/achievements/Achievement;F)Lcom/amazon/ags/api/achievements/Achievement;");
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyWithNewProgress_Lcom_amazon_ags_api_achievements_Achievement_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
