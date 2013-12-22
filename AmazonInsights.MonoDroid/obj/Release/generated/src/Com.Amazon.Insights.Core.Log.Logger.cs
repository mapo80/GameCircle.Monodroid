using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/log/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AmazonInsightsSDK";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']"
		[global::Android.Runtime.Register ("com/amazon/insights/core/log/Logger$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {


			static IntPtr DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Debug {
				get {
					if (DEBUG_jfieldId == IntPtr.Zero)
						DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEBUG_jfieldId == IntPtr.Zero)
						DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Info {
				get {
					if (INFO_jfieldId == IntPtr.Zero)
						INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INFO_jfieldId == IntPtr.Zero)
						INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INFO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='OFF']"
			[Register ("OFF")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Off {
				get {
					if (OFF_jfieldId == IntPtr.Zero)
						OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OFF_jfieldId == IntPtr.Zero)
						OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OFF_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERBOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Verbose {
				get {
					if (VERBOSE_jfieldId == IntPtr.Zero)
						VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERBOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERBOSE_jfieldId == IntPtr.Zero)
						VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERBOSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr WARN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel Warn {
				get {
					if (WARN_jfieldId == IntPtr.Zero)
						WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (WARN_jfieldId == IntPtr.Zero)
						WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lcom/amazon/insights/core/log/Logger$LogLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, WARN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/core/log/Logger$LogLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LogLevel); }
			}

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/log/Logger$LogLevel;", "")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/core/log/Logger$LogLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Insights.Core.Log.Logger.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/insights/core/log/Logger$LogLevel;", "")]
			public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/insights/core/log/Logger$LogLevel;");
				return (global::Com.Amazon.Insights.Core.Log.Logger.LogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Insights.Core.Log.Logger.LogLevel));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/log/Logger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logger); }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public Logger (string p0, global::Java.Lang.Class p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (Logger)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Class;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Class;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Class_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getAppenders;
		public static global::System.Collections.Generic.ICollection<global::Com.Amazon.Insights.Core.Log.Appender.LogAppender> Appenders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='getAppenders' and count(parameter)=0]"
			[Register ("getAppenders", "()Ljava/util/Collection;", "GetGetAppendersHandler")]
			get {
				if (id_getAppenders == IntPtr.Zero)
					id_getAppenders = JNIEnv.GetStaticMethodID (class_ref, "getAppenders", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Com.Amazon.Insights.Core.Log.Appender.LogAppender>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppenders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getGlobalLevel;
		static IntPtr id_setGlobalLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_;
		public static global::Com.Amazon.Insights.Core.Log.Logger.LogLevel GlobalLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='getGlobalLevel' and count(parameter)=0]"
			[Register ("getGlobalLevel", "()Lcom/amazon/insights/core/log/Logger$LogLevel;", "GetGetGlobalLevelHandler")]
			get {
				if (id_getGlobalLevel == IntPtr.Zero)
					id_getGlobalLevel = JNIEnv.GetStaticMethodID (class_ref, "getGlobalLevel", "()Lcom/amazon/insights/core/log/Logger$LogLevel;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGlobalLevel), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='setGlobalLevel' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.Logger.LogLevel']]"
			[Register ("setGlobalLevel", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)V", "GetSetGlobalLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_Handler")]
			set {
				if (id_setGlobalLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ == IntPtr.Zero)
					id_setGlobalLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "setGlobalLevel", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setGlobalLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_, new JValue (value));
			}
		}

		static IntPtr id_getLogAppenders;
		public static global::System.Collections.Generic.ICollection<global::Com.Amazon.Insights.Core.Log.Appender.LogAppender> LogAppenders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='getLogAppenders' and count(parameter)=0]"
			[Register ("getLogAppenders", "()Ljava/util/Collection;", "GetGetLogAppendersHandler")]
			get {
				if (id_getLogAppenders == IntPtr.Zero)
					id_getLogAppenders = JNIEnv.GetStaticMethodID (class_ref, "getLogAppenders", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Com.Amazon.Insights.Core.Log.Appender.LogAppender>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogAppenders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_attachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='attachAppender' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.appender.LogAppender']]"
		[Register ("attachAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V", "")]
		public static void AttachAppender (global::Com.Amazon.Insights.Core.Log.Appender.LogAppender p0)
		{
			if (id_attachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ == IntPtr.Zero)
				id_attachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ = JNIEnv.GetStaticMethodID (class_ref, "attachAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_attachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_, new JValue (p0));
		}

		static IntPtr id_attachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='attachLogAppender' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.appender.LogAppender']]"
		[Register ("attachLogAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V", "")]
		public static void AttachLogAppender (global::Com.Amazon.Insights.Core.Log.Appender.LogAppender p0)
		{
			if (id_attachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ == IntPtr.Zero)
				id_attachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ = JNIEnv.GetStaticMethodID (class_ref, "attachLogAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_attachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_, new JValue (p0));
		}

		static Delegate cb_d_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "GetD_Ljava_lang_String_Handler")]
		public virtual void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_d_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_d_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetD_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void D (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_d_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_detachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='detachAppender' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.appender.LogAppender']]"
		[Register ("detachAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V", "")]
		public static void DetachAppender (global::Com.Amazon.Insights.Core.Log.Appender.LogAppender p0)
		{
			if (id_detachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ == IntPtr.Zero)
				id_detachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ = JNIEnv.GetStaticMethodID (class_ref, "detachAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_detachAppender_Lcom_amazon_insights_core_log_appender_LogAppender_, new JValue (p0));
		}

		static IntPtr id_detachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='detachLogAppender' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.appender.LogAppender']]"
		[Register ("detachLogAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V", "")]
		public static void DetachLogAppender (global::Com.Amazon.Insights.Core.Log.Appender.LogAppender p0)
		{
			if (id_detachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ == IntPtr.Zero)
				id_detachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_ = JNIEnv.GetStaticMethodID (class_ref, "detachLogAppender", "(Lcom/amazon/insights/core/log/appender/LogAppender;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_detachLogAppender_Lcom_amazon_insights_core_log_appender_LogAppender_, new JValue (p0));
		}

		static Delegate cb_devd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDevd_Ljava_lang_String_Handler ()
		{
			if (cb_devd_Ljava_lang_String_ == null)
				cb_devd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Devd_Ljava_lang_String_);
			return cb_devd_Ljava_lang_String_;
		}

		static void n_Devd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Devd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_devd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("devd", "(Ljava/lang/String;)V", "GetDevd_Ljava_lang_String_Handler")]
		public virtual void Devd (string p0)
		{
			if (id_devd_Ljava_lang_String_ == IntPtr.Zero)
				id_devd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "devd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devd_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devd_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devd_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDevd_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_devd_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_devd_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Devd_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_devd_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Devd_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Devd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_devd_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("devd", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDevd_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void Devd (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_devd_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_devd_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "devd", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devd_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devd_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_deve_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeve_Ljava_lang_String_Handler ()
		{
			if (cb_deve_Ljava_lang_String_ == null)
				cb_deve_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Deve_Ljava_lang_String_);
			return cb_deve_Ljava_lang_String_;
		}

		static void n_Deve_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Deve (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deve_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='deve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deve", "(Ljava/lang/String;)V", "GetDeve_Ljava_lang_String_Handler")]
		public virtual void Deve (string p0)
		{
			if (id_deve_Ljava_lang_String_ == IntPtr.Zero)
				id_deve_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deve", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deve_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deve_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_deve_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDeve_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_deve_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_deve_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Deve_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_deve_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Deve_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Deve (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deve_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='deve' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("deve", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDeve_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void Deve (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_deve_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_deve_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "deve", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deve_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deve_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDevi_Ljava_lang_String_Handler ()
		{
			if (cb_devi_Ljava_lang_String_ == null)
				cb_devi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Devi_Ljava_lang_String_);
			return cb_devi_Ljava_lang_String_;
		}

		static void n_Devi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Devi (p0);
		}
#pragma warning restore 0169

		static IntPtr id_devi_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("devi", "(Ljava/lang/String;)V", "GetDevi_Ljava_lang_String_Handler")]
		public virtual void Devi (string p0)
		{
			if (id_devi_Ljava_lang_String_ == IntPtr.Zero)
				id_devi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "devi", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devi_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devi_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devi_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDevi_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_devi_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_devi_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Devi_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_devi_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Devi_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Devi (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_devi_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("devi", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDevi_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void Devi (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_devi_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_devi_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "devi", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devi_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devi_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devv_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDevv_Ljava_lang_String_Handler ()
		{
			if (cb_devv_Ljava_lang_String_ == null)
				cb_devv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Devv_Ljava_lang_String_);
			return cb_devv_Ljava_lang_String_;
		}

		static void n_Devv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Devv (p0);
		}
#pragma warning restore 0169

		static IntPtr id_devv_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("devv", "(Ljava/lang/String;)V", "GetDevv_Ljava_lang_String_Handler")]
		public virtual void Devv (string p0)
		{
			if (id_devv_Ljava_lang_String_ == IntPtr.Zero)
				id_devv_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "devv", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devv_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devv_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devv_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDevv_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_devv_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_devv_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Devv_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_devv_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Devv_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Devv (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_devv_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("devv", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDevv_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void Devv (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_devv_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_devv_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "devv", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devv_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devv_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDevw_Ljava_lang_String_Handler ()
		{
			if (cb_devw_Ljava_lang_String_ == null)
				cb_devw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Devw_Ljava_lang_String_);
			return cb_devw_Ljava_lang_String_;
		}

		static void n_Devw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Devw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_devw_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("devw", "(Ljava/lang/String;)V", "GetDevw_Ljava_lang_String_Handler")]
		public virtual void Devw (string p0)
		{
			if (id_devw_Ljava_lang_String_ == IntPtr.Zero)
				id_devw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "devw", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devw_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devw_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devw_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDevw_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_devw_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_devw_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Devw_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_devw_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Devw_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Devw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_devw_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devw' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("devw", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDevw_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void Devw (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_devw_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_devw_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "devw", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devw_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devw_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_devw_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDevw_Ljava_lang_Throwable_Handler ()
		{
			if (cb_devw_Ljava_lang_Throwable_ == null)
				cb_devw_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Devw_Ljava_lang_Throwable_);
			return cb_devw_Ljava_lang_Throwable_;
		}

		static void n_Devw_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Devw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_devw_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='devw' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("devw", "(Ljava/lang/Throwable;)V", "GetDevw_Ljava_lang_Throwable_Handler")]
		public virtual void Devw (global::Java.Lang.Throwable p0)
		{
			if (id_devw_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_devw_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "devw", "(Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_devw_Ljava_lang_Throwable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_devw_Ljava_lang_Throwable_, new JValue (p0));
		}

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.E (p0);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		public virtual void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_e_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void E (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_e_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getLogger_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getLogger", "(Ljava/lang/Class;)Lcom/amazon/insights/core/log/Logger;", "")]
		public static global::Com.Amazon.Insights.Core.Log.Logger GetLogger (global::Java.Lang.Class p0)
		{
			if (id_getLogger_Ljava_lang_Class_ == IntPtr.Zero)
				id_getLogger_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getLogger", "(Ljava/lang/Class;)Lcom/amazon/insights/core/log/Logger;");
			global::Com.Amazon.Insights.Core.Log.Logger __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogger_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.I (p0);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		public virtual void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_i_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void I (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_i_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_;
#pragma warning disable 0169
		static Delegate GetIsLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_Handler ()
		{
			if (cb_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_ == null)
				cb_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_);
			return cb_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_;
		}

		static bool n_IsLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Log.Logger.LogLevel p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsLoggingEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='isLoggingEnabled' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.Logger.LogLevel']]"
		[Register ("isLoggingEnabled", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)Z", "GetIsLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_Handler")]
		public virtual bool IsLoggingEnabled (global::Com.Amazon.Insights.Core.Log.Logger.LogLevel p0)
		{
			if (id_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_ == IntPtr.Zero)
				id_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_ = JNIEnv.GetMethodID (class_ref, "isLoggingEnabled", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isLoggingEnabled_Lcom_amazon_insights_core_log_Logger_LogLevel_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_Handler ()
		{
			if (cb_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ == null)
				cb_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_);
			return cb_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_;
		}

		static void n_SetLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Core.Log.Logger.LogLevel p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLevel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.Logger.LogLevel']]"
		[Register ("setLevel", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)V", "GetSetLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_Handler")]
		public virtual void SetLevel (global::Com.Amazon.Insights.Core.Log.Logger.LogLevel p0)
		{
			if (id_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ == IntPtr.Zero)
				id_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_ = JNIEnv.GetMethodID (class_ref, "setLevel", "(Lcom/amazon/insights/core/log/Logger$LogLevel;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLevel_Lcom_amazon_insights_core_log_Logger_LogLevel_, new JValue (p0));
		}

		static IntPtr id_tryInitialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='tryInitialize' and count(parameter)=0]"
		[Register ("tryInitialize", "()V", "")]
		public static void TryInitialize ()
		{
			if (id_tryInitialize == IntPtr.Zero)
				id_tryInitialize = JNIEnv.GetStaticMethodID (class_ref, "tryInitialize", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_tryInitialize);
		}

		static IntPtr id_tryInitialize_Lcom_amazon_insights_core_log_LogInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='tryInitialize' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.log.LogInitializer']]"
		[Register ("tryInitialize", "(Lcom/amazon/insights/core/log/LogInitializer;)V", "")]
		public static void TryInitialize (global::Com.Amazon.Insights.Core.Log.ILogInitializer p0)
		{
			if (id_tryInitialize_Lcom_amazon_insights_core_log_LogInitializer_ == IntPtr.Zero)
				id_tryInitialize_Lcom_amazon_insights_core_log_LogInitializer_ = JNIEnv.GetStaticMethodID (class_ref, "tryInitialize", "(Lcom/amazon/insights/core/log/LogInitializer;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_tryInitialize_Lcom_amazon_insights_core_log_LogInitializer_, new JValue (p0));
		}

		static Delegate cb_v_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.V (p0);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "GetV_Ljava_lang_String_Handler")]
		public virtual void V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_v_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_v_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void V (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_v_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_v_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_w_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.W (p0);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "GetW_Ljava_lang_String_Handler")]
		public virtual void W (string p0)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_w_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual void W (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_w_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_w_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Core.Log.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Log.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.W (p0);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.log']/class[@name='Logger']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/Throwable;)V", "GetW_Ljava_lang_Throwable_Handler")]
		public virtual void W (global::Java.Lang.Throwable p0)
		{
			if (id_w_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_Throwable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_w_Ljava_lang_Throwable_, new JValue (p0));
		}

	}
}
