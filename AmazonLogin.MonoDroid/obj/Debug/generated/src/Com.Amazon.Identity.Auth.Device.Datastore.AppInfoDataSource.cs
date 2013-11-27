using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Datastore {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/AppInfoDataSource", DoNotGenerateAcw=true)]
	public sealed partial class AppInfoDataSource : global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/datastore/AppInfoDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppInfoDataSource); }
		}

		internal AppInfoDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLogTag;
		public override string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get {
				if (id_getLogTag == IntPtr.Zero)
					id_getLogTag = JNIEnv.GetMethodID (class_ref, "getLogTag", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTableName;
		public override string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
			get {
				if (id_getTableName == IntPtr.Zero)
					id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_cursorToObject_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='cursorToObject' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public override global::Java.Lang.Object CursorToObject (global::Android.Database.ICursor p0)
		{
			if (id_cursorToObject_Landroid_database_Cursor_ == IntPtr.Zero)
				id_cursorToObject_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_cursorToObject_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_deleteByAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='deleteByAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteByAppId", "(Ljava/lang/String;)I", "")]
		public int DeleteByAppId (string p0)
		{
			if (id_deleteByAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteByAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteByAppId", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_deleteByAppId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_deleteByPackageName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='deleteByPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteByPackageName", "(Ljava/lang/String;)I", "")]
		public int DeleteByPackageName (string p0)
		{
			if (id_deleteByPackageName_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteByPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteByPackageName", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_deleteByPackageName_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByAppFamilyId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='findByAppFamilyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAppFamilyId", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> FindByAppFamilyId (string p0)
		{
			if (id_findByAppFamilyId_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAppFamilyId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAppFamilyId", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> __ret = global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByAppFamilyId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='findByAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAppId", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo FindByAppId (string p0)
		{
			if (id_findByAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAppId", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_findByAppId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByAppVariantId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='findByAppVariantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAppVariantId", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo FindByAppVariantId (string p0)
		{
			if (id_findByAppVariantId_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAppVariantId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAppVariantId", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_findByAppVariantId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByPackageName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='findByPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByPackageName", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo FindByPackageName (string p0)
		{
			if (id_findByPackageName_Ljava_lang_String_ == IntPtr.Zero)
				id_findByPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByPackageName", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_findByPackageName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByPrimaryKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='findByPrimaryKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByPrimaryKey", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo FindByPrimaryKey (string p0)
		{
			if (id_findByPrimaryKey_Ljava_lang_String_ == IntPtr.Zero)
				id_findByPrimaryKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByPrimaryKey", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_findByPrimaryKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAllColumns;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='getAllColumns' and count(parameter)=0]"
		[Register ("getAllColumns", "()[Ljava/lang/String;", "")]
		public override string[] GetAllColumns ()
		{
			if (id_getAllColumns == IntPtr.Zero)
				id_getAllColumns = JNIEnv.GetMethodID (class_ref, "getAllColumns", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllColumns), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='AppInfoDataSource']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AppInfoDataSource;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Datastore.AppInfoDataSource GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AppInfoDataSource;");
			global::Com.Amazon.Identity.Auth.Device.Datastore.AppInfoDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AppInfoDataSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
