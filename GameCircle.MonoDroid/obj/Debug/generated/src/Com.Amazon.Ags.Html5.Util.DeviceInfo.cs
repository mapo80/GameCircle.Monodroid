using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/DeviceInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceInfo); }
		}

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_KindleFireProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.KindleFireProxy']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/KindleFireProxy;)V", "")]
		public DeviceInfo (global::Com.Amazon.Ags.Client.IKindleFireProxy p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceInfo)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/KindleFireProxy;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/KindleFireProxy;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_KindleFireProxy_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_KindleFireProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/KindleFireProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_KindleFireProxy_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_KindleFireProxy_, new JValue (p0));
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.DeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceType;
		public virtual string DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/String;", "GetGetDeviceTypeHandler")]
			get {
				if (id_getDeviceType == IntPtr.Zero)
					id_getDeviceType = JNIEnv.GetMethodID (class_ref, "getDeviceType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIdentifier;
		public static string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetStaticMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getManufacturer;
		public static string Manufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']/method[@name='getManufacturer' and count(parameter)=0]"
			[Register ("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
			get {
				if (id_getManufacturer == IntPtr.Zero)
					id_getManufacturer = JNIEnv.GetStaticMethodID (class_ref, "getManufacturer", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getManufacturer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getModel;
		public static string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='DeviceInfo']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetStaticMethodID (class_ref, "getModel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getModel), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
