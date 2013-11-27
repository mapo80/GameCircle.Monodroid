using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='InternalGameDataMap']"
	[Register ("com/amazon/ags/client/whispersync/InternalGameDataMap", "", "Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMapInvoker")]
	public partial interface IInternalGameDataMap : global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable {

		global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Client.Whispersync.Model.Key, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> AllElements {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='InternalGameDataMap']/method[@name='getAllElements' and count(parameter)=0]"
			[Register ("getAllElements", "()Ljava/util/Map;", "GetGetAllElementsHandler:Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMapInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='InternalGameDataMap']/method[@name='lockAndCopy' and count(parameter)=0]"
		[Register ("lockAndCopy", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetLockAndCopyHandler:Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMapInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap LockAndCopy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='InternalGameDataMap']/method[@name='putElement' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.whispersync.model.Key'] and parameter[2][@type='com.amazon.ags.client.whispersync.model.Mergeable']]"
		[Register ("putElement", "(Lcom/amazon/ags/client/whispersync/model/Key;Lcom/amazon/ags/client/whispersync/model/Mergeable;)V", "GetPutElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_Handler:Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMapInvoker, GameCircle.MonoDroid")]
		void PutElement (global::Com.Amazon.Ags.Client.Whispersync.Model.Key p0, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/interface[@name='InternalGameDataMap']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler:Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMapInvoker, GameCircle.MonoDroid")]
		int Size ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/InternalGameDataMap", DoNotGenerateAcw=true)]
	internal class IInternalGameDataMapInvoker : global::Java.Lang.Object, IInternalGameDataMap {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/InternalGameDataMap");
		IntPtr class_ref;

		public static IInternalGameDataMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalGameDataMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.InternalGameDataMap"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalGameDataMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInternalGameDataMapInvoker); }
		}

		static Delegate cb_getAllElements;
#pragma warning disable 0169
		static Delegate GetGetAllElementsHandler ()
		{
			if (cb_getAllElements == null)
				cb_getAllElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllElements);
			return cb_getAllElements;
		}

		static IntPtr n_GetAllElements (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Client.Whispersync.Model.Key, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable>.ToLocalJniHandle (__this.AllElements);
		}
#pragma warning restore 0169

		IntPtr id_getAllElements;
		public global::System.Collections.Generic.IDictionary<global::Com.Amazon.Ags.Client.Whispersync.Model.Key, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> AllElements {
			get {
				if (id_getAllElements == IntPtr.Zero)
					id_getAllElements = JNIEnv.GetMethodID (class_ref, "getAllElements", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Com.Amazon.Ags.Client.Whispersync.Model.Key, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllElements), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_lockAndCopy;
#pragma warning disable 0169
		static Delegate GetLockAndCopyHandler ()
		{
			if (cb_lockAndCopy == null)
				cb_lockAndCopy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LockAndCopy);
			return cb_lockAndCopy;
		}

		static IntPtr n_LockAndCopy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LockAndCopy ());
		}
#pragma warning restore 0169

		IntPtr id_lockAndCopy;
		public global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap LockAndCopy ()
		{
			if (id_lockAndCopy == IntPtr.Zero)
				id_lockAndCopy = JNIEnv.GetMethodID (class_ref, "lockAndCopy", "()Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod (Handle, id_lockAndCopy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
#pragma warning disable 0169
		static Delegate GetPutElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_Handler ()
		{
			if (cb_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_ == null)
				cb_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_);
			return cb_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
		}

		static void n_PutElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.Key p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.Key> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable p1 = (global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutElement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_;
		public void PutElement (global::Com.Amazon.Ags.Client.Whispersync.Model.Key p0, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable p1)
		{
			if (id_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_ == IntPtr.Zero)
				id_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_ = JNIEnv.GetMethodID (class_ref, "putElement", "(Lcom/amazon/ags/client/whispersync/model/Key;Lcom/amazon/ags/client/whispersync/model/Mergeable;)V");
			JNIEnv.CallVoidMethod (Handle, id_putElement_Lcom_amazon_ags_client_whispersync_model_Key_Lcom_amazon_ags_client_whispersync_model_Mergeable_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (Handle, id_size);
		}

		static Delegate cb_getAccumulatingNumberKeys;
#pragma warning disable 0169
		static Delegate GetGetAccumulatingNumberKeysHandler ()
		{
			if (cb_getAccumulatingNumberKeys == null)
				cb_getAccumulatingNumberKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccumulatingNumberKeys);
			return cb_getAccumulatingNumberKeys;
		}

		static IntPtr n_GetAccumulatingNumberKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AccumulatingNumberKeys);
		}
#pragma warning restore 0169

		IntPtr id_getAccumulatingNumberKeys;
		public global::System.Collections.Generic.ICollection<string> AccumulatingNumberKeys {
			get {
				if (id_getAccumulatingNumberKeys == IntPtr.Zero)
					id_getAccumulatingNumberKeys = JNIEnv.GetMethodID (class_ref, "getAccumulatingNumberKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAccumulatingNumberKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeveloperStringKeys;
#pragma warning disable 0169
		static Delegate GetGetDeveloperStringKeysHandler ()
		{
			if (cb_getDeveloperStringKeys == null)
				cb_getDeveloperStringKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperStringKeys);
			return cb_getDeveloperStringKeys;
		}

		static IntPtr n_GetDeveloperStringKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.DeveloperStringKeys);
		}
#pragma warning restore 0169

		IntPtr id_getDeveloperStringKeys;
		public global::System.Collections.Generic.ICollection<string> DeveloperStringKeys {
			get {
				if (id_getDeveloperStringKeys == IntPtr.Zero)
					id_getDeveloperStringKeys = JNIEnv.GetMethodID (class_ref, "getDeveloperStringKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getDeveloperStringKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHighNumberListKeys;
#pragma warning disable 0169
		static Delegate GetGetHighNumberListKeysHandler ()
		{
			if (cb_getHighNumberListKeys == null)
				cb_getHighNumberListKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighNumberListKeys);
			return cb_getHighNumberListKeys;
		}

		static IntPtr n_GetHighNumberListKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.HighNumberListKeys);
		}
#pragma warning restore 0169

		IntPtr id_getHighNumberListKeys;
		public global::System.Collections.Generic.ICollection<string> HighNumberListKeys {
			get {
				if (id_getHighNumberListKeys == IntPtr.Zero)
					id_getHighNumberListKeys = JNIEnv.GetMethodID (class_ref, "getHighNumberListKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getHighNumberListKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHighestNumberKeys;
#pragma warning disable 0169
		static Delegate GetGetHighestNumberKeysHandler ()
		{
			if (cb_getHighestNumberKeys == null)
				cb_getHighestNumberKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighestNumberKeys);
			return cb_getHighestNumberKeys;
		}

		static IntPtr n_GetHighestNumberKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.HighestNumberKeys);
		}
#pragma warning restore 0169

		IntPtr id_getHighestNumberKeys;
		public global::System.Collections.Generic.ICollection<string> HighestNumberKeys {
			get {
				if (id_getHighestNumberKeys == IntPtr.Zero)
					id_getHighestNumberKeys = JNIEnv.GetMethodID (class_ref, "getHighestNumberKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getHighestNumberKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatestNumberKeys;
#pragma warning disable 0169
		static Delegate GetGetLatestNumberKeysHandler ()
		{
			if (cb_getLatestNumberKeys == null)
				cb_getLatestNumberKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestNumberKeys);
			return cb_getLatestNumberKeys;
		}

		static IntPtr n_GetLatestNumberKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LatestNumberKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLatestNumberKeys;
		public global::System.Collections.Generic.ICollection<string> LatestNumberKeys {
			get {
				if (id_getLatestNumberKeys == IntPtr.Zero)
					id_getLatestNumberKeys = JNIEnv.GetMethodID (class_ref, "getLatestNumberKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLatestNumberKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatestNumberListKeys;
#pragma warning disable 0169
		static Delegate GetGetLatestNumberListKeysHandler ()
		{
			if (cb_getLatestNumberListKeys == null)
				cb_getLatestNumberListKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestNumberListKeys);
			return cb_getLatestNumberListKeys;
		}

		static IntPtr n_GetLatestNumberListKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LatestNumberListKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLatestNumberListKeys;
		public global::System.Collections.Generic.ICollection<string> LatestNumberListKeys {
			get {
				if (id_getLatestNumberListKeys == IntPtr.Zero)
					id_getLatestNumberListKeys = JNIEnv.GetMethodID (class_ref, "getLatestNumberListKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLatestNumberListKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatestStringKeys;
#pragma warning disable 0169
		static Delegate GetGetLatestStringKeysHandler ()
		{
			if (cb_getLatestStringKeys == null)
				cb_getLatestStringKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestStringKeys);
			return cb_getLatestStringKeys;
		}

		static IntPtr n_GetLatestStringKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LatestStringKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLatestStringKeys;
		public global::System.Collections.Generic.ICollection<string> LatestStringKeys {
			get {
				if (id_getLatestStringKeys == IntPtr.Zero)
					id_getLatestStringKeys = JNIEnv.GetMethodID (class_ref, "getLatestStringKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLatestStringKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatestStringListKeys;
#pragma warning disable 0169
		static Delegate GetGetLatestStringListKeysHandler ()
		{
			if (cb_getLatestStringListKeys == null)
				cb_getLatestStringListKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestStringListKeys);
			return cb_getLatestStringListKeys;
		}

		static IntPtr n_GetLatestStringListKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LatestStringListKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLatestStringListKeys;
		public global::System.Collections.Generic.ICollection<string> LatestStringListKeys {
			get {
				if (id_getLatestStringListKeys == IntPtr.Zero)
					id_getLatestStringListKeys = JNIEnv.GetMethodID (class_ref, "getLatestStringListKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLatestStringListKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLowNumberListKeys;
#pragma warning disable 0169
		static Delegate GetGetLowNumberListKeysHandler ()
		{
			if (cb_getLowNumberListKeys == null)
				cb_getLowNumberListKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowNumberListKeys);
			return cb_getLowNumberListKeys;
		}

		static IntPtr n_GetLowNumberListKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LowNumberListKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLowNumberListKeys;
		public global::System.Collections.Generic.ICollection<string> LowNumberListKeys {
			get {
				if (id_getLowNumberListKeys == IntPtr.Zero)
					id_getLowNumberListKeys = JNIEnv.GetMethodID (class_ref, "getLowNumberListKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLowNumberListKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLowestNumberKeys;
#pragma warning disable 0169
		static Delegate GetGetLowestNumberKeysHandler ()
		{
			if (cb_getLowestNumberKeys == null)
				cb_getLowestNumberKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowestNumberKeys);
			return cb_getLowestNumberKeys;
		}

		static IntPtr n_GetLowestNumberKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.LowestNumberKeys);
		}
#pragma warning restore 0169

		IntPtr id_getLowestNumberKeys;
		public global::System.Collections.Generic.ICollection<string> LowestNumberKeys {
			get {
				if (id_getLowestNumberKeys == IntPtr.Zero)
					id_getLowestNumberKeys = JNIEnv.GetMethodID (class_ref, "getLowestNumberKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLowestNumberKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapKeys;
#pragma warning disable 0169
		static Delegate GetGetMapKeysHandler ()
		{
			if (cb_getMapKeys == null)
				cb_getMapKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapKeys);
			return cb_getMapKeys;
		}

		static IntPtr n_GetMapKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.MapKeys);
		}
#pragma warning restore 0169

		IntPtr id_getMapKeys;
		public global::System.Collections.Generic.ICollection<string> MapKeys {
			get {
				if (id_getMapKeys == IntPtr.Zero)
					id_getMapKeys = JNIEnv.GetMethodID (class_ref, "getMapKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getMapKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStringSetKeys;
#pragma warning disable 0169
		static Delegate GetGetStringSetKeysHandler ()
		{
			if (cb_getStringSetKeys == null)
				cb_getStringSetKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringSetKeys);
			return cb_getStringSetKeys;
		}

		static IntPtr n_GetStringSetKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.StringSetKeys);
		}
#pragma warning restore 0169

		IntPtr id_getStringSetKeys;
		public global::System.Collections.Generic.ICollection<string> StringSetKeys {
			get {
				if (id_getStringSetKeys == IntPtr.Zero)
					id_getStringSetKeys = JNIEnv.GetMethodID (class_ref, "getStringSetKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getStringSetKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAccumulatingNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccumulatingNumber_Ljava_lang_String_Handler ()
		{
			if (cb_getAccumulatingNumber_Ljava_lang_String_ == null)
				cb_getAccumulatingNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccumulatingNumber_Ljava_lang_String_);
			return cb_getAccumulatingNumber_Ljava_lang_String_;
		}

		static IntPtr n_GetAccumulatingNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccumulatingNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAccumulatingNumber_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber GetAccumulatingNumber (string p0)
		{
			if (id_getAccumulatingNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccumulatingNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccumulatingNumber", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableAccumulatingNumber;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (JNIEnv.CallObjectMethod (Handle, id_getAccumulatingNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeveloperString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeveloperString_Ljava_lang_String_Handler ()
		{
			if (cb_getDeveloperString_Ljava_lang_String_ == null)
				cb_getDeveloperString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDeveloperString_Ljava_lang_String_);
			return cb_getDeveloperString_Ljava_lang_String_;
		}

		static IntPtr n_GetDeveloperString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeveloperString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeveloperString_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString GetDeveloperString (string p0)
		{
			if (id_getDeveloperString_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeveloperString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDeveloperString", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableDeveloperString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableDeveloperString> (JNIEnv.CallObjectMethod (Handle, id_getDeveloperString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getHighNumberList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHighNumberList_Ljava_lang_String_Handler ()
		{
			if (cb_getHighNumberList_Ljava_lang_String_ == null)
				cb_getHighNumberList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHighNumberList_Ljava_lang_String_);
			return cb_getHighNumberList_Ljava_lang_String_;
		}

		static IntPtr n_GetHighNumberList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHighNumberList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHighNumberList_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList GetHighNumberList (string p0)
		{
			if (id_getHighNumberList_Ljava_lang_String_ == IntPtr.Zero)
				id_getHighNumberList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHighNumberList", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumberList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (JNIEnv.CallObjectMethod (Handle, id_getHighNumberList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getHighestNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHighestNumber_Ljava_lang_String_Handler ()
		{
			if (cb_getHighestNumber_Ljava_lang_String_ == null)
				cb_getHighestNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHighestNumber_Ljava_lang_String_);
			return cb_getHighestNumber_Ljava_lang_String_;
		}

		static IntPtr n_GetHighestNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHighestNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHighestNumber_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber GetHighestNumber (string p0)
		{
			if (id_getHighestNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_getHighestNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHighestNumber", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumber;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (JNIEnv.CallObjectMethod (Handle, id_getHighestNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLatestNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestNumber_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestNumber_Ljava_lang_String_ == null)
				cb_getLatestNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestNumber_Ljava_lang_String_);
			return cb_getLatestNumber_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLatestNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLatestNumber_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber GetLatestNumber (string p0)
		{
			if (id_getLatestNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestNumber", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumber;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (JNIEnv.CallObjectMethod (Handle, id_getLatestNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLatestNumberList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestNumberList_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestNumberList_Ljava_lang_String_ == null)
				cb_getLatestNumberList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestNumberList_Ljava_lang_String_);
			return cb_getLatestNumberList_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestNumberList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLatestNumberList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLatestNumberList_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList GetLatestNumberList (string p0)
		{
			if (id_getLatestNumberList_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestNumberList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestNumberList", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumberList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (JNIEnv.CallObjectMethod (Handle, id_getLatestNumberList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLatestString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestString_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestString_Ljava_lang_String_ == null)
				cb_getLatestString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestString_Ljava_lang_String_);
			return cb_getLatestString_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLatestString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLatestString_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString GetLatestString (string p0)
		{
			if (id_getLatestString_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestString", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableString> (JNIEnv.CallObjectMethod (Handle, id_getLatestString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLatestStringList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestStringList_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestStringList_Ljava_lang_String_ == null)
				cb_getLatestStringList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestStringList_Ljava_lang_String_);
			return cb_getLatestStringList_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestStringList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLatestStringList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLatestStringList_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList GetLatestStringList (string p0)
		{
			if (id_getLatestStringList_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestStringList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestStringList", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringList> (JNIEnv.CallObjectMethod (Handle, id_getLatestStringList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLowNumberList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLowNumberList_Ljava_lang_String_Handler ()
		{
			if (cb_getLowNumberList_Ljava_lang_String_ == null)
				cb_getLowNumberList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLowNumberList_Ljava_lang_String_);
			return cb_getLowNumberList_Ljava_lang_String_;
		}

		static IntPtr n_GetLowNumberList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLowNumberList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLowNumberList_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList GetLowNumberList (string p0)
		{
			if (id_getLowNumberList_Ljava_lang_String_ == IntPtr.Zero)
				id_getLowNumberList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLowNumberList", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumberList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberList> (JNIEnv.CallObjectMethod (Handle, id_getLowNumberList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLowestNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLowestNumber_Ljava_lang_String_Handler ()
		{
			if (cb_getLowestNumber_Ljava_lang_String_ == null)
				cb_getLowestNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLowestNumber_Ljava_lang_String_);
			return cb_getLowestNumber_Ljava_lang_String_;
		}

		static IntPtr n_GetLowestNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLowestNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLowestNumber_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber GetLowestNumber (string p0)
		{
			if (id_getLowestNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_getLowestNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLowestNumber", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableNumber;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (JNIEnv.CallObjectMethod (Handle, id_getLowestNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMap_Ljava_lang_String_Handler ()
		{
			if (cb_getMap_Ljava_lang_String_ == null)
				cb_getMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMap_Ljava_lang_String_);
			return cb_getMap_Ljava_lang_String_;
		}

		static IntPtr n_GetMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMap_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GetMap (string p0)
		{
			if (id_getMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMap", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/GameDataMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap> (JNIEnv.CallObjectMethod (Handle, id_getMap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStringSet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringSet_Ljava_lang_String_Handler ()
		{
			if (cb_getStringSet_Ljava_lang_String_ == null)
				cb_getStringSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringSet_Ljava_lang_String_);
			return cb_getStringSet_Ljava_lang_String_;
		}

		static IntPtr n_GetStringSet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStringSet (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStringSet_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet GetStringSet (string p0)
		{
			if (id_getStringSet_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringSet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStringSet", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/model/SyncableStringSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableStringSet> (JNIEnv.CallObjectMethod (Handle, id_getStringSet_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
