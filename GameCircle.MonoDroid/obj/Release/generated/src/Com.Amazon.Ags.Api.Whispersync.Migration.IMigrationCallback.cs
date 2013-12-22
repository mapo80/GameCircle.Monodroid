using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Migration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/interface[@name='MigrationCallback']"
	[Register ("com/amazon/ags/api/whispersync/migration/MigrationCallback", "", "Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallbackInvoker")]
	public partial interface IMigrationCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.migration']/interface[@name='MigrationCallback']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.whispersync.migration.MigrationResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;[B)V", "GetOnComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayBHandler:Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallbackInvoker, GameCircle.MonoDroid")]
		void OnComplete (global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/migration/MigrationCallback", DoNotGenerateAcw=true)]
	internal class IMigrationCallbackInvoker : global::Java.Lang.Object, IMigrationCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/migration/MigrationCallback");
		IntPtr class_ref;

		public static IMigrationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMigrationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.migration.MigrationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMigrationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMigrationCallbackInvoker); }
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayBHandler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB == null)
				cb_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB);
			return cb_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnComplete (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB;
		public void OnComplete (global::Com.Amazon.Ags.Api.Whispersync.Migration.MigrationResultCode p0, byte[] p1)
		{
			if (id_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/whispersync/migration/MigrationResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_Lcom_amazon_ags_api_whispersync_migration_MigrationResultCode_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
