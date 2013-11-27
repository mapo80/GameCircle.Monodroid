using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']"
	[Register ("com/amazon/ags/api/leaderboards/LeaderboardsClient", "", "Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker")]
	public partial interface ILeaderboardsClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='getLeaderboards' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLeaderboards_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetLeaderboards (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='getLocalPlayerScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerScore (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='getPercentileRanks' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetPercentileRanks (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='getScores' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetScores (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='showLeaderboardOverlay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardOverlay (string p0, params global:: Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='showLeaderboardsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardsOverlay_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/interface[@name='LeaderboardsClient']/method[@name='submitScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetSubmitScore_Ljava_lang_String_JarrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle SubmitScore (string p0, long p1, params global:: Java.Lang.Object[] p2);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/LeaderboardsClient", DoNotGenerateAcw=true)]
	internal class ILeaderboardsClientInvoker : global::Java.Lang.Object, ILeaderboardsClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/LeaderboardsClient");
		IntPtr class_ref;

		public static ILeaderboardsClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILeaderboardsClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.leaderboards.LeaderboardsClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILeaderboardsClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILeaderboardsClientInvoker); }
		}

		static Delegate cb_getLeaderboards_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetLeaderboards_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getLeaderboards_arrayLjava_lang_Object_ == null)
				cb_getLeaderboards_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLeaderboards_arrayLjava_lang_Object_);
			return cb_getLeaderboards_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetLeaderboards_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLeaderboards (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLeaderboards_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetLeaderboards (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLeaderboards_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLeaderboards_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getLeaderboards_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == null)
				cb_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_);
			return cb_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalPlayerScore (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerScore (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == null)
				cb_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_);
			return cb_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPercentileRanks (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetPercentileRanks (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == null)
				cb_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_);
			return cb_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetScores (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetScores (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardOverlay (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardOverlay (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_showLeaderboardsOverlay_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowLeaderboardsOverlay_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showLeaderboardsOverlay_arrayLjava_lang_Object_ == null)
				cb_showLeaderboardsOverlay_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowLeaderboardsOverlay_arrayLjava_lang_Object_);
			return cb_showLeaderboardsOverlay_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowLeaderboardsOverlay_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showLeaderboardsOverlay_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay (params global:: Java.Lang.Object[] p0)
		{
			if (id_showLeaderboardsOverlay_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardsOverlay_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_showLeaderboardsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSubmitScore_Ljava_lang_String_JarrayLjava_lang_Object_Handler ()
		{
			if (cb_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ == null)
				cb_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_SubmitScore_Ljava_lang_String_JarrayLjava_lang_Object_);
			return cb_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_;
		}

		static IntPtr n_SubmitScore_Ljava_lang_String_JarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubmitScore (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle SubmitScore (string p0, long p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ == IntPtr.Zero)
				id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}

}
