using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/ServiceRequestBase", DoNotGenerateAcw=true)]
	public abstract partial class ServiceRequestBase : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/ServiceRequestBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceRequestBase); }
		}

		protected ServiceRequestBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/constructor[@name='ServiceRequestBase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public ServiceRequestBase (string p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ServiceRequestBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEndpointHandler ()
		{
			if (cb_getEndpoint == null)
				cb_getEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoint);
			return cb_getEndpoint;
		}

		static IntPtr n_GetEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Endpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndpoint;
		public virtual string Endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='getEndpoint' and count(parameter)=0]"
			[Register ("getEndpoint", "()Ljava/lang/String;", "GetGetEndpointHandler")]
			get {
				if (id_getEndpoint == IntPtr.Zero)
					id_getEndpoint = JNIEnv.GetMethodID (class_ref, "getEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEndpoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeaderParams;
		public global::System.Collections.Generic.IDictionary<string, string> HeaderParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='getHeaderParams' and count(parameter)=0]"
			[Register ("getHeaderParams", "()Ljava/util/Map;", "GetGetHeaderParamsHandler")]
			get {
				if (id_getHeaderParams == IntPtr.Zero)
					id_getHeaderParams = JNIEnv.GetMethodID (class_ref, "getHeaderParams", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaderParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isAuthenticationRequired;
		public bool IsAuthenticationRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='isAuthenticationRequired' and count(parameter)=0]"
			[Register ("isAuthenticationRequired", "()Z", "GetIsAuthenticationRequiredHandler")]
			get {
				if (id_isAuthenticationRequired == IntPtr.Zero)
					id_isAuthenticationRequired = JNIEnv.GetMethodID (class_ref, "isAuthenticationRequired", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAuthenticationRequired);
			}
		}

		static IntPtr id_getUrlParams;
		public global::System.Collections.Generic.IDictionary<string, string> UrlParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='getUrlParams' and count(parameter)=0]"
			[Register ("getUrlParams", "()Ljava/util/Map;", "GetGetUrlParamsHandler")]
			get {
				if (id_getUrlParams == IntPtr.Zero)
					id_getUrlParams = JNIEnv.GetMethodID (class_ref, "getUrlParams", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUrlParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_constructUri;
#pragma warning disable 0169
		static Delegate GetConstructUriHandler ()
		{
			if (cb_constructUri == null)
				cb_constructUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConstructUri);
			return cb_constructUri;
		}

		static IntPtr n_ConstructUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConstructUri ());
		}
#pragma warning restore 0169

		static IntPtr id_constructUri;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='constructUri' and count(parameter)=0]"
		[Register ("constructUri", "()Ljava/lang/String;", "GetConstructUriHandler")]
		public virtual string ConstructUri ()
		{
			if (id_constructUri == IntPtr.Zero)
				id_constructUri = JNIEnv.GetMethodID (class_ref, "constructUri", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_constructUri), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_constructUri), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_putHeaderParameter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='putHeaderParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putHeaderParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void PutHeaderParameter (string p0, string p1)
		{
			if (id_putHeaderParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putHeaderParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putHeaderParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_putHeaderParameter_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_putUrlParameter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='ServiceRequestBase']/method[@name='putUrlParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putUrlParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void PutUrlParameter (string p0, string p1)
		{
			if (id_putUrlParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putUrlParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putUrlParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_putUrlParameter_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/ServiceRequestBase", DoNotGenerateAcw=true)]
	internal partial class ServiceRequestBaseInvoker : ServiceRequestBase {

		public ServiceRequestBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceRequestBaseInvoker); }
		}

	}

}
