using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Connectivity']"
	[Register ("com/amazon/insights/core/system/Connectivity", "", "com.amazon.insights.core.system.amazon.IConnectivityInvoker")]
	public partial interface IConnectivity : IJavaObject {

		bool HasWAN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Connectivity']/method[@name='hasWAN' and count(parameter)=0]"
			[Register ("hasWAN", "()Z", "GetHasWANHandler:com.amazon.insights.core.system.amazon.IConnectivityInvoker, AmazonInsights.MonoDroid")] get;
		}

		bool HasWifi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Connectivity']/method[@name='hasWifi' and count(parameter)=0]"
			[Register ("hasWifi", "()Z", "GetHasWifiHandler:com.amazon.insights.core.system.amazon.IConnectivityInvoker, AmazonInsights.MonoDroid")] get;
		}

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Connectivity']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:com.amazon.insights.core.system.amazon.IConnectivityInvoker, AmazonInsights.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/system/Connectivity", DoNotGenerateAcw=true)]
	internal class IConnectivityInvoker : global::Java.Lang.Object, IConnectivity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/system/Connectivity");
		IntPtr class_ref;

		public static IConnectivity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectivity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.system.Connectivity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IConnectivityInvoker); }
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
			global::com.amazon.insights.core.system.amazon.IConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWAN;
		}
#pragma warning restore 0169

		IntPtr id_hasWAN;
		public bool HasWAN {
			get {
				if (id_hasWAN == IntPtr.Zero)
					id_hasWAN = JNIEnv.GetMethodID (class_ref, "hasWAN", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasWAN);
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
			global::com.amazon.insights.core.system.amazon.IConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasWifi;
		}
#pragma warning restore 0169

		IntPtr id_hasWifi;
		public bool HasWifi {
			get {
				if (id_hasWifi == IntPtr.Zero)
					id_hasWifi = JNIEnv.GetMethodID (class_ref, "hasWifi", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasWifi);
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
			global::com.amazon.insights.core.system.amazon.IConnectivity __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IConnectivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isConnected);
			}
		}

	}

}
