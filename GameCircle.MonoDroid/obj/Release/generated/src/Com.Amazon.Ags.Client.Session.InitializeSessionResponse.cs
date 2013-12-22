using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='InitializeSessionResponse']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/session/InitializeSessionResponse", DoNotGenerateAcw=true)]
	public partial class InitializeSessionResponse : global::Com.Amazon.Ags.Client.RequestResponseImpl {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/session/InitializeSessionResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitializeSessionResponse); }
		}

		protected InitializeSessionResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='InitializeSessionResponse']/constructor[@name='InitializeSessionResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public InitializeSessionResponse (string p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (InitializeSessionResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='InitializeSessionResponse']/constructor[@name='InitializeSessionResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public InitializeSessionResponse (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InitializeSessionResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILcom_amazon_ags_api_ErrorCode_ == IntPtr.Zero)
				id_ctor_ILcom_amazon_ags_api_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/amazon/ags/api/ErrorCode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getAuthorizeResult;
#pragma warning disable 0169
		static Delegate GetGetAuthorizeResultHandler ()
		{
			if (cb_getAuthorizeResult == null)
				cb_getAuthorizeResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthorizeResult);
			return cb_getAuthorizeResult;
		}

		static IntPtr n_GetAuthorizeResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.InitializeSessionResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.InitializeSessionResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizeResult);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizeResult;
		public virtual string AuthorizeResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='InitializeSessionResponse']/method[@name='getAuthorizeResult' and count(parameter)=0]"
			[Register ("getAuthorizeResult", "()Ljava/lang/String;", "GetGetAuthorizeResultHandler")]
			get {
				if (id_getAuthorizeResult == IntPtr.Zero)
					id_getAuthorizeResult = JNIEnv.GetMethodID (class_ref, "getAuthorizeResult", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthorizeResult), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAuthorizeResult), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
