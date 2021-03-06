using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/achievements/GetAchievementsResponseImpl", DoNotGenerateAcw=true)]
	public partial class GetAchievementsResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Achievements.IGetAchievementsResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/achievements/GetAchievementsResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAchievementsResponseImpl); }
		}

		protected GetAchievementsResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/constructor[@name='GetAchievementsResponseImpl' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;I)V", "")]
		public GetAchievementsResponseImpl (global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Achievements.IAchievement> p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Achievements.IAchievement>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (GetAchievementsResponseImpl)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/constructor[@name='GetAchievementsResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public GetAchievementsResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GetAchievementsResponseImpl)) {
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

		static IntPtr id_getAchievementsList;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Api.Achievements.IAchievement> AchievementsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/method[@name='getAchievementsList' and count(parameter)=0]"
			[Register ("getAchievementsList", "()Ljava/util/List;", "GetGetAchievementsListHandler")]
			get {
				if (id_getAchievementsList == IntPtr.Zero)
					id_getAchievementsList = JNIEnv.GetMethodID (class_ref, "getAchievementsList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Api.Achievements.IAchievement>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAchievementsList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAchievementsMap;
		public global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Ags.Api.Achievements.IAchievement> AchievementsMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/method[@name='getAchievementsMap' and count(parameter)=0]"
			[Register ("getAchievementsMap", "()Ljava/util/Map;", "GetGetAchievementsMapHandler")]
			get {
				if (id_getAchievementsMap == IntPtr.Zero)
					id_getAchievementsMap = JNIEnv.GetMethodID (class_ref, "getAchievementsMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Ags.Api.Achievements.IAchievement>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAchievementsMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getEventType;
		public override int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
		}

		static IntPtr id_getNumVisibleAchievements;
		public int NumVisibleAchievements {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/method[@name='getNumVisibleAchievements' and count(parameter)=0]"
			[Register ("getNumVisibleAchievements", "()I", "GetGetNumVisibleAchievementsHandler")]
			get {
				if (id_getNumVisibleAchievements == IntPtr.Zero)
					id_getNumVisibleAchievements = JNIEnv.GetMethodID (class_ref, "getNumVisibleAchievements", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getNumVisibleAchievements);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='GetAchievementsResponseImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
