using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='ERSRequestBuilder']"
	[global::Android.Runtime.Register ("com/amazon/insights/delivery/ERSRequestBuilder", DoNotGenerateAcw=true)]
	public partial class ERSRequestBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/delivery/ERSRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ERSRequestBuilder); }
		}

		protected ERSRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='ERSRequestBuilder']/constructor[@name='ERSRequestBuilder' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;)V", "")]
		public ERSRequestBuilder (global::Com.Amazon.Insights.Core.IInsightsContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ERSRequestBuilder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0));
		}

	}
}
