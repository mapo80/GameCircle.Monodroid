using System;
using System.Collections.Generic;
using Android.Runtime;

namespace configurationImpl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']"
	[Register ("com/amazon/insights/core/configuration/Configuration", "", "configurationImpl.IConfigurationInvoker")]
	public partial interface IConfiguration : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", "GetGetBoolean_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Boolean GetBoolean (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)Ljava/lang/Double;", "GetGetDouble_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Double GetDouble (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetInt_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Integer GetInt (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", "GetGetLong_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Long GetLong (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getShort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getShort", "(Ljava/lang/String;)Ljava/lang/Short;", "GetGetShort_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Short GetShort (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		string GetString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("optBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "GetOptBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Boolean OptBoolean (string p0, global::Java.Lang.Boolean p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double']]"
		[Register ("optDouble", "(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;", "GetOptDouble_Ljava_lang_String_Ljava_lang_Double_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Double OptDouble (string p0, global::Java.Lang.Double p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("optInt", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;", "GetOptInt_Ljava_lang_String_Ljava_lang_Integer_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Integer OptInt (string p0, global::Java.Lang.Integer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("optLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;", "GetOptLong_Ljava_lang_String_Ljava_lang_Long_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Long OptLong (string p0, global::Java.Lang.Long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optShort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Short']]"
		[Register ("optShort", "(Ljava/lang/String;Ljava/lang/Short;)Ljava/lang/Short;", "GetOptShort_Ljava_lang_String_Ljava_lang_Short_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		global::Java.Lang.Short OptShort (string p0, global::Java.Lang.Short p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='optString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetOptString_Ljava_lang_String_Ljava_lang_String_Handler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		string OptString (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/interface[@name='Configuration']/method[@name='refresh' and count(parameter)=0]"
		[Register ("refresh", "()V", "GetRefreshHandler:configurationImpl.IConfigurationInvoker, AmazonInsights.MonoDroid")]
		void Refresh ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/configuration/Configuration", DoNotGenerateAcw=true)]
	internal class IConfigurationInvoker : global::Java.Lang.Object, IConfiguration {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/configuration/Configuration");
		IntPtr class_ref;

		public static IConfiguration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfiguration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.configuration.Configuration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IConfigurationInvoker); }
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static IntPtr n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBoolean (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_;
		public global::Java.Lang.Boolean GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_getBoolean_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDouble_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_Handler ()
		{
			if (cb_getDouble_Ljava_lang_String_ == null)
				cb_getDouble_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDouble_Ljava_lang_String_);
			return cb_getDouble_Ljava_lang_String_;
		}

		static IntPtr n_GetDouble_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDouble (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDouble_Ljava_lang_String_;
		public global::Java.Lang.Double GetDouble (string p0)
		{
			if (id_getDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Double __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (Handle, id_getDouble_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static IntPtr n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_;
		public global::Java.Lang.Integer GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (Handle, id_getInt_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static IntPtr n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLong (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_;
		public global::Java.Lang.Long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (Handle, id_getLong_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getShort_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetShort_Ljava_lang_String_Handler ()
		{
			if (cb_getShort_Ljava_lang_String_ == null)
				cb_getShort_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetShort_Ljava_lang_String_);
			return cb_getShort_Ljava_lang_String_;
		}

		static IntPtr n_GetShort_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetShort (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getShort_Ljava_lang_String_;
		public global::Java.Lang.Short GetShort (string p0)
		{
			if (id_getShort_Ljava_lang_String_ == IntPtr.Zero)
				id_getShort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getShort", "(Ljava/lang/String;)Ljava/lang/Short;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Short __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (Handle, id_getShort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_;
		public string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetOptBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptBoolean_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static IntPtr n_OptBoolean_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptBoolean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		public global::Java.Lang.Boolean OptBoolean (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "optBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optDouble_Ljava_lang_String_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetOptDouble_Ljava_lang_String_Ljava_lang_Double_Handler ()
		{
			if (cb_optDouble_Ljava_lang_String_Ljava_lang_Double_ == null)
				cb_optDouble_Ljava_lang_String_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptDouble_Ljava_lang_String_Ljava_lang_Double_);
			return cb_optDouble_Ljava_lang_String_Ljava_lang_Double_;
		}

		static IntPtr n_OptDouble_Ljava_lang_String_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptDouble (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optDouble_Ljava_lang_String_Ljava_lang_Double_;
		public global::Java.Lang.Double OptDouble (string p0, global::Java.Lang.Double p1)
		{
			if (id_optDouble_Ljava_lang_String_Ljava_lang_Double_ == IntPtr.Zero)
				id_optDouble_Ljava_lang_String_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "optDouble", "(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Double __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (Handle, id_optDouble_Ljava_lang_String_Ljava_lang_Double_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optInt_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetOptInt_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_optInt_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_optInt_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptInt_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_optInt_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static IntPtr n_OptInt_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptInt (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optInt_Ljava_lang_String_Ljava_lang_Integer_;
		public global::Java.Lang.Integer OptInt (string p0, global::Java.Lang.Integer p1)
		{
			if (id_optInt_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_optInt_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "optInt", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (Handle, id_optInt_Ljava_lang_String_Ljava_lang_Integer_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optLong_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetOptLong_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_optLong_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_optLong_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptLong_Ljava_lang_String_Ljava_lang_Long_);
			return cb_optLong_Ljava_lang_String_Ljava_lang_Long_;
		}

		static IntPtr n_OptLong_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptLong (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optLong_Ljava_lang_String_Ljava_lang_Long_;
		public global::Java.Lang.Long OptLong (string p0, global::Java.Lang.Long p1)
		{
			if (id_optLong_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_optLong_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "optLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (Handle, id_optLong_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optShort_Ljava_lang_String_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetOptShort_Ljava_lang_String_Ljava_lang_Short_Handler ()
		{
			if (cb_optShort_Ljava_lang_String_Ljava_lang_Short_ == null)
				cb_optShort_Ljava_lang_String_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptShort_Ljava_lang_String_Ljava_lang_Short_);
			return cb_optShort_Ljava_lang_String_Ljava_lang_Short_;
		}

		static IntPtr n_OptShort_Ljava_lang_String_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptShort (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optShort_Ljava_lang_String_Ljava_lang_Short_;
		public global::Java.Lang.Short OptShort (string p0, global::Java.Lang.Short p1)
		{
			if (id_optShort_Ljava_lang_String_Ljava_lang_Short_ == IntPtr.Zero)
				id_optShort_Ljava_lang_String_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "optShort", "(Ljava/lang/String;Ljava/lang/Short;)Ljava/lang/Short;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Short __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (Handle, id_optShort_Ljava_lang_String_Ljava_lang_Short_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOptString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_optString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_optString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OptString_Ljava_lang_String_Ljava_lang_String_);
			return cb_optString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_OptString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OptString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_optString_Ljava_lang_String_Ljava_lang_String_;
		public string OptString (string p0, string p1)
		{
			if (id_optString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_optString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_optString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_refresh;
#pragma warning disable 0169
		static Delegate GetRefreshHandler ()
		{
			if (cb_refresh == null)
				cb_refresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Refresh);
			return cb_refresh;
		}

		static void n_Refresh (IntPtr jnienv, IntPtr native__this)
		{
			global::configurationImpl.IConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.IConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Refresh ();
		}
#pragma warning restore 0169

		IntPtr id_refresh;
		public void Refresh ()
		{
			if (id_refresh == IntPtr.Zero)
				id_refresh = JNIEnv.GetMethodID (class_ref, "refresh", "()V");
			JNIEnv.CallVoidMethod (Handle, id_refresh);
		}

	}

}
