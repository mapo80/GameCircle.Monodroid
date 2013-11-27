using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='QuietPeriodListener']"
	[Register ("com/amazon/ags/client/whispersync/QuietPeriodListener", "", "Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListenerInvoker")]
	public partial interface IQuietPeriodListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='QuietPeriodListener']/method[@name='blockUntilQuiet' and count(parameter)=0]"
		[Register ("blockUntilQuiet", "()V", "GetBlockUntilQuietHandler:Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListenerInvoker, GameCircle.MonoDroid")]
		void BlockUntilQuiet ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='QuietPeriodListener']/method[@name='breakSilence' and count(parameter)=0]"
		[Register ("breakSilence", "()V", "GetBreakSilenceHandler:Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListenerInvoker, GameCircle.MonoDroid")]
		void BreakSilence ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/QuietPeriodListener", DoNotGenerateAcw=true)]
	internal class IQuietPeriodListenerInvoker : global::Java.Lang.Object, IQuietPeriodListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/QuietPeriodListener");
		IntPtr class_ref;

		public static IQuietPeriodListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQuietPeriodListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.QuietPeriodListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQuietPeriodListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IQuietPeriodListenerInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockUntilQuiet ();
		}
#pragma warning restore 0169

		IntPtr id_blockUntilQuiet;
		public void BlockUntilQuiet ()
		{
			if (id_blockUntilQuiet == IntPtr.Zero)
				id_blockUntilQuiet = JNIEnv.GetMethodID (class_ref, "blockUntilQuiet", "()V");
			JNIEnv.CallVoidMethod (Handle, id_blockUntilQuiet);
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
			global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BreakSilence ();
		}
#pragma warning restore 0169

		IntPtr id_breakSilence;
		public void BreakSilence ()
		{
			if (id_breakSilence == IntPtr.Zero)
				id_breakSilence = JNIEnv.GetMethodID (class_ref, "breakSilence", "()V");
			JNIEnv.CallVoidMethod (Handle, id_breakSilence);
		}

	}

	[global::Android.Runtime.Register ("mono/com/amazon/ags/client/whispersync/QuietPeriodListenerImplementor")]
	internal sealed class IQuietPeriodListenerImplementor : global::Java.Lang.Object, IQuietPeriodListener {

		object sender;

		public IQuietPeriodListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/client/whispersync/QuietPeriodListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler BlockUntilQuietHandler;
#pragma warning restore 0649

		public void BlockUntilQuiet ()
		{
			var __h = BlockUntilQuietHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler BreakSilenceHandler;
#pragma warning restore 0649

		public void BreakSilence ()
		{
			var __h = BreakSilenceHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IQuietPeriodListenerImplementor value)
		{
			return value.BlockUntilQuietHandler == null && value.BreakSilenceHandler == null;
		}
	}

}
