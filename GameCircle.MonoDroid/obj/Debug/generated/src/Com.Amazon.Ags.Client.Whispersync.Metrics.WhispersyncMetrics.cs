using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/metrics/WhispersyncMetrics", DoNotGenerateAcw=true)]
	public partial class WhispersyncMetrics : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHIPSERYNC_PARSE_EXCEPTION_METRIC']"
		[Register ("WHIPSERYNC_PARSE_EXCEPTION_METRIC")]
		public const string WhipseryncParseExceptionMetric = (string) "WHISPERSYNC_PARSE_EXCEPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLIENT_NOT_INITIALIZED_METRIC']"
		[Register ("WHISPERSYNC_CLIENT_NOT_INITIALIZED_METRIC")]
		public const string WhispersyncClientNotInitializedMetric = (string) "WHISPERSYNC_CLIENT_NOT_INITIALIZED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLOUD_SYNC_CLIENT_EXCEPTION_METRIC']"
		[Register ("WHISPERSYNC_CLOUD_SYNC_CLIENT_EXCEPTION_METRIC")]
		public const string WhispersyncCloudSyncClientExceptionMetric = (string) "WHISPERSYNC_CLOUD_SYNC_CLIENT_EXCEPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLOUD_SYNC_IO_EXCEPTION_METRIC']"
		[Register ("WHISPERSYNC_CLOUD_SYNC_IO_EXCEPTION_METRIC")]
		public const string WhispersyncCloudSyncIoExceptionMetric = (string) "WHISPERSYNC_CLOUD_SYNC_IO_EXCEPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLOUD_SYNC_NETWORK_EXCEPTION_METRIC']"
		[Register ("WHISPERSYNC_CLOUD_SYNC_NETWORK_EXCEPTION_METRIC")]
		public const string WhispersyncCloudSyncNetworkExceptionMetric = (string) "WHISPERSYNC_CLOUD_SYNC_NETWORK_EXCEPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLOUD_SYNC_SERVER_EXCEPTION_METRIC']"
		[Register ("WHISPERSYNC_CLOUD_SYNC_SERVER_EXCEPTION_METRIC")]
		public const string WhispersyncCloudSyncServerExceptionMetric = (string) "WHISPERSYNC_CLOUD_SYNC_SERVER_EXCEPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_CLOUD_SYNC_THROTTLED_METRIC']"
		[Register ("WHISPERSYNC_CLOUD_SYNC_THROTTLED_METRIC")]
		public const string WhispersyncCloudSyncThrottledMetric = (string) "WHISPERSYNC_CLOUD_SYNC_THROTTLED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_DISK_TO_MEMORY_SYNC_METRIC']"
		[Register ("WHISPERSYNC_DISK_TO_MEMORY_SYNC_METRIC")]
		public const string WhispersyncDiskToMemorySyncMetric = (string) "WHISPERSYNC_DISK_TO_MEMORY_SYNC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_DOWNLOAD_FROM_CLOUD_METRIC']"
		[Register ("WHISPERSYNC_DOWNLOAD_FROM_CLOUD_METRIC")]
		public const string WhispersyncDownloadFromCloudMetric = (string) "WHISPERSYNC_DOWNLOAD_FROM_CLOUD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_FULL_SYNC_METRIC']"
		[Register ("WHISPERSYNC_FULL_SYNC_METRIC")]
		public const string WhispersyncFullSyncMetric = (string) "WHISPERSYNC_FULL_SYNC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_MANUAL_FLUSH_METRIC']"
		[Register ("WHISPERSYNC_MANUAL_FLUSH_METRIC")]
		public const string WhispersyncManualFlushMetric = (string) "WHISPERSYNC_MANUAL_FLUSH";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_MANUAL_SYNC_METRIC']"
		[Register ("WHISPERSYNC_MANUAL_SYNC_METRIC")]
		public const string WhispersyncManualSyncMetric = (string) "WHISPERSYNC_MANUAL_SYNC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_MEMORY_TO_DISK_SYNC_METRIC']"
		[Register ("WHISPERSYNC_MEMORY_TO_DISK_SYNC_METRIC")]
		public const string WhispersyncMemoryToDiskSyncMetric = (string) "WHISPERSYNC_MEMORY_TO_DISK_SYNC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_MERGE_ON_UPLOAD_METRIC']"
		[Register ("WHISPERSYNC_MERGE_ON_UPLOAD_METRIC")]
		public const string WhispersyncMergeOnUploadMetric = (string) "WHISPERSYNC_MERGE_ON_UPLOAD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_SYNCABLE_TYPE_FAILED_MERGE_METRIC']"
		[Register ("WHISPERSYNC_SYNCABLE_TYPE_FAILED_MERGE_METRIC")]
		public const string WhispersyncSyncableTypeFailedMergeMetric = (string) "WHISPERSYNC_SYNCABLE_TYPE_FAILED_MERGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_SYNCABLE_TYPE_UPDATE_FAILURE_METRIC']"
		[Register ("WHISPERSYNC_SYNCABLE_TYPE_UPDATE_FAILURE_METRIC")]
		public const string WhispersyncSyncableTypeUpdateFailureMetric = (string) "WHISPERSYNC_SYNCABLE_TYPE_UPDATE_FAILURE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_UPLOAD_TO_CLOUD_METRIC']"
		[Register ("WHISPERSYNC_UPLOAD_TO_CLOUD_METRIC")]
		public const string WhispersyncUploadToCloudMetric = (string) "WHISPERSYNC_UPLOAD_TO_CLOUD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_MIGRATION_FAILURE_METRIC']"
		[Register ("WHISPERSYNC_V1_MIGRATION_FAILURE_METRIC")]
		public const string WhispersyncV1MigrationFailureMetric = (string) "WHISPERSYNC_V1_MIGRATION_FAILURE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_MIGRATION_METRIC']"
		[Register ("WHISPERSYNC_V1_MIGRATION_METRIC")]
		public const string WhispersyncV1MigrationMetric = (string) "WHISPERSYNC_V1_MIGRATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_MIGRATION_NO_DATA_METRIC']"
		[Register ("WHISPERSYNC_V1_MIGRATION_NO_DATA_METRIC")]
		public const string WhispersyncV1MigrationNoDataMetric = (string) "WHISPERSYNC_V1_MIGRATION_NO_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_MIGRATION_NO_NETWORK_METRIC']"
		[Register ("WHISPERSYNC_V1_MIGRATION_NO_NETWORK_METRIC")]
		public const string WhispersyncV1MigrationNoNetworkMetric = (string) "WHISPERSYNC_V1_MIGRATION_NO_NETWORK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_MIGRATION_WHISPERSYNC_OFF_METRIC']"
		[Register ("WHISPERSYNC_V1_MIGRATION_WHISPERSYNC_OFF_METRIC")]
		public const string WhispersyncV1MigrationWhispersyncOffMetric = (string) "WHISPERSYNC_V1_MIGRATION_WHISPERSYNC_OFF";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetrics']/field[@name='WHISPERSYNC_V1_UNPACK_MULTIFILE_METRIC']"
		[Register ("WHISPERSYNC_V1_UNPACK_MULTIFILE_METRIC")]
		public const string WhispersyncV1UnpackMultifileMetric = (string) "WHISPERSYNC_V1_UNPACK_MULTIFILE";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/metrics/WhispersyncMetrics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncMetrics); }
		}

		protected WhispersyncMetrics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
