using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr AUTHENTICATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='AUTHENTICATION_ERROR']"
		[Register ("AUTHENTICATION_ERROR")]
		public static global::Com.Amazon.Ags.Api.ErrorCode AuthenticationError {
			get {
				if (AUTHENTICATION_ERROR_jfieldId == IntPtr.Zero)
					AUTHENTICATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTHENTICATION_ERROR_jfieldId == IntPtr.Zero)
					AUTHENTICATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, AUTHENTICATION_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CODE_TO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='CODE_TO_ERROR']"
		[Register ("CODE_TO_ERROR")]
		public static global::System.Collections.IDictionary CodeToError {
			get {
				if (CODE_TO_ERROR_jfieldId == IntPtr.Zero)
					CODE_TO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE_TO_ERROR", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_TO_ERROR_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CODE_TO_ERROR_jfieldId == IntPtr.Zero)
					CODE_TO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE_TO_ERROR", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CODE_TO_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CONNECTION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='CONNECTION_ERROR']"
		[Register ("CONNECTION_ERROR")]
		public static global::Com.Amazon.Ags.Api.ErrorCode ConnectionError {
			get {
				if (CONNECTION_ERROR_jfieldId == IntPtr.Zero)
					CONNECTION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONNECTION_ERROR_jfieldId == IntPtr.Zero)
					CONNECTION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CONNECTION_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DATA_VALIDATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='DATA_VALIDATION_ERROR']"
		[Register ("DATA_VALIDATION_ERROR")]
		public static global::Com.Amazon.Ags.Api.ErrorCode DataValidationError {
			get {
				if (DATA_VALIDATION_ERROR_jfieldId == IntPtr.Zero)
					DATA_VALIDATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_VALIDATION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_VALIDATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DATA_VALIDATION_ERROR_jfieldId == IntPtr.Zero)
					DATA_VALIDATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_VALIDATION_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DATA_VALIDATION_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr IO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='IO_ERROR']"
		[Register ("IO_ERROR")]
		public static global::Com.Amazon.Ags.Api.ErrorCode IoError {
			get {
				if (IO_ERROR_jfieldId == IntPtr.Zero)
					IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IO_ERROR_jfieldId == IntPtr.Zero)
					IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, IO_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Amazon.Ags.Api.ErrorCode None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_NOT_READY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='SERVICE_NOT_READY']"
		[Register ("SERVICE_NOT_READY")]
		public static global::Com.Amazon.Ags.Api.ErrorCode ServiceNotReady {
			get {
				if (SERVICE_NOT_READY_jfieldId == IntPtr.Zero)
					SERVICE_NOT_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_NOT_READY", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_NOT_READY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_NOT_READY_jfieldId == IntPtr.Zero)
					SERVICE_NOT_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_NOT_READY", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_NOT_READY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNRECOVERABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/field[@name='UNRECOVERABLE']"
		[Register ("UNRECOVERABLE")]
		public static global::Com.Amazon.Ags.Api.ErrorCode Unrecoverable {
			get {
				if (UNRECOVERABLE_jfieldId == IntPtr.Zero)
					UNRECOVERABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNRECOVERABLE", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNRECOVERABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNRECOVERABLE_jfieldId == IntPtr.Zero)
					UNRECOVERABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNRECOVERABLE", "Lcom/amazon/ags/api/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNRECOVERABLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isError;
		public bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler")]
			get {
				if (id_isError == IntPtr.Zero)
					id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isError);
			}
		}

		static IntPtr id_fromServiceResponseCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/method[@name='fromServiceResponseCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromServiceResponseCode", "(I)Lcom/amazon/ags/api/ErrorCode;", "")]
		public static global::Com.Amazon.Ags.Api.ErrorCode FromServiceResponseCode (int p0)
		{
			if (id_fromServiceResponseCode_I == IntPtr.Zero)
				id_fromServiceResponseCode_I = JNIEnv.GetStaticMethodID (class_ref, "fromServiceResponseCode", "(I)Lcom/amazon/ags/api/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromServiceResponseCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/ErrorCode;", "")]
		public static global::Com.Amazon.Ags.Api.ErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/ErrorCode;", "")]
		public static global::Com.Amazon.Ags.Api.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/ErrorCode;");
			return (global::Com.Amazon.Ags.Api.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.ErrorCode));
		}

	}
}
