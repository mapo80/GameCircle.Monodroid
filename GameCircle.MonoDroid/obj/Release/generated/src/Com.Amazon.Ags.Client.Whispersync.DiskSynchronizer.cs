using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/DiskSynchronizer", DoNotGenerateAcw=true)]
	public partial class DiskSynchronizer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/DiskSynchronizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskSynchronizer); }
		}

		protected DiskSynchronizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_QuietPeriodListener_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/constructor[@name='DiskSynchronizer' and count(parameter)=6 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap'] and parameter[2][@type='com.amazon.ags.client.whispersync.storage.LocalStorage'] and parameter[3][@type='com.amazon.ags.client.whispersync.SyncRequestState'] and parameter[4][@type='com.amazon.ags.client.whispersync.QuietPeriodListener'] and parameter[5][@type='com.amazon.ags.client.whispersync.WhispersyncEventPoster'] and parameter[6][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/QuietPeriodListener;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public DiskSynchronizer (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0, global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage p1, global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState p2, global::Com.Amazon.Ags.Client.Whispersync.IQuietPeriodListener p3, global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster p4, global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DiskSynchronizer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/QuietPeriodListener;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/QuietPeriodListener;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_QuietPeriodListener_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_QuietPeriodListener_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Lcom/amazon/ags/client/whispersync/storage/LocalStorage;Lcom/amazon/ags/client/whispersync/SyncRequestState;Lcom/amazon/ags/client/whispersync/QuietPeriodListener;Lcom/amazon/ags/client/whispersync/WhispersyncEventPoster;Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_QuietPeriodListener_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Lcom_amazon_ags_client_whispersync_storage_LocalStorage_Lcom_amazon_ags_client_whispersync_SyncRequestState_Lcom_amazon_ags_client_whispersync_QuietPeriodListener_Lcom_amazon_ags_client_whispersync_WhispersyncEventPoster_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static Delegate cb_loadFromDisk;
#pragma warning disable 0169
		static Delegate GetLoadFromDiskHandler ()
		{
			if (cb_loadFromDisk == null)
				cb_loadFromDisk = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadFromDisk);
			return cb_loadFromDisk;
		}

		static void n_LoadFromDisk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadFromDisk ();
		}
#pragma warning restore 0169

		static IntPtr id_loadFromDisk;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/method[@name='loadFromDisk' and count(parameter)=0]"
		[Register ("loadFromDisk", "()V", "GetLoadFromDiskHandler")]
		public virtual void LoadFromDisk ()
		{
			if (id_loadFromDisk == IntPtr.Zero)
				id_loadFromDisk = JNIEnv.GetMethodID (class_ref, "loadFromDisk", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadFromDisk);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadFromDisk);
		}

		static Delegate cb_notifyDataChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataChangedHandler ()
		{
			if (cb_notifyDataChanged == null)
				cb_notifyDataChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataChanged);
			return cb_notifyDataChanged;
		}

		static void n_NotifyDataChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/method[@name='notifyDataChanged' and count(parameter)=0]"
		[Register ("notifyDataChanged", "()V", "GetNotifyDataChangedHandler")]
		public virtual void NotifyDataChanged ()
		{
			if (id_notifyDataChanged == IntPtr.Zero)
				id_notifyDataChanged = JNIEnv.GetMethodID (class_ref, "notifyDataChanged", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyDataChanged);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyDataChanged);
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
			global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventCollectorClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/method[@name='setEventCollectorClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
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

		static Delegate cb_syncToDisk;
#pragma warning disable 0169
		static Delegate GetSyncToDiskHandler ()
		{
			if (cb_syncToDisk == null)
				cb_syncToDisk = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncToDisk);
			return cb_syncToDisk;
		}

		static void n_SyncToDisk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncToDisk ();
		}
#pragma warning restore 0169

		static IntPtr id_syncToDisk;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/method[@name='syncToDisk' and count(parameter)=0]"
		[Register ("syncToDisk", "()V", "GetSyncToDiskHandler")]
		public virtual void SyncToDisk ()
		{
			if (id_syncToDisk == IntPtr.Zero)
				id_syncToDisk = JNIEnv.GetMethodID (class_ref, "syncToDisk", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncToDisk);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncToDisk);
		}

		static Delegate cb_syncToDiskNow;
#pragma warning disable 0169
		static Delegate GetSyncToDiskNowHandler ()
		{
			if (cb_syncToDiskNow == null)
				cb_syncToDiskNow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncToDiskNow);
			return cb_syncToDiskNow;
		}

		static void n_SyncToDiskNow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncToDiskNow ();
		}
#pragma warning restore 0169

		static IntPtr id_syncToDiskNow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='DiskSynchronizer']/method[@name='syncToDiskNow' and count(parameter)=0]"
		[Register ("syncToDiskNow", "()V", "GetSyncToDiskNowHandler")]
		public virtual void SyncToDiskNow ()
		{
			if (id_syncToDiskNow == IntPtr.Zero)
				id_syncToDiskNow = JNIEnv.GetMethodID (class_ref, "syncToDiskNow", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncToDiskNow);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncToDiskNow);
		}

	}
}
