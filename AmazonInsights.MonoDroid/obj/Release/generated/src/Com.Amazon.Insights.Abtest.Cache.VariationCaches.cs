using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Abtest.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='VariationCaches']"
	[global::Android.Runtime.Register ("com/amazon/insights/abtest/cache/VariationCaches", DoNotGenerateAcw=true)]
	public partial class VariationCaches : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/abtest/cache/VariationCaches", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VariationCaches); }
		}

		protected VariationCaches (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_tryGetFileVariationCache_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='VariationCaches']/method[@name='tryGetFileVariationCache' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("tryGetFileVariationCache", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/abtest/cache/VariationCache;", "")]
		public static global::Com.Amazon.Insights.Abtest.Cache.IVariationCache TryGetFileVariationCache (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_tryGetFileVariationCache_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_tryGetFileVariationCache_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetStaticMethodID (class_ref, "tryGetFileVariationCache", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/abtest/cache/VariationCache;");
			global::Com.Amazon.Insights.Abtest.Cache.IVariationCache __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.IVariationCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_tryGetFileVariationCache_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
