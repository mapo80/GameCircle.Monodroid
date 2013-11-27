using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSAsyncOfflineEventManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/AGSAsyncOfflineEventManager", DoNotGenerateAcw=true)]
	public partial class AGSAsyncOfflineEventManager : global::Com.Amazon.Ags.Storage.AGSOfflineEventManager {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSAsyncOfflineEventManager.WorkerThread']"
		[global::Android.Runtime.Register ("com/amazon/ags/storage/AGSAsyncOfflineEventManager$WorkerThread", DoNotGenerateAcw=true)]
		public partial class WorkerThread : global::Java.Lang.Thread {

			protected WorkerThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/AGSAsyncOfflineEventManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSAsyncOfflineEventManager); }
		}

		protected AGSAsyncOfflineEventManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_GlobalState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='AGSAsyncOfflineEventManager']/constructor[@name='AGSAsyncOfflineEventManager' and count(parameter)=4 and parameter[1][@type='com.amazon.ags.storage.SQLiteOfflineEventStorage'] and parameter[2][@type='com.amazon.ags.html5.util.NetworkUtil'] and parameter[3][@type='com.amazon.ags.html5.service.ServiceHelper'] and parameter[4][@type='com.amazon.ags.html5.util.GlobalState']]"
		[Register (".ctor", "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/GlobalState;)V", "")]
		public AGSAsyncOfflineEventManager (global::Com.Amazon.Ags.Storage.SQLiteOfflineEventStorage p0, global::Com.Amazon.Ags.Html5.Util.NetworkUtil p1, global::Com.Amazon.Ags.Html5.Service.IServiceHelper p2, global::Com.Amazon.Ags.Html5.Util.GlobalState p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AGSAsyncOfflineEventManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/GlobalState;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/GlobalState;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_GlobalState_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_GlobalState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/storage/SQLiteOfflineEventStorage;Lcom/amazon/ags/html5/util/NetworkUtil;Lcom/amazon/ags/html5/service/ServiceHelper;Lcom/amazon/ags/html5/util/GlobalState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_GlobalState_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_storage_SQLiteOfflineEventStorage_Lcom_amazon_ags_html5_util_NetworkUtil_Lcom_amazon_ags_html5_service_ServiceHelper_Lcom_amazon_ags_html5_util_GlobalState_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}
}
