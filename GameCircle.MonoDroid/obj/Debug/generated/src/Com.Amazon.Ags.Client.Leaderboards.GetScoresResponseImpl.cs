using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/GetScoresResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetScoresResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Leaderboards.IGetScoresResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/GetScoresResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetScoresResponseImpl); }
		}

		protected GetScoresResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_amazon_ags_api_leaderboards_Score_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/constructor[@name='GetScoresResponseImpl' and count(parameter)=6 and parameter[1][@type='com.amazon.ags.api.leaderboards.Score[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amazon.ags.constants.ScoreFormat'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register (".ctor", "([Lcom/amazon/ags/api/leaderboards/Score;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public GetScoresResponseImpl (global::Com.Amazon.Ags.Api.Leaderboards.IScore[] p0, string p1, global::Com.Amazon.Ags.Constants.ScoreFormat p2, string p3, string p4, int p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			IntPtr native_p4 = JNIEnv.NewString (p4);;
			if (GetType () != typeof (GetScoresResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/amazon/ags/api/leaderboards/Score;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;Ljava/lang/String;I)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/amazon/ags/api/leaderboards/Score;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;Ljava/lang/String;I)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				return;
			}

			if (id_ctor_arrayLcom_amazon_ags_api_leaderboards_Score_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_arrayLcom_amazon_ags_api_leaderboards_Score_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/amazon/ags/api/leaderboards/Score;Ljava/lang/String;Lcom/amazon/ags/constants/ScoreFormat;Ljava/lang/String;Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_amazon_ags_api_leaderboards_Score_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_amazon_ags_api_leaderboards_Score_Ljava_lang_String_Lcom_amazon_ags_constants_ScoreFormat_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/constructor[@name='GetScoresResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetScoresResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetScoresResponseImpl)) {
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

		static IntPtr id_getDisplayText;
		public string DisplayText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getDisplayText' and count(parameter)=0]"
			[Register ("getDisplayText", "()Ljava/lang/String;", "GetGetDisplayTextHandler")]
			get {
				if (id_getDisplayText == IntPtr.Zero)
					id_getDisplayText = JNIEnv.GetMethodID (class_ref, "getDisplayText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayText), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventType;
		public override int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_getLeaderboardId;
		public string LeaderboardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getLeaderboardId' and count(parameter)=0]"
			[Register ("getLeaderboardId", "()Ljava/lang/String;", "GetGetLeaderboardIdHandler")]
			get {
				if (id_getLeaderboardId == IntPtr.Zero)
					id_getLeaderboardId = JNIEnv.GetMethodID (class_ref, "getLeaderboardId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLeaderboardName;
		public string LeaderboardName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getLeaderboardName' and count(parameter)=0]"
			[Register ("getLeaderboardName", "()Ljava/lang/String;", "GetGetLeaderboardNameHandler")]
			get {
				if (id_getLeaderboardName == IntPtr.Zero)
					id_getLeaderboardName = JNIEnv.GetMethodID (class_ref, "getLeaderboardName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboardName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getNumScores;
		public int NumScores {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getNumScores' and count(parameter)=0]"
			[Register ("getNumScores", "()I", "GetGetNumScoresHandler")]
			get {
				if (id_getNumScores == IntPtr.Zero)
					id_getNumScores = JNIEnv.GetMethodID (class_ref, "getNumScores", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNumScores);
			}
		}

		static IntPtr id_getScoreFormat;
		public global::Com.Amazon.Ags.Constants.ScoreFormat ScoreFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getScoreFormat' and count(parameter)=0]"
			[Register ("getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;", "GetGetScoreFormatHandler")]
			get {
				if (id_getScoreFormat == IntPtr.Zero)
					id_getScoreFormat = JNIEnv.GetMethodID (class_ref, "getScoreFormat", "()Lcom/amazon/ags/constants/ScoreFormat;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.ScoreFormat> (JNIEnv.CallObjectMethod  (Handle, id_getScoreFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getScores;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.IScore> Scores {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='getScores' and count(parameter)=0]"
			[Register ("getScores", "()Ljava/util/List;", "GetGetScoresHandler")]
			get {
				if (id_getScores == IntPtr.Zero)
					id_getScores = JNIEnv.GetMethodID (class_ref, "getScores", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.IScore>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getScores), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetScoresResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
