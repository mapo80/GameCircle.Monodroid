using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Datastore {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/datastore/RequestedScopeDataSource", DoNotGenerateAcw=true)]
	public sealed partial class RequestedScopeDataSource : global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/datastore/RequestedScopeDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestedScopeDataSource); }
		}

		internal RequestedScopeDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLogTag;
		public override string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get {
				if (id_getLogTag == IntPtr.Zero)
					id_getLogTag = JNIEnv.GetMethodID (class_ref, "getLogTag", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTableName;
		public override string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
			get {
				if (id_getTableName == IntPtr.Zero)
					id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_cursorToObject_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='cursorToObject' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope;", "")]
		public override global::Java.Lang.Object CursorToObject (global::Android.Database.ICursor p0)
		{
			if (id_cursorToObject_Landroid_database_Cursor_ == IntPtr.Zero)
				id_cursorToObject_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "cursorToObject", "(Landroid/database/Cursor;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope;");
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_cursorToObject_Landroid_database_Cursor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_deleteByAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='deleteByAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_deleteByDirectedId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='deleteByDirectedId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteByDirectedId", "(Ljava/lang/String;)I", "")]
		public int DeleteByDirectedId (string p0)
		{
			if (id_deleteByDirectedId_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteByDirectedId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteByDirectedId", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_deleteByDirectedId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_deleteByScope_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='deleteByScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteByScope", "(Ljava/lang/String;)I", "")]
		public int DeleteByScope (string p0)
		{
			if (id_deleteByScope_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteByScope_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteByScope", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_deleteByScope_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAppId", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> FindByAppId (string p0)
		{
			if (id_findByAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAppId", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> __ret = global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByAppId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByAuthorizationAccessTokenId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByAuthorizationAccessTokenId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findByAuthorizationAccessTokenId", "(J)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> FindByAuthorizationAccessTokenId (long p0)
		{
			if (id_findByAuthorizationAccessTokenId_J == IntPtr.Zero)
				id_findByAuthorizationAccessTokenId_J = JNIEnv.GetMethodID (class_ref, "findByAuthorizationAccessTokenId", "(J)Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByAuthorizationAccessTokenId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_findByAuthorizationRefreshTokenId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByAuthorizationRefreshTokenId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findByAuthorizationRefreshTokenId", "(J)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> FindByAuthorizationRefreshTokenId (long p0)
		{
			if (id_findByAuthorizationRefreshTokenId_J == IntPtr.Zero)
				id_findByAuthorizationRefreshTokenId_J = JNIEnv.GetMethodID (class_ref, "findByAuthorizationRefreshTokenId", "(J)Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByAuthorizationRefreshTokenId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_findByDirectedId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByDirectedId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByDirectedId", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> FindByDirectedId (string p0)
		{
			if (id_findByDirectedId_Ljava_lang_String_ == IntPtr.Zero)
				id_findByDirectedId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByDirectedId", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> __ret = global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByDirectedId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findByPrimaryKey_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByPrimaryKey' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("findByPrimaryKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope;", "")]
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope FindByPrimaryKey (string p0, string p1, string p2)
		{
			if (id_findByPrimaryKey_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_findByPrimaryKey_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByPrimaryKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (JNIEnv.CallObjectMethod  (Handle, id_findByPrimaryKey_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_findByScope_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='findByScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByScope", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> FindByScope (string p0)
		{
			if (id_findByScope_Ljava_lang_String_ == IntPtr.Zero)
				id_findByScope_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByScope", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> __ret = global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByScope_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAllColumns;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='getAllColumns' and count(parameter)=0]"
		[Register ("getAllColumns", "()[Ljava/lang/String;", "")]
		public override string[] GetAllColumns ()
		{
			if (id_getAllColumns == IntPtr.Zero)
				id_getAllColumns = JNIEnv.GetMethodID (class_ref, "getAllColumns", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllColumns), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.datastore']/class[@name='RequestedScopeDataSource']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/RequestedScopeDataSource;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/RequestedScopeDataSource;");
			global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
