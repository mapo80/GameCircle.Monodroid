using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/AuthError", DoNotGenerateAcw=true)]
	public partial class AuthError : global::Java.Lang.Exception, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/field[@name='AUTH_ERROR_EXECEPTION']"
		[Register ("AUTH_ERROR_EXECEPTION")]
		public const string AuthErrorExeception = (string) "AUTH_ERROR_EXECEPTION";

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/field[@name='RESULT_AUTH_ERROR']"
		[Register ("RESULT_AUTH_ERROR")]
		public const int ResultAuthError = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/AuthError$ERROR_CATEGORY", DoNotGenerateAcw=true)]
		public sealed partial class ERROR_CATEGORY : global::Java.Lang.Enum {


			static IntPtr ACTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/field[@name='ACTION']"
			[Register ("ACTION")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Action {
				get {
					if (ACTION_jfieldId == IntPtr.Zero)
						ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ACTION_jfieldId == IntPtr.Zero)
						ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ACTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BAD_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/field[@name='BAD_REQUEST']"
			[Register ("BAD_REQUEST")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY BadRequest {
				get {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BAD_REQUEST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INTERNAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/field[@name='INTERNAL']"
			[Register ("INTERNAL")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Internal {
				get {
					if (INTERNAL_jfieldId == IntPtr.Zero)
						INTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INTERNAL_jfieldId == IntPtr.Zero)
						INTERNAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INTERNAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Network {
				get {
					if (NETWORK_jfieldId == IntPtr.Zero)
						NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_jfieldId == IntPtr.Zero)
						NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/AuthError$ERROR_CATEGORY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ERROR_CATEGORY); }
			}

			internal ERROR_CATEGORY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_CATEGORY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
				return (global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/AuthError$ERROR_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class ERROR_TYPE : global::Java.Lang.Enum {


			static IntPtr ERROR_ACCESS_DENIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_ACCESS_DENIED']"
			[Register ("ERROR_ACCESS_DENIED")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorAccessDenied {
				get {
					if (ERROR_ACCESS_DENIED_jfieldId == IntPtr.Zero)
						ERROR_ACCESS_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_ACCESS_DENIED", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_ACCESS_DENIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_ACCESS_DENIED_jfieldId == IntPtr.Zero)
						ERROR_ACCESS_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_ACCESS_DENIED", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_ACCESS_DENIED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_AUTH_DIALOG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_AUTH_DIALOG']"
			[Register ("ERROR_AUTH_DIALOG")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorAuthDialog {
				get {
					if (ERROR_AUTH_DIALOG_jfieldId == IntPtr.Zero)
						ERROR_AUTH_DIALOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_AUTH_DIALOG", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_AUTH_DIALOG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_AUTH_DIALOG_jfieldId == IntPtr.Zero)
						ERROR_AUTH_DIALOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_AUTH_DIALOG", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_AUTH_DIALOG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_BAD_API_PARAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_BAD_API_PARAM']"
			[Register ("ERROR_BAD_API_PARAM")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorBadApiParam {
				get {
					if (ERROR_BAD_API_PARAM_jfieldId == IntPtr.Zero)
						ERROR_BAD_API_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_BAD_API_PARAM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_BAD_API_PARAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_BAD_API_PARAM_jfieldId == IntPtr.Zero)
						ERROR_BAD_API_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_BAD_API_PARAM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_BAD_API_PARAM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_BAD_PARAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_BAD_PARAM']"
			[Register ("ERROR_BAD_PARAM")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorBadParam {
				get {
					if (ERROR_BAD_PARAM_jfieldId == IntPtr.Zero)
						ERROR_BAD_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_BAD_PARAM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_BAD_PARAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_BAD_PARAM_jfieldId == IntPtr.Zero)
						ERROR_BAD_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_BAD_PARAM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_BAD_PARAM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_COM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_COM']"
			[Register ("ERROR_COM")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorCom {
				get {
					if (ERROR_COM_jfieldId == IntPtr.Zero)
						ERROR_COM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_COM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_COM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_COM_jfieldId == IntPtr.Zero)
						ERROR_COM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_COM", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_COM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_DATA_STORAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_DATA_STORAGE']"
			[Register ("ERROR_DATA_STORAGE")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorDataStorage {
				get {
					if (ERROR_DATA_STORAGE_jfieldId == IntPtr.Zero)
						ERROR_DATA_STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DATA_STORAGE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_DATA_STORAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_DATA_STORAGE_jfieldId == IntPtr.Zero)
						ERROR_DATA_STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DATA_STORAGE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_DATA_STORAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_DCP_DMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_DCP_DMS']"
			[Register ("ERROR_DCP_DMS")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorDcpDms {
				get {
					if (ERROR_DCP_DMS_jfieldId == IntPtr.Zero)
						ERROR_DCP_DMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DCP_DMS", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_DCP_DMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_DCP_DMS_jfieldId == IntPtr.Zero)
						ERROR_DCP_DMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DCP_DMS", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_DCP_DMS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_DIRECTED_ID_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_DIRECTED_ID_NOT_FOUND']"
			[Register ("ERROR_DIRECTED_ID_NOT_FOUND")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorDirectedIdNotFound {
				get {
					if (ERROR_DIRECTED_ID_NOT_FOUND_jfieldId == IntPtr.Zero)
						ERROR_DIRECTED_ID_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DIRECTED_ID_NOT_FOUND", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_DIRECTED_ID_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_DIRECTED_ID_NOT_FOUND_jfieldId == IntPtr.Zero)
						ERROR_DIRECTED_ID_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_DIRECTED_ID_NOT_FOUND", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_DIRECTED_ID_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_FORCE_UPDATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_FORCE_UPDATE']"
			[Register ("ERROR_FORCE_UPDATE")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorForceUpdate {
				get {
					if (ERROR_FORCE_UPDATE_jfieldId == IntPtr.Zero)
						ERROR_FORCE_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_FORCE_UPDATE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_FORCE_UPDATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_FORCE_UPDATE_jfieldId == IntPtr.Zero)
						ERROR_FORCE_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_FORCE_UPDATE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_FORCE_UPDATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INIT']"
			[Register ("ERROR_INIT")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInit {
				get {
					if (ERROR_INIT_jfieldId == IntPtr.Zero)
						ERROR_INIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INIT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INIT_jfieldId == IntPtr.Zero)
						ERROR_INIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INIT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INIT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INVALID_API_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INVALID_API']"
			[Register ("ERROR_INVALID_API")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInvalidApi {
				get {
					if (ERROR_INVALID_API_jfieldId == IntPtr.Zero)
						ERROR_INVALID_API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_API", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INVALID_API_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INVALID_API_jfieldId == IntPtr.Zero)
						ERROR_INVALID_API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_API", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INVALID_API_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INVALID_CLIENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INVALID_CLIENT']"
			[Register ("ERROR_INVALID_CLIENT")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInvalidClient {
				get {
					if (ERROR_INVALID_CLIENT_jfieldId == IntPtr.Zero)
						ERROR_INVALID_CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_CLIENT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INVALID_CLIENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INVALID_CLIENT_jfieldId == IntPtr.Zero)
						ERROR_INVALID_CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_CLIENT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INVALID_CLIENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INVALID_GRANT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INVALID_GRANT']"
			[Register ("ERROR_INVALID_GRANT")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInvalidGrant {
				get {
					if (ERROR_INVALID_GRANT_jfieldId == IntPtr.Zero)
						ERROR_INVALID_GRANT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_GRANT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INVALID_GRANT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INVALID_GRANT_jfieldId == IntPtr.Zero)
						ERROR_INVALID_GRANT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_GRANT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INVALID_GRANT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INVALID_SCOPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INVALID_SCOPE']"
			[Register ("ERROR_INVALID_SCOPE")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInvalidScope {
				get {
					if (ERROR_INVALID_SCOPE_jfieldId == IntPtr.Zero)
						ERROR_INVALID_SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_SCOPE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INVALID_SCOPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INVALID_SCOPE_jfieldId == IntPtr.Zero)
						ERROR_INVALID_SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_SCOPE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INVALID_SCOPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_INVALID_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_INVALID_TOKEN']"
			[Register ("ERROR_INVALID_TOKEN")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorInvalidToken {
				get {
					if (ERROR_INVALID_TOKEN_jfieldId == IntPtr.Zero)
						ERROR_INVALID_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_TOKEN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INVALID_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_INVALID_TOKEN_jfieldId == IntPtr.Zero)
						ERROR_INVALID_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INVALID_TOKEN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_INVALID_TOKEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_IO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_IO']"
			[Register ("ERROR_IO")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorIo {
				get {
					if (ERROR_IO_jfieldId == IntPtr.Zero)
						ERROR_IO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_IO", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_IO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_IO_jfieldId == IntPtr.Zero)
						ERROR_IO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_IO", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_IO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_JSON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_JSON']"
			[Register ("ERROR_JSON")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorJson {
				get {
					if (ERROR_JSON_jfieldId == IntPtr.Zero)
						ERROR_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_JSON", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_JSON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_JSON_jfieldId == IntPtr.Zero)
						ERROR_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_JSON", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_JSON_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_PARSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_PARSE']"
			[Register ("ERROR_PARSE")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorParse {
				get {
					if (ERROR_PARSE_jfieldId == IntPtr.Zero)
						ERROR_PARSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_PARSE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_PARSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_PARSE_jfieldId == IntPtr.Zero)
						ERROR_PARSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_PARSE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_PARSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_RESOURCES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_RESOURCES']"
			[Register ("ERROR_RESOURCES")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorResources {
				get {
					if (ERROR_RESOURCES_jfieldId == IntPtr.Zero)
						ERROR_RESOURCES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_RESOURCES", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_RESOURCES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_RESOURCES_jfieldId == IntPtr.Zero)
						ERROR_RESOURCES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_RESOURCES", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_RESOURCES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_REVOKE_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_REVOKE_AUTH']"
			[Register ("ERROR_REVOKE_AUTH")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorRevokeAuth {
				get {
					if (ERROR_REVOKE_AUTH_jfieldId == IntPtr.Zero)
						ERROR_REVOKE_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_REVOKE_AUTH", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_REVOKE_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_REVOKE_AUTH_jfieldId == IntPtr.Zero)
						ERROR_REVOKE_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_REVOKE_AUTH", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_REVOKE_AUTH_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_SECURITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_SECURITY']"
			[Register ("ERROR_SECURITY")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorSecurity {
				get {
					if (ERROR_SECURITY_jfieldId == IntPtr.Zero)
						ERROR_SECURITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_SECURITY", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_SECURITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_SECURITY_jfieldId == IntPtr.Zero)
						ERROR_SECURITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_SECURITY", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_SECURITY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_SERVER_REPSONSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_SERVER_REPSONSE']"
			[Register ("ERROR_SERVER_REPSONSE")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorServerRepsonse {
				get {
					if (ERROR_SERVER_REPSONSE_jfieldId == IntPtr.Zero)
						ERROR_SERVER_REPSONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_SERVER_REPSONSE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_SERVER_REPSONSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_SERVER_REPSONSE_jfieldId == IntPtr.Zero)
						ERROR_SERVER_REPSONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_SERVER_REPSONSE", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_SERVER_REPSONSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_THREAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_THREAD']"
			[Register ("ERROR_THREAD")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorThread {
				get {
					if (ERROR_THREAD_jfieldId == IntPtr.Zero)
						ERROR_THREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_THREAD", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_THREAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_THREAD_jfieldId == IntPtr.Zero)
						ERROR_THREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_THREAD", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_THREAD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_UNAUTHORIZED_CLIENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_UNAUTHORIZED_CLIENT']"
			[Register ("ERROR_UNAUTHORIZED_CLIENT")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorUnauthorizedClient {
				get {
					if (ERROR_UNAUTHORIZED_CLIENT_jfieldId == IntPtr.Zero)
						ERROR_UNAUTHORIZED_CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_UNAUTHORIZED_CLIENT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_UNAUTHORIZED_CLIENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_UNAUTHORIZED_CLIENT_jfieldId == IntPtr.Zero)
						ERROR_UNAUTHORIZED_CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_UNAUTHORIZED_CLIENT", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_UNAUTHORIZED_CLIENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_UNKNOWN']"
			[Register ("ERROR_UNKNOWN")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorUnknown {
				get {
					if (ERROR_UNKNOWN_jfieldId == IntPtr.Zero)
						ERROR_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_UNKNOWN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_UNKNOWN_jfieldId == IntPtr.Zero)
						ERROR_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_UNKNOWN", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_WEBVIEW_SSL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/field[@name='ERROR_WEBVIEW_SSL']"
			[Register ("ERROR_WEBVIEW_SSL")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ErrorWebviewSsl {
				get {
					if (ERROR_WEBVIEW_SSL_jfieldId == IntPtr.Zero)
						ERROR_WEBVIEW_SSL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_WEBVIEW_SSL", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_WEBVIEW_SSL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_WEBVIEW_SSL_jfieldId == IntPtr.Zero)
						ERROR_WEBVIEW_SSL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_WEBVIEW_SSL", "Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_WEBVIEW_SSL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/AuthError$ERROR_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ERROR_TYPE); }
			}

			internal ERROR_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCategory;
			public global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Category {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/method[@name='getCategory' and count(parameter)=0]"
				[Register ("getCategory", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;", "GetGetCategoryHandler")]
				get {
					if (id_getCategory == IntPtr.Zero)
						id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError.ERROR_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");
				return (global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/AuthError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthError); }
		}

		protected AuthError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/constructor[@name='AuthError' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public AuthError (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/constructor[@name='AuthError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='com.amazon.identity.auth.device.AuthError.ERROR_TYPE']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", "")]
		public AuthError (string p0, global::Java.Lang.Throwable p1, global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AuthError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/constructor[@name='AuthError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.identity.auth.device.AuthError.ERROR_TYPE']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", "")]
		public AuthError (string p0, global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AuthError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.AuthError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Category);
		}
#pragma warning restore 0169

		static IntPtr id_getCategory;
		public virtual global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;", "GetGetCategoryHandler")]
			get {
				if (id_getCategory == IntPtr.Zero)
					id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_CATEGORY;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_CATEGORY> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCategory), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.AuthError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.AuthError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_describeContents);
		}

		static IntPtr id_extractError_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='extractError' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("extractError", "(Landroid/content/Intent;)Lcom/amazon/identity/auth/device/AuthError;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.AuthError ExtractError (global::Android.Content.Intent p0)
		{
			if (id_extractError_Landroid_content_Intent_ == IntPtr.Zero)
				id_extractError_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "extractError", "(Landroid/content/Intent;)Lcom/amazon/identity/auth/device/AuthError;");
			global::Com.Amazon.Identity.Auth.Device.AuthError __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractError_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_extractError_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='extractError' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extractError", "(Landroid/os/Bundle;)Lcom/amazon/identity/auth/device/AuthError;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.AuthError ExtractError (global::Android.OS.Bundle p0)
		{
			if (id_extractError_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extractError_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "extractError", "(Landroid/os/Bundle;)Lcom/amazon/identity/auth/device/AuthError;");
			global::Com.Amazon.Identity.Auth.Device.AuthError __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractError_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getAuthError' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class']]"
		[Register ("getAuthError", "(Ljava/lang/Throwable;Ljava/lang/Class;)Lcom/amazon/identity/auth/device/AuthError;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.AuthError GetAuthError (global::Java.Lang.Throwable p0, global::Java.Lang.Class p1)
		{
			if (id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAuthError", "(Ljava/lang/Throwable;Ljava/lang/Class;)Lcom/amazon/identity/auth/device/AuthError;");
			global::Com.Amazon.Identity.Auth.Device.AuthError __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getAuthError' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='com.amazon.identity.auth.device.AuthError.ERROR_TYPE']]"
		[Register ("getAuthError", "(Ljava/lang/Throwable;Ljava/lang/Class;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)Lcom/amazon/identity/auth/device/AuthError;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.AuthError GetAuthError (global::Java.Lang.Throwable p0, global::Java.Lang.Class p1, global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE p2)
		{
			if (id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ == IntPtr.Zero)
				id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ = JNIEnv.GetStaticMethodID (class_ref, "getAuthError", "(Ljava/lang/Throwable;Ljava/lang/Class;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)Lcom/amazon/identity/auth/device/AuthError;");
			global::Com.Amazon.Identity.Auth.Device.AuthError __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthError_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorBundle_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getErrorBundle' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getErrorBundle", "(Landroid/content/Intent;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetErrorBundle (global::Android.Content.Intent p0)
		{
			if (id_getErrorBundle_Landroid_content_Intent_ == IntPtr.Zero)
				id_getErrorBundle_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorBundle", "(Landroid/content/Intent;)Landroid/os/Bundle;");
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorBundle_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorBundle_Lcom_amazon_identity_auth_device_AuthError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getErrorBundle' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("getErrorBundle", "(Lcom/amazon/identity/auth/device/AuthError;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetErrorBundle (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_getErrorBundle_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_getErrorBundle_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorBundle", "(Lcom/amazon/identity/auth/device/AuthError;)Landroid/os/Bundle;");
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorBundle_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorBundle_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='getErrorBundle' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='com.amazon.identity.auth.device.AuthError.ERROR_TYPE']]"
		[Register ("getErrorBundle", "(Ljava/lang/Throwable;Ljava/lang/Class;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle GetErrorBundle (global::Java.Lang.Throwable p0, global::Java.Lang.Class p1, global::Com.Amazon.Identity.Auth.Device.AuthError.ERROR_TYPE p2)
		{
			if (id_getErrorBundle_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ == IntPtr.Zero)
				id_getErrorBundle_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorBundle", "(Ljava/lang/Throwable;Ljava/lang/Class;Lcom/amazon/identity/auth/device/AuthError$ERROR_TYPE;)Landroid/os/Bundle;");
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorBundle_Ljava_lang_Throwable_Ljava_lang_Class_Lcom_amazon_identity_auth_device_AuthError_ERROR_TYPE_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.AuthError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='AuthError']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
