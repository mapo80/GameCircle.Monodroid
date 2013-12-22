using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']"
	[Register ("com/amazon/insights/core/system/DeviceDetails", "", "com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker")]
	public partial interface IDeviceDetails : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']/method[@name='locale' and count(parameter)=0]"
		[Register ("locale", "()Ljava/util/Locale;", "GetLocaleHandler:com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker, AmazonInsights.MonoDroid")]
		global::Java.Util.Locale Locale ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']/method[@name='manufacturer' and count(parameter)=0]"
		[Register ("manufacturer", "()Ljava/lang/String;", "GetManufacturerHandler:com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker, AmazonInsights.MonoDroid")]
		string Manufacturer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']/method[@name='model' and count(parameter)=0]"
		[Register ("model", "()Ljava/lang/String;", "GetModelHandler:com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker, AmazonInsights.MonoDroid")]
		string Model ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']/method[@name='platform' and count(parameter)=0]"
		[Register ("platform", "()Ljava/lang/String;", "GetPlatformHandler:com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker, AmazonInsights.MonoDroid")]
		string Platform ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='DeviceDetails']/method[@name='platformVersion' and count(parameter)=0]"
		[Register ("platformVersion", "()Ljava/lang/String;", "GetPlatformVersionHandler:com.amazon.insights.core.system.amazon.IDeviceDetailsInvoker, AmazonInsights.MonoDroid")]
		string PlatformVersion ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/system/DeviceDetails", DoNotGenerateAcw=true)]
	internal class IDeviceDetailsInvoker : global::Java.Lang.Object, IDeviceDetails {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/system/DeviceDetails");
		IntPtr class_ref;

		public static IDeviceDetails GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceDetails> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.system.DeviceDetails"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceDetailsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeviceDetailsInvoker); }
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
			global::com.amazon.insights.core.system.amazon.IDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Locale ());
		}
#pragma warning restore 0169

		IntPtr id_locale;
		public global::Java.Util.Locale Locale ()
		{
			if (id_locale == IntPtr.Zero)
				id_locale = JNIEnv.GetMethodID (class_ref, "locale", "()Ljava/util/Locale;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod (Handle, id_locale), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacturer ());
		}
#pragma warning restore 0169

		IntPtr id_manufacturer;
		public string Manufacturer ()
		{
			if (id_manufacturer == IntPtr.Zero)
				id_manufacturer = JNIEnv.GetMethodID (class_ref, "manufacturer", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_manufacturer), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model ());
		}
#pragma warning restore 0169

		IntPtr id_model;
		public string Model ()
		{
			if (id_model == IntPtr.Zero)
				id_model = JNIEnv.GetMethodID (class_ref, "model", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_model), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Platform ());
		}
#pragma warning restore 0169

		IntPtr id_platform;
		public string Platform ()
		{
			if (id_platform == IntPtr.Zero)
				id_platform = JNIEnv.GetMethodID (class_ref, "platform", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_platform), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IDeviceDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformVersion ());
		}
#pragma warning restore 0169

		IntPtr id_platformVersion;
		public string PlatformVersion ()
		{
			if (id_platformVersion == IntPtr.Zero)
				id_platformVersion = JNIEnv.GetMethodID (class_ref, "platformVersion", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_platformVersion), JniHandleOwnership.TransferLocalRef);
		}

	}

}
