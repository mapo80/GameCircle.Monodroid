using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	[Register ("com/amazon/ags/api/whispersync/model/SyncableNumberList")]
	public abstract class SyncableNumberList {

		internal SyncableNumberList ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/field[@name='DEFAULT_MAX_SIZE']"
		[Register ("DEFAULT_MAX_SIZE")]
		public const int DefaultMaxSize = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/field[@name='MAX_SIZE_LIMIT']"
		[Register ("MAX_SIZE_LIMIT")]
		public const int MaxSizeLimit = (int) 1000;
	}

	[System.Obsolete ("Use the 'SyncableNumberList' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class SyncableNumberListConsts : SyncableNumberList {

		private SyncableNumberListConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableNumberList", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker")]
	public partial interface ISyncableNumberList : IJavaObject {

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")] get;
		}

		int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSize", "(I)V", "GetSetMaxSize_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("add", "(D)V", "GetAdd_DHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(DLjava/util/Map;)V", "GetAdd_DLjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (double p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("add", "(I)V", "GetAdd_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(ILjava/util/Map;)V", "GetAdd_ILjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (int p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(Ljava/lang/String;Ljava/util/Map;)V", "GetAdd_Ljava_lang_String_Ljava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("add", "(J)V", "GetAdd_JHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(JLjava/util/Map;)V", "GetAdd_JLjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		void Add (long p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberList']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[Lcom/amazon/ags/api/whispersync/model/SyncableNumberElement;", "GetGetValuesHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberListInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement[] GetValues ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableNumberList", DoNotGenerateAcw=true)]
	internal class ISyncableNumberListInvoker : global::Java.Lang.Object, ISyncableNumberList {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableNumberList");
		IntPtr class_ref;

		public static ISyncableNumberList GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableNumberList> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableNumberList"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableNumberListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableNumberListInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_add_D;
#pragma warning disable 0169
		static Delegate GetAdd_DHandler ()
		{
			if (cb_add_D == null)
				cb_add_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Add_D);
			return cb_add_D;
		}

		static void n_Add_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_D;
		public void Add (double p0)
		{
			if (id_add_D == IntPtr.Zero)
				id_add_D = JNIEnv.GetMethodID (class_ref, "add", "(D)V");
			JNIEnv.CallVoidMethod (Handle, id_add_D, new JValue (p0));
		}

		static Delegate cb_add_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdd_DLjava_util_Map_Handler ()
		{
			if (cb_add_DLjava_util_Map_ == null)
				cb_add_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_Add_DLjava_util_Map_);
			return cb_add_DLjava_util_Map_;
		}

		static void n_Add_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_DLjava_util_Map_;
		public void Add (double p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_add_DLjava_util_Map_ == IntPtr.Zero)
				id_add_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "add", "(DLjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_add_DLjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_add_I;
#pragma warning disable 0169
		static Delegate GetAdd_IHandler ()
		{
			if (cb_add_I == null)
				cb_add_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Add_I);
			return cb_add_I;
		}

		static void n_Add_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_I;
		public void Add (int p0)
		{
			if (id_add_I == IntPtr.Zero)
				id_add_I = JNIEnv.GetMethodID (class_ref, "add", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_add_I, new JValue (p0));
		}

		static Delegate cb_add_ILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdd_ILjava_util_Map_Handler ()
		{
			if (cb_add_ILjava_util_Map_ == null)
				cb_add_ILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILjava_util_Map_);
			return cb_add_ILjava_util_Map_;
		}

		static void n_Add_ILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_ILjava_util_Map_;
		public void Add (int p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_add_ILjava_util_Map_ == IntPtr.Zero)
				id_add_ILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_add_ILjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_add_J;
#pragma warning disable 0169
		static Delegate GetAdd_JHandler ()
		{
			if (cb_add_J == null)
				cb_add_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Add_J);
			return cb_add_J;
		}

		static void n_Add_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_J;
		public void Add (long p0)
		{
			if (id_add_J == IntPtr.Zero)
				id_add_J = JNIEnv.GetMethodID (class_ref, "add", "(J)V");
			JNIEnv.CallVoidMethod (Handle, id_add_J, new JValue (p0));
		}

		static Delegate cb_add_JLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdd_JLjava_util_Map_Handler ()
		{
			if (cb_add_JLjava_util_Map_ == null)
				cb_add_JLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_Add_JLjava_util_Map_);
			return cb_add_JLjava_util_Map_;
		}

		static void n_Add_JLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_JLjava_util_Map_;
		public void Add (long p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_add_JLjava_util_Map_ == IntPtr.Zero)
				id_add_JLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "add", "(JLjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_add_JLjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		IntPtr id_getValues;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[Lcom/amazon/ags/api/whispersync/model/SyncableNumberElement;");
			return (global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement));
		}

	}

}
