using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='WhispersyncEnabledResponse']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/session/WhispersyncEnabledResponse", DoNotGenerateAcw=true)]
	public partial class WhispersyncEnabledResponse : global::Com.Amazon.Ags.Client.RequestResponseImpl {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/session/WhispersyncEnabledResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncEnabledResponse); }
		}

		protected WhispersyncEnabledResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='WhispersyncEnabledResponse']/constructor[@name='WhispersyncEnabledResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public WhispersyncEnabledResponse (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncEnabledResponse)) {
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

		static IntPtr id_ctor_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='WhispersyncEnabledResponse']/constructor[@name='WhispersyncEnabledResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(IZ)V", "")]
		public WhispersyncEnabledResponse (int p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncEnabledResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IZ)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IZ)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_IZ == IntPtr.Zero)
				id_ctor_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IZ, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IZ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isWhispersyncEnabled;
#pragma warning disable 0169
		static Delegate GetIsWhispersyncEnabledHandler ()
		{
			if (cb_isWhispersyncEnabled == null)
				cb_isWhispersyncEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWhispersyncEnabled);
			return cb_isWhispersyncEnabled;
		}

		static bool n_IsWhispersyncEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.WhispersyncEnabledResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.WhispersyncEnabledResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWhispersyncEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isWhispersyncEnabled;
		public virtual bool IsWhispersyncEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='WhispersyncEnabledResponse']/method[@name='isWhispersyncEnabled' and count(parameter)=0]"
			[Register ("isWhispersyncEnabled", "()Z", "GetIsWhispersyncEnabledHandler")]
			get {
				if (id_isWhispersyncEnabled == IntPtr.Zero)
					id_isWhispersyncEnabled = JNIEnv.GetMethodID (class_ref, "isWhispersyncEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isWhispersyncEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isWhispersyncEnabled);
			}
		}

	}
}
