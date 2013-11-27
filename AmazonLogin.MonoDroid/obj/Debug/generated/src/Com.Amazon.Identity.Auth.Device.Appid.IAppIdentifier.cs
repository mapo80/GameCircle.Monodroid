using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Appid {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']"
	[Register ("com/amazon/identity/auth/device/appid/AppIdentifier", "", "Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker")]
	public partial interface IAppIdentifier : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAllowedScopes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAllowedScopes", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "GetGetAllowedScopes_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string[] GetAllowedScopes (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAppFamilyId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppFamilyId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetAppFamilyId_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string GetAppFamilyId (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAppInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppInfo", "(Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "GetGetAppInfo_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo GetAppInfo (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAppLabel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppLabel", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetAppLabel_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string GetAppLabel (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAppPermissions' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppPermissions", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "GetGetAppPermissions_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string[] GetAppPermissions (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getAppVariantId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppVariantId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetAppVariantId_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string GetAppVariantId (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getPackageName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageName", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetPackageName_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string GetPackageName (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getPackageNameByVariant' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageNameByVariant", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string GetPackageNameByVariant (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='getPackageNames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getPackageNames", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;", "GetGetPackageNames_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		string[] GetPackageNames (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='isAPIKeyValid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAPIKeyValid", "(Landroid/content/Context;)Z", "GetIsAPIKeyValid_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		bool IsAPIKeyValid (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='isAPIKeyValid' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("isAPIKeyValid", "(Ljava/lang/String;Landroid/content/Context;)Z", "GetIsAPIKeyValid_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		bool IsAPIKeyValid (string p0, global::Android.Content.Context p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.appid']/interface[@name='AppIdentifier']/method[@name='isAPIKeyValid' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("isAPIKeyValid", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Z", "GetIsAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler:Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifierInvoker, AmazonLogin.MonoDroid")]
		bool IsAPIKeyValid (string p0, string p1, global::Android.Content.Context p2);

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/appid/AppIdentifier", DoNotGenerateAcw=true)]
	internal class IAppIdentifierInvoker : global::Java.Lang.Object, IAppIdentifier {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/appid/AppIdentifier");
		IntPtr class_ref;

		public static IAppIdentifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppIdentifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.appid.AppIdentifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppIdentifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAppIdentifierInvoker); }
		}

		static Delegate cb_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAllowedScopes_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllowedScopes_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAllowedScopes_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAllowedScopes (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_;
		public string[] GetAllowedScopes (string p0, global::Android.Content.Context p1)
		{
			if (id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAllowedScopes", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getAllowedScopes_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppFamilyId_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppFamilyId_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAppFamilyId_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppFamilyId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_;
		public string GetAppFamilyId (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAppFamilyId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAppInfo_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppInfo_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAppInfo_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAppInfo_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppInfo_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAppInfo_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAppInfo_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAppInfo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppInfo_Ljava_lang_String_Landroid_content_Context_;
		public global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo GetAppInfo (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppInfo_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppInfo_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppInfo", "(Ljava/lang/String;Landroid/content/Context;)Lcom/amazon/identity/auth/device/dataobject/AppInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod (Handle, id_getAppInfo_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAppLabel_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppLabel_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAppLabel_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAppLabel_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppLabel_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAppLabel_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAppLabel_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppLabel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppLabel_Ljava_lang_String_Landroid_content_Context_;
		public string GetAppLabel (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppLabel_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppLabel_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppLabel", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAppLabel_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAppPermissions_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppPermissions_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppPermissions_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAppPermissions_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAppPermissions_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAppPermissions (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_;
		public string[] GetAppPermissions (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppPermissions", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getAppPermissions_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAppVariantId_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppVariantId_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppVariantId_Ljava_lang_String_Landroid_content_Context_);
			return cb_getAppVariantId_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetAppVariantId_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppVariantId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_;
		public string GetAppVariantId (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppVariantId", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAppVariantId_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPackageName_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPackageName_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getPackageName_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getPackageName_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPackageName_Ljava_lang_String_Landroid_content_Context_);
			return cb_getPackageName_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetPackageName_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageName (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPackageName_Ljava_lang_String_Landroid_content_Context_;
		public string GetPackageName (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageName_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageName_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageName", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPackageName_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_);
			return cb_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageNameByVariant (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_;
		public string GetPackageNameByVariant (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageNameByVariant", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPackageNameByVariant_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPackageNames_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPackageNames_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getPackageNames_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getPackageNames_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPackageNames_Ljava_lang_String_Landroid_content_Context_);
			return cb_getPackageNames_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetPackageNames_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetPackageNames (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPackageNames_Ljava_lang_String_Landroid_content_Context_;
		public string[] GetPackageNames (string p0, global::Android.Content.Context p1)
		{
			if (id_getPackageNames_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageNames_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPackageNames", "(Ljava/lang/String;Landroid/content/Context;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getPackageNames_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isAPIKeyValid_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsAPIKeyValid_Landroid_content_Context_Handler ()
		{
			if (cb_isAPIKeyValid_Landroid_content_Context_ == null)
				cb_isAPIKeyValid_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAPIKeyValid_Landroid_content_Context_);
			return cb_isAPIKeyValid_Landroid_content_Context_;
		}

		static bool n_IsAPIKeyValid_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAPIKeyValid (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAPIKeyValid_Landroid_content_Context_;
		public bool IsAPIKeyValid (global::Android.Content.Context p0)
		{
			if (id_isAPIKeyValid_Landroid_content_Context_ == IntPtr.Zero)
				id_isAPIKeyValid_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isAPIKeyValid", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isAPIKeyValid_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsAPIKeyValid_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsAPIKeyValid_Ljava_lang_String_Landroid_content_Context_);
			return cb_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_;
		}

		static bool n_IsAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAPIKeyValid (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_;
		public bool IsAPIKeyValid (string p0, global::Android.Content.Context p1)
		{
			if (id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isAPIKeyValid", "(Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isAPIKeyValid_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_);
			return cb_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static bool n_IsAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Appid.IAppIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAPIKeyValid (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		public bool IsAPIKeyValid (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isAPIKeyValid", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isAPIKeyValid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
