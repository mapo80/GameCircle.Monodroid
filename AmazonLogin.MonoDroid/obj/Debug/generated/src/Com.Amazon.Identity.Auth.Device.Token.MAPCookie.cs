using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/MAPCookie", DoNotGenerateAcw=true)]
	public partial class MAPCookie : global::Java.Lang.Object, global::Com.Amazon.Identity.Auth.Device.Token.IToken, global::Java.IO.ISerializable, global::Org.Apache.Http.Cookies.ICookie {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='COOKIE_DATE_FORMAT']"
		[Register ("COOKIE_DATE_FORMAT")]
		public const string CookieDateFormat = (string) "dd MMM yyyy kk:mm:ss z";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_COMMENT']"
		[Register ("KEY_COMMENT")]
		public const string KeyComment = (string) "Comment";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_COMMENT_URL']"
		[Register ("KEY_COMMENT_URL")]
		public const string KeyCommentUrl = (string) "CommentUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_DIRECTED_ID']"
		[Register ("KEY_DIRECTED_ID")]
		public const string KeyDirectedId = (string) "DirectedId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_DOMAIN']"
		[Register ("KEY_DOMAIN")]
		public const string KeyDomain = (string) "Domain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_EXPIRES']"
		[Register ("KEY_EXPIRES")]
		public const string KeyExpires = (string) "Expires";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_HTTP_ONLY']"
		[Register ("KEY_HTTP_ONLY")]
		public const string KeyHttpOnly = (string) "HttpOnly";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_NAME']"
		[Register ("KEY_NAME")]
		public const string KeyName = (string) "Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_PATH']"
		[Register ("KEY_PATH")]
		public const string KeyPath = (string) "Path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_PERSISTANT']"
		[Register ("KEY_PERSISTANT")]
		public const string KeyPersistant = (string) "Persistant";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_SECURE']"
		[Register ("KEY_SECURE")]
		public const string KeySecure = (string) "Secure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_VALUE']"
		[Register ("KEY_VALUE")]
		public const string KeyValue = (string) "Value";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='KEY_VERSION']"
		[Register ("KEY_VERSION")]
		public const string KeyVersion = (string) "Version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/field[@name='NO_VERSION']"
		[Register ("NO_VERSION")]
		public const int NoVersion = (int) -1;

		public static class InterfaceConsts {

			// The following are fields from: com.amazon.identity.auth.device.token.Token

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/interface[@name='Token']/field[@name='KEY_TOKEN']"
			[Register ("KEY_TOKEN")]
			public const string KeyToken = (string) "token";
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie.CookieAttribute']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/MAPCookie$CookieAttribute", DoNotGenerateAcw=true)]
		public partial class CookieAttribute : global::Java.Lang.Object {

			protected CookieAttribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/token/MAPCookie", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPCookie); }
		}

		protected MAPCookie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/constructor[@name='MAPCookie' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public MAPCookie (string p0, string p1, string p2, string p3, bool p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (MAPCookie)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/constructor[@name='MAPCookie' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public MAPCookie (global::System.Collections.Generic.IDictionary<string, string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (MAPCookie)) {
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

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		static IntPtr id_getComment;
		public virtual string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler")]
			get {
				if (id_getComment == IntPtr.Zero)
					id_getComment = JNIEnv.GetMethodID (class_ref, "getComment", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getComment), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getComment), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCommentURL;
#pragma warning disable 0169
		static Delegate GetGetCommentURLHandler ()
		{
			if (cb_getCommentURL == null)
				cb_getCommentURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommentURL);
			return cb_getCommentURL;
		}

		static IntPtr n_GetCommentURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommentURL);
		}
#pragma warning restore 0169

		static IntPtr id_getCommentURL;
		public virtual string CommentURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getCommentURL' and count(parameter)=0]"
			[Register ("getCommentURL", "()Ljava/lang/String;", "GetGetCommentURLHandler")]
			get {
				if (id_getCommentURL == IntPtr.Zero)
					id_getCommentURL = JNIEnv.GetMethodID (class_ref, "getCommentURL", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCommentURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCommentURL), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public virtual global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getData), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DirectedId);
		}
#pragma warning restore 0169

		static IntPtr id_getDirectedId;
		public virtual string DirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getDirectedId' and count(parameter)=0]"
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

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		public virtual string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDomain), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExpiryDate;
#pragma warning disable 0169
		static Delegate GetGetExpiryDateHandler ()
		{
			if (cb_getExpiryDate == null)
				cb_getExpiryDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiryDate);
			return cb_getExpiryDate;
		}

		static IntPtr n_GetExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiryDate);
		}
#pragma warning restore 0169

		static IntPtr id_getExpiryDate;
		public virtual global::Java.Util.Date ExpiryDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getExpiryDate' and count(parameter)=0]"
			[Register ("getExpiryDate", "()Ljava/util/Date;", "GetGetExpiryDateHandler")]
			get {
				if (id_getExpiryDate == IntPtr.Zero)
					id_getExpiryDate = JNIEnv.GetMethodID (class_ref, "getExpiryDate", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpiryDate), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExpiryDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasExpired;
#pragma warning disable 0169
		static Delegate GetHasExpiredHandler ()
		{
			if (cb_hasExpired == null)
				cb_hasExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasExpired);
			return cb_hasExpired;
		}

		static bool n_HasExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasExpired;
		public virtual bool HasExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='hasExpired' and count(parameter)=0]"
			[Register ("hasExpired", "()Z", "GetHasExpiredHandler")]
			get {
				if (id_hasExpired == IntPtr.Zero)
					id_hasExpired = JNIEnv.GetMethodID (class_ref, "hasExpired", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasExpired);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasExpired);
			}
		}

		static Delegate cb_isHttpOnly;
#pragma warning disable 0169
		static Delegate GetIsHttpOnlyHandler ()
		{
			if (cb_isHttpOnly == null)
				cb_isHttpOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHttpOnly);
			return cb_isHttpOnly;
		}

		static bool n_IsHttpOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpOnly;
		}
#pragma warning restore 0169

		static Delegate cb_setHttpOnly_Z;
#pragma warning disable 0169
		static Delegate GetSetHttpOnly_ZHandler ()
		{
			if (cb_setHttpOnly_Z == null)
				cb_setHttpOnly_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHttpOnly_Z);
			return cb_setHttpOnly_Z;
		}

		static void n_SetHttpOnly_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpOnly = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHttpOnly;
		static IntPtr id_setHttpOnly_Z;
		public virtual bool HttpOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='isHttpOnly' and count(parameter)=0]"
			[Register ("isHttpOnly", "()Z", "GetIsHttpOnlyHandler")]
			get {
				if (id_isHttpOnly == IntPtr.Zero)
					id_isHttpOnly = JNIEnv.GetMethodID (class_ref, "isHttpOnly", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isHttpOnly);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isHttpOnly);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setHttpOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHttpOnly", "(Z)V", "GetSetHttpOnly_ZHandler")]
			set {
				if (id_setHttpOnly_Z == IntPtr.Zero)
					id_setHttpOnly_Z = JNIEnv.GetMethodID (class_ref, "setHttpOnly", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHttpOnly_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setHttpOnly_Z, new JValue (value));
			}
		}

		static Delegate cb_isPersistent;
#pragma warning disable 0169
		static Delegate GetIsPersistentHandler ()
		{
			if (cb_isPersistent == null)
				cb_isPersistent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPersistent);
			return cb_isPersistent;
		}

		static bool n_IsPersistent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPersistent;
		}
#pragma warning restore 0169

		static IntPtr id_isPersistent;
		public virtual bool IsPersistent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='isPersistent' and count(parameter)=0]"
			[Register ("isPersistent", "()Z", "GetIsPersistentHandler")]
			get {
				if (id_isPersistent == IntPtr.Zero)
					id_isPersistent = JNIEnv.GetMethodID (class_ref, "isPersistent", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPersistent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPersistent);
			}
		}

		static Delegate cb_isSecure;
#pragma warning disable 0169
		static Delegate GetIsSecureHandler ()
		{
			if (cb_isSecure == null)
				cb_isSecure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSecure);
			return cb_isSecure;
		}

		static bool n_IsSecure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSecure;
		}
#pragma warning restore 0169

		static IntPtr id_isSecure;
		public virtual bool IsSecure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='isSecure' and count(parameter)=0]"
			[Register ("isSecure", "()Z", "GetIsSecureHandler")]
			get {
				if (id_isSecure == IntPtr.Zero)
					id_isSecure = JNIEnv.GetMethodID (class_ref, "isSecure", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSecure);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isSecure);
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
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalTimestamp);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalTimestamp;
		public virtual global::Android.Text.Format.Time LocalTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getLocalTimestamp' and count(parameter)=0]"
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
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static void n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Path = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		static IntPtr id_setPath_Ljava_lang_String_;
		public virtual string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPath), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler")]
			set {
				if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPath_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPath_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getVersion);
			}
		}

		static IntPtr id_clearCookieInCookieManager_Landroid_content_Context_Lorg_apache_http_cookie_Cookie_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='clearCookieInCookieManager' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.apache.http.cookie.Cookie'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("clearCookieInCookieManager", "(Landroid/content/Context;Lorg/apache/http/cookie/Cookie;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void ClearCookieInCookieManager (global::Android.Content.Context p0, global::Org.Apache.Http.Cookies.ICookie p1, string p2, string p3)
		{
			if (id_clearCookieInCookieManager_Landroid_content_Context_Lorg_apache_http_cookie_Cookie_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_clearCookieInCookieManager_Landroid_content_Context_Lorg_apache_http_cookie_Cookie_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "clearCookieInCookieManager", "(Landroid/content/Context;Lorg/apache/http/cookie/Cookie;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCookieInCookieManager_Landroid_content_Context_Lorg_apache_http_cookie_Cookie_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_extractCookieStringArray_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='extractCookieStringArray' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("extractCookieStringArray", "(Ljava/util/List;)[Ljava/lang/String;", "")]
		public static string[] ExtractCookieStringArray (global::System.Collections.Generic.IList<global::Org.Apache.Http.Cookies.ICookie> p0)
		{
			if (id_extractCookieStringArray_Ljava_util_List_ == IntPtr.Zero)
				id_extractCookieStringArray_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "extractCookieStringArray", "(Ljava/util/List;)[Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Apache.Http.Cookies.ICookie>.ToLocalJniHandle (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractCookieStringArray_Ljava_util_List_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_formatDate_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='formatDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("formatDate", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static string FormatDate (global::Java.Util.Date p0)
		{
			if (id_formatDate_Ljava_util_Date_ == IntPtr.Zero)
				id_formatDate_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "formatDate", "(Ljava/util/Date;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDate_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_getAttribute_Ljava_lang_String_ == null)
				cb_getAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttribute_Ljava_lang_String_);
			return cb_getAttribute_Ljava_lang_String_;
		}

		static IntPtr n_GetAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAttribute (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAttribute_Ljava_lang_String_Handler")]
		public virtual string GetAttribute (string p0)
		{
			if (id_getAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAttribute_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAttribute_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getCookiesFromCookieManager_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getCookiesFromCookieManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getCookiesFromCookieManager", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Org.Apache.Http.Cookies.ICookie> GetCookiesFromCookieManager (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getCookiesFromCookieManager_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCookiesFromCookieManager_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCookiesFromCookieManager", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::System.Collections.Generic.IList<global::Org.Apache.Http.Cookies.ICookie> __ret = global::Android.Runtime.JavaList<global::Org.Apache.Http.Cookies.ICookie>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCookiesFromCookieManager_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_getCookiesStringFromCookieManager_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getCookiesStringFromCookieManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCookiesStringFromCookieManager", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetCookiesStringFromCookieManager (global::Android.Content.Context p0, string p1)
		{
			if (id_getCookiesStringFromCookieManager_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getCookiesStringFromCookieManager_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCookiesStringFromCookieManager", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCookiesStringFromCookieManager_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getPorts;
#pragma warning disable 0169
		static Delegate GetGetPortsHandler ()
		{
			if (cb_getPorts == null)
				cb_getPorts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPorts);
			return cb_getPorts;
		}

		static IntPtr n_GetPorts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPorts ());
		}
#pragma warning restore 0169

		static IntPtr id_getPorts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getPorts' and count(parameter)=0]"
		[Register ("getPorts", "()[I", "GetGetPortsHandler")]
		public virtual int[] GetPorts ()
		{
			if (id_getPorts == IntPtr.Zero)
				id_getPorts = JNIEnv.GetMethodID (class_ref, "getPorts", "()[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPorts), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPorts), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static IntPtr id_getSetCookieHeader_Lorg_apache_http_cookie_Cookie_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='getSetCookieHeader' and count(parameter)=1 and parameter[1][@type='org.apache.http.cookie.Cookie']]"
		[Register ("getSetCookieHeader", "(Lorg/apache/http/cookie/Cookie;)Ljava/lang/String;", "")]
		public static string GetSetCookieHeader (global::Org.Apache.Http.Cookies.ICookie p0)
		{
			if (id_getSetCookieHeader_Lorg_apache_http_cookie_Cookie_ == IntPtr.Zero)
				id_getSetCookieHeader_Lorg_apache_http_cookie_Cookie_ = JNIEnv.GetStaticMethodID (class_ref, "getSetCookieHeader", "(Lorg/apache/http/cookie/Cookie;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSetCookieHeader_Lorg_apache_http_cookie_Cookie_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isExpired_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetIsExpired_Ljava_util_Date_Handler ()
		{
			if (cb_isExpired_Ljava_util_Date_ == null)
				cb_isExpired_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsExpired_Ljava_util_Date_);
			return cb_isExpired_Ljava_util_Date_;
		}

		static bool n_IsExpired_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsExpired (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isExpired_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='isExpired' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("isExpired", "(Ljava/util/Date;)Z", "GetIsExpired_Ljava_util_Date_Handler")]
		public virtual bool IsExpired (global::Java.Util.Date p0)
		{
			if (id_isExpired_Ljava_util_Date_ == IntPtr.Zero)
				id_isExpired_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "isExpired", "(Ljava/util/Date;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isExpired_Ljava_util_Date_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isExpired_Ljava_util_Date_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_setAttribute_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttribute_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAttribute_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAttribute_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttribute_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAttribute_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetAttribute_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SetAttribute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSetAttribute_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string SetAttribute (string p0, string p1)
		{
			if (id_setAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_setAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setAttribute_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setExpiryDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpiryDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpiryDate_Ljava_lang_String_ == null)
				cb_setExpiryDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpiryDate_Ljava_lang_String_);
			return cb_setExpiryDate_Ljava_lang_String_;
		}

		static void n_SetExpiryDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExpiryDate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpiryDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setExpiryDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExpiryDate", "(Ljava/lang/String;)V", "GetSetExpiryDate_Ljava_lang_String_Handler")]
		public virtual void SetExpiryDate (string p0)
		{
			if (id_setExpiryDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setExpiryDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpiryDate", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExpiryDate_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setExpiryDate_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPorts_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPorts_arrayIHandler ()
		{
			if (cb_setPorts_arrayI == null)
				cb_setPorts_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPorts_arrayI);
			return cb_setPorts_arrayI;
		}

		static void n_SetPorts_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPorts (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPorts_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setPorts' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setPorts", "([I)V", "GetSetPorts_arrayIHandler")]
		public virtual void SetPorts (int[] p0)
		{
			if (id_setPorts_arrayI == IntPtr.Zero)
				id_setPorts_arrayI = JNIEnv.GetMethodID (class_ref, "setPorts", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPorts_arrayI, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPorts_arrayI, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSecure_Z;
#pragma warning disable 0169
		static Delegate GetSetSecure_ZHandler ()
		{
			if (cb_setSecure_Z == null)
				cb_setSecure_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSecure_Z);
			return cb_setSecure_Z;
		}

		static void n_SetSecure_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.MAPCookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSecure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSecure_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='MAPCookie']/method[@name='setSecure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSecure", "(Z)V", "GetSetSecure_ZHandler")]
		protected virtual void SetSecure (bool p0)
		{
			if (id_setSecure_Z == IntPtr.Zero)
				id_setSecure_Z = JNIEnv.GetMethodID (class_ref, "setSecure", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSecure_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSecure_Z, new JValue (p0));
		}

	}
}
