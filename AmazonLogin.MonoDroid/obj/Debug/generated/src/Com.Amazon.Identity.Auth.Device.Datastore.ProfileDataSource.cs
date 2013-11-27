using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Datastore {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/ProfileDataSource", DoNotGenerateAcw=true)]
	public partial class ProfileDataSource : global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/datastore/ProfileDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileDataSource); }
		}

		protected ProfileDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/constructor[@name='ProfileDataSource' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register (".ctor", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public ProfileDataSource (global::Android.Database.Sqlite.SQLiteDatabase p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfileDataSource)) {
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
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LogTag);
		}
#pragma warning restore 0169

		static IntPtr id_getLogTag;
		public override string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get {
				if (id_getLogTag == IntPtr.Zero)
					id_getLogTag = JNIEnv.GetMethodID (class_ref, "getLogTag", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogTag), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLogTag), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TableName);
		}
#pragma warning restore 0169

		static IntPtr id_getTableName;
		public override string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
			get {
				if (id_getTableName == IntPtr.Zero)
					id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTableName), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CursorToObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cursorToObject_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='cursorToObject' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/Profile;", "GetCursorToObject_Landroid_database_Cursor_Handler")]
		public override global::Java.Lang.Object CursorToObject (global::Android.Database.ICursor p0)
		{
			if (id_cursorToObject_Landroid_database_Cursor_ == IntPtr.Zero)
				id_cursorToObject_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/Profile;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_cursorToObject_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_cursorToObject_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllColumns ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllColumns;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='getAllColumns' and count(parameter)=0]"
		[Register ("getAllColumns", "()[Ljava/lang/String;", "GetGetAllColumnsHandler")]
		public override string[] GetAllColumns ()
		{
			if (id_getAllColumns == IntPtr.Zero)
				id_getAllColumns = JNIEnv.GetMethodID (class_ref, "getAllColumns", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllColumns), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAllColumns), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/ProfileDataSource;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/ProfileDataSource;");
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProfile_Ljava_lang_String_Handler ()
		{
			if (cb_getProfile_Ljava_lang_String_ == null)
				cb_getProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProfile_Ljava_lang_String_);
			return cb_getProfile_Ljava_lang_String_;
		}

		static IntPtr n_GetProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProfile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='ProfileDataSource']/method[@name='getProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProfile", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/Profile;", "GetGetProfile_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile GetProfile (string p0)
		{
			if (id_getProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_getProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProfile", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/Profile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (JNIEnv.CallObjectMethod  (Handle, id_getProfile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProfile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
