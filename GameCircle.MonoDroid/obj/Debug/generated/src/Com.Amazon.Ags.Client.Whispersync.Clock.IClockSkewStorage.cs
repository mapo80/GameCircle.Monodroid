using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Clock {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/interface[@name='ClockSkewStorage']"
	[Register ("com/amazon/ags/client/whispersync/clock/ClockSkewStorage", "", "Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorageInvoker")]
	public partial interface IClockSkewStorage : IJavaObject {

		long ClockSkew {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/interface[@name='ClockSkewStorage']/method[@name='getClockSkew' and count(parameter)=0]"
			[Register ("getClockSkew", "()J", "GetGetClockSkewHandler:Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorageInvoker, GameCircle.MonoDroid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.clock']/interface[@name='ClockSkewStorage']/method[@name='setClockSkew' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setClockSkew", "(J)V", "GetSetClockSkew_JHandler:Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorageInvoker, GameCircle.MonoDroid")] set;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/clock/ClockSkewStorage", DoNotGenerateAcw=true)]
	internal class IClockSkewStorageInvoker : global::Java.Lang.Object, IClockSkewStorage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/clock/ClockSkewStorage");
		IntPtr class_ref;

		public static IClockSkewStorage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClockSkewStorage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.clock.ClockSkewStorage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClockSkewStorageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IClockSkewStorageInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Clock.IClockSkewStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClockSkew = p0;
		}
#pragma warning restore 0169

		IntPtr id_getClockSkew;
		IntPtr id_setClockSkew_J;
		public long ClockSkew {
			get {
				if (id_getClockSkew == IntPtr.Zero)
					id_getClockSkew = JNIEnv.GetMethodID (class_ref, "getClockSkew", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getClockSkew);
			}
			set {
				if (id_setClockSkew_J == IntPtr.Zero)
					id_setClockSkew_J = JNIEnv.GetMethodID (class_ref, "setClockSkew", "(J)V");
				JNIEnv.CallVoidMethod (Handle, id_setClockSkew_J, new JValue (value));
			}
		}

	}

}
