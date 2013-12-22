using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='CloudSynchronizer']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/CloudSynchronizer", DoNotGenerateAcw=true)]
	public partial class CloudSynchronizer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/CloudSynchronizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudSynchronizer); }
		}

		protected CloudSynchronizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_storage_RemoteStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='CloudSynchronizer']/constructor[@name='CloudSynchronizer' and count(parameter)=6 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap'] and parameter[2][@type='com.amazon.ags.client.whispersync.storage.LocalStorage'] and parameter[3][@type='com.amazon.ags.client.whispersync.storage.RemoteStorage'] and parameter[4][@type='com.amazon.ags.client.whispersync.SyncRequestState'] and parameter[5][@type='com.amazon.ags.client.whispersync.WhispersyncEventPoster'] and parameter[6][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/storage/RemoteStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public CloudSynchronizer (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0, global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage p1, global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage p2, global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState p3, global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster p4, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CloudSynchronizer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/storage/RemoteStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/storage/RemoteStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_storage_RemoteStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_storage_RemoteStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/storage/RemoteStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_storage_RemoteStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_storage_RemoteStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static Delegate cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
#pragma warning disable 0169
		static Delegate GetSetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_Handler ()
		{
			if (cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == null)
				cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_);
			return cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		}

		static void n_SetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventCollectorClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='CloudSynchronizer']/method[@name='setEventCollectorClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register ("setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "GetSetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_Handler")]
		public virtual void SetEventCollectorClient (global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0)
		{
			if (id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
		}

		static Delegate cb_syncToCloud;
#pragma warning disable 0169
		static Delegate GetSyncToCloudHandler ()
		{
			if (cb_syncToCloud == null)
				cb_syncToCloud = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncToCloud);
			return cb_syncToCloud;
		}

		static void n_SyncToCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncToCloud ();
		}
#pragma warning restore 0169

		static IntPtr id_syncToCloud;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='CloudSynchronizer']/method[@name='syncToCloud' and count(parameter)=0]"
		[Register ("syncToCloud", "()V", "GetSyncToCloudHandler")]
		public virtual void SyncToCloud ()
		{
			if (id_syncToCloud == IntPtr.Zero)
				id_syncToCloud = JNIEnv.GetMethodID (class_ref, "syncToCloud", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncToCloud);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncToCloud);
		}

	}
}
