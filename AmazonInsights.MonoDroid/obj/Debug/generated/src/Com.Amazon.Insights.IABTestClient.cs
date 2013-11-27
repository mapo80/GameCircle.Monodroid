using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='ABTestClient']"
	[Register ("com/amazon/insights/ABTestClient", "", "Com.Amazon.Insights.IABTestClientInvoker")]
	public partial interface IABTestClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='ABTestClient']/method[@name='getVariations' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getVariations", "([Ljava/lang/String;)Lcom/amazon/insights/InsightsHandler;", "GetGetVariations_arrayLjava_lang_String_Handler:Com.Amazon.Insights.IABTestClientInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IInsightsHandler GetVariations (params  string[] p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/ABTestClient", DoNotGenerateAcw=true)]
	internal class IABTestClientInvoker : global::Java.Lang.Object, IABTestClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/ABTestClient");
		IntPtr class_ref;

		public static IABTestClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IABTestClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.ABTestClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IABTestClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IABTestClientInvoker); }
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
			global::Com.Amazon.Insights.IABTestClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IABTestClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetVariations (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariations_arrayLjava_lang_String_;
		public global::Com.Amazon.Insights.IInsightsHandler GetVariations (params  string[] p0)
		{
			if (id_getVariations_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getVariations_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVariations", "([Ljava/lang/String;)Lcom/amazon/insights/InsightsHandler;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Insights.IInsightsHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsHandler> (JNIEnv.CallObjectMethod (Handle, id_getVariations_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
