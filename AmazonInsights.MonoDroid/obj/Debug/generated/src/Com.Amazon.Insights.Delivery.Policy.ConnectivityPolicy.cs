using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='ConnectivityPolicy']"
	[global::Android.Runtime.Register ("com/amazon/insights/delivery/policy/ConnectivityPolicy", DoNotGenerateAcw=true)]
	public partial class ConnectivityPolicy : global::Java.Lang.Object, global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/delivery/policy/ConnectivityPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectivityPolicy); }
		}

		protected ConnectivityPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='ConnectivityPolicy']/constructor[@name='ConnectivityPolicy' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;Z)V", "")]
		public ConnectivityPolicy (global::Com.Amazon.Insights.Core.IInsightsContext p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConnectivityPolicy)) {
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

		static Delegate cb_isAllowed;
#pragma warning disable 0169
		static Delegate GetIsAllowedHandler ()
		{
			if (cb_isAllowed == null)
				cb_isAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAllowed);
			return cb_isAllowed;
		}

		static bool n_IsAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.Policy.ConnectivityPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.ConnectivityPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_isAllowed;
		public virtual bool IsAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='ConnectivityPolicy']/method[@name='isAllowed' and count(parameter)=0]"
			[Register ("isAllowed", "()Z", "GetIsAllowedHandler")]
			get {
				if (id_isAllowed == IntPtr.Zero)
					id_isAllowed = JNIEnv.GetMethodID (class_ref, "isAllowed", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAllowed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isAllowed);
			}
		}

		static Delegate cb_handleDeliveryAttempt_Z;
#pragma warning disable 0169
		static Delegate GetHandleDeliveryAttempt_ZHandler ()
		{
			if (cb_handleDeliveryAttempt_Z == null)
				cb_handleDeliveryAttempt_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HandleDeliveryAttempt_Z);
			return cb_handleDeliveryAttempt_Z;
		}

		static void n_HandleDeliveryAttempt_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Insights.Delivery.Policy.ConnectivityPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.ConnectivityPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDeliveryAttempt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleDeliveryAttempt_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/class[@name='ConnectivityPolicy']/method[@name='handleDeliveryAttempt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("handleDeliveryAttempt", "(Z)V", "GetHandleDeliveryAttempt_ZHandler")]
		public virtual void HandleDeliveryAttempt (bool p0)
		{
			if (id_handleDeliveryAttempt_Z == IntPtr.Zero)
				id_handleDeliveryAttempt_Z = JNIEnv.GetMethodID (class_ref, "handleDeliveryAttempt", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleDeliveryAttempt_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_handleDeliveryAttempt_Z, new JValue (p0));
		}

	}
}
