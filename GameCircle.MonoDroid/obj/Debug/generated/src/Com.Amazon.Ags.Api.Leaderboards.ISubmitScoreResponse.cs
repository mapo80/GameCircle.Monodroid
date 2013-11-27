using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='SubmitScoreResponse']"
	[Register ("com/amazon/ags/api/leaderboards/SubmitScoreResponse", "", "Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponseInvoker")]
	public partial interface ISubmitScoreResponse : global::Com.Amazon.Ags.Api.IRequestResponse {

		global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer> NewRank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='SubmitScoreResponse']/method[@name='getNewRank' and count(parameter)=0]"
			[Register ("getNewRank", "()Ljava/util/Map;", "GetGetNewRankHandler:Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponseInvoker, GameCircle.MonoDroid")] get;
		}

		global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean> RankImproved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='SubmitScoreResponse']/method[@name='getRankImproved' and count(parameter)=0]"
			[Register ("getRankImproved", "()Ljava/util/Map;", "GetGetRankImprovedHandler:Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponseInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/SubmitScoreResponse", DoNotGenerateAcw=true)]
	internal class ISubmitScoreResponseInvoker : global::Java.Lang.Object, ISubmitScoreResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/SubmitScoreResponse");
		IntPtr class_ref;

		public static ISubmitScoreResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubmitScoreResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.SubmitScoreResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubmitScoreResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISubmitScoreResponseInvoker); }
		}

		static Delegate cb_getNewRank;
#pragma warning disable 0169
		static Delegate GetGetNewRankHandler ()
		{
			if (cb_getNewRank == null)
				cb_getNewRank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewRank);
			return cb_getNewRank;
		}

		static IntPtr n_GetNewRank (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer>.ToLocalJniHandle (__this.NewRank);
		}
#pragma warning restore 0169

		IntPtr id_getNewRank;
		public global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer> NewRank {
			get {
				if (id_getNewRank == IntPtr.Zero)
					id_getNewRank = JNIEnv.GetMethodID (class_ref, "getNewRank", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getNewRank), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRankImproved;
#pragma warning disable 0169
		static Delegate GetGetRankImprovedHandler ()
		{
			if (cb_getRankImproved == null)
				cb_getRankImproved = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRankImproved);
			return cb_getRankImproved;
		}

		static IntPtr n_GetRankImproved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.RankImproved);
		}
#pragma warning restore 0169

		IntPtr id_getRankImproved;
		public global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean> RankImproved {
			get {
				if (id_getRankImproved == IntPtr.Zero)
					id_getRankImproved = JNIEnv.GetMethodID (class_ref, "getRankImproved", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getRankImproved), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
