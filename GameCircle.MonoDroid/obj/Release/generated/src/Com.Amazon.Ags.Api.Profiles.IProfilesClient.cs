using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Profiles {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.profiles']/interface[@name='ProfilesClient']"
	[Register ("com/amazon/ags/api/profiles/ProfilesClient", "", "Com.Amazon.Ags.Api.Profiles.IProfilesClientInvoker")]
	public partial interface IProfilesClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.profiles']/interface[@name='ProfilesClient']/method[@name='getLocalPlayerProfile' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetLocalPlayerProfile_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Profiles.IProfilesClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerProfile (params global:: Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/profiles/ProfilesClient", DoNotGenerateAcw=true)]
	internal class IProfilesClientInvoker : global::Java.Lang.Object, IProfilesClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/profiles/ProfilesClient");
		IntPtr class_ref;

		public static IProfilesClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProfilesClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.profiles.ProfilesClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProfilesClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IProfilesClientInvoker); }
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
			global::Com.Amazon.Ags.Api.Profiles.IProfilesClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IProfilesClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalPlayerProfile (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLocalPlayerProfile_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetLocalPlayerProfile (params global:: Java.Lang.Object[] p0)
		{
			if (id_getLocalPlayerProfile_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getLocalPlayerProfile_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLocalPlayerProfile", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getLocalPlayerProfile_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
