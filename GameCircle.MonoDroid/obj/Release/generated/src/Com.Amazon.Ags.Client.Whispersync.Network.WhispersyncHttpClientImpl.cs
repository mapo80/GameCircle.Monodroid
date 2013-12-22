using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncHttpClientImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/network/WhispersyncHttpClientImpl", DoNotGenerateAcw=true)]
	public partial class WhispersyncHttpClientImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/network/WhispersyncHttpClientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncHttpClientImpl); }
		}

		protected WhispersyncHttpClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_comm_NetworkClient_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncHttpClientImpl']/constructor[@name='WhispersyncHttpClientImpl' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.html5.comm.NetworkClient'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/comm/NetworkClient;Ljava/lang/String;)V", "")]
		public WhispersyncHttpClientImpl (global::Com.Amazon.Ags.Html5.Comm.INetworkClient p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (WhispersyncHttpClientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/comm/NetworkClient;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/comm/NetworkClient;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_comm_NetworkClient_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_comm_NetworkClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/comm/NetworkClient;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_comm_NetworkClient_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_comm_NetworkClient_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getWhisperData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetWhisperData_Ljava_lang_String_Handler ()
		{
			if (cb_getWhisperData_Ljava_lang_String_ == null)
				cb_getWhisperData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetWhisperData_Ljava_lang_String_);
			return cb_getWhisperData_Ljava_lang_String_;
		}

		static IntPtr n_GetWhisperData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncHttpClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncHttpClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetWhisperData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getWhisperData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncHttpClientImpl']/method[@name='getWhisperData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getWhisperData", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;", "GetGetWhisperData_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse GetWhisperData (string p0)
		{
			if (id_getWhisperData_Ljava_lang_String_ == IntPtr.Zero)
				id_getWhisperData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getWhisperData", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallObjectMethod  (Handle, id_getWhisperData_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getWhisperData_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_;
#pragma warning disable 0169
		static Delegate GetPostWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_Handler ()
		{
			if (cb_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ == null)
				cb_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_);
			return cb_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_;
		}

		static IntPtr n_PostWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncHttpClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncHttpClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostWhisperData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncHttpClientImpl']/method[@name='postWhisperData' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.network.WhispersyncRequest']]"
		[Register ("postWhisperData", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncRequest;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;", "GetPostWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_Handler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse PostWhisperData (global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest p0)
		{
			if (id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ == IntPtr.Zero)
				id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ = JNIEnv.GetMethodID (class_ref, "postWhisperData", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncRequest;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;");

			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallObjectMethod  (Handle, id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
