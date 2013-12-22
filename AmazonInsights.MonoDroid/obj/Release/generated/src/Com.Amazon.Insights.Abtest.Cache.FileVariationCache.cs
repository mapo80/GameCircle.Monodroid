using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Abtest.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']"
	[global::Android.Runtime.Register ("com/amazon/insights/abtest/cache/FileVariationCache", DoNotGenerateAcw=true)]
	public partial class FileVariationCache : global::Java.Lang.Object, global::Com.Amazon.Insights.Abtest.Cache.IVariationCache {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/field[@name='VARIATIONS_DIRECTORY']"
		[Register ("VARIATIONS_DIRECTORY")]
		public const string VariationsDirectory = (string) "variations";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/abtest/cache/FileVariationCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileVariationCache); }
		}

		protected FileVariationCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_insights_core_InsightsContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/constructor[@name='FileVariationCache' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.core.InsightsContext']]"
		[Register (".ctor", "(Lcom/amazon/insights/core/InsightsContext;)V", "")]
		public FileVariationCache (global::Com.Amazon.Insights.Core.IInsightsContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileVariationCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/insights/core/InsightsContext;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_insights_core_InsightsContext_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_insights_core_InsightsContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/insights/core/InsightsContext;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_insights_core_InsightsContext_, new JValue (p0));
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		static IntPtr id_getAll;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_contains_Lcom_amazon_insights_abtest_DefaultVariation_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_amazon_insights_abtest_DefaultVariation_Handler ()
		{
			if (cb_contains_Lcom_amazon_insights_abtest_DefaultVariation_ == null)
				cb_contains_Lcom_amazon_insights_abtest_DefaultVariation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_amazon_insights_abtest_DefaultVariation_);
			return cb_contains_Lcom_amazon_insights_abtest_DefaultVariation_;
		}

		static bool n_Contains_Lcom_amazon_insights_abtest_DefaultVariation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Abtest.DefaultVariation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lcom_amazon_insights_abtest_DefaultVariation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation']]"
		[Register ("contains", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z", "GetContains_Lcom_amazon_insights_abtest_DefaultVariation_Handler")]
		public virtual bool Contains (global::Com.Amazon.Insights.Abtest.DefaultVariation p0)
		{
			if (id_contains_Lcom_amazon_insights_abtest_DefaultVariation_ == IntPtr.Zero)
				id_contains_Lcom_amazon_insights_abtest_DefaultVariation_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_contains_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_get_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_util_Set_Handler ()
		{
			if (cb_get_Ljava_util_Set_ == null)
				cb_get_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_util_Set_);
			return cb_get_Ljava_util_Set_;
		}

		static IntPtr n_Get_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.Set']]"
		[Register ("get", "(Ljava/util/Set;)Ljava/util/Map;", "GetGet_Ljava_util_Set_Handler")]
		public virtual global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> Get (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_get_Ljava_util_Set_ == IntPtr.Zero)
				id_get_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/util/Set;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);

			global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_util_Set_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_get_Ljava_util_Set_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Lcom_amazon_insights_abtest_DefaultVariation_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_amazon_insights_abtest_DefaultVariation_Handler ()
		{
			if (cb_put_Lcom_amazon_insights_abtest_DefaultVariation_ == null)
				cb_put_Lcom_amazon_insights_abtest_DefaultVariation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Put_Lcom_amazon_insights_abtest_DefaultVariation_);
			return cb_put_Lcom_amazon_insights_abtest_DefaultVariation_;
		}

		static bool n_Put_Lcom_amazon_insights_abtest_DefaultVariation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.FileVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Abtest.DefaultVariation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_amazon_insights_abtest_DefaultVariation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/class[@name='FileVariationCache']/method[@name='put' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation']]"
		[Register ("put", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z", "GetPut_Lcom_amazon_insights_abtest_DefaultVariation_Handler")]
		public virtual bool Put (global::Com.Amazon.Insights.Abtest.DefaultVariation p0)
		{
			if (id_put_Lcom_amazon_insights_abtest_DefaultVariation_ == IntPtr.Zero)
				id_put_Lcom_amazon_insights_abtest_DefaultVariation_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_put_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			return __ret;
		}

	}
}
