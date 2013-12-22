using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsOptions']"
	[Register ("com/amazon/insights/InsightsOptions", "", "Com.Amazon.Insights.IInsightsOptionsInvoker")]
	public partial interface IInsightsOptions : IJavaObject {

		bool AllowEventCollection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsOptions']/method[@name='getAllowEventCollection' and count(parameter)=0]"
			[Register ("getAllowEventCollection", "()Z", "GetGetAllowEventCollectionHandler:Com.Amazon.Insights.IInsightsOptionsInvoker, AmazonInsights.MonoDroid")] get;
		}

		bool AllowWANDelivery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsOptions']/method[@name='getAllowWANDelivery' and count(parameter)=0]"
			[Register ("getAllowWANDelivery", "()Z", "GetGetAllowWANDeliveryHandler:Com.Amazon.Insights.IInsightsOptionsInvoker, AmazonInsights.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/InsightsOptions", DoNotGenerateAcw=true)]
	internal class IInsightsOptionsInvoker : global::Java.Lang.Object, IInsightsOptions {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/InsightsOptions");
		IntPtr class_ref;

		public static IInsightsOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsightsOptions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.InsightsOptions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsightsOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInsightsOptionsInvoker); }
		}

		static Delegate cb_getAllowEventCollection;
#pragma warning disable 0169
		static Delegate GetGetAllowEventCollectionHandler ()
		{
			if (cb_getAllowEventCollection == null)
				cb_getAllowEventCollection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAllowEventCollection);
			return cb_getAllowEventCollection;
		}

		static bool n_GetAllowEventCollection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IInsightsOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowEventCollection;
		}
#pragma warning restore 0169

		IntPtr id_getAllowEventCollection;
		public bool AllowEventCollection {
			get {
				if (id_getAllowEventCollection == IntPtr.Zero)
					id_getAllowEventCollection = JNIEnv.GetMethodID (class_ref, "getAllowEventCollection", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_getAllowEventCollection);
			}
		}

		static Delegate cb_getAllowWANDelivery;
#pragma warning disable 0169
		static Delegate GetGetAllowWANDeliveryHandler ()
		{
			if (cb_getAllowWANDelivery == null)
				cb_getAllowWANDelivery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAllowWANDelivery);
			return cb_getAllowWANDelivery;
		}

		static bool n_GetAllowWANDelivery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IInsightsOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowWANDelivery;
		}
#pragma warning restore 0169

		IntPtr id_getAllowWANDelivery;
		public bool AllowWANDelivery {
			get {
				if (id_getAllowWANDelivery == IntPtr.Zero)
					id_getAllowWANDelivery = JNIEnv.GetMethodID (class_ref, "getAllowWANDelivery", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_getAllowWANDelivery);
			}
		}

	}

}
