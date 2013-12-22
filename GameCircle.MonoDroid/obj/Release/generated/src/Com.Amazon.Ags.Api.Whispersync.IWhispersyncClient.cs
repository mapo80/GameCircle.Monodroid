using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']"
	[Register ("com/amazon/ags/api/whispersync/WhispersyncClient", "", "Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker")]
	public partial interface IWhispersyncClient : IJavaObject {

		global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GameData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='getGameData' and count(parameter)=0]"
			[Register ("getGameData", "()Lcom/amazon/ags/api/whispersync/GameDataMap;", "GetGetGameDataHandler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='migrateVersion1GameData' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.migration.MigrationCallback']]"
		[Register ("migrateVersion1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V", "GetMigrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_Handler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")]
		void MigrateVersion1GameData (global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='setWhispersyncEventListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.WhispersyncEventListener']]"
		[Register ("setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V", "GetSetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_Handler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")]
		void SetWhispersyncEventListener (global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "GetSynchronizeHandler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")]
		void Synchronize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/interface[@name='WhispersyncClient']/method[@name='unpackVersion1MultiFileGameData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("unpackVersion1MultiFileGameData", "([BLjava/io/File;)V", "GetUnpackVersion1MultiFileGameData_arrayBLjava_io_File_Handler:Com.Amazon.Ags.Api.Whispersync.IWhispersyncClientInvoker, GameCircle.MonoDroid")]
		void UnpackVersion1MultiFileGameData (byte[] p0, global::Java.IO.File p1);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/WhispersyncClient", DoNotGenerateAcw=true)]
	internal class IWhispersyncClientInvoker : global::Java.Lang.Object, IWhispersyncClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/WhispersyncClient");
		IntPtr class_ref;

		public static IWhispersyncClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWhispersyncClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.WhispersyncClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWhispersyncClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWhispersyncClientInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GameData);
		}
#pragma warning restore 0169

		IntPtr id_getGameData;
		public global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GameData {
			get {
				if (id_getGameData == IntPtr.Zero)
					id_getGameData = JNIEnv.GetMethodID (class_ref, "getGameData", "()Lcom/amazon/ags/api/whispersync/GameDataMap;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap> (JNIEnv.CallObjectMethod (Handle, id_getGameData), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (Handle, id_flush);
		}

		static Delegate cb_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_;
#pragma warning disable 0169
		static Delegate GetMigrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_Handler ()
		{
			if (cb_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ == null)
				cb_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MigrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_);
			return cb_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_;
		}

		static void n_MigrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback p0 = (global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MigrateVersion1GameData (p0);
		}
#pragma warning restore 0169

		IntPtr id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_;
		public void MigrateVersion1GameData (global::Com.Amazon.Ags.Api.Whispersync.Migration.IMigrationCallback p0)
		{
			if (id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ == IntPtr.Zero)
				id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_ = JNIEnv.GetMethodID (class_ref, "migrateVersion1GameData", "(Lcom/amazon/ags/api/whispersync/migration/MigrationCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_migrateVersion1GameData_Lcom_amazon_ags_api_whispersync_migration_MigrationCallback_, new JValue (p0));
		}

		static Delegate cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
#pragma warning disable 0169
		static Delegate GetSetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_Handler ()
		{
			if (cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ == null)
				cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_);
			return cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
		}

		static void n_SetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWhispersyncEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
		public void SetWhispersyncEventListener (global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0)
		{
			if (id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ == IntPtr.Zero)
				id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ = JNIEnv.GetMethodID (class_ref, "setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_, new JValue (p0));
		}

		static Delegate cb_synchronize;
#pragma warning disable 0169
		static Delegate GetSynchronizeHandler ()
		{
			if (cb_synchronize == null)
				cb_synchronize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Synchronize);
			return cb_synchronize;
		}

		static void n_Synchronize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Synchronize ();
		}
#pragma warning restore 0169

		IntPtr id_synchronize;
		public void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetMethodID (class_ref, "synchronize", "()V");
			JNIEnv.CallVoidMethod (Handle, id_synchronize);
		}

		static Delegate cb_unpackVersion1MultiFileGameData_arrayBLjava_io_File_;
#pragma warning disable 0169
		static Delegate GetUnpackVersion1MultiFileGameData_arrayBLjava_io_File_Handler ()
		{
			if (cb_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ == null)
				cb_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnpackVersion1MultiFileGameData_arrayBLjava_io_File_);
			return cb_unpackVersion1MultiFileGameData_arrayBLjava_io_File_;
		}

		static void n_UnpackVersion1MultiFileGameData_arrayBLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IWhispersyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnpackVersion1MultiFileGameData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_;
		public void UnpackVersion1MultiFileGameData (byte[] p0, global::Java.IO.File p1)
		{
			if (id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ == IntPtr.Zero)
				id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_ = JNIEnv.GetMethodID (class_ref, "unpackVersion1MultiFileGameData", "([BLjava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_unpackVersion1MultiFileGameData_arrayBLjava_io_File_, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
