using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='LocalizationUtil']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/LocalizationUtil", DoNotGenerateAcw=true)]
	public partial class LocalizationUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/LocalizationUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalizationUtil); }
		}

		protected LocalizationUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='LocalizationUtil']/constructor[@name='LocalizationUtil' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public LocalizationUtil (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocalizationUtil)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getCountryCode;
#pragma warning disable 0169
		static Delegate GetGetCountryCodeHandler ()
		{
			if (cb_getCountryCode == null)
				cb_getCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryCode);
			return cb_getCountryCode;
		}

		static IntPtr n_GetCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.LocalizationUtil __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryCode);
		}
#pragma warning restore 0169

		static IntPtr id_getCountryCode;
		public virtual string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='LocalizationUtil']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				if (id_getCountryCode == IntPtr.Zero)
					id_getCountryCode = JNIEnv.GetMethodID (class_ref, "getCountryCode", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentLocale;
#pragma warning disable 0169
		static Delegate GetGetCurrentLocaleHandler ()
		{
			if (cb_getCurrentLocale == null)
				cb_getCurrentLocale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentLocale);
			return cb_getCurrentLocale;
		}

		static IntPtr n_GetCurrentLocale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.LocalizationUtil __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentLocale);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentLocale;
		public virtual global::Java.Util.Locale CurrentLocale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='LocalizationUtil']/method[@name='getCurrentLocale' and count(parameter)=0]"
			[Register ("getCurrentLocale", "()Ljava/util/Locale;", "GetGetCurrentLocaleHandler")]
			get {
				if (id_getCurrentLocale == IntPtr.Zero)
					id_getCurrentLocale = JNIEnv.GetMethodID (class_ref, "getCurrentLocale", "()Ljava/util/Locale;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentLocale), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentLocale), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLanguageCode;
#pragma warning disable 0169
		static Delegate GetGetLanguageCodeHandler ()
		{
			if (cb_getLanguageCode == null)
				cb_getLanguageCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguageCode);
			return cb_getLanguageCode;
		}

		static IntPtr n_GetLanguageCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.LocalizationUtil __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.LocalizationUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LanguageCode);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguageCode;
		public virtual string LanguageCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='LocalizationUtil']/method[@name='getLanguageCode' and count(parameter)=0]"
			[Register ("getLanguageCode", "()Ljava/lang/String;", "GetGetLanguageCodeHandler")]
			get {
				if (id_getLanguageCode == IntPtr.Zero)
					id_getLanguageCode = JNIEnv.GetMethodID (class_ref, "getLanguageCode", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLanguageCode), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLanguageCode), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
