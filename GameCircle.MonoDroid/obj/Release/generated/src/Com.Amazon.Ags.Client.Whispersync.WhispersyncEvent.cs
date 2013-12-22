using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/WhispersyncEvent", DoNotGenerateAcw=true)]
	public sealed partial class WhispersyncEvent : global::Java.Lang.Enum {


		static IntPtr DATA_UPLOADED_TO_CLOUD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/field[@name='DATA_UPLOADED_TO_CLOUD']"
		[Register ("DATA_UPLOADED_TO_CLOUD")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent DataUploadedToCloud {
			get {
				if (DATA_UPLOADED_TO_CLOUD_jfieldId == IntPtr.Zero)
					DATA_UPLOADED_TO_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_UPLOADED_TO_CLOUD", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_UPLOADED_TO_CLOUD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DATA_UPLOADED_TO_CLOUD_jfieldId == IntPtr.Zero)
					DATA_UPLOADED_TO_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_UPLOADED_TO_CLOUD", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DATA_UPLOADED_TO_CLOUD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DISK_WRITE_COMPLETE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/field[@name='DISK_WRITE_COMPLETE']"
		[Register ("DISK_WRITE_COMPLETE")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent DiskWriteComplete {
			get {
				if (DISK_WRITE_COMPLETE_jfieldId == IntPtr.Zero)
					DISK_WRITE_COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISK_WRITE_COMPLETE", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISK_WRITE_COMPLETE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DISK_WRITE_COMPLETE_jfieldId == IntPtr.Zero)
					DISK_WRITE_COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISK_WRITE_COMPLETE", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DISK_WRITE_COMPLETE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FIRST_SYNC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/field[@name='FIRST_SYNC']"
		[Register ("FIRST_SYNC")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent FirstSync {
			get {
				if (FIRST_SYNC_jfieldId == IntPtr.Zero)
					FIRST_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIRST_SYNC", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIRST_SYNC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FIRST_SYNC_jfieldId == IntPtr.Zero)
					FIRST_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIRST_SYNC", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FIRST_SYNC_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NEW_DATA_FROM_CLOUD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/field[@name='NEW_DATA_FROM_CLOUD']"
		[Register ("NEW_DATA_FROM_CLOUD")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent NewDataFromCloud {
			get {
				if (NEW_DATA_FROM_CLOUD_jfieldId == IntPtr.Zero)
					NEW_DATA_FROM_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW_DATA_FROM_CLOUD", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_DATA_FROM_CLOUD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NEW_DATA_FROM_CLOUD_jfieldId == IntPtr.Zero)
					NEW_DATA_FROM_CLOUD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW_DATA_FROM_CLOUD", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NEW_DATA_FROM_CLOUD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr THROTTLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/field[@name='THROTTLED']"
		[Register ("THROTTLED")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent Throttled {
			get {
				if (THROTTLED_jfieldId == IntPtr.Zero)
					THROTTLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THROTTLED", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THROTTLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (THROTTLED_jfieldId == IntPtr.Zero)
					THROTTLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THROTTLED", "Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, THROTTLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/WhispersyncEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncEvent); }
		}

		internal WhispersyncEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/WhispersyncEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEvent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/client/whispersync/WhispersyncEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/client/whispersync/WhispersyncEvent;");
			return (global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent));
		}

	}
}
