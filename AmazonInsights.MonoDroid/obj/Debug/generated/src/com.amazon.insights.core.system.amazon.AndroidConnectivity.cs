using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/system/AndroidConnectivity", DoNotGenerateAcw=true)]
	public partial class AndroidConnectivity : global::Java.Lang.Object, global::com.amazon.insights.core.system.amazon.IConnectivity {


		static IntPtr hasMobile_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/field[@name='hasMobile']"
		[Register ("hasMobile")]
		protected bool HasMobile {
			get {
				if (hasMobile_jfieldId == IntPtr.Zero)
					hasMobile_jfieldId = JNIEnv.GetFieldID (class_ref, "hasMobile", "Z");
				return JNIEnv.GetBooleanField (Handle, hasMobile_jfieldId);
			}
			set {
				if (hasMobile_jfieldId == IntPtr.Zero)
					hasMobile_jfieldId = JNIEnv.GetFieldID (class_ref, "hasMobile", "Z");
				JNIEnv.SetField (Handle, hasMobile_jfieldId, value);
			}
		}

		static IntPtr inAirplaneMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/field[@name='inAirplaneMode']"
		[Register ("inAirplaneMode")]
		protected bool InAirplaneMode {
			get {
				if (inAirplaneMode_jfieldId == IntPtr.Zero)
					inAirplaneMode_jfieldId = JNIEnv.GetFieldID (class_ref, "inAirplaneMode", "Z");
				return JNIEnv.GetBooleanField (Handle, inAirplaneMode_jfieldId);
			}
			set {
				if (inAirplaneMode_jfieldId == IntPtr.Zero)
					inAirplaneMode_jfieldId = JNIEnv.GetFieldID (class_ref, "inAirplaneMode", "Z");
				JNIEnv.SetField (Handle, inAirplaneMode_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity.Network']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/system/AndroidConnectivity$Network", DoNotGenerateAcw=true)]
		public sealed partial class Network : global::Java.Lang.Enum {


			static IntPtr MOBILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity.Network']/field[@name='MOBILE']"
			[Register ("MOBILE")]
			public static global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network Mobile {
				get {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MOBILE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity.Network']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, WIFI_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/system/AndroidConnectivity$Network", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Network); }
			}

			internal Network (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity.Network']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/system/AndroidConnectivity$Network;", "")]
			public static global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network __ret = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity.Network']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/insights/core/system/AndroidConnectivity$Network;", "")]
			public static global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/insights/core/system/AndroidConnectivity$Network;");
				return (global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::com.amazon.insights.core.system.amazon.AndroidConnectivity.Network));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/system/AndroidConnectivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidConnectivity); }
		}

		protected AndroidConnectivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/constructor[@name='AndroidConnectivity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public AndroidConnectivity (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AndroidConnectivity)) {
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

		static Delegate cb_hasWAN;
#pragma warning disable 0169
		static Delegate GetHasWANHandler ()
		{
			if (cb_hasWAN == null)
				cb_hasWAN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasWAN);
			return cb_hasWAN;
		}

		static bool n_HasWAN (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWAN;
		}
#pragma warning restore 0169

		static IntPtr id_hasWAN;
		public virtual bool HasWAN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/method[@name='hasWAN' and count(parameter)=0]"
			[Register ("hasWAN", "()Z", "GetHasWANHandler")]
			get {
				if (id_hasWAN == IntPtr.Zero)
					id_hasWAN = JNIEnv.GetMethodID (class_ref, "hasWAN", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasWAN);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasWAN);
			}
		}

		static Delegate cb_hasWifi;
#pragma warning disable 0169
		static Delegate GetHasWifiHandler ()
		{
			if (cb_hasWifi == null)
				cb_hasWifi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasWifi);
			return cb_hasWifi;
		}

		static bool n_HasWifi (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWifi;
		}
#pragma warning restore 0169

		static IntPtr id_hasWifi;
		public virtual bool HasWifi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/method[@name='hasWifi' and count(parameter)=0]"
			[Register ("hasWifi", "()Z", "GetHasWifiHandler")]
			get {
				if (id_hasWifi == IntPtr.Zero)
					id_hasWifi = JNIEnv.GetMethodID (class_ref, "hasWifi", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasWifi);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasWifi);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidConnectivity']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnected);
			}
		}

	}
}
