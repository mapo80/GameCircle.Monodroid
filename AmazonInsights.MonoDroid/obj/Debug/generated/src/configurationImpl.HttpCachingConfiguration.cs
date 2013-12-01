using System;
using System.Collections.Generic;
using Android.Runtime;

namespace configurationImpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/configuration/HttpCachingConfiguration", DoNotGenerateAcw=true)]
	public partial class HttpCachingConfiguration : global::Java.Lang.Object, global::configurationImpl.IConfiguration {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/configuration/HttpCachingConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpCachingConfiguration); }
		}

		protected HttpCachingConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBoolean (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Boolean GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Boolean __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getBoolean_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBoolean_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDouble (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)Ljava/lang/Double;", "GetGetDouble_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Double GetDouble (string p0)
		{
			if (id_getDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Double __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getDouble_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDouble_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Integer GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Integer __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getInt_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInt_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLong (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Long __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getLong_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLong_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetShort (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getShort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getShort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getShort", "(Ljava/lang/String;)Ljava/lang/Short;", "GetGetShort_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Short GetShort (string p0)
		{
			if (id_getShort_Ljava_lang_String_ == IntPtr.Zero)
				id_getShort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getShort", "(Ljava/lang/String;)Ljava/lang/Short;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Short __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod  (Handle, id_getShort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getShort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='com.amazon.insights.core.InsightsContext'] and parameter[2][@type='java.util.Map']]"
		[Register ("newInstance", "(Lcom/amazon/insights/core/InsightsContext;Ljava/util/Map;)Lcom/amazon/insights/core/configuration/HttpCachingConfiguration;", "")]
		public static global::configurationImpl.HttpCachingConfiguration NewInstance (global::Com.Amazon.Insights.Core.IInsightsContext p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_util_Map_ == IntPtr.Zero)
				id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/amazon/insights/core/InsightsContext;Ljava/util/Map;)Lcom/amazon/insights/core/configuration/HttpCachingConfiguration;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			global::configurationImpl.HttpCachingConfiguration __ret = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_amazon_insights_core_InsightsContext_Ljava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptBoolean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("optBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "GetOptBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		public virtual global::Java.Lang.Boolean OptBoolean (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "optBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Boolean __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optBoolean_Ljava_lang_String_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptDouble (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optDouble_Ljava_lang_String_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double']]"
		[Register ("optDouble", "(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;", "GetOptDouble_Ljava_lang_String_Ljava_lang_Double_Handler")]
		public virtual global::Java.Lang.Double OptDouble (string p0, global::Java.Lang.Double p1)
		{
			if (id_optDouble_Ljava_lang_String_Ljava_lang_Double_ == IntPtr.Zero)
				id_optDouble_Ljava_lang_String_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "optDouble", "(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Double __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_optDouble_Ljava_lang_String_Ljava_lang_Double_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optDouble_Ljava_lang_String_Ljava_lang_Double_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptInt (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optInt_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("optInt", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;", "GetOptInt_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual global::Java.Lang.Integer OptInt (string p0, global::Java.Lang.Integer p1)
		{
			if (id_optInt_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_optInt_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "optInt", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Integer __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_optInt_Ljava_lang_String_Ljava_lang_Integer_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optInt_Ljava_lang_String_Ljava_lang_Integer_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptLong (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optLong_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("optLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;", "GetOptLong_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual global::Java.Lang.Long OptLong (string p0, global::Java.Lang.Long p1)
		{
			if (id_optLong_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_optLong_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "optLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Long __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_optLong_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optLong_Ljava_lang_String_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OptShort (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optShort_Ljava_lang_String_Ljava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optShort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Short']]"
		[Register ("optShort", "(Ljava/lang/String;Ljava/lang/Short;)Ljava/lang/Short;", "GetOptShort_Ljava_lang_String_Ljava_lang_Short_Handler")]
		public virtual global::Java.Lang.Short OptShort (string p0, global::Java.Lang.Short p1)
		{
			if (id_optShort_Ljava_lang_String_Ljava_lang_Short_ == IntPtr.Zero)
				id_optShort_Ljava_lang_String_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "optShort", "(Ljava/lang/String;Ljava/lang/Short;)Ljava/lang/Short;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Short __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod  (Handle, id_optShort_Ljava_lang_String_Ljava_lang_Short_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optShort_Ljava_lang_String_Ljava_lang_Short_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OptString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_optString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='optString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetOptString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string OptString (string p0, string p1)
		{
			if (id_optString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_optString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_optString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_optString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
			global::configurationImpl.HttpCachingConfiguration __this = global::Java.Lang.Object.GetObject<global::configurationImpl.HttpCachingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Refresh ();
		}
#pragma warning restore 0169

		static IntPtr id_refresh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.configuration']/class[@name='HttpCachingConfiguration']/method[@name='refresh' and count(parameter)=0]"
		[Register ("refresh", "()V", "GetRefreshHandler")]
		public virtual void Refresh ()
		{
			if (id_refresh == IntPtr.Zero)
				id_refresh = JNIEnv.GetMethodID (class_ref, "refresh", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_refresh);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_refresh);
		}

	}
}
