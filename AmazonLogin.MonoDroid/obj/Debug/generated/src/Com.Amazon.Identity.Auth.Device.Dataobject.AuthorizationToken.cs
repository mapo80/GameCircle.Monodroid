using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationToken", DoNotGenerateAcw=true)]
	public abstract partial class AuthorizationToken : global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject, global::Com.Amazon.Identity.Auth.Device.Token.IToken {


		static IntPtr ALL_COLUMNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='ALL_COLUMNS']"
		[Register ("ALL_COLUMNS")]
		public static IList<string> AllColumns {
			get {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALL_COLUMNS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				IntPtr native_value = JavaArray<string>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ALL_COLUMNS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mAppFamilyId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mAppFamilyId']"
		[Register ("mAppFamilyId")]
		protected string MAppFamilyId {
			get {
				if (mAppFamilyId_jfieldId == IntPtr.Zero)
					mAppFamilyId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppFamilyId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAppFamilyId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAppFamilyId_jfieldId == IntPtr.Zero)
					mAppFamilyId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppFamilyId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mAppFamilyId_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCreationTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mCreationTime']"
		[Register ("mCreationTime")]
		protected global::Java.Util.Date MCreationTime {
			get {
				if (mCreationTime_jfieldId == IntPtr.Zero)
					mCreationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mCreationTime", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCreationTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCreationTime_jfieldId == IntPtr.Zero)
					mCreationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mCreationTime", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCreationTime_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mExpirationTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mExpirationTime']"
		[Register ("mExpirationTime")]
		protected global::Java.Util.Date MExpirationTime {
			get {
				if (mExpirationTime_jfieldId == IntPtr.Zero)
					mExpirationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpirationTime", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mExpirationTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExpirationTime_jfieldId == IntPtr.Zero)
					mExpirationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpirationTime", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mExpirationTime_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMiscData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mMiscData']"
		[Register ("mMiscData")]
		protected IList<byte> MMiscData {
			get {
				if (mMiscData_jfieldId == IntPtr.Zero)
					mMiscData_jfieldId = JNIEnv.GetFieldID (class_ref, "mMiscData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, mMiscData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMiscData_jfieldId == IntPtr.Zero)
					mMiscData_jfieldId = JNIEnv.GetFieldID (class_ref, "mMiscData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMiscData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTokenValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mTokenValue']"
		[Register ("mTokenValue")]
		protected string MTokenValue {
			get {
				if (mTokenValue_jfieldId == IntPtr.Zero)
					mTokenValue_jfieldId = JNIEnv.GetFieldID (class_ref, "mTokenValue", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTokenValue_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTokenValue_jfieldId == IntPtr.Zero)
					mTokenValue_jfieldId = JNIEnv.GetFieldID (class_ref, "mTokenValue", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mTokenValue_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/field[@name='mType']"
		[Register ("mType")]
		protected global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE MType {
			get {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mType_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.amazon.identity.auth.device.token.Token

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/field[@name='KEY_TOKEN']"
			[Register ("KEY_TOKEN")]
			public const string KeyToken = (string) "token";
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.AUTHZ_TOKEN_TYPE']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class AUTHZ_TOKEN_TYPE : global::Java.Lang.Enum {


			static IntPtr ACCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.AUTHZ_TOKEN_TYPE']/field[@name='ACCESS']"
			[Register ("ACCESS")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE Access {
				get {
					if (ACCESS_jfieldId == IntPtr.Zero)
						ACCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCESS", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ACCESS_jfieldId == IntPtr.Zero)
						ACCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCESS", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ACCESS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REFRESH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.AUTHZ_TOKEN_TYPE']/field[@name='REFRESH']"
			[Register ("REFRESH")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE Refresh {
				get {
					if (REFRESH_jfieldId == IntPtr.Zero)
						REFRESH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFRESH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REFRESH_jfieldId == IntPtr.Zero)
						REFRESH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REFRESH_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AUTHZ_TOKEN_TYPE); }
			}

			internal AUTHZ_TOKEN_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.AUTHZ_TOKEN_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.AUTHZ_TOKEN_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");
				return (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX", DoNotGenerateAcw=true)]
		public sealed partial class COL_INDEX : global::Java.Lang.Enum {


			static IntPtr APP_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='APP_ID']"
			[Register ("APP_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX AppId {
				get {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CREATION_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='CREATION_TIME']"
			[Register ("CREATION_TIME")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX CreationTime {
				get {
					if (CREATION_TIME_jfieldId == IntPtr.Zero)
						CREATION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATION_TIME", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATION_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CREATION_TIME_jfieldId == IntPtr.Zero)
						CREATION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATION_TIME", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CREATION_TIME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DIRECTED_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='DIRECTED_ID']"
			[Register ("DIRECTED_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX DirectedId {
				get {
					if (DIRECTED_ID_jfieldId == IntPtr.Zero)
						DIRECTED_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTED_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRECTED_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DIRECTED_ID_jfieldId == IntPtr.Zero)
						DIRECTED_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTED_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DIRECTED_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXPIRATION_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='EXPIRATION_TIME']"
			[Register ("EXPIRATION_TIME")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX ExpirationTime {
				get {
					if (EXPIRATION_TIME_jfieldId == IntPtr.Zero)
						EXPIRATION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRATION_TIME", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRATION_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXPIRATION_TIME_jfieldId == IntPtr.Zero)
						EXPIRATION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRATION_TIME", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXPIRATION_TIME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='ID']"
			[Register ("ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX Id {
				get {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MISC_DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='MISC_DATA']"
			[Register ("MISC_DATA")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX MiscData {
				get {
					if (MISC_DATA_jfieldId == IntPtr.Zero)
						MISC_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISC_DATA", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MISC_DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MISC_DATA_jfieldId == IntPtr.Zero)
						MISC_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISC_DATA", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MISC_DATA_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='TOKEN']"
			[Register ("TOKEN")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX Token {
				get {
					if (TOKEN_jfieldId == IntPtr.Zero)
						TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TOKEN_jfieldId == IntPtr.Zero)
						TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TOKEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='TYPE']"
			[Register ("TYPE")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX Type {
				get {
					if (TYPE_jfieldId == IntPtr.Zero)
						TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TYPE_jfieldId == IntPtr.Zero)
						TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr colId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/field[@name='colId']"
			[Register ("colId")]
			public int ColId {
				get {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					return JNIEnv.GetIntField (Handle, colId_jfieldId);
				}
				set {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					JNIEnv.SetField (Handle, colId_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (COL_INDEX); }
			}

			internal COL_INDEX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken.COL_INDEX']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$COL_INDEX;");
				return (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.COL_INDEX));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationToken); }
		}

		protected AuthorizationToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_arrayBLcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/constructor[@name='AuthorizationToken' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date'] and parameter[5][@type='java.util.Date'] and parameter[6][@type='byte[]'] and parameter[7][@type='com.amazon.identity.auth.device.dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;[BLcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)V", "")]
		public AuthorizationToken (string p0, string p1, string p2, global::Java.Util.Date p3, global::Java.Util.Date p4, byte[] p5, global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p5 = JNIEnv.NewArray (p5);;
			if (GetType () != typeof (AuthorizationToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;[BLcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;[BLcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (p6));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_arrayBLcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_arrayBLcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;[BLcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_arrayBLcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_arrayBLcom_amazon_identity_auth_device_dataobject_AuthorizationToken_AUTHZ_TOKEN_TYPE_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5), new JValue (p6));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/constructor[@name='AuthorizationToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthorizationToken () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthorizationToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getAppFamilyId;
#pragma warning disable 0169
		static Delegate GetGetAppFamilyIdHandler ()
		{
			if (cb_getAppFamilyId == null)
				cb_getAppFamilyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppFamilyId);
			return cb_getAppFamilyId;
		}

		static IntPtr n_GetAppFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppFamilyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppFamilyId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppFamilyId_Ljava_lang_String_ == null)
				cb_setAppFamilyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppFamilyId_Ljava_lang_String_);
			return cb_setAppFamilyId_Ljava_lang_String_;
		}

		static void n_SetAppFamilyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppFamilyId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		static IntPtr id_setAppFamilyId_Ljava_lang_String_;
		public virtual string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getAppFamilyId' and count(parameter)=0]"
			[Register ("getAppFamilyId", "()Ljava/lang/String;", "GetGetAppFamilyIdHandler")]
			get {
				if (id_getAppFamilyId == IntPtr.Zero)
					id_getAppFamilyId = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setAppFamilyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppFamilyId", "(Ljava/lang/String;)V", "GetSetAppFamilyId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppFamilyId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppFamilyId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppFamilyId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppFamilyId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAppFamilyId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getCreationTime;
#pragma warning disable 0169
		static Delegate GetGetCreationTimeHandler ()
		{
			if (cb_getCreationTime == null)
				cb_getCreationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreationTime);
			return cb_getCreationTime;
		}

		static IntPtr n_GetCreationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreationTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreationTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCreationTime_Ljava_util_Date_Handler ()
		{
			if (cb_setCreationTime_Ljava_util_Date_ == null)
				cb_setCreationTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreationTime_Ljava_util_Date_);
			return cb_setCreationTime_Ljava_util_Date_;
		}

		static void n_SetCreationTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreationTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreationTime;
		static IntPtr id_setCreationTime_Ljava_util_Date_;
		public virtual global::Java.Util.Date CreationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getCreationTime' and count(parameter)=0]"
			[Register ("getCreationTime", "()Ljava/util/Date;", "GetGetCreationTimeHandler")]
			get {
				if (id_getCreationTime == IntPtr.Zero)
					id_getCreationTime = JNIEnv.GetMethodID (class_ref, "getCreationTime", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getCreationTime), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCreationTime), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setCreationTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCreationTime", "(Ljava/util/Date;)V", "GetSetCreationTime_Ljava_util_Date_Handler")]
			set {
				if (id_setCreationTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setCreationTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCreationTime", "(Ljava/util/Date;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCreationTime_Ljava_util_Date_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCreationTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public virtual global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDirectedId;
#pragma warning disable 0169
		static Delegate GetGetDirectedIdHandler ()
		{
			if (cb_getDirectedId == null)
				cb_getDirectedId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirectedId);
			return cb_getDirectedId;
		}

		static IntPtr n_GetDirectedId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DirectedId);
		}
#pragma warning restore 0169

		static Delegate cb_setDirectedId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDirectedId_Ljava_lang_String_Handler ()
		{
			if (cb_setDirectedId_Ljava_lang_String_ == null)
				cb_setDirectedId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDirectedId_Ljava_lang_String_);
			return cb_setDirectedId_Ljava_lang_String_;
		}

		static void n_SetDirectedId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DirectedId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDirectedId;
		static IntPtr id_setDirectedId_Ljava_lang_String_;
		public virtual string DirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getDirectedId' and count(parameter)=0]"
			[Register ("getDirectedId", "()Ljava/lang/String;", "GetGetDirectedIdHandler")]
			get {
				if (id_getDirectedId == IntPtr.Zero)
					id_getDirectedId = JNIEnv.GetMethodID (class_ref, "getDirectedId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setDirectedId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDirectedId", "(Ljava/lang/String;)V", "GetSetDirectedId_Ljava_lang_String_Handler")]
			set {
				if (id_setDirectedId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDirectedId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDirectedId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDirectedId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDirectedId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getExpirationTime;
#pragma warning disable 0169
		static Delegate GetGetExpirationTimeHandler ()
		{
			if (cb_getExpirationTime == null)
				cb_getExpirationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationTime);
			return cb_getExpirationTime;
		}

		static IntPtr n_GetExpirationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpirationTime);
		}
#pragma warning restore 0169

		static Delegate cb_setExpirationTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpirationTime_Ljava_util_Date_Handler ()
		{
			if (cb_setExpirationTime_Ljava_util_Date_ == null)
				cb_setExpirationTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationTime_Ljava_util_Date_);
			return cb_setExpirationTime_Ljava_util_Date_;
		}

		static void n_SetExpirationTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationTime;
		static IntPtr id_setExpirationTime_Ljava_util_Date_;
		public virtual global::Java.Util.Date ExpirationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getExpirationTime' and count(parameter)=0]"
			[Register ("getExpirationTime", "()Ljava/util/Date;", "GetGetExpirationTimeHandler")]
			get {
				if (id_getExpirationTime == IntPtr.Zero)
					id_getExpirationTime = JNIEnv.GetMethodID (class_ref, "getExpirationTime", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationTime), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExpirationTime), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpirationTime", "(Ljava/util/Date;)V", "GetSetExpirationTime_Ljava_util_Date_Handler")]
			set {
				if (id_setExpirationTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setExpirationTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExpirationTime", "(Ljava/util/Date;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExpirationTime_Ljava_util_Date_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setExpirationTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_J;
#pragma warning disable 0169
		static Delegate GetSetId_JHandler ()
		{
			if (cb_setId_J == null)
				cb_setId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetId_J);
			return cb_setId_J;
		}

		static void n_SetId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_J;
		public virtual long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getId);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				if (id_setId_J == IntPtr.Zero)
					id_setId_J = JNIEnv.GetMethodID (class_ref, "setId", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setId_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setId_J, new JValue (value));
			}
		}

		static Delegate cb_isRemainingLifeAcceptable;
#pragma warning disable 0169
		static Delegate GetIsRemainingLifeAcceptableHandler ()
		{
			if (cb_isRemainingLifeAcceptable == null)
				cb_isRemainingLifeAcceptable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRemainingLifeAcceptable);
			return cb_isRemainingLifeAcceptable;
		}

		static bool n_IsRemainingLifeAcceptable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRemainingLifeAcceptable;
		}
#pragma warning restore 0169

		static IntPtr id_isRemainingLifeAcceptable;
		public virtual bool IsRemainingLifeAcceptable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='isRemainingLifeAcceptable' and count(parameter)=0]"
			[Register ("isRemainingLifeAcceptable", "()Z", "GetIsRemainingLifeAcceptableHandler")]
			get {
				if (id_isRemainingLifeAcceptable == IntPtr.Zero)
					id_isRemainingLifeAcceptable = JNIEnv.GetMethodID (class_ref, "isRemainingLifeAcceptable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRemainingLifeAcceptable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isRemainingLifeAcceptable);
			}
		}

		static Delegate cb_getLocalTimestamp;
#pragma warning disable 0169
		static Delegate GetGetLocalTimestampHandler ()
		{
			if (cb_getLocalTimestamp == null)
				cb_getLocalTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalTimestamp);
			return cb_getLocalTimestamp;
		}

		static IntPtr n_GetLocalTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalTimestamp);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalTimestamp;
		public virtual global::Android.Text.Format.Time LocalTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getLocalTimestamp' and count(parameter)=0]"
			[Register ("getLocalTimestamp", "()Landroid/text/format/Time;", "GetGetLocalTimestampHandler")]
			get {
				if (id_getLocalTimestamp == IntPtr.Zero)
					id_getLocalTimestamp = JNIEnv.GetMethodID (class_ref, "getLocalTimestamp", "()Landroid/text/format/Time;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallObjectMethod  (Handle, id_getLocalTimestamp), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalTimestamp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTokenValue;
#pragma warning disable 0169
		static Delegate GetGetTokenValueHandler ()
		{
			if (cb_getTokenValue == null)
				cb_getTokenValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenValue);
			return cb_getTokenValue;
		}

		static IntPtr n_GetTokenValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenValue);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenValue_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenValue_Ljava_lang_String_ == null)
				cb_setTokenValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenValue_Ljava_lang_String_);
			return cb_setTokenValue_Ljava_lang_String_;
		}

		static void n_SetTokenValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenValue;
		static IntPtr id_setTokenValue_Ljava_lang_String_;
		public virtual string TokenValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getTokenValue' and count(parameter)=0]"
			[Register ("getTokenValue", "()Ljava/lang/String;", "GetGetTokenValueHandler")]
			get {
				if (id_getTokenValue == IntPtr.Zero)
					id_getTokenValue = JNIEnv.GetMethodID (class_ref, "getTokenValue", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenValue), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTokenValue), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setTokenValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenValue", "(Ljava/lang/String;)V", "GetSetTokenValue_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTokenValue_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTokenValue_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTypeAsEnum;
#pragma warning disable 0169
		static Delegate GetGetTypeAsEnumHandler ()
		{
			if (cb_getTypeAsEnum == null)
				cb_getTypeAsEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeAsEnum);
			return cb_getTypeAsEnum;
		}

		static IntPtr n_GetTypeAsEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypeAsEnum);
		}
#pragma warning restore 0169

		static IntPtr id_getTypeAsEnum;
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE TypeAsEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getTypeAsEnum' and count(parameter)=0]"
			[Register ("getTypeAsEnum", "()Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;", "GetGetTypeAsEnumHandler")]
			get {
				if (id_getTypeAsEnum == IntPtr.Zero)
					id_getTypeAsEnum = JNIEnv.GetMethodID (class_ref, "getTypeAsEnum", "()Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken$AUTHZ_TOKEN_TYPE;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (JNIEnv.CallObjectMethod  (Handle, id_getTypeAsEnum), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken.AUTHZ_TOKEN_TYPE> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTypeAsEnum), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getValuesForInsert;
#pragma warning disable 0169
		static Delegate GetGetValuesForInsertHandler ()
		{
			if (cb_getValuesForInsert == null)
				cb_getValuesForInsert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValuesForInsert);
			return cb_getValuesForInsert;
		}

		static IntPtr n_GetValuesForInsert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getValuesForInsert;
		public override global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getValuesForInsert' and count(parameter)=0]"
			[Register ("getValuesForInsert", "()Landroid/content/ContentValues;", "GetGetValuesForInsertHandler")]
			get {
				if (id_getValuesForInsert == IntPtr.Zero)
					id_getValuesForInsert = JNIEnv.GetMethodID (class_ref, "getValuesForInsert", "()Landroid/content/ContentValues;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_getDataSource_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetDataSource_Landroid_content_Context_Handler ()
		{
			if (cb_getDataSource_Landroid_content_Context_ == null)
				cb_getDataSource_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSource_Landroid_content_Context_);
			return cb_getDataSource_Landroid_content_Context_;
		}

		static IntPtr n_GetDataSource_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AuthorizationTokenDataSource;", "GetGetDataSource_Landroid_content_Context_Handler")]
		public override global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AuthorizationTokenDataSource;");

			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getMiscData;
#pragma warning disable 0169
		static Delegate GetGetMiscDataHandler ()
		{
			if (cb_getMiscData == null)
				cb_getMiscData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiscData);
			return cb_getMiscData;
		}

		static IntPtr n_GetMiscData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMiscData ());
		}
#pragma warning restore 0169

		static IntPtr id_getMiscData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='getMiscData' and count(parameter)=0]"
		[Register ("getMiscData", "()[B", "GetGetMiscDataHandler")]
		public virtual byte[] GetMiscData ()
		{
			if (id_getMiscData == IntPtr.Zero)
				id_getMiscData = JNIEnv.GetMethodID (class_ref, "getMiscData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMiscData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMiscData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_setMiscData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetMiscData_arrayBHandler ()
		{
			if (cb_setMiscData_arrayB == null)
				cb_setMiscData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMiscData_arrayB);
			return cb_setMiscData_arrayB;
		}

		static void n_SetMiscData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetMiscData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMiscData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='setMiscData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setMiscData", "([B)V", "GetSetMiscData_arrayBHandler")]
		public virtual void SetMiscData (byte[] p0)
		{
			if (id_setMiscData_arrayB == IntPtr.Zero)
				id_setMiscData_arrayB = JNIEnv.GetMethodID (class_ref, "setMiscData", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMiscData_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setMiscData_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toLogString;
#pragma warning disable 0169
		static Delegate GetToLogStringHandler ()
		{
			if (cb_toLogString == null)
				cb_toLogString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToLogString);
			return cb_toLogString;
		}

		static IntPtr n_ToLogString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToLogString ());
		}
#pragma warning restore 0169

		static IntPtr id_toLogString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationToken']/method[@name='toLogString' and count(parameter)=0]"
		[Register ("toLogString", "()Ljava/lang/String;", "GetToLogStringHandler")]
		public virtual string ToLogString ()
		{
			if (id_toLogString == IntPtr.Zero)
				id_toLogString = JNIEnv.GetMethodID (class_ref, "toLogString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toLogString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toLogString), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationToken", DoNotGenerateAcw=true)]
	internal partial class AuthorizationTokenInvoker : AuthorizationToken {

		public AuthorizationTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationTokenInvoker); }
		}

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AbstractDataSource;", "GetGetDataSource_Landroid_content_Context_Handler")]
		public override global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AbstractDataSource;");
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
