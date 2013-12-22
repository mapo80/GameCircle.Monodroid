using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Idresolver {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/interface[@name='UniqueIdGenerator']"
	[Register ("com/amazon/insights/core/idresolver/UniqueIdGenerator", "", "Com.Amazon.Insights.Core.Idresolver.IUniqueIdGeneratorInvoker")]
	public partial interface IUniqueIdGenerator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/interface[@name='UniqueIdGenerator']/method[@name='generateUniqueIdString' and count(parameter)=0]"
		[Register ("generateUniqueIdString", "()Ljava/lang/String;", "GetGenerateUniqueIdStringHandler:Com.Amazon.Insights.Core.Idresolver.IUniqueIdGeneratorInvoker, AmazonInsights.MonoDroid")]
		string GenerateUniqueIdString ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/idresolver/UniqueIdGenerator", DoNotGenerateAcw=true)]
	internal class IUniqueIdGeneratorInvoker : global::Java.Lang.Object, IUniqueIdGenerator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/idresolver/UniqueIdGenerator");
		IntPtr class_ref;

		public static IUniqueIdGenerator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUniqueIdGenerator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.idresolver.UniqueIdGenerator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUniqueIdGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUniqueIdGeneratorInvoker); }
		}

		static Delegate cb_generateUniqueIdString;
#pragma warning disable 0169
		static Delegate GetGenerateUniqueIdStringHandler ()
		{
			if (cb_generateUniqueIdString == null)
				cb_generateUniqueIdString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateUniqueIdString);
			return cb_generateUniqueIdString;
		}

		static IntPtr n_GenerateUniqueIdString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateUniqueIdString ());
		}
#pragma warning restore 0169

		IntPtr id_generateUniqueIdString;
		public string GenerateUniqueIdString ()
		{
			if (id_generateUniqueIdString == IntPtr.Zero)
				id_generateUniqueIdString = JNIEnv.GetMethodID (class_ref, "generateUniqueIdString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_generateUniqueIdString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
