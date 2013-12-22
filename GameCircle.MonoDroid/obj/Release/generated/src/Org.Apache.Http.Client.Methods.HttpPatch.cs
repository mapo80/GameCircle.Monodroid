using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Http.Client.Methods {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']"
	[global::Android.Runtime.Register ("org/apache/http/client/methods/HttpPatch", DoNotGenerateAcw=true)]
	public partial class HttpPatch : global::Org.Apache.Http.Client.Methods.HttpEntityEnclosingRequestBase {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']/field[@name='METHOD_NAME']"
		[Register ("METHOD_NAME")]
		public const string MethodName = (string) "PATCH";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/http/client/methods/HttpPatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpPatch); }
		}

		protected HttpPatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']/constructor[@name='HttpPatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HttpPatch () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpPatch)) {
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

		static IntPtr id_ctor_Ljava_net_URI_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']/constructor[@name='HttpPatch' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register (".ctor", "(Ljava/net/URI;)V", "")]
		public HttpPatch (global::Java.Net.URI p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpPatch)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URI;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URI;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_net_URI_ == IntPtr.Zero)
				id_ctor_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URI;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URI_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URI_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']/constructor[@name='HttpPatch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public HttpPatch (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (HttpPatch)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Http.Client.Methods.HttpPatch __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpPatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public override string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.http.client.methods']/class[@name='HttpPatch']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
