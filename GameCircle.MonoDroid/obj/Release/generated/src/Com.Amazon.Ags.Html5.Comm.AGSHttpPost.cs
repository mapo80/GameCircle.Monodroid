using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPost']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/AGSHttpPost", DoNotGenerateAcw=true)]
	public partial class AGSHttpPost : global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/AGSHttpPost", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSHttpPost); }
		}

		protected AGSHttpPost (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPost']/constructor[@name='AGSHttpPost' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public AGSHttpPost (string p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AGSHttpPost)) {
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

		static Delegate cb_prepareHttpRequestBase;
#pragma warning disable 0169
		static Delegate GetPrepareHttpRequestBaseHandler ()
		{
			if (cb_prepareHttpRequestBase == null)
				cb_prepareHttpRequestBase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PrepareHttpRequestBase);
			return cb_prepareHttpRequestBase;
		}

		static IntPtr n_PrepareHttpRequestBase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Comm.AGSHttpPost __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.AGSHttpPost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepareHttpRequestBase ());
		}
#pragma warning restore 0169

		static IntPtr id_prepareHttpRequestBase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='AGSHttpPost']/method[@name='prepareHttpRequestBase' and count(parameter)=0]"
		[Register ("prepareHttpRequestBase", "()Lorg/apache/http/client/methods/HttpRequestBase;", "GetPrepareHttpRequestBaseHandler")]
		public virtual global::Org.Apache.Http.Client.Methods.HttpRequestBase PrepareHttpRequestBase ()
		{
			if (id_prepareHttpRequestBase == IntPtr.Zero)
				id_prepareHttpRequestBase = JNIEnv.GetMethodID (class_ref, "prepareHttpRequestBase", "()Lorg/apache/http/client/methods/HttpRequestBase;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallObjectMethod  (Handle, id_prepareHttpRequestBase), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpRequestBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_prepareHttpRequestBase), JniHandleOwnership.TransferLocalRef);
		}

	}
}
