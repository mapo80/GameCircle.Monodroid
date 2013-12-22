using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/ClientConfig", DoNotGenerateAcw=true)]
	public partial class ClientConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig.ConfigEntry']"
		[global::Android.Runtime.Register ("com/amazon/ags/html5/util/ClientConfig$ConfigEntry", DoNotGenerateAcw=true)]
		public partial class ConfigEntry : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/html5/util/ClientConfig$ConfigEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConfigEntry); }
			}

			protected ConfigEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_JJJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig.ConfigEntry']/constructor[@name='ClientConfig.ConfigEntry' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register (".ctor", "(JJJ)V", "")]
			public ConfigEntry (long p0, long p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ConfigEntry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJJ)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JJJ)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_JJJ == IntPtr.Zero)
					id_ctor_JJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJJ, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JJJ, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetValue);
				return cb_getValue;
			}

			static long n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Util.ClientConfig.ConfigEntry __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.ClientConfig.ConfigEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Value;
			}
#pragma warning restore 0169

			static Delegate cb_setValue_J;
#pragma warning disable 0169
			static Delegate GetSetValue_JHandler ()
			{
				if (cb_setValue_J == null)
					cb_setValue_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetValue_J);
				return cb_setValue_J;
			}

			static void n_SetValue_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Ags.Html5.Util.ClientConfig.ConfigEntry __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.ClientConfig.ConfigEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Value = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			static IntPtr id_setValue_J;
			public virtual long Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig.ConfigEntry']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()J", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getValue);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig.ConfigEntry']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setValue", "(J)V", "GetSetValue_JHandler")]
				set {
					if (id_setValue_J == IntPtr.Zero)
						id_setValue_J = JNIEnv.GetMethodID (class_ref, "setValue", "(J)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setValue_J, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setValue_J, new JValue (value));
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/ClientConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientConfig); }
		}

		protected ClientConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig']/constructor[@name='ClientConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ClientConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClientConfig)) {
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

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static long n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.ClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.ClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Get (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)J", "GetGet_Ljava_lang_String_Handler")]
		public virtual long Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_get_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_load_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLoad_Lorg_json_JSONObject_Handler ()
		{
			if (cb_load_Lorg_json_JSONObject_ == null)
				cb_load_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Load_Lorg_json_JSONObject_);
			return cb_load_Lorg_json_JSONObject_;
		}

		static void n_Load_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.ClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.ClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0);
		}
#pragma warning restore 0169

		static IntPtr id_load_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ClientConfig']/method[@name='load' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("load", "(Lorg/json/JSONObject;)V", "GetLoad_Lorg_json_JSONObject_Handler")]
		public virtual void Load (global::Org.Json.JSONObject p0)
		{
			if (id_load_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_load_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "load", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_load_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_load_Lorg_json_JSONObject_, new JValue (p0));
		}

	}
}
