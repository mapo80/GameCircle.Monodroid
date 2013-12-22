using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/SyncableType", DoNotGenerateAcw=true)]
	public sealed partial class SyncableType : global::Java.Lang.Enum {


		static IntPtr ACCUMULATING_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='ACCUMULATING_NUMBER']"
		[Register ("ACCUMULATING_NUMBER")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType AccumulatingNumber {
			get {
				if (ACCUMULATING_NUMBER_jfieldId == IntPtr.Zero)
					ACCUMULATING_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCUMULATING_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCUMULATING_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACCUMULATING_NUMBER_jfieldId == IntPtr.Zero)
					ACCUMULATING_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCUMULATING_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ACCUMULATING_NUMBER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVELOPER_STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='DEVELOPER_STRING']"
		[Register ("DEVELOPER_STRING")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType DeveloperString {
			get {
				if (DEVELOPER_STRING_jfieldId == IntPtr.Zero)
					DEVELOPER_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_STRING", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVELOPER_STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVELOPER_STRING_jfieldId == IntPtr.Zero)
					DEVELOPER_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_STRING", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVELOPER_STRING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HIGHEST_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='HIGHEST_NUMBER']"
		[Register ("HIGHEST_NUMBER")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType HighestNumber {
			get {
				if (HIGHEST_NUMBER_jfieldId == IntPtr.Zero)
					HIGHEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGHEST_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HIGHEST_NUMBER_jfieldId == IntPtr.Zero)
					HIGHEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HIGHEST_NUMBER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HIGHEST_NUMBER_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='HIGHEST_NUMBER_LIST']"
		[Register ("HIGHEST_NUMBER_LIST")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType HighestNumberList {
			get {
				if (HIGHEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					HIGHEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGHEST_NUMBER_LIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HIGHEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					HIGHEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HIGHEST_NUMBER_LIST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LATEST_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LATEST_NUMBER']"
		[Register ("LATEST_NUMBER")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LatestNumber {
			get {
				if (LATEST_NUMBER_jfieldId == IntPtr.Zero)
					LATEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATEST_NUMBER_jfieldId == IntPtr.Zero)
					LATEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATEST_NUMBER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LATEST_NUMBER_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LATEST_NUMBER_LIST']"
		[Register ("LATEST_NUMBER_LIST")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LatestNumberList {
			get {
				if (LATEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					LATEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_NUMBER_LIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					LATEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATEST_NUMBER_LIST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LATEST_STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LATEST_STRING']"
		[Register ("LATEST_STRING")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LatestString {
			get {
				if (LATEST_STRING_jfieldId == IntPtr.Zero)
					LATEST_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_STRING", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATEST_STRING_jfieldId == IntPtr.Zero)
					LATEST_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_STRING", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATEST_STRING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LATEST_STRING_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LATEST_STRING_LIST']"
		[Register ("LATEST_STRING_LIST")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LatestStringList {
			get {
				if (LATEST_STRING_LIST_jfieldId == IntPtr.Zero)
					LATEST_STRING_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_STRING_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_STRING_LIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATEST_STRING_LIST_jfieldId == IntPtr.Zero)
					LATEST_STRING_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_STRING_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATEST_STRING_LIST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LOWEST_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LOWEST_NUMBER']"
		[Register ("LOWEST_NUMBER")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LowestNumber {
			get {
				if (LOWEST_NUMBER_jfieldId == IntPtr.Zero)
					LOWEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWEST_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOWEST_NUMBER_jfieldId == IntPtr.Zero)
					LOWEST_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST_NUMBER", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LOWEST_NUMBER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LOWEST_NUMBER_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='LOWEST_NUMBER_LIST']"
		[Register ("LOWEST_NUMBER_LIST")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType LowestNumberList {
			get {
				if (LOWEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					LOWEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWEST_NUMBER_LIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOWEST_NUMBER_LIST_jfieldId == IntPtr.Zero)
					LOWEST_NUMBER_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWEST_NUMBER_LIST", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LOWEST_NUMBER_LIST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='MAP']"
		[Register ("MAP")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType Map {
			get {
				if (MAP_jfieldId == IntPtr.Zero)
					MAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAP", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAP_jfieldId == IntPtr.Zero)
					MAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAP", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAP_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STRING_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/field[@name='STRING_SET']"
		[Register ("STRING_SET")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType StringSet {
			get {
				if (STRING_SET_jfieldId == IntPtr.Zero)
					STRING_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_SET", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_SET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STRING_SET_jfieldId == IntPtr.Zero)
					STRING_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_SET", "Lcom/amazon/ags/client/whispersync/model/SyncableType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STRING_SET_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/SyncableType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncableType); }
		}

		internal SyncableType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getJsonName;
		public string JsonName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/method[@name='getJsonName' and count(parameter)=0]"
			[Register ("getJsonName", "()Ljava/lang/String;", "GetGetJsonNameHandler")]
			get {
				if (id_getJsonName == IntPtr.Zero)
					id_getJsonName = JNIEnv.GetMethodID (class_ref, "getJsonName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getJsonName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncableType;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncableType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncableType;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncableType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncableType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/client/whispersync/model/SyncableType;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/client/whispersync/model/SyncableType;");
			return (global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType));
		}

	}
}
