using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='TokenResponse']"
	[Register ("com/amazon/identity/auth/device/endpoint/TokenResponse", "", "Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponseInvoker")]
	public partial interface ITokenResponse : IJavaObject {

		int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='TokenResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler:Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponseInvoker, AmazonLogin.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/interface[@name='TokenResponse']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()V", "GetParseHandler:Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponseInvoker, AmazonLogin.MonoDroid")]
		void Parse ();

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/TokenResponse", DoNotGenerateAcw=true)]
	internal class ITokenResponseInvoker : global::Java.Lang.Object, ITokenResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/TokenResponse");
		IntPtr class_ref;

		public static ITokenResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.endpoint.TokenResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITokenResponseInvoker); }
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		IntPtr id_getStatusCode;
		public int StatusCode {
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getStatusCode);
			}
		}

		static Delegate cb_parse;
#pragma warning disable 0169
		static Delegate GetParseHandler ()
		{
			if (cb_parse == null)
				cb_parse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Parse);
			return cb_parse;
		}

		static void n_Parse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Endpoint.ITokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Parse ();
		}
#pragma warning restore 0169

		IntPtr id_parse;
		public void Parse ()
		{
			if (id_parse == IntPtr.Zero)
				id_parse = JNIEnv.GetMethodID (class_ref, "parse", "()V");
			JNIEnv.CallVoidMethod (Handle, id_parse);
		}

	}

}
