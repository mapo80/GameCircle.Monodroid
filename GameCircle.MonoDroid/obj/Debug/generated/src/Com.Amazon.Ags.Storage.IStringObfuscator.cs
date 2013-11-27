using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='StringObfuscator']"
	[Register ("com/amazon/ags/storage/StringObfuscator", "", "Com.Amazon.Ags.Storage.IStringObfuscatorInvoker")]
	public partial interface IStringObfuscator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='StringObfuscator']/method[@name='obfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("obfuscate", "(Ljava/lang/String;)Ljava/lang/String;", "GetObfuscate_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IStringObfuscatorInvoker, GameCircle.MonoDroid")]
		string Obfuscate (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/interface[@name='StringObfuscator']/method[@name='unobfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unobfuscate", "(Ljava/lang/String;)Ljava/lang/String;", "GetUnobfuscate_Ljava_lang_String_Handler:Com.Amazon.Ags.Storage.IStringObfuscatorInvoker, GameCircle.MonoDroid")]
		string Unobfuscate (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/storage/StringObfuscator", DoNotGenerateAcw=true)]
	internal class IStringObfuscatorInvoker : global::Java.Lang.Object, IStringObfuscator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/storage/StringObfuscator");
		IntPtr class_ref;

		public static IStringObfuscator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStringObfuscator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.storage.StringObfuscator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStringObfuscatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IStringObfuscatorInvoker); }
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
			global::Com.Amazon.Ags.Storage.IStringObfuscator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IStringObfuscator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Obfuscate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_obfuscate_Ljava_lang_String_;
		public string Obfuscate (string p0)
		{
			if (id_obfuscate_Ljava_lang_String_ == IntPtr.Zero)
				id_obfuscate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "obfuscate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_obfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Storage.IStringObfuscator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.IStringObfuscator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Unobfuscate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unobfuscate_Ljava_lang_String_;
		public string Unobfuscate (string p0)
		{
			if (id_unobfuscate_Ljava_lang_String_ == IntPtr.Zero)
				id_unobfuscate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unobfuscate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_unobfuscate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
