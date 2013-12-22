using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/leaderboards/LeaderboardsJni", DoNotGenerateAcw=true)]
	public partial class LeaderboardsJni : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/leaderboards/LeaderboardsJni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardsJni); }
		}

		protected LeaderboardsJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/constructor[@name='LeaderboardsJni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LeaderboardsJni () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LeaderboardsJni)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_getLeaderboardsResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getLeaderboardsResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getLeaderboardsResponseFailure", "(JII)V", "")]
		public static void GetLeaderboardsResponseFailure (long p0, int p1, int p2)
		{
			if (id_getLeaderboardsResponseFailure_JII == IntPtr.Zero)
				id_getLeaderboardsResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getLeaderboardsResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLeaderboardsResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getLeaderboardsResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardsResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getLeaderboardsResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.leaderboards.GetLeaderboardsResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getLeaderboardsResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetLeaderboardsResponse;JI)V", "")]
		public static void GetLeaderboardsResponseSuccess (global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse p0, long p1, int p2)
		{
			if (id_getLeaderboardsResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardsResponse_JI == IntPtr.Zero)
				id_getLeaderboardsResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardsResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getLeaderboardsResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetLeaderboardsResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLeaderboardsResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardsResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getPercentilesResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getPercentilesResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPercentilesResponseFailure", "(JII)V", "")]
		public static void GetPercentilesResponseFailure (long p0, int p1, int p2)
		{
			if (id_getPercentilesResponseFailure_JII == IntPtr.Zero)
				id_getPercentilesResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getPercentilesResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPercentilesResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getPercentilesResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardPercentilesResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getPercentilesResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.leaderboards.GetLeaderboardPercentilesResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getPercentilesResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetLeaderboardPercentilesResponse;JI)V", "")]
		public static void GetPercentilesResponseSuccess (global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardPercentilesResponse p0, long p1, int p2)
		{
			if (id_getPercentilesResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardPercentilesResponse_JI == IntPtr.Zero)
				id_getPercentilesResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardPercentilesResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getPercentilesResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetLeaderboardPercentilesResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPercentilesResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetLeaderboardPercentilesResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getPlayerScoreResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getPlayerScoreResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPlayerScoreResponseFailure", "(JII)V", "")]
		public static void GetPlayerScoreResponseFailure (long p0, int p1, int p2)
		{
			if (id_getPlayerScoreResponseFailure_JII == IntPtr.Zero)
				id_getPlayerScoreResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getPlayerScoreResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPlayerScoreResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getPlayerScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getPlayerScoreResponseSuccess' and count(parameter)=4 and parameter[1][@type='com.amazon.ags.api.leaderboards.GetPlayerScoreResponse'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register ("getPlayerScoreResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetPlayerScoreResponse;Ljava/lang/String;JI)V", "")]
		public static void GetPlayerScoreResponseSuccess (global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse p0, string p1, long p2, int p3)
		{
			if (id_getPlayerScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Ljava_lang_String_JI == IntPtr.Zero)
				id_getPlayerScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Ljava_lang_String_JI = JNIEnv.GetStaticMethodID (class_ref, "getPlayerScoreResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetPlayerScoreResponse;Ljava/lang/String;JI)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPlayerScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetPlayerScoreResponse_Ljava_lang_String_JI, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_getScoresResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getScoresResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getScoresResponseFailure", "(JII)V", "")]
		public static void GetScoresResponseFailure (long p0, int p1, int p2)
		{
			if (id_getScoresResponseFailure_JII == IntPtr.Zero)
				id_getScoresResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "getScoresResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getScoresResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getScoresResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetScoresResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='getScoresResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.leaderboards.GetScoresResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getScoresResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetScoresResponse;JI)V", "")]
		public static void GetScoresResponseSuccess (global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse p0, long p1, int p2)
		{
			if (id_getScoresResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetScoresResponse_JI == IntPtr.Zero)
				id_getScoresResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetScoresResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "getScoresResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/GetScoresResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getScoresResponseSuccess_Lcom_amazon_ags_api_leaderboards_GetScoresResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_submitScoreResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='submitScoreResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("submitScoreResponseFailure", "(JII)V", "")]
		public static void SubmitScoreResponseFailure (long p0, int p1, int p2)
		{
			if (id_submitScoreResponseFailure_JII == IntPtr.Zero)
				id_submitScoreResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "submitScoreResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_submitScoreResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_submitScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_SubmitScoreResponse_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsJni']/method[@name='submitScoreResponseSuccess' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.api.leaderboards.SubmitScoreResponse'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("submitScoreResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/SubmitScoreResponse;JI)V", "")]
		public static void SubmitScoreResponseSuccess (global::Com.Amazon.Ags.Api.Leaderboards.ISubmitScoreResponse p0, long p1, int p2)
		{
			if (id_submitScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_SubmitScoreResponse_JI == IntPtr.Zero)
				id_submitScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_SubmitScoreResponse_JI = JNIEnv.GetStaticMethodID (class_ref, "submitScoreResponseSuccess", "(Lcom/amazon/ags/api/leaderboards/SubmitScoreResponse;JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_submitScoreResponseSuccess_Lcom_amazon_ags_api_leaderboards_SubmitScoreResponse_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
