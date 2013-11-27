using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Idresolver {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/interface[@name='UniqueIdService']"
	[Register ("com/amazon/insights/core/idresolver/UniqueIdService", "", "Com.Amazon.Insights.Core.Idresolver.IUniqueIdServiceInvoker")]
	public partial interface IUniqueIdService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/interface[@name='UniqueIdService']/method[@name='getUniqueId' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("getUniqueId", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueId_Lcom_amazon_insights_core_InsightsContext_Handler:Com.Amazon.Insights.Core.Idresolver.IUniqueIdServiceInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Core.Idresolver.Id GetUniqueId (global::Com.Amazon.Insights.Core.IInsightsContext p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/idresolver/UniqueIdService", DoNotGenerateAcw=true)]
	internal class IUniqueIdServiceInvoker : global::Java.Lang.Object, IUniqueIdService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/idresolver/UniqueIdService");
		IntPtr class_ref;

		public static IUniqueIdService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUniqueIdService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.idresolver.UniqueIdService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUniqueIdServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUniqueIdServiceInvoker); }
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
			global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdService __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.IInsightsContext p0 = (global::Com.Amazon.Insights.Core.IInsightsContext)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IInsightsContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUniqueId (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_;
		public global::Com.Amazon.Insights.Core.Idresolver.Id GetUniqueId (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "getUniqueId", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/core/idresolver/Id;");
			global::Com.Amazon.Insights.Core.Idresolver.Id __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod (Handle, id_getUniqueId_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
