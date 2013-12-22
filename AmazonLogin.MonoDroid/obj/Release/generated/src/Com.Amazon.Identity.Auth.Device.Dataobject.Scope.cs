using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/Scope", DoNotGenerateAcw=true)]
	public partial class Scope : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/Scope", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scope); }
		}

		protected Scope (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/constructor[@name='Scope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public Scope (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (Scope)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_isLocal;
#pragma warning disable 0169
		static Delegate GetIsLocalHandler ()
		{
			if (cb_isLocal == null)
				cb_isLocal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocal);
			return cb_isLocal;
		}

		static bool n_IsLocal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocal;
		}
#pragma warning restore 0169

		static IntPtr id_isLocal;
		public virtual bool IsLocal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='isLocal' and count(parameter)=0]"
			[Register ("isLocal", "()Z", "GetIsLocalHandler")]
			get {
				if (id_isLocal == IntPtr.Zero)
					id_isLocal = JNIEnv.GetMethodID (class_ref, "isLocal", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLocal);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isLocal);
			}
		}

		static Delegate cb_getScopeDescription;
#pragma warning disable 0169
		static Delegate GetGetScopeDescriptionHandler ()
		{
			if (cb_getScopeDescription == null)
				cb_getScopeDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopeDescription);
			return cb_getScopeDescription;
		}

		static IntPtr n_GetScopeDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScopeDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setScopeDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScopeDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setScopeDescription_Ljava_lang_String_ == null)
				cb_setScopeDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScopeDescription_Ljava_lang_String_);
			return cb_setScopeDescription_Ljava_lang_String_;
		}

		static void n_SetScopeDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScopeDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScopeDescription;
		static IntPtr id_setScopeDescription_Ljava_lang_String_;
		public virtual string ScopeDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='getScopeDescription' and count(parameter)=0]"
			[Register ("getScopeDescription", "()Ljava/lang/String;", "GetGetScopeDescriptionHandler")]
			get {
				if (id_getScopeDescription == IntPtr.Zero)
					id_getScopeDescription = JNIEnv.GetMethodID (class_ref, "getScopeDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScopeDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getScopeDescription), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='setScopeDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScopeDescription", "(Ljava/lang/String;)V", "GetSetScopeDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setScopeDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setScopeDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopeDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScopeDescription_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setScopeDescription_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getScopeName;
#pragma warning disable 0169
		static Delegate GetGetScopeNameHandler ()
		{
			if (cb_getScopeName == null)
				cb_getScopeName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopeName);
			return cb_getScopeName;
		}

		static IntPtr n_GetScopeName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScopeName);
		}
#pragma warning restore 0169

		static IntPtr id_getScopeName;
		public virtual string ScopeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='getScopeName' and count(parameter)=0]"
			[Register ("getScopeName", "()Ljava/lang/String;", "GetGetScopeNameHandler")]
			get {
				if (id_getScopeName == IntPtr.Zero)
					id_getScopeName = JNIEnv.GetMethodID (class_ref, "getScopeName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScopeName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getScopeName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDescription_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='getDescription' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDescription", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetDescription (string p0, string p1)
		{
			if (id_getDescription_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getDescription_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDescription", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDescription_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_isLocal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Scope']/method[@name='isLocal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isLocal", "(Ljava/lang/String;)Z", "")]
		public static bool InvokeIsLocal (string p0)
		{
			if (id_isLocal_Ljava_lang_String_ == IntPtr.Zero)
				id_isLocal_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isLocal", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocal_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
