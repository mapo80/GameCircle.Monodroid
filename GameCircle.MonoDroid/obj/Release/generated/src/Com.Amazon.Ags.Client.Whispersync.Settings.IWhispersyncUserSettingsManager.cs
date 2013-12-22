using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Settings {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.settings']/interface[@name='WhispersyncUserSettingsManager']"
	[Register ("com/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager", "", "Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManagerInvoker")]
	public partial interface IWhispersyncUserSettingsManager : IJavaObject {

		bool IsWhispersyncEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.settings']/interface[@name='WhispersyncUserSettingsManager']/method[@name='isWhispersyncEnabled' and count(parameter)=0]"
			[Register ("isWhispersyncEnabled", "()Z", "GetIsWhispersyncEnabledHandler:Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManagerInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager", DoNotGenerateAcw=true)]
	internal class IWhispersyncUserSettingsManagerInvoker : global::Java.Lang.Object, IWhispersyncUserSettingsManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager");
		IntPtr class_ref;

		public static IWhispersyncUserSettingsManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWhispersyncUserSettingsManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.settings.WhispersyncUserSettingsManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWhispersyncUserSettingsManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWhispersyncUserSettingsManagerInvoker); }
		}

		static Delegate cb_isWhispersyncEnabled;
#pragma warning disable 0169
		static Delegate GetIsWhispersyncEnabledHandler ()
		{
			if (cb_isWhispersyncEnabled == null)
				cb_isWhispersyncEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWhispersyncEnabled);
			return cb_isWhispersyncEnabled;
		}

		static bool n_IsWhispersyncEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWhispersyncEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isWhispersyncEnabled;
		public bool IsWhispersyncEnabled {
			get {
				if (id_isWhispersyncEnabled == IntPtr.Zero)
					id_isWhispersyncEnabled = JNIEnv.GetMethodID (class_ref, "isWhispersyncEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isWhispersyncEnabled);
			}
		}

	}

}
