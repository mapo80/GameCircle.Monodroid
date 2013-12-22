using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableDeveloperString", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker")]
	public partial interface ISyncableDeveloperString : IJavaObject {

		long CloudTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='getCloudTimestamp' and count(parameter)=0]"
			[Register ("getCloudTimestamp", "()J", "GetGetCloudTimestampHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] get;
		}

		string CloudValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='getCloudValue' and count(parameter)=0]"
			[Register ("getCloudValue", "()Ljava/lang/String;", "GetGetCloudValueHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] get;
		}

		long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] get;
		}

		string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='inConflict' and count(parameter)=0]"
		[Register ("inConflict", "()Z", "GetInConflictHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")]
		bool InConflict ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableDeveloperString']/method[@name='markAsResolved' and count(parameter)=0]"
		[Register ("markAsResolved", "()V", "GetMarkAsResolvedHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperStringInvoker, GameCircle.MonoDroid")]
		void MarkAsResolved ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableDeveloperString", DoNotGenerateAcw=true)]
	internal class ISyncableDeveloperStringInvoker : global::Java.Lang.Object, ISyncableDeveloperString {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableDeveloperString");
		IntPtr class_ref;

		public static ISyncableDeveloperString GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableDeveloperString> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableDeveloperString"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableDeveloperStringInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableDeveloperStringInvoker); }
		}

		static Delegate cb_getCloudTimestamp;
#pragma warning disable 0169
		static Delegate GetGetCloudTimestampHandler ()
		{
			if (cb_getCloudTimestamp == null)
				cb_getCloudTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCloudTimestamp);
			return cb_getCloudTimestamp;
		}

		static long n_GetCloudTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloudTimestamp;
		}
#pragma warning restore 0169

		IntPtr id_getCloudTimestamp;
		public long CloudTimestamp {
			get {
				if (id_getCloudTimestamp == IntPtr.Zero)
					id_getCloudTimestamp = JNIEnv.GetMethodID (class_ref, "getCloudTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getCloudTimestamp);
			}
		}

		static Delegate cb_getCloudValue;
#pragma warning disable 0169
		static Delegate GetGetCloudValueHandler ()
		{
			if (cb_getCloudValue == null)
				cb_getCloudValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloudValue);
			return cb_getCloudValue;
		}

		static IntPtr n_GetCloudValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CloudValue);
		}
#pragma warning restore 0169

		IntPtr id_getCloudValue;
		public string CloudValue {
			get {
				if (id_getCloudValue == IntPtr.Zero)
					id_getCloudValue = JNIEnv.GetMethodID (class_ref, "getCloudValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCloudValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isSet;
#pragma warning disable 0169
		static Delegate GetIsSetHandler ()
		{
			if (cb_isSet == null)
				cb_isSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSet);
			return cb_isSet;
		}

		static bool n_IsSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet;
		}
#pragma warning restore 0169

		IntPtr id_isSet;
		public bool IsSet {
			get {
				if (id_isSet == IntPtr.Zero)
					id_isSet = JNIEnv.GetMethodID (class_ref, "isSet", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSet);
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		IntPtr id_getTimestamp;
		public long Timestamp {
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getTimestamp);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		IntPtr id_setValue_Ljava_lang_String_;
		public string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setValue_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_inConflict;
#pragma warning disable 0169
		static Delegate GetInConflictHandler ()
		{
			if (cb_inConflict == null)
				cb_inConflict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InConflict);
			return cb_inConflict;
		}

		static bool n_InConflict (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InConflict ();
		}
#pragma warning restore 0169

		IntPtr id_inConflict;
		public bool InConflict ()
		{
			if (id_inConflict == IntPtr.Zero)
				id_inConflict = JNIEnv.GetMethodID (class_ref, "inConflict", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_inConflict);
		}

		static Delegate cb_markAsResolved;
#pragma warning disable 0169
		static Delegate GetMarkAsResolvedHandler ()
		{
			if (cb_markAsResolved == null)
				cb_markAsResolved = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkAsResolved);
			return cb_markAsResolved;
		}

		static void n_MarkAsResolved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkAsResolved ();
		}
#pragma warning restore 0169

		IntPtr id_markAsResolved;
		public void MarkAsResolved ()
		{
			if (id_markAsResolved == IntPtr.Zero)
				id_markAsResolved = JNIEnv.GetMethodID (class_ref, "markAsResolved", "()V");
			JNIEnv.CallVoidMethod (Handle, id_markAsResolved);
		}

	}

}
