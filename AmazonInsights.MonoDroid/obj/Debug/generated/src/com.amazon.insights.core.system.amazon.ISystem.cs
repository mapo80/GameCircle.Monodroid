using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']"
	[Register ("com/amazon/insights/core/system/System", "", "com.amazon.insights.core.system.amazon.ISystemInvoker")]
	public partial interface ISystem : IJavaObject {

		global::com.amazon.insights.core.system.amazon.IAppDetails AppDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']/method[@name='getAppDetails' and count(parameter)=0]"
			[Register ("getAppDetails", "()Lcom/amazon/insights/core/system/AppDetails;", "GetGetAppDetailsHandler:com.amazon.insights.core.system.amazon.ISystemInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::com.amazon.insights.core.system.amazon.IConnectivity Connectivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']/method[@name='getConnectivity' and count(parameter)=0]"
			[Register ("getConnectivity", "()Lcom/amazon/insights/core/system/Connectivity;", "GetGetConnectivityHandler:com.amazon.insights.core.system.amazon.ISystemInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::com.amazon.insights.core.system.amazon.IDeviceDetails DeviceDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']/method[@name='getDeviceDetails' and count(parameter)=0]"
			[Register ("getDeviceDetails", "()Lcom/amazon/insights/core/system/DeviceDetails;", "GetGetDeviceDetailsHandler:com.amazon.insights.core.system.amazon.ISystemInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::com.amazon.insights.core.system.amazon.IFileManager FileManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']/method[@name='getFileManager' and count(parameter)=0]"
			[Register ("getFileManager", "()Lcom/amazon/insights/core/system/FileManager;", "GetGetFileManagerHandler:com.amazon.insights.core.system.amazon.ISystemInvoker, AmazonInsights.MonoDroid")] get;
		}

		global::com.amazon.insights.core.system.amazon.IPreferences Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='System']/method[@name='getPreferences' and count(parameter)=0]"
			[Register ("getPreferences", "()Lcom/amazon/insights/core/system/Preferences;", "GetGetPreferencesHandler:com.amazon.insights.core.system.amazon.ISystemInvoker, AmazonInsights.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/system/System", DoNotGenerateAcw=true)]
	internal class ISystemInvoker : global::Java.Lang.Object, ISystem {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/system/System");
		IntPtr class_ref;

		public static ISystem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISystem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.system.System"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISystemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISystemInvoker); }
		}

		static Delegate cb_getAppDetails;
#pragma warning disable 0169
		static Delegate GetGetAppDetailsHandler ()
		{
			if (cb_getAppDetails == null)
				cb_getAppDetails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppDetails);
			return cb_getAppDetails;
		}

		static IntPtr n_GetAppDetails (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.ISystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppDetails);
		}
#pragma warning restore 0169

		IntPtr id_getAppDetails;
		public global::com.amazon.insights.core.system.amazon.IAppDetails AppDetails {
			get {
				if (id_getAppDetails == IntPtr.Zero)
					id_getAppDetails = JNIEnv.GetMethodID (class_ref, "getAppDetails", "()Lcom/amazon/insights/core/system/AppDetails;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (JNIEnv.CallObjectMethod (Handle, id_getAppDetails), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getConnectivity;
#pragma warning disable 0169
		static Delegate GetGetConnectivityHandler ()
		{
			if (cb_getConnectivity == null)
				cb_getConnectivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectivity);
			return cb_getConnectivity;
		}

		static IntPtr n_GetConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.ISystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connectivity);
		}
#pragma warning restore 0169

		IntPtr id_getConnectivity;
		public global::com.amazon.insights.core.system.amazon.IConnectivity Connectivity {
			get {
				if (id_getConnectivity == IntPtr.Zero)
					id_getConnectivity = JNIEnv.GetMethodID (class_ref, "getConnectivity", "()Lcom/amazon/insights/core/system/Connectivity;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (JNIEnv.CallObjectMethod (Handle, id_getConnectivity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceDetails;
#pragma warning disable 0169
		static Delegate GetGetDeviceDetailsHandler ()
		{
			if (cb_getDeviceDetails == null)
				cb_getDeviceDetails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceDetails);
			return cb_getDeviceDetails;
		}

		static IntPtr n_GetDeviceDetails (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.ISystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceDetails);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceDetails;
		public global::com.amazon.insights.core.system.amazon.IDeviceDetails DeviceDetails {
			get {
				if (id_getDeviceDetails == IntPtr.Zero)
					id_getDeviceDetails = JNIEnv.GetMethodID (class_ref, "getDeviceDetails", "()Lcom/amazon/insights/core/system/DeviceDetails;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (JNIEnv.CallObjectMethod (Handle, id_getDeviceDetails), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFileManager;
#pragma warning disable 0169
		static Delegate GetGetFileManagerHandler ()
		{
			if (cb_getFileManager == null)
				cb_getFileManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileManager);
			return cb_getFileManager;
		}

		static IntPtr n_GetFileManager (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.ISystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileManager);
		}
#pragma warning restore 0169

		IntPtr id_getFileManager;
		public global::com.amazon.insights.core.system.amazon.IFileManager FileManager {
			get {
				if (id_getFileManager == IntPtr.Zero)
					id_getFileManager = JNIEnv.GetMethodID (class_ref, "getFileManager", "()Lcom/amazon/insights/core/system/FileManager;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IFileManager> (JNIEnv.CallObjectMethod (Handle, id_getFileManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPreferences;
#pragma warning disable 0169
		static Delegate GetGetPreferencesHandler ()
		{
			if (cb_getPreferences == null)
				cb_getPreferences = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferences);
			return cb_getPreferences;
		}

		static IntPtr n_GetPreferences (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.ISystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.ISystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		IntPtr id_getPreferences;
		public global::com.amazon.insights.core.system.amazon.IPreferences Preferences {
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetMethodID (class_ref, "getPreferences", "()Lcom/amazon/insights/core/system/Preferences;");
				return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (JNIEnv.CallObjectMethod (Handle, id_getPreferences), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
