using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/AuthorizeResult", DoNotGenerateAcw=true)]
	public sealed partial class AuthorizeResult : global::Java.Lang.Enum {


		static IntPtr AUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']/field[@name='AUTHORIZED']"
		[Register ("AUTHORIZED")]
		public static global::Com.Amazon.Ags.Constants.AuthorizeResult Authorized {
			get {
				if (AUTHORIZED_jfieldId == IntPtr.Zero)
					AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZED", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.AuthorizeResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTHORIZED_jfieldId == IntPtr.Zero)
					AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZED", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, AUTHORIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CANNOT_AUTHORIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']/field[@name='CANNOT_AUTHORIZE']"
		[Register ("CANNOT_AUTHORIZE")]
		public static global::Com.Amazon.Ags.Constants.AuthorizeResult CannotAuthorize {
			get {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_AUTHORIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.AuthorizeResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANNOT_AUTHORIZE_jfieldId == IntPtr.Zero)
					CANNOT_AUTHORIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_AUTHORIZE", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANNOT_AUTHORIZE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_AUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']/field[@name='NOT_AUTHORIZED']"
		[Register ("NOT_AUTHORIZED")]
		public static global::Com.Amazon.Ags.Constants.AuthorizeResult NotAuthorized {
			get {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.AuthorizeResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
					NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/amazon/ags/constants/AuthorizeResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_AUTHORIZED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/AuthorizeResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizeResult); }
		}

		internal AuthorizeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/AuthorizeResult;", "")]
		public static global::Com.Amazon.Ags.Constants.AuthorizeResult ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/AuthorizeResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.AuthorizeResult __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.AuthorizeResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeResult']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/AuthorizeResult;", "")]
		public static global::Com.Amazon.Ags.Constants.AuthorizeResult[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/AuthorizeResult;");
			return (global::Com.Amazon.Ags.Constants.AuthorizeResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.AuthorizeResult));
		}

	}
}
