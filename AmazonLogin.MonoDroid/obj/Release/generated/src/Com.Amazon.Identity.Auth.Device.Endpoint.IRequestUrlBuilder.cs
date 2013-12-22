using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='RequestUrlBuilder']"
	[Register ("com/amazon/identity/auth/device/endpoint/RequestUrlBuilder", "", "Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilderInvoker")]
	public partial interface IRequestUrlBuilder : IJavaObject {

		string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='RequestUrlBuilder']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilderInvoker, AmazonLogin.MonoDroid")] get;
		}

		int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='RequestUrlBuilder']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilderInvoker, AmazonLogin.MonoDroid")] get;
		}

		string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='RequestUrlBuilder']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler:Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilderInvoker, AmazonLogin.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/RequestUrlBuilder", DoNotGenerateAcw=true)]
	internal class IRequestUrlBuilderInvoker : global::Java.Lang.Object, IRequestUrlBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/RequestUrlBuilder");
		IntPtr class_ref;

		public static IRequestUrlBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestUrlBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.endpoint.RequestUrlBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestUrlBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRequestUrlBuilderInvoker); }
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		IntPtr id_getDomain;
		public string Domain {
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		IntPtr id_getPort;
		public int Port {
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPort);
			}
		}

		static Delegate cb_getRequestUrl;
#pragma warning disable 0169
		static Delegate GetGetRequestUrlHandler ()
		{
			if (cb_getRequestUrl == null)
				cb_getRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrl);
			return cb_getRequestUrl;
		}

		static IntPtr n_GetRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.IRequestUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUrl);
		}
#pragma warning restore 0169

		IntPtr id_getRequestUrl;
		public string RequestUrl {
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
