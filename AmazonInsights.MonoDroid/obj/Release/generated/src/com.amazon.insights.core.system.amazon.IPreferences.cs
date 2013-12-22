using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']"
	[Register ("com/amazon/insights/core/system/Preferences", "", "com.amazon.insights.core.system.amazon.IPreferencesInvoker")]
	public partial interface IPreferences : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		bool GetBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloat", "(Ljava/lang/String;F)F", "GetGetFloat_Ljava_lang_String_FHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		float GetFloat (string p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		int GetInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_JHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		long GetLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		string GetString (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)V", "GetPutBoolean_Ljava_lang_String_ZHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		void PutBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='putFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("putFloat", "(Ljava/lang/String;F)V", "GetPutFloat_Ljava_lang_String_FHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		void PutFloat (string p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putInt", "(Ljava/lang/String;I)V", "GetPutInt_Ljava_lang_String_IHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		void PutInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)V", "GetPutLong_Ljava_lang_String_JHandler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		void PutLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='Preferences']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler:com.amazon.insights.core.system.amazon.IPreferencesInvoker, AmazonInsights.MonoDroid")]
		void PutString (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/system/Preferences", DoNotGenerateAcw=true)]
	internal class IPreferencesInvoker : global::Java.Lang.Object, IPreferences {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/system/Preferences");
		IntPtr class_ref;

		public static IPreferences GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPreferences> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.system.Preferences"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPreferencesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPreferencesInvoker); }
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_Z;
		public bool GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_getBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_getFloat_Ljava_lang_String_F == null)
				cb_getFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float>) n_GetFloat_Ljava_lang_String_F);
			return cb_getFloat_Ljava_lang_String_F;
		}

		static float n_GetFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFloat_Ljava_lang_String_F;
		public float GetFloat (string p0, float p1)
		{
			if (id_getFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_getFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;F)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			float __ret = JNIEnv.CallFloatMethod (Handle, id_getFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_I;
		public int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_GetLong_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_J;
		public long GetLong (string p0, long p1)
		{
			if (id_getLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallLongMethod (Handle, id_getLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
		public string GetString (string p0, string p1)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static void n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putBoolean_Ljava_lang_String_Z;
		public void PutBoolean (string p0, bool p1)
		{
			if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_putBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetPutFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_putFloat_Ljava_lang_String_F == null)
				cb_putFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_PutFloat_Ljava_lang_String_F);
			return cb_putFloat_Ljava_lang_String_F;
		}

		static void n_PutFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutFloat (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putFloat_Ljava_lang_String_F;
		public void PutFloat (string p0, float p1)
		{
			if (id_putFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_putFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "putFloat", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_putFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_IHandler ()
		{
			if (cb_putInt_Ljava_lang_String_I == null)
				cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PutInt_Ljava_lang_String_I);
			return cb_putInt_Ljava_lang_String_I;
		}

		static void n_PutInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putInt_Ljava_lang_String_I;
		public void PutInt (string p0, int p1)
		{
			if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_putInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static void n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putLong_Ljava_lang_String_J;
		public void PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_putLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::com.amazon.insights.core.system.amazon.IPreferences __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		public void PutString (string p0, string p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
