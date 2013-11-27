using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/OverlaySessionInformation", DoNotGenerateAcw=true)]
	public partial class OverlaySessionInformation : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/OverlaySessionInformation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlaySessionInformation); }
		}

		protected OverlaySessionInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_util_DeviceInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/constructor[@name='OverlaySessionInformation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.amazon.ags.html5.util.LocalizationUtil'] and parameter[5][@type='com.amazon.ags.html5.util.DeviceInfo']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/util/DeviceInfo;)V", "")]
		public OverlaySessionInformation (string p0, string p1, string p2, global::Com.Amazon.Ags.Html5.Util.LocalizationUtil p3, global::Com.Amazon.Ags.Html5.Util.DeviceInfo p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (OverlaySessionInformation)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/util/DeviceInfo;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/util/DeviceInfo;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_util_DeviceInfo_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_util_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/amazon/ags/html5/util/LocalizationUtil;Lcom/amazon/ags/html5/util/DeviceInfo;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_amazon_ags_html5_util_LocalizationUtil_Lcom_amazon_ags_html5_util_DeviceInfo_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getApplicationName;
#pragma warning disable 0169
		static Delegate GetGetApplicationNameHandler ()
		{
			if (cb_getApplicationName == null)
				cb_getApplicationName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationName);
			return cb_getApplicationName;
		}

		static IntPtr n_GetApplicationName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationName);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationName;
		public virtual string ApplicationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/method[@name='getApplicationName' and count(parameter)=0]"
			[Register ("getApplicationName", "()Ljava/lang/String;", "GetGetApplicationNameHandler")]
			get {
				if (id_getApplicationName == IntPtr.Zero)
					id_getApplicationName = JNIEnv.GetMethodID (class_ref, "getApplicationName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApplicationName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClientVersion;
#pragma warning disable 0169
		static Delegate GetGetClientVersionHandler ()
		{
			if (cb_getClientVersion == null)
				cb_getClientVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientVersion);
			return cb_getClientVersion;
		}

		static IntPtr n_GetClientVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getClientVersion;
		public virtual string ClientVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/method[@name='getClientVersion' and count(parameter)=0]"
			[Register ("getClientVersion", "()Ljava/lang/String;", "GetGetClientVersionHandler")]
			get {
				if (id_getClientVersion == IntPtr.Zero)
					id_getClientVersion = JNIEnv.GetMethodID (class_ref, "getClientVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getClientVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentVersion;
#pragma warning disable 0169
		static Delegate GetGetContentVersionHandler ()
		{
			if (cb_getContentVersion == null)
				cb_getContentVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentVersion);
			return cb_getContentVersion;
		}

		static IntPtr n_GetContentVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getContentVersion;
		public virtual string ContentVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/method[@name='getContentVersion' and count(parameter)=0]"
			[Register ("getContentVersion", "()Ljava/lang/String;", "GetGetContentVersionHandler")]
			get {
				if (id_getContentVersion == IntPtr.Zero)
					id_getContentVersion = JNIEnv.GetMethodID (class_ref, "getContentVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getContentVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceInfo;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfoHandler ()
		{
			if (cb_getDeviceInfo == null)
				cb_getDeviceInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceInfo);
			return cb_getDeviceInfo;
		}

		static IntPtr n_GetDeviceInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceInfo;
		public virtual global::Com.Amazon.Ags.Html5.Util.DeviceInfo DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Lcom/amazon/ags/html5/util/DeviceInfo;", "GetGetDeviceInfoHandler")]
			get {
				if (id_getDeviceInfo == IntPtr.Zero)
					id_getDeviceInfo = JNIEnv.GetMethodID (class_ref, "getDeviceInfo", "()Lcom/amazon/ags/html5/util/DeviceInfo;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.DeviceInfo> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.DeviceInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalizationUtil;
#pragma warning disable 0169
		static Delegate GetGetLocalizationUtilHandler ()
		{
			if (cb_getLocalizationUtil == null)
				cb_getLocalizationUtil = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalizationUtil);
			return cb_getLocalizationUtil;
		}

		static IntPtr n_GetLocalizationUtil (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.OverlaySessionInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalizationUtil);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalizationUtil;
		public virtual global::Com.Amazon.Ags.Html5.Util.LocalizationUtil LocalizationUtil {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='OverlaySessionInformation']/method[@name='getLocalizationUtil' and count(parameter)=0]"
			[Register ("getLocalizationUtil", "()Lcom/amazon/ags/html5/util/LocalizationUtil;", "GetGetLocalizationUtilHandler")]
			get {
				if (id_getLocalizationUtil == IntPtr.Zero)
					id_getLocalizationUtil = JNIEnv.GetMethodID (class_ref, "getLocalizationUtil", "()Lcom/amazon/ags/html5/util/LocalizationUtil;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (JNIEnv.CallObjectMethod  (Handle, id_getLocalizationUtil), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalizationUtil), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
