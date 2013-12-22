using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardPercentileItemImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/LeaderboardPercentileItemImpl", DoNotGenerateAcw=true)]
	public partial class LeaderboardPercentileItemImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/LeaderboardPercentileItemImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardPercentileItemImpl); }
		}

		protected LeaderboardPercentileItemImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardPercentileItemImpl']/constructor[@name='LeaderboardPercentileItemImpl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;JI)V", "")]
		public LeaderboardPercentileItemImpl (string p0, long p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (LeaderboardPercentileItemImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JI)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JI)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_JI == IntPtr.Zero)
				id_ctor_Ljava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JI, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JI, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getPercentile;
#pragma warning disable 0169
		static Delegate GetGetPercentileHandler ()
		{
			if (cb_getPercentile == null)
				cb_getPercentile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPercentile);
			return cb_getPercentile;
		}

		static int n_GetPercentile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Percentile;
		}
#pragma warning restore 0169

		static IntPtr id_getPercentile;
		public virtual int Percentile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardPercentileItemImpl']/method[@name='getPercentile' and count(parameter)=0]"
			[Register ("getPercentile", "()I", "GetGetPercentileHandler")]
			get {
				if (id_getPercentile == IntPtr.Zero)
					id_getPercentile = JNIEnv.GetMethodID (class_ref, "getPercentile", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPercentile);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getPercentile);
			}
		}

		static Delegate cb_getPlayerAlias;
#pragma warning disable 0169
		static Delegate GetGetPlayerAliasHandler ()
		{
			if (cb_getPlayerAlias == null)
				cb_getPlayerAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerAlias);
			return cb_getPlayerAlias;
		}

		static IntPtr n_GetPlayerAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerAlias);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerAlias;
		public virtual string PlayerAlias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardPercentileItemImpl']/method[@name='getPlayerAlias' and count(parameter)=0]"
			[Register ("getPlayerAlias", "()Ljava/lang/String;", "GetGetPlayerAliasHandler")]
			get {
				if (id_getPlayerAlias == IntPtr.Zero)
					id_getPlayerAlias = JNIEnv.GetMethodID (class_ref, "getPlayerAlias", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlayerAlias), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPlayerAlias), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayerScore;
#pragma warning disable 0169
		static Delegate GetGetPlayerScoreHandler ()
		{
			if (cb_getPlayerScore == null)
				cb_getPlayerScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPlayerScore);
			return cb_getPlayerScore;
		}

		static long n_GetPlayerScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardPercentileItemImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayerScore;
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerScore;
		public virtual long PlayerScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardPercentileItemImpl']/method[@name='getPlayerScore' and count(parameter)=0]"
			[Register ("getPlayerScore", "()J", "GetGetPlayerScoreHandler")]
			get {
				if (id_getPlayerScore == IntPtr.Zero)
					id_getPlayerScore = JNIEnv.GetMethodID (class_ref, "getPlayerScore", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getPlayerScore);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getPlayerScore);
			}
		}

	}
}
