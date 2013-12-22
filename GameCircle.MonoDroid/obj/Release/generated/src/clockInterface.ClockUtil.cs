using System;
using System.Collections.Generic;
using Android.Runtime;

namespace clockInterface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockUtil']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/ClockUtil", DoNotGenerateAcw=true)]
	public partial class ClockUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/ClockUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClockUtil); }
		}

		protected ClockUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentTime;
		public static long CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockUtil']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()J", "GetGetCurrentTimeHandler")]
			get {
				if (id_getCurrentTime == IntPtr.Zero)
					id_getCurrentTime = JNIEnv.GetStaticMethodID (class_ref, "getCurrentTime", "()J");
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getCurrentTime);
			}
		}

		static IntPtr id_setGlobalClock_Lcom_amazon_ags_client_whispersync_clock_Clock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockUtil']/method[@name='setGlobalClock' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.clock.Clock']]"
		[Register ("setGlobalClock", "(Lcom/amazon/ags/client/whispersync/clock/Clock;)V", "")]
		public static void SetGlobalClock (global::clockInterface.IClock p0)
		{
			if (id_setGlobalClock_Lcom_amazon_ags_client_whispersync_clock_Clock_ == IntPtr.Zero)
				id_setGlobalClock_Lcom_amazon_ags_client_whispersync_clock_Clock_ = JNIEnv.GetStaticMethodID (class_ref, "setGlobalClock", "(Lcom/amazon/ags/client/whispersync/clock/Clock;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setGlobalClock_Lcom_amazon_ags_client_whispersync_clock_Clock_, new JValue (p0));
		}

	}
}
