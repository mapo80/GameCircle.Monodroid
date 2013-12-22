using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableStringSet", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker")]
	public partial interface ISyncableStringSet : global::Java.Lang.IIterable {

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")] get;
		}

		global::System.Collections.Generic.ICollection<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/Set;", "GetGetValuesHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")]
		void Add (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(Ljava/lang/String;Ljava/util/Map;)V", "GetAdd_Ljava_lang_String_Ljava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")]
		void Add (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringSet']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;", "GetGet_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSetInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement Get (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableStringSet", DoNotGenerateAcw=true)]
	internal class ISyncableStringSetInvoker : global::Java.Lang.Object, ISyncableStringSet {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableStringSet");
		IntPtr class_ref;

		public static ISyncableStringSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableStringSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableStringSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableStringSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableStringSetInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.ToLocalJniHandle (__this.Values);
		}
#pragma warning restore 0169

		IntPtr id_getValues;
		public global::System.Collections.Generic.ICollection<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> Values {
			get {
				if (id_getValues == IntPtr.Zero)
					id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getValues), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_String_;
		public void Add (string p0)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_add_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_add_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_add_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_util_Map_);
			return cb_add_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Add_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_String_Ljava_util_Map_;
		public void Add (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_add_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_add_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_contains_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> (JNIEnv.CallObjectMethod (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

	}

}
