using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.util']/interface[@name='JSONSerializable']"
	[Register ("com/amazon/insights/core/util/JSONSerializable", "", "Com.Amazon.Insights.Core.Util.IJSONSerializableInvoker")]
	public partial interface IJSONSerializable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.util']/interface[@name='JSONSerializable']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler:Com.Amazon.Insights.Core.Util.IJSONSerializableInvoker, AmazonInsights.MonoDroid")]
		global::Org.Json.JSONObject ToJSONObject ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/util/JSONSerializable", DoNotGenerateAcw=true)]
	internal class IJSONSerializableInvoker : global::Java.Lang.Object, IJSONSerializable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/util/JSONSerializable");
		IntPtr class_ref;

		public static IJSONSerializable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSONSerializable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.util.JSONSerializable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSONSerializableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJSONSerializableInvoker); }
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
			global::Com.Amazon.Insights.Core.Util.IJSONSerializable __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Core.Util.IJSONSerializable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		IntPtr id_toJSONObject;
		public global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");
			return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
		}

	}

}
