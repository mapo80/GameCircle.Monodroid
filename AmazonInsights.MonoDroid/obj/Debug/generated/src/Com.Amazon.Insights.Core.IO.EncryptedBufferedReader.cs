using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedBufferedReader']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/io/EncryptedBufferedReader", DoNotGenerateAcw=true)]
	public partial class EncryptedBufferedReader : global::Java.IO.BufferedReader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/io/EncryptedBufferedReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncryptedBufferedReader); }
		}

		protected EncryptedBufferedReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_BufferedReader_Ljavax_crypto_SecretKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedBufferedReader']/constructor[@name='EncryptedBufferedReader' and count(parameter)=2 and parameter[1][@type='java.io.BufferedReader'] and parameter[2][@type='javax.crypto.SecretKey']]"
		[Register (".ctor", "(Ljava/io/BufferedReader;Ljavax/crypto/SecretKey;)V", "")]
		public EncryptedBufferedReader (global::Java.IO.BufferedReader p0, global::Javax.Crypto.ISecretKey p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (EncryptedBufferedReader)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedReader;Ljavax/crypto/SecretKey;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/BufferedReader;Ljavax/crypto/SecretKey;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_io_BufferedReader_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
				id_ctor_Ljava_io_BufferedReader_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedReader;Ljavax/crypto/SecretKey;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedReader_Ljavax_crypto_SecretKey_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_BufferedReader_Ljavax_crypto_SecretKey_, new JValue (p0), new JValue (p1));
		}

	}
}
