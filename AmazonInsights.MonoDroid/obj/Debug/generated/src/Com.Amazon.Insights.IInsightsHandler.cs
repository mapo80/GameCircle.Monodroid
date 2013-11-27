using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsHandler']"
	[Register ("com/amazon/insights/InsightsHandler", "", "Com.Amazon.Insights.IInsightsHandlerInvoker")]
	public partial interface IInsightsHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsHandler']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.InsightsCallback']]"
		[Register ("setCallback", "(Lcom/amazon/insights/InsightsCallback;)V", "GetSetCallback_Lcom_amazon_insights_InsightsCallback_Handler:Com.Amazon.Insights.IInsightsHandlerInvoker, AmazonInsights.MonoDroid")]
		void SetCallback (global::Com.Amazon.Insights.InsightsCallback p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/InsightsHandler", DoNotGenerateAcw=true)]
	internal class IInsightsHandlerInvoker : global::Java.Lang.Object, IInsightsHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/InsightsHandler");
		IntPtr class_ref;

		public static IInsightsHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsightsHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.InsightsHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsightsHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInsightsHandlerInvoker); }
		}

		static Delegate cb_setCallback_Lcom_amazon_insights_InsightsCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_amazon_insights_InsightsCallback_Handler ()
		{
			if (cb_setCallback_Lcom_amazon_insights_InsightsCallback_ == null)
				cb_setCallback_Lcom_amazon_insights_InsightsCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_amazon_insights_InsightsCallback_);
			return cb_setCallback_Lcom_amazon_insights_InsightsCallback_;
		}

		static void n_SetCallback_Lcom_amazon_insights_InsightsCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IInsightsHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.InsightsCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.InsightsCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCallback_Lcom_amazon_insights_InsightsCallback_;
		public void SetCallback (global::Com.Amazon.Insights.InsightsCallback p0)
		{
			if (id_setCallback_Lcom_amazon_insights_InsightsCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_amazon_insights_InsightsCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/amazon/insights/InsightsCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_setCallback_Lcom_amazon_insights_InsightsCallback_, new JValue (p0));
		}

	}

}
