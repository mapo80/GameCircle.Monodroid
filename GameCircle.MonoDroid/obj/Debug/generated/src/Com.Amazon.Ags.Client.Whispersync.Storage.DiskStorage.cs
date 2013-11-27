using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/storage/DiskStorage", DoNotGenerateAcw=true)]
	public partial class DiskStorage : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Storage.ILocalStorage {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/field[@name='AMAZON_GAMES_DIR_NAME']"
		[Register ("AMAZON_GAMES_DIR_NAME")]
		public const string AmazonGamesDirName = (string) ".amazonGamesService";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/storage/DiskStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskStorage); }
		}

		protected DiskStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_storage_StringObfuscator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/constructor[@name='DiskStorage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.client.whispersync.marshaller.GameDataMarshaller'] and parameter[3][@type='com.amazon.ags.storage.StringObfuscator']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/storage/StringObfuscator;)V", "")]
		public DiskStorage (global::Android.Content.Context p0, global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller p1, global::Com.Amazon.Ags.Storage.IStringObfuscator p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DiskStorage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/storage/StringObfuscator;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/storage/StringObfuscator;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_storage_StringObfuscator_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_storage_StringObfuscator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/ags/client/whispersync/marshaller/GameDataMarshaller;Lcom/amazon/ags/storage/StringObfuscator;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_storage_StringObfuscator_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_client_whispersync_marshaller_GameDataMarshaller_Lcom_amazon_ags_storage_StringObfuscator_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSuccessfullySynchronized;
		}
#pragma warning restore 0169

		static IntPtr id_hasSuccessfullySynchronized;
		public virtual bool HasSuccessfullySynchronized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='hasSuccessfullySynchronized' and count(parameter)=0]"
			[Register ("hasSuccessfullySynchronized", "()Z", "GetHasSuccessfullySynchronizedHandler")]
			get {
				if (id_hasSuccessfullySynchronized == IntPtr.Zero)
					id_hasSuccessfullySynchronized = JNIEnv.GetMethodID (class_ref, "hasSuccessfullySynchronized", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSuccessfullySynchronized);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasSuccessfullySynchronized);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionId);
		}
#pragma warning restore 0169

		static IntPtr id_getVersionId;
		public virtual string VersionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='getVersionId' and count(parameter)=0]"
			[Register ("getVersionId", "()Ljava/lang/String;", "GetGetVersionIdHandler")]
			get {
				if (id_getVersionId == IntPtr.Zero)
					id_getVersionId = JNIEnv.GetMethodID (class_ref, "getVersionId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersionId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutVersionId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putVersionId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='putVersionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putVersionId", "(Ljava/lang/String;)V", "GetPutVersionId_Ljava_lang_String_Handler")]
		public virtual void PutVersionId (string p0)
		{
			if (id_putVersionId_Ljava_lang_String_ == IntPtr.Zero)
				id_putVersionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putVersionId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putVersionId_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_putVersionId_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Retrieve ());
		}
#pragma warning restore 0169

		static IntPtr id_retrieve;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='retrieve' and count(parameter)=0]"
		[Register ("retrieve", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetRetrieveHandler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Retrieve ()
		{
			if (id_retrieve == IntPtr.Zero)
				id_retrieve = JNIEnv.GetMethodID (class_ref, "retrieve", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod  (Handle, id_retrieve), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_retrieve), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Save (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("save", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)I", "GetSave_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler")]
		public virtual int Save (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "save", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_save_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_;
#pragma warning disable 0169
		static Delegate GetSetStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_Handler ()
		{
			if (cb_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_ == null)
				cb_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_);
			return cb_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_;
		}

		static void n_SetStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.DiskStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.IStringObfuscator p0 = (global::Com.Amazon.Ags.Storage.IStringObfuscator)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IStringObfuscator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStringObfuscator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='DiskStorage']/method[@name='setStringObfuscator' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.StringObfuscator']]"
		[Register ("setStringObfuscator", "(Lcom/amazon/ags/storage/StringObfuscator;)V", "GetSetStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_Handler")]
		public virtual void SetStringObfuscator (global::Com.Amazon.Ags.Storage.IStringObfuscator p0)
		{
			if (id_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_ == IntPtr.Zero)
				id_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_ = JNIEnv.GetMethodID (class_ref, "setStringObfuscator", "(Lcom/amazon/ags/storage/StringObfuscator;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setStringObfuscator_Lcom_amazon_ags_storage_StringObfuscator_, new JValue (p0));
		}

	}
}
