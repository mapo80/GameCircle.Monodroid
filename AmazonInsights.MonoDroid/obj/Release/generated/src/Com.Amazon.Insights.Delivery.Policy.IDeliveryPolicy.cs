using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery.Policy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicy']"
	[Register ("com/amazon/insights/delivery/policy/DeliveryPolicy", "", "Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyInvoker")]
	public partial interface IDeliveryPolicy : IJavaObject {

		bool IsAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicy']/method[@name='isAllowed' and count(parameter)=0]"
			[Register ("isAllowed", "()Z", "GetIsAllowedHandler:Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery.policy']/interface[@name='DeliveryPolicy']/method[@name='handleDeliveryAttempt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("handleDeliveryAttempt", "(Z)V", "GetHandleDeliveryAttempt_ZHandler:Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicyInvoker, AmazonInsights.MonoDroid")]
		void HandleDeliveryAttempt (bool p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/delivery/policy/DeliveryPolicy", DoNotGenerateAcw=true)]
	internal class IDeliveryPolicyInvoker : global::Java.Lang.Object, IDeliveryPolicy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/delivery/policy/DeliveryPolicy");
		IntPtr class_ref;

		public static IDeliveryPolicy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeliveryPolicy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.delivery.policy.DeliveryPolicy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeliveryPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeliveryPolicyInvoker); }
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
			global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowed;
		}
#pragma warning restore 0169

		IntPtr id_isAllowed;
		public bool IsAllowed {
			get {
				if (id_isAllowed == IntPtr.Zero)
					id_isAllowed = JNIEnv.GetMethodID (class_ref, "isAllowed", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isAllowed);
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
			global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.Policy.IDeliveryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDeliveryAttempt (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleDeliveryAttempt_Z;
		public void HandleDeliveryAttempt (bool p0)
		{
			if (id_handleDeliveryAttempt_Z == IntPtr.Zero)
				id_handleDeliveryAttempt_Z = JNIEnv.GetMethodID (class_ref, "handleDeliveryAttempt", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_handleDeliveryAttempt_Z, new JValue (p0));
		}

	}

}
