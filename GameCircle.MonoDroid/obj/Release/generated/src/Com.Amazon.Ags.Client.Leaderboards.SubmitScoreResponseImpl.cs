using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/SubmitScoreResponseImpl", DoNotGenerateAcw=true)]
	public partial class SubmitScoreResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/SubmitScoreResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitScoreResponseImpl); }
		}

		protected SubmitScoreResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_Ljava_util_Map_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/constructor[@name='SubmitScoreResponseImpl' and count(parameter)=3 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/util/Map;Ljava/util/Map;I)V", "")]
		public SubmitScoreResponseImpl (global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean> p0, global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer> p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean>.ToLocalJniHandle (p0);;
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (SubmitScoreResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;Ljava/util/Map;I)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;Ljava/util/Map;I)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_util_Map_Ljava_util_Map_I == IntPtr.Zero)
				id_ctor_Ljava_util_Map_Ljava_util_Map_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;Ljava/util/Map;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_Ljava_util_Map_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_Ljava_util_Map_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/constructor[@name='SubmitScoreResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public SubmitScoreResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SubmitScoreResponseImpl)) {
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

		static IntPtr id_getEventType;
		public override int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_getNewRank;
		public global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer> NewRank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/method[@name='getNewRank' and count(parameter)=0]"
			[Register ("getNewRank", "()Ljava/util/Map;", "GetGetNewRankHandler")]
			get {
				if (id_getNewRank == IntPtr.Zero)
					id_getNewRank = JNIEnv.GetMethodID (class_ref, "getNewRank", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNewRank), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRankImproved;
		public global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean> RankImproved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/method[@name='getRankImproved' and count(parameter)=0]"
			[Register ("getRankImproved", "()Ljava/util/Map;", "GetGetRankImprovedHandler")]
			get {
				if (id_getRankImproved == IntPtr.Zero)
					id_getRankImproved = JNIEnv.GetMethodID (class_ref, "getRankImproved", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Constants.LeaderboardFilter, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRankImproved), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='SubmitScoreResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
