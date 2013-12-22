using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='DecryptionException']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/io/DecryptionException", DoNotGenerateAcw=true)]
	public partial class DecryptionException : global::Java.IO.IOException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/io/DecryptionException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecryptionException); }
		}

		protected DecryptionException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='DecryptionException']/constructor[@name='DecryptionException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public DecryptionException (global::Java.Lang.Exception p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DecryptionException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Exception;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Exception;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Exception_, new JValue (p0));
		}

	}
}
