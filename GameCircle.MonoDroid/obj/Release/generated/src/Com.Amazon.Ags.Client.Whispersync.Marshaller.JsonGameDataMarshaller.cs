using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Marshaller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/marshaller/JsonGameDataMarshaller", DoNotGenerateAcw=true)]
	public partial class JsonGameDataMarshaller : global::Java.Lang.Object, global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/marshaller/JsonGameDataMarshaller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonGameDataMarshaller); }
		}

		protected JsonGameDataMarshaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']/constructor[@name='JsonGameDataMarshaller' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "")]
		public JsonGameDataMarshaller (global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JsonGameDataMarshaller)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
		}

		static Delegate cb_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
#pragma warning disable 0169
		static Delegate GetComposeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler ()
		{
			if (cb_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == null)
				cb_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ComposeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_);
			return cb_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		}

		static IntPtr n_ComposeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ComposeForDisk (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']/method[@name='composeForDisk' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("composeForDisk", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;", "GetComposeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler")]
		public virtual string ComposeForDisk (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "composeForDisk", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
#pragma warning disable 0169
		static Delegate GetComposeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler ()
		{
			if (cb_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == null)
				cb_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ComposeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_);
			return cb_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		}

		static IntPtr n_ComposeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ComposeForService (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']/method[@name='composeForService' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("composeForService", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;", "GetComposeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler")]
		public virtual string ComposeForService (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "composeForService", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_lang_String_);
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetParse_Ljava_lang_String_Handler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod  (Handle, id_parse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_parse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
#pragma warning disable 0169
		static Delegate GetSetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_Handler ()
		{
			if (cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == null)
				cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_);
			return cb_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		}

		static void n_SetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.JsonGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventCollectorClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/class[@name='JsonGameDataMarshaller']/method[@name='setEventCollectorClient' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient']]"
		[Register ("setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V", "GetSetEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_Handler")]
		public virtual void SetEventCollectorClient (global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0)
		{
			if (id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ == IntPtr.Zero)
				id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_ = JNIEnv.GetMethodID (class_ref, "setEventCollectorClient", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setEventCollectorClient_Lcom_amazon_ags_client_metrics_EventCollectorClient_, new JValue (p0));
		}

	}
}
