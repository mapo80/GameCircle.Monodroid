using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Storage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']"
	[Register ("com/amazon/ags/client/whispersync/storage/LocalStorage", "", "Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker")]
	public partial interface ILocalStorage : IJavaObject {

		bool HasSuccessfullySynchronized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']/method[@name='hasSuccessfullySynchronized' and count(parameter)=0]"
			[Register ("hasSuccessfullySynchronized", "()Z", "GetHasSuccessfullySynchronizedHandler:Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker, GameCircle.MonoDroid")] get;
		}

		string VersionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']/method[@name='getVersionId' and count(parameter)=0]"
			[Register ("getVersionId", "()Ljava/lang/String;", "GetGetVersionIdHandler:Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']/method[@name='putVersionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putVersionId", "(Ljava/lang/String;)V", "GetPutVersionId_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker, GameCircle.MonoDroid")]
		void PutVersionId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']/method[@name='retrieve' and count(parameter)=0]"
		[Register ("retrieve", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetRetrieveHandler:Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Retrieve ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/interface[@name='LocalStorage']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("save", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)I", "GetSave_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler:Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorageInvoker, GameCircle.MonoDroid")]
		int Save (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/storage/LocalStorage", DoNotGenerateAcw=true)]
	internal class ILocalStorageInvoker : global::Java.Lang.Object, ILocalStorage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/storage/LocalStorage");
		IntPtr class_ref;

		public static ILocalStorage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocalStorage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.storage.LocalStorage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocalStorageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILocalStorageInvoker); }
		}

		static Delegate cb_hasSuccessfullySynchronized;
#pragma warning disable 0169
		static Delegate GetHasSuccessfullySynchronizedHandler ()
		{
			if (cb_hasSuccessfullySynchronized == null)
				cb_hasSuccessfullySynchronized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSuccessfullySynchronized);
			return cb_hasSuccessfullySynchronized;
		}

		static bool n_HasSuccessfullySynchronized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSuccessfullySynchronized;
		}
#pragma warning restore 0169

		IntPtr id_hasSuccessfullySynchronized;
		public bool HasSuccessfullySynchronized {
			get {
				if (id_hasSuccessfullySynchronized == IntPtr.Zero)
					id_hasSuccessfullySynchronized = JNIEnv.GetMethodID (class_ref, "hasSuccessfullySynchronized", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasSuccessfullySynchronized);
			}
		}

		static Delegate cb_getVersionId;
#pragma warning disable 0169
		static Delegate GetGetVersionIdHandler ()
		{
			if (cb_getVersionId == null)
				cb_getVersionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersionId);
			return cb_getVersionId;
		}

		static IntPtr n_GetVersionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionId);
		}
#pragma warning restore 0169

		IntPtr id_getVersionId;
		public string VersionId {
			get {
				if (id_getVersionId == IntPtr.Zero)
					id_getVersionId = JNIEnv.GetMethodID (class_ref, "getVersionId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getVersionId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_putVersionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutVersionId_Ljava_lang_String_Handler ()
		{
			if (cb_putVersionId_Ljava_lang_String_ == null)
				cb_putVersionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutVersionId_Ljava_lang_String_);
			return cb_putVersionId_Ljava_lang_String_;
		}

		static void n_PutVersionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutVersionId (p0);
		}
#pragma warning restore 0169

		IntPtr id_putVersionId_Ljava_lang_String_;
		public void PutVersionId (string p0)
		{
			if (id_putVersionId_Ljava_lang_String_ == IntPtr.Zero)
				id_putVersionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putVersionId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_putVersionId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_retrieve;
#pragma warning disable 0169
		static Delegate GetRetrieveHandler ()
		{
			if (cb_retrieve == null)
				cb_retrieve = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Retrieve);
			return cb_retrieve;
		}

		static IntPtr n_Retrieve (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Retrieve ());
		}
#pragma warning restore 0169

		IntPtr id_retrieve;
		public global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Retrieve ()
		{
			if (id_retrieve == IntPtr.Zero)
				id_retrieve = JNIEnv.GetMethodID (class_ref, "retrieve", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod (Handle, id_retrieve), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
#pragma warning disable 0169
		static Delegate GetSave_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler ()
		{
			if (cb_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == null)
				cb_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_);
			return cb_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		}

		static int n_Save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Save (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		public int Save (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "save", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)I");
			int __ret = JNIEnv.CallIntMethod (Handle, id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0));
			return __ret;
		}

	}

}
