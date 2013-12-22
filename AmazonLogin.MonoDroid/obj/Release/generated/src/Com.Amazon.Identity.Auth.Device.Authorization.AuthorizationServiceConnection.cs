using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationServiceConnection']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AuthorizationServiceConnection", DoNotGenerateAcw=true)]
	public partial class AuthorizationServiceConnection : global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AuthorizationServiceConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationServiceConnection); }
		}

		protected AuthorizationServiceConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationServiceConnection']/constructor[@name='AuthorizationServiceConnection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthorizationServiceConnection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthorizationServiceConnection)) {
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

		static Delegate cb_getServiceInterfaceClass;
#pragma warning disable 0169
		static Delegate GetGetServiceInterfaceClassHandler ()
		{
			if (cb_getServiceInterfaceClass == null)
				cb_getServiceInterfaceClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceInterfaceClass);
			return cb_getServiceInterfaceClass;
		}

		static IntPtr n_GetServiceInterfaceClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServiceInterfaceClass);
		}
#pragma warning restore 0169

		static IntPtr id_getServiceInterfaceClass;
		public override global::Java.Lang.Class ServiceInterfaceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationServiceConnection']/method[@name='getServiceInterfaceClass' and count(parameter)=0]"
			[Register ("getServiceInterfaceClass", "()Ljava/lang/Class;", "GetGetServiceInterfaceClassHandler")]
			get {
				if (id_getServiceInterfaceClass == IntPtr.Zero)
					id_getServiceInterfaceClass = JNIEnv.GetMethodID (class_ref, "getServiceInterfaceClass", "()Ljava/lang/Class;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getServiceInterfaceClass), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getServiceInterfaceClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServiceInterface_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetGetServiceInterface_Landroid_os_IBinder_Handler ()
		{
			if (cb_getServiceInterface_Landroid_os_IBinder_ == null)
				cb_getServiceInterface_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServiceInterface_Landroid_os_IBinder_);
			return cb_getServiceInterface_Landroid_os_IBinder_;
		}

		static IntPtr n_GetServiceInterface_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AuthorizationServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetServiceInterface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AuthorizationServiceConnection']/method[@name='getServiceInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getServiceInterface", "(Landroid/os/IBinder;)Landroid/os/IInterface;", "GetGetServiceInterface_Landroid_os_IBinder_Handler")]
		public override global::Android.OS.IInterface GetServiceInterface (global::Android.OS.IBinder p0)
		{
			if (id_getServiceInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_getServiceInterface_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "getServiceInterface", "(Landroid/os/IBinder;)Landroid/os/IInterface;");

			global::Android.OS.IInterface __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallObjectMethod  (Handle, id_getServiceInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getServiceInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
