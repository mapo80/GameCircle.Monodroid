using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='GameData']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/storage/GameData", DoNotGenerateAcw=true)]
	public partial class GameData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/storage/GameData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameData); }
		}

		protected GameData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='GameData']/constructor[@name='GameData' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Ljava/lang/String;)V", "")]
		public GameData (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (GameData)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getGameDataMap;
#pragma warning disable 0169
		static Delegate GetGetGameDataMapHandler ()
		{
			if (cb_getGameDataMap == null)
				cb_getGameDataMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGameDataMap);
			return cb_getGameDataMap;
		}

		static IntPtr n_GetGameDataMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GameDataMap);
		}
#pragma warning restore 0169

		static IntPtr id_getGameDataMap;
		public virtual global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap GameDataMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='GameData']/method[@name='getGameDataMap' and count(parameter)=0]"
			[Register ("getGameDataMap", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetGetGameDataMapHandler")]
			get {
				if (id_getGameDataMap == IntPtr.Zero)
					id_getGameDataMap = JNIEnv.GetMethodID (class_ref, "getGameDataMap", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod  (Handle, id_getGameDataMap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getGameDataMap), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Storage.GameData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionId);
		}
#pragma warning restore 0169

		static IntPtr id_getVersionId;
		public virtual string VersionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.storage']/class[@name='GameData']/method[@name='getVersionId' and count(parameter)=0]"
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

	}
}
