using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/SynchronizationManager", DoNotGenerateAcw=true)]
	public partial class SynchronizationManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/SynchronizationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronizationManager); }
		}

		protected SynchronizationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_DiskSynchronizer_Lcom_amazon_ags_client_whispersync_SyncRequestState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/constructor[@name='SynchronizationManager' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.whispersync.DiskSynchronizer'] and parameter[2][@type='com.amazon.ags.client.whispersync.SyncRequestState']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/DiskSynchronizer;Lcom/amazon/ags/client/whispersync/SyncRequestState;)V", "")]
		public SynchronizationManager (global::Com.Amazon.Ags.Client.Whispersync.DiskSynchronizer p0, global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SynchronizationManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/DiskSynchronizer;Lcom/amazon/ags/client/whispersync/SyncRequestState;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/DiskSynchronizer;Lcom/amazon/ags/client/whispersync/SyncRequestState;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_DiskSynchronizer_Lcom_amazon_ags_client_whispersync_SyncRequestState_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_DiskSynchronizer_Lcom_amazon_ags_client_whispersync_SyncRequestState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/DiskSynchronizer;Lcom/amazon/ags/client/whispersync/SyncRequestState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_DiskSynchronizer_Lcom_amazon_ags_client_whispersync_SyncRequestState_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_DiskSynchronizer_Lcom_amazon_ags_client_whispersync_SyncRequestState_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_flush);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_flush);
		}

		static Delegate cb_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_;
#pragma warning disable 0169
		static Delegate GetSetCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_Handler ()
		{
			if (cb_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_ == null)
				cb_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_);
			return cb_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_;
		}

		static void n_SetCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCloudSynchronizer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='setCloudSynchronizer' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.CloudSynchronizer']]"
		[Register ("setCloudSynchronizer", "(Lcom/amazon/ags/client/whispersync/CloudSynchronizer;)V", "GetSetCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_Handler")]
		public virtual void SetCloudSynchronizer (global::Com.Amazon.Ags.Client.Whispersync.CloudSynchronizer p0)
		{
			if (id_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_ == IntPtr.Zero)
				id_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_ = JNIEnv.GetMethodID (class_ref, "setCloudSynchronizer", "(Lcom/amazon/ags/client/whispersync/CloudSynchronizer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCloudSynchronizer_Lcom_amazon_ags_client_whispersync_CloudSynchronizer_, new JValue (p0));
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
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventCollectorClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='setEventCollectorClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
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

		static Delegate cb_syncActively;
#pragma warning disable 0169
		static Delegate GetSyncActivelyHandler ()
		{
			if (cb_syncActively == null)
				cb_syncActively = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncActively);
			return cb_syncActively;
		}

		static void n_SyncActively (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncActively ();
		}
#pragma warning restore 0169

		static IntPtr id_syncActively;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='syncActively' and count(parameter)=0]"
		[Register ("syncActively", "()V", "GetSyncActivelyHandler")]
		public virtual void SyncActively ()
		{
			if (id_syncActively == IntPtr.Zero)
				id_syncActively = JNIEnv.GetMethodID (class_ref, "syncActively", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncActively);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncActively);
		}

		static Delegate cb_syncFromDiskToMemory;
#pragma warning disable 0169
		static Delegate GetSyncFromDiskToMemoryHandler ()
		{
			if (cb_syncFromDiskToMemory == null)
				cb_syncFromDiskToMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncFromDiskToMemory);
			return cb_syncFromDiskToMemory;
		}

		static void n_SyncFromDiskToMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncFromDiskToMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_syncFromDiskToMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='syncFromDiskToMemory' and count(parameter)=0]"
		[Register ("syncFromDiskToMemory", "()V", "GetSyncFromDiskToMemoryHandler")]
		public virtual void SyncFromDiskToMemory ()
		{
			if (id_syncFromDiskToMemory == IntPtr.Zero)
				id_syncFromDiskToMemory = JNIEnv.GetMethodID (class_ref, "syncFromDiskToMemory", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncFromDiskToMemory);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncFromDiskToMemory);
		}

		static Delegate cb_syncPassively;
#pragma warning disable 0169
		static Delegate GetSyncPassivelyHandler ()
		{
			if (cb_syncPassively == null)
				cb_syncPassively = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncPassively);
			return cb_syncPassively;
		}

		static void n_SyncPassively (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SynchronizationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncPassively ();
		}
#pragma warning restore 0169

		static IntPtr id_syncPassively;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SynchronizationManager']/method[@name='syncPassively' and count(parameter)=0]"
		[Register ("syncPassively", "()V", "GetSyncPassivelyHandler")]
		public virtual void SyncPassively ()
		{
			if (id_syncPassively == IntPtr.Zero)
				id_syncPassively = JNIEnv.GetMethodID (class_ref, "syncPassively", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_syncPassively);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_syncPassively);
		}

	}
}
