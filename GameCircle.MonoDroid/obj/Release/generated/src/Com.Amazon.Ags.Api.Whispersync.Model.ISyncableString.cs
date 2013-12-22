using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableString']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableString", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringInvoker")]
	public partial interface ISyncableString : global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement {

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableString']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableString']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringInvoker, GameCircle.MonoDroid")]
		void Set (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableString']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSet_Ljava_lang_String_Ljava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringInvoker, GameCircle.MonoDroid")]
		void Set (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableString", DoNotGenerateAcw=true)]
	internal class ISyncableStringInvoker : global::Java.Lang.Object, ISyncableString {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableString");
		IntPtr class_ref;

		public static ISyncableString GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableString> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableString"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableStringInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableStringInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_;
		}

		static void n_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_;
		public void Set (string p0)
		{
			if (id_set_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_set_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_set_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_util_Map_);
			return cb_set_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Set_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_Ljava_util_Map_;
		public void Set (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_set_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		public string Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public global::System.Collections.Generic.IDictionary<string, string> Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
