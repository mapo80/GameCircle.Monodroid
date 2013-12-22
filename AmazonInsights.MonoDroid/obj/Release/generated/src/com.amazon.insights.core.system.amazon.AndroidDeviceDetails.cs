using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/system/AndroidDeviceDetails", DoNotGenerateAcw=true)]
	public partial class AndroidDeviceDetails : global::Java.Lang.Object, global::com.amazon.insights.core.system.amazon.IDeviceDetails {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/system/AndroidDeviceDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidDeviceDetails); }
		}

		protected AndroidDeviceDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/constructor[@name='AndroidDeviceDetails' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AndroidDeviceDetails () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AndroidDeviceDetails)) {
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

		static Delegate cb_locale;
#pragma warning disable 0169
		static Delegate GetLocaleHandler ()
		{
			if (cb_locale == null)
				cb_locale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Locale);
			return cb_locale;
		}

		static IntPtr n_Locale (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Locale ());
		}
#pragma warning restore 0169

		static IntPtr id_locale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/method[@name='locale' and count(parameter)=0]"
		[Register ("locale", "()Ljava/util/Locale;", "GetLocaleHandler")]
		public virtual global::Java.Util.Locale Locale ()
		{
			if (id_locale == IntPtr.Zero)
				id_locale = JNIEnv.GetMethodID (class_ref, "locale", "()Ljava/util/Locale;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod  (Handle, id_locale), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_locale), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_manufacturer;
#pragma warning disable 0169
		static Delegate GetManufacturerHandler ()
		{
			if (cb_manufacturer == null)
				cb_manufacturer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Manufacturer);
			return cb_manufacturer;
		}

		static IntPtr n_Manufacturer (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacturer ());
		}
#pragma warning restore 0169

		static IntPtr id_manufacturer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/method[@name='manufacturer' and count(parameter)=0]"
		[Register ("manufacturer", "()Ljava/lang/String;", "GetManufacturerHandler")]
		public virtual string Manufacturer ()
		{
			if (id_manufacturer == IntPtr.Zero)
				id_manufacturer = JNIEnv.GetMethodID (class_ref, "manufacturer", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_manufacturer), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_manufacturer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_model;
#pragma warning disable 0169
		static Delegate GetModelHandler ()
		{
			if (cb_model == null)
				cb_model = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Model);
			return cb_model;
		}

		static IntPtr n_Model (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model ());
		}
#pragma warning restore 0169

		static IntPtr id_model;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/method[@name='model' and count(parameter)=0]"
		[Register ("model", "()Ljava/lang/String;", "GetModelHandler")]
		public virtual string Model ()
		{
			if (id_model == IntPtr.Zero)
				id_model = JNIEnv.GetMethodID (class_ref, "model", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_model), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_model), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_platform;
#pragma warning disable 0169
		static Delegate GetPlatformHandler ()
		{
			if (cb_platform == null)
				cb_platform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Platform);
			return cb_platform;
		}

		static IntPtr n_Platform (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Platform ());
		}
#pragma warning restore 0169

		static IntPtr id_platform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/method[@name='platform' and count(parameter)=0]"
		[Register ("platform", "()Ljava/lang/String;", "GetPlatformHandler")]
		public virtual string Platform ()
		{
			if (id_platform == IntPtr.Zero)
				id_platform = JNIEnv.GetMethodID (class_ref, "platform", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_platform), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_platform), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_platformVersion;
#pragma warning disable 0169
		static Delegate GetPlatformVersionHandler ()
		{
			if (cb_platformVersion == null)
				cb_platformVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PlatformVersion);
			return cb_platformVersion;
		}

		static IntPtr n_PlatformVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformVersion ());
		}
#pragma warning restore 0169

		static IntPtr id_platformVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidDeviceDetails']/method[@name='platformVersion' and count(parameter)=0]"
		[Register ("platformVersion", "()Ljava/lang/String;", "GetPlatformVersionHandler")]
		public virtual string PlatformVersion ()
		{
			if (id_platformVersion == IntPtr.Zero)
				id_platformVersion = JNIEnv.GetMethodID (class_ref, "platformVersion", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_platformVersion), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_platformVersion), JniHandleOwnership.TransferLocalRef);
		}

	}
}
