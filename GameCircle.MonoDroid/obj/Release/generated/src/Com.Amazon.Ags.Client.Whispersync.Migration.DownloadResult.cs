using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='DownloadResult']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/migration/DownloadResult", DoNotGenerateAcw=true)]
	public partial class DownloadResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/migration/DownloadResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadResult); }
		}

		protected DownloadResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLcom_amazon_ags_api_whispersync_migration_MigrationResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='DownloadResult']/constructor[@name='DownloadResult' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.amazon.ags.api.whispersync.migration.MigrationResultCode']]"
		[Register (".ctor", "([BLcom/amazon/ags/api/whispersync/migration/MigrationResultCode;)V", "")]
		public DownloadResult (byte[] p0, global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (DownloadResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLcom/amazon/ags/api/whispersync/migration/MigrationResultCode;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLcom/amazon/ags/api/whispersync/migration/MigrationResultCode;)V", new JValue (native_p0), new JValue (p1));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayBLcom_amazon_ags_api_whispersync_migration_MigrationResultCode_ == IntPtr.Zero)
				id_ctor_arrayBLcom_amazon_ags_api_whispersync_migration_MigrationResultCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLcom/amazon/ags/api/whispersync/migration/MigrationResultCode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLcom_amazon_ags_api_whispersync_migration_MigrationResultCode_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLcom_amazon_ags_api_whispersync_migration_MigrationResultCode_, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultCode);
			return cb_getResultCode;
		}

		static IntPtr n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultCode);
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		public virtual global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='DownloadResult']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (JNIEnv.CallObjectMethod  (Handle, id_getResultCode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResultCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGameData;
#pragma warning disable 0169
		static Delegate GetGetGameDataHandler ()
		{
			if (cb_getGameData == null)
				cb_getGameData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGameData);
			return cb_getGameData;
		}

		static IntPtr n_GetGameData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGameData ());
		}
#pragma warning restore 0169

		static IntPtr id_getGameData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='DownloadResult']/method[@name='getGameData' and count(parameter)=0]"
		[Register ("getGameData", "()[B", "GetGetGameDataHandler")]
		public virtual byte[] GetGameData ()
		{
			if (id_getGameData == IntPtr.Zero)
				id_getGameData = JNIEnv.GetMethodID (class_ref, "getGameData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getGameData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getGameData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}
}
