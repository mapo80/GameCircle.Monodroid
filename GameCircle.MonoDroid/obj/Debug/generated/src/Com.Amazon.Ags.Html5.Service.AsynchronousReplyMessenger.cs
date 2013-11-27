using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='AsynchronousReplyMessenger']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/service/AsynchronousReplyMessenger", DoNotGenerateAcw=true)]
	public partial class AsynchronousReplyMessenger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/service/AsynchronousReplyMessenger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsynchronousReplyMessenger); }
		}

		protected AsynchronousReplyMessenger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_Ljava_util_concurrent_ScheduledExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='AsynchronousReplyMessenger']/constructor[@name='AsynchronousReplyMessenger' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.util.concurrent.ScheduledExecutorService']]"
		[Register (".ctor", "(Landroid/os/Handler;Ljava/util/concurrent/ScheduledExecutorService;)V", "")]
		public AsynchronousReplyMessenger (global::Android.OS.Handler p0, global::Java.Util.Concurrent.IScheduledExecutorService p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AsynchronousReplyMessenger)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;Ljava/util/concurrent/ScheduledExecutorService;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;Ljava/util/concurrent/ScheduledExecutorService;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_os_Handler_Ljava_util_concurrent_ScheduledExecutorService_ == IntPtr.Zero)
				id_ctor_Landroid_os_Handler_Ljava_util_concurrent_ScheduledExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;Ljava/util/concurrent/ScheduledExecutorService;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_Ljava_util_concurrent_ScheduledExecutorService_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_Ljava_util_concurrent_ScheduledExecutorService_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_;
#pragma warning disable 0169
		static Delegate GetAddAsyncRequest_Lcom_amazon_ags_client_JSONRequest_Handler ()
		{
			if (cb_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_ == null)
				cb_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAsyncRequest_Lcom_amazon_ags_client_JSONRequest_);
			return cb_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_;
		}

		static void n_AddAsyncRequest_Lcom_amazon_ags_client_JSONRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.IJSONRequest p0 = (global::Com.Amazon.Ags.Client.IJSONRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IJSONRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAsyncRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='AsynchronousReplyMessenger']/method[@name='addAsyncRequest' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.JSONRequest']]"
		[Register ("addAsyncRequest", "(Lcom/amazon/ags/client/JSONRequest;)V", "GetAddAsyncRequest_Lcom_amazon_ags_client_JSONRequest_Handler")]
		public virtual void AddAsyncRequest (global::Com.Amazon.Ags.Client.IJSONRequest p0)
		{
			if (id_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_ == IntPtr.Zero)
				id_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_ = JNIEnv.GetMethodID (class_ref, "addAsyncRequest", "(Lcom/amazon/ags/client/JSONRequest;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addAsyncRequest_Lcom_amazon_ags_client_JSONRequest_, new JValue (p0));
		}

		static Delegate cb_sendReply_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSendReply_Lorg_json_JSONObject_Handler ()
		{
			if (cb_sendReply_Lorg_json_JSONObject_ == null)
				cb_sendReply_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendReply_Lorg_json_JSONObject_);
			return cb_sendReply_Lorg_json_JSONObject_;
		}

		static void n_SendReply_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.AsynchronousReplyMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendReply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendReply_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.service']/class[@name='AsynchronousReplyMessenger']/method[@name='sendReply' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("sendReply", "(Lorg/json/JSONObject;)V", "GetSendReply_Lorg_json_JSONObject_Handler")]
		public virtual void SendReply (global::Org.Json.JSONObject p0)
		{
			if (id_sendReply_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_sendReply_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "sendReply", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendReply_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendReply_Lorg_json_JSONObject_, new JValue (p0));
		}

	}
}
