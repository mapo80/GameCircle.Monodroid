using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/ClientConfigKeys", DoNotGenerateAcw=true)]
	public partial class ClientConfigKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='AUTH_GET_TOKEN_TIMEOUT_MILLIS']"
		[Register ("AUTH_GET_TOKEN_TIMEOUT_MILLIS")]
		public const string AuthGetTokenTimeoutMillis = (string) "AUTH_GET_TOKEN_TIMEOUT_MILLIS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='HTTP_CONNECTION_POOL_TIMEOUT_MILLIS']"
		[Register ("HTTP_CONNECTION_POOL_TIMEOUT_MILLIS")]
		public const string HttpConnectionPoolTimeoutMillis = (string) "HTTP_CONNECTION_POOL_TIMEOUT_MILLIS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='HTTP_CONNECTION_TIMEOUT_MILLIS']"
		[Register ("HTTP_CONNECTION_TIMEOUT_MILLIS")]
		public const string HttpConnectionTimeoutMillis = (string) "HTTP_CONNECTION_TIMEOUT_MILLIS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='HTTP_MAX_CONNECTIONS_PER_ROUTE']"
		[Register ("HTTP_MAX_CONNECTIONS_PER_ROUTE")]
		public const string HttpMaxConnectionsPerRoute = (string) "HTTP_MAX_CONNECTIONS_PER_ROUTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='HTTP_MAX_TOTAL_CONNECTIONS']"
		[Register ("HTTP_MAX_TOTAL_CONNECTIONS")]
		public const string HttpMaxTotalConnections = (string) "HTTP_MAX_TOTAL_CONNECTIONS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='HTTP_SOCKET_TIMEOUT_MILLIS']"
		[Register ("HTTP_SOCKET_TIMEOUT_MILLIS")]
		public const string HttpSocketTimeoutMillis = (string) "HTTP_SOCKET_TIMEOUT_MILLIS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='SETTINGS_CACHE_KEY']"
		[Register ("SETTINGS_CACHE_KEY")]
		public const string SettingsCacheKey = (string) "clientConfig";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/field[@name='THREAD_POOL_SIZE']"
		[Register ("THREAD_POOL_SIZE")]
		public const string ThreadPoolSize = (string) "THREAD_POOL_SIZE";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/ClientConfigKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientConfigKeys); }
		}

		protected ClientConfigKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='ClientConfigKeys']/constructor[@name='ClientConfigKeys' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ClientConfigKeys () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClientConfigKeys)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
