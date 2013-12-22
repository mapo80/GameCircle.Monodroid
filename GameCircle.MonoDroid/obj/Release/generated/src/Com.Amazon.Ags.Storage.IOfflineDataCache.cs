using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']"
	[Register ("com/amazon/ags/storage/OfflineDataCache", "", "Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker")]
	public partial interface IOfflineDataCache : IJavaObject {

		global::System.Collections.Generic.IList<global::Org.Json.JSONObject> AllCacheItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='getAllCacheItems' and count(parameter)=0]"
			[Register ("getAllCacheItems", "()Ljava/util/List;", "GetGetAllCacheItemsHandler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='batchRemoveCachedItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("batchRemoveCachedItems", "(Ljava/util/List;)V", "GetBatchRemoveCachedItems_Ljava_util_List_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void BatchRemoveCachedItems (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='getCacheItem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCacheItem", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetCacheItem_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		global::Org.Json.JSONObject GetCacheItem (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='queryCacheItems' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryCacheItems", "(Ljava/lang/String;)Ljava/util/List;", "GetQueryCacheItems_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		global::System.Collections.Generic.IList<global::Org.Json.JSONObject> QueryCacheItems (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='removeCachedItem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeCachedItem", "(Ljava/lang/String;)V", "GetRemoveCachedItem_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void RemoveCachedItem (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='removeCachedItems' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeCachedItems", "(Ljava/lang/String;)V", "GetRemoveCachedItems_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void RemoveCachedItems (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='setCacheItem' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.storage.OfflineCacheRequest']]"
		[Register ("setCacheItem", "(Lcom/amazon/ags/storage/OfflineCacheRequest;)V", "GetSetCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void SetCacheItem (global::Com.Amazon.Ags.Storage.OfflineCacheRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='setCacheItem' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("setCacheItem", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", "GetSetCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void SetCacheItem (string p0, string p1, global::Org.Json.JSONObject p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='OfflineDataCache']/method[@name='setCacheItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("setCacheItems", "(Ljava/util/List;)V", "GetSetCacheItems_Ljava_util_List_Handler:Com.Amazon.Ags.Storage.IOfflineDataCacheInvoker, GameCircle.MonoDroid")]
		void SetCacheItems (global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineDataCache", DoNotGenerateAcw=true)]
	internal class IOfflineDataCacheInvoker : global::Java.Lang.Object, IOfflineDataCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/storage/OfflineDataCache");
		IntPtr class_ref;

		public static IOfflineDataCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOfflineDataCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.storage.OfflineDataCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOfflineDataCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOfflineDataCacheInvoker); }
		}

		static Delegate cb_getAllCacheItems;
#pragma warning disable 0169
		static Delegate GetGetAllCacheItemsHandler ()
		{
			if (cb_getAllCacheItems == null)
				cb_getAllCacheItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllCacheItems);
			return cb_getAllCacheItems;
		}

		static IntPtr n_GetAllCacheItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.ToLocalJniHandle (__this.AllCacheItems);
		}
#pragma warning restore 0169

		IntPtr id_getAllCacheItems;
		public global::System.Collections.Generic.IList<global::Org.Json.JSONObject> AllCacheItems {
			get {
				if (id_getAllCacheItems == IntPtr.Zero)
					id_getAllCacheItems = JNIEnv.GetMethodID (class_ref, "getAllCacheItems", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllCacheItems), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_batchRemoveCachedItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetBatchRemoveCachedItems_Ljava_util_List_Handler ()
		{
			if (cb_batchRemoveCachedItems_Ljava_util_List_ == null)
				cb_batchRemoveCachedItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BatchRemoveCachedItems_Ljava_util_List_);
			return cb_batchRemoveCachedItems_Ljava_util_List_;
		}

		static void n_BatchRemoveCachedItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BatchRemoveCachedItems (p0);
		}
#pragma warning restore 0169

		IntPtr id_batchRemoveCachedItems_Ljava_util_List_;
		public void BatchRemoveCachedItems (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_batchRemoveCachedItems_Ljava_util_List_ == IntPtr.Zero)
				id_batchRemoveCachedItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "batchRemoveCachedItems", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_batchRemoveCachedItems_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_getCacheItem_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCacheItem_Ljava_lang_String_Handler ()
		{
			if (cb_getCacheItem_Ljava_lang_String_ == null)
				cb_getCacheItem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCacheItem_Ljava_lang_String_);
			return cb_getCacheItem_Ljava_lang_String_;
		}

		static IntPtr n_GetCacheItem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCacheItem (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCacheItem_Ljava_lang_String_;
		public global::Org.Json.JSONObject GetCacheItem (string p0)
		{
			if (id_getCacheItem_Ljava_lang_String_ == IntPtr.Zero)
				id_getCacheItem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCacheItem", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getCacheItem_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queryCacheItems_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryCacheItems_Ljava_lang_String_Handler ()
		{
			if (cb_queryCacheItems_Ljava_lang_String_ == null)
				cb_queryCacheItems_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryCacheItems_Ljava_lang_String_);
			return cb_queryCacheItems_Ljava_lang_String_;
		}

		static IntPtr n_QueryCacheItems_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.ToLocalJniHandle (__this.QueryCacheItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_queryCacheItems_Ljava_lang_String_;
		public global::System.Collections.Generic.IList<global::Org.Json.JSONObject> QueryCacheItems (string p0)
		{
			if (id_queryCacheItems_Ljava_lang_String_ == IntPtr.Zero)
				id_queryCacheItems_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryCacheItems", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Org.Json.JSONObject> __ret = global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_queryCacheItems_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeCachedItem_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveCachedItem_Ljava_lang_String_Handler ()
		{
			if (cb_removeCachedItem_Ljava_lang_String_ == null)
				cb_removeCachedItem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCachedItem_Ljava_lang_String_);
			return cb_removeCachedItem_Ljava_lang_String_;
		}

		static void n_RemoveCachedItem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCachedItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCachedItem_Ljava_lang_String_;
		public void RemoveCachedItem (string p0)
		{
			if (id_removeCachedItem_Ljava_lang_String_ == IntPtr.Zero)
				id_removeCachedItem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeCachedItem", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeCachedItem_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeCachedItems_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveCachedItems_Ljava_lang_String_Handler ()
		{
			if (cb_removeCachedItems_Ljava_lang_String_ == null)
				cb_removeCachedItems_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCachedItems_Ljava_lang_String_);
			return cb_removeCachedItems_Ljava_lang_String_;
		}

		static void n_RemoveCachedItems_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCachedItems (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCachedItems_Ljava_lang_String_;
		public void RemoveCachedItems (string p0)
		{
			if (id_removeCachedItems_Ljava_lang_String_ == IntPtr.Zero)
				id_removeCachedItems_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeCachedItems", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeCachedItems_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_;
#pragma warning disable 0169
		static Delegate GetSetCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_Handler ()
		{
			if (cb_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_ == null)
				cb_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_);
			return cb_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_;
		}

		static void n_SetCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Storage.OfflineCacheRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCacheItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_;
		public void SetCacheItem (global::Com.Amazon.Ags.Storage.OfflineCacheRequest p0)
		{
			if (id_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_ == IntPtr.Zero)
				id_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_ = JNIEnv.GetMethodID (class_ref, "setCacheItem", "(Lcom/amazon/ags/storage/OfflineCacheRequest;)V");
			JNIEnv.CallVoidMethod (Handle, id_setCacheItem_Lcom_amazon_ags_storage_OfflineCacheRequest_, new JValue (p0));
		}

		static Delegate cb_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_SetCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetCacheItem (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		public void SetCacheItem (string p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setCacheItem", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_setCacheItem_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setCacheItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCacheItems_Ljava_util_List_Handler ()
		{
			if (cb_setCacheItems_Ljava_util_List_ == null)
				cb_setCacheItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCacheItems_Ljava_util_List_);
			return cb_setCacheItems_Ljava_util_List_;
		}

		static void n_SetCacheItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.IOfflineDataCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IOfflineDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Amazon.Ags.Storage.OfflineCacheRequest> p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Storage.OfflineCacheRequest>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCacheItems (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCacheItems_Ljava_util_List_;
		public void SetCacheItems (global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> p0)
		{
			if (id_setCacheItems_Ljava_util_List_ == IntPtr.Zero)
				id_setCacheItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setCacheItems", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Storage.OfflineCacheRequest>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_setCacheItems_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
