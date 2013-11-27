using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPut']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/AGSHttpPut", DoNotGenerateAcw=true)]
	public partial class AGSHttpPut : global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/AGSHttpPut", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSHttpPut); }
		}

		protected AGSHttpPut (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPut']/constructor[@name='AGSHttpPut' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public AGSHttpPut (string p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AGSHttpPut)) {
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

		static Delegate cb_setRequestBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestBody_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestBody_Ljava_lang_String_ == null)
				cb_setRequestBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestBody_Ljava_lang_String_);
			return cb_setRequestBody_Ljava_lang_String_;
		}

		static void n_SetRequestBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Comm.AGSHttpPut __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.AGSHttpPut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestBody (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPut']/method[@name='setRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestBody", "(Ljava/lang/String;)V", "GetSetRequestBody_Ljava_lang_String_Handler")]
		public virtual void SetRequestBody (string p0)
		{
			if (id_setRequestBody_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestBody_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestBody", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRequestBody_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRequestBody_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
