using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.log']/interface[@name='LogInitializer']"
	[Register ("com/amazon/insights/core/log/LogInitializer", "", "Com.Amazon.Insights.Core.Log.ILogInitializerInvoker")]
	public partial interface ILogInitializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/interface[@name='LogInitializer']/method[@name='tryInitialize' and count(parameter)=0]"
		[Register ("tryInitialize", "()V", "GetTryInitializeHandler:Com.Amazon.Insights.Core.Log.ILogInitializerInvoker, AmazonInsights.MonoDroid")]
		void TryInitialize ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/log/LogInitializer", DoNotGenerateAcw=true)]
	internal class ILogInitializerInvoker : global::Java.Lang.Object, ILogInitializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/log/LogInitializer");
		IntPtr class_ref;

		public static ILogInitializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogInitializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.log.LogInitializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogInitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILogInitializerInvoker); }
		}

		static Delegate cb_tryInitialize;
#pragma warning disable 0169
		static Delegate GetTryInitializeHandler ()
		{
			if (cb_tryInitialize == null)
				cb_tryInitialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TryInitialize);
			return cb_tryInitialize;
		}

		static void n_TryInitialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Log.ILogInitializer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.ILogInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TryInitialize ();
		}
#pragma warning restore 0169

		IntPtr id_tryInitialize;
		public void TryInitialize ()
		{
			if (id_tryInitialize == IntPtr.Zero)
				id_tryInitialize = JNIEnv.GetMethodID (class_ref, "tryInitialize", "()V");
			JNIEnv.CallVoidMethod (Handle, id_tryInitialize);
		}

	}

}
