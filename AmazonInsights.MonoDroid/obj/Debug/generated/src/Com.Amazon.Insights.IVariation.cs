using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']"
	[Register ("com/amazon/insights/Variation", "", "Com.Amazon.Insights.IVariationInvoker")]
	public partial interface IVariation : IJavaObject {

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")] get;
		}

		string ProjectName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getProjectName' and count(parameter)=0]"
			[Register ("getProjectName", "()Ljava/lang/String;", "GetGetProjectNameHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='containsVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsVariable", "(Ljava/lang/String;)Z", "GetContainsVariable_Ljava_lang_String_Handler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		bool ContainsVariable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getVariableAsBoolean", "(Ljava/lang/String;Z)Z", "GetGetVariableAsBoolean_Ljava_lang_String_ZHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		bool GetVariableAsBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("getVariableAsDouble", "(Ljava/lang/String;D)D", "GetGetVariableAsDouble_Ljava_lang_String_DHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		double GetVariableAsDouble (string p0, double p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getVariableAsFloat", "(Ljava/lang/String;F)F", "GetGetVariableAsFloat_Ljava_lang_String_FHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		float GetVariableAsFloat (string p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getVariableAsInt", "(Ljava/lang/String;I)I", "GetGetVariableAsInt_Ljava_lang_String_IHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		int GetVariableAsInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getVariableAsLong", "(Ljava/lang/String;J)J", "GetGetVariableAsLong_Ljava_lang_String_JHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		long GetVariableAsLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsShort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("getVariableAsShort", "(Ljava/lang/String;S)S", "GetGetVariableAsShort_Ljava_lang_String_SHandler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		short GetVariableAsShort (string p0, short p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/interface[@name='Variation']/method[@name='getVariableAsString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVariableAsString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetVariableAsString_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Insights.IVariationInvoker, AmazonInsights.MonoDroid")]
		string GetVariableAsString (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/Variation", DoNotGenerateAcw=true)]
	internal class IVariationInvoker : global::Java.Lang.Object, IVariation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/Variation");
		IntPtr class_ref;

		public static IVariation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVariation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.Variation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVariationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IVariationInvoker); }
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProjectName);
		}
#pragma warning restore 0169

		IntPtr id_getProjectName;
		public string ProjectName {
			get {
				if (id_getProjectName == IntPtr.Zero)
					id_getProjectName = JNIEnv.GetMethodID (class_ref, "getProjectName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getProjectName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsVariable (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsVariable_Ljava_lang_String_;
		public bool ContainsVariable (string p0)
		{
			if (id_containsVariable_Ljava_lang_String_ == IntPtr.Zero)
				id_containsVariable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsVariable", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_containsVariable_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetVariableAsBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsBoolean_Ljava_lang_String_Z;
		public bool GetVariableAsBoolean (string p0, bool p1)
		{
			if (id_getVariableAsBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getVariableAsBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getVariableAsBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_getVariableAsBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetVariableAsDouble (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsDouble_Ljava_lang_String_D;
		public double GetVariableAsDouble (string p0, double p1)
		{
			if (id_getVariableAsDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_getVariableAsDouble_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "getVariableAsDouble", "(Ljava/lang/String;D)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			double __ret = JNIEnv.CallDoubleMethod (Handle, id_getVariableAsDouble_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetVariableAsFloat (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsFloat_Ljava_lang_String_F;
		public float GetVariableAsFloat (string p0, float p1)
		{
			if (id_getVariableAsFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_getVariableAsFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "getVariableAsFloat", "(Ljava/lang/String;F)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			float __ret = JNIEnv.CallFloatMethod (Handle, id_getVariableAsFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetVariableAsInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsInt_Ljava_lang_String_I;
		public int GetVariableAsInt (string p0, int p1)
		{
			if (id_getVariableAsInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getVariableAsInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getVariableAsInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getVariableAsInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetVariableAsLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsLong_Ljava_lang_String_J;
		public long GetVariableAsLong (string p0, long p1)
		{
			if (id_getVariableAsLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getVariableAsLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getVariableAsLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallLongMethod (Handle, id_getVariableAsLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			short __ret = __this.GetVariableAsShort (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsShort_Ljava_lang_String_S;
		public short GetVariableAsShort (string p0, short p1)
		{
			if (id_getVariableAsShort_Ljava_lang_String_S == IntPtr.Zero)
				id_getVariableAsShort_Ljava_lang_String_S = JNIEnv.GetMethodID (class_ref, "getVariableAsShort", "(Ljava/lang/String;S)S");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			short __ret = JNIEnv.CallShortMethod (Handle, id_getVariableAsShort_Ljava_lang_String_S, new JValue (native_p0), new JValue (p1));
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
			global::Com.Amazon.Insights.IVariation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.IVariation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetVariableAsString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_;
		public string GetVariableAsString (string p0, string p1)
		{
			if (id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVariableAsString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getVariableAsString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
