using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsCredentials']"
	[global::Android.Runtime.Register ("com/amazon/insights/impl/DefaultInsightsCredentials", DoNotGenerateAcw=true)]
	public partial class DefaultInsightsCredentials : global::Java.Lang.Object, global::Com.Amazon.Insights.IInsightsCredentials {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/impl/DefaultInsightsCredentials", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInsightsCredentials); }
		}

		protected DefaultInsightsCredentials (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsCredentials']/constructor[@name='DefaultInsightsCredentials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public DefaultInsightsCredentials (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (DefaultInsightsCredentials)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Impl.DefaultInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Impl.DefaultInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		public virtual string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsCredentials']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetPrivateKeyHandler ()
		{
			if (cb_getPrivateKey == null)
				cb_getPrivateKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivateKey);
			return cb_getPrivateKey;
		}

		static IntPtr n_GetPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Impl.DefaultInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Impl.DefaultInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrivateKey);
		}
#pragma warning restore 0169

		static IntPtr id_getPrivateKey;
		public virtual string PrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.impl']/class[@name='DefaultInsightsCredentials']/method[@name='getPrivateKey' and count(parameter)=0]"
			[Register ("getPrivateKey", "()Ljava/lang/String;", "GetGetPrivateKeyHandler")]
			get {
				if (id_getPrivateKey == IntPtr.Zero)
					id_getPrivateKey = JNIEnv.GetMethodID (class_ref, "getPrivateKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrivateKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPrivateKey), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
