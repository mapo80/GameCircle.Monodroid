using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SimpleQuietPeriodListener']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/SimpleQuietPeriodListener", DoNotGenerateAcw=true)]
	public partial class SimpleQuietPeriodListener : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/SimpleQuietPeriodListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleQuietPeriodListener); }
		}

		protected SimpleQuietPeriodListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SimpleQuietPeriodListener']/constructor[@name='SimpleQuietPeriodListener' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public SimpleQuietPeriodListener (long p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleQuietPeriodListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", new JValue (p0));
				return;
			}

			if (id_ctor_J == IntPtr.Zero)
				id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, new JValue (p0));
		}

		static Delegate cb_blockUntilQuiet;
#pragma warning disable 0169
		static Delegate GetBlockUntilQuietHandler ()
		{
			if (cb_blockUntilQuiet == null)
				cb_blockUntilQuiet = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BlockUntilQuiet);
			return cb_blockUntilQuiet;
		}

		static void n_BlockUntilQuiet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SimpleQuietPeriodListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SimpleQuietPeriodListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockUntilQuiet ();
		}
#pragma warning restore 0169

		static IntPtr id_blockUntilQuiet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SimpleQuietPeriodListener']/method[@name='blockUntilQuiet' and count(parameter)=0]"
		[Register ("blockUntilQuiet", "()V", "GetBlockUntilQuietHandler")]
		public virtual void BlockUntilQuiet ()
		{
			if (id_blockUntilQuiet == IntPtr.Zero)
				id_blockUntilQuiet = JNIEnv.GetMethodID (class_ref, "blockUntilQuiet", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_blockUntilQuiet);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_blockUntilQuiet);
		}

		static Delegate cb_breakSilence;
#pragma warning disable 0169
		static Delegate GetBreakSilenceHandler ()
		{
			if (cb_breakSilence == null)
				cb_breakSilence = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BreakSilence);
			return cb_breakSilence;
		}

		static void n_BreakSilence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SimpleQuietPeriodListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SimpleQuietPeriodListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BreakSilence ();
		}
#pragma warning restore 0169

		static IntPtr id_breakSilence;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SimpleQuietPeriodListener']/method[@name='breakSilence' and count(parameter)=0]"
		[Register ("breakSilence", "()V", "GetBreakSilenceHandler")]
		public virtual void BreakSilence ()
		{
			if (id_breakSilence == IntPtr.Zero)
				id_breakSilence = JNIEnv.GetMethodID (class_ref, "breakSilence", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_breakSilence);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_breakSilence);
		}

	}
}
