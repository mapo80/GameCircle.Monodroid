using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/GetLeaderboardPercentilesResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetLeaderboardPercentilesResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/GetLeaderboardPercentilesResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetLeaderboardPercentilesResponseImpl); }
		}

		protected GetLeaderboardPercentilesResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_api_leaderboards_Leaderboard_Ljava_util_List_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']/constructor[@name='GetLeaderboardPercentilesResponseImpl' and count(parameter)=4 and parameter[1][@type='com.amazon.ags.api.leaderboards.Leaderboard'] and parameter[2][@type='java.util.List'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/amazon/ags/api/leaderboards/Leaderboard;Ljava/util/List;II)V", "")]
		public GetLeaderboardPercentilesResponseImpl (global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard p0, global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (GetLeaderboardPercentilesResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/api/leaderboards/Leaderboard;Ljava/util/List;II)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/api/leaderboards/Leaderboard;Ljava/util/List;II)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_amazon_ags_api_leaderboards_Leaderboard_Ljava_util_List_II == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_api_leaderboards_Leaderboard_Ljava_util_List_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/api/leaderboards/Leaderboard;Ljava/util/List;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_api_leaderboards_Leaderboard_Ljava_util_List_II, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_api_leaderboards_Leaderboard_Ljava_util_List_II, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']/constructor[@name='GetLeaderboardPercentilesResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetLeaderboardPercentilesResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetLeaderboardPercentilesResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILcom_amazon_ags_api_ErrorCode_ == IntPtr.Zero)
				id_ctor_ILcom_amazon_ags_api_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/amazon/ags/api/ErrorCode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Leaderboard);
		}
#pragma warning restore 0169

		static IntPtr id_getLeaderboard;
		public virtual global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard Leaderboard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']/method[@name='getLeaderboard' and count(parameter)=0]"
			[Register ("getLeaderboard", "()Lcom/amazon/ags/api/leaderboards/Leaderboard;", "GetGetLeaderboardHandler")]
			get {
				if (id_getLeaderboard == IntPtr.Zero)
					id_getLeaderboard = JNIEnv.GetMethodID (class_ref, "getLeaderboard", "()Lcom/amazon/ags/api/leaderboards/Leaderboard;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboard), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLeaderboard), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.ToLocalJniHandle (__this.PercentileList);
		}
#pragma warning restore 0169

		static IntPtr id_getPercentileList;
		public virtual global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem> PercentileList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']/method[@name='getPercentileList' and count(parameter)=0]"
			[Register ("getPercentileList", "()Ljava/util/List;", "GetGetPercentileListHandler")]
			get {
				if (id_getPercentileList == IntPtr.Zero)
					id_getPercentileList = JNIEnv.GetMethodID (class_ref, "getPercentileList", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPercentileList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardPercentileItem>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPercentileList), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.GetLeaderboardPercentilesResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getUserIndex;
		public virtual int UserIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardPercentilesResponseImpl']/method[@name='getUserIndex' and count(parameter)=0]"
			[Register ("getUserIndex", "()I", "GetGetUserIndexHandler")]
			get {
				if (id_getUserIndex == IntPtr.Zero)
					id_getUserIndex = JNIEnv.GetMethodID (class_ref, "getUserIndex", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUserIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getUserIndex);
			}
		}

	}
}
