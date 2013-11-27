using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='VariationSet']"
	[Register ("com/amazon/insights/VariationSet", "", "Com.Amazon.Insights.IVariationSetInvoker")]
	public partial interface IVariationSet : global::Java.Lang.IIterable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='VariationSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Com.Amazon.Insights.IVariationSetInvoker, AmazonInsights.MonoDroid")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='VariationSet']/method[@name='getVariation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getVariation", "(Ljava/lang/String;)Lcom/amazon/insights/Variation;", "GetGetVariation_Ljava_lang_String_Handler:Com.Amazon.Insights.IVariationSetInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.IVariation GetVariation (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='VariationSet']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Com.Amazon.Insights.IVariationSetInvoker, AmazonInsights.MonoDroid")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='VariationSet']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler:Com.Amazon.Insights.IVariationSetInvoker, AmazonInsights.MonoDroid")]
		int Size ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/VariationSet", DoNotGenerateAcw=true)]
	internal class IVariationSetInvoker : global::Java.Lang.Object, IVariationSet {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/VariationSet");
		IntPtr class_ref;

		public static IVariationSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVariationSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.VariationSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVariationSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IVariationSetInvoker); }
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IVariationSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_contains_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getVariation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetVariation_Ljava_lang_String_Handler ()
		{
			if (cb_getVariation_Ljava_lang_String_ == null)
				cb_getVariation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetVariation_Ljava_lang_String_);
			return cb_getVariation_Ljava_lang_String_;
		}

		static IntPtr n_GetVariation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IVariationSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetVariation (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariation_Ljava_lang_String_;
		public global::Com.Amazon.Insights.IVariation GetVariation (string p0)
		{
			if (id_getVariation_Ljava_lang_String_ == IntPtr.Zero)
				id_getVariation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVariation", "(Ljava/lang/String;)Lcom/amazon/insights/Variation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Insights.IVariation __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (JNIEnv.CallObjectMethod (Handle, id_getVariation_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IVariationSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IVariationSet __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (Handle, id_size);
		}

	}

}
