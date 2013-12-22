using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/CMConstants", DoNotGenerateAcw=true)]
	public sealed partial class CMConstants : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY", DoNotGenerateAcw=true)]
		public sealed partial class BUNDLE_KEY : global::Java.Lang.Enum {


			static IntPtr APPS_WITH_PERMISSION_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='APPS_WITH_PERMISSION_LIST']"
			[Register ("APPS_WITH_PERMISSION_LIST")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY AppsWithPermissionList {
				get {
					if (APPS_WITH_PERMISSION_LIST_jfieldId == IntPtr.Zero)
						APPS_WITH_PERMISSION_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPS_WITH_PERMISSION_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPS_WITH_PERMISSION_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APPS_WITH_PERMISSION_LIST_jfieldId == IntPtr.Zero)
						APPS_WITH_PERMISSION_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPS_WITH_PERMISSION_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APPS_WITH_PERMISSION_LIST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APPS_WITH_SCOPE_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='APPS_WITH_SCOPE_LIST']"
			[Register ("APPS_WITH_SCOPE_LIST")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY AppsWithScopeList {
				get {
					if (APPS_WITH_SCOPE_LIST_jfieldId == IntPtr.Zero)
						APPS_WITH_SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPS_WITH_SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPS_WITH_SCOPE_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APPS_WITH_SCOPE_LIST_jfieldId == IntPtr.Zero)
						APPS_WITH_SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPS_WITH_SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APPS_WITH_SCOPE_LIST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='APP_ID']"
			[Register ("APP_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY AppId {
				get {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_VARIANT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='APP_VARIANT_ID']"
			[Register ("APP_VARIANT_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY AppVariantId {
				get {
					if (APP_VARIANT_ID_jfieldId == IntPtr.Zero)
						APP_VARIANT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VARIANT_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_VARIANT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_VARIANT_ID_jfieldId == IntPtr.Zero)
						APP_VARIANT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VARIANT_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_VARIANT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HAS_PERMISSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='HAS_PERMISSION']"
			[Register ("HAS_PERMISSION")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY HasPermission {
				get {
					if (HAS_PERMISSION_jfieldId == IntPtr.Zero)
						HAS_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_PERMISSION", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAS_PERMISSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HAS_PERMISSION_jfieldId == IntPtr.Zero)
						HAS_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_PERMISSION", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HAS_PERMISSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HAS_SCOPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='HAS_SCOPE']"
			[Register ("HAS_SCOPE")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY HasScope {
				get {
					if (HAS_SCOPE_jfieldId == IntPtr.Zero)
						HAS_SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_SCOPE", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAS_SCOPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HAS_SCOPE_jfieldId == IntPtr.Zero)
						HAS_SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_SCOPE", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HAS_SCOPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PACKAGE_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='PACKAGE_NAME']"
			[Register ("PACKAGE_NAME")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY PackageName {
				get {
					if (PACKAGE_NAME_jfieldId == IntPtr.Zero)
						PACKAGE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAME", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PACKAGE_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PACKAGE_NAME_jfieldId == IntPtr.Zero)
						PACKAGE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAME", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PACKAGE_NAME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PACKAGE_NAMES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='PACKAGE_NAMES']"
			[Register ("PACKAGE_NAMES")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY PackageNames {
				get {
					if (PACKAGE_NAMES_jfieldId == IntPtr.Zero)
						PACKAGE_NAMES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAMES", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PACKAGE_NAMES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PACKAGE_NAMES_jfieldId == IntPtr.Zero)
						PACKAGE_NAMES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAMES", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PACKAGE_NAMES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PERMISSION_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='PERMISSION_LIST']"
			[Register ("PERMISSION_LIST")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY PermissionList {
				get {
					if (PERMISSION_LIST_jfieldId == IntPtr.Zero)
						PERMISSION_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERMISSION_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PERMISSION_LIST_jfieldId == IntPtr.Zero)
						PERMISSION_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PERMISSION_LIST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SCOPE_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='SCOPE_LIST']"
			[Register ("SCOPE_LIST")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY ScopeList {
				get {
					if (SCOPE_LIST_jfieldId == IntPtr.Zero)
						SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCOPE_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SCOPE_LIST_jfieldId == IntPtr.Zero)
						SCOPE_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCOPE_LIST", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SCOPE_LIST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr USER_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='USER_ID']"
			[Register ("USER_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY UserId {
				get {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (USER_ID_jfieldId == IntPtr.Zero)
						USER_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ID", "Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, USER_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr val_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/field[@name='val']"
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
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants.BUNDLE_KEY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/authorization/api/CMConstants$BUNDLE_KEY;");
				return (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.CMConstants.BUNDLE_KEY));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/api/CMConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CMConstants); }
		}

		internal CMConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization.api']/class[@name='CMConstants']/constructor[@name='CMConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CMConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CMConstants)) {
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
