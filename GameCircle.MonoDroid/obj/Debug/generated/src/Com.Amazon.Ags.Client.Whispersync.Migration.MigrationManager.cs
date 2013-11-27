using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/migration/MigrationManager", DoNotGenerateAcw=true)]
	public sealed partial class MigrationManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/migration/MigrationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MigrationManager); }
		}

		internal MigrationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_migration_MigrationHttpClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationManager']/constructor[@name='MigrationManager' and count(parameter)=4 and parameter[1][@type='com.amazon.ags.client.whispersync.migration.MigrationHttpClient'] and parameter[2][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[3][@type='com.amazon.ags.client.whispersync.settings.WhispersyncUserSettingsManager'] and parameter[4][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/migration/MigrationHttpClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public MigrationManager (global::Com.Amazon.Ags.Client.Whispersync.Migration.MigrationHttpClient p0, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p1, global::Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManager p2, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MigrationManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/migration/MigrationHttpClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/migration/MigrationHttpClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_migration_MigrationHttpClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_migration_MigrationHttpClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/migration/MigrationHttpClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_migration_MigrationHttpClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_migration_MigrationHttpClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_downloadV1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationManager']/method[@name='downloadV1GameData' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.migration.MigrationCallback']]"
		[Register ("downloadV1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V", "")]
		public void DownloadV1GameData (global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback p0)
		{
			if (id_downloadV1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ == IntPtr.Zero)
				id_downloadV1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ = JNIEnv.GetMethodID (class_ref, "downloadV1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_downloadV1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_, new JValue (p0));
		}

		static IntPtr id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationManager']/method[@name='setEventCollectorClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register ("setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public void SetEventCollectorClient (global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0)
		{
			if (id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
		}

		static IntPtr id_unpackV1MultiFileGameData_arrayBLjava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationManager']/method[@name='unpackV1MultiFileGameData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("unpackV1MultiFileGameData", "([BLjava/io/File;)V", "")]
		public void UnpackV1MultiFileGameData (byte[] p0, global::Java.IO.File p1)
		{
			if (id_unpackV1MultiFileGameData_arrayBLjava_io_File_ == IntPtr.Zero)
				id_unpackV1MultiFileGameData_arrayBLjava_io_File_ = JNIEnv.GetMethodID (class_ref, "unpackV1MultiFileGameData", "([BLjava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_unpackV1MultiFileGameData_arrayBLjava_io_File_, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
