using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardPercentileItem']"
	[Register ("com/amazon/ags/api/leaderboards/LeaderboardPercentileItem", "", "Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItemInvoker")]
	public partial interface ILeaderboardPercentileItem : IJavaObject {

		int Percentile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardPercentileItem']/method[@name='getPercentile' and count(parameter)=0]"
			[Register ("getPercentile", "()I", "GetGetPercentileHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItemInvoker, GameCircle.MonoDroid")] get;
		}

		string PlayerAlias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardPercentileItem']/method[@name='getPlayerAlias' and count(parameter)=0]"
			[Register ("getPlayerAlias", "()Ljava/lang/String;", "GetGetPlayerAliasHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItemInvoker, GameCircle.MonoDroid")] get;
		}

		long PlayerScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardPercentileItem']/method[@name='getPlayerScore' and count(parameter)=0]"
			[Register ("getPlayerScore", "()J", "GetGetPlayerScoreHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItemInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/LeaderboardPercentileItem", DoNotGenerateAcw=true)]
	internal class ILeaderboardPercentileItemInvoker : global::Java.Lang.Object, ILeaderboardPercentileItem {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/LeaderboardPercentileItem");
		IntPtr class_ref;

		public static ILeaderboardPercentileItem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboardPercentileItem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.LeaderboardPercentileItem"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardPercentileItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardPercentileItemInvoker); }
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Percentile;
		}
#pragma warning restore 0169

		IntPtr id_getPercentile;
		public int Percentile {
			get {
				if (id_getPercentile == IntPtr.Zero)
					id_getPercentile = JNIEnv.GetMethodID (class_ref, "getPercentile", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPercentile);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerAlias);
		}
#pragma warning restore 0169

		IntPtr id_getPlayerAlias;
		public string PlayerAlias {
			get {
				if (id_getPlayerAlias == IntPtr.Zero)
					id_getPlayerAlias = JNIEnv.GetMethodID (class_ref, "getPlayerAlias", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPlayerAlias), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayerScore;
		}
#pragma warning restore 0169

		IntPtr id_getPlayerScore;
		public long PlayerScore {
			get {
				if (id_getPlayerScore == IntPtr.Zero)
					id_getPlayerScore = JNIEnv.GetMethodID (class_ref, "getPlayerScore", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getPlayerScore);
			}
		}

	}

}
