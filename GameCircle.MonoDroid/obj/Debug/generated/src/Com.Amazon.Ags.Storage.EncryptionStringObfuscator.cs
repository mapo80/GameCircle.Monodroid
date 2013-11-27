using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='EncryptionStringObfuscator']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/EncryptionStringObfuscator", DoNotGenerateAcw=true)]
	public partial class EncryptionStringObfuscator : global::Java.Lang.Object, global::Com.Amazon.Ags.Storage.IStringObfuscator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/EncryptionStringObfuscator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncryptionStringObfuscator); }
		}

		protected EncryptionStringObfuscator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='EncryptionStringObfuscator']/constructor[@name='EncryptionStringObfuscator' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public EncryptionStringObfuscator (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (EncryptionStringObfuscator)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_obfuscate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObfuscate_Ljava_lang_String_Handler ()
		{
			if (cb_obfuscate_Ljava_lang_String_ == null)
				cb_obfuscate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Obfuscate_Ljava_lang_String_);
			return cb_obfuscate_Ljava_lang_String_;
		}

		static IntPtr n_Obfuscate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.EncryptionStringObfuscator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.EncryptionStringObfuscator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Obfuscate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_obfuscate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='EncryptionStringObfuscator']/method[@name='obfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("obfuscate", "(Ljava/lang/String;)Ljava/lang/String;", "GetObfuscate_Ljava_lang_String_Handler")]
		public virtual string Obfuscate (string p0)
		{
			if (id_obfuscate_Ljava_lang_String_ == IntPtr.Zero)
				id_obfuscate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "obfuscate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_obfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_obfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_unobfuscate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnobfuscate_Ljava_lang_String_Handler ()
		{
			if (cb_unobfuscate_Ljava_lang_String_ == null)
				cb_unobfuscate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unobfuscate_Ljava_lang_String_);
			return cb_unobfuscate_Ljava_lang_String_;
		}

		static IntPtr n_Unobfuscate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Storage.EncryptionStringObfuscator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.EncryptionStringObfuscator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Unobfuscate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unobfuscate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='EncryptionStringObfuscator']/method[@name='unobfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unobfuscate", "(Ljava/lang/String;)Ljava/lang/String;", "GetUnobfuscate_Ljava_lang_String_Handler")]
		public virtual string Unobfuscate (string p0)
		{
			if (id_unobfuscate_Ljava_lang_String_ == IntPtr.Zero)
				id_unobfuscate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unobfuscate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_unobfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_unobfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
