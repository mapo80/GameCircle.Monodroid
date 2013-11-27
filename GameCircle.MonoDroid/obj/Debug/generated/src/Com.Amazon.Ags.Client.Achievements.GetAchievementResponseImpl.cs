using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/achievements/GetAchievementResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetAchievementResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Achievements.IGetAchievementResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/achievements/GetAchievementResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAchievementResponseImpl); }
		}

		protected GetAchievementResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_api_achievements_Achievement_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']/constructor[@name='GetAchievementResponseImpl' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.achievements.Achievement'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/amazon/ags/api/achievements/Achievement;I)V", "")]
		public GetAchievementResponseImpl (global::Com.Amazon.Ags.Api.Achievements.IAchievement p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetAchievementResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/api/achievements/Achievement;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/api/achievements/Achievement;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_api_achievements_Achievement_I == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_api_achievements_Achievement_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/api/achievements/Achievement;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_api_achievements_Achievement_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_api_achievements_Achievement_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']/constructor[@name='GetAchievementResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetAchievementResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetAchievementResponseImpl)) {
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

		static IntPtr id_getAchievement;
		public global::Com.Amazon.Ags.Api.Achievements.IAchievement Achievement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']/method[@name='getAchievement' and count(parameter)=0]"
			[Register ("getAchievement", "()Lcom/amazon/ags/api/achievements/Achievement;", "GetGetAchievementHandler")]
			get {
				if (id_getAchievement == IntPtr.Zero)
					id_getAchievement = JNIEnv.GetMethodID (class_ref, "getAchievement", "()Lcom/amazon/ags/api/achievements/Achievement;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (JNIEnv.CallObjectMethod  (Handle, id_getAchievement), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventType;
		public override int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
