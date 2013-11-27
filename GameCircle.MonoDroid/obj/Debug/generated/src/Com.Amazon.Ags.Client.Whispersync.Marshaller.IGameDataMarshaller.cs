using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Marshaller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/interface[@name='GameDataMarshaller']"
	[Register ("com/amazon/ags/client/whispersync/marshaller/GameDataMarshaller", "", "Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshallerInvoker")]
	public partial interface IGameDataMarshaller : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/interface[@name='GameDataMarshaller']/method[@name='composeForDisk' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("composeForDisk", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;", "GetComposeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler:Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshallerInvoker, GameCircle.MonoDroid")]
		string ComposeForDisk (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/interface[@name='GameDataMarshaller']/method[@name='composeForService' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.InternalGameDataMap']]"
		[Register ("composeForService", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;", "GetComposeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_Handler:Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshallerInvoker, GameCircle.MonoDroid")]
		string ComposeForService (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.marshaller']/interface[@name='GameDataMarshaller']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/InternalGameDataMap;", "GetParse_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshallerInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Parse (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/marshaller/GameDataMarshaller", DoNotGenerateAcw=true)]
	internal class IGameDataMarshallerInvoker : global::Java.Lang.Object, IGameDataMarshaller {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/whispersync/marshaller/GameDataMarshaller");
		IntPtr class_ref;

		public static IGameDataMarshaller GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGameDataMarshaller> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.whispersync.marshaller.GameDataMarshaller"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGameDataMarshallerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGameDataMarshallerInvoker); }
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
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ComposeForDisk (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		public string ComposeForDisk (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "composeForDisk", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_composeForDisk_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0 = (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ComposeForService (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_;
		public string ComposeForService (global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap p0)
		{
			if (id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ == IntPtr.Zero)
				id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_ = JNIEnv.GetMethodID (class_ref, "composeForService", "(Lcom/amazon/ags/client/whispersync/InternalGameDataMap;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_composeForService_Lcom_amazon_ags_client_whispersync_InternalGameDataMap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Marshaller.IGameDataMarshaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/InternalGameDataMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.IInternalGameDataMap> (JNIEnv.CallObjectMethod (Handle, id_parse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
