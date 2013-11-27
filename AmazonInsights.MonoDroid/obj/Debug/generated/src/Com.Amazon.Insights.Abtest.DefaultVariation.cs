using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Abtest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']"
	[global::Android.Runtime.Register ("com/amazon/insights/abtest/DefaultVariation", DoNotGenerateAcw=true)]
	public partial class DefaultVariation : global::Java.Lang.Object, global::Com.Amazon.Insights.IVariation, global::Com.Amazon.Insights.Core.Util.IJSONSerializable {


		static IntPtr NULL_VARIATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/field[@name='NULL_VARIATION']"
		[Register ("NULL_VARIATION")]
		public static global::Com.Amazon.Insights.Abtest.DefaultVariation NullVariation {
			get {
				if (NULL_VARIATION_jfieldId == IntPtr.Zero)
					NULL_VARIATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NULL_VARIATION", "Lcom/amazon/insights/abtest/DefaultVariation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NULL_VARIATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NULL_VARIATION_jfieldId == IntPtr.Zero)
					NULL_VARIATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NULL_VARIATION", "Lcom/amazon/insights/abtest/DefaultVariation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NULL_VARIATION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']"
		[global::Android.Runtime.Register ("com/amazon/insights/abtest/DefaultVariation$AllocationSource", DoNotGenerateAcw=true)]
		public sealed partial class AllocationSource : global::Java.Lang.Enum {


			static IntPtr CACHE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']/field[@name='CACHE']"
			[Register ("CACHE")]
			public static global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource Cache {
				get {
					if (CACHE_jfieldId == IntPtr.Zero)
						CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CACHE_jfieldId == IntPtr.Zero)
						CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CACHE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SERVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']/field[@name='SERVER']"
			[Register ("SERVER")]
			public static global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource Server {
				get {
					if (SERVER_jfieldId == IntPtr.Zero)
						SERVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SERVER_jfieldId == IntPtr.Zero)
						SERVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER", "Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SERVER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/abtest/DefaultVariation$AllocationSource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AllocationSource); }
			}

			internal AllocationSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;", "")]
			public static global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.AllocationSource']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;", "")]
			public static global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");
				return (global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']"
		[global::Android.Runtime.Register ("com/amazon/insights/abtest/DefaultVariation$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/insights/abtest/DefaultVariation$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/constructor[@name='DefaultVariation.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
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

			static Delegate cb_getAllocationSource;
#pragma warning disable 0169
			static Delegate GetGetAllocationSourceHandler ()
			{
				if (cb_getAllocationSource == null)
					cb_getAllocationSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllocationSource);
				return cb_getAllocationSource;
			}

			static IntPtr n_GetAllocationSource (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AllocationSource);
			}
#pragma warning restore 0169

			static Delegate cb_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_;
#pragma warning disable 0169
			static Delegate GetSetAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_Handler ()
			{
				if (cb_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_ == null)
					cb_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_);
				return cb_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_;
			}

			static void n_SetAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AllocationSource = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getAllocationSource;
			static IntPtr id_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_;
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource AllocationSource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getAllocationSource' and count(parameter)=0]"
				[Register ("getAllocationSource", "()Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;", "GetGetAllocationSourceHandler")]
				get {
					if (id_getAllocationSource == IntPtr.Zero)
						id_getAllocationSource = JNIEnv.GetMethodID (class_ref, "getAllocationSource", "()Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (JNIEnv.CallObjectMethod  (Handle, id_getAllocationSource), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAllocationSource), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setAllocationSource' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation.AllocationSource']]"
				[Register ("setAllocationSource", "(Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;)V", "GetSetAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_Handler")]
				set {
					if (id_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_ == IntPtr.Zero)
						id_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_ = JNIEnv.GetMethodID (class_ref, "setAllocationSource", "(Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAllocationSource_Lcom_amazon_insights_abtest_DefaultVariation_AllocationSource_, new JValue (value));
				}
			}

			static Delegate cb_getApplicationKey;
#pragma warning disable 0169
			static Delegate GetGetApplicationKeyHandler ()
			{
				if (cb_getApplicationKey == null)
					cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
				return cb_getApplicationKey;
			}

			static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ApplicationKey);
			}
#pragma warning restore 0169

			static IntPtr id_getApplicationKey;
			public virtual string ApplicationKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getApplicationKey' and count(parameter)=0]"
				[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
				get {
					if (id_getApplicationKey == IntPtr.Zero)
						id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getAppliedDate;
#pragma warning disable 0169
			static Delegate GetGetAppliedDateHandler ()
			{
				if (cb_getAppliedDate == null)
					cb_getAppliedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppliedDate);
				return cb_getAppliedDate;
			}

			static IntPtr n_GetAppliedDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AppliedDate);
			}
#pragma warning restore 0169

			static IntPtr id_getAppliedDate;
			public virtual global::Java.Util.Date AppliedDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getAppliedDate' and count(parameter)=0]"
				[Register ("getAppliedDate", "()Ljava/util/Date;", "GetGetAppliedDateHandler")]
				get {
					if (id_getAppliedDate == IntPtr.Zero)
						id_getAppliedDate = JNIEnv.GetMethodID (class_ref, "getAppliedDate", "()Ljava/util/Date;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getAppliedDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppliedDate), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getExperimentId;
#pragma warning disable 0169
			static Delegate GetGetExperimentIdHandler ()
			{
				if (cb_getExperimentId == null)
					cb_getExperimentId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExperimentId);
				return cb_getExperimentId;
			}

			static long n_GetExperimentId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ExperimentId;
			}
#pragma warning restore 0169

			static IntPtr id_getExperimentId;
			public virtual long ExperimentId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getExperimentId' and count(parameter)=0]"
				[Register ("getExperimentId", "()J", "GetGetExperimentIdHandler")]
				get {
					if (id_getExperimentId == IntPtr.Zero)
						id_getExperimentId = JNIEnv.GetMethodID (class_ref, "getExperimentId", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getExperimentId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getExperimentId);
				}
			}

			static Delegate cb_getExpirationDate;
#pragma warning disable 0169
			static Delegate GetGetExpirationDateHandler ()
			{
				if (cb_getExpirationDate == null)
					cb_getExpirationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationDate);
				return cb_getExpirationDate;
			}

			static IntPtr n_GetExpirationDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ExpirationDate);
			}
#pragma warning restore 0169

			static IntPtr id_getExpirationDate;
			public virtual global::Java.Util.Date ExpirationDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getExpirationDate' and count(parameter)=0]"
				[Register ("getExpirationDate", "()Ljava/util/Date;", "GetGetExpirationDateHandler")]
				get {
					if (id_getExpirationDate == IntPtr.Zero)
						id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/util/Date;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getProjectName;
#pragma warning disable 0169
			static Delegate GetGetProjectNameHandler ()
			{
				if (cb_getProjectName == null)
					cb_getProjectName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjectName);
				return cb_getProjectName;
			}

			static IntPtr n_GetProjectName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProjectName);
			}
#pragma warning restore 0169

			static IntPtr id_getProjectName;
			public virtual string ProjectName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getProjectName' and count(parameter)=0]"
				[Register ("getProjectName", "()Ljava/lang/String;", "GetGetProjectNameHandler")]
				get {
					if (id_getProjectName == IntPtr.Zero)
						id_getProjectName = JNIEnv.GetMethodID (class_ref, "getProjectName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProjectName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProjectName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getUniqueId;
#pragma warning disable 0169
			static Delegate GetGetUniqueIdHandler ()
			{
				if (cb_getUniqueId == null)
					cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
				return cb_getUniqueId;
			}

			static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UniqueId);
			}
#pragma warning restore 0169

			static IntPtr id_getUniqueId;
			public virtual global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getUniqueId' and count(parameter)=0]"
				[Register ("getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueIdHandler")]
				get {
					if (id_getUniqueId == IntPtr.Zero)
						id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getVariables;
#pragma warning disable 0169
			static Delegate GetGetVariablesHandler ()
			{
				if (cb_getVariables == null)
					cb_getVariables = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariables);
				return cb_getVariables;
			}

			static IntPtr n_GetVariables (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Variables);
			}
#pragma warning restore 0169

			static IntPtr id_getVariables;
			public virtual global::System.Collections.Generic.IDictionary<string, string> Variables {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getVariables' and count(parameter)=0]"
				[Register ("getVariables", "()Ljava/util/Map;", "GetGetVariablesHandler")]
				get {
					if (id_getVariables == IntPtr.Zero)
						id_getVariables = JNIEnv.GetMethodID (class_ref, "getVariables", "()Ljava/util/Map;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getVariables), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVariables), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getVariationId;
#pragma warning disable 0169
			static Delegate GetGetVariationIdHandler ()
			{
				if (cb_getVariationId == null)
					cb_getVariationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVariationId);
				return cb_getVariationId;
			}

			static long n_GetVariationId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.VariationId;
			}
#pragma warning restore 0169

			static IntPtr id_getVariationId;
			public virtual long VariationId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getVariationId' and count(parameter)=0]"
				[Register ("getVariationId", "()J", "GetGetVariationIdHandler")]
				get {
					if (id_getVariationId == IntPtr.Zero)
						id_getVariationId = JNIEnv.GetMethodID (class_ref, "getVariationId", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getVariationId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getVariationId);
				}
			}

			static Delegate cb_getVariationName;
#pragma warning disable 0169
			static Delegate GetGetVariationNameHandler ()
			{
				if (cb_getVariationName == null)
					cb_getVariationName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariationName);
				return cb_getVariationName;
			}

			static IntPtr n_GetVariationName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.VariationName);
			}
#pragma warning restore 0169

			static IntPtr id_getVariationName;
			public virtual string VariationName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='getVariationName' and count(parameter)=0]"
				[Register ("getVariationName", "()Ljava/lang/String;", "GetGetVariationNameHandler")]
				get {
					if (id_getVariationName == IntPtr.Zero)
						id_getVariationName = JNIEnv.GetMethodID (class_ref, "getVariationName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVariationName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVariationName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/amazon/insights/abtest/DefaultVariation;", "GetBuildHandler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/amazon/insights/abtest/DefaultVariation;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setApplicationKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetApplicationKey_Ljava_lang_String_Handler ()
			{
				if (cb_setApplicationKey_Ljava_lang_String_ == null)
					cb_setApplicationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApplicationKey_Ljava_lang_String_);
				return cb_setApplicationKey_Ljava_lang_String_;
			}

			static IntPtr n_SetApplicationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApplicationKey (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setApplicationKey_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setApplicationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationKey", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetApplicationKey_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetApplicationKey (string p0)
			{
				if (id_setApplicationKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationKey", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setApplicationKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setApplicationKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setAppliedDate_Ljava_util_Date_;
#pragma warning disable 0169
			static Delegate GetSetAppliedDate_Ljava_util_Date_Handler ()
			{
				if (cb_setAppliedDate_Ljava_util_Date_ == null)
					cb_setAppliedDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppliedDate_Ljava_util_Date_);
				return cb_setAppliedDate_Ljava_util_Date_;
			}

			static IntPtr n_SetAppliedDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppliedDate (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAppliedDate_Ljava_util_Date_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setAppliedDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setAppliedDate", "(Ljava/util/Date;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetAppliedDate_Ljava_util_Date_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetAppliedDate (global::Java.Util.Date p0)
			{
				if (id_setAppliedDate_Ljava_util_Date_ == IntPtr.Zero)
					id_setAppliedDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setAppliedDate", "(Ljava/util/Date;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAppliedDate_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAppliedDate_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setExperimentId_J;
#pragma warning disable 0169
			static Delegate GetSetExperimentId_JHandler ()
			{
				if (cb_setExperimentId_J == null)
					cb_setExperimentId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetExperimentId_J);
				return cb_setExperimentId_J;
			}

			static IntPtr n_SetExperimentId_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetExperimentId (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setExperimentId_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setExperimentId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExperimentId", "(J)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetExperimentId_JHandler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetExperimentId (long p0)
			{
				if (id_setExperimentId_J == IntPtr.Zero)
					id_setExperimentId_J = JNIEnv.GetMethodID (class_ref, "setExperimentId", "(J)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setExperimentId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setExperimentId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setExpirationDate_Ljava_util_Date_;
#pragma warning disable 0169
			static Delegate GetSetExpirationDate_Ljava_util_Date_Handler ()
			{
				if (cb_setExpirationDate_Ljava_util_Date_ == null)
					cb_setExpirationDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExpirationDate_Ljava_util_Date_);
				return cb_setExpirationDate_Ljava_util_Date_;
			}

			static IntPtr n_SetExpirationDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExpirationDate (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setExpirationDate_Ljava_util_Date_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpirationDate", "(Ljava/util/Date;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetExpirationDate_Ljava_util_Date_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetExpirationDate (global::Java.Util.Date p0)
			{
				if (id_setExpirationDate_Ljava_util_Date_ == IntPtr.Zero)
					id_setExpirationDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExpirationDate", "(Ljava/util/Date;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setExpirationDate_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setExpirationDate_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setProjectName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProjectName_Ljava_lang_String_Handler ()
			{
				if (cb_setProjectName_Ljava_lang_String_ == null)
					cb_setProjectName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProjectName_Ljava_lang_String_);
				return cb_setProjectName_Ljava_lang_String_;
			}

			static IntPtr n_SetProjectName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProjectName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setProjectName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setProjectName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProjectName", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetProjectName_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetProjectName (string p0)
			{
				if (id_setProjectName_Ljava_lang_String_ == IntPtr.Zero)
					id_setProjectName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProjectName", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setProjectName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setProjectName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_;
#pragma warning disable 0169
			static Delegate GetSetUniqueId_Lcom_amazon_insights_core_idresolver_Id_Handler ()
			{
				if (cb_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_ == null)
					cb_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUniqueId_Lcom_amazon_insights_core_idresolver_Id_);
				return cb_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_;
			}

			static IntPtr n_SetUniqueId_Lcom_amazon_insights_core_idresolver_Id_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Insights.Core.Idresolver.Id p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUniqueId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setUniqueId' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.idresolver.Id']]"
			[Register ("setUniqueId", "(Lcom/amazon/insights/core/idresolver/Id;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetUniqueId_Lcom_amazon_insights_core_idresolver_Id_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetUniqueId (global::Com.Amazon.Insights.Core.Idresolver.Id p0)
			{
				if (id_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_ == IntPtr.Zero)
					id_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_ = JNIEnv.GetMethodID (class_ref, "setUniqueId", "(Lcom/amazon/insights/core/idresolver/Id;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setUniqueId_Lcom_amazon_insights_core_idresolver_Id_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_setVariables_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetVariables_Ljava_util_Map_Handler ()
			{
				if (cb_setVariables_Ljava_util_Map_ == null)
					cb_setVariables_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVariables_Ljava_util_Map_);
				return cb_setVariables_Ljava_util_Map_;
			}

			static IntPtr n_SetVariables_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariables (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setVariables_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setVariables' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setVariables", "(Ljava/util/Map;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetVariables_Ljava_util_Map_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetVariables (global::System.Collections.Generic.IDictionary<string, string> p0)
			{
				if (id_setVariables_Ljava_util_Map_ == IntPtr.Zero)
					id_setVariables_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setVariables", "(Ljava/util/Map;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVariables_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setVariables_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setVariationId_J;
#pragma warning disable 0169
			static Delegate GetSetVariationId_JHandler ()
			{
				if (cb_setVariationId_J == null)
					cb_setVariationId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetVariationId_J);
				return cb_setVariationId_J;
			}

			static IntPtr n_SetVariationId_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetVariationId (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setVariationId_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setVariationId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setVariationId", "(J)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetVariationId_JHandler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetVariationId (long p0)
			{
				if (id_setVariationId_J == IntPtr.Zero)
					id_setVariationId_J = JNIEnv.GetMethodID (class_ref, "setVariationId", "(J)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVariationId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setVariationId_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setVariationName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetVariationName_Ljava_lang_String_Handler ()
			{
				if (cb_setVariationName_Ljava_lang_String_ == null)
					cb_setVariationName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVariationName_Ljava_lang_String_);
				return cb_setVariationName_Ljava_lang_String_;
			}

			static IntPtr n_SetVariationName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVariationName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setVariationName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation.Builder']/method[@name='setVariationName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVariationName", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;", "GetSetVariationName_Ljava_lang_String_Handler")]
			public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder SetVariationName (string p0)
			{
				if (id_setVariationName_Ljava_lang_String_ == IntPtr.Zero)
					id_setVariationName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVariationName", "(Ljava/lang/String;)Lcom/amazon/insights/abtest/DefaultVariation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVariationName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setVariationName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/abtest/DefaultVariation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultVariation); }
		}

		protected DefaultVariation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		public virtual string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExperimentId;
#pragma warning disable 0169
		static Delegate GetGetExperimentIdHandler ()
		{
			if (cb_getExperimentId == null)
				cb_getExperimentId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExperimentId);
			return cb_getExperimentId;
		}

		static long n_GetExperimentId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExperimentId;
		}
#pragma warning restore 0169

		static IntPtr id_getExperimentId;
		public virtual long ExperimentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getExperimentId' and count(parameter)=0]"
			[Register ("getExperimentId", "()J", "GetGetExperimentIdHandler")]
			get {
				if (id_getExperimentId == IntPtr.Zero)
					id_getExperimentId = JNIEnv.GetMethodID (class_ref, "getExperimentId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getExperimentId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getExperimentId);
			}
		}

		static Delegate cb_getExpirationDate;
#pragma warning disable 0169
		static Delegate GetGetExpirationDateHandler ()
		{
			if (cb_getExpirationDate == null)
				cb_getExpirationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationDate);
			return cb_getExpirationDate;
		}

		static IntPtr n_GetExpirationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpirationDate);
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationDate;
		public virtual global::Java.Util.Date ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/util/Date;", "GetGetExpirationDateHandler")]
			get {
				if (id_getExpirationDate == IntPtr.Zero)
					id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isDefault;
#pragma warning disable 0169
		static Delegate GetIsDefaultHandler ()
		{
			if (cb_isDefault == null)
				cb_isDefault = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDefault);
			return cb_isDefault;
		}

		static bool n_IsDefault (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDefault;
		}
#pragma warning restore 0169

		static IntPtr id_isDefault;
		public virtual bool IsDefault {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='isDefault' and count(parameter)=0]"
			[Register ("isDefault", "()Z", "GetIsDefaultHandler")]
			get {
				if (id_isDefault == IntPtr.Zero)
					id_isDefault = JNIEnv.GetMethodID (class_ref, "isDefault", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDefault);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isDefault);
			}
		}

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		static IntPtr id_isExpired;
		public virtual bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				if (id_isExpired == IntPtr.Zero)
					id_isExpired = JNIEnv.GetMethodID (class_ref, "isExpired", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isExpired);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isExpired);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProjectName;
#pragma warning disable 0169
		static Delegate GetGetProjectNameHandler ()
		{
			if (cb_getProjectName == null)
				cb_getProjectName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjectName);
			return cb_getProjectName;
		}

		static IntPtr n_GetProjectName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProjectName);
		}
#pragma warning restore 0169

		static IntPtr id_getProjectName;
		public virtual string ProjectName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getProjectName' and count(parameter)=0]"
			[Register ("getProjectName", "()Ljava/lang/String;", "GetGetProjectNameHandler")]
			get {
				if (id_getProjectName == IntPtr.Zero)
					id_getProjectName = JNIEnv.GetMethodID (class_ref, "getProjectName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProjectName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProjectName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UniqueId);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId;
		public virtual global::Com.Amazon.Insights.Core.Idresolver.Id UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Lcom/amazon/insights/core/idresolver/Id;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Idresolver.Id> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVariationId;
#pragma warning disable 0169
		static Delegate GetGetVariationIdHandler ()
		{
			if (cb_getVariationId == null)
				cb_getVariationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVariationId);
			return cb_getVariationId;
		}

		static long n_GetVariationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VariationId;
		}
#pragma warning restore 0169

		static IntPtr id_getVariationId;
		public virtual long VariationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariationId' and count(parameter)=0]"
			[Register ("getVariationId", "()J", "GetGetVariationIdHandler")]
			get {
				if (id_getVariationId == IntPtr.Zero)
					id_getVariationId = JNIEnv.GetMethodID (class_ref, "getVariationId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getVariationId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getVariationId);
			}
		}

		static Delegate cb_containsVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsVariable_Ljava_lang_String_Handler ()
		{
			if (cb_containsVariable_Ljava_lang_String_ == null)
				cb_containsVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsVariable_Ljava_lang_String_);
			return cb_containsVariable_Ljava_lang_String_;
		}

		static bool n_ContainsVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsVariable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsVariable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='containsVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsVariable", "(Ljava/lang/String;)Z", "GetContainsVariable_Ljava_lang_String_Handler")]
		public virtual bool ContainsVariable (string p0)
		{
			if (id_containsVariable_Ljava_lang_String_ == IntPtr.Zero)
				id_containsVariable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsVariable", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsVariable_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_containsVariable_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAllocationSource;
#pragma warning disable 0169
		static Delegate GetGetAllocationSourceHandler ()
		{
			if (cb_getAllocationSource == null)
				cb_getAllocationSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllocationSource);
			return cb_getAllocationSource;
		}

		static IntPtr n_GetAllocationSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAllocationSource ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllocationSource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getAllocationSource' and count(parameter)=0]"
		[Register ("getAllocationSource", "()Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;", "GetGetAllocationSourceHandler")]
		public virtual global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource GetAllocationSource ()
		{
			if (id_getAllocationSource == IntPtr.Zero)
				id_getAllocationSource = JNIEnv.GetMethodID (class_ref, "getAllocationSource", "()Lcom/amazon/insights/abtest/DefaultVariation$AllocationSource;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (JNIEnv.CallObjectMethod  (Handle, id_getAllocationSource), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation.AllocationSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAllocationSource), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getVariableAsBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetVariableAsBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getVariableAsBoolean_Ljava_lang_String_Z == null)
				cb_getVariableAsBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetVariableAsBoolean_Ljava_lang_String_Z);
			return cb_getVariableAsBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetVariableAsBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetVariableAsBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getVariableAsBoolean", "(Ljava/lang/String;Z)Z", "GetGetVariableAsBoolean_Ljava_lang_String_ZHandler")]
		public virtual bool GetVariableAsBoolean (string p0, bool p1)
		{
			if (id_getVariableAsBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getVariableAsBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getVariableAsBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getVariableAsBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getVariableAsBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsDouble_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetGetVariableAsDouble_Ljava_lang_String_DHandler ()
		{
			if (cb_getVariableAsDouble_Ljava_lang_String_D == null)
				cb_getVariableAsDouble_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, double>) n_GetVariableAsDouble_Ljava_lang_String_D);
			return cb_getVariableAsDouble_Ljava_lang_String_D;
		}

		static double n_GetVariableAsDouble_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetVariableAsDouble (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsDouble_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("getVariableAsDouble", "(Ljava/lang/String;D)D", "GetGetVariableAsDouble_Ljava_lang_String_DHandler")]
		public virtual double GetVariableAsDouble (string p0, double p1)
		{
			if (id_getVariableAsDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_getVariableAsDouble_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "getVariableAsDouble", "(Ljava/lang/String;D)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_getVariableAsDouble_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getVariableAsDouble_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetGetVariableAsFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_getVariableAsFloat_Ljava_lang_String_F == null)
				cb_getVariableAsFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float>) n_GetVariableAsFloat_Ljava_lang_String_F);
			return cb_getVariableAsFloat_Ljava_lang_String_F;
		}

		static float n_GetVariableAsFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetVariableAsFloat (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsFloat_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getVariableAsFloat", "(Ljava/lang/String;F)F", "GetGetVariableAsFloat_Ljava_lang_String_FHandler")]
		public virtual float GetVariableAsFloat (string p0, float p1)
		{
			if (id_getVariableAsFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_getVariableAsFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "getVariableAsFloat", "(Ljava/lang/String;F)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			float __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallFloatMethod  (Handle, id_getVariableAsFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getVariableAsFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetVariableAsInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getVariableAsInt_Ljava_lang_String_I == null)
				cb_getVariableAsInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetVariableAsInt_Ljava_lang_String_I);
			return cb_getVariableAsInt_Ljava_lang_String_I;
		}

		static int n_GetVariableAsInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetVariableAsInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getVariableAsInt", "(Ljava/lang/String;I)I", "GetGetVariableAsInt_Ljava_lang_String_IHandler")]
		public virtual int GetVariableAsInt (string p0, int p1)
		{
			if (id_getVariableAsInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getVariableAsInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getVariableAsInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getVariableAsInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getVariableAsInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetVariableAsLong_Ljava_lang_String_JHandler ()
		{
			if (cb_getVariableAsLong_Ljava_lang_String_J == null)
				cb_getVariableAsLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_GetVariableAsLong_Ljava_lang_String_J);
			return cb_getVariableAsLong_Ljava_lang_String_J;
		}

		static long n_GetVariableAsLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetVariableAsLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getVariableAsLong", "(Ljava/lang/String;J)J", "GetGetVariableAsLong_Ljava_lang_String_JHandler")]
		public virtual long GetVariableAsLong (string p0, long p1)
		{
			if (id_getVariableAsLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getVariableAsLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getVariableAsLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getVariableAsLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getVariableAsLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsShort_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetGetVariableAsShort_Ljava_lang_String_SHandler ()
		{
			if (cb_getVariableAsShort_Ljava_lang_String_S == null)
				cb_getVariableAsShort_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, short>) n_GetVariableAsShort_Ljava_lang_String_S);
			return cb_getVariableAsShort_Ljava_lang_String_S;
		}

		static short n_GetVariableAsShort_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			short __ret = __this.GetVariableAsShort (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsShort_Ljava_lang_String_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsShort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("getVariableAsShort", "(Ljava/lang/String;S)S", "GetGetVariableAsShort_Ljava_lang_String_SHandler")]
		public virtual short GetVariableAsShort (string p0, short p1)
		{
			if (id_getVariableAsShort_Ljava_lang_String_S == IntPtr.Zero)
				id_getVariableAsShort_Ljava_lang_String_S = JNIEnv.GetMethodID (class_ref, "getVariableAsShort", "(Ljava/lang/String;S)S");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			short __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallShortMethod  (Handle, id_getVariableAsShort_Ljava_lang_String_S, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, id_getVariableAsShort_Ljava_lang_String_S, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariableAsString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetVariableAsString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetVariableAsString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getVariableAsString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetVariableAsString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetVariableAsString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='getVariableAsString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVariableAsString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetVariableAsString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string GetVariableAsString (string p0, string p1)
		{
			if (id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVariableAsString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newVariation_Lcom_amazon_insights_abtest_DefaultVariation_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='newVariation' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation.Builder']]"
		[Register ("newVariation", "(Lcom/amazon/insights/abtest/DefaultVariation$Builder;)Lcom/amazon/insights/abtest/DefaultVariation;", "")]
		public static global::Com.Amazon.Insights.Abtest.DefaultVariation NewVariation (global::Com.Amazon.Insights.Abtest.DefaultVariation.Builder p0)
		{
			if (id_newVariation_Lcom_amazon_insights_abtest_DefaultVariation_Builder_ == IntPtr.Zero)
				id_newVariation_Lcom_amazon_insights_abtest_DefaultVariation_Builder_ = JNIEnv.GetStaticMethodID (class_ref, "newVariation", "(Lcom/amazon/insights/abtest/DefaultVariation$Builder;)Lcom/amazon/insights/abtest/DefaultVariation;");
			global::Com.Amazon.Insights.Abtest.DefaultVariation __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newVariation_Lcom_amazon_insights_abtest_DefaultVariation_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_variablesIterator;
#pragma warning disable 0169
		static Delegate GetVariablesIteratorHandler ()
		{
			if (cb_variablesIterator == null)
				cb_variablesIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_VariablesIterator);
			return cb_variablesIterator;
		}

		static IntPtr n_VariablesIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.DefaultVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VariablesIterator ());
		}
#pragma warning restore 0169

		static IntPtr id_variablesIterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest']/class[@name='DefaultVariation']/method[@name='variablesIterator' and count(parameter)=0]"
		[Register ("variablesIterator", "()Ljava/util/Iterator;", "GetVariablesIteratorHandler")]
		public virtual global::Java.Util.IIterator VariablesIterator ()
		{
			if (id_variablesIterator == IntPtr.Zero)
				id_variablesIterator = JNIEnv.GetMethodID (class_ref, "variablesIterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_variablesIterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_variablesIterator), JniHandleOwnership.TransferLocalRef);
		}

	}
}
