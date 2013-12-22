using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/IconSize", DoNotGenerateAcw=true)]
	public sealed partial class IconSize : global::Java.Lang.Enum {


		static IntPtr LARGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']/field[@name='LARGE']"
		[Register ("LARGE")]
		public static global::Com.Amazon.Ags.Constants.IconSize Large {
			get {
				if (LARGE_jfieldId == IntPtr.Zero)
					LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LARGE", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LARGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.IconSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LARGE_jfieldId == IntPtr.Zero)
					LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LARGE", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LARGE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MEDIUM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		public static global::Com.Amazon.Ags.Constants.IconSize Medium {
			get {
				if (MEDIUM_jfieldId == IntPtr.Zero)
					MEDIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIUM", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEDIUM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.IconSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MEDIUM_jfieldId == IntPtr.Zero)
					MEDIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIUM", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MEDIUM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SMALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']/field[@name='SMALL']"
		[Register ("SMALL")]
		public static global::Com.Amazon.Ags.Constants.IconSize Small {
			get {
				if (SMALL_jfieldId == IntPtr.Zero)
					SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMALL", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.IconSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SMALL_jfieldId == IntPtr.Zero)
					SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMALL", "Lcom/amazon/ags/constants/IconSize;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SMALL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/IconSize", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IconSize); }
		}

		internal IconSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/IconSize;", "")]
		public static global::Com.Amazon.Ags.Constants.IconSize ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/constants/IconSize;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Constants.IconSize __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Constants.IconSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='IconSize']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/constants/IconSize;", "")]
		public static global::Com.Amazon.Ags.Constants.IconSize[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/constants/IconSize;");
			return (global::Com.Amazon.Ags.Constants.IconSize[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Constants.IconSize));
		}

	}
}
