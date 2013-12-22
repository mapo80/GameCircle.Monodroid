using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Datastore {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/DatabaseHelper", DoNotGenerateAcw=true)]
	public sealed partial class DatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {


		static IntPtr ISO8601_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='ISO8601']"
		[Register ("ISO8601")]
		public static global::Java.Text.SimpleDateFormat Iso8601 {
			get {
				if (ISO8601_jfieldId == IntPtr.Zero)
					ISO8601_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8601", "Ljava/text/SimpleDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8601_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ISO8601_jfieldId == IntPtr.Zero)
					ISO8601_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8601", "Ljava/text/SimpleDateFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ISO8601_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='MAP_DB_NAME']"
		[Register ("MAP_DB_NAME")]
		public const string MapDbName = (string) "MAPDataStore.db";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfoTable']"
		[Register ("appInfoTable")]
		public const string AppInfoTable = (string) "AppInfo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_AllowedScopes']"
		[Register ("appInfo_AllowedScopes")]
		public const string AppInfoAllowedScopes = (string) "AllowedScopes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_AppFamilyId']"
		[Register ("appInfo_AppFamilyId")]
		public const string AppInfoAppFamilyId = (string) "AppFamilyId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_AppVariantId']"
		[Register ("appInfo_AppVariantId")]
		public const string AppInfoAppVariantId = (string) "AppVariantId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_ClientId']"
		[Register ("appInfo_ClientId")]
		public const string AppInfoClientId = (string) "ClientId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_GrantedPermissions']"
		[Register ("appInfo_GrantedPermissions")]
		public const string AppInfoGrantedPermissions = (string) "GrantedPermissions";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_PackageName']"
		[Register ("appInfo_PackageName")]
		public const string AppInfoPackageName = (string) "PackageName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='appInfo_Payload']"
		[Register ("appInfo_Payload")]
		public const string AppInfoPayload = (string) "Payload";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationCode']"
		[Register ("authorizationCode")]
		public const string AuthorizationCode = (string) "Code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationCodeTable']"
		[Register ("authorizationCodeTable")]
		public const string AuthorizationCodeTable = (string) "AuthorizationCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationCode_AppId']"
		[Register ("authorizationCode_AppId")]
		public const string AuthorizationCodeAppId = (string) "AppId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationCode_AuthorizationTokenId']"
		[Register ("authorizationCode_AuthorizationTokenId")]
		public const string AuthorizationCodeAuthorizationTokenId = (string) "AuthorizationTokenId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationCode_Id']"
		[Register ("authorizationCode_Id")]
		public const string AuthorizationCodeId = (string) "Id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationTokenTable']"
		[Register ("authorizationTokenTable")]
		public const string AuthorizationTokenTable = (string) "AuthorizationToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_AppId']"
		[Register ("authorizationToken_AppId")]
		public const string AuthorizationTokenAppId = (string) "AppId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_CreationTime']"
		[Register ("authorizationToken_CreationTime")]
		public const string AuthorizationTokenCreationTime = (string) "CreationTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_DirectedId']"
		[Register ("authorizationToken_DirectedId")]
		public const string AuthorizationTokenDirectedId = (string) "directedId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_ExpirationTime']"
		[Register ("authorizationToken_ExpirationTime")]
		public const string AuthorizationTokenExpirationTime = (string) "ExpirationTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_Id']"
		[Register ("authorizationToken_Id")]
		public const string AuthorizationTokenId = (string) "Id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_MiscData']"
		[Register ("authorizationToken_MiscData")]
		public const string AuthorizationTokenMiscData = (string) "MiscData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_Token']"
		[Register ("authorizationToken_Token")]
		public const string AuthorizationTokenToken = (string) "Token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='authorizationToken_Type']"
		[Register ("authorizationToken_Type")]
		public const string AuthorizationTokenType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='profileTable']"
		[Register ("profileTable")]
		public const string ProfileTable = (string) "Profile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='profile_AppId']"
		[Register ("profile_AppId")]
		public const string ProfileAppId = (string) "AppId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='profile_Data']"
		[Register ("profile_Data")]
		public const string ProfileData = (string) "Data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='profile_ExpirationTime']"
		[Register ("profile_ExpirationTime")]
		public const string ProfileExpirationTime = (string) "ExpirationTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='profile_Id']"
		[Register ("profile_Id")]
		public const string ProfileId = (string) "Id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScopeTable']"
		[Register ("requestedScopeTable")]
		public const string RequestedScopeTable = (string) "RequestedScope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScope_AppId']"
		[Register ("requestedScope_AppId")]
		public const string RequestedScopeAppId = (string) "AppId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScope_AuthorizationAccessTokenId']"
		[Register ("requestedScope_AuthorizationAccessTokenId")]
		public const string RequestedScopeAuthorizationAccessTokenId = (string) "AtzAccessTokenId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScope_AuthorizationRefreshTokenId']"
		[Register ("requestedScope_AuthorizationRefreshTokenId")]
		public const string RequestedScopeAuthorizationRefreshTokenId = (string) "AtzRefreshTokenId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScope_DirectedId']"
		[Register ("requestedScope_DirectedId")]
		public const string RequestedScopeDirectedId = (string) "DirectedId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/field[@name='requestedScope_Scope']"
		[Register ("requestedScope_Scope")]
		public const string RequestedScopeScope = (string) "Scope";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/datastore/DatabaseHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatabaseHelper); }
		}

		internal DatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/constructor[@name='DatabaseHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public DatabaseHelper (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DatabaseHelper)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_clearAuthorizationState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='clearAuthorizationState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearAuthorizationState", "(Landroid/content/Context;)V", "")]
		public static void ClearAuthorizationState (global::Android.Content.Context p0)
		{
			if (id_clearAuthorizationState_Landroid_content_Context_ == IntPtr.Zero)
				id_clearAuthorizationState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearAuthorizationState", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAuthorizationState_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_clearServiceAuthorizationState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='clearServiceAuthorizationState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearServiceAuthorizationState", "(Landroid/content/Context;)V", "")]
		public static void ClearServiceAuthorizationState (global::Android.Content.Context p0)
		{
			if (id_clearServiceAuthorizationState_Landroid_content_Context_ == IntPtr.Zero)
				id_clearServiceAuthorizationState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearServiceAuthorizationState", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearServiceAuthorizationState_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_doesColumnExist_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='doesColumnExist' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("doesColumnExist", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public bool DoesColumnExist (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string p2)
		{
			if (id_doesColumnExist_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_doesColumnExist_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doesColumnExist", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_doesColumnExist_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public override void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, new JValue (p0));
		}

		static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "")]
		public override void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_truncateFractionalSeconds_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='DatabaseHelper']/method[@name='truncateFractionalSeconds' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("truncateFractionalSeconds", "(Ljava/util/Date;)Ljava/util/Date;", "")]
		public static global::Java.Util.Date TruncateFractionalSeconds (global::Java.Util.Date p0)
		{
			if (id_truncateFractionalSeconds_Ljava_util_Date_ == IntPtr.Zero)
				id_truncateFractionalSeconds_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "truncateFractionalSeconds", "(Ljava/util/Date;)Ljava/util/Date;");
			global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_truncateFractionalSeconds_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
