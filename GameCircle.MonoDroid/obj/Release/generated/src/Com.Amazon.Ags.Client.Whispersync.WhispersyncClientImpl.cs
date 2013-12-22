using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/WhispersyncClientImpl", DoNotGenerateAcw=true)]
	public sealed partial class WhispersyncClientImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/WhispersyncClientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncClientImpl); }
		}

		internal WhispersyncClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/constructor[@name='WhispersyncClientImpl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.storage.StringObfuscator'] and parameter[3][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public WhispersyncClientImpl (global::Android.Content.Context p0, global::Com.Amazon.Ags.Storage.IStringObfuscator p1, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncClientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getGameData;
		public global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GameData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='getGameData' and count(parameter)=0]"
			[Register ("getGameData", "()Lcom/amazon/ags/api/whispersync/GameDataMap;", "GetGetGameDataHandler")]
			get {
				if (id_getGameData == IntPtr.Zero)
					id_getGameData = JNIEnv.GetMethodID (class_ref, "getGameData", "()Lcom/amazon/ags/api/whispersync/GameDataMap;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap> (JNIEnv.CallObjectMethod  (Handle, id_getGameData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_hasSuccessfullySynchronized;
		public static bool HasSuccessfullySynchronized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='hasSuccessfullySynchronized' and count(parameter)=0]"
			[Register ("hasSuccessfullySynchronized", "()Z", "GetHasSuccessfullySynchronizedHandler")]
			get {
				if (id_hasSuccessfullySynchronized == IntPtr.Zero)
					id_hasSuccessfullySynchronized = JNIEnv.GetStaticMethodID (class_ref, "hasSuccessfullySynchronized", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasSuccessfullySynchronized);
			}
		}

		static IntPtr id_getInstance;
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncClientImpl Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/amazon/ags/client/whispersync/WhispersyncClientImpl;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/amazon/ags/client/whispersync/WhispersyncClientImpl;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncClientImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_flush);
		}

		static IntPtr id_initialize_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.storage.StringObfuscator'] and parameter[3][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public static void Initialize (global::Android.Content.Context p0, global::Com.Amazon.Ags.Storage.IStringObfuscator p1, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p2)
		{
			if (id_initialize_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='migrateVersion1GameData' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.migration.MigrationCallback']]"
		[Register ("migrateVersion1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V", "")]
		public void MigrateVersion1GameData (global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback p0)
		{
			if (id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ == IntPtr.Zero)
				id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ = JNIEnv.GetMethodID (class_ref, "migrateVersion1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_, new JValue (p0));
		}

		static IntPtr id_setNetworkDependencies_Lcom_amazon_ags_html5_comm_NetworkClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_session_SessionClient_Lorg_apache_http_client_HttpClient_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_javascript_event_JavascriptEventsManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='setNetworkDependencies' and count(parameter)=6 and parameter[1][@type='com.amazon.ags.html5.comm.NetworkClient'] and parameter[2][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[3][@type='com.amazon.ags.client.session.SessionClient'] and parameter[4][@type='org.apache.http.client.HttpClient'] and parameter[5][@type='com.amazon.ags.auth.AuthManager'] and parameter[6][@type='com.amazon.ags.html5.javascript.event.JavascriptEventsManager']]"
		[Register ("setNetworkDependencies", "(Lcom/amazon/ags/html5/comm/NetworkClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/session/SessionClient;Lorg/apache/http/client/HttpClient;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/javascript/event/JavascriptEventsManager;)V", "")]
		public void SetNetworkDependencies (global::Com.Amazon.Ags.Html5.Comm.INetworkClient p0, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p1, global::Com.Amazon.Ags.Client.Session.SessionClient p2, global::Org.Apache.Http.Client.IHttpClient p3, global::Com.Amazon.Ags.Auth.AuthManager p4, global::Com.Amazon.Ags.Html5.Javascript.Event.JavascriptEventsManager p5)
		{
			if (id_setNetworkDependencies_Lcom_amazon_ags_html5_comm_NetworkClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_session_SessionClient_Lorg_apache_http_client_HttpClient_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_javascript_event_JavascriptEventsManager_ == IntPtr.Zero)
				id_setNetworkDependencies_Lcom_amazon_ags_html5_comm_NetworkClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_session_SessionClient_Lorg_apache_http_client_HttpClient_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_javascript_event_JavascriptEventsManager_ = JNIEnv.GetMethodID (class_ref, "setNetworkDependencies", "(Lcom/amazon/ags/html5/comm/NetworkClient;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/session/SessionClient;Lorg/apache/http/client/HttpClient;Lcom/amazon/ags/auth/AuthManager;Lcom/amazon/ags/html5/javascript/event/JavascriptEventsManager;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setNetworkDependencies_Lcom_amazon_ags_html5_comm_NetworkClient_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_session_SessionClient_Lorg_apache_http_client_HttpClient_Lcom_amazon_ags_auth_AuthManager_Lcom_amazon_ags_html5_javascript_event_JavascriptEventsManager_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='setWhispersyncEventListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.WhispersyncEventListener']]"
		[Register ("setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V", "")]
		public void SetWhispersyncEventListener (global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0)
		{
			if (id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ == IntPtr.Zero)
				id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ = JNIEnv.GetMethodID (class_ref, "setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_, new JValue (p0));
		}

		static IntPtr id_syncPassively;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='syncPassively' and count(parameter)=0]"
		[Register ("syncPassively", "()V", "")]
		public static void SyncPassively ()
		{
			if (id_syncPassively == IntPtr.Zero)
				id_syncPassively = JNIEnv.GetStaticMethodID (class_ref, "syncPassively", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_syncPassively);
		}

		static IntPtr id_synchronize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "")]
		public void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetMethodID (class_ref, "synchronize", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_synchronize);
		}

		static IntPtr id_synchronizeOnInitialization;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='synchronizeOnInitialization' and count(parameter)=0]"
		[Register ("synchronizeOnInitialization", "()V", "")]
		public void SynchronizeOnInitialization ()
		{
			if (id_synchronizeOnInitialization == IntPtr.Zero)
				id_synchronizeOnInitialization = JNIEnv.GetMethodID (class_ref, "synchronizeOnInitialization", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_synchronizeOnInitialization);
		}

		static IntPtr id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncClientImpl']/method[@name='unpackVersion1MultiFileGameData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("unpackVersion1MultiFileGameData", "([BLjava/io/File;)V", "")]
		public void UnpackVersion1MultiFileGameData (byte[] p0, global::Java.IO.File p1)
		{
			if (id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ == IntPtr.Zero)
				id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ = JNIEnv.GetMethodID (class_ref, "unpackVersion1MultiFileGameData", "([BLjava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
