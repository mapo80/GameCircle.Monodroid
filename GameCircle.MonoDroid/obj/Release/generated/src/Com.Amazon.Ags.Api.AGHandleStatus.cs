using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/AGHandleStatus", DoNotGenerateAcw=true)]
	public sealed partial class AGHandleStatus : global::Java.Lang.Enum {


		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Amazon.Ags.Api.AGHandleStatus Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Amazon.Ags.Api.AGHandleStatus Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr WAITING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']/field[@name='WAITING']"
		[Register ("WAITING")]
		public static global::Com.Amazon.Ags.Api.AGHandleStatus Waiting {
			get {
				if (WAITING_jfieldId == IntPtr.Zero)
					WAITING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAITING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WAITING_jfieldId == IntPtr.Zero)
					WAITING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING", "Lcom/amazon/ags/api/AGHandleStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, WAITING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/AGHandleStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGHandleStatus); }
		}

		internal AGHandleStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AGHandleStatus;", "")]
		public static global::Com.Amazon.Ags.Api.AGHandleStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/api/AGHandleStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.AGHandleStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.AGHandleStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/class[@name='AGHandleStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/api/AGHandleStatus;", "")]
		public static global::Com.Amazon.Ags.Api.AGHandleStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/api/AGHandleStatus;");
			return (global::Com.Amazon.Ags.Api.AGHandleStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.AGHandleStatus));
		}

	}
}
