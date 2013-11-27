using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEvent']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/session/SessionEvent", DoNotGenerateAcw=true)]
	public partial class SessionEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/session/SessionEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionEvent); }
		}

		protected SessionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEvent']/constructor[@name='SessionEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public SessionEvent (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (SessionEvent)) {
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

		static Delegate cb_getActionCode;
#pragma warning disable 0169
		static Delegate GetGetActionCodeHandler ()
		{
			if (cb_getActionCode == null)
				cb_getActionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionCode);
			return cb_getActionCode;
		}

		static IntPtr n_GetActionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.SessionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActionCode);
		}
#pragma warning restore 0169

		static IntPtr id_getActionCode;
		public virtual string ActionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEvent']/method[@name='getActionCode' and count(parameter)=0]"
			[Register ("getActionCode", "()Ljava/lang/String;", "GetGetActionCodeHandler")]
			get {
				if (id_getActionCode == IntPtr.Zero)
					id_getActionCode = JNIEnv.GetMethodID (class_ref, "getActionCode", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getActionCode), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getActionCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Session.SessionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Session.SessionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.session']/class[@name='SessionEvent']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimestamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getTimestamp);
			}
		}

	}
}
