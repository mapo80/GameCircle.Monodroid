using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/leaderboards/LeaderboardsNativeHandler", DoNotGenerateAcw=true)]
	public partial class LeaderboardsNativeHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/leaderboards/LeaderboardsNativeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardsNativeHandler); }
		}

		protected LeaderboardsNativeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/constructor[@name='LeaderboardsNativeHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LeaderboardsNativeHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LeaderboardsNativeHandler)) {
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

		static IntPtr id_getPercentiles_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='getPercentiles' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("getPercentiles", "(Ljava/lang/String;IIJ)V", "")]
		public static void GetPercentiles (string p0, int p1, int p2, long p3)
		{
			if (id_getPercentiles_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_getPercentiles_Ljava_lang_String_IIJ = JNIEnv.GetStaticMethodID (class_ref, "getPercentiles", "(Ljava/lang/String;IIJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPercentiles_Ljava_lang_String_IIJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getPercentilesHandle_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='getPercentilesHandle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPercentilesHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetPercentilesHandle (string p0, int p1, int p2)
		{
			if (id_getPercentilesHandle_Ljava_lang_String_II == IntPtr.Zero)
				id_getPercentilesHandle_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "getPercentilesHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPercentilesHandle_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='initializeNativeHandler' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGamesClient']]"
		[Register ("initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V", "")]
		public static void InitializeNativeHandler (global::Com.Amazon.Ags.Api.AmazonGamesClient p0)
		{
			if (id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ == IntPtr.Zero)
				id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_ = JNIEnv.GetStaticMethodID (class_ref, "initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGamesClient;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGamesClient_, new JValue (p0));
		}

		static IntPtr id_requestLeaderboards_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestLeaderboards' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("requestLeaderboards", "(IJ)V", "")]
		public static void RequestLeaderboards (int p0, long p1)
		{
			if (id_requestLeaderboards_IJ == IntPtr.Zero)
				id_requestLeaderboards_IJ = JNIEnv.GetStaticMethodID (class_ref, "requestLeaderboards", "(IJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestLeaderboards_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_requestLeaderboardsHandle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestLeaderboardsHandle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestLeaderboardsHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle RequestLeaderboardsHandle (int p0)
		{
			if (id_requestLeaderboardsHandle_I == IntPtr.Zero)
				id_requestLeaderboardsHandle_I = JNIEnv.GetStaticMethodID (class_ref, "requestLeaderboardsHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestLeaderboardsHandle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_requestLocalPlayerScore_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestLocalPlayerScore' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("requestLocalPlayerScore", "(Ljava/lang/String;IIJ)V", "")]
		public static void RequestLocalPlayerScore (string p0, int p1, int p2, long p3)
		{
			if (id_requestLocalPlayerScore_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_requestLocalPlayerScore_Ljava_lang_String_IIJ = JNIEnv.GetStaticMethodID (class_ref, "requestLocalPlayerScore", "(Ljava/lang/String;IIJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestLocalPlayerScore_Ljava_lang_String_IIJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_requestLocalPlayerScoreHandle_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestLocalPlayerScoreHandle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("requestLocalPlayerScoreHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle RequestLocalPlayerScoreHandle (string p0, int p1, int p2)
		{
			if (id_requestLocalPlayerScoreHandle_Ljava_lang_String_II == IntPtr.Zero)
				id_requestLocalPlayerScoreHandle_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "requestLocalPlayerScoreHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestLocalPlayerScoreHandle_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_requestScores_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestScores' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("requestScores", "(Ljava/lang/String;IIJ)V", "")]
		public static void RequestScores (string p0, int p1, int p2, long p3)
		{
			if (id_requestScores_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_requestScores_Ljava_lang_String_IIJ = JNIEnv.GetStaticMethodID (class_ref, "requestScores", "(Ljava/lang/String;IIJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestScores_Ljava_lang_String_IIJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_requestScoresHandle_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='requestScoresHandle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("requestScoresHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle RequestScoresHandle (string p0, int p1, int p2)
		{
			if (id_requestScoresHandle_Ljava_lang_String_II == IntPtr.Zero)
				id_requestScoresHandle_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "requestScoresHandle", "(Ljava/lang/String;II)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestScoresHandle_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_showLeaderboardOverlay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='showLeaderboardOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showLeaderboardOverlay", "(Ljava/lang/String;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardOverlay (string p0)
		{
			if (id_showLeaderboardOverlay_Ljava_lang_String_ == IntPtr.Zero)
				id_showLeaderboardOverlay_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showLeaderboardOverlay", "(Ljava/lang/String;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showLeaderboardOverlay_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_showLeaderboardsOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='showLeaderboardsOverlay' and count(parameter)=0]"
		[Register ("showLeaderboardsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay ()
		{
			if (id_showLeaderboardsOverlay == IntPtr.Zero)
				id_showLeaderboardsOverlay = JNIEnv.GetStaticMethodID (class_ref, "showLeaderboardsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showLeaderboardsOverlay), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_submitLeaderboardScore_Ljava_lang_String_JIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='submitLeaderboardScore' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("submitLeaderboardScore", "(Ljava/lang/String;JIJ)V", "")]
		public static void SubmitLeaderboardScore (string p0, long p1, int p2, long p3)
		{
			if (id_submitLeaderboardScore_Ljava_lang_String_JIJ == IntPtr.Zero)
				id_submitLeaderboardScore_Ljava_lang_String_JIJ = JNIEnv.GetStaticMethodID (class_ref, "submitLeaderboardScore", "(Ljava/lang/String;JIJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_submitLeaderboardScore_Ljava_lang_String_JIJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_submitLeaderboardScoreHandle_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.leaderboards']/class[@name='LeaderboardsNativeHandler']/method[@name='submitLeaderboardScoreHandle' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("submitLeaderboardScoreHandle", "(Ljava/lang/String;JI)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle SubmitLeaderboardScoreHandle (string p0, long p1, int p2)
		{
			if (id_submitLeaderboardScoreHandle_Ljava_lang_String_JI == IntPtr.Zero)
				id_submitLeaderboardScoreHandle_Ljava_lang_String_JI = JNIEnv.GetStaticMethodID (class_ref, "submitLeaderboardScoreHandle", "(Ljava/lang/String;JI)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_submitLeaderboardScoreHandle_Ljava_lang_String_JI, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
