using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToastFactory']"
	[Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastFactory", "", "Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactoryInvoker")]
	public partial interface IClickableToastFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToastFactory']/method[@name='getClickableWebViewToast' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClickableWebViewToast", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;", "GetGetClickableWebViewToast_Ljava_lang_String_Handler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactoryInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast GetClickableWebViewToast (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastFactory", DoNotGenerateAcw=true)]
	internal class IClickableToastFactoryInvoker : global::Java.Lang.Object, IClickableToastFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToastFactory");
		IntPtr class_ref;

		public static IClickableToastFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClickableToastFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.overlay.toasts.ClickableToastFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClickableToastFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IClickableToastFactoryInvoker); }
		}

		static Delegate cb_getClickableWebViewToast_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClickableWebViewToast_Ljava_lang_String_Handler ()
		{
			if (cb_getClickableWebViewToast_Ljava_lang_String_ == null)
				cb_getClickableWebViewToast_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClickableWebViewToast_Ljava_lang_String_);
			return cb_getClickableWebViewToast_Ljava_lang_String_;
		}

		static IntPtr n_GetClickableWebViewToast_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClickableWebViewToast (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getClickableWebViewToast_Ljava_lang_String_;
		public global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast GetClickableWebViewToast (string p0)
		{
			if (id_getClickableWebViewToast_Ljava_lang_String_ == IntPtr.Zero)
				id_getClickableWebViewToast_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getClickableWebViewToast", "(Ljava/lang/String;)Lcom/amazon/ags/html5/overlay/toasts/ClickableToast;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (JNIEnv.CallObjectMethod (Handle, id_getClickableWebViewToast_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
