using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Clock {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/interface[@name='Clock']"
	[Register ("com/amazon/ags/client/whispersync/clock/Clock", "", "Com.Amazon.Ags.Client.Whispersync.Clock.IClockInvoker")]
	public partial interface IClock : IJavaObject {

		long CurrentTimeSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/interface[@name='Clock']/method[@name='getCurrentTimeSeconds' and count(parameter)=0]"
			[Register ("getCurrentTimeSeconds", "()J", "GetGetCurrentTimeSecondsHandler:Com.Amazon.Ags.Client.Whispersync.Clock.IClockInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/Clock", DoNotGenerateAcw=true)]
	internal class IClockInvoker : global::Java.Lang.Object, IClock {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/Clock");
		IntPtr class_ref;

		public static IClock GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClock> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.clock.Clock"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IClockInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Clock.IClock __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Clock.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeSeconds;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeSeconds;
		public long CurrentTimeSeconds {
			get {
				if (id_getCurrentTimeSeconds == IntPtr.Zero)
					id_getCurrentTimeSeconds = JNIEnv.GetMethodID (class_ref, "getCurrentTimeSeconds", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getCurrentTimeSeconds);
			}
		}

	}

}
