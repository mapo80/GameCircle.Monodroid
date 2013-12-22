using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/StringSet", DoNotGenerateAcw=true)]
	public partial class StringSet : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/StringSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringSet); }
		}

		protected StringSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/constructor[@name='StringSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public StringSet (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (StringSet)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_client_whispersync_model_SyncState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/constructor[@name='StringSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set'] and parameter[3][@type='com.amazon.ags.client.whispersync.model.SyncState']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", "")]
		public StringSet (string p0, global::System.Collections.Generic.ICollection<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> p1, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (StringSet)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_client_whispersync_model_SyncState_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_client_whispersync_model_SyncState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Set;Lcom/amazon/ags/client/whispersync/model/SyncState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Set_Lcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet;
		}
#pragma warning restore 0169

		static IntPtr id_isSet;
		public virtual bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler")]
			get {
				if (id_isSet == IntPtr.Zero)
					id_isSet = JNIEnv.GetMethodID (class_ref, "isSet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isSet);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallObjectMethod  (Handle, id_getState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getState), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.ToLocalJniHandle (__this.Values);
		}
#pragma warning restore 0169

		static IntPtr id_getValues;
		public virtual global::System.Collections.Generic.ICollection<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/Set;", "GetGetValuesHandler")]
			get {
				if (id_getValues == IntPtr.Zero)
					id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getValues), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getValues), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler")]
		public virtual void Add (string p0)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("add", "(Ljava/lang/String;Ljava/util/Map;)V", "GetAdd_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual void Add (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_add_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_completeSyncing;
#pragma warning disable 0169
		static Delegate GetCompleteSyncingHandler ()
		{
			if (cb_completeSyncing == null)
				cb_completeSyncing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CompleteSyncing);
			return cb_completeSyncing;
		}

		static void n_CompleteSyncing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompleteSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_completeSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='completeSyncing' and count(parameter)=0]"
		[Register ("completeSyncing", "()V", "GetCompleteSyncingHandler")]
		public virtual void CompleteSyncing ()
		{
			if (id_completeSyncing == IntPtr.Zero)
				id_completeSyncing = JNIEnv.GetMethodID (class_ref, "completeSyncing", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_completeSyncing);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_completeSyncing);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
		public virtual bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_contains_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_deepCopy;
#pragma warning disable 0169
		static Delegate GetDeepCopyHandler ()
		{
			if (cb_deepCopy == null)
				cb_deepCopy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeepCopy);
			return cb_deepCopy;
		}

		static IntPtr n_DeepCopy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeepCopy ());
		}
#pragma warning restore 0169

		static IntPtr id_deepCopy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/amazon/ags/client/whispersync/model/StringSet;", "GetDeepCopyHandler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/amazon/ags/client/whispersync/model/StringSet;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (JNIEnv.CallObjectMethod  (Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_deepCopy), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;", "GetGet_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringElement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringElement> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_;
#pragma warning disable 0169
		static Delegate GetMerge_Lcom_amazon_ags_client_whispersync_model_StringSet_Handler ()
		{
			if (cb_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_ == null)
				cb_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Merge_Lcom_amazon_ags_client_whispersync_model_StringSet_);
			return cb_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_;
		}

		static void n_Merge_Lcom_amazon_ags_client_whispersync_model_StringSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Merge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.model.StringSet']]"
		[Register ("merge", "(Lcom/amazon/ags/client/whispersync/model/StringSet;)V", "GetMerge_Lcom_amazon_ags_client_whispersync_model_StringSet_Handler")]
		public virtual void Merge (global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet p0)
		{
			if (id_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_ == IntPtr.Zero)
				id_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lcom/amazon/ags/client/whispersync/model/StringSet;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_merge_Lcom_amazon_ags_client_whispersync_model_StringSet_, new JValue (p0));
		}

		static Delegate cb_startSyncing;
#pragma warning disable 0169
		static Delegate GetStartSyncingHandler ()
		{
			if (cb_startSyncing == null)
				cb_startSyncing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartSyncing);
			return cb_startSyncing;
		}

		static void n_StartSyncing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.StringSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_startSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='StringSet']/method[@name='startSyncing' and count(parameter)=0]"
		[Register ("startSyncing", "()V", "GetStartSyncingHandler")]
		public virtual void StartSyncing ()
		{
			if (id_startSyncing == IntPtr.Zero)
				id_startSyncing = JNIEnv.GetMethodID (class_ref, "startSyncing", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startSyncing);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startSyncing);
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Client.Whispersync.Model.IMergeable
		global::Java.Lang.Object global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable.DeepCopy ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(DeepCopy ());
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Client.Whispersync.Model.IMergeable
		void global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable.Merge (global::Java.Lang.Object p0)
		{
			Merge (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Client.Whispersync.Model.StringSet>(p0));
		}

	}
}
