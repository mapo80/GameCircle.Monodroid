using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/MAPServiceConnection", DoNotGenerateAcw=true)]
	public abstract partial class MAPServiceConnection : global::Java.Lang.Object, global::Android.Content.IServiceConnection {


		static IntPtr mListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener MListener {
			get {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/amazon/identity/auth/device/authorization/AmazonServiceListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/amazon/identity/auth/device/authorization/AmazonServiceListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/field[@name='mService']"
		[Register ("mService")]
		protected global::Android.OS.IInterface MService {
			get {
				if (mService_jfieldId == IntPtr.Zero)
					mService_jfieldId = JNIEnv.GetFieldID (class_ref, "mService", "Landroid/os/IInterface;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mService_jfieldId == IntPtr.Zero)
					mService_jfieldId = JNIEnv.GetFieldID (class_ref, "mService", "Landroid/os/IInterface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mService_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/MAPServiceConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPServiceConnection); }
		}

		protected MAPServiceConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/constructor[@name='MAPServiceConnection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MAPServiceConnection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MAPServiceConnection)) {
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
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServiceInterfaceClass);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Class ServiceInterfaceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='getServiceInterfaceClass' and count(parameter)=0]"
			[Register ("getServiceInterfaceClass", "()Ljava/lang/Class;", "GetGetServiceInterfaceClassHandler")] get;
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
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetServiceInterface (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='getServiceInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getServiceInterface", "(Landroid/os/IBinder;)Landroid/os/IInterface;", "GetGetServiceInterface_Landroid_os_IBinder_Handler")]
		public abstract global::Android.OS.IInterface GetServiceInterface (global::Android.OS.IBinder p0);

		static Delegate cb_isValidService_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetIsValidService_Landroid_os_IBinder_Handler ()
		{
			if (cb_isValidService_Landroid_os_IBinder_ == null)
				cb_isValidService_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsValidService_Landroid_os_IBinder_);
			return cb_isValidService_Landroid_os_IBinder_;
		}

		static bool n_IsValidService_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsValidService (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isValidService_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='isValidService' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("isValidService", "(Landroid/os/IBinder;)Z", "GetIsValidService_Landroid_os_IBinder_Handler")]
		protected virtual bool IsValidService (global::Android.OS.IBinder p0)
		{
			if (id_isValidService_Landroid_os_IBinder_ == IntPtr.Zero)
				id_isValidService_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "isValidService", "(Landroid/os/IBinder;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isValidService_Landroid_os_IBinder_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isValidService_Landroid_os_IBinder_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
		{
			if (id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == IntPtr.Zero)
				id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual void OnServiceDisconnected (global::Android.Content.ComponentName p0)
		{
			if (id_onServiceDisconnected_Landroid_content_ComponentName_ == IntPtr.Zero)
				id_onServiceDisconnected_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onServiceDisconnected_Landroid_content_ComponentName_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onServiceDisconnected_Landroid_content_ComponentName_, new JValue (p0));
		}

		static Delegate cb_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_;
#pragma warning disable 0169
		static Delegate GetSetServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_Handler ()
		{
			if (cb_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_ == null)
				cb_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_);
			return cb_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_;
		}

		static void n_SetServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.MAPServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener p0 = (global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServiceListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='setServiceListener' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.authorization.AmazonServiceListener']]"
		[Register ("setServiceListener", "(Lcom/amazon/identity/auth/device/authorization/AmazonServiceListener;)V", "GetSetServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_Handler")]
		public virtual void SetServiceListener (global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener p0)
		{
			if (id_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_ == IntPtr.Zero)
				id_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_ = JNIEnv.GetMethodID (class_ref, "setServiceListener", "(Lcom/amazon/identity/auth/device/authorization/AmazonServiceListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setServiceListener_Lcom_amazon_identity_auth_device_authorization_AmazonServiceListener_, new JValue (p0));
		}

#region "Event implementation for Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener"
		public event EventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.BindErrorEventArgs> BindError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor>(
						ref weak_implementor_SetServiceListener,
						__CreateIAmazonServiceListenerImplementor,
						SetServiceListener,
						__h => __h.OnBindErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor>(
						ref weak_implementor_SetServiceListener,
						global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor.__IsEmpty,
						__v => SetServiceListener (null),
						__h => __h.OnBindErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.BindSuccessEventArgs> BindSuccess {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor>(
						ref weak_implementor_SetServiceListener,
						__CreateIAmazonServiceListenerImplementor,
						SetServiceListener,
						__h => __h.OnBindSuccessHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListener, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor>(
						ref weak_implementor_SetServiceListener,
						global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor.__IsEmpty,
						__v => SetServiceListener (null),
						__h => __h.OnBindSuccessHandler -= value);
			}
		}

		WeakReference weak_implementor_SetServiceListener;

		global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor __CreateIAmazonServiceListenerImplementor ()
		{
			return new global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonServiceListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/MAPServiceConnection", DoNotGenerateAcw=true)]
	internal partial class MAPServiceConnectionInvoker : MAPServiceConnection {

		public MAPServiceConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPServiceConnectionInvoker); }
		}

		static IntPtr id_getServiceInterfaceClass;
		public override global::Java.Lang.Class ServiceInterfaceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='getServiceInterfaceClass' and count(parameter)=0]"
			[Register ("getServiceInterfaceClass", "()Ljava/lang/Class;", "GetGetServiceInterfaceClassHandler")]
			get {
				if (id_getServiceInterfaceClass == IntPtr.Zero)
					id_getServiceInterfaceClass = JNIEnv.GetMethodID (class_ref, "getServiceInterfaceClass", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getServiceInterfaceClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getServiceInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='MAPServiceConnection']/method[@name='getServiceInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getServiceInterface", "(Landroid/os/IBinder;)Landroid/os/IInterface;", "GetGetServiceInterface_Landroid_os_IBinder_Handler")]
		public override global::Android.OS.IInterface GetServiceInterface (global::Android.OS.IBinder p0)
		{
			if (id_getServiceInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_getServiceInterface_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "getServiceInterface", "(Landroid/os/IBinder;)Landroid/os/IInterface;");
			global::Android.OS.IInterface __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IInterface> (JNIEnv.CallObjectMethod  (Handle, id_getServiceInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
