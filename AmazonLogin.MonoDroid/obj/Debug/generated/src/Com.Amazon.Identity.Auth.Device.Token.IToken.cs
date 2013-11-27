using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Token {

	[Register ("com/amazon/identity/auth/device/token/Token")]
	public abstract class Token {

		internal Token ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/field[@name='KEY_TOKEN']"
		[Register ("KEY_TOKEN")]
		public const string KeyToken = (string) "token";
	}

	[System.Obsolete ("Use the 'Token' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class TokenConsts : Token {

		private TokenConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']"
	[Register ("com/amazon/identity/auth/device/token/Token", "", "Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker")]
	public partial interface IToken : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler:Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker, AmazonLogin.MonoDroid")] get;
		}

		string DirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/method[@name='getDirectedId' and count(parameter)=0]"
			[Register ("getDirectedId", "()Ljava/lang/String;", "GetGetDirectedIdHandler:Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker, AmazonLogin.MonoDroid")] get;
		}

		global::Android.Text.Format.Time LocalTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/method[@name='getLocalTimestamp' and count(parameter)=0]"
			[Register ("getLocalTimestamp", "()Landroid/text/format/Time;", "GetGetLocalTimestampHandler:Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker, AmazonLogin.MonoDroid")] get;
		}

		string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler:Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker, AmazonLogin.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Com.Amazon.Identity.Auth.Device.Token.ITokenInvoker, AmazonLogin.MonoDroid")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/Token", DoNotGenerateAcw=true)]
	internal class ITokenInvoker : global::Java.Lang.Object, IToken {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/identity/auth/device/token/Token");
		IntPtr class_ref;

		public static IToken GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToken> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.identity.auth.device.token.Token"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITokenInvoker); }
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.IToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.IToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		IntPtr id_getData;
		public global::System.Collections.Generic.IDictionary<string, string> Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Token.IToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.IToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DirectedId);
		}
#pragma warning restore 0169

		IntPtr id_getDirectedId;
		public string DirectedId {
			get {
				if (id_getDirectedId == IntPtr.Zero)
					id_getDirectedId = JNIEnv.GetMethodID (class_ref, "getDirectedId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Token.IToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.IToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalTimestamp);
		}
#pragma warning restore 0169

		IntPtr id_getLocalTimestamp;
		public global::Android.Text.Format.Time LocalTimestamp {
			get {
				if (id_getLocalTimestamp == IntPtr.Zero)
					id_getLocalTimestamp = JNIEnv.GetMethodID (class_ref, "getLocalTimestamp", "()Landroid/text/format/Time;");
				return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallObjectMethod (Handle, id_getLocalTimestamp), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Token.IToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.IToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public string Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.IToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.IToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
