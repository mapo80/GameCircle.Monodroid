using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	[Register ("com/amazon/ags/api/whispersync/model/SyncableStringList")]
	public abstract class SyncableStringList {

		internal SyncableStringList ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/field[@name='DEFAULT_MAX_SIZE']"
		[Register ("DEFAULT_MAX_SIZE")]
		public const int DefaultMaxSize = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/field[@name='MAX_SIZE_LIMIT']"
		[Register ("MAX_SIZE_LIMIT")]
		public const int MaxSizeLimit = (int) 1000;
	}

	[System.Obsolete ("Use the 'SyncableStringList' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class SyncableStringListConsts : SyncableStringList {

		private SyncableStringListConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableStringList", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker")]
	public partial interface ISyncableStringList : IJavaObject {

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")] get;
		}

		int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSize", "(I)V", "GetSetMaxSize_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")]
		void Add (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(Ljava/lang/String;Ljava/util/Map;)V", "GetAdd_Ljava_lang_String_Ljava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")]
		void Add (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableStringList']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;", "GetGetValuesHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringListInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement[] GetValues ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableStringList", DoNotGenerateAcw=true)]
	internal class ISyncableStringListInvoker : global::Java.Lang.Object, ISyncableStringList {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableStringList");
		IntPtr class_ref;

		public static ISyncableStringList GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableStringList> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableStringList"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableStringListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableStringListInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getMaxSize;
#pragma warning disable 0169
		static Delegate GetGetMaxSizeHandler ()
		{
			if (cb_getMaxSize == null)
				cb_getMaxSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxSize);
			return cb_getMaxSize;
		}

		static int n_GetMaxSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxSize_I;
#pragma warning disable 0169
		static Delegate GetSetMaxSize_IHandler ()
		{
			if (cb_setMaxSize_I == null)
				cb_setMaxSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxSize_I);
			return cb_setMaxSize_I;
		}

		static void n_SetMaxSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMaxSize;
		IntPtr id_setMaxSize_I;
		public int MaxSize {
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMaxSize);
			}
			set {
				if (id_setMaxSize_I == IntPtr.Zero)
					id_setMaxSize_I = JNIEnv.GetMethodID (class_ref, "setMaxSize", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setMaxSize_I, new JValue (value));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		IntPtr id_getValues;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;");
			return (global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement));
		}

	}

}
