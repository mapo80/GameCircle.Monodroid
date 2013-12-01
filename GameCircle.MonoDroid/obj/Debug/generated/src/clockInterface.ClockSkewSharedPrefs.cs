using System;
using System.Collections.Generic;
using Android.Runtime;

namespace clockInterface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockSkewSharedPrefs']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/ClockSkewSharedPrefs", DoNotGenerateAcw=true)]
	public partial class ClockSkewSharedPrefs : global::Java.Lang.Object, global::clockInterface.IClockSkewStorage {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/ClockSkewSharedPrefs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClockSkewSharedPrefs); }
		}

		protected ClockSkewSharedPrefs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockSkewSharedPrefs']/constructor[@name='ClockSkewSharedPrefs' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ClockSkewSharedPrefs (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClockSkewSharedPrefs)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getClockSkew;
#pragma warning disable 0169
		static Delegate GetGetClockSkewHandler ()
		{
			if (cb_getClockSkew == null)
				cb_getClockSkew = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetClockSkew);
			return cb_getClockSkew;
		}

		static long n_GetClockSkew (IntPtr jnienv, IntPtr native__this)
		{
			global::clockInterface.ClockSkewSharedPrefs __this = global::Java.Lang.Object.GetObject<global::clockInterface.ClockSkewSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClockSkew;
		}
#pragma warning restore 0169

		static Delegate cb_setClockSkew_J;
#pragma warning disable 0169
		static Delegate GetSetClockSkew_JHandler ()
		{
			if (cb_setClockSkew_J == null)
				cb_setClockSkew_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetClockSkew_J);
			return cb_setClockSkew_J;
		}

		static void n_SetClockSkew_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::clockInterface.ClockSkewSharedPrefs __this = global::Java.Lang.Object.GetObject<global::clockInterface.ClockSkewSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClockSkew = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClockSkew;
		static IntPtr id_setClockSkew_J;
		public virtual long ClockSkew {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockSkewSharedPrefs']/method[@name='getClockSkew' and count(parameter)=0]"
			[Register ("getClockSkew", "()J", "GetGetClockSkewHandler")]
			get {
				if (id_getClockSkew == IntPtr.Zero)
					id_getClockSkew = JNIEnv.GetMethodID (class_ref, "getClockSkew", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getClockSkew);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getClockSkew);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/class[@name='ClockSkewSharedPrefs']/method[@name='setClockSkew' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setClockSkew", "(J)V", "GetSetClockSkew_JHandler")]
			set {
				if (id_setClockSkew_J == IntPtr.Zero)
					id_setClockSkew_J = JNIEnv.GetMethodID (class_ref, "setClockSkew", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClockSkew_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setClockSkew_J, new JValue (value));
			}
		}

	}
}
