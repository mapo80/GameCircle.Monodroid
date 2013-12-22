using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/thread/MAPCallbackFuture", DoNotGenerateAcw=true)]
	public partial class MAPCallbackFuture : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Shared.IAPIListener, global::Java.Util.Concurrent.IFuture {


		static IntPtr mError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/field[@name='mError']"
		[Register ("mError")]
		protected global::Com.Amazon.Identity.Auth.Device.AuthError MError {
			get {
				if (mError_jfieldId == IntPtr.Zero)
					mError_jfieldId = JNIEnv.GetFieldID (class_ref, "mError", "Lcom/amazon/identity/auth/device/AuthError;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mError_jfieldId == IntPtr.Zero)
					mError_jfieldId = JNIEnv.GetFieldID (class_ref, "mError", "Lcom/amazon/identity/auth/device/AuthError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mError_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLatch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/field[@name='mLatch']"
		[Register ("mLatch")]
		protected global::Java.Util.Concurrent.CountDownLatch MLatch {
			get {
				if (mLatch_jfieldId == IntPtr.Zero)
					mLatch_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatch", "Ljava/util/concurrent/CountDownLatch;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLatch_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CountDownLatch> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLatch_jfieldId == IntPtr.Zero)
					mLatch_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatch", "Ljava/util/concurrent/CountDownLatch;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLatch_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener MListener {
			get {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSuccessResult_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/field[@name='mSuccessResult']"
		[Register ("mSuccessResult")]
		protected global::Android.OS.Bundle MSuccessResult {
			get {
				if (mSuccessResult_jfieldId == IntPtr.Zero)
					mSuccessResult_jfieldId = JNIEnv.GetFieldID (class_ref, "mSuccessResult", "Landroid/os/Bundle;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSuccessResult_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSuccessResult_jfieldId == IntPtr.Zero)
					mSuccessResult_jfieldId = JNIEnv.GetFieldID (class_ref, "mSuccessResult", "Landroid/os/Bundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSuccessResult_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/thread/MAPCallbackFuture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPCallbackFuture); }
		}

		protected MAPCallbackFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/constructor[@name='MAPCallbackFuture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MAPCallbackFuture () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MAPCallbackFuture)) {
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

		static IntPtr id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/constructor[@name='MAPCallbackFuture' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.authorization.api.AuthorizationListener']]"
		[Register (".ctor", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", "")]
		public MAPCallbackFuture (global::Com.Amazon.Identity.Auth.Device.Authorization.Api.IAuthorizationListener p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MAPCallbackFuture)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/authorization/api/AuthorizationListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_authorization_api_AuthorizationListener_, new JValue (p0));
		}

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		static IntPtr id_isCancelled;
		public virtual bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCancelled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isCancelled);
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		static IntPtr id_isDone;
		public virtual bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler")]
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDone);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isDone);
			}
		}

		static Delegate cb_getResultHelper;
#pragma warning disable 0169
		static Delegate GetGetResultHelperHandler ()
		{
			if (cb_getResultHelper == null)
				cb_getResultHelper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultHelper);
			return cb_getResultHelper;
		}

		static IntPtr n_GetResultHelper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultHelper);
		}
#pragma warning restore 0169

		static IntPtr id_getResultHelper;
		protected virtual global::Android.OS.Bundle ResultHelper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='getResultHelper' and count(parameter)=0]"
			[Register ("getResultHelper", "()Landroid/os/Bundle;", "GetGetResultHelperHandler")]
			get {
				if (id_getResultHelper == IntPtr.Zero)
					id_getResultHelper = JNIEnv.GetMethodID (class_ref, "getResultHelper", "()Landroid/os/Bundle;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getResultHelper), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResultHelper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public virtual bool Cancel (bool p0)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_cancel_Z, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_cancel_Z, new JValue (p0));
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Landroid/os/Bundle;", "GetGetHandler")]
		public virtual global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Landroid/os/Bundle;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Landroid/os/Bundle;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Landroid/os/Bundle;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_get_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onError_Lcom_amazon_identity_auth_device_AuthError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_amazon_identity_auth_device_AuthError_Handler ()
		{
			if (cb_onError_Lcom_amazon_identity_auth_device_AuthError_ == null)
				cb_onError_Lcom_amazon_identity_auth_device_AuthError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_amazon_identity_auth_device_AuthError_);
			return cb_onError_Lcom_amazon_identity_auth_device_AuthError_;
		}

		static void n_OnError_Lcom_amazon_identity_auth_device_AuthError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Identity.Auth.Device.AuthError p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AuthError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Lcom_amazon_identity_auth_device_AuthError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AuthError']]"
		[Register ("onError", "(Lcom/amazon/identity/auth/device/AuthError;)V", "GetOnError_Lcom_amazon_identity_auth_device_AuthError_Handler")]
		public virtual void OnError (global::Com.Amazon.Identity.Auth.Device.AuthError p0)
		{
			if (id_onError_Lcom_amazon_identity_auth_device_AuthError_ == IntPtr.Zero)
				id_onError_Lcom_amazon_identity_auth_device_AuthError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/amazon/identity/auth/device/AuthError;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onError_Lcom_amazon_identity_auth_device_AuthError_, new JValue (p0));
		}

		static Delegate cb_onSuccess_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSuccess_Landroid_os_Bundle_ == null)
				cb_onSuccess_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Landroid_os_Bundle_);
			return cb_onSuccess_Landroid_os_Bundle_;
		}

		static void n_OnSuccess_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Thread.MAPCallbackFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='MAPCallbackFuture']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSuccess", "(Landroid/os/Bundle;)V", "GetOnSuccess_Landroid_os_Bundle_Handler")]
		public virtual void OnSuccess (global::Android.OS.Bundle p0)
		{
			if (id_onSuccess_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSuccess_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onSuccess_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
