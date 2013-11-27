using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/system/AndroidSystem", DoNotGenerateAcw=true)]
	public partial class AndroidSystem : global::Java.Lang.Object, global::com.amazon.insights.core.system.amazon.ISystem {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/system/AndroidSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidSystem); }
		}

		protected AndroidSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_insights_InsightsCredentials_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/constructor[@name='AndroidSystem' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.insights.InsightsCredentials']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/insights/InsightsCredentials;)V", "")]
		public AndroidSystem (global::Android.Content.Context p0, global::Com.Amazon.Insights.IInsightsCredentials p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AndroidSystem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/insights/InsightsCredentials;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/insights/InsightsCredentials;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_insights_InsightsCredentials_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_insights_InsightsCredentials_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/insights/InsightsCredentials;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_insights_InsightsCredentials_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_insights_InsightsCredentials_, new JValue (p0), new JValue (p1));
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
			global::com.amazon.insights.core.system.amazon.AndroidSystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppDetails);
		}
#pragma warning restore 0169

		static IntPtr id_getAppDetails;
		public virtual global::com.amazon.insights.core.system.amazon.IAppDetails AppDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/method[@name='getAppDetails' and count(parameter)=0]"
			[Register ("getAppDetails", "()Lcom/amazon/insights/core/system/AppDetails;", "GetGetAppDetailsHandler")]
			get {
				if (id_getAppDetails == IntPtr.Zero)
					id_getAppDetails = JNIEnv.GetMethodID (class_ref, "getAppDetails", "()Lcom/amazon/insights/core/system/AppDetails;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (JNIEnv.CallObjectMethod  (Handle, id_getAppDetails), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppDetails), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.AndroidSystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connectivity);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectivity;
		public virtual global::com.amazon.insights.core.system.amazon.IConnectivity Connectivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/method[@name='getConnectivity' and count(parameter)=0]"
			[Register ("getConnectivity", "()Lcom/amazon/insights/core/system/Connectivity;", "GetGetConnectivityHandler")]
			get {
				if (id_getConnectivity == IntPtr.Zero)
					id_getConnectivity = JNIEnv.GetMethodID (class_ref, "getConnectivity", "()Lcom/amazon/insights/core/system/Connectivity;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (JNIEnv.CallObjectMethod  (Handle, id_getConnectivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConnectivity), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.AndroidSystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceDetails);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceDetails;
		public virtual global::com.amazon.insights.core.system.amazon.IDeviceDetails DeviceDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/method[@name='getDeviceDetails' and count(parameter)=0]"
			[Register ("getDeviceDetails", "()Lcom/amazon/insights/core/system/DeviceDetails;", "GetGetDeviceDetailsHandler")]
			get {
				if (id_getDeviceDetails == IntPtr.Zero)
					id_getDeviceDetails = JNIEnv.GetMethodID (class_ref, "getDeviceDetails", "()Lcom/amazon/insights/core/system/DeviceDetails;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceDetails), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IDeviceDetails> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceDetails), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.AndroidSystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileManager);
		}
#pragma warning restore 0169

		static IntPtr id_getFileManager;
		public virtual global::com.amazon.insights.core.system.amazon.IFileManager FileManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/method[@name='getFileManager' and count(parameter)=0]"
			[Register ("getFileManager", "()Lcom/amazon/insights/core/system/FileManager;", "GetGetFileManagerHandler")]
			get {
				if (id_getFileManager == IntPtr.Zero)
					id_getFileManager = JNIEnv.GetMethodID (class_ref, "getFileManager", "()Lcom/amazon/insights/core/system/FileManager;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IFileManager> (JNIEnv.CallObjectMethod  (Handle, id_getFileManager), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IFileManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getFileManager), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.AndroidSystem __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences;
		public virtual global::com.amazon.insights.core.system.amazon.IPreferences Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidSystem']/method[@name='getPreferences' and count(parameter)=0]"
			[Register ("getPreferences", "()Lcom/amazon/insights/core/system/Preferences;", "GetGetPreferencesHandler")]
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetMethodID (class_ref, "getPreferences", "()Lcom/amazon/insights/core/system/Preferences;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getPreferences), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPreferences), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
