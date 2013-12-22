using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/SQLiteOfflineEventStorage", DoNotGenerateAcw=true)]
	public partial class SQLiteOfflineEventStorage : global::Android.Database.Sqlite.SQLiteOpenHelper, global::Com.Amazon.Ags.Storage.IOfflineEventStorage {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/SQLiteOfflineEventStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteOfflineEventStorage); }
		}

		protected SQLiteOfflineEventStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/constructor[@name='SQLiteOfflineEventStorage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.storage.StringObfuscator'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Ljava/lang/String;)V", "")]
		public SQLiteOfflineEventStorage (global::Android.Content.Context p0, global::Com.Amazon.Ags.Storage.IStringObfuscator p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (SQLiteOfflineEventStorage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Ljava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/amazon/ags/storage/StringObfuscator;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amazon_ags_storage_StringObfuscator_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_getAllEvents;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple> AllEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='getAllEvents' and count(parameter)=0]"
			[Register ("getAllEvents", "()Ljava/util/List;", "GetGetAllEventsHandler")]
			get {
				if (id_getAllEvents == IntPtr.Zero)
					id_getAllEvents = JNIEnv.GetMethodID (class_ref, "getAllEvents", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllEvents), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSize;
		public int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getSize);
			}
		}

		static IntPtr id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='getEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("getEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)Lorg/json/JSONObject;", "")]
		public global::Org.Json.JSONObject GetEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0)
		{
			if (id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ == IntPtr.Zero)
				id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNIEnv.GetMethodID (class_ref, "getEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)Lorg/json/JSONObject;");
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public override sealed void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "")]
		public override sealed void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_peekEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='peekEvent' and count(parameter)=0]"
		[Register ("peekEvent", "()Lcom/amazon/ags/storage/OfflineEventId;", "")]
		public global::Com.Amazon.Ags.Storage.OfflineEventId PeekEvent ()
		{
			if (id_peekEvent == IntPtr.Zero)
				id_peekEvent = JNIEnv.GetMethodID (class_ref, "peekEvent", "()Lcom/amazon/ags/storage/OfflineEventId;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod  (Handle, id_peekEvent), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_removeAllEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='removeAllEvents' and count(parameter)=0]"
		[Register ("removeAllEvents", "()V", "")]
		public void RemoveAllEvents ()
		{
			if (id_removeAllEvents == IntPtr.Zero)
				id_removeAllEvents = JNIEnv.GetMethodID (class_ref, "removeAllEvents", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_removeAllEvents);
		}

		static IntPtr id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V", "")]
		public void RemoveEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0)
		{
			if (id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ == IntPtr.Zero)
				id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNIEnv.GetMethodID (class_ref, "removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0));
		}

		static IntPtr id_storeEvent_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='SQLiteOfflineEventStorage']/method[@name='storeEvent' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("storeEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/storage/OfflineEventId;", "")]
		public global::Com.Amazon.Ags.Storage.OfflineEventId StoreEvent (global::Org.Json.JSONObject p0)
		{
			if (id_storeEvent_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_storeEvent_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "storeEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/storage/OfflineEventId;");
			global::Com.Amazon.Ags.Storage.OfflineEventId __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod  (Handle, id_storeEvent_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
