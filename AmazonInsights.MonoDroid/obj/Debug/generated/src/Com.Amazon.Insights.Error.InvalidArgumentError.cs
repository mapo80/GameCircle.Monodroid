using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.error']/class[@name='InvalidArgumentError']"
	[global::Android.Runtime.Register ("com/amazon/insights/error/InvalidArgumentError", DoNotGenerateAcw=true)]
	public partial class InvalidArgumentError : global::Com.Amazon.Insights.Error.BaseInsightsError {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/error/InvalidArgumentError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InvalidArgumentError); }
		}

		protected InvalidArgumentError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.error']/class[@name='InvalidArgumentError']/constructor[@name='InvalidArgumentError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public InvalidArgumentError (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (InvalidArgumentError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Error.InvalidArgumentError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Error.InvalidArgumentError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public override string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.error']/class[@name='InvalidArgumentError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParameterName;
#pragma warning disable 0169
		static Delegate GetGetParameterNameHandler ()
		{
			if (cb_getParameterName == null)
				cb_getParameterName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameterName);
			return cb_getParameterName;
		}

		static IntPtr n_GetParameterName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Error.InvalidArgumentError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Error.InvalidArgumentError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParameterName);
		}
#pragma warning restore 0169

		static IntPtr id_getParameterName;
		public virtual string ParameterName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.error']/class[@name='InvalidArgumentError']/method[@name='getParameterName' and count(parameter)=0]"
			[Register ("getParameterName", "()Ljava/lang/String;", "GetGetParameterNameHandler")]
			get {
				if (id_getParameterName == IntPtr.Zero)
					id_getParameterName = JNIEnv.GetMethodID (class_ref, "getParameterName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParameterName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getParameterName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
