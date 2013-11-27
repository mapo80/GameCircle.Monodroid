using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedWriter']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/io/EncryptedWriter", DoNotGenerateAcw=true)]
	public partial class EncryptedWriter : global::Java.IO.Writer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/io/EncryptedWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncryptedWriter); }
		}

		protected EncryptedWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_Writer_Ljavax_crypto_SecretKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedWriter']/constructor[@name='EncryptedWriter' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='javax.crypto.SecretKey']]"
		[Register (".ctor", "(Ljava/io/Writer;Ljavax/crypto/SecretKey;)V", "")]
		public EncryptedWriter (global::Java.IO.Writer p0, global::Javax.Crypto.ISecretKey p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (EncryptedWriter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/Writer;Ljavax/crypto/SecretKey;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/Writer;Ljavax/crypto/SecretKey;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_io_Writer_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
				id_ctor_Ljava_io_Writer_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/Writer;Ljavax/crypto/SecretKey;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_Writer_Ljavax_crypto_SecretKey_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_Writer_Ljavax_crypto_SecretKey_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.IO.EncryptedWriter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IO.EncryptedWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_close);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Core.IO.EncryptedWriter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IO.EncryptedWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public override void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_flush);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_flush);
		}

		static Delegate cb_write_arrayCII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayCIIHandler ()
		{
			if (cb_write_arrayCII == null)
				cb_write_arrayCII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Write_arrayCII);
			return cb_write_arrayCII;
		}

		static void n_Write_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Amazon.Insights.Core.IO.EncryptedWriter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.IO.EncryptedWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] p0 = (char[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.Write (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.io']/class[@name='EncryptedWriter']/method[@name='write' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([CII)V", "GetWrite_arrayCIIHandler")]
		public override void Write (char[] p0, int p1, int p2)
		{
			if (id_write_arrayCII == IntPtr.Zero)
				id_write_arrayCII = JNIEnv.GetMethodID (class_ref, "write", "([CII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_write_arrayCII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_write_arrayCII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
