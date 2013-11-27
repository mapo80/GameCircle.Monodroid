using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/AmazonGamesStatus", DoNotGenerateAcw=true)]
	public sealed partial class AmazonGamesStatus : global::Java.Lang.Enum {


		static IntPtr CANNOT_AUTHORIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='CANNOT_AUTHORIZE']"
		[Register ("CANNOT_AUTHORIZE")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus CannotAuthorize {
			get {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_AUTHORIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANNOT_AUTHORIZE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CANNOT_BIND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='CANNOT_BIND']"
		[Register ("CANNOT_BIND")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus CannotBind {
			get {
				if (CANNOT_BIND_jfieldId == IntPtr.Zero)
					CANNOT_BIND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_BIND", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_BIND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANNOT_BIND_jfieldId == IntPtr.Zero)
					CANNOT_BIND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_BIND", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANNOT_BIND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CANNOT_INITIALIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='CANNOT_INITIALIZE']"
		[Register ("CANNOT_INITIALIZE")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus CannotInitialize {
			get {
				if (CANNOT_INITIALIZE_jfieldId == IntPtr.Zero)
					CANNOT_INITIALIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_INITIALIZE", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_INITIALIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANNOT_INITIALIZE_jfieldId == IntPtr.Zero)
					CANNOT_INITIALIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_INITIALIZE", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANNOT_INITIALIZE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INITIALIZING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='INITIALIZING']"
		[Register ("INITIALIZING")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus Initializing {
			get {
				if (INITIALIZING_jfieldId == IntPtr.Zero)
					INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INITIALIZING_jfieldId == IntPtr.Zero)
					INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INITIALIZING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INVALID_SESSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='INVALID_SESSION']"
		[Register ("INVALID_SESSION")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus InvalidSession {
			get {
				if (INVALID_SESSION_jfieldId == IntPtr.Zero)
					INVALID_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SESSION", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_SESSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INVALID_SESSION_jfieldId == IntPtr.Zero)
					INVALID_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SESSION", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INVALID_SESSION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_AUTHENTICATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='NOT_AUTHENTICATED']"
		[Register ("NOT_AUTHENTICATED")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus NotAuthenticated {
			get {
				if (NOT_AUTHENTICATED_jfieldId == IntPtr.Zero)
					NOT_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHENTICATED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHENTICATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_AUTHENTICATED_jfieldId == IntPtr.Zero)
					NOT_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHENTICATED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_AUTHENTICATED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_AUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='NOT_AUTHORIZED']"
		[Register ("NOT_AUTHORIZED")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus NotAuthorized {
			get {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_AUTHORIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_CONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='SERVICE_CONNECTED']"
		[Register ("SERVICE_CONNECTED")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus ServiceConnected {
			get {
				if (SERVICE_CONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_CONNECTED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_CONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_CONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_CONNECTED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_CONNECTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_DISCONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='SERVICE_DISCONNECTED']"
		[Register ("SERVICE_DISCONNECTED")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus ServiceDisconnected {
			get {
				if (SERVICE_DISCONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISCONNECTED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_DISCONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_DISCONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISCONNECTED", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_DISCONNECTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_NOT_OPTED_IN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/field[@name='SERVICE_NOT_OPTED_IN']"
		[Register ("SERVICE_NOT_OPTED_IN")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus ServiceNotOptedIn {
			get {
				if (SERVICE_NOT_OPTED_IN_jfieldId == IntPtr.Zero)
					SERVICE_NOT_OPTED_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_NOT_OPTED_IN", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_NOT_OPTED_IN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_NOT_OPTED_IN_jfieldId == IntPtr.Zero)
					SERVICE_NOT_OPTED_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_NOT_OPTED_IN", "Lcom/amazon/ags/api/AmazonGamesStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_NOT_OPTED_IN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/AmazonGamesStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonGamesStatus); }
		}

		internal AmazonGamesStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AmazonGamesStatus;", "")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AmazonGamesStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.AmazonGamesStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AmazonGamesStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AmazonGamesStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/AmazonGamesStatus;", "")]
		public static global::Com.Amazon.Ags.Api.AmazonGamesStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/AmazonGamesStatus;");
			return (global::Com.Amazon.Ags.Api.AmazonGamesStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.AmazonGamesStatus));
		}

	}
}
