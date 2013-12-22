using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/LeaderboardsClientImpl", DoNotGenerateAcw=true)]
	public partial class LeaderboardsClientImpl : global::Com.Amazon.Ags.Client.ClientBase, global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboardsClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/LeaderboardsClientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeaderboardsClientImpl); }
		}

		protected LeaderboardsClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/constructor[@name='LeaderboardsClientImpl' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper'] and parameter[2][@type='com.amazon.ags.client.OverlayClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", "")]
		public LeaderboardsClientImpl (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0, global::Com.Amazon.Ags.Client.OverlayClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LeaderboardsClientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/client/OverlayClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/constructor[@name='LeaderboardsClientImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LeaderboardsClientImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LeaderboardsClientImpl)) {
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLeaderboards (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLeaderboards_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='getLeaderboards' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLeaderboards_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetLeaderboards (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLeaderboards_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLeaderboards_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLeaderboards", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboards_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLeaderboards_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalPlayerScore (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='getLocalPlayerScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerScore (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLocalPlayerScore", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalPlayerScore_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPercentileRanks (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='getPercentileRanks' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetPercentileRanks (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getPercentileRanks", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPercentileRanks_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Constants.LeaderboardFilter p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.LeaderboardFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetScores (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='getScores' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.constants.LeaderboardFilter'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetScores (string p0, global::Com.Amazon.Ags.Constants.LeaderboardFilter p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getScores", "(Ljava/lang/String;Lcom/amazon/ags/constants/LeaderboardFilter;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getScores_Ljava_lang_String_Lcom_amazon_ags_constants_LeaderboardFilter_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
#pragma warning disable 0169
		static Delegate GetSetOverlayClient_Lcom_amazon_ags_client_OverlayClient_Handler ()
		{
			if (cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ == null)
				cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverlayClient_Lcom_amazon_ags_client_OverlayClient_);
			return cb_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
		}

		static void n_SetOverlayClient_Lcom_amazon_ags_client_OverlayClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.OverlayClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.OverlayClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='setOverlayClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.OverlayClient']]"
		[Register ("setOverlayClient", "(Lcom/amazon/ags/client/OverlayClient;)V", "GetSetOverlayClient_Lcom_amazon_ags_client_OverlayClient_Handler")]
		public virtual void SetOverlayClient (global::Com.Amazon.Ags.Client.OverlayClient p0)
		{
			if (id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ == IntPtr.Zero)
				id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_ = JNIEnv.GetMethodID (class_ref, "setOverlayClient", "(Lcom/amazon/ags/client/OverlayClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayClient_Lcom_amazon_ags_client_OverlayClient_, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardOverlay (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='showLeaderboardOverlay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardOverlay (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardOverlay", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showLeaderboardOverlay_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowLeaderboardsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_showLeaderboardsOverlay_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='showLeaderboardsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowLeaderboardsOverlay_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle ShowLeaderboardsOverlay (params global:: Java.Lang.Object[] p0)
		{
			if (id_showLeaderboardsOverlay_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showLeaderboardsOverlay_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showLeaderboardsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_showLeaderboardsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showLeaderboardsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shutdown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_shutdown);
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
			global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Leaderboards.LeaderboardsClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubmitScore (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='LeaderboardsClientImpl']/method[@name='submitScore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetSubmitScore_Ljava_lang_String_JarrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle SubmitScore (string p0, long p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ == IntPtr.Zero)
				id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "submitScore", "(Ljava/lang/String;J[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_submitScore_Ljava_lang_String_JarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}
