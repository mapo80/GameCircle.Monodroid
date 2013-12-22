using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Storage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='RemoteStorage']"
	[Register ("com/amazon/ags/client/whispersync/storage/RemoteStorage", "", "Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorageInvoker")]
	public partial interface IRemoteStorage : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='RemoteStorage']/method[@name='canCallService' and count(parameter)=0]"
		[Register ("canCallService", "()Z", "GetCanCallServiceHandler:Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorageInvoker, GameCircle.MonoDroid")]
		bool CanCallService ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='RemoteStorage']/method[@name='retrieve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retrieve", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/storage/GameData;", "GetRetrieve_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorageInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Retrieve (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='RemoteStorage']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.storage.GameData']]"
		[Register ("save", "(Lcom/amazon/ags/client/whispersync/storage/GameData;)Lcom/amazon/ags/client/whispersync/storage/GameData;", "GetSave_Lcom_amazon_ags_client_whispersync_storage_GameData_Handler:Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorageInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Save (global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/storage/RemoteStorage", DoNotGenerateAcw=true)]
	internal class IRemoteStorageInvoker : global::Java.Lang.Object, IRemoteStorage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/storage/RemoteStorage");
		IntPtr class_ref;

		public static IRemoteStorage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteStorage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.storage.RemoteStorage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteStorageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRemoteStorageInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanCallService ();
		}
#pragma warning restore 0169

		IntPtr id_canCallService;
		public bool CanCallService ()
		{
			if (id_canCallService == IntPtr.Zero)
				id_canCallService = JNIEnv.GetMethodID (class_ref, "canCallService", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_canCallService);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Retrieve (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_retrieve_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Retrieve (string p0)
		{
			if (id_retrieve_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieve_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieve", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/storage/GameData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallObjectMethod (Handle, id_retrieve_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.IRemoteStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Save (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_;
		public global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData Save (global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData p0)
		{
			if (id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ == IntPtr.Zero)
				id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_ = JNIEnv.GetMethodID (class_ref, "save", "(Lcom/amazon/ags/client/whispersync/storage/GameData;)Lcom/amazon/ags/client/whispersync/storage/GameData;");
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (JNIEnv.CallObjectMethod (Handle, id_save_Lcom_amazon_ags_client_whispersync_storage_GameData_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
