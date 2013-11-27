using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery.Policy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicyFactory']"
	[Register ("com/amazon/insights/delivery/policy/DeliveryPolicyFactory", "", "Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactoryInvoker")]
	public partial interface IDeliveryPolicyFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicyFactory']/method[@name='newBackgroundSubmissionTimePolicy' and count(parameter)=0]"
		[Register ("newBackgroundSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewBackgroundSubmissionTimePolicyHandler:Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactoryInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewBackgroundSubmissionTimePolicy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicyFactory']/method[@name='newConnectivityPolicy' and count(parameter)=0]"
		[Register ("newConnectivityPolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewConnectivityPolicyHandler:Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactoryInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewConnectivityPolicy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicyFactory']/method[@name='newForceSubmissionTimePolicy' and count(parameter)=0]"
		[Register ("newForceSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;", "GetNewForceSubmissionTimePolicyHandler:Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactoryInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewForceSubmissionTimePolicy ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/delivery/policy/DeliveryPolicyFactory", DoNotGenerateAcw=true)]
	internal class IDeliveryPolicyFactoryInvoker : global::Java.Lang.Object, IDeliveryPolicyFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/delivery/policy/DeliveryPolicyFactory");
		IntPtr class_ref;

		public static IDeliveryPolicyFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeliveryPolicyFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.delivery.policy.DeliveryPolicyFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeliveryPolicyFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeliveryPolicyFactoryInvoker); }
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
			global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBackgroundSubmissionTimePolicy ());
		}
#pragma warning restore 0169

		IntPtr id_newBackgroundSubmissionTimePolicy;
		public global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewBackgroundSubmissionTimePolicy ()
		{
			if (id_newBackgroundSubmissionTimePolicy == IntPtr.Zero)
				id_newBackgroundSubmissionTimePolicy = JNIEnv.GetMethodID (class_ref, "newBackgroundSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod (Handle, id_newBackgroundSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewConnectivityPolicy ());
		}
#pragma warning restore 0169

		IntPtr id_newConnectivityPolicy;
		public global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewConnectivityPolicy ()
		{
			if (id_newConnectivityPolicy == IntPtr.Zero)
				id_newConnectivityPolicy = JNIEnv.GetMethodID (class_ref, "newConnectivityPolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod (Handle, id_newConnectivityPolicy), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewForceSubmissionTimePolicy ());
		}
#pragma warning restore 0169

		IntPtr id_newForceSubmissionTimePolicy;
		public global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy NewForceSubmissionTimePolicy ()
		{
			if (id_newForceSubmissionTimePolicy == IntPtr.Zero)
				id_newForceSubmissionTimePolicy = JNIEnv.GetMethodID (class_ref, "newForceSubmissionTimePolicy", "()Lcom/amazon/insights/delivery/policy/DeliveryPolicy;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (JNIEnv.CallObjectMethod (Handle, id_newForceSubmissionTimePolicy), JniHandleOwnership.TransferLocalRef);
		}

	}

}
