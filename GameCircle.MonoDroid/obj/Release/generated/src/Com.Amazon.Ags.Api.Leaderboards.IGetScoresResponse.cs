using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']"
	[Register ("com/amazon/ags/api/leaderboards/GetScoresResponse", "", "Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker")]
	public partial interface IGetScoresResponse : global::Com.Amazon.Ags.Api.IRequestResponse {

		string DisplayText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getDisplayText' and count(parameter)=0]"
			[Register ("getDisplayText", "()Ljava/lang/String;", "GetGetDisplayTextHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

		string LeaderboardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getLeaderboardId' and count(parameter)=0]"
			[Register ("getLeaderboardId", "()Ljava/lang/String;", "GetGetLeaderboardIdHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

		string LeaderboardName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getLeaderboardName' and count(parameter)=0]"
			[Register ("getLeaderboardName", "()Ljava/lang/String;", "GetGetLeaderboardNameHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

		int NumScores {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getNumScores' and count(parameter)=0]"
			[Register ("getNumScores", "()I", "GetGetNumScoresHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Constants.ScoreFormat ScoreFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getScoreFormat' and count(parameter)=0]"
			[Register ("getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;", "GetGetScoreFormatHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.IScore> Scores {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetScoresResponse']/method[@name='getScores' and count(parameter)=0]"
			[Register ("getScores", "()Ljava/util/List;", "GetGetScoresHandler:Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponseInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/GetScoresResponse", DoNotGenerateAcw=true)]
	internal class IGetScoresResponseInvoker : global::Java.Lang.Object, IGetScoresResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/GetScoresResponse");
		IntPtr class_ref;

		public static IGetScoresResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetScoresResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.GetScoresResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetScoresResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGetScoresResponseInvoker); }
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getLeaderboardId;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardIdHandler ()
		{
			if (cb_getLeaderboardId == null)
				cb_getLeaderboardId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboardId);
			return cb_getLeaderboardId;
		}

		static IntPtr n_GetLeaderboardId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LeaderboardId);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboardId;
		public string LeaderboardId {
			get {
				if (id_getLeaderboardId == IntPtr.Zero)
					id_getLeaderboardId = JNIEnv.GetMethodID (class_ref, "getLeaderboardId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLeaderboardId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLeaderboardName;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardNameHandler ()
		{
			if (cb_getLeaderboardName == null)
				cb_getLeaderboardName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboardName);
			return cb_getLeaderboardName;
		}

		static IntPtr n_GetLeaderboardName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LeaderboardName);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboardName;
		public string LeaderboardName {
			get {
				if (id_getLeaderboardName == IntPtr.Zero)
					id_getLeaderboardName = JNIEnv.GetMethodID (class_ref, "getLeaderboardName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLeaderboardName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumScores;
#pragma warning disable 0169
		static Delegate GetGetNumScoresHandler ()
		{
			if (cb_getNumScores == null)
				cb_getNumScores = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumScores);
			return cb_getNumScores;
		}

		static int n_GetNumScores (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumScores;
		}
#pragma warning restore 0169

		IntPtr id_getNumScores;
		public int NumScores {
			get {
				if (id_getNumScores == IntPtr.Zero)
					id_getNumScores = JNIEnv.GetMethodID (class_ref, "getNumScores", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getNumScores);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getScores;
#pragma warning disable 0169
		static Delegate GetGetScoresHandler ()
		{
			if (cb_getScores == null)
				cb_getScores = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScores);
			return cb_getScores;
		}

		static IntPtr n_GetScores (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.IScore>.ToLocalJniHandle (__this.Scores);
		}
#pragma warning restore 0169

		IntPtr id_getScores;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.IScore> Scores {
			get {
				if (id_getScores == IntPtr.Zero)
					id_getScores = JNIEnv.GetMethodID (class_ref, "getScores", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.IScore>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getScores), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		IntPtr id_getError;
		public global::Com.Amazon.Ags.Api.ErrorCode Error {
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Lcom/amazon/ags/api/ErrorCode;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (JNIEnv.CallObjectMethod (Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isError;
#pragma warning disable 0169
		static Delegate GetIsErrorHandler ()
		{
			if (cb_isError == null)
				cb_isError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsError);
			return cb_isError;
		}

		static bool n_IsError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsError;
		}
#pragma warning restore 0169

		IntPtr id_isError;
		public bool IsError {
			get {
				if (id_isError == IntPtr.Zero)
					id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isError);
			}
		}

		static Delegate cb_getUserData;
#pragma warning disable 0169
		static Delegate GetGetUserDataHandler ()
		{
			if (cb_getUserData == null)
				cb_getUserData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserData);
			return cb_getUserData;
		}

		static IntPtr n_GetUserData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUserData ());
		}
#pragma warning restore 0169

		IntPtr id_getUserData;
		public global::Java.Lang.Object[] GetUserData ()
		{
			if (id_getUserData == IntPtr.Zero)
				id_getUserData = JNIEnv.GetMethodID (class_ref, "getUserData", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getUserData), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_setUserData_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUserData_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setUserData_arrayLjava_lang_Object_ == null)
				cb_setUserData_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserData_arrayLjava_lang_Object_);
			return cb_setUserData_arrayLjava_lang_Object_;
		}

		static void n_SetUserData_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetUserData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setUserData_arrayLjava_lang_Object_;
		public void SetUserData (global::Java.Lang.Object[] p0)
		{
			if (id_setUserData_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setUserData_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setUserData", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_setUserData_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
