using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/AbstractToken", DoNotGenerateAcw=true)]
	public abstract partial class AbstractToken : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Token.IToken {


		static IntPtr localCreationTimestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/field[@name='localCreationTimestamp']"
		[Register ("localCreationTimestamp")]
		protected global::Android.Text.Format.Time LocalCreationTimestamp {
			get {
				if (localCreationTimestamp_jfieldId == IntPtr.Zero)
					localCreationTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "localCreationTimestamp", "Landroid/text/format/Time;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, localCreationTimestamp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localCreationTimestamp_jfieldId == IntPtr.Zero)
					localCreationTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "localCreationTimestamp", "Landroid/text/format/Time;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, localCreationTimestamp_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr tokenData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/field[@name='tokenData']"
		[Register ("tokenData")]
		protected global::System.Collections.IDictionary TokenData {
			get {
				if (tokenData_jfieldId == IntPtr.Zero)
					tokenData_jfieldId = JNIEnv.GetFieldID (class_ref, "tokenData", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, tokenData_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tokenData_jfieldId == IntPtr.Zero)
					tokenData_jfieldId = JNIEnv.GetFieldID (class_ref, "tokenData", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, tokenData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.amazon.identity.auth.device.token.Token

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/field[@name='KEY_TOKEN']"
			[Register ("KEY_TOKEN")]
			public const string KeyToken = (string) "token";
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/token/AbstractToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractToken); }
		}

		protected AbstractToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_identity_auth_device_token_AbstractToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/constructor[@name='AbstractToken' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.token.AbstractToken']]"
		[Register (".ctor", "(Lcom/amazon/identity/auth/device/token/AbstractToken;)V", "")]
		public AbstractToken (global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/identity/auth/device/token/AbstractToken;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/identity/auth/device/token/AbstractToken;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_identity_auth_device_token_AbstractToken_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_identity_auth_device_token_AbstractToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/token/AbstractToken;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_token_AbstractToken_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_token_AbstractToken_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/constructor[@name='AbstractToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public AbstractToken (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AbstractToken)) {
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

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/constructor[@name='AbstractToken' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public AbstractToken (global::System.Collections.Generic.IDictionary<string, string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (AbstractToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
				id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getData;
		public global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDirectedId;
#pragma warning disable 0169
		static Delegate GetGetDirectedIdHandler ()
		{
			if (cb_getDirectedId == null)
				cb_getDirectedId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirectedId);
			return cb_getDirectedId;
		}

		static IntPtr n_GetDirectedId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DirectedId);
		}
#pragma warning restore 0169

		static IntPtr id_getDirectedId;
		public virtual string DirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getDirectedId' and count(parameter)=0]"
			[Register ("getDirectedId", "()Ljava/lang/String;", "GetGetDirectedIdHandler")]
			get {
				if (id_getDirectedId == IntPtr.Zero)
					id_getDirectedId = JNIEnv.GetMethodID (class_ref, "getDirectedId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalTimestamp;
#pragma warning disable 0169
		static Delegate GetGetLocalTimestampHandler ()
		{
			if (cb_getLocalTimestamp == null)
				cb_getLocalTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalTimestamp);
			return cb_getLocalTimestamp;
		}

		static IntPtr n_GetLocalTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalTimestamp);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalTimestamp;
		public virtual global::Android.Text.Format.Time LocalTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getLocalTimestamp' and count(parameter)=0]"
			[Register ("getLocalTimestamp", "()Landroid/text/format/Time;", "GetGetLocalTimestampHandler")]
			get {
				if (id_getLocalTimestamp == IntPtr.Zero)
					id_getLocalTimestamp = JNIEnv.GetMethodID (class_ref, "getLocalTimestamp", "()Landroid/text/format/Time;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallObjectMethod  (Handle, id_getLocalTimestamp), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalTimestamp), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getToken;
		protected string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_convertStringToRegionHint_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='convertStringToRegionHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertStringToRegionHint", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;", "")]
		public static global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT ConvertStringToRegionHint (string p0)
		{
			if (id_convertStringToRegionHint_Ljava_lang_String_ == IntPtr.Zero)
				id_convertStringToRegionHint_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertStringToRegionHint", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStringToRegionHint_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_millisToSecs_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='millisToSecs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("millisToSecs", "(J)J", "")]
		protected static long MillisToSecs (long p0)
		{
			if (id_millisToSecs_J == IntPtr.Zero)
				id_millisToSecs_J = JNIEnv.GetStaticMethodID (class_ref, "millisToSecs", "(J)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_millisToSecs_J, new JValue (p0));
		}

		static IntPtr id_secsToMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='secsToMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("secsToMillis", "(J)J", "")]
		public static long SecsToMillis (long p0)
		{
			if (id_secsToMillis_J == IntPtr.Zero)
				id_secsToMillis_J = JNIEnv.GetStaticMethodID (class_ref, "secsToMillis", "(J)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_secsToMillis_J, new JValue (p0));
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		public abstract string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/AbstractToken", DoNotGenerateAcw=true)]
	internal partial class AbstractTokenInvoker : AbstractToken {

		public AbstractTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractTokenInvoker); }
		}

		static IntPtr id_getType;
		public override string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AbstractToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
