using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/PopUpPrefs", DoNotGenerateAcw=true)]
	public sealed partial class PopUpPrefs : global::Java.Lang.Enum {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/amazon/ags/html5/overlay/PopUpPrefs;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/amazon/ags/html5/overlay/PopUpPrefs;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INSTANCE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/PopUpPrefs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PopUpPrefs); }
		}

		internal PopUpPrefs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFadeInDuration;
		public int FadeInDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='getFadeInDuration' and count(parameter)=0]"
			[Register ("getFadeInDuration", "()I", "GetGetFadeInDurationHandler")]
			get {
				if (id_getFadeInDuration == IntPtr.Zero)
					id_getFadeInDuration = JNIEnv.GetMethodID (class_ref, "getFadeInDuration", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFadeInDuration);
			}
		}

		static IntPtr id_getFadeOutDuration;
		public int FadeOutDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='getFadeOutDuration' and count(parameter)=0]"
			[Register ("getFadeOutDuration", "()I", "GetGetFadeOutDurationHandler")]
			get {
				if (id_getFadeOutDuration == IntPtr.Zero)
					id_getFadeOutDuration = JNIEnv.GetMethodID (class_ref, "getFadeOutDuration", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFadeOutDuration);
			}
		}

		static IntPtr id_isEnabled;
		public bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isEnabled);
			}
		}

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
		public global::Com.Amazon.Ags.Api.Overlay.PopUpLocation Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/amazon/ags/api/overlay/PopUpLocation;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/amazon/ags/api/overlay/PopUpLocation;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.overlay.PopUpLocation']]"
			[Register ("setLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V", "GetSetLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_Handler")]
			set {
				if (id_setLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == IntPtr.Zero)
					id_setLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (value));
			}
		}

		static IntPtr id_getWelcomeBackFadeInDuration;
		public int WelcomeBackFadeInDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='getWelcomeBackFadeInDuration' and count(parameter)=0]"
			[Register ("getWelcomeBackFadeInDuration", "()I", "GetGetWelcomeBackFadeInDurationHandler")]
			get {
				if (id_getWelcomeBackFadeInDuration == IntPtr.Zero)
					id_getWelcomeBackFadeInDuration = JNIEnv.GetMethodID (class_ref, "getWelcomeBackFadeInDuration", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getWelcomeBackFadeInDuration);
			}
		}

		static IntPtr id_getWelcomeBackFadeOutDuration;
		public int WelcomeBackFadeOutDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='getWelcomeBackFadeOutDuration' and count(parameter)=0]"
			[Register ("getWelcomeBackFadeOutDuration", "()I", "GetGetWelcomeBackFadeOutDurationHandler")]
			get {
				if (id_getWelcomeBackFadeOutDuration == IntPtr.Zero)
					id_getWelcomeBackFadeOutDuration = JNIEnv.GetMethodID (class_ref, "getWelcomeBackFadeOutDuration", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getWelcomeBackFadeOutDuration);
			}
		}

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_disable);
		}

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "")]
		public void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_enable);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/PopUpPrefs;", "")]
		public static global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/PopUpPrefs;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay']/class[@name='PopUpPrefs']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/ags/html5/overlay/PopUpPrefs;", "")]
		public static global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/ags/html5/overlay/PopUpPrefs;");
			return (global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Ags.Html5.Overlay.PopUpPrefs));
		}

	}
}
