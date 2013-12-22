using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardsResponse']"
	[Register ("com/amazon/ags/api/leaderboards/GetLeaderboardsResponse", "", "Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponseInvoker")]
	public partial interface IGetLeaderboardsResponse : global::Com.Amazon.Ags.Api.IRequestResponse {

		global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> Leaderboards {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardsResponse']/method[@name='getLeaderboards' and count(parameter)=0]"
			[Register ("getLeaderboards", "()Ljava/util/List;", "GetGetLeaderboardsHandler:Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponseInvoker, GameCircle.MonoDroid")] get;
		}

		int NumLeaderboards {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='GetLeaderboardsResponse']/method[@name='getNumLeaderboards' and count(parameter)=0]"
			[Register ("getNumLeaderboards", "()I", "GetGetNumLeaderboardsHandler:Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponseInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/GetLeaderboardsResponse", DoNotGenerateAcw=true)]
	internal class IGetLeaderboardsResponseInvoker : global::Java.Lang.Object, IGetLeaderboardsResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/GetLeaderboardsResponse");
		IntPtr class_ref;

		public static IGetLeaderboardsResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetLeaderboardsResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.GetLeaderboardsResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetLeaderboardsResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGetLeaderboardsResponseInvoker); }
		}

		static Delegate cb_getLeaderboards;
#pragma warning disable 0169
		static Delegate GetGetLeaderboardsHandler ()
		{
			if (cb_getLeaderboards == null)
				cb_getLeaderboards = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeaderboards);
			return cb_getLeaderboards;
		}

		static IntPtr n_GetLeaderboards (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard>.ToLocalJniHandle (__this.Leaderboards);
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboards;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> Leaderboards {
			get {
				if (id_getLeaderboards == IntPtr.Zero)
					id_getLeaderboards = JNIEnv.GetMethodID (class_ref, "getLeaderboards", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLeaderboards), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumLeaderboards;
#pragma warning disable 0169
		static Delegate GetGetNumLeaderboardsHandler ()
		{
			if (cb_getNumLeaderboards == null)
				cb_getNumLeaderboards = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumLeaderboards);
			return cb_getNumLeaderboards;
		}

		static int n_GetNumLeaderboards (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumLeaderboards;
		}
#pragma warning restore 0169

		IntPtr id_getNumLeaderboards;
		public int NumLeaderboards {
			get {
				if (id_getNumLeaderboards == IntPtr.Zero)
					id_getNumLeaderboards = JNIEnv.GetMethodID (class_ref, "getNumLeaderboards", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getNumLeaderboards);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
