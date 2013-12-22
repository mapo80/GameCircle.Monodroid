using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/leaderboards/AGLeaderboards", DoNotGenerateAcw=true)]
	public partial class AGLeaderboards : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/leaderboards/AGLeaderboards", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGLeaderboards); }
		}

		protected AGLeaderboards (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLeaderboards_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getLeaderboards' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getLeaderboards", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetLeaderboards (global::Com.Amazon.Ags.Api.IAGResponseCallback p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getLeaderboards_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLeaderboards_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLeaderboards", "(Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLeaderboards_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getLeaderboards_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getLeaderboards' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetLeaderboards (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLeaderboards_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLeaderboards_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLeaderboards_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getLocalPlayerScore' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetLocalPlayerScore (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, global::Com.Amazon.Ags.Api.IAGResponseCallback p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getLocalPlayerScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerScore (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getPercentileRanks' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetPercentileRanks (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, global::Com.Amazon.Ags.Api.IAGResponseCallback p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getPercentileRanks' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetPercentileRanks (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getScores' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void GetScores (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, global::Com.Amazon.Ags.Api.IAGResponseCallback p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;Lcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_Lcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='getScores' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle GetScores (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_showLeaderboardOverlay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='showLeaderboardOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='showLeaderboardsOverlay' and count(parameter)=0]"
		[Register ("showLeaderboardsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay ()
		{
			if (id_showLeaderboardsOverlay == IntPtr.Zero)
				id_showLeaderboardsOverlay = JNIEnv.GetStaticMethodID (class_ref, "showLeaderboardsOverlay", "()Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showLeaderboardsOverlay), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_submitScore_Ljava_lang_String_JLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='submitScore' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.amazon.ags.api.AGResponseCallback'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("submitScore", "(Ljava/lang/String;JLcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V", "")]
		public static void SubmitScore (string p0, long p1, global::Com.Amazon.Ags.Api.IAGResponseCallback p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_submitScore_Ljava_lang_String_JLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_submitScore_Ljava_lang_String_JLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "submitScore", "(Ljava/lang/String;JLcom/amazon/ags/api/AGResponseCallback;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_submitScore_Ljava_lang_String_JLcom_amazon_ags_api_AGResponseCallback_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.leaderboards']/class[@name='AGLeaderboards']/method[@name='submitScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle SubmitScore (string p0, long p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ == IntPtr.Zero)
				id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}
