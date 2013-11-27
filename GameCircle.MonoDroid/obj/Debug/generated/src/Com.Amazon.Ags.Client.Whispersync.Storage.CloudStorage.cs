using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='CloudStorage']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/storage/CloudStorage", DoNotGenerateAcw=true)]
	public partial class CloudStorage : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/storage/CloudStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudStorage); }
		}

		protected CloudStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_network_WhispersyncHttpClient_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_whispersync_clock_GameDataServiceSyncedClock_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='CloudStorage']/constructor[@name='CloudStorage' and count(parameter)=5 and parameter[1][@type='com.amazon.ags.client.whispersync.network.WhispersyncHttpClient'] and parameter[2][@type='com.amazon.ags.client.whispersync.marshaller.GameDataMarshaller'] and parameter[3][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[4][@type='com.amazon.ags.client.whispersync.settings.WhispersyncUserSettingsManager'] and parameter[5][@type='com.amazon.ags.client.whispersync.clock.GameDataServiceSyncedClock']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncHttpClient;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock;)V", "")]
		public CloudStorage (global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient p0, global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller p1, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p2, global::Com.Amazon.Ags.Client.Whispersync.Settings.IWhispersyncUserSettingsManager p3, global::Com.Amazon.Ags.Client.Whispersync.Clock.GameDataServiceSyncedClock p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CloudStorage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/network/WhispersyncHttpClient;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/network/WhispersyncHttpClient;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_network_WhispersyncHttpClient_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_whispersync_clock_GameDataServiceSyncedClock_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_network_WhispersyncHttpClient_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_whispersync_clock_GameDataServiceSyncedClock_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncHttpClient;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/client/whispersync/settings/WhispersyncUserSettingsManager;Lcom/amazon/ags/client/whispersync/clock/GameDataServiceSyncedClock;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_network_WhispersyncHttpClient_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_whispersync_clock_GameDataServiceSyncedClock_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_network_WhispersyncHttpClient_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_client_whispersync_settings_WhispersyncUserSettingsManager_Lcom_amazon_ags_client_whispersync_clock_GameDataServiceSyncedClock_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_canCallService;
#pragma warning disable 0169
		static Delegate GetCanCallServiceHandler ()
		{
			if (cb_canCallService == null)
				cb_canCallService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanCallService);
			return cb_canCallService;
		}

		static bool n_CanCallService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanCallService ();
		}
#pragma warning restore 0169

		static IntPtr id_canCallService;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='CloudStorage']/method[@name='canCallService' and count(parameter)=0]"
		[Register ("canCallService", "()Z", "GetCanCallServiceHandler")]
		public virtual bool CanCallService ()
		{
			if (id_canCallService == IntPtr.Zero)
				id_canCallService = JNIEnv.GetMethodID (class_ref, "canCallService", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canCallService);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_canCallService);
		}

		static Delegate cb_retrieve_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetrieve_Ljava_lang_String_Handler ()
		{
			if (cb_retrieve_Ljava_lang_String_ == null)
				cb_retrieve_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Retrieve_Ljava_lang_String_);
			return cb_retrieve_Ljava_lang_String_;
		}

		static IntPtr n_Retrieve_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Retrieve (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_retrieve_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='CloudStorage']/method[@name='retrieve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retrieve", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/storage/GameData;", "GetRetrieve_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Retrieve (string p0)
		{
			if (id_retrieve_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieve_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieve", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/storage/GameData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallObjectMethod  (Handle, id_retrieve_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_retrieve_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_save_Lcom_amazon_ags_client_whispersync_storage_GameData_;
#pragma warning disable 0169
		static Delegate GetSave_Lcom_amazon_ags_client_whispersync_storage_GameData_Handler ()
		{
			if (cb_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ == null)
				cb_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Lcom_amazon_ags_client_whispersync_storage_GameData_);
			return cb_save_Lcom_amazon_ags_client_whispersync_storage_GameData_;
		}

		static IntPtr n_Save_Lcom_amazon_ags_client_whispersync_storage_GameData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.CloudStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Save (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='CloudStorage']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.storage.GameData']]"
		[Register ("save", "(Lcom/amazon/ags/client/whispersync/storage/GameData;)Lcom/amazon/ags/client/whispersync/storage/GameData;", "GetSave_Lcom_amazon_ags_client_whispersync_storage_GameData_Handler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Save (global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData p0)
		{
			if (id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ == IntPtr.Zero)
				id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ = JNIEnv.GetMethodID (class_ref, "save", "(Lcom/amazon/ags/client/whispersync/storage/GameData;)Lcom/amazon/ags/client/whispersync/storage/GameData;");

			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallObjectMethod  (Handle, id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
