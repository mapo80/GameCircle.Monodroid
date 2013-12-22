using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/LeaderboardImpl", DoNotGenerateAcw=true)]
	public partial class LeaderboardImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/LeaderboardImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardImpl); }
		}

		protected LeaderboardImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/constructor[@name='LeaderboardImpl' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.amazon.ags.constants.ScoreFormat'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;)V", "")]
		public LeaderboardImpl (string p0, string p1, string p2, global::Com.Amazon.Ags.Constants.ScoreFormat p3, string p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p4 = JNIEnv.NewString (p4);;
			if (GetType () != typeof (LeaderboardImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_getDisplayText;
#pragma warning disable 0169
		static Delegate GetGetDisplayTextHandler ()
		{
			if (cb_getDisplayText == null)
				cb_getDisplayText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayText);
			return cb_getDisplayText;
		}

		static IntPtr n_GetDisplayText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayText);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayText;
		public virtual string DisplayText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/method[@name='getDisplayText' and count(parameter)=0]"
			[Register ("getDisplayText", "()Ljava/lang/String;", "GetGetDisplayTextHandler")]
			get {
				if (id_getDisplayText == IntPtr.Zero)
					id_getDisplayText = JNIEnv.GetMethodID (class_ref, "getDisplayText", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayText), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDisplayText), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		static IntPtr id_getImageURL;
		public virtual string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/method[@name='getImageURL' and count(parameter)=0]"
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreFormat;
#pragma warning disable 0169
		static Delegate GetGetScoreFormatHandler ()
		{
			if (cb_getScoreFormat == null)
				cb_getScoreFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreFormat);
			return cb_getScoreFormat;
		}

		static IntPtr n_GetScoreFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScoreFormat);
		}
#pragma warning restore 0169

		static IntPtr id_getScoreFormat;
		public virtual global::Com.Amazon.Ags.Constants.ScoreFormat ScoreFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardImpl']/method[@name='getScoreFormat' and count(parameter)=0]"
			[Register ("getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;", "GetGetScoreFormatHandler")]
			get {
				if (id_getScoreFormat == IntPtr.Zero)
					id_getScoreFormat = JNIEnv.GetMethodID (class_ref, "getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (JNIEnv.CallObjectMethod  (Handle, id_getScoreFormat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getScoreFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
