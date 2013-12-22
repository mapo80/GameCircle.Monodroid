using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/system/DefaultFileManager", DoNotGenerateAcw=true)]
	public partial class DefaultFileManager : global::Java.Lang.Object, global::com.amazon.insights.core.system.amazon.IFileManager {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/system/DefaultFileManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultFileManager); }
		}

		protected DefaultFileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/constructor[@name='DefaultFileManager' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public DefaultFileManager (global::Java.IO.File p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultFileManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
				id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_, new JValue (p0));
		}

		static Delegate cb_createDirectory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateDirectory_Ljava_lang_String_Handler ()
		{
			if (cb_createDirectory_Ljava_lang_String_ == null)
				cb_createDirectory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDirectory_Ljava_lang_String_);
			return cb_createDirectory_Ljava_lang_String_;
		}

		static IntPtr n_CreateDirectory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDirectory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createDirectory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='createDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createDirectory", "(Ljava/lang/String;)Ljava/io/File;", "GetCreateDirectory_Ljava_lang_String_Handler")]
		public virtual global::Java.IO.File CreateDirectory (string p0)
		{
			if (id_createDirectory_Ljava_lang_String_ == IntPtr.Zero)
				id_createDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.IO.File __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_createDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_createFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCreateFile_Ljava_io_File_Handler ()
		{
			if (cb_createFile_Ljava_io_File_ == null)
				cb_createFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateFile_Ljava_io_File_);
			return cb_createFile_Ljava_io_File_;
		}

		static IntPtr n_CreateFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='createFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createFile", "(Ljava/io/File;)Ljava/io/File;", "GetCreateFile_Ljava_io_File_Handler")]
		public virtual global::Java.IO.File CreateFile (global::Java.IO.File p0)
		{
			if (id_createFile_Ljava_io_File_ == IntPtr.Zero)
				id_createFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "createFile", "(Ljava/io/File;)Ljava/io/File;");

			global::Java.IO.File __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_createFile_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createFile_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateFile_Ljava_lang_String_Handler ()
		{
			if (cb_createFile_Ljava_lang_String_ == null)
				cb_createFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateFile_Ljava_lang_String_);
			return cb_createFile_Ljava_lang_String_;
		}

		static IntPtr n_CreateFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='createFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createFile", "(Ljava/lang/String;)Ljava/io/File;", "GetCreateFile_Ljava_lang_String_Handler")]
		public virtual global::Java.IO.File CreateFile (string p0)
		{
			if (id_createFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createFile", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.IO.File __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_createFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_deleteFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_io_File_Handler ()
		{
			if (cb_deleteFile_Ljava_io_File_ == null)
				cb_deleteFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFile_Ljava_io_File_);
			return cb_deleteFile_Ljava_io_File_;
		}

		static bool n_DeleteFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFile", "(Ljava/io/File;)Z", "GetDeleteFile_Ljava_io_File_Handler")]
		public virtual bool DeleteFile (global::Java.IO.File p0)
		{
			if (id_deleteFile_Ljava_io_File_ == IntPtr.Zero)
				id_deleteFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "deleteFile", "(Ljava/io/File;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_deleteFile_Ljava_io_File_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_deleteFile_Ljava_io_File_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_deleteFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_ == null)
				cb_deleteFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFile_Ljava_lang_String_);
			return cb_deleteFile_Ljava_lang_String_;
		}

		static bool n_DeleteFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public virtual bool DeleteFile (string p0)
		{
			if (id_deleteFile_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteFile", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_deleteFile_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_deleteFile_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDirectory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDirectory_Ljava_lang_String_Handler ()
		{
			if (cb_getDirectory_Ljava_lang_String_ == null)
				cb_getDirectory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDirectory_Ljava_lang_String_);
			return cb_getDirectory_Ljava_lang_String_;
		}

		static IntPtr n_GetDirectory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDirectory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDirectory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='getDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDirectory", "(Ljava/lang/String;)Ljava/io/File;", "GetGetDirectory_Ljava_lang_String_Handler")]
		public virtual global::Java.IO.File GetDirectory (string p0)
		{
			if (id_getDirectory_Ljava_lang_String_ == IntPtr.Zero)
				id_getDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.IO.File __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_listFilesInDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetListFilesInDirectory_Ljava_io_File_Handler ()
		{
			if (cb_listFilesInDirectory_Ljava_io_File_ == null)
				cb_listFilesInDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListFilesInDirectory_Ljava_io_File_);
			return cb_listFilesInDirectory_Ljava_io_File_;
		}

		static IntPtr n_ListFilesInDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.ToLocalJniHandle (__this.ListFilesInDirectory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listFilesInDirectory_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='listFilesInDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("listFilesInDirectory", "(Ljava/io/File;)Ljava/util/Set;", "GetListFilesInDirectory_Ljava_io_File_Handler")]
		public virtual global::System.Collections.Generic.ICollection<global::Java.IO.File> ListFilesInDirectory (global::Java.IO.File p0)
		{
			if (id_listFilesInDirectory_Ljava_io_File_ == IntPtr.Zero)
				id_listFilesInDirectory_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "listFilesInDirectory", "(Ljava/io/File;)Ljava/util/Set;");

			global::System.Collections.Generic.ICollection<global::Java.IO.File> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_listFilesInDirectory_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_listFilesInDirectory_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_listFilesInDirectory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetListFilesInDirectory_Ljava_lang_String_Handler ()
		{
			if (cb_listFilesInDirectory_Ljava_lang_String_ == null)
				cb_listFilesInDirectory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListFilesInDirectory_Ljava_lang_String_);
			return cb_listFilesInDirectory_Ljava_lang_String_;
		}

		static IntPtr n_ListFilesInDirectory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.ToLocalJniHandle (__this.ListFilesInDirectory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listFilesInDirectory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='listFilesInDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("listFilesInDirectory", "(Ljava/lang/String;)Ljava/util/Set;", "GetListFilesInDirectory_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.Generic.ICollection<global::Java.IO.File> ListFilesInDirectory (string p0)
		{
			if (id_listFilesInDirectory_Ljava_lang_String_ == IntPtr.Zero)
				id_listFilesInDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "listFilesInDirectory", "(Ljava/lang/String;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.Generic.ICollection<global::Java.IO.File> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_listFilesInDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaSet<global::Java.IO.File>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_listFilesInDirectory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_newInputStream_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetNewInputStream_Ljava_io_File_Handler ()
		{
			if (cb_newInputStream_Ljava_io_File_ == null)
				cb_newInputStream_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewInputStream_Ljava_io_File_);
			return cb_newInputStream_Ljava_io_File_;
		}

		static IntPtr n_NewInputStream_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.NewInputStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newInputStream_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='newInputStream' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("newInputStream", "(Ljava/io/File;)Ljava/io/InputStream;", "GetNewInputStream_Ljava_io_File_Handler")]
		public virtual global::System.IO.Stream NewInputStream (global::Java.IO.File p0)
		{
			if (id_newInputStream_Ljava_io_File_ == IntPtr.Zero)
				id_newInputStream_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "newInputStream", "(Ljava/io/File;)Ljava/io/InputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newInputStream_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newInputStream_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newInputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewInputStream_Ljava_lang_String_Handler ()
		{
			if (cb_newInputStream_Ljava_lang_String_ == null)
				cb_newInputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewInputStream_Ljava_lang_String_);
			return cb_newInputStream_Ljava_lang_String_;
		}

		static IntPtr n_NewInputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.NewInputStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newInputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='newInputStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newInputStream", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetNewInputStream_Ljava_lang_String_Handler")]
		public virtual global::System.IO.Stream NewInputStream (string p0)
		{
			if (id_newInputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_newInputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newInputStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newInputStream_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newInputStream_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_newOutputStream_Ljava_io_File_Z;
#pragma warning disable 0169
		static Delegate GetNewOutputStream_Ljava_io_File_ZHandler ()
		{
			if (cb_newOutputStream_Ljava_io_File_Z == null)
				cb_newOutputStream_Ljava_io_File_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_NewOutputStream_Ljava_io_File_Z);
			return cb_newOutputStream_Ljava_io_File_Z;
		}

		static IntPtr n_NewOutputStream_Ljava_io_File_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.NewOutputStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newOutputStream_Ljava_io_File_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='newOutputStream' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("newOutputStream", "(Ljava/io/File;Z)Ljava/io/OutputStream;", "GetNewOutputStream_Ljava_io_File_ZHandler")]
		public virtual global::System.IO.Stream NewOutputStream (global::Java.IO.File p0, bool p1)
		{
			if (id_newOutputStream_Ljava_io_File_Z == IntPtr.Zero)
				id_newOutputStream_Ljava_io_File_Z = JNIEnv.GetMethodID (class_ref, "newOutputStream", "(Ljava/io/File;Z)Ljava/io/OutputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newOutputStream_Ljava_io_File_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newOutputStream_Ljava_io_File_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newOutputStream_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetNewOutputStream_Ljava_lang_String_ZHandler ()
		{
			if (cb_newOutputStream_Ljava_lang_String_Z == null)
				cb_newOutputStream_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_NewOutputStream_Ljava_lang_String_Z);
			return cb_newOutputStream_Ljava_lang_String_Z;
		}

		static IntPtr n_NewOutputStream_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::com.amazon.insights.core.system.amazon.DefaultFileManager __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.DefaultFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.NewOutputStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newOutputStream_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='DefaultFileManager']/method[@name='newOutputStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("newOutputStream", "(Ljava/lang/String;Z)Ljava/io/OutputStream;", "GetNewOutputStream_Ljava_lang_String_ZHandler")]
		public virtual global::System.IO.Stream NewOutputStream (string p0, bool p1)
		{
			if (id_newOutputStream_Ljava_lang_String_Z == IntPtr.Zero)
				id_newOutputStream_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "newOutputStream", "(Ljava/lang/String;Z)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newOutputStream_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newOutputStream_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
