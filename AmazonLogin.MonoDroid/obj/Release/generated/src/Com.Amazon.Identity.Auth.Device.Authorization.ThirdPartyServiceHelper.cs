using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper", DoNotGenerateAcw=true)]
	public partial class ThirdPartyServiceHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.HighestVersionedService']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper$HighestVersionedService", DoNotGenerateAcw=true)]
		public partial class HighestVersionedService : global::Java.Lang.Object {

			protected HighestVersionedService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper$MAPServiceInfo", DoNotGenerateAcw=true)]
		public partial class MAPServiceInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper$MAPServiceInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MAPServiceInfo); }
			}

			protected MAPServiceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_amazon_identity_auth_device_authorization_ThirdPartyServiceHelper_Lcom_amazon_identity_auth_device_utils_MAPVersion_Landroid_os_IInterface_Lcom_amazon_identity_auth_device_authorization_ThirdPartyAuthorizationServiceConnection_ZLandroid_content_pm_ResolveInfo_Landroid_content_Intent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/constructor[@name='ThirdPartyServiceHelper.MAPServiceInfo' and count(parameter)=7 and parameter[1][@type='com.amazon.identity.auth.device.authorization.ThirdPartyServiceHelper'] and parameter[2][@type='com.amazon.identity.auth.device.utils.MAPVersion'] and parameter[3][@type='android.os.IInterface'] and parameter[4][@type='com.amazon.identity.auth.device.authorization.ThirdPartyAuthorizationServiceConnection'] and parameter[5][@type='boolean'] and parameter[6][@type='android.content.pm.ResolveInfo'] and parameter[7][@type='android.content.Intent']]"
			[Register (".ctor", "(Lcom/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper;Lcom/amazon/identity/auth/device/utils/MAPVersion;Landroid/os/IInterface;Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;ZLandroid/content/pm/ResolveInfo;Landroid/content/Intent;)V", "")]
			public MAPServiceInfo (global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper __self, global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion p1, global::Android.OS.IInterface p2, global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyAuthorizationServiceConnection p3, bool p4, global::Android.Content.PM.ResolveInfo p5, global::Android.Content.Intent p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MAPServiceInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/amazon/identity/auth/device/utils/MAPVersion;Landroid/os/IInterface;Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;ZLandroid/content/pm/ResolveInfo;Landroid/content/Intent;)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/amazon/identity/auth/device/utils/MAPVersion;Landroid/os/IInterface;Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;ZLandroid/content/pm/ResolveInfo;Landroid/content/Intent;)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
					return;
				}

				if (id_ctor_Lcom_amazon_identity_auth_device_authorization_ThirdPartyServiceHelper_Lcom_amazon_identity_auth_device_utils_MAPVersion_Landroid_os_IInterface_Lcom_amazon_identity_auth_device_authorization_ThirdPartyAuthorizationServiceConnection_ZLandroid_content_pm_ResolveInfo_Landroid_content_Intent_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_identity_auth_device_authorization_ThirdPartyServiceHelper_Lcom_amazon_identity_auth_device_utils_MAPVersion_Landroid_os_IInterface_Lcom_amazon_identity_auth_device_authorization_ThirdPartyAuthorizationServiceConnection_ZLandroid_content_pm_ResolveInfo_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper;Lcom/amazon/identity/auth/device/utils/MAPVersion;Landroid/os/IInterface;Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;ZLandroid/content/pm/ResolveInfo;Landroid/content/Intent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_ThirdPartyServiceHelper_Lcom_amazon_identity_auth_device_utils_MAPVersion_Landroid_os_IInterface_Lcom_amazon_identity_auth_device_authorization_ThirdPartyAuthorizationServiceConnection_ZLandroid_content_pm_ResolveInfo_Landroid_content_Intent_, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_ThirdPartyServiceHelper_Lcom_amazon_identity_auth_device_utils_MAPVersion_Landroid_os_IInterface_Lcom_amazon_identity_auth_device_authorization_ThirdPartyAuthorizationServiceConnection_ZLandroid_content_pm_ResolveInfo_Landroid_content_Intent_, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
			}

			static Delegate cb_getConnection;
#pragma warning disable 0169
			static Delegate GetGetConnectionHandler ()
			{
				if (cb_getConnection == null)
					cb_getConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnection);
				return cb_getConnection;
			}

			static IntPtr n_GetConnection (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Connection);
			}
#pragma warning restore 0169

			static IntPtr id_getConnection;
			public virtual global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyAuthorizationServiceConnection Connection {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='getConnection' and count(parameter)=0]"
				[Register ("getConnection", "()Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;", "GetGetConnectionHandler")]
				get {
					if (id_getConnection == IntPtr.Zero)
						id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Lcom/amazon/identity/auth/device/authorization/ThirdPartyAuthorizationServiceConnection;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyAuthorizationServiceConnection> (JNIEnv.CallObjectMethod  (Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyAuthorizationServiceConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConnection), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_isPrimary;
#pragma warning disable 0169
			static Delegate GetIsPrimaryHandler ()
			{
				if (cb_isPrimary == null)
					cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
				return cb_isPrimary;
			}

			static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPrimary;
			}
#pragma warning restore 0169

			static IntPtr id_isPrimary;
			public virtual bool IsPrimary {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='isPrimary' and count(parameter)=0]"
				[Register ("isPrimary", "()Z", "GetIsPrimaryHandler")]
				get {
					if (id_isPrimary == IntPtr.Zero)
						id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPrimary);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPrimary);
				}
			}

			static Delegate cb_getMapVersion;
#pragma warning disable 0169
			static Delegate GetGetMapVersionHandler ()
			{
				if (cb_getMapVersion == null)
					cb_getMapVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapVersion);
				return cb_getMapVersion;
			}

			static IntPtr n_GetMapVersion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MapVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getMapVersion;
			public virtual global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion MapVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='getMapVersion' and count(parameter)=0]"
				[Register ("getMapVersion", "()Lcom/amazon/identity/auth/device/utils/MAPVersion;", "GetGetMapVersionHandler")]
				get {
					if (id_getMapVersion == IntPtr.Zero)
						id_getMapVersion = JNIEnv.GetMethodID (class_ref, "getMapVersion", "()Lcom/amazon/identity/auth/device/utils/MAPVersion;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion> (JNIEnv.CallObjectMethod  (Handle, id_getMapVersion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMapVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getService;
#pragma warning disable 0169
			static Delegate GetGetServiceHandler ()
			{
				if (cb_getService == null)
					cb_getService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetService);
				return cb_getService;
			}

			static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Service);
			}
#pragma warning restore 0169

			static Delegate cb_setService_Landroid_os_IInterface_;
#pragma warning disable 0169
			static Delegate GetSetService_Landroid_os_IInterface_Handler ()
			{
				if (cb_setService_Landroid_os_IInterface_ == null)
					cb_setService_Landroid_os_IInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetService_Landroid_os_IInterface_);
				return cb_setService_Landroid_os_IInterface_;
			}

			static void n_SetService_Landroid_os_IInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.IInterface p0 = (global::Android.OS.IInterface)global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Service = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getService;
			static IntPtr id_setService_Landroid_os_IInterface_;
			public virtual global::Android.OS.IInterface Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Landroid/os/IInterface;", "GetGetServiceHandler")]
				get {
					if (id_getService == IntPtr.Zero)
						id_getService = JNIEnv.GetMethodID (class_ref, "getService", "()Landroid/os/IInterface;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallObjectMethod  (Handle, id_getService), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getService), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='android.os.IInterface']]"
				[Register ("setService", "(Landroid/os/IInterface;)V", "GetSetService_Landroid_os_IInterface_Handler")]
				set {
					if (id_setService_Landroid_os_IInterface_ == IntPtr.Zero)
						id_setService_Landroid_os_IInterface_ = JNIEnv.GetMethodID (class_ref, "setService", "(Landroid/os/IInterface;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setService_Landroid_os_IInterface_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setService_Landroid_os_IInterface_, new JValue (value));
				}
			}

			static Delegate cb_getServiceIntent;
#pragma warning disable 0169
			static Delegate GetGetServiceIntentHandler ()
			{
				if (cb_getServiceIntent == null)
					cb_getServiceIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceIntent);
				return cb_getServiceIntent;
			}

			static IntPtr n_GetServiceIntent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ServiceIntent);
			}
#pragma warning restore 0169

			static Delegate cb_setServiceIntent_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetSetServiceIntent_Landroid_content_Intent_Handler ()
			{
				if (cb_setServiceIntent_Landroid_content_Intent_ == null)
					cb_setServiceIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceIntent_Landroid_content_Intent_);
				return cb_setServiceIntent_Landroid_content_Intent_;
			}

			static void n_SetServiceIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper.MAPServiceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ServiceIntent = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getServiceIntent;
			static IntPtr id_setServiceIntent_Landroid_content_Intent_;
			public virtual global::Android.Content.Intent ServiceIntent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='getServiceIntent' and count(parameter)=0]"
				[Register ("getServiceIntent", "()Landroid/content/Intent;", "GetGetServiceIntentHandler")]
				get {
					if (id_getServiceIntent == IntPtr.Zero)
						id_getServiceIntent = JNIEnv.GetMethodID (class_ref, "getServiceIntent", "()Landroid/content/Intent;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getServiceIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getServiceIntent), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.MAPServiceInfo']/method[@name='setServiceIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
				[Register ("setServiceIntent", "(Landroid/content/Intent;)V", "GetSetServiceIntent_Landroid_content_Intent_Handler")]
				set {
					if (id_setServiceIntent_Landroid_content_Intent_ == IntPtr.Zero)
						id_setServiceIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setServiceIntent", "(Landroid/content/Intent;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setServiceIntent_Landroid_content_Intent_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setServiceIntent_Landroid_content_Intent_, new JValue (value));
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.TOKEN_KEYS']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper$TOKEN_KEYS", DoNotGenerateAcw=true)]
		public sealed partial class TOKEN_KEYS : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.TOKEN_KEYS']/field[@name='ACCESS_ATZ_EXPIRES_IN']"
			[Register ("ACCESS_ATZ_EXPIRES_IN")]
			public const string AccessAtzExpiresIn = (string) "accessAtzToken.expiries_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.TOKEN_KEYS']/field[@name='ACCESS_ATZ_TOKEN']"
			[Register ("ACCESS_ATZ_TOKEN")]
			public const string AccessAtzToken = (string) "accessAtzToken";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.TOKEN_KEYS']/field[@name='REFRESH_ATZ_TOKEN']"
			[Register ("REFRESH_ATZ_TOKEN")]
			public const string RefreshAtzToken = (string) "refreshAtzToken";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper$TOKEN_KEYS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TOKEN_KEYS); }
			}

			internal TOKEN_KEYS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper.TOKEN_KEYS']/constructor[@name='ThirdPartyServiceHelper.TOKEN_KEYS' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public TOKEN_KEYS () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (TOKEN_KEYS)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/ThirdPartyServiceHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThirdPartyServiceHelper); }
		}

		protected ThirdPartyServiceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']/constructor[@name='ThirdPartyServiceHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ThirdPartyServiceHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ThirdPartyServiceHelper)) {
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

		static IntPtr id_clearCachedService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']/method[@name='clearCachedService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearCachedService", "(Landroid/content/Context;)V", "")]
		public static void ClearCachedService (global::Android.Content.Context p0)
		{
			if (id_clearCachedService_Landroid_content_Context_ == IntPtr.Zero)
				id_clearCachedService_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearCachedService", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCachedService_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getAuthorizationServiceInstance_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationServiceInstance_Landroid_content_Context_Handler ()
		{
			if (cb_getAuthorizationServiceInstance_Landroid_content_Context_ == null)
				cb_getAuthorizationServiceInstance_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthorizationServiceInstance_Landroid_content_Context_);
			return cb_getAuthorizationServiceInstance_Landroid_content_Context_;
		}

		static IntPtr n_GetAuthorizationServiceInstance_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.ThirdPartyServiceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthorizationServiceInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationServiceInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']/method[@name='getAuthorizationServiceInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAuthorizationServiceInstance", "(Landroid/content/Context;)Landroid/os/IInterface;", "GetGetAuthorizationServiceInstance_Landroid_content_Context_Handler")]
		public virtual global::Android.OS.IInterface GetAuthorizationServiceInstance (global::Android.Content.Context p0)
		{
			if (id_getAuthorizationServiceInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getAuthorizationServiceInstance_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAuthorizationServiceInstance", "(Landroid/content/Context;)Landroid/os/IInterface;");

			global::Android.OS.IInterface __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallObjectMethod  (Handle, id_getAuthorizationServiceInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAuthorizationServiceInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRemoteAndroidService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']/method[@name='getRemoteAndroidService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteAndroidService", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface GetRemoteAndroidService (global::Android.Content.Context p0)
		{
			if (id_getRemoteAndroidService_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteAndroidService_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteAndroidService", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface;");
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteAndroidService_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_unbind_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='ThirdPartyServiceHelper']/method[@name='unbind' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unbind", "(Landroid/content/Context;)V", "")]
		public static void Unbind (global::Android.Content.Context p0)
		{
			if (id_unbind_Landroid_content_Context_ == IntPtr.Zero)
				id_unbind_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "unbind", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unbind_Landroid_content_Context_, new JValue (p0));
		}

	}
}
