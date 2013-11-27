using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/interface[@name='WhispersyncHttpClient']"
	[Register ("com/amazon/ags/client/whispersync/network/WhispersyncHttpClient", "", "Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClientInvoker")]
	public partial interface IWhispersyncHttpClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/interface[@name='WhispersyncHttpClient']/method[@name='getWhisperData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getWhisperData", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;", "GetGetWhisperData_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse GetWhisperData (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/interface[@name='WhispersyncHttpClient']/method[@name='postWhisperData' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.network.WhispersyncRequest']]"
		[Register ("postWhisperData", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncRequest;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;", "GetPostWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_Handler:Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse PostWhisperData (global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/network/WhispersyncHttpClient", DoNotGenerateAcw=true)]
	internal class IWhispersyncHttpClientInvoker : global::Java.Lang.Object, IWhispersyncHttpClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/network/WhispersyncHttpClient");
		IntPtr class_ref;

		public static IWhispersyncHttpClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWhispersyncHttpClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.network.WhispersyncHttpClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWhispersyncHttpClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWhispersyncHttpClientInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetWhisperData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getWhisperData_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse GetWhisperData (string p0)
		{
			if (id_getWhisperData_Ljava_lang_String_ == IntPtr.Zero)
				id_getWhisperData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getWhisperData", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallObjectMethod (Handle, id_getWhisperData_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.IWhispersyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostWhisperData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_;
		public global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse PostWhisperData (global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest p0)
		{
			if (id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ == IntPtr.Zero)
				id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_ = JNIEnv.GetMethodID (class_ref, "postWhisperData", "(Lcom/amazon/ags/client/whispersync/network/WhispersyncRequest;)Lcom/amazon/ags/client/whispersync/network/WhispersyncResponse;");
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (JNIEnv.CallObjectMethod (Handle, id_postWhisperData_Lcom_amazon_ags_client_whispersync_network_WhispersyncRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
