using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='JSONBuilder']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/util/JSONBuilder", DoNotGenerateAcw=true)]
	public partial class JSONBuilder : global::Java.Lang.Object, global::Com.Amazon.Insights.Core.Util.IJSONSerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/util/JSONBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSONBuilder); }
		}

		protected JSONBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='JSONBuilder']/constructor[@name='JSONBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public JSONBuilder (global::Java.Lang.Object p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JSONBuilder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_, new JValue (p0));
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
			global::Com.Amazon.Insights.Core.Util.JSONBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.JSONBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='JSONBuilder']/method[@name='toJSONObject' and count(parameter)=0]"
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

		static Delegate cb_withAttribute_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWithAttribute_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_withAttribute_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_withAttribute_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAttribute_Ljava_lang_String_Ljava_lang_Object_);
			return cb_withAttribute_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WithAttribute_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Insights.Core.Util.JSONBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.JSONBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAttribute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAttribute_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/class[@name='JSONBuilder']/method[@name='withAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("withAttribute", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/amazon/insights/core/util/JSONBuilder;", "GetWithAttribute_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Amazon.Insights.Core.Util.JSONBuilder WithAttribute (string p0, global::Java.Lang.Object p1)
		{
			if (id_withAttribute_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_withAttribute_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "withAttribute", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/amazon/insights/core/util/JSONBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Amazon.Insights.Core.Util.JSONBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.JSONBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withAttribute_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.JSONBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withAttribute_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
