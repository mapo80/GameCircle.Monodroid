using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Monetization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']"
	[global::Android.Runtime.Register ("com/amazon/insights/monetization/MonetizationEventBuilder", DoNotGenerateAcw=true)]
	public abstract partial class MonetizationEventBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/monetization/MonetizationEventBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonetizationEventBuilder); }
		}

		protected MonetizationEventBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_EventClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/constructor[@name='MonetizationEventBuilder' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.EventClient']]"
		[Register (".ctor", "(Lcom/amazon/insights/EventClient;)V", "")]
		protected MonetizationEventBuilder (global::Com.Amazon.Insights.IEventClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MonetizationEventBuilder)) {
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

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrency);
			return cb_getCurrency;
		}

		static IntPtr n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Currency);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrency_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCurrency_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrency_Ljava_lang_String_ == null)
				cb_setCurrency_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrency_Ljava_lang_String_);
			return cb_setCurrency_Ljava_lang_String_;
		}

		static void n_SetCurrency_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Currency = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		static IntPtr id_setCurrency_Ljava_lang_String_;
		protected virtual string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/lang/String;", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrency), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrency), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setCurrency' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrency", "(Ljava/lang/String;)V", "GetSetCurrency_Ljava_lang_String_Handler")]
			set {
				if (id_setCurrency_Ljava_lang_String_ == IntPtr.Zero)
					id_setCurrency_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCurrency", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCurrency_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCurrency_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getFormattedItemPrice;
#pragma warning disable 0169
		static Delegate GetGetFormattedItemPriceHandler ()
		{
			if (cb_getFormattedItemPrice == null)
				cb_getFormattedItemPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedItemPrice);
			return cb_getFormattedItemPrice;
		}

		static IntPtr n_GetFormattedItemPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormattedItemPrice);
		}
#pragma warning restore 0169

		static Delegate cb_setFormattedItemPrice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormattedItemPrice_Ljava_lang_String_Handler ()
		{
			if (cb_setFormattedItemPrice_Ljava_lang_String_ == null)
				cb_setFormattedItemPrice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormattedItemPrice_Ljava_lang_String_);
			return cb_setFormattedItemPrice_Ljava_lang_String_;
		}

		static void n_SetFormattedItemPrice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FormattedItemPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFormattedItemPrice;
		static IntPtr id_setFormattedItemPrice_Ljava_lang_String_;
		protected virtual string FormattedItemPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getFormattedItemPrice' and count(parameter)=0]"
			[Register ("getFormattedItemPrice", "()Ljava/lang/String;", "GetGetFormattedItemPriceHandler")]
			get {
				if (id_getFormattedItemPrice == IntPtr.Zero)
					id_getFormattedItemPrice = JNIEnv.GetMethodID (class_ref, "getFormattedItemPrice", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFormattedItemPrice), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getFormattedItemPrice), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setFormattedItemPrice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFormattedItemPrice", "(Ljava/lang/String;)V", "GetSetFormattedItemPrice_Ljava_lang_String_Handler")]
			set {
				if (id_setFormattedItemPrice_Ljava_lang_String_ == IntPtr.Zero)
					id_setFormattedItemPrice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFormattedItemPrice", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFormattedItemPrice_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFormattedItemPrice_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
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
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		protected abstract bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")] get;
		}

		static Delegate cb_getItemPrice;
#pragma warning disable 0169
		static Delegate GetGetItemPriceHandler ()
		{
			if (cb_getItemPrice == null)
				cb_getItemPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemPrice);
			return cb_getItemPrice;
		}

		static IntPtr n_GetItemPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemPrice);
		}
#pragma warning restore 0169

		static Delegate cb_setItemPrice_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetItemPrice_Ljava_lang_Double_Handler ()
		{
			if (cb_setItemPrice_Ljava_lang_Double_ == null)
				cb_setItemPrice_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItemPrice_Ljava_lang_Double_);
			return cb_setItemPrice_Ljava_lang_Double_;
		}

		static void n_SetItemPrice_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ItemPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemPrice;
		static IntPtr id_setItemPrice_Ljava_lang_Double_;
		protected virtual global::Java.Lang.Double ItemPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getItemPrice' and count(parameter)=0]"
			[Register ("getItemPrice", "()Ljava/lang/Double;", "GetGetItemPriceHandler")]
			get {
				if (id_getItemPrice == IntPtr.Zero)
					id_getItemPrice = JNIEnv.GetMethodID (class_ref, "getItemPrice", "()Ljava/lang/Double;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getItemPrice), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getItemPrice), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setItemPrice' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setItemPrice", "(Ljava/lang/Double;)V", "GetSetItemPrice_Ljava_lang_Double_Handler")]
			set {
				if (id_setItemPrice_Ljava_lang_Double_ == IntPtr.Zero)
					id_setItemPrice_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setItemPrice", "(Ljava/lang/Double;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setItemPrice_Ljava_lang_Double_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setItemPrice_Ljava_lang_Double_, new JValue (value));
			}
		}

		static Delegate cb_getProductId;
#pragma warning disable 0169
		static Delegate GetGetProductIdHandler ()
		{
			if (cb_getProductId == null)
				cb_getProductId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductId);
			return cb_getProductId;
		}

		static IntPtr n_GetProductId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductId);
		}
#pragma warning restore 0169

		static Delegate cb_setProductId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductId_Ljava_lang_String_Handler ()
		{
			if (cb_setProductId_Ljava_lang_String_ == null)
				cb_setProductId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProductId_Ljava_lang_String_);
			return cb_setProductId_Ljava_lang_String_;
		}

		static void n_SetProductId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProductId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProductId;
		static IntPtr id_setProductId_Ljava_lang_String_;
		protected virtual string ProductId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getProductId' and count(parameter)=0]"
			[Register ("getProductId", "()Ljava/lang/String;", "GetGetProductIdHandler")]
			get {
				if (id_getProductId == IntPtr.Zero)
					id_getProductId = JNIEnv.GetMethodID (class_ref, "getProductId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProductId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setProductId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProductId", "(Ljava/lang/String;)V", "GetSetProductId_Ljava_lang_String_Handler")]
			set {
				if (id_setProductId_Ljava_lang_String_ == IntPtr.Zero)
					id_setProductId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProductId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProductId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setProductId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getQuantity;
#pragma warning disable 0169
		static Delegate GetGetQuantityHandler ()
		{
			if (cb_getQuantity == null)
				cb_getQuantity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuantity);
			return cb_getQuantity;
		}

		static IntPtr n_GetQuantity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Quantity);
		}
#pragma warning restore 0169

		static Delegate cb_setQuantity_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetQuantity_Ljava_lang_Integer_Handler ()
		{
			if (cb_setQuantity_Ljava_lang_Integer_ == null)
				cb_setQuantity_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQuantity_Ljava_lang_Integer_);
			return cb_setQuantity_Ljava_lang_Integer_;
		}

		static void n_SetQuantity_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Quantity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQuantity;
		static IntPtr id_setQuantity_Ljava_lang_Integer_;
		protected virtual global::Java.Lang.Integer Quantity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getQuantity' and count(parameter)=0]"
			[Register ("getQuantity", "()Ljava/lang/Integer;", "GetGetQuantityHandler")]
			get {
				if (id_getQuantity == IntPtr.Zero)
					id_getQuantity = JNIEnv.GetMethodID (class_ref, "getQuantity", "()Ljava/lang/Integer;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getQuantity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getQuantity), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setQuantity' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setQuantity", "(Ljava/lang/Integer;)V", "GetSetQuantity_Ljava_lang_Integer_Handler")]
			set {
				if (id_setQuantity_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setQuantity_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setQuantity", "(Ljava/lang/Integer;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setQuantity_Ljava_lang_Integer_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setQuantity_Ljava_lang_Integer_, new JValue (value));
			}
		}

		static Delegate cb_getStore;
#pragma warning disable 0169
		static Delegate GetGetStoreHandler ()
		{
			if (cb_getStore == null)
				cb_getStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStore);
			return cb_getStore;
		}

		static IntPtr n_GetStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Store);
		}
#pragma warning restore 0169

		static Delegate cb_setStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStore_Ljava_lang_String_Handler ()
		{
			if (cb_setStore_Ljava_lang_String_ == null)
				cb_setStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStore_Ljava_lang_String_);
			return cb_setStore_Ljava_lang_String_;
		}

		static void n_SetStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Store = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStore;
		static IntPtr id_setStore_Ljava_lang_String_;
		protected virtual string Store {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getStore' and count(parameter)=0]"
			[Register ("getStore", "()Ljava/lang/String;", "GetGetStoreHandler")]
			get {
				if (id_getStore == IntPtr.Zero)
					id_getStore = JNIEnv.GetMethodID (class_ref, "getStore", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStore), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStore), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStore", "(Ljava/lang/String;)V", "GetSetStore_Ljava_lang_String_Handler")]
			set {
				if (id_setStore_Ljava_lang_String_ == IntPtr.Zero)
					id_setStore_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStore", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStore_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setStore_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		static IntPtr id_setTransactionId_Ljava_lang_String_;
		protected virtual string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTransactionId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTransactionId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Monetization.MonetizationEventBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/amazon/insights/Event;", "GetBuildHandler")]
		public virtual global::Com.Amazon.Insights.IEvent Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/amazon/insights/Event;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/monetization/MonetizationEventBuilder", DoNotGenerateAcw=true)]
	internal partial class MonetizationEventBuilderInvoker : MonetizationEventBuilder {

		public MonetizationEventBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonetizationEventBuilderInvoker); }
		}

		static IntPtr id_isValid;
		protected override bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.monetization']/class[@name='MonetizationEventBuilder']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
			}
		}

	}

}
