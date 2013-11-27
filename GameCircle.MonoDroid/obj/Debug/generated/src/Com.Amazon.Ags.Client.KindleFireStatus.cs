using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/KindleFireStatus", DoNotGenerateAcw=true)]
	public sealed partial class KindleFireStatus : global::Java.Lang.Enum {


		static IntPtr CANNOT_AUTHORIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='CANNOT_AUTHORIZE']"
		[Register ("CANNOT_AUTHORIZE")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus CannotAuthorize {
			get {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_AUTHORIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANNOT_AUTHORIZE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INITIALIZING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='INITIALIZING']"
		[Register ("INITIALIZING")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus Initializing {
			get {
				if (INITIALIZING_jfieldId == IntPtr.Zero)
					INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INITIALIZING_jfieldId == IntPtr.Zero)
					INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INITIALIZING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_AUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='NOT_AUTHORIZED']"
		[Register ("NOT_AUTHORIZED")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus NotAuthorized {
			get {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_AUTHORIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_REGISTERED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='NOT_REGISTERED']"
		[Register ("NOT_REGISTERED")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus NotRegistered {
			get {
				if (NOT_REGISTERED_jfieldId == IntPtr.Zero)
					NOT_REGISTERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_REGISTERED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_REGISTERED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_REGISTERED_jfieldId == IntPtr.Zero)
					NOT_REGISTERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_REGISTERED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_REGISTERED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_CONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='SERVICE_CONNECTED']"
		[Register ("SERVICE_CONNECTED")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus ServiceConnected {
			get {
				if (SERVICE_CONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_CONNECTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_CONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_CONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_CONNECTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_CONNECTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_DISCONNECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='SERVICE_DISCONNECTED']"
		[Register ("SERVICE_DISCONNECTED")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus ServiceDisconnected {
			get {
				if (SERVICE_DISCONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISCONNECTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_DISCONNECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_DISCONNECTED_jfieldId == IntPtr.Zero)
					SERVICE_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISCONNECTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_DISCONNECTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNIVERSAL_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/field[@name='UNIVERSAL_NOT_SUPPORTED']"
		[Register ("UNIVERSAL_NOT_SUPPORTED")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus UniversalNotSupported {
			get {
				if (UNIVERSAL_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					UNIVERSAL_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIVERSAL_NOT_SUPPORTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIVERSAL_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNIVERSAL_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					UNIVERSAL_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIVERSAL_NOT_SUPPORTED", "Lcom/amazon/ags/client/KindleFireStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNIVERSAL_NOT_SUPPORTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/KindleFireStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KindleFireStatus); }
		}

		internal KindleFireStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/KindleFireStatus;", "")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/KindleFireStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.KindleFireStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/client/KindleFireStatus;", "")]
		public static global::Com.Amazon.Ags.Client.KindleFireStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/client/KindleFireStatus;");
			return (global::Com.Amazon.Ags.Client.KindleFireStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Client.KindleFireStatus));
		}

	}
}
