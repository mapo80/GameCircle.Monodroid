using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/ScoreImpl", DoNotGenerateAcw=true)]
	public partial class ScoreImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Leaderboards.IScore {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/ScoreImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScoreImpl); }
		}

		protected ScoreImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLcom_amazon_ags_api_profiles_Player_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/constructor[@name='ScoreImpl' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.amazon.ags.api.profiles.Player'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(JLcom/amazon/ags/api/profiles/Player;ILjava/lang/String;)V", "")]
		public ScoreImpl (long p0, global::Com.Amazon.Ags.Api.Profiles.IPlayer p1, int p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (ScoreImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JLcom/amazon/ags/api/profiles/Player;ILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JLcom/amazon/ags/api/profiles/Player;ILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_JLcom_amazon_ags_api_profiles_Player_ILjava_lang_String_ == IntPtr.Zero)
				id_ctor_JLcom_amazon_ags_api_profiles_Player_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLcom/amazon/ags/api/profiles/Player;ILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLcom_amazon_ags_api_profiles_Player_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JLcom_amazon_ags_api_profiles_Player_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_getLeaderboard;
		public string Leaderboard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/method[@name='getLeaderboard' and count(parameter)=0]"
			[Register ("getLeaderboard", "()Ljava/lang/String;", "GetGetLeaderboardHandler")]
			get {
				if (id_getLeaderboard == IntPtr.Zero)
					id_getLeaderboard = JNIEnv.GetMethodID (class_ref, "getLeaderboard", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboard), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPlayer;
		public global::Com.Amazon.Ags.Api.Profiles.IPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/amazon/ags/api/profiles/Player;", "GetGetPlayerHandler")]
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/amazon/ags/api/profiles/Player;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (JNIEnv.CallObjectMethod  (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRank;
		public int Rank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/method[@name='getRank' and count(parameter)=0]"
			[Register ("getRank", "()I", "GetGetRankHandler")]
			get {
				if (id_getRank == IntPtr.Zero)
					id_getRank = JNIEnv.GetMethodID (class_ref, "getRank", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRank);
			}
		}

		static IntPtr id_getScoreString;
		public string ScoreString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/method[@name='getScoreString' and count(parameter)=0]"
			[Register ("getScoreString", "()Ljava/lang/String;", "GetGetScoreStringHandler")]
			get {
				if (id_getScoreString == IntPtr.Zero)
					id_getScoreString = JNIEnv.GetMethodID (class_ref, "getScoreString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScoreString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getScoreValue;
		public long ScoreValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='ScoreImpl']/method[@name='getScoreValue' and count(parameter)=0]"
			[Register ("getScoreValue", "()J", "GetGetScoreValueHandler")]
			get {
				if (id_getScoreValue == IntPtr.Zero)
					id_getScoreValue = JNIEnv.GetMethodID (class_ref, "getScoreValue", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getScoreValue);
			}
		}

	}
}
