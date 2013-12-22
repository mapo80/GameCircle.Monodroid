using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AuthzConstants", DoNotGenerateAcw=true)]
	public sealed partial class AuthzConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants']/field[@name='CAUSE_FAILED_AUTHENTICATION']"
		[Register ("CAUSE_FAILED_AUTHENTICATION")]
		public const int CauseFailedAuthentication = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants']/field[@name='CAUSE_REJECTED_SCOPES']"
		[Register ("CAUSE_REJECTED_SCOPES")]
		public const int CauseRejectedScopes = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY", DoNotGenerateAcw=true)]
		public sealed partial class BUNDLE_KEY : global::Java.Lang.Enum {


			static IntPtr APP_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='APP_ID']"
			[Register ("APP_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY AppId {
				get {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr AUTHORIZATION_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='AUTHORIZATION_CODE']"
			[Register ("AUTHORIZATION_CODE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY AuthorizationCode {
				get {
					if (AUTHORIZATION_CODE_jfieldId == IntPtr.Zero)
						AUTHORIZATION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_CODE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZATION_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AUTHORIZATION_CODE_jfieldId == IntPtr.Zero)
						AUTHORIZATION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_CODE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AUTHORIZATION_CODE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr AUTHORIZE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='AUTHORIZE']"
			[Register ("AUTHORIZE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY Authorize {
				get {
					if (AUTHORIZE_jfieldId == IntPtr.Zero)
						AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AUTHORIZE_jfieldId == IntPtr.Zero)
						AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AUTHORIZE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BROWSER_AUTHORIZATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='BROWSER_AUTHORIZATION']"
			[Register ("BROWSER_AUTHORIZATION")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY BrowserAuthorization {
				get {
					if (BROWSER_AUTHORIZATION_jfieldId == IntPtr.Zero)
						BROWSER_AUTHORIZATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROWSER_AUTHORIZATION", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BROWSER_AUTHORIZATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BROWSER_AUTHORIZATION_jfieldId == IntPtr.Zero)
						BROWSER_AUTHORIZATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROWSER_AUTHORIZATION", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BROWSER_AUTHORIZATION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CAUSE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='CAUSE_ID']"
			[Register ("CAUSE_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY CauseId {
				get {
					if (CAUSE_ID_jfieldId == IntPtr.Zero)
						CAUSE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAUSE_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAUSE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CAUSE_ID_jfieldId == IntPtr.Zero)
						CAUSE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAUSE_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CAUSE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY ClientId {
				get {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='DEVICE_ID']"
			[Register ("DEVICE_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY DeviceId {
				get {
					if (DEVICE_ID_jfieldId == IntPtr.Zero)
						DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_ID_jfieldId == IntPtr.Zero)
						DEVICE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DIRECTED_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='DIRECTED_ID']"
			[Register ("DIRECTED_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY DirectedId {
				get {
					if (DIRECTED_ID_jfieldId == IntPtr.Zero)
						DIRECTED_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTED_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRECTED_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DIRECTED_ID_jfieldId == IntPtr.Zero)
						DIRECTED_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTED_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DIRECTED_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FUTURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='FUTURE']"
			[Register ("FUTURE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY Future {
				get {
					if (FUTURE_jfieldId == IntPtr.Zero)
						FUTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FUTURE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FUTURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FUTURE_jfieldId == IntPtr.Zero)
						FUTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FUTURE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FUTURE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ON_CANCEL_DESCRIPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='ON_CANCEL_DESCRIPTION']"
			[Register ("ON_CANCEL_DESCRIPTION")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY OnCancelDescription {
				get {
					if (ON_CANCEL_DESCRIPTION_jfieldId == IntPtr.Zero)
						ON_CANCEL_DESCRIPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_CANCEL_DESCRIPTION", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_CANCEL_DESCRIPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ON_CANCEL_DESCRIPTION_jfieldId == IntPtr.Zero)
						ON_CANCEL_DESCRIPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_CANCEL_DESCRIPTION", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ON_CANCEL_DESCRIPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ON_CANCEL_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='ON_CANCEL_TYPE']"
			[Register ("ON_CANCEL_TYPE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY OnCancelType {
				get {
					if (ON_CANCEL_TYPE_jfieldId == IntPtr.Zero)
						ON_CANCEL_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_CANCEL_TYPE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_CANCEL_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ON_CANCEL_TYPE_jfieldId == IntPtr.Zero)
						ON_CANCEL_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_CANCEL_TYPE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ON_CANCEL_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PROFILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='PROFILE']"
			[Register ("PROFILE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY Profile {
				get {
					if (PROFILE_jfieldId == IntPtr.Zero)
						PROFILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROFILE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROFILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PROFILE_jfieldId == IntPtr.Zero)
						PROFILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROFILE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PROFILE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REJECTED_SCOPE_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='REJECTED_SCOPE_LIST']"
			[Register ("REJECTED_SCOPE_LIST")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY RejectedScopeList {
				get {
					if (REJECTED_SCOPE_LIST_jfieldId == IntPtr.Zero)
						REJECTED_SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REJECTED_SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REJECTED_SCOPE_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REJECTED_SCOPE_LIST_jfieldId == IntPtr.Zero)
						REJECTED_SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REJECTED_SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REJECTED_SCOPE_LIST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='TOKEN']"
			[Register ("TOKEN")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY Token {
				get {
					if (TOKEN_jfieldId == IntPtr.Zero)
						TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TOKEN_jfieldId == IntPtr.Zero)
						TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TOKEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr val_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/field[@name='val']"
			[Register ("val")]
			public string Val {
				get {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, val_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, val_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BUNDLE_KEY); }
			}

			internal BUNDLE_KEY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.BUNDLE_KEY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$BUNDLE_KEY;");
				return (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.BUNDLE_KEY));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class FUTURE_TYPE : global::Java.Lang.Enum {


			static IntPtr CANCEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']/field[@name='CANCEL']"
			[Register ("CANCEL")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE Cancel {
				get {
					if (CANCEL_jfieldId == IntPtr.Zero)
						CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CANCEL_jfieldId == IntPtr.Zero)
						CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CANCEL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE Success {
				get {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SUCCESS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FUTURE_TYPE); }
			}

			internal FUTURE_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.FUTURE_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$FUTURE_TYPE;");
				return (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.FUTURE_TYPE));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY", DoNotGenerateAcw=true)]
		public sealed partial class PROFILE_KEY : global::Java.Lang.Enum {


			static IntPtr EMAIL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/field[@name='EMAIL']"
			[Register ("EMAIL")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY Email {
				get {
					if (EMAIL_jfieldId == IntPtr.Zero)
						EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EMAIL_jfieldId == IntPtr.Zero)
						EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EMAIL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/field[@name='NAME']"
			[Register ("NAME")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY Name {
				get {
					if (NAME_jfieldId == IntPtr.Zero)
						NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NAME", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NAME_jfieldId == IntPtr.Zero)
						NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NAME", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NAME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr POSTAL_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/field[@name='POSTAL_CODE']"
			[Register ("POSTAL_CODE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY PostalCode {
				get {
					if (POSTAL_CODE_jfieldId == IntPtr.Zero)
						POSTAL_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSTAL_CODE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSTAL_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (POSTAL_CODE_jfieldId == IntPtr.Zero)
						POSTAL_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSTAL_CODE", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, POSTAL_CODE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr USER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/field[@name='USER_ID']"
			[Register ("USER_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY UserId {
				get {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, USER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr val_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/field[@name='val']"
			[Register ("val")]
			public string Val {
				get {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, val_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, val_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PROFILE_KEY); }
			}

			internal PROFILE_KEY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants.PROFILE_KEY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/authorization/api/AuthzConstants$PROFILE_KEY;");
				return (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.AuthzConstants.PROFILE_KEY));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/AuthzConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthzConstants); }
		}

		internal AuthzConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='AuthzConstants']/constructor[@name='AuthzConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthzConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthzConstants)) {
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

	}
}
