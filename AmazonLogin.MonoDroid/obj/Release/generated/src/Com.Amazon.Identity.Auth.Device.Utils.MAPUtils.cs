using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/MAPUtils", DoNotGenerateAcw=true)]
	public sealed partial class MAPUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils.SCOPE_MODIFIER']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER", DoNotGenerateAcw=true)]
		public sealed partial class SCOPE_MODIFIER : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils.SCOPE_MODIFIER']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOCAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils.SCOPE_MODIFIER']/field[@name='LOCAL']"
			[Register ("LOCAL")]
			public static global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER Local {
				get {
					if (LOCAL_jfieldId == IntPtr.Zero)
						LOCAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCAL", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOCAL_jfieldId == IntPtr.Zero)
						LOCAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCAL", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOCAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REMOTE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils.SCOPE_MODIFIER']/field[@name='REMOTE']"
			[Register ("REMOTE")]
			public static global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER Remote {
				get {
					if (REMOTE_jfieldId == IntPtr.Zero)
						REMOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REMOTE", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REMOTE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPUtils.SCOPE_MODIFIER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REMOTE_jfieldId == IntPtr.Zero)
						REMOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REMOTE", "Lcom/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REMOTE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/MAPUtils$SCOPE_MODIFIER", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SCOPE_MODIFIER); }
			}

			internal SCOPE_MODIFIER (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/MAPUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPUtils); }
		}

		internal MAPUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDeviceId;
		public static string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetStaticMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_areScopesLocalAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='areScopesLocalAndValid' and count(parameter)=2 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AppInfo'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("areScopesLocalAndValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z", "")]
		public static bool AreScopesLocalAndValid (global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo p0, string[] p1)
		{
			if (id_areScopesLocalAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ == IntPtr.Zero)
				id_areScopesLocalAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "areScopesLocalAndValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_areScopesLocalAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_areScopesRemoteAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='areScopesRemoteAndValid' and count(parameter)=2 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AppInfo'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("areScopesRemoteAndValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z", "")]
		public static bool AreScopesRemoteAndValid (global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo p0, string[] p1)
		{
			if (id_areScopesRemoteAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ == IntPtr.Zero)
				id_areScopesRemoteAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "areScopesRemoteAndValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_areScopesRemoteAndValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_areScopesValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='areScopesValid' and count(parameter)=2 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AppInfo'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("areScopesValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z", "")]
		public static bool AreScopesValid (global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo p0, string[] p1)
		{
			if (id_areScopesValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ == IntPtr.Zero)
				id_areScopesValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "areScopesValid", "(Lcom/amazon/identity/auth/device/dataobject/AppInfo;[Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_areScopesValid_Lcom_amazon_identity_auth_device_dataobject_AppInfo_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_contains_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("contains", "([Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool Contains (string[] p0, string p1)
		{
			if (id_contains_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "contains", "([Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_arrayLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getMAPdatabase_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='getMAPdatabase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMAPdatabase", "(Landroid/content/Context;)Landroid/database/sqlite/SQLiteDatabase;", "")]
		public static global::Android.Database.Sqlite.SQLiteDatabase GetMAPdatabase (global::Android.Content.Context p0)
		{
			if (id_getMAPdatabase_Landroid_content_Context_ == IntPtr.Zero)
				id_getMAPdatabase_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMAPdatabase", "(Landroid/content/Context;)Landroid/database/sqlite/SQLiteDatabase;");
			global::Android.Database.Sqlite.SQLiteDatabase __ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMAPdatabase_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getSetDifference_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='getSetDifference' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getSetDifference", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> GetSetDifference (string[] p0, string[] p1)
		{
			if (id_getSetDifference_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getSetDifference_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSetDifference", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSetDifference_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_isMAPUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='isMAPUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isMAPUrl", "(Ljava/lang/String;)Z", "")]
		public static bool IsMAPUrl (string p0)
		{
			if (id_isMAPUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_isMAPUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isMAPUrl", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMAPUrl_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toDelimitedString_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='toDelimitedString' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("toDelimitedString", "([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ToDelimitedString (string[] p0, string p1)
		{
			if (id_toDelimitedString_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toDelimitedString_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toDelimitedString", "([Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toDelimitedString_arrayLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_toHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toHexString", "([B)Ljava/lang/String;", "")]
		public static string ToHexString (byte[] p0)
		{
			if (id_toHexString_arrayB == IntPtr.Zero)
				id_toHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toStringArray_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPUtils']/method[@name='toStringArray' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("toStringArray", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] ToStringArray (string p0, string p1)
		{
			if (id_toStringArray_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toStringArray_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toStringArray", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringArray_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
