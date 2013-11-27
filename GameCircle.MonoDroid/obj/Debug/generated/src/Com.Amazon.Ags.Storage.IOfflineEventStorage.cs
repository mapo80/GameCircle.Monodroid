using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventStorage.OfflineEventJSONTuple']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventStorage$OfflineEventJSONTuple", DoNotGenerateAcw=true)]
	public partial class OfflineEventStorageOfflineEventJSONTuple : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventStorage$OfflineEventJSONTuple", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineEventStorageOfflineEventJSONTuple); }
		}

		protected OfflineEventStorageOfflineEventJSONTuple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventStorage.OfflineEventJSONTuple']/constructor[@name='OfflineEventStorage.OfflineEventJSONTuple' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lcom/amazon/ags/storage/OfflineEventId;Lorg/json/JSONObject;)V", "")]
		public OfflineEventStorageOfflineEventJSONTuple (global::Com.Amazon.Ags.Storage.OfflineEventId p0, global::Org.Json.JSONObject p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OfflineEventStorageOfflineEventJSONTuple)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/storage/OfflineEventId;Lorg/json/JSONObject;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/storage/OfflineEventId;Lorg/json/JSONObject;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/storage/OfflineEventId;Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_storage_OfflineEventId_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1));
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
			global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual global::Com.Amazon.Ags.Storage.OfflineEventId EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventStorage.OfflineEventJSONTuple']/method[@name='getEventId' and count(parameter)=0]"
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

		static Delegate cb_getJSONOfflineEvent;
#pragma warning disable 0169
		static Delegate GetGetJSONOfflineEventHandler ()
		{
			if (cb_getJSONOfflineEvent == null)
				cb_getJSONOfflineEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSONOfflineEvent);
			return cb_getJSONOfflineEvent;
		}

		static IntPtr n_GetJSONOfflineEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSONOfflineEvent);
		}
#pragma warning restore 0169

		static IntPtr id_getJSONOfflineEvent;
		public virtual global::Org.Json.JSONObject JSONOfflineEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventStorage.OfflineEventJSONTuple']/method[@name='getJSONOfflineEvent' and count(parameter)=0]"
			[Register ("getJSONOfflineEvent", "()Lorg/json/JSONObject;", "GetGetJSONOfflineEventHandler")]
			get {
				if (id_getJSONOfflineEvent == IntPtr.Zero)
					id_getJSONOfflineEvent = JNIEnv.GetMethodID (class_ref, "getJSONOfflineEvent", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSONOfflineEvent), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getJSONOfflineEvent), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']"
	[Register ("com/amazon/ags/storage/OfflineEventStorage", "", "Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker")]
	public partial interface IOfflineEventStorage : IJavaObject {

		global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple> AllEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='getAllEvents' and count(parameter)=0]"
			[Register ("getAllEvents", "()Ljava/util/List;", "GetGetAllEventsHandler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")] get;
		}

		int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='getEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("getEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)Lorg/json/JSONObject;", "GetGetEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")]
		global::Org.Json.JSONObject GetEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='peekEvent' and count(parameter)=0]"
		[Register ("peekEvent", "()Lcom/amazon/ags/storage/OfflineEventId;", "GetPeekEventHandler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Storage.OfflineEventId PeekEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='removeAllEvents' and count(parameter)=0]"
		[Register ("removeAllEvents", "()V", "GetRemoveAllEventsHandler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")]
		void RemoveAllEvents ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineEventId']]"
		[Register ("removeEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)V", "GetRemoveEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")]
		void RemoveEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineEventStorage']/method[@name='storeEvent' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("storeEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/storage/OfflineEventId;", "GetStoreEvent_Lorg_json_JSONObject_Handler:Com.Amazon.Ags.Storage.IOfflineEventStorageInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Storage.OfflineEventId StoreEvent (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventStorage", DoNotGenerateAcw=true)]
	internal class IOfflineEventStorageInvoker : global::Java.Lang.Object, IOfflineEventStorage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventStorage");
		IntPtr class_ref;

		public static IOfflineEventStorage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOfflineEventStorage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.storage.OfflineEventStorage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOfflineEventStorageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOfflineEventStorageInvoker); }
		}

		static Delegate cb_getAllEvents;
#pragma warning disable 0169
		static Delegate GetGetAllEventsHandler ()
		{
			if (cb_getAllEvents == null)
				cb_getAllEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllEvents);
			return cb_getAllEvents;
		}

		static IntPtr n_GetAllEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple>.ToLocalJniHandle (__this.AllEvents);
		}
#pragma warning restore 0169

		IntPtr id_getAllEvents;
		public global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple> AllEvents {
			get {
				if (id_getAllEvents == IntPtr.Zero)
					id_getAllEvents = JNIEnv.GetMethodID (class_ref, "getAllEvents", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllEvents), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		IntPtr id_getSize;
		public int Size {
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getSize);
			}
		}

		static Delegate cb_getEvent_Lcom_amazon_ags_storage_OfflineEventId_;
#pragma warning disable 0169
		static Delegate GetGetEvent_Lcom_amazon_ags_storage_OfflineEventId_Handler ()
		{
			if (cb_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ == null)
				cb_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEvent_Lcom_amazon_ags_storage_OfflineEventId_);
			return cb_getEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		}

		static IntPtr n_GetEvent_Lcom_amazon_ags_storage_OfflineEventId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineEventId p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_;
		public global::Org.Json.JSONObject GetEvent (global::Com.Amazon.Ags.Storage.OfflineEventId p0)
		{
			if (id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ == IntPtr.Zero)
				id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_ = JNIEnv.GetMethodID (class_ref, "getEvent", "(Lcom/amazon/ags/storage/OfflineEventId;)Lorg/json/JSONObject;");
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getEvent_Lcom_amazon_ags_storage_OfflineEventId_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_peekEvent;
#pragma warning disable 0169
		static Delegate GetPeekEventHandler ()
		{
			if (cb_peekEvent == null)
				cb_peekEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekEvent);
			return cb_peekEvent;
		}

		static IntPtr n_PeekEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekEvent ());
		}
#pragma warning restore 0169

		IntPtr id_peekEvent;
		public global::Com.Amazon.Ags.Storage.OfflineEventId PeekEvent ()
		{
			if (id_peekEvent == IntPtr.Zero)
				id_peekEvent = JNIEnv.GetMethodID (class_ref, "peekEvent", "()Lcom/amazon/ags/storage/OfflineEventId;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod (Handle, id_peekEvent), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeAllEvents;
#pragma warning disable 0169
		static Delegate GetRemoveAllEventsHandler ()
		{
			if (cb_removeAllEvents == null)
				cb_removeAllEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllEvents);
			return cb_removeAllEvents;
		}

		static void n_RemoveAllEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllEvents ();
		}
#pragma warning restore 0169

		IntPtr id_removeAllEvents;
		public void RemoveAllEvents ()
		{
			if (id_removeAllEvents == IntPtr.Zero)
				id_removeAllEvents = JNIEnv.GetMethodID (class_ref, "removeAllEvents", "()V");
			JNIEnv.CallVoidMethod (Handle, id_removeAllEvents);
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
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_storeEvent_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetStoreEvent_Lorg_json_JSONObject_Handler ()
		{
			if (cb_storeEvent_Lorg_json_JSONObject_ == null)
				cb_storeEvent_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StoreEvent_Lorg_json_JSONObject_);
			return cb_storeEvent_Lorg_json_JSONObject_;
		}

		static IntPtr n_StoreEvent_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineEventStorage __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineEventStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StoreEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_storeEvent_Lorg_json_JSONObject_;
		public global::Com.Amazon.Ags.Storage.OfflineEventId StoreEvent (global::Org.Json.JSONObject p0)
		{
			if (id_storeEvent_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_storeEvent_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "storeEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/storage/OfflineEventId;");
			global::Com.Amazon.Ags.Storage.OfflineEventId __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (JNIEnv.CallObjectMethod (Handle, id_storeEvent_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
