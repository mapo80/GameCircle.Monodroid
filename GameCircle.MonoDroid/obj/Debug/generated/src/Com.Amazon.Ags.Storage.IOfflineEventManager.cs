using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventManager.OfflineEventTuple']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventManager$OfflineEventTuple", DoNotGenerateAcw=true)]
	public partial class OfflineEventManagerOfflineEventTuple : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventManager$OfflineEventTuple", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineEventManagerOfflineEventTuple); }
		}

		protected OfflineEventManagerOfflineEventTuple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lcom_amazon_ags_storage_OfflineEvent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventManager.OfflineEventTuple']/constructor[@name='OfflineEventManager.OfflineEventTuple' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId'] and parameter[2][@type='com.amazon.ags.storage.OfflineEvent']]"
		[Register (".ctor", "(Lcom/amazon/ags/storage/OfflineEventId;Lcom/amazon/ags/storage/OfflineEvent;)V", "")]
		public OfflineEventManagerOfflineEventTuple (global::Com.Amazon.Ags.Storage.OfflineEventId p0, global::Com.Amazon.Ags.Storage.OfflineEvent p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OfflineEventManagerOfflineEventTuple)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/storage/OfflineEventId;Lcom/amazon/ags/storage/OfflineEvent;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/storage/OfflineEventId;Lcom/amazon/ags/storage/OfflineEvent;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lcom_amazon_ags_storage_OfflineEvent_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lcom_amazon_ags_storage_OfflineEvent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/storage/OfflineEventId;Lcom/amazon/ags/storage/OfflineEvent;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lcom_amazon_ags_storage_OfflineEvent_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lcom_amazon_ags_storage_OfflineEvent_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual global::Com.Amazon.Ags.Storage.OfflineEventId EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventManager.OfflineEventTuple']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Lcom/amazon/ags/storage/OfflineEventId;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Lcom/amazon/ags/storage/OfflineEventId;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod  (Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEventId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOfflineEvent;
#pragma warning disable 0169
		static Delegate GetGetOfflineEventHandler ()
		{
			if (cb_getOfflineEvent == null)
				cb_getOfflineEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOfflineEvent);
			return cb_getOfflineEvent;
		}

		static IntPtr n_GetOfflineEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OfflineEvent);
		}
#pragma warning restore 0169

		static IntPtr id_getOfflineEvent;
		public virtual global::Com.Amazon.Ags.Storage.OfflineEvent OfflineEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventManager.OfflineEventTuple']/method[@name='getOfflineEvent' and count(parameter)=0]"
			[Register ("getOfflineEvent", "()Lcom/amazon/ags/storage/OfflineEvent;", "GetGetOfflineEventHandler")]
			get {
				if (id_getOfflineEvent == IntPtr.Zero)
					id_getOfflineEvent = JNIEnv.GetMethodID (class_ref, "getOfflineEvent", "()Lcom/amazon/ags/storage/OfflineEvent;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (JNIEnv.CallObjectMethod  (Handle, id_getOfflineEvent), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOfflineEvent), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']"
	[Register ("com/amazon/ags/storage/OfflineEventManager", "", "Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker")]
	public partial interface IOfflineEventManager : IJavaObject {

		global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple NextEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='getNextEvent' and count(parameter)=0]"
			[Register ("getNextEvent", "()Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;", "GetGetNextEventHandler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='processOfflineEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventManager.OfflineEventTuple']]"
		[Register ("processOfflineEvent", "(Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;)V", "GetProcessOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_Handler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		void ProcessOfflineEvent (global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V", "GetRemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		void RemoveEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='removeNextEvent' and count(parameter)=0]"
		[Register ("removeNextEvent", "()V", "GetRemoveNextEventHandler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		void RemoveNextEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventManager']/method[@name='submitEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEvent']]"
		[Register ("submitEvent", "(Lcom/amazon/ags/storage/OfflineEvent;)Lcom/amazon/ags/storage/OfflineEventId;", "GetSubmitEvent_Lcom_amazon_ags_storage_OfflineEvent_Handler:Com.Amazon.Ags.Storage.IOfflineEventManagerInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Storage.OfflineEventId SubmitEvent (global::Com.Amazon.Ags.Storage.OfflineEvent p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventManager", DoNotGenerateAcw=true)]
	internal class IOfflineEventManagerInvoker : global::Java.Lang.Object, IOfflineEventManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventManager");
		IntPtr class_ref;

		public static IOfflineEventManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOfflineEventManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.storage.OfflineEventManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOfflineEventManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOfflineEventManagerInvoker); }
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextEvent);
		}
#pragma warning restore 0169

		IntPtr id_getNextEvent;
		public global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple NextEvent {
			get {
				if (id_getNextEvent == IntPtr.Zero)
					id_getNextEvent = JNIEnv.GetMethodID (class_ref, "getNextEvent", "()Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (JNIEnv.CallObjectMethod (Handle, id_getNextEvent), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPause);
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onResume);
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessOfflineEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_;
		public void ProcessOfflineEvent (global::Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple p0)
		{
			if (id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ == IntPtr.Zero)
				id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_ = JNIEnv.GetMethodID (class_ref, "processOfflineEvent", "(Lcom/amazon/ags/storage/OfflineEventManager$OfflineEventTuple;)V");
			JNIEnv.CallVoidMethod (Handle, id_processOfflineEvent_Lcom_amazon_ags_storage_OfflineEventManager_OfflineEventTuple_, new JValue (p0));
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEventId p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		public void RemoveEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0)
		{
			if (id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ == IntPtr.Zero)
				id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNIEnv.GetMethodID (class_ref, "removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V");
			JNIEnv.CallVoidMethod (Handle, id_removeEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0));
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNextEvent ();
		}
#pragma warning restore 0169

		IntPtr id_removeNextEvent;
		public void RemoveNextEvent ()
		{
			if (id_removeNextEvent == IntPtr.Zero)
				id_removeNextEvent = JNIEnv.GetMethodID (class_ref, "removeNextEvent", "()V");
			JNIEnv.CallVoidMethod (Handle, id_removeNextEvent);
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
			global::Com.Amazon.Ags.Storage.IOfflineEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubmitEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_;
		public global::Com.Amazon.Ags.Storage.OfflineEventId SubmitEvent (global::Com.Amazon.Ags.Storage.OfflineEvent p0)
		{
			if (id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ == IntPtr.Zero)
				id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_ = JNIEnv.GetMethodID (class_ref, "submitEvent", "(Lcom/amazon/ags/storage/OfflineEvent;)Lcom/amazon/ags/storage/OfflineEventId;");
			global::Com.Amazon.Ags.Storage.OfflineEventId __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod (Handle, id_submitEvent_Lcom_amazon_ags_storage_OfflineEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
