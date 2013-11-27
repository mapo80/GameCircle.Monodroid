using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Datastore {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/AbstractDataSource", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDataSource : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/field[@name='INSERT_FAILED']"
		[Register ("INSERT_FAILED")]
		public const int InsertFailed = (int) -1;

		static IntPtr database_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/field[@name='database']"
		[Register ("database")]
		protected global::Android.Database.Sqlite.SQLiteDatabase Database {
			get {
				if (database_jfieldId == IntPtr.Zero)
					database_jfieldId = JNIEnv.GetFieldID (class_ref, "database", "Landroid/database/sqlite/SQLiteDatabase;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, database_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (database_jfieldId == IntPtr.Zero)
					database_jfieldId = JNIEnv.GetFieldID (class_ref, "database", "Landroid/database/sqlite/SQLiteDatabase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, database_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/datastore/AbstractDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataSource); }
		}

		protected AbstractDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/constructor[@name='AbstractDataSource' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register (".ctor", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public AbstractDataSource (global::Android.Database.Sqlite.SQLiteDatabase p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractDataSource)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/database/sqlite/SQLiteDatabase;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/database/sqlite/SQLiteDatabase;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_ctor_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static Delegate cb_getLogTag;
#pragma warning disable 0169
		static Delegate GetGetLogTagHandler ()
		{
			if (cb_getLogTag == null)
				cb_getLogTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogTag);
			return cb_getLogTag;
		}

		static IntPtr n_GetLogTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LogTag);
		}
#pragma warning restore 0169

		public abstract string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")] get;
		}

		static Delegate cb_getTableName;
#pragma warning disable 0169
		static Delegate GetGetTableNameHandler ()
		{
			if (cb_getTableName == null)
				cb_getTableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTableName);
			return cb_getTableName;
		}

		static IntPtr n_GetTableName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TableName);
		}
#pragma warning restore 0169

		public abstract string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")] get;
		}

		static Delegate cb_cursorToObject_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetCursorToObject_Landroid_database_Cursor_Handler ()
		{
			if (cb_cursorToObject_Landroid_database_Cursor_ == null)
				cb_cursorToObject_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CursorToObject_Landroid_database_Cursor_);
			return cb_cursorToObject_Landroid_database_Cursor_;
		}

		static IntPtr n_CursorToObject_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CursorToObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='cursorToObject' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;", "GetCursorToObject_Landroid_database_Cursor_Handler")]
		public abstract global::Java.Lang.Object CursorToObject (global::Android.Database.ICursor p0);

		static Delegate cb_deleteAllRows;
#pragma warning disable 0169
		static Delegate GetDeleteAllRowsHandler ()
		{
			if (cb_deleteAllRows == null)
				cb_deleteAllRows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DeleteAllRows);
			return cb_deleteAllRows;
		}

		static int n_DeleteAllRows (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeleteAllRows ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteAllRows;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='deleteAllRows' and count(parameter)=0]"
		[Register ("deleteAllRows", "()I", "GetDeleteAllRowsHandler")]
		public virtual int DeleteAllRows ()
		{
			if (id_deleteAllRows == IntPtr.Zero)
				id_deleteAllRows = JNIEnv.GetMethodID (class_ref, "deleteAllRows", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_deleteAllRows);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_deleteAllRows);
		}

		static Delegate cb_deleteRow_J;
#pragma warning disable 0169
		static Delegate GetDeleteRow_JHandler ()
		{
			if (cb_deleteRow_J == null)
				cb_deleteRow_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_DeleteRow_J);
			return cb_deleteRow_J;
		}

		static bool n_DeleteRow_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeleteRow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteRow_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='deleteRow' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("deleteRow", "(J)Z", "GetDeleteRow_JHandler")]
		public virtual bool DeleteRow (long p0)
		{
			if (id_deleteRow_J == IntPtr.Zero)
				id_deleteRow_J = JNIEnv.GetMethodID (class_ref, "deleteRow", "(J)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_deleteRow_J, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_deleteRow_J, new JValue (p0));
		}

		static Delegate cb_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteRows_arrayLjava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
				cb_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DeleteRows_arrayLjava_lang_String_arrayLjava_lang_String_);
			return cb_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		static int n_DeleteRows_arrayLjava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.DeleteRows (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='deleteRows' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("deleteRows", "([Ljava/lang/String;[Ljava/lang/String;)I", "GetDeleteRows_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual int DeleteRows (string[] p0, string[] p1)
		{
			if (id_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteRows", "([Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_deleteRows_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DeleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_DeleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteRowsBySingleColumn (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='deleteRowsBySingleColumn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteRowsBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDeleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual int DeleteRowsBySingleColumn (string p0, string p1)
		{
			if (id_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteRowsBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_deleteRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_findAllRows;
#pragma warning disable 0169
		static Delegate GetFindAllRowsHandler ()
		{
			if (cb_findAllRows == null)
				cb_findAllRows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAllRows);
			return cb_findAllRows;
		}

		static IntPtr n_FindAllRows (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.FindAllRows ());
		}
#pragma warning restore 0169

		static IntPtr id_findAllRows;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findAllRows' and count(parameter)=0]"
		[Register ("findAllRows", "()Ljava/util/List;", "GetFindAllRowsHandler")]
		public virtual global::System.Collections.IList FindAllRows ()
		{
			if (id_findAllRows == IntPtr.Zero)
				id_findAllRows = JNIEnv.GetMethodID (class_ref, "findAllRows", "()Ljava/util/List;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAllRows), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findAllRows), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindAllRows_arrayLjava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
				cb_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FindAllRows_arrayLjava_lang_String_arrayLjava_lang_String_);
			return cb_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_FindAllRows_arrayLjava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.FindAllRows (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findAllRows' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("findAllRows", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "GetFindAllRows_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual global::System.Collections.IList FindAllRows (string[] p0, string[] p1)
		{
			if (id_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findAllRows", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::System.Collections.IList __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findAllRows_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FindAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_);
			return cb_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_FindAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.FindAllRowsBySingleColumn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findAllRowsBySingleColumn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("findAllRowsBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetFindAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual global::System.Collections.IList FindAllRowsBySingleColumn (string p0, string p1)
		{
			if (id_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findAllRowsBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::System.Collections.IList __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findAllRowsBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_findByRowId_J;
#pragma warning disable 0169
		static Delegate GetFindByRowId_JHandler ()
		{
			if (cb_findByRowId_J == null)
				cb_findByRowId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_FindByRowId_J);
			return cb_findByRowId_J;
		}

		static IntPtr n_FindByRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindByRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_findByRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findByRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findByRowId", "(J)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;", "GetFindByRowId_JHandler")]
		public virtual global::Java.Lang.Object FindByRowId (long p0)
		{
			if (id_findByRowId_J == IntPtr.Zero)
				id_findByRowId_J = JNIEnv.GetMethodID (class_ref, "findByRowId", "(J)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_findByRowId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findByRowId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindOneRow_arrayLjava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
				cb_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FindOneRow_arrayLjava_lang_String_arrayLjava_lang_String_);
			return cb_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_FindOneRow_arrayLjava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindOneRow (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findOneRow' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("findOneRow", "([Ljava/lang/String;[Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;", "GetFindOneRow_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual global::Java.Lang.Object FindOneRow (string[] p0, string[] p1)
		{
			if (id_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findOneRow", "([Ljava/lang/String;[Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findOneRow_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FindOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_);
			return cb_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_FindOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindOneRowBySingleColumn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='findOneRowBySingleColumn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("findOneRowBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;", "GetFindOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual global::Java.Lang.Object FindOneRowBySingleColumn (string p0, string p1)
		{
			if (id_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findOneRowBySingleColumn", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findOneRowBySingleColumn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getAllColumns;
#pragma warning disable 0169
		static Delegate GetGetAllColumnsHandler ()
		{
			if (cb_getAllColumns == null)
				cb_getAllColumns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllColumns);
			return cb_getAllColumns;
		}

		static IntPtr n_GetAllColumns (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllColumns ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getAllColumns' and count(parameter)=0]"
		[Register ("getAllColumns", "()[Ljava/lang/String;", "GetGetAllColumnsHandler")]
		public abstract string[] GetAllColumns ();

		static Delegate cb_getColumnIndex_Landroid_database_Cursor_I;
#pragma warning disable 0169
		static Delegate GetGetColumnIndex_Landroid_database_Cursor_IHandler ()
		{
			if (cb_getColumnIndex_Landroid_database_Cursor_I == null)
				cb_getColumnIndex_Landroid_database_Cursor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetColumnIndex_Landroid_database_Cursor_I);
			return cb_getColumnIndex_Landroid_database_Cursor_I;
		}

		static int n_GetColumnIndex_Landroid_database_Cursor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColumnIndex (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnIndex_Landroid_database_Cursor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getColumnIndex' and count(parameter)=2 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='int']]"
		[Register ("getColumnIndex", "(Landroid/database/Cursor;I)I", "GetGetColumnIndex_Landroid_database_Cursor_IHandler")]
		public virtual int GetColumnIndex (global::Android.Database.ICursor p0, int p1)
		{
			if (id_getColumnIndex_Landroid_database_Cursor_I == IntPtr.Zero)
				id_getColumnIndex_Landroid_database_Cursor_I = JNIEnv.GetMethodID (class_ref, "getColumnIndex", "(Landroid/database/Cursor;I)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getColumnIndex_Landroid_database_Cursor_I, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getColumnIndex_Landroid_database_Cursor_I, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_;
#pragma warning disable 0169
		static Delegate GetInsertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_Handler ()
		{
			if (cb_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_ == null)
				cb_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InsertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_);
			return cb_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_;
		}

		static long n_InsertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InsertRow (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='insertRow' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("insertRow", "(Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;)J", "GetInsertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_Handler")]
		public virtual long InsertRow (global::Java.Lang.Object p0)
		{
			if (id_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_ == IntPtr.Zero)
				id_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_ = JNIEnv.GetMethodID (class_ref, "insertRow", "(Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;)J");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_insertRow_Lcom_amazon_identity_auth_device_dataobject_AbstractDataObject_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_updateRow_JLandroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetUpdateRow_JLandroid_content_ContentValues_Handler ()
		{
			if (cb_updateRow_JLandroid_content_ContentValues_ == null)
				cb_updateRow_JLandroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_UpdateRow_JLandroid_content_ContentValues_);
			return cb_updateRow_JLandroid_content_ContentValues_;
		}

		static bool n_UpdateRow_JLandroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateRow (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateRow_JLandroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='updateRow' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("updateRow", "(JLandroid/content/ContentValues;)Z", "GetUpdateRow_JLandroid_content_ContentValues_Handler")]
		public virtual bool UpdateRow (long p0, global::Android.Content.ContentValues p1)
		{
			if (id_updateRow_JLandroid_content_ContentValues_ == IntPtr.Zero)
				id_updateRow_JLandroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "updateRow", "(JLandroid/content/ContentValues;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateRow_JLandroid_content_ContentValues_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_updateRow_JLandroid_content_ContentValues_, new JValue (p0), new JValue (p1));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/AbstractDataSource", DoNotGenerateAcw=true)]
	internal partial class AbstractDataSourceInvoker : AbstractDataSource {

		public AbstractDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataSourceInvoker); }
		}

		static IntPtr id_getLogTag;
		public override string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get {
				if (id_getLogTag == IntPtr.Zero)
					id_getLogTag = JNIEnv.GetMethodID (class_ref, "getLogTag", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTableName;
		public override string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
			get {
				if (id_getTableName == IntPtr.Zero)
					id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_cursorToObject_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='cursorToObject' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;", "GetCursorToObject_Landroid_database_Cursor_Handler")]
		public override global::Java.Lang.Object CursorToObject (global::Android.Database.ICursor p0)
		{
			if (id_cursorToObject_Landroid_database_Cursor_ == IntPtr.Zero)
				id_cursorToObject_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/AbstractDataObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_cursorToObject_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAllColumns;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AbstractDataSource']/method[@name='getAllColumns' and count(parameter)=0]"
		[Register ("getAllColumns", "()[Ljava/lang/String;", "GetGetAllColumnsHandler")]
		public override string[] GetAllColumns ()
		{
			if (id_getAllColumns == IntPtr.Zero)
				id_getAllColumns = JNIEnv.GetMethodID (class_ref, "getAllColumns", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllColumns), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}

}
