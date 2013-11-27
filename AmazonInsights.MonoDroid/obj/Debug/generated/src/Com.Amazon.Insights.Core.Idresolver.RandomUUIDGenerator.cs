using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Idresolver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='RandomUUIDGenerator']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/idresolver/RandomUUIDGenerator", DoNotGenerateAcw=true)]
	public partial class RandomUUIDGenerator : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Idresolver.IUniqueIdGenerator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/idresolver/RandomUUIDGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RandomUUIDGenerator); }
		}

		protected RandomUUIDGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='RandomUUIDGenerator']/constructor[@name='RandomUUIDGenerator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RandomUUIDGenerator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RandomUUIDGenerator)) {
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
			global::Com.Amazon.Insights.Core.Idresolver.RandomUUIDGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.RandomUUIDGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateUniqueIdString ());
		}
#pragma warning restore 0169

		static IntPtr id_generateUniqueIdString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.idresolver']/class[@name='RandomUUIDGenerator']/method[@name='generateUniqueIdString' and count(parameter)=0]"
		[Register ("generateUniqueIdString", "()Ljava/lang/String;", "GetGenerateUniqueIdStringHandler")]
		public virtual string GenerateUniqueIdString ()
		{
			if (id_generateUniqueIdString == IntPtr.Zero)
				id_generateUniqueIdString = JNIEnv.GetMethodID (class_ref, "generateUniqueIdString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateUniqueIdString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_generateUniqueIdString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
