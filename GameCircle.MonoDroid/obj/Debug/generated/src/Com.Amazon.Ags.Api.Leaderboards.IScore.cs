using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']"
	[Register ("com/amazon/ags/api/leaderboards/Score", "", "Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker")]
	public partial interface IScore : IJavaObject {

		string Leaderboard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']/method[@name='getLeaderboard' and count(parameter)=0]"
			[Register ("getLeaderboard", "()Ljava/lang/String;", "GetGetLeaderboardHandler:Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Api.Profiles.IPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/amazon/ags/api/profiles/Player;", "GetGetPlayerHandler:Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker, GameCircle.MonoDroid")] get;
		}

		int Rank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']/method[@name='getRank' and count(parameter)=0]"
			[Register ("getRank", "()I", "GetGetRankHandler:Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker, GameCircle.MonoDroid")] get;
		}

		string ScoreString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']/method[@name='getScoreString' and count(parameter)=0]"
			[Register ("getScoreString", "()Ljava/lang/String;", "GetGetScoreStringHandler:Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker, GameCircle.MonoDroid")] get;
		}

		long ScoreValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Score']/method[@name='getScoreValue' and count(parameter)=0]"
			[Register ("getScoreValue", "()J", "GetGetScoreValueHandler:Com.Amazon.Ags.Api.Leaderboards.IScoreInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/Score", DoNotGenerateAcw=true)]
	internal class IScoreInvoker : global::Java.Lang.Object, IScore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/Score");
		IntPtr class_ref;

		public static IScore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.Score"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IScoreInvoker); }
		}

		static Delegate cb_getLeaderboard;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardHandler ()
		{
			if (cb_getLeaderboard == null)
				cb_getLeaderboard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboard);
			return cb_getLeaderboard;
		}

		static IntPtr n_GetLeaderboard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IScore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IScore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Leaderboard);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboard;
		public string Leaderboard {
			get {
				if (id_getLeaderboard == IntPtr.Zero)
					id_getLeaderboard = JNIEnv.GetMethodID (class_ref, "getLeaderboard", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLeaderboard), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayer;
#pragma warning disable 0169
		static Delegate GetGetPlayerHandler ()
		{
			if (cb_getPlayer == null)
				cb_getPlayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayer);
			return cb_getPlayer;
		}

		static IntPtr n_GetPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IScore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IScore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Player);
		}
#pragma warning restore 0169

		IntPtr id_getPlayer;
		public global::Com.Amazon.Ags.Api.Profiles.IPlayer Player {
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/amazon/ags/api/profiles/Player;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (JNIEnv.CallObjectMethod (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRank;
#pragma warning disable 0169
		static Delegate GetGetRankHandler ()
		{
			if (cb_getRank == null)
				cb_getRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRank);
			return cb_getRank;
		}

		static int n_GetRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IScore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IScore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rank;
		}
#pragma warning restore 0169

		IntPtr id_getRank;
		public int Rank {
			get {
				if (id_getRank == IntPtr.Zero)
					id_getRank = JNIEnv.GetMethodID (class_ref, "getRank", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getRank);
			}
		}

		static Delegate cb_getScoreString;
#pragma warning disable 0169
		static Delegate GetGetScoreStringHandler ()
		{
			if (cb_getScoreString == null)
				cb_getScoreString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScoreString);
			return cb_getScoreString;
		}

		static IntPtr n_GetScoreString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IScore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IScore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScoreString);
		}
#pragma warning restore 0169

		IntPtr id_getScoreString;
		public string ScoreString {
			get {
				if (id_getScoreString == IntPtr.Zero)
					id_getScoreString = JNIEnv.GetMethodID (class_ref, "getScoreString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getScoreString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScoreValue;
#pragma warning disable 0169
		static Delegate GetGetScoreValueHandler ()
		{
			if (cb_getScoreValue == null)
				cb_getScoreValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetScoreValue);
			return cb_getScoreValue;
		}

		static long n_GetScoreValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IScore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IScore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScoreValue;
		}
#pragma warning restore 0169

		IntPtr id_getScoreValue;
		public long ScoreValue {
			get {
				if (id_getScoreValue == IntPtr.Zero)
					id_getScoreValue = JNIEnv.GetMethodID (class_ref, "getScoreValue", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getScoreValue);
			}
		}

	}

}
