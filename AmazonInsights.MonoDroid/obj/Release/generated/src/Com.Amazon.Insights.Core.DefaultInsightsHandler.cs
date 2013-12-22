using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsHandler']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/DefaultInsightsHandler", DoNotGenerateAcw=true)]
	public partial class DefaultInsightsHandler : global::Java.Lang.Object, global::Com.Amazon.Insights.IInsightsHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/DefaultInsightsHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInsightsHandler); }
		}

		protected DefaultInsightsHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsHandler']/constructor[@name='DefaultInsightsHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultInsightsHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultInsightsHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_onComplete_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Ljava_lang_Object_Handler ()
		{
			if (cb_onComplete_Ljava_lang_Object_ == null)
				cb_onComplete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_Object_);
			return cb_onComplete_Ljava_lang_Object_;
		}

		static void n_OnComplete_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onComplete_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onComplete", "(Ljava/lang/Object;)V", "GetOnComplete_Ljava_lang_Object_Handler")]
		public virtual void OnComplete (global::Java.Lang.Object p0)
		{
			if (id_onComplete_Ljava_lang_Object_ == IntPtr.Zero)
				id_onComplete_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onComplete_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onComplete_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onError_Lcom_amazon_insights_error_InsightsError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_amazon_insights_error_InsightsError_Handler ()
		{
			if (cb_onError_Lcom_amazon_insights_error_InsightsError_ == null)
				cb_onError_Lcom_amazon_insights_error_InsightsError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_amazon_insights_error_InsightsError_);
			return cb_onError_Lcom_amazon_insights_error_InsightsError_;
		}

		static void n_OnError_Lcom_amazon_insights_error_InsightsError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.DefaultInsightsHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Error.IInsightsError p0 = (global::Com.Amazon.Insights.Error.IInsightsError)global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Error.IInsightsError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Lcom_amazon_insights_error_InsightsError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsHandler']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.error.InsightsError']]"
		[Register ("onError", "(Lcom/amazon/insights/error/InsightsError;)V", "GetOnError_Lcom_amazon_insights_error_InsightsError_Handler")]
		public virtual void OnError (global::Com.Amazon.Insights.Error.IInsightsError p0)
		{
			if (id_onError_Lcom_amazon_insights_error_InsightsError_ == IntPtr.Zero)
				id_onError_Lcom_amazon_insights_error_InsightsError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/amazon/insights/error/InsightsError;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onError_Lcom_amazon_insights_error_InsightsError_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onError_Lcom_amazon_insights_error_InsightsError_, new JValue (p0));
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
			global::Com.Amazon.Insights.Core.DefaultInsightsHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.DefaultInsightsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.InsightsCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.InsightsCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_amazon_insights_InsightsCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core']/class[@name='DefaultInsightsHandler']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.InsightsCallback']]"
		[Register ("setCallback", "(Lcom/amazon/insights/InsightsCallback;)V", "GetSetCallback_Lcom_amazon_insights_InsightsCallback_Handler")]
		public virtual void SetCallback (global::Com.Amazon.Insights.InsightsCallback p0)
		{
			if (id_setCallback_Lcom_amazon_insights_InsightsCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_amazon_insights_InsightsCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/amazon/insights/InsightsCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCallback_Lcom_amazon_insights_InsightsCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCallback_Lcom_amazon_insights_InsightsCallback_, new JValue (p0));
		}

	}
}
