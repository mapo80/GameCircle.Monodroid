using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']"
	[Register ("com/amazon/ags/api/leaderboards/Leaderboard", "", "Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker")]
	public partial interface ILeaderboard : IJavaObject {

		string DisplayText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']/method[@name='getDisplayText' and count(parameter)=0]"
			[Register ("getDisplayText", "()Ljava/lang/String;", "GetGetDisplayTextHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker, GameCircle.MonoDroid")] get;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker, GameCircle.MonoDroid")] get;
		}

		string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']/method[@name='getImageURL' and count(parameter)=0]"
			[Register ("getImageURL", "()Ljava/lang/String;", "GetGetImageURLHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker, GameCircle.MonoDroid")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Constants.ScoreFormat ScoreFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='Leaderboard']/method[@name='getScoreFormat' and count(parameter)=0]"
			[Register ("getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;", "GetGetScoreFormatHandler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/Leaderboard", DoNotGenerateAcw=true)]
	internal class ILeaderboardInvoker : global::Java.Lang.Object, ILeaderboard {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/Leaderboard");
		IntPtr class_ref;

		public static ILeaderboard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.Leaderboard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardInvoker); }
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayText);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayText;
		public string DisplayText {
			get {
				if (id_getDisplayText == IntPtr.Zero)
					id_getDisplayText = JNIEnv.GetMethodID (class_ref, "getDisplayText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDisplayText), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		IntPtr id_getImageURL;
		public string ImageURL {
			get {
				if (id_getImageURL == IntPtr.Zero)
					id_getImageURL = JNIEnv.GetMethodID (class_ref, "getImageURL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getImageURL), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScoreFormat);
		}
#pragma warning restore 0169

		IntPtr id_getScoreFormat;
		public global::Com.Amazon.Ags.Constants.ScoreFormat ScoreFormat {
			get {
				if (id_getScoreFormat == IntPtr.Zero)
					id_getScoreFormat = JNIEnv.GetMethodID (class_ref, "getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (JNIEnv.CallObjectMethod (Handle, id_getScoreFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
