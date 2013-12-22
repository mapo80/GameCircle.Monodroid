using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Abtest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']"
	[global::Android.Runtime.Register ("com/amazon/insights/abtest/DefaultABTestClient", DoNotGenerateAcw=true)]
	public partial class DefaultABTestClient : global::Java.Lang.Object, global::Com.Amazon.Insights.IABTestClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']/field[@name='ALLOW_OPERATION_AFTER_HEADER']"
		[Register ("ALLOW_OPERATION_AFTER_HEADER")]
		protected const string AllowOperationAfterHeader = (string) "x-amzn-Allow-Operation-After";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/abtest/DefaultABTestClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultABTestClient); }
		}

		protected DefaultABTestClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_canHandleRequest;
#pragma warning disable 0169
		static Delegate GetCanHandleRequestHandler ()
		{
			if (cb_canHandleRequest == null)
				cb_canHandleRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanHandleRequest);
			return cb_canHandleRequest;
		}

		static bool n_CanHandleRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultABTestClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultABTestClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanHandleRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_canHandleRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']/method[@name='canHandleRequest' and count(parameter)=0]"
		[Register ("canHandleRequest", "()Z", "GetCanHandleRequestHandler")]
		protected virtual bool CanHandleRequest ()
		{
			if (id_canHandleRequest == IntPtr.Zero)
				id_canHandleRequest = JNIEnv.GetMethodID (class_ref, "canHandleRequest", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canHandleRequest);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_canHandleRequest);
		}

		static Delegate cb_getVariations_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetVariations_arrayLjava_lang_String_Handler ()
		{
			if (cb_getVariations_arrayLjava_lang_String_ == null)
				cb_getVariations_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetVariations_arrayLjava_lang_String_);
			return cb_getVariations_arrayLjava_lang_String_;
		}

		static IntPtr n_GetVariations_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.DefaultABTestClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultABTestClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetVariations (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariations_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']/method[@name='getVariations' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getVariations", "([Ljava/lang/String;)Lcom/amazon/insights/InsightsHandler;", "GetGetVariations_arrayLjava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.IInsightsHandler GetVariations (params  string[] p0)
		{
			if (id_getVariations_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getVariations_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVariations", "([Ljava/lang/String;)Lcom/amazon/insights/InsightsHandler;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Insights.IInsightsHandler __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsHandler> (JNIEnv.CallObjectMethod  (Handle, id_getVariations_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsHandler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVariations_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='com.amazon.insights.event.InternalEventClient']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;)Lcom/amazon/insights/abtest/DefaultABTestClient;", "")]
		public static global::Com.Amazon.Insights.Abtest.DefaultABTestClient NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::Com.Amazon.Insights.Event.IInternalEventClient p1)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Lcom/amazon/insights/event/InternalEventClient;)Lcom/amazon/insights/abtest/DefaultABTestClient;");
			global::Com.Amazon.Insights.Abtest.DefaultABTestClient __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultABTestClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Lcom_amazon_insights_event_InternalEventClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_;
#pragma warning disable 0169
		static Delegate GetSetVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_Handler ()
		{
			if (cb_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_ == null)
				cb_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_);
			return cb_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_;
		}

		static void n_SetVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.DefaultABTestClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultABTestClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Abtest.DefaultVariation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVariationIdsFromAllocatedVariation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultABTestClient']/method[@name='setVariationIdsFromAllocatedVariation' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation']]"
		[Register ("setVariationIdsFromAllocatedVariation", "(Lcom/amazon/insights/abtest/DefaultVariation;)V", "GetSetVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_Handler")]
		public virtual void SetVariationIdsFromAllocatedVariation (global::Com.Amazon.Insights.Abtest.DefaultVariation p0)
		{
			if (id_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_ == IntPtr.Zero)
				id_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_ = JNIEnv.GetMethodID (class_ref, "setVariationIdsFromAllocatedVariation", "(Lcom/amazon/insights/abtest/DefaultVariation;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setVariationIdsFromAllocatedVariation_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
		}

	}
}
