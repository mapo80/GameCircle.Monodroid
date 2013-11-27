using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/content/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/content/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_copyResourceContentIntoDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='copyResourceContentIntoDirectory' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("copyResourceContentIntoDirectory", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool CopyResourceContentIntoDirectory (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_copyResourceContentIntoDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_copyResourceContentIntoDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copyResourceContentIntoDirectory", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copyResourceContentIntoDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_deleteDirectory_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='deleteDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteDirectory", "(Ljava/io/File;)Z", "")]
		public static bool DeleteDirectory (global::Java.IO.File p0)
		{
			if (id_deleteDirectory_Ljava_io_File_ == IntPtr.Zero)
				id_deleteDirectory_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteDirectory", "(Ljava/io/File;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteDirectory_Ljava_io_File_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_downloadFile_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='downloadFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("downloadFile", "(Ljava/lang/String;Ljava/lang/String;J)Z", "")]
		public static bool DownloadFile (string p0, string p1, long p2)
		{
			if (id_downloadFile_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_downloadFile_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "downloadFile", "(Ljava/lang/String;Ljava/lang/String;J)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_downloadFile_Ljava_lang_String_Ljava_lang_String_J, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_ensureDirectoryExists_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='ensureDirectoryExists' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("ensureDirectoryExists", "(Ljava/io/File;)Z", "")]
		public static bool EnsureDirectoryExists (global::Java.IO.File p0)
		{
			if (id_ensureDirectoryExists_Ljava_io_File_ == IntPtr.Zero)
				id_ensureDirectoryExists_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "ensureDirectoryExists", "(Ljava/io/File;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_ensureDirectoryExists_Ljava_io_File_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_extractZipToDirectory_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='extractZipToDirectory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("extractZipToDirectory", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool ExtractZipToDirectory (string p0, string p1)
		{
			if (id_extractZipToDirectory_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_extractZipToDirectory_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extractZipToDirectory", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_extractZipToDirectory_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getDirectorySize_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='getDirectorySize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getDirectorySize", "(Ljava/io/File;)J", "")]
		public static long GetDirectorySize (global::Java.IO.File p0)
		{
			if (id_getDirectorySize_Ljava_io_File_ == IntPtr.Zero)
				id_getDirectorySize_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getDirectorySize", "(Ljava/io/File;)J");
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getDirectorySize_Ljava_io_File_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getMD5ChecksumForFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='getMD5ChecksumForFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMD5ChecksumForFile", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetMD5ChecksumForFile (string p0)
		{
			if (id_getMD5ChecksumForFile_Ljava_lang_String_ == IntPtr.Zero)
				id_getMD5ChecksumForFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMD5ChecksumForFile", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMD5ChecksumForFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_readFileBytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='readFileBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readFileBytes", "(Ljava/lang/String;)[B", "")]
		public static byte[] ReadFileBytes (string p0)
		{
			if (id_readFileBytes_Ljava_lang_String_ == IntPtr.Zero)
				id_readFileBytes_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readFileBytes", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFileBytes_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_renameDirectory_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='FileUtils']/method[@name='renameDirectory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("renameDirectory", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool RenameDirectory (string p0, string p1)
		{
			if (id_renameDirectory_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_renameDirectory_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "renameDirectory", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_renameDirectory_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
