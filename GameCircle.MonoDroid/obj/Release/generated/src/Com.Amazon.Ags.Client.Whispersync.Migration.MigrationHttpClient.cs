using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationHttpClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/migration/MigrationHttpClient", DoNotGenerateAcw=true)]
	public partial class MigrationHttpClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/migration/MigrationHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MigrationHttpClient); }
		}

		protected MigrationHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_comm_NetworkClient_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationHttpClient']/constructor[@name='MigrationHttpClient' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amazon.ags.html5.comm.NetworkClient'] and parameter[4][@type='org.apache.http.client.HttpClient']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/comm/NetworkClient;Lorg/apache/http/client/HttpClient;)V", "")]
		public MigrationHttpClient (string p0, string p1, global::Com.Amazon.Ags.Html5.Comm.INetworkClient p2, global::Org.Apache.Http.Client.IHttpClient p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (MigrationHttpClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/comm/NetworkClient;Lorg/apache/http/client/HttpClient;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/comm/NetworkClient;Lorg/apache/http/client/HttpClient;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_comm_NetworkClient_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_comm_NetworkClient_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/comm/NetworkClient;Lorg/apache/http/client/HttpClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_comm_NetworkClient_Lorg_apache_http_client_HttpClient_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_comm_NetworkClient_Lorg_apache_http_client_HttpClient_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getV1GameDataDownloadUrl;
#pragma warning disable 0169
		static Delegate GetGetV1GameDataDownloadUrlHandler ()
		{
			if (cb_getV1GameDataDownloadUrl == null)
				cb_getV1GameDataDownloadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetV1GameDataDownloadUrl);
			return cb_getV1GameDataDownloadUrl;
		}

		static IntPtr n_GetV1GameDataDownloadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Migration.MigrationHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Migration.MigrationHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.V1GameDataDownloadUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getV1GameDataDownloadUrl;
		public virtual string V1GameDataDownloadUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationHttpClient']/method[@name='getV1GameDataDownloadUrl' and count(parameter)=0]"
			[Register ("getV1GameDataDownloadUrl", "()Ljava/lang/String;", "GetGetV1GameDataDownloadUrlHandler")]
			get {
				if (id_getV1GameDataDownloadUrl == IntPtr.Zero)
					id_getV1GameDataDownloadUrl = JNIEnv.GetMethodID (class_ref, "getV1GameDataDownloadUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getV1GameDataDownloadUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getV1GameDataDownloadUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_download_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='MigrationHttpClient']/method[@name='download' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("download", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/migration/DownloadResult;", "")]
		public global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult Download (string p0)
		{
			if (id_download_Ljava_lang_String_ == IntPtr.Zero)
				id_download_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;)Lcom/amazon/ags/client/whispersync/migration/DownloadResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Migration.DownloadResult> (JNIEnv.CallObjectMethod  (Handle, id_download_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
