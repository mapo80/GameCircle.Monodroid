using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Monetization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']"
	[global::Android.Runtime.Register ("com/amazon/insights/monetization/AmazonMonetizationEventBuilder", DoNotGenerateAcw=true)]
	public partial class AmazonMonetizationEventBuilder : global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/monetization/AmazonMonetizationEventBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonMonetizationEventBuilder); }
		}

		protected AmazonMonetizationEventBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_EventClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/constructor[@name='AmazonMonetizationEventBuilder' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.EventClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/EventClient;)V", "")]
		protected AmazonMonetizationEventBuilder (global::Com.Amazon.Insights.IEventClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AmazonMonetizationEventBuilder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/EventClient;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/EventClient;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_EventClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_EventClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/EventClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_EventClient_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_EventClient_, new JValue (p0));
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		protected override bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isValid);
			}
		}

		static IntPtr id_create_Lcom_amazon_insights_EventClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.EventClient']]"
		[Register ("create", "(Lcom/amazon/insights/EventClient;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;", "")]
		public static global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder Create (global::Com.Amazon.Insights.IEventClient p0)
		{
			if (id_create_Lcom_amazon_insights_EventClient_ == IntPtr.Zero)
				id_create_Lcom_amazon_insights_EventClient_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/amazon/insights/EventClient;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;");
			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_amazon_insights_EventClient_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withFormattedItemPrice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFormattedItemPrice_Ljava_lang_String_Handler ()
		{
			if (cb_withFormattedItemPrice_Ljava_lang_String_ == null)
				cb_withFormattedItemPrice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFormattedItemPrice_Ljava_lang_String_);
			return cb_withFormattedItemPrice_Ljava_lang_String_;
		}

		static IntPtr n_WithFormattedItemPrice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFormattedItemPrice (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFormattedItemPrice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/method[@name='withFormattedItemPrice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFormattedItemPrice", "(Ljava/lang/String;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;", "GetWithFormattedItemPrice_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder WithFormattedItemPrice (string p0)
		{
			if (id_withFormattedItemPrice_Ljava_lang_String_ == IntPtr.Zero)
				id_withFormattedItemPrice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFormattedItemPrice", "(Ljava/lang/String;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withFormattedItemPrice_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withFormattedItemPrice_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withProductId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithProductId_Ljava_lang_String_Handler ()
		{
			if (cb_withProductId_Ljava_lang_String_ == null)
				cb_withProductId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithProductId_Ljava_lang_String_);
			return cb_withProductId_Ljava_lang_String_;
		}

		static IntPtr n_WithProductId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProductId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withProductId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/method[@name='withProductId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withProductId", "(Ljava/lang/String;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;", "GetWithProductId_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder WithProductId (string p0)
		{
			if (id_withProductId_Ljava_lang_String_ == IntPtr.Zero)
				id_withProductId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withProductId", "(Ljava/lang/String;)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withProductId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withProductId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withQuantity_I;
#pragma warning disable 0169
		static Delegate GetWithQuantity_IHandler ()
		{
			if (cb_withQuantity_I == null)
				cb_withQuantity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithQuantity_I);
			return cb_withQuantity_I;
		}

		static IntPtr n_WithQuantity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithQuantity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withQuantity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='AmazonMonetizationEventBuilder']/method[@name='withQuantity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withQuantity", "(I)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;", "GetWithQuantity_IHandler")]
		public virtual global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder WithQuantity (int p0)
		{
			if (id_withQuantity_I == IntPtr.Zero)
				id_withQuantity_I = JNIEnv.GetMethodID (class_ref, "withQuantity", "(I)Lcom/amazon/insights/monetization/AmazonMonetizationEventBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withQuantity_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.AmazonMonetizationEventBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withQuantity_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
