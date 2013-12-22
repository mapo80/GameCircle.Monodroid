using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/GetPlayerScoreResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetPlayerScoreResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Leaderboards.IGetPlayerScoreResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/GetPlayerScoreResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetPlayerScoreResponseImpl); }
		}

		protected GetPlayerScoreResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/constructor[@name='GetPlayerScoreResponseImpl' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(JII)V", "")]
		public GetPlayerScoreResponseImpl (long p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetPlayerScoreResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JII)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JII)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_JII == IntPtr.Zero)
				id_ctor_JII = JNIEnv.GetMethodID (class_ref, "<init>", "(JII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JII, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/constructor[@name='GetPlayerScoreResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetPlayerScoreResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetPlayerScoreResponseImpl)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_getRank;
		public int Rank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/method[@name='getRank' and count(parameter)=0]"
			[Register ("getRank", "()I", "GetGetRankHandler")]
			get {
				if (id_getRank == IntPtr.Zero)
					id_getRank = JNIEnv.GetMethodID (class_ref, "getRank", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRank);
			}
		}

		static IntPtr id_getScoreValue;
		public long ScoreValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/method[@name='getScoreValue' and count(parameter)=0]"
			[Register ("getScoreValue", "()J", "GetGetScoreValueHandler")]
			get {
				if (id_getScoreValue == IntPtr.Zero)
					id_getScoreValue = JNIEnv.GetMethodID (class_ref, "getScoreValue", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getScoreValue);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetPlayerScoreResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
