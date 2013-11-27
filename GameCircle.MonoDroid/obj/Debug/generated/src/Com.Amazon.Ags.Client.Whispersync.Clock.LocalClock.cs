using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Clock {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='LocalClock']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/LocalClock", DoNotGenerateAcw=true)]
	public partial class LocalClock : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Clock.IClock {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/LocalClock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalClock); }
		}

		protected LocalClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='LocalClock']/constructor[@name='LocalClock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LocalClock () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocalClock)) {
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

		static Delegate cb_getCurrentTimeSeconds;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeSecondsHandler ()
		{
			if (cb_getCurrentTimeSeconds == null)
				cb_getCurrentTimeSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentTimeSeconds);
			return cb_getCurrentTimeSeconds;
		}

		static long n_GetCurrentTimeSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Clock.LocalClock __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Clock.LocalClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTimeSeconds;
		public virtual long CurrentTimeSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='LocalClock']/method[@name='getCurrentTimeSeconds' and count(parameter)=0]"
			[Register ("getCurrentTimeSeconds", "()J", "GetGetCurrentTimeSecondsHandler")]
			get {
				if (id_getCurrentTimeSeconds == IntPtr.Zero)
					id_getCurrentTimeSeconds = JNIEnv.GetMethodID (class_ref, "getCurrentTimeSeconds", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getCurrentTimeSeconds);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getCurrentTimeSeconds);
			}
		}

	}
}
