using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/SyncState", DoNotGenerateAcw=true)]
	public sealed partial class SyncState : global::Java.Lang.Enum {


		static IntPtr DIRTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/field[@name='DIRTY']"
		[Register ("DIRTY")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState Dirty {
			get {
				if (DIRTY_jfieldId == IntPtr.Zero)
					DIRTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRTY", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRTY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIRTY_jfieldId == IntPtr.Zero)
					DIRTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRTY", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DIRTY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr IN_CONFLICT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/field[@name='IN_CONFLICT']"
		[Register ("IN_CONFLICT")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState InConflict {
			get {
				if (IN_CONFLICT_jfieldId == IntPtr.Zero)
					IN_CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_CONFLICT", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_CONFLICT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IN_CONFLICT_jfieldId == IntPtr.Zero)
					IN_CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_CONFLICT", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, IN_CONFLICT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState NotSet {
			get {
				if (NOT_SET_jfieldId == IntPtr.Zero)
					NOT_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SET", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_SET_jfieldId == IntPtr.Zero)
					NOT_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SET", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_SET_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SYNCED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/field[@name='SYNCED']"
		[Register ("SYNCED")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState Synced {
			get {
				if (SYNCED_jfieldId == IntPtr.Zero)
					SYNCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCED", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYNCED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SYNCED_jfieldId == IntPtr.Zero)
					SYNCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCED", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SYNCED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SYNCING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/field[@name='SYNCING']"
		[Register ("SYNCING")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState Syncing {
			get {
				if (SYNCING_jfieldId == IntPtr.Zero)
					SYNCING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCING", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYNCING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SYNCING_jfieldId == IntPtr.Zero)
					SYNCING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCING", "Lcom/amazon/ags/client/whispersync/model/SyncState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SYNCING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/SyncState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncState); }
		}

		internal SyncState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncState;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/model/SyncState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='SyncState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/client/whispersync/model/SyncState;", "")]
		public static global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/client/whispersync/model/SyncState;");
			return (global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState));
		}

	}
}
