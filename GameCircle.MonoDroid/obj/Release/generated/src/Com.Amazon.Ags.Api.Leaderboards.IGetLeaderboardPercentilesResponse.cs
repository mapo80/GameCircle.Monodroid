using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardPercentilesResponse']"
	[Register ("com/amazon/ags/api/leaderboards/GetLeaderboardPercentilesResponse", "", "Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponseInvoker")]
	public partial interface IGetLeaderboardPercentilesResponse : global::Com.Amazon.Ags.Api.IRequestResponse {

		global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard Leaderboard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardPercentilesResponse']/method[@name='getLeaderboard' and count(parameter)=0]"
			[Register ("getLeaderboard", "()Lcom/amazon/ags/api/leaderboards/Leaderboard;", "GetGetLeaderboardHandler:Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponseInvoker, GameCircle.MonoDroid")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> PercentileList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardPercentilesResponse']/method[@name='getPercentileList' and count(parameter)=0]"
			[Register ("getPercentileList", "()Ljava/util/List;", "GetGetPercentileListHandler:Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponseInvoker, GameCircle.MonoDroid")] get;
		}

		int UserIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardPercentilesResponse']/method[@name='getUserIndex' and count(parameter)=0]"
			[Register ("getUserIndex", "()I", "GetGetUserIndexHandler:Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponseInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/GetLeaderboardPercentilesResponse", DoNotGenerateAcw=true)]
	internal class IGetLeaderboardPercentilesResponseInvoker : global::Java.Lang.Object, IGetLeaderboardPercentilesResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/GetLeaderboardPercentilesResponse");
		IntPtr class_ref;

		public static IGetLeaderboardPercentilesResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetLeaderboardPercentilesResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.GetLeaderboardPercentilesResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetLeaderboardPercentilesResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGetLeaderboardPercentilesResponseInvoker); }
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Leaderboard);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboard;
		public global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard Leaderboard {
			get {
				if (id_getLeaderboard == IntPtr.Zero)
					id_getLeaderboard = JNIEnv.GetMethodID (class_ref, "getLeaderboard", "()Lcom/amazon/ags/api/leaderboards/Leaderboard;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (JNIEnv.CallObjectMethod (Handle, id_getLeaderboard), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPercentileList;
#pragma warning disable 0169
		static Delegate GetGetPercentileListHandler ()
		{
			if (cb_getPercentileList == null)
				cb_getPercentileList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPercentileList);
			return cb_getPercentileList;
		}

		static IntPtr n_GetPercentileList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.ToLocalJniHandle (__this.PercentileList);
		}
#pragma warning restore 0169

		IntPtr id_getPercentileList;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> PercentileList {
			get {
				if (id_getPercentileList == IntPtr.Zero)
					id_getPercentileList = JNIEnv.GetMethodID (class_ref, "getPercentileList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPercentileList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserIndex;
#pragma warning disable 0169
		static Delegate GetGetUserIndexHandler ()
		{
			if (cb_getUserIndex == null)
				cb_getUserIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserIndex);
			return cb_getUserIndex;
		}

		static int n_GetUserIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserIndex;
		}
#pragma warning restore 0169

		IntPtr id_getUserIndex;
		public int UserIndex {
			get {
				if (id_getUserIndex == IntPtr.Zero)
					id_getUserIndex = JNIEnv.GetMethodID (class_ref, "getUserIndex", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getUserIndex);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
