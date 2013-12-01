using System;
using System.Collections.Generic;
using Android.Runtime;

namespace tokenImpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/AccessToken", DoNotGenerateAcw=true)]
	public partial class AccessToken : global::tokenImpl.AbstractToken {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/field[@name='ALWAYS_EXPIRE']"
		[Register ("ALWAYS_EXPIRE")]
		public const long AlwaysExpire = (long) -1L;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/token/AccessToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccessToken); }
		}

		protected AccessToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/constructor[@name='AccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public AccessToken (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (AccessToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/constructor[@name='AccessToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public AccessToken (string p0, string p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (AccessToken)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;J)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;J)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_J, new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_J, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/constructor[@name='AccessToken' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public AccessToken (global::System.Collections.Generic.IDictionary<string, string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (AccessToken)) {
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

		static Delegate cb_getCurrentTime;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeHandler ()
		{
			if (cb_getCurrentTime == null)
				cb_getCurrentTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentTime);
			return cb_getCurrentTime;
		}

		static IntPtr n_GetCurrentTime (IntPtr jnienv, IntPtr native__this)
		{
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTime);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTime;
		protected virtual global::Android.Text.Format.Time CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()Landroid/text/format/Time;", "GetGetCurrentTimeHandler")]
			get {
				if (id_getCurrentTime == IntPtr.Zero)
					id_getCurrentTime = JNIEnv.GetMethodID (class_ref, "getCurrentTime", "()Landroid/text/format/Time;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentTime), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Text.Format.Time> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static long n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresIn;
		public virtual long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()J", "GetGetExpiresInHandler")]
			get {
				if (id_getExpiresIn == IntPtr.Zero)
					id_getExpiresIn = JNIEnv.GetMethodID (class_ref, "getExpiresIn", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getExpiresIn);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getExpiresIn);
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
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasExpired;
		public virtual bool HasExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='hasExpired' and count(parameter)=0]"
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

		static Delegate cb_getPreExpirationPeriod;
#pragma warning disable 0169
		static Delegate GetGetPreExpirationPeriodHandler ()
		{
			if (cb_getPreExpirationPeriod == null)
				cb_getPreExpirationPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPreExpirationPeriod);
			return cb_getPreExpirationPeriod;
		}

		static long n_GetPreExpirationPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreExpirationPeriod;
		}
#pragma warning restore 0169

		static IntPtr id_getPreExpirationPeriod;
		protected virtual long PreExpirationPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='getPreExpirationPeriod' and count(parameter)=0]"
			[Register ("getPreExpirationPeriod", "()J", "GetGetPreExpirationPeriodHandler")]
			get {
				if (id_getPreExpirationPeriod == IntPtr.Zero)
					id_getPreExpirationPeriod = JNIEnv.GetMethodID (class_ref, "getPreExpirationPeriod", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getPreExpirationPeriod);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getPreExpirationPeriod);
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
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_neverExpire;
#pragma warning disable 0169
		static Delegate GetNeverExpireHandler ()
		{
			if (cb_neverExpire == null)
				cb_neverExpire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeverExpire);
			return cb_neverExpire;
		}

		static bool n_NeverExpire (IntPtr jnienv, IntPtr native__this)
		{
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeverExpire ();
		}
#pragma warning restore 0169

		static IntPtr id_neverExpire;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='neverExpire' and count(parameter)=0]"
		[Register ("neverExpire", "()Z", "GetNeverExpireHandler")]
		public virtual bool NeverExpire ()
		{
			if (id_neverExpire == IntPtr.Zero)
				id_neverExpire = JNIEnv.GetMethodID (class_ref, "neverExpire", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_neverExpire);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_neverExpire);
		}

		static Delegate cb_setExpirationTime_J;
#pragma warning disable 0169
		static Delegate GetSetExpirationTime_JHandler ()
		{
			if (cb_setExpirationTime_J == null)
				cb_setExpirationTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpirationTime_J);
			return cb_setExpirationTime_J;
		}

		static void n_SetExpirationTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::tokenImpl.AccessToken __this = global::Java.Lang.Object.GetObject<global::tokenImpl.AccessToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpirationTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpirationTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='AccessToken']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpirationTime", "(J)V", "GetSetExpirationTime_JHandler")]
		protected virtual void SetExpirationTime (long p0)
		{
			if (id_setExpirationTime_J == IntPtr.Zero)
				id_setExpirationTime_J = JNIEnv.GetMethodID (class_ref, "setExpirationTime", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExpirationTime_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setExpirationTime_J, new JValue (p0));
		}

	}
}
