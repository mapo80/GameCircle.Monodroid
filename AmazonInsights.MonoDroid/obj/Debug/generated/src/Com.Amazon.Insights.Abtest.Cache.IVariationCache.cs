using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Abtest.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/interface[@name='VariationCache']"
	[Register ("com/amazon/insights/abtest/cache/VariationCache", "", "Com.Amazon.Insights.Abtest.Cache.IVariationCacheInvoker")]
	public partial interface IVariationCache : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/interface[@name='VariationCache']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler:Com.Amazon.Insights.Abtest.Cache.IVariationCacheInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/interface[@name='VariationCache']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation']]"
		[Register ("contains", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z", "GetContains_Lcom_amazon_insights_abtest_DefaultVariation_Handler:Com.Amazon.Insights.Abtest.Cache.IVariationCacheInvoker, AmazonInsights.MonoDroid")]
		bool Contains (global::Com.Amazon.Insights.Abtest.DefaultVariation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/interface[@name='VariationCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.Set']]"
		[Register ("get", "(Ljava/util/Set;)Ljava/util/Map;", "GetGet_Ljava_util_Set_Handler:Com.Amazon.Insights.Abtest.Cache.IVariationCacheInvoker, AmazonInsights.MonoDroid")]
		global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> Get (global::System.Collections.Generic.ICollection<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.abtest.cache']/interface[@name='VariationCache']/method[@name='put' and count(parameter)=1 and parameter[1][@type='com.amazon.insights.abtest.DefaultVariation']]"
		[Register ("put", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z", "GetPut_Lcom_amazon_insights_abtest_DefaultVariation_Handler:Com.Amazon.Insights.Abtest.Cache.IVariationCacheInvoker, AmazonInsights.MonoDroid")]
		bool Put (global::Com.Amazon.Insights.Abtest.DefaultVariation p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/abtest/cache/VariationCache", DoNotGenerateAcw=true)]
	internal class IVariationCacheInvoker : global::Java.Lang.Object, IVariationCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/abtest/cache/VariationCache");
		IntPtr class_ref;

		public static IVariationCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVariationCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.abtest.cache.VariationCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVariationCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IVariationCacheInvoker); }
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
			global::Com.Amazon.Insights.Abtest.Cache.IVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.IVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		IntPtr id_getAll;
		public global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> All {
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Abtest.Cache.IVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.IVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Abtest.DefaultVariation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lcom_amazon_insights_abtest_DefaultVariation_;
		public bool Contains (global::Com.Amazon.Insights.Abtest.DefaultVariation p0)
		{
			if (id_contains_Lcom_amazon_insights_abtest_DefaultVariation_ == IntPtr.Zero)
				id_contains_Lcom_amazon_insights_abtest_DefaultVariation_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_contains_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
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
			global::Com.Amazon.Insights.Abtest.Cache.IVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.IVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_util_Set_;
		public global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> Get (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_get_Ljava_util_Set_ == IntPtr.Zero)
				id_get_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/util/Set;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation> __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Insights.Abtest.DefaultVariation>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_get_Ljava_util_Set_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.Abtest.Cache.IVariationCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.Cache.IVariationCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Insights.Abtest.DefaultVariation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Abtest.DefaultVariation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Lcom_amazon_insights_abtest_DefaultVariation_;
		public bool Put (global::Com.Amazon.Insights.Abtest.DefaultVariation p0)
		{
			if (id_put_Lcom_amazon_insights_abtest_DefaultVariation_ == IntPtr.Zero)
				id_put_Lcom_amazon_insights_abtest_DefaultVariation_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/amazon/insights/abtest/DefaultVariation;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_put_Lcom_amazon_insights_abtest_DefaultVariation_, new JValue (p0));
			return __ret;
		}

	}

}
