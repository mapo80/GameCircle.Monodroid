using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']"
	[Register ("com/amazon/ags/client/whispersync/model/Mergeable", "", "Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker")]
	public partial interface IMergeable : IJavaObject {

		global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;", "GetGetStateHandler:Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']/method[@name='completeSyncing' and count(parameter)=0]"
		[Register ("completeSyncing", "()V", "GetCompleteSyncingHandler:Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker, GameCircle.MonoDroid")]
		void CompleteSyncing ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/amazon/ags/client/whispersync/model/Mergeable;", "GetDeepCopyHandler:Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker, GameCircle.MonoDroid")]
		global::Java.Lang.Object DeepCopy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("merge", "(Lcom/amazon/ags/client/whispersync/model/Mergeable;)V", "GetMerge_Lcom_amazon_ags_client_whispersync_model_Mergeable_Handler:Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker, GameCircle.MonoDroid")]
		void Merge (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/interface[@name='Mergeable']/method[@name='startSyncing' and count(parameter)=0]"
		[Register ("startSyncing", "()V", "GetStartSyncingHandler:Com.Amazon.Ags.Client.Whispersync.Model.IMergeableInvoker, GameCircle.MonoDroid")]
		void StartSyncing ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/Mergeable", DoNotGenerateAcw=true)]
	internal class IMergeableInvoker : global::Java.Lang.Object, IMergeable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/Mergeable");
		IntPtr class_ref;

		public static IMergeable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMergeable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.model.Mergeable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMergeableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMergeableInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallObjectMethod (Handle, id_getState), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompleteSyncing ();
		}
#pragma warning restore 0169

		IntPtr id_completeSyncing;
		public void CompleteSyncing ()
		{
			if (id_completeSyncing == IntPtr.Zero)
				id_completeSyncing = JNIEnv.GetMethodID (class_ref, "completeSyncing", "()V");
			JNIEnv.CallVoidMethod (Handle, id_completeSyncing);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeepCopy ());
		}
#pragma warning restore 0169

		IntPtr id_deepCopy;
		public global::Java.Lang.Object DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/amazon/ags/client/whispersync/model/Mergeable;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
#pragma warning disable 0169
		static Delegate GetMerge_Lcom_amazon_ags_client_whispersync_model_Mergeable_Handler ()
		{
			if (cb_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_ == null)
				cb_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_);
			return cb_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
		}

		static void n_Merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Merge (p0);
		}
#pragma warning restore 0169

		IntPtr id_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
		public void Merge (global::Java.Lang.Object p0)
		{
			if (id_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_ == IntPtr.Zero)
				id_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lcom/amazon/ags/client/whispersync/model/Mergeable;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_merge_Lcom_amazon_ags_client_whispersync_model_Mergeable_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSyncing ();
		}
#pragma warning restore 0169

		IntPtr id_startSyncing;
		public void StartSyncing ()
		{
			if (id_startSyncing == IntPtr.Zero)
				id_startSyncing = JNIEnv.GetMethodID (class_ref, "startSyncing", "()V");
			JNIEnv.CallVoidMethod (Handle, id_startSyncing);
		}

	}

}
