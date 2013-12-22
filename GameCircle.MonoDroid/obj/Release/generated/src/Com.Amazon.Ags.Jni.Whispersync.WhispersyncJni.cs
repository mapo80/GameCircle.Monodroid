using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncJni']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/whispersync/WhispersyncJni", DoNotGenerateAcw=true)]
	public partial class WhispersyncJni : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/whispersync/WhispersyncJni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncJni); }
		}

		protected WhispersyncJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncJni']/constructor[@name='WhispersyncJni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WhispersyncJni () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncJni)) {
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

		static IntPtr id_onNewCloudData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncJni']/method[@name='onNewCloudData' and count(parameter)=0]"
		[Register ("onNewCloudData", "()V", "")]
		public static void OnNewCloudData ()
		{
			if (id_onNewCloudData == IntPtr.Zero)
				id_onNewCloudData = JNIEnv.GetStaticMethodID (class_ref, "onNewCloudData", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onNewCloudData);
		}

	}
}
