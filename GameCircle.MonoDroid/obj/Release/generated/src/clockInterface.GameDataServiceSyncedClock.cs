using System;
using System.Collections.Generic;
using Android.Runtime;

namespace clockInterface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='GameDataServiceSyncedClock']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock", DoNotGenerateAcw=true)]
	public partial class GameDataServiceSyncedClock : global::Java.Lang.Object, global::clockInterface.IClock {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameDataServiceSyncedClock); }
		}

		protected GameDataServiceSyncedClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_clock_Clock_Lcom_amazon_ags_client_whispersync_clock_ClockSkewStorage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='GameDataServiceSyncedClock']/constructor[@name='GameDataServiceSyncedClock' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.whispersync.clock.Clock'] and parameter[2][@type='com.amazon.ags.client.whispersync.clock.ClockSkewStorage']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/clock/Clock;Lcom/amazon/ags/client/whispersync/clock/ClockSkewStorage;)V", "")]
		public GameDataServiceSyncedClock (global::clockInterface.IClock p0, global::clockInterface.IClockSkewStorage p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GameDataServiceSyncedClock)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/clock/Clock;Lcom/amazon/ags/client/whispersync/clock/ClockSkewStorage;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/clock/Clock;Lcom/amazon/ags/client/whispersync/clock/ClockSkewStorage;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_clock_Clock_Lcom_amazon_ags_client_whispersync_clock_ClockSkewStorage_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_clock_Clock_Lcom_amazon_ags_client_whispersync_clock_ClockSkewStorage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/clock/Clock;Lcom/amazon/ags/client/whispersync/clock/ClockSkewStorage;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_clock_Clock_Lcom_amazon_ags_client_whispersync_clock_ClockSkewStorage_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_clock_Clock_Lcom_amazon_ags_client_whispersync_clock_ClockSkewStorage_, new JValue (p0), new JValue (p1));
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
			global::clockInterface.GameDataServiceSyncedClock __this = global::Java.Lang.Object.GetObject<global::clockInterface.GameDataServiceSyncedClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTimeSeconds;
		public virtual long CurrentTimeSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='GameDataServiceSyncedClock']/method[@name='getCurrentTimeSeconds' and count(parameter)=0]"
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

		static Delegate cb_synchronizeClock_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSynchronizeClock_Ljava_lang_String_Handler ()
		{
			if (cb_synchronizeClock_Ljava_lang_String_ == null)
				cb_synchronizeClock_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SynchronizeClock_Ljava_lang_String_);
			return cb_synchronizeClock_Ljava_lang_String_;
		}

		static void n_SynchronizeClock_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::clockInterface.GameDataServiceSyncedClock __this = global::Java.Lang.Object.GetObject<global::clockInterface.GameDataServiceSyncedClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SynchronizeClock (p0);
		}
#pragma warning restore 0169

		static IntPtr id_synchronizeClock_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='GameDataServiceSyncedClock']/method[@name='synchronizeClock' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("synchronizeClock", "(Ljava/lang/String;)V", "GetSynchronizeClock_Ljava_lang_String_Handler")]
		public virtual void SynchronizeClock (string p0)
		{
			if (id_synchronizeClock_Ljava_lang_String_ == IntPtr.Zero)
				id_synchronizeClock_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "synchronizeClock", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_synchronizeClock_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_synchronizeClock_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
