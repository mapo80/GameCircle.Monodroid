using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/AGSOfflineEventManager", DoNotGenerateAcw=true)]
	public partial class AGSOfflineEventManager : global::Java.Lang.Object, global::Com.Amazon.Ags.Storage.IOfflineEventManager {


		static IntPtr storage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/field[@name='storage']"
		[Register ("storage")]
		protected global::Com.Amazon.Ags.Storage.SQLiteOfflineEventStorage Storage {
			get {
				if (storage_jfieldId == IntPtr.Zero)
					storage_jfieldId = JNIEnv.GetFieldID (class_ref, "storage", "Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, storage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.SQLiteOfflineEventStorage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (storage_jfieldId == IntPtr.Zero)
					storage_jfieldId = JNIEnv.GetFieldID (class_ref, "storage", "Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, storage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/AGSOfflineEventManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSOfflineEventManager); }
		}

		protected AGSOfflineEventManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/constructor[@name='AGSOfflineEventManager' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.storage.SQLiteOfflineEventStorage'] and parameter[2][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[3][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register (".ctor", "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;)V", "")]
		public AGSOfflineEventManager (global::Com.Amazon.Ags.Storage.SQLiteOfflineEventStorage p0, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p1, global::Com.Amazon.Ags.Html5.Service.IServiceHelper p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AGSOfflineEventManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getNetworkUtil;
#pragma warning disable 0169
		static Delegate GetGetNetworkUtilHandler ()
		{
			if (cb_getNetworkUtil == null)
				cb_getNetworkUtil = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkUtil);
			return cb_getNetworkUtil;
		}

		static IntPtr n_GetNetworkUtil (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NetworkUtil);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkUtil;
		public virtual global::Com.Amazon.Ags.Html5.Util.NetworkUtil NetworkUtil {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='getNetworkUtil' and count(parameter)=0]"
			[Register ("getNetworkUtil", "()Lcom/amazon/ags/html5/util/NetworkUtil;", "GetGetNetworkUtilHandler")]
			get {
				if (id_getNetworkUtil == IntPtr.Zero)
					id_getNetworkUtil = JNIEnv.GetMethodID (class_ref, "getNetworkUtil", "()Lcom/amazon/ags/html5/util/NetworkUtil;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.NetworkUtil> (JNIEnv.CallObjectMethod  (Handle, id_getNetworkUtil), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.NetworkUtil> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNetworkUtil), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNextEvent;
#pragma warning disable 0169
		static Delegate GetGetNextEventHandler ()
		{
			if (cb_getNextEvent == null)
				cb_getNextEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextEvent);
			return cb_getNextEvent;
		}

		static IntPtr n_GetNextEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextEvent);
		}
#pragma warning restore 0169

		static IntPtr id_getNextEvent;
		public virtual global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple NextEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='getNextEvent' and count(parameter)=0]"
			[Register ("getNextEvent", "()Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;", "GetGetNextEventHandler")]
			get {
				if (id_getNextEvent == IntPtr.Zero)
					id_getNextEvent = JNIEnv.GetMethodID (class_ref, "getNextEvent", "()Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (JNIEnv.CallObjectMethod  (Handle, id_getNextEvent), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNextEvent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onResume);
		}

		static Delegate cb_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_;
#pragma warning disable 0169
		static Delegate GetProcessOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_Handler ()
		{
			if (cb_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ == null)
				cb_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_);
			return cb_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_;
		}

		static void n_ProcessOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessOfflineEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='processOfflineEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventManager.OfflineEventTuple']]"
		[Register ("processOfflineEvent", "(Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;)V", "GetProcessOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_Handler")]
		public virtual void ProcessOfflineEvent (global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple p0)
		{
			if (id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ == IntPtr.Zero)
				id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ = JNIEnv.GetMethodID (class_ref, "processOfflineEvent", "(Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_, new JValue (p0));
		}

		static Delegate cb_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_;
#pragma warning disable 0169
		static Delegate GetRemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler ()
		{
			if (cb_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ == null)
				cb_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_);
			return cb_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		}

		static void n_RemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEventId p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V", "GetRemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler")]
		public virtual void RemoveEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0)
		{
			if (id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ == IntPtr.Zero)
				id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNIEnv.GetMethodID (class_ref, "removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0));
		}

		static Delegate cb_removeNextEvent;
#pragma warning disable 0169
		static Delegate GetRemoveNextEventHandler ()
		{
			if (cb_removeNextEvent == null)
				cb_removeNextEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveNextEvent);
			return cb_removeNextEvent;
		}

		static void n_RemoveNextEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNextEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_removeNextEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='removeNextEvent' and count(parameter)=0]"
		[Register ("removeNextEvent", "()V", "GetRemoveNextEventHandler")]
		public virtual void RemoveNextEvent ()
		{
			if (id_removeNextEvent == IntPtr.Zero)
				id_removeNextEvent = JNIEnv.GetMethodID (class_ref, "removeNextEvent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeNextEvent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeNextEvent);
		}

		static Delegate cb_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_;
#pragma warning disable 0169
		static Delegate GetSubmitEvent_Lcom_amazon_ags_storage_OfflineEvent_Handler ()
		{
			if (cb_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ == null)
				cb_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubmitEvent_Lcom_amazon_ags_storage_OfflineEvent_);
			return cb_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_;
		}

		static IntPtr n_SubmitEvent_Lcom_amazon_ags_storage_OfflineEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.AGSOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.AGSOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubmitEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSOfflineEventManager']/method[@name='submitEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEvent']]"
		[Register ("submitEvent", "(Lcom/amazon/ags/storage/OfflineEvent;)Lcom/amazon/ags/storage/OfflineEventId;", "GetSubmitEvent_Lcom_amazon_ags_storage_OfflineEvent_Handler")]
		public virtual global::Com.Amazon.Ags.Storage.OfflineEventId SubmitEvent (global::Com.Amazon.Ags.Storage.OfflineEvent p0)
		{
			if (id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ == IntPtr.Zero)
				id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ = JNIEnv.GetMethodID (class_ref, "submitEvent", "(Lcom/amazon/ags/storage/OfflineEvent;)Lcom/amazon/ags/storage/OfflineEventId;");

			global::Com.Amazon.Ags.Storage.OfflineEventId __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod  (Handle, id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
