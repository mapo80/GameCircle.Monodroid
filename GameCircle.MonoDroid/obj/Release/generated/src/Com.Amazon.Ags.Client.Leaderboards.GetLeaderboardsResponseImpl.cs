using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Leaderboards {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/leaderboards/GetLeaderboardsResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetLeaderboardsResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Leaderboards.IGetLeaderboardsResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/leaderboards/GetLeaderboardsResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetLeaderboardsResponseImpl); }
		}

		protected GetLeaderboardsResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/constructor[@name='GetLeaderboardsResponseImpl' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;I)V", "")]
		public GetLeaderboardsResponseImpl (global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (GetLeaderboardsResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;I)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;I)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_I == IntPtr.Zero)
				id_ctor_Ljava_util_List_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/constructor[@name='GetLeaderboardsResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetLeaderboardsResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetLeaderboardsResponseImpl)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_getLeaderboards;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard> Leaderboards {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/method[@name='getLeaderboards' and count(parameter)=0]"
			[Register ("getLeaderboards", "()Ljava/util/List;", "GetGetLeaderboardsHandler")]
			get {
				if (id_getLeaderboards == IntPtr.Zero)
					id_getLeaderboards = JNIEnv.GetMethodID (class_ref, "getLeaderboards", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Leaderboards.ILeaderboard>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLeaderboards), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getNumLeaderboards;
		public int NumLeaderboards {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/method[@name='getNumLeaderboards' and count(parameter)=0]"
			[Register ("getNumLeaderboards", "()I", "GetGetNumLeaderboardsHandler")]
			get {
				if (id_getNumLeaderboards == IntPtr.Zero)
					id_getNumLeaderboards = JNIEnv.GetMethodID (class_ref, "getNumLeaderboards", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNumLeaderboards);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.leaderboards']/class[@name='GetLeaderboardsResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
