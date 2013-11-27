using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/whispersync/MergePolicy", DoNotGenerateAcw=true)]
	public sealed partial class MergePolicy : global::Java.Lang.Enum {


		static IntPtr HIGHEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/field[@name='HIGHEST']"
		[Register ("HIGHEST")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy Highest {
			get {
				if (HIGHEST_jfieldId == IntPtr.Zero)
					HIGHEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGHEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HIGHEST_jfieldId == IntPtr.Zero)
					HIGHEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HIGHEST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LATEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/field[@name='LATEST']"
		[Register ("LATEST")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy Latest {
			get {
				if (LATEST_jfieldId == IntPtr.Zero)
					LATEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATEST_jfieldId == IntPtr.Zero)
					LATEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATEST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LOWEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/field[@name='LOWEST']"
		[Register ("LOWEST")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy Lowest {
			get {
				if (LOWEST_jfieldId == IntPtr.Zero)
					LOWEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOWEST_jfieldId == IntPtr.Zero)
					LOWEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LOWEST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/amazon/ags/jni/whispersync/MergePolicy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/whispersync/MergePolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MergePolicy); }
		}

		internal MergePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_mergePolicyFromInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/method[@name='mergePolicyFromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mergePolicyFromInt", "(I)Lcom/amazon/ags/jni/whispersync/MergePolicy;", "")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy MergePolicyFromInt (int p0)
		{
			if (id_mergePolicyFromInt_I == IntPtr.Zero)
				id_mergePolicyFromInt_I = JNIEnv.GetStaticMethodID (class_ref, "mergePolicyFromInt", "(I)Lcom/amazon/ags/jni/whispersync/MergePolicy;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergePolicyFromInt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/jni/whispersync/MergePolicy;", "")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/jni/whispersync/MergePolicy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='MergePolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/jni/whispersync/MergePolicy;", "")]
		public static global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/jni/whispersync/MergePolicy;");
			return (global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Jni.Whispersync.MergePolicy));
		}

	}
}
