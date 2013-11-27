using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='FileEventStore']"
	[global::Android.Runtime.Register ("com/amazon/insights/delivery/FileEventStore", DoNotGenerateAcw=true)]
	public partial class FileEventStore : global::Java.Lang.Object, global::Com.Amazon.Insights.Delivery.IEventStore {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/delivery/FileEventStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileEventStore); }
		}

		protected FileEventStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='FileEventStore']/constructor[@name='FileEventStore' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;)V", "")]
		public FileEventStore (global::Com.Amazon.Insights.Core.IInsightsContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileEventStore)) {
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

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.FileEventStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.FileEventStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='FileEventStore']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Lcom/amazon/insights/delivery/EventStore$EventIterator;", "GetIteratorHandler")]
		public virtual global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Lcom/amazon/insights/delivery/EventStore$EventIterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='FileEventStore']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/delivery/FileEventStore;", "")]
		public static global::Com.Amazon.Insights.Delivery.FileEventStore NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;)Lcom/amazon/insights/delivery/FileEventStore;");
			global::Com.Amazon.Insights.Delivery.FileEventStore __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.FileEventStore> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_;
		}

		static bool n_Put_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Delivery.FileEventStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.FileEventStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/class[@name='FileEventStore']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;)Z", "GetPut_Ljava_lang_String_Handler")]
		public virtual bool Put (string p0)
		{
			if (id_put_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_put_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
