using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='ProfilesClientImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/profiles/ProfilesClientImpl", DoNotGenerateAcw=true)]
	public partial class ProfilesClientImpl : global::Com.Amazon.Ags.Client.ClientBase, global::Com.Amazon.Ags.Api.Profiles.IProfilesClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/profiles/ProfilesClientImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilesClientImpl); }
		}

		protected ProfilesClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='ProfilesClientImpl']/constructor[@name='ProfilesClientImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProfilesClientImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilesClientImpl)) {
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

		static IntPtr id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='ProfilesClientImpl']/constructor[@name='ProfilesClientImpl' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.service.ServiceHelper']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", "")]
		public ProfilesClientImpl (global::Com.Amazon.Ags.Html5.Service.IServiceHelper p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilesClientImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/service/ServiceHelper;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/service/ServiceHelper;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_service_ServiceHelper_, new JValue (p0));
		}

		static Delegate cb_getLocalPlayerProfile_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetLocalPlayerProfile_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getLocalPlayerProfile_arrayLjava_lang_Object_ == null)
				cb_getLocalPlayerProfile_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalPlayerProfile_arrayLjava_lang_Object_);
			return cb_getLocalPlayerProfile_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetLocalPlayerProfile_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Profiles.ProfilesClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Profiles.ProfilesClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalPlayerProfile (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalPlayerProfile_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='ProfilesClientImpl']/method[@name='getLocalPlayerProfile' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLocalPlayerProfile_arrayLjava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerProfile (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLocalPlayerProfile_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerProfile_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod  (Handle, id_getLocalPlayerProfile_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalPlayerProfile_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Profiles.ProfilesClientImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Profiles.ProfilesClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='ProfilesClientImpl']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shutdown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_shutdown);
		}

	}
}
