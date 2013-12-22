using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsCredentials']"
	[Register ("com/amazon/insights/InsightsCredentials", "", "Com.Amazon.Insights.IInsightsCredentialsInvoker")]
	public partial interface IInsightsCredentials : IJavaObject {

		string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsCredentials']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler:Com.Amazon.Insights.IInsightsCredentialsInvoker, AmazonInsights.MonoDroid")] get;
		}

		string PrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsCredentials']/method[@name='getPrivateKey' and count(parameter)=0]"
			[Register ("getPrivateKey", "()Ljava/lang/String;", "GetGetPrivateKeyHandler:Com.Amazon.Insights.IInsightsCredentialsInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsCredentials']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Com.Amazon.Insights.IInsightsCredentialsInvoker, AmazonInsights.MonoDroid")]
		bool Equals (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='InsightsCredentials']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler:Com.Amazon.Insights.IInsightsCredentialsInvoker, AmazonInsights.MonoDroid")]
		int GetHashCode ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/InsightsCredentials", DoNotGenerateAcw=true)]
	internal class IInsightsCredentialsInvoker : global::Java.Lang.Object, IInsightsCredentials {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/InsightsCredentials");
		IntPtr class_ref;

		public static IInsightsCredentials GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsightsCredentials> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.InsightsCredentials"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsightsCredentialsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IInsightsCredentialsInvoker); }
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
			global::Com.Amazon.Insights.IInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationKey;
		public string ApplicationKey {
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetPrivateKeyHandler ()
		{
			if (cb_getPrivateKey == null)
				cb_getPrivateKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivateKey);
			return cb_getPrivateKey;
		}

		static IntPtr n_GetPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrivateKey);
		}
#pragma warning restore 0169

		IntPtr id_getPrivateKey;
		public string PrivateKey {
			get {
				if (id_getPrivateKey == IntPtr.Zero)
					id_getPrivateKey = JNIEnv.GetMethodID (class_ref, "getPrivateKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPrivateKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.IInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.IInsightsCredentials __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IInsightsCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCode);
		}

	}

}
