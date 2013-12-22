using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Migration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='ZipUtil']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/migration/ZipUtil", DoNotGenerateAcw=true)]
	public partial class ZipUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/migration/ZipUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZipUtil); }
		}

		protected ZipUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='ZipUtil']/constructor[@name='ZipUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ZipUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZipUtil)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_unzip_arrayBLjava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='ZipUtil']/method[@name='unzip' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("unzip", "([BLjava/io/File;)V", "")]
		public void Unzip (byte[] p0, global::Java.IO.File p1)
		{
			if (id_unzip_arrayBLjava_io_File_ == IntPtr.Zero)
				id_unzip_arrayBLjava_io_File_ = JNIEnv.GetMethodID (class_ref, "unzip", "([BLjava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_unzip_arrayBLjava_io_File_, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_unzip_Ljava_io_InputStream_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.migration']/class[@name='ZipUtil']/method[@name='unzip' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.File']]"
		[Register ("unzip", "(Ljava/io/InputStream;Ljava/io/File;)V", "")]
		public void Unzip (global::System.IO.Stream p0, global::Java.IO.File p1)
		{
			if (id_unzip_Ljava_io_InputStream_Ljava_io_File_ == IntPtr.Zero)
				id_unzip_Ljava_io_InputStream_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "unzip", "(Ljava/io/InputStream;Ljava/io/File;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_unzip_Ljava_io_InputStream_Ljava_io_File_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
