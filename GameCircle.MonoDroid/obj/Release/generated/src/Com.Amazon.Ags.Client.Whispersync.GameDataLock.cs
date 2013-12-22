using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='GameDataLock']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/GameDataLock", DoNotGenerateAcw=true)]
	public partial class GameDataLock : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/GameDataLock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameDataLock); }
		}

		protected GameDataLock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='GameDataLock']/constructor[@name='GameDataLock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GameDataLock () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GameDataLock)) {
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

		static IntPtr id_lock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='GameDataLock']/method[@name='lock' and count(parameter)=0]"
		[Register ("lock", "()V", "")]
		public static void Lock ()
		{
			if (id_lock == IntPtr.Zero)
				id_lock = JNIEnv.GetStaticMethodID (class_ref, "lock", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_lock);
		}

		static IntPtr id_unlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='GameDataLock']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "")]
		public static void Unlock ()
		{
			if (id_unlock == IntPtr.Zero)
				id_unlock = JNIEnv.GetStaticMethodID (class_ref, "unlock", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unlock);
		}

	}
}
