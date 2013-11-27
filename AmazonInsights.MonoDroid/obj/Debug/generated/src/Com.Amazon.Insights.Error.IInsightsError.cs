using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Error {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.error']/interface[@name='InsightsError']"
	[Register ("com/amazon/insights/error/InsightsError", "", "Com.Amazon.Insights.Error.IInsightsErrorInvoker")]
	public partial interface IInsightsError : IJavaObject {

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.error']/interface[@name='InsightsError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Com.Amazon.Insights.Error.IInsightsErrorInvoker, AmazonInsights.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/error/InsightsError", DoNotGenerateAcw=true)]
	internal class IInsightsErrorInvoker : global::Java.Lang.Object, IInsightsError {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/error/InsightsError");
		IntPtr class_ref;

		public static IInsightsError GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsightsError> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.error.InsightsError"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsightsErrorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInsightsErrorInvoker); }
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Error.IInsightsError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Error.IInsightsError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
