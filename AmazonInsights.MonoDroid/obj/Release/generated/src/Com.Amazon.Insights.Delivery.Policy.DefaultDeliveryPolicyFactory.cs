using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='DefaultDeliveryPolicyFactory']"
	[global::Android.Runtime.Register ("com/amazon/insights/delivery/policy/DefaultDeliveryPolicyFactory", DoNotGenerateAcw=true)]
	public partial class DefaultDeliveryPolicyFactory : global::Java.Lang.Object, global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/delivery/policy/DefaultDeliveryPolicyFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultDeliveryPolicyFactory); }
		}

		protected DefaultDeliveryPolicyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='DefaultDeliveryPolicyFactory']/constructor[@name='DefaultDeliveryPolicyFactory' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;Z)V", "")]
		public DefaultDeliveryPolicyFactory (global::Com.Amazon.Insights.Core.IInsightsContext p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultDeliveryPolicyFactory)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;Z)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;Z)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_Z == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Z, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_Z, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_newBackgroundSubmissionTimePolicy;
#pragma warning disable 0169
		static Delegate GetNewBackgroundSubmissionTimePolicyHandler ()
		{
			if (cb_newBackgroundSubmissionTimePolicy == null)
				cb_newBackgroundSubmissionTimePolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewBackgroundSubmissionTimePolicy);
			return cb_newBackgroundSubmissionTimePolicy;
		}

		static IntPtr n_NewBackgroundSubmissionTimePolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBackgroundSubmissionTimePolicy ());
		}
#pragma warning restore 0169

		static IntPtr id_newBackgroundSubmissionTimePolicy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='DefaultDeliveryPolicyFactory']/method[@name='newBackgroundSubmissionTimePolicy' and count(parameter)=0]"
		[Register ("newBackgroundSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewBackgroundSubmissionTimePolicyHandler")]
		public virtual global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewBackgroundSubmissionTimePolicy ()
		{
			if (id_newBackgroundSubmissionTimePolicy == IntPtr.Zero)
				id_newBackgroundSubmissionTimePolicy = JNIEnv.GetMethodID (class_ref, "newBackgroundSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod  (Handle, id_newBackgroundSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newBackgroundSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_newConnectivityPolicy;
#pragma warning disable 0169
		static Delegate GetNewConnectivityPolicyHandler ()
		{
			if (cb_newConnectivityPolicy == null)
				cb_newConnectivityPolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewConnectivityPolicy);
			return cb_newConnectivityPolicy;
		}

		static IntPtr n_NewConnectivityPolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewConnectivityPolicy ());
		}
#pragma warning restore 0169

		static IntPtr id_newConnectivityPolicy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='DefaultDeliveryPolicyFactory']/method[@name='newConnectivityPolicy' and count(parameter)=0]"
		[Register ("newConnectivityPolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewConnectivityPolicyHandler")]
		public virtual global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewConnectivityPolicy ()
		{
			if (id_newConnectivityPolicy == IntPtr.Zero)
				id_newConnectivityPolicy = JNIEnv.GetMethodID (class_ref, "newConnectivityPolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod  (Handle, id_newConnectivityPolicy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newConnectivityPolicy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_newForceSubmissionTimePolicy;
#pragma warning disable 0169
		static Delegate GetNewForceSubmissionTimePolicyHandler ()
		{
			if (cb_newForceSubmissionTimePolicy == null)
				cb_newForceSubmissionTimePolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewForceSubmissionTimePolicy);
			return cb_newForceSubmissionTimePolicy;
		}

		static IntPtr n_NewForceSubmissionTimePolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.DefaultDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewForceSubmissionTimePolicy ());
		}
#pragma warning restore 0169

		static IntPtr id_newForceSubmissionTimePolicy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='DefaultDeliveryPolicyFactory']/method[@name='newForceSubmissionTimePolicy' and count(parameter)=0]"
		[Register ("newForceSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewForceSubmissionTimePolicyHandler")]
		public virtual global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewForceSubmissionTimePolicy ()
		{
			if (id_newForceSubmissionTimePolicy == IntPtr.Zero)
				id_newForceSubmissionTimePolicy = JNIEnv.GetMethodID (class_ref, "newForceSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod  (Handle, id_newForceSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newForceSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
		}

	}
}
