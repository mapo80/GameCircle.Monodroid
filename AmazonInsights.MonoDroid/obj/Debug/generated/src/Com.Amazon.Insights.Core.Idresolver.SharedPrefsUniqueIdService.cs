using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Idresolver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/idresolver/SharedPrefsUniqueIdService", DoNotGenerateAcw=true)]
	public partial class SharedPrefsUniqueIdService : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdService {


		static IntPtr PREFS_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']/field[@name='PREFS_NAME']"
		[Register ("PREFS_NAME")]
		protected static string PrefsName {
			get {
				if (PREFS_NAME_jfieldId == IntPtr.Zero)
					PREFS_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFS_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREFS_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PREFS_NAME_jfieldId == IntPtr.Zero)
					PREFS_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFS_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, PREFS_NAME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']/field[@name='UNIQUE_ID_KEY']"
		[Register ("UNIQUE_ID_KEY")]
		protected const string UniqueIdKey = (string) "UniqueId";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/idresolver/SharedPrefsUniqueIdService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPrefsUniqueIdService); }
		}

		protected SharedPrefsUniqueIdService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_idresolver_UniqueIdGenerator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']/constructor[@name='SharedPrefsUniqueIdService' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.idresolver.UniqueIdGenerator']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/idresolver/UniqueIdGenerator;)V", "")]
		public SharedPrefsUniqueIdService (global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdGenerator p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SharedPrefsUniqueIdService)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/idresolver/UniqueIdGenerator;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/idresolver/UniqueIdGenerator;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_idresolver_UniqueIdGenerator_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_idresolver_UniqueIdGenerator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/idresolver/UniqueIdGenerator;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_idresolver_UniqueIdGenerator_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_idresolver_UniqueIdGenerator_, new JValue (p0));
		}

		static Delegate cb_getUniqueId_Lcom_amazon_insights_core_InsightsContext_;
#pragma warning disable 0169
		static Delegate GetGetUniqueId_Lcom_amazon_insights_core_InsightsContext_Handler ()
		{
			if (cb_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ == null)
				cb_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUniqueId_Lcom_amazon_insights_core_InsightsContext_);
			return cb_getUniqueId_Lcom_amazon_insights_core_InsightsContext_;
		}

		static IntPtr n_GetUniqueId_Lcom_amazon_insights_core_InsightsContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Idresolver.SharedPrefsUniqueIdService __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.SharedPrefsUniqueIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.IInsightsContext p0 = (global::Com.Amazon.Insights.Core.IInsightsContext)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUniqueId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']/method[@name='getUniqueId' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("getUniqueId", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueId_Lcom_amazon_insights_core_InsightsContext_Handler")]
		public virtual global::Com.Amazon.Insights.Core.Idresolver.Id GetUniqueId (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "getUniqueId", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/core/idresolver/Id;");

			global::Com.Amazon.Insights.Core.Idresolver.Id __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='SharedPrefsUniqueIdService']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/amazon/insights/core/idresolver/UniqueIdService;", "")]
		public static global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdService NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/amazon/insights/core/idresolver/UniqueIdService;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
