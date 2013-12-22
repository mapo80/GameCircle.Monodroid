using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Authorization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AmazonAuthorizationServiceInterfaceStub : global::Android.OS.Binder, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getMetaData;
#pragma warning disable 0169
			static Delegate GetGetMetaDataHandler ()
			{
				if (cb_getMetaData == null)
					cb_getMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetaData);
				return cb_getMetaData;
			}

			static IntPtr n_GetMetaData (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MetaData);
			}
#pragma warning restore 0169

			static IntPtr id_getMetaData;
			public virtual global::Android.OS.Bundle MetaData {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='getMetaData' and count(parameter)=0]"
				[Register ("getMetaData", "()Landroid/os/Bundle;", "GetGetMetaDataHandler")]
				get {
					if (id_getMetaData == IntPtr.Zero)
						id_getMetaData = JNIEnv.GetMethodID (class_ref, "getMetaData", "()Landroid/os/Bundle;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getMetaData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMetaData), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asBinder), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
			{
				if (cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
					cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
				return cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
			}

			static IntPtr n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authorize (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
			[Register ("authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
			public virtual global::Android.OS.Bundle Authorize (global::Android.OS.Bundle p0, string p1, string[] p2)
			{
				if (id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

			static Delegate cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler ()
			{
				if (cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == null)
					cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_);
				return cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
			}

			static IntPtr n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearAuthorizationState (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='clearAuthorizationState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
			[Register ("clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;", "GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler")]
			public virtual global::Android.OS.Bundle ClearAuthorizationState (global::Android.OS.Bundle p0, string p1)
			{
				if (id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
					id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;");
				IntPtr native_p1 = JNIEnv.NewString (p1);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static Delegate cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
			{
				if (cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
					cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
				return cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
			}

			static IntPtr n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub.Proxy']/method[@name='getToken' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
			[Register ("getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
			public virtual global::Android.OS.Bundle GetToken (global::Android.OS.Bundle p0, string p1, string[] p2)
			{
				if (id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonAuthorizationServiceInterfaceStub); }
		}

		protected AmazonAuthorizationServiceInterfaceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/constructor[@name='AmazonAuthorizationServiceInterface.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AmazonAuthorizationServiceInterfaceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AmazonAuthorizationServiceInterfaceStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface;");
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authorize (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle Authorize (global::Android.OS.Bundle p0, string p1, string[] p2);

		static Delegate cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearAuthorizationState (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='clearAuthorizationState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;", "GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle ClearAuthorizationState (global::Android.OS.Bundle p0, string p1);

		static Delegate cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='getToken' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle GetToken (global::Android.OS.Bundle p0, string p1, string[] p2);

		static Delegate cb_getMetaData;
#pragma warning disable 0169
		static Delegate GetGetMetaDataHandler ()
		{
			if (cb_getMetaData == null)
				cb_getMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetaData);
			return cb_getMetaData;
		}

		static IntPtr n_GetMetaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetaData);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.Bundle MetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='getMetaData' and count(parameter)=0]"
			[Register ("getMetaData", "()Landroid/os/Bundle;", "GetGetMetaDataHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub", DoNotGenerateAcw=true)]
	internal partial class AmazonAuthorizationServiceInterfaceStubInvoker : AmazonAuthorizationServiceInterfaceStub {

		public AmazonAuthorizationServiceInterfaceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonAuthorizationServiceInterfaceStubInvoker); }
		}

		static IntPtr id_getMetaData;
		public override global::Android.OS.Bundle MetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='getMetaData' and count(parameter)=0]"
			[Register ("getMetaData", "()Landroid/os/Bundle;", "GetGetMetaDataHandler")]
			get {
				if (id_getMetaData == IntPtr.Zero)
					id_getMetaData = JNIEnv.GetMethodID (class_ref, "getMetaData", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getMetaData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override global::Android.OS.Bundle Authorize (global::Android.OS.Bundle p0, string p1, string[] p2)
		{
			if (id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='clearAuthorizationState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;", "GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public override global::Android.OS.Bundle ClearAuthorizationState (global::Android.OS.Bundle p0, string p1)
		{
			if (id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/class[@name='AmazonAuthorizationServiceInterface.Stub']/method[@name='getToken' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override global::Android.OS.Bundle GetToken (global::Android.OS.Bundle p0, string p1, string[] p2)
		{
			if (id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonAuthorizationServiceInterface']"
	[Register ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface", "", "Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterfaceInvoker")]
	public partial interface IAmazonAuthorizationServiceInterface : global::Android.OS.IInterface {

		global::Android.OS.Bundle MetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonAuthorizationServiceInterface']/method[@name='getMetaData' and count(parameter)=0]"
			[Register ("getMetaData", "()Landroid/os/Bundle;", "GetGetMetaDataHandler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterfaceInvoker, AmazonLogin.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonAuthorizationServiceInterface']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterfaceInvoker, AmazonLogin.MonoDroid")]
		global::Android.OS.Bundle Authorize (global::Android.OS.Bundle p0, string p1, string[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonAuthorizationServiceInterface']/method[@name='clearAuthorizationState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;", "GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterfaceInvoker, AmazonLogin.MonoDroid")]
		global::Android.OS.Bundle ClearAuthorizationState (global::Android.OS.Bundle p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.authorization']/interface[@name='AmazonAuthorizationServiceInterface']/method[@name='getToken' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;", "GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler:Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterfaceInvoker, AmazonLogin.MonoDroid")]
		global::Android.OS.Bundle GetToken (global::Android.OS.Bundle p0, string p1, string[] p2);

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface", DoNotGenerateAcw=true)]
	internal class IAmazonAuthorizationServiceInterfaceInvoker : global::Java.Lang.Object, IAmazonAuthorizationServiceInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface");
		IntPtr class_ref;

		public static IAmazonAuthorizationServiceInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmazonAuthorizationServiceInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.authorization.AmazonAuthorizationServiceInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmazonAuthorizationServiceInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAmazonAuthorizationServiceInterfaceInvoker); }
		}

		static Delegate cb_getMetaData;
#pragma warning disable 0169
		static Delegate GetGetMetaDataHandler ()
		{
			if (cb_getMetaData == null)
				cb_getMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetaData);
			return cb_getMetaData;
		}

		static IntPtr n_GetMetaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetaData);
		}
#pragma warning restore 0169

		IntPtr id_getMetaData;
		public global::Android.OS.Bundle MetaData {
			get {
				if (id_getMetaData == IntPtr.Zero)
					id_getMetaData = JNIEnv.GetMethodID (class_ref, "getMetaData", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (Handle, id_getMetaData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_Authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authorize (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		public global::Android.OS.Bundle Authorize (global::Android.OS.Bundle p0, string p1, string[] p2)
		{
			if (id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (Handle, id_authorize_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_ClearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearAuthorizationState (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_;
		public global::Android.OS.Bundle ClearAuthorizationState (global::Android.OS.Bundle p0, string p1)
		{
			if (id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearAuthorizationState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (Handle, id_clearAuthorizationState_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_GetToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_;
		public global::Android.OS.Bundle GetToken (global::Android.OS.Bundle p0, string p1, string[] p2)
		{
			if (id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Landroid/os/Bundle;Ljava/lang/String;[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (Handle, id_getToken_Landroid_os_Bundle_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.IAmazonAuthorizationServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
