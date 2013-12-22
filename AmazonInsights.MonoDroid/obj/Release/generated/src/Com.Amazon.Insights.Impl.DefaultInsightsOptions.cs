using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsOptions']"
	[global::Android.Runtime.Register ("com/amazon/insights/impl/DefaultInsightsOptions", DoNotGenerateAcw=true)]
	public partial class DefaultInsightsOptions : global::Java.Lang.Object, global::Com.Amazon.Insights.IInsightsOptions {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/impl/DefaultInsightsOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInsightsOptions); }
		}

		protected DefaultInsightsOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsOptions']/constructor[@name='DefaultInsightsOptions' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(ZZ)V", "")]
		public DefaultInsightsOptions (bool p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultInsightsOptions)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZZ)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZZ)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ZZ == IntPtr.Zero)
				id_ctor_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZZ, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZZ, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Insights.Impl.DefaultInsightsOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Impl.DefaultInsightsOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowEventCollection;
		}
#pragma warning restore 0169

		static IntPtr id_getAllowEventCollection;
		public virtual bool AllowEventCollection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsOptions']/method[@name='getAllowEventCollection' and count(parameter)=0]"
			[Register ("getAllowEventCollection", "()Z", "GetGetAllowEventCollectionHandler")]
			get {
				if (id_getAllowEventCollection == IntPtr.Zero)
					id_getAllowEventCollection = JNIEnv.GetMethodID (class_ref, "getAllowEventCollection", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAllowEventCollection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getAllowEventCollection);
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
			global::Com.Amazon.Insights.Impl.DefaultInsightsOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Impl.DefaultInsightsOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowWANDelivery;
		}
#pragma warning restore 0169

		static IntPtr id_getAllowWANDelivery;
		public virtual bool AllowWANDelivery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsOptions']/method[@name='getAllowWANDelivery' and count(parameter)=0]"
			[Register ("getAllowWANDelivery", "()Z", "GetGetAllowWANDeliveryHandler")]
			get {
				if (id_getAllowWANDelivery == IntPtr.Zero)
					id_getAllowWANDelivery = JNIEnv.GetMethodID (class_ref, "getAllowWANDelivery", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAllowWANDelivery);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getAllowWANDelivery);
			}
		}

	}
}
