using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/LatestString", DoNotGenerateAcw=true)]
	public partial class LatestString : global::Com.Amazon.Ags.Client.Whispersync.Model.StringElement, global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/LatestString", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatestString); }
		}

		protected LatestString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/constructor[@name='LatestString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public LatestString (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (LatestString)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_JLcom_amazon_ags_client_whispersync_model_SyncState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/constructor[@name='LatestString' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='long'] and parameter[5][@type='com.amazon.ags.client.whispersync.model.SyncState']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;JLcom/amazon/ags/client/whispersync/model/SyncState;)V", "")]
		public LatestString (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2, long p3, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);;
			if (GetType () != typeof (LatestString)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;JLcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;JLcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_JLcom_amazon_ags_client_whispersync_model_SyncState_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_JLcom_amazon_ags_client_whispersync_model_SyncState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;JLcom/amazon/ags/client/whispersync/model/SyncState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_JLcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_JLcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (native_p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet;
		}
#pragma warning restore 0169

		static IntPtr id_isSet;
		public virtual bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='isSet' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='getState' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompleteSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_completeSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='completeSyncing' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeepCopy ());
		}
#pragma warning restore 0169

		static IntPtr id_deepCopy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/amazon/ags/client/whispersync/model/LatestString;", "GetDeepCopyHandler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/amazon/ags/client/whispersync/model/LatestString;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (JNIEnv.CallObjectMethod  (Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_deepCopy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_;
#pragma warning disable 0169
		static Delegate GetMerge_Lcom_amazon_ags_client_whispersync_model_LatestString_Handler ()
		{
			if (cb_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_ == null)
				cb_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Merge_Lcom_amazon_ags_client_whispersync_model_LatestString_);
			return cb_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_;
		}

		static void n_Merge_Lcom_amazon_ags_client_whispersync_model_LatestString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Merge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.model.LatestString']]"
		[Register ("merge", "(Lcom/amazon/ags/client/whispersync/model/LatestString;)V", "GetMerge_Lcom_amazon_ags_client_whispersync_model_LatestString_Handler")]
		public virtual void Merge (global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString p0)
		{
			if (id_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_ == IntPtr.Zero)
				id_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lcom/amazon/ags/client/whispersync/model/LatestString;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_merge_Lcom_amazon_ags_client_whispersync_model_LatestString_, new JValue (p0));
		}

		static Delegate cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
#pragma warning disable 0169
		static Delegate GetReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_Handler ()
		{
			if (cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ == null)
				cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_);
			return cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
		}

		static void n_ReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='reportEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.client.whispersync.model.SyncableType']]"
		[Register ("reportEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)V", "GetReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_Handler")]
		protected virtual void ReportEvent (string p0, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType p1)
		{
			if (id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ == IntPtr.Zero)
				id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ = JNIEnv.GetMethodID (class_ref, "reportEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler")]
		public virtual void Set (string p0)
		{
			if (id_set_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_set_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSet_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual void Set (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_set_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_startSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestString']/method[@name='startSyncing' and count(parameter)=0]"
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
			Merge (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Client.Whispersync.Model.LatestString>(p0));
		}

	}
}
