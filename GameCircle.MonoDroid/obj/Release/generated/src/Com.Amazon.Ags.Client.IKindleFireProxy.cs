using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']"
	[Register ("com/amazon/ags/client/KindleFireProxy", "", "Com.Amazon.Ags.Client.IKindleFireProxyInvoker")]
	public partial interface IKindleFireProxy : IJavaObject {

		bool IsKindle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isKindle' and count(parameter)=0]"
			[Register ("isKindle", "()Z", "GetIsKindleHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsOptedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isOptedIn' and count(parameter)=0]"
			[Register ("isOptedIn", "()Z", "GetIsOptedInHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsOverlaysSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isOverlaysSupported' and count(parameter)=0]"
			[Register ("isOverlaysSupported", "()Z", "GetIsOverlaysSupportedHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsUniversalSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isUniversalSupported' and count(parameter)=0]"
			[Register ("isUniversalSupported", "()Z", "GetIsUniversalSupportedHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsWhispersyncEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='isWhispersyncEnabled' and count(parameter)=0]"
			[Register ("isWhispersyncEnabled", "()Z", "GetIsWhispersyncEnabledHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		global::Com.Amazon.Ags.Client.KindleFireStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/amazon/ags/client/KindleFireStatus;", "GetGetStatusHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='bindToGameCircleService' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.KindleFireBindingCallback']]"
		[Register ("bindToGameCircleService", "(Lcom/amazon/ags/client/KindleFireBindingCallback;)V", "GetBindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_Handler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")]
		void BindToGameCircleService (global::Com.Amazon.Ags.Client.IKindleFireBindingCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='setOptIn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOptIn", "(Z)V", "GetSetOptIn_ZHandler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")]
		void SetOptIn (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='showOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showOverlay", "(Ljava/lang/String;)V", "GetShowOverlay_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")]
		void ShowOverlay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireProxy']/method[@name='signMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("signMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;", "GetSignMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Ags.Client.IKindleFireProxyInvoker, GameCircle.MonoDroid")]
		global::System.Collections.Generic.IDictionary<string, string> SignMessage (string p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/KindleFireProxy", DoNotGenerateAcw=true)]
	internal class IKindleFireProxyInvoker : global::Java.Lang.Object, IKindleFireProxy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/KindleFireProxy");
		IntPtr class_ref;

		public static IKindleFireProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKindleFireProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.KindleFireProxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKindleFireProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IKindleFireProxyInvoker); }
		}

		static Delegate cb_isKindle;
#pragma warning disable 0169
		static Delegate GetIsKindleHandler ()
		{
			if (cb_isKindle == null)
				cb_isKindle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKindle);
			return cb_isKindle;
		}

		static bool n_IsKindle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKindle;
		}
#pragma warning restore 0169

		IntPtr id_isKindle;
		public bool IsKindle {
			get {
				if (id_isKindle == IntPtr.Zero)
					id_isKindle = JNIEnv.GetMethodID (class_ref, "isKindle", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isKindle);
			}
		}

		static Delegate cb_isOptedIn;
#pragma warning disable 0169
		static Delegate GetIsOptedInHandler ()
		{
			if (cb_isOptedIn == null)
				cb_isOptedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOptedIn);
			return cb_isOptedIn;
		}

		static bool n_IsOptedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOptedIn;
		}
#pragma warning restore 0169

		IntPtr id_isOptedIn;
		public bool IsOptedIn {
			get {
				if (id_isOptedIn == IntPtr.Zero)
					id_isOptedIn = JNIEnv.GetMethodID (class_ref, "isOptedIn", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOptedIn);
			}
		}

		static Delegate cb_isOverlaysSupported;
#pragma warning disable 0169
		static Delegate GetIsOverlaysSupportedHandler ()
		{
			if (cb_isOverlaysSupported == null)
				cb_isOverlaysSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOverlaysSupported);
			return cb_isOverlaysSupported;
		}

		static bool n_IsOverlaysSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOverlaysSupported;
		}
#pragma warning restore 0169

		IntPtr id_isOverlaysSupported;
		public bool IsOverlaysSupported {
			get {
				if (id_isOverlaysSupported == IntPtr.Zero)
					id_isOverlaysSupported = JNIEnv.GetMethodID (class_ref, "isOverlaysSupported", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOverlaysSupported);
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isReady);
			}
		}

		static Delegate cb_isRegistered;
#pragma warning disable 0169
		static Delegate GetIsRegisteredHandler ()
		{
			if (cb_isRegistered == null)
				cb_isRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegistered);
			return cb_isRegistered;
		}

		static bool n_IsRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegistered;
		}
#pragma warning restore 0169

		IntPtr id_isRegistered;
		public bool IsRegistered {
			get {
				if (id_isRegistered == IntPtr.Zero)
					id_isRegistered = JNIEnv.GetMethodID (class_ref, "isRegistered", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isRegistered);
			}
		}

		static Delegate cb_isUniversalSupported;
#pragma warning disable 0169
		static Delegate GetIsUniversalSupportedHandler ()
		{
			if (cb_isUniversalSupported == null)
				cb_isUniversalSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUniversalSupported);
			return cb_isUniversalSupported;
		}

		static bool n_IsUniversalSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUniversalSupported;
		}
#pragma warning restore 0169

		IntPtr id_isUniversalSupported;
		public bool IsUniversalSupported {
			get {
				if (id_isUniversalSupported == IntPtr.Zero)
					id_isUniversalSupported = JNIEnv.GetMethodID (class_ref, "isUniversalSupported", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isUniversalSupported);
			}
		}

		static Delegate cb_isWhispersyncEnabled;
#pragma warning disable 0169
		static Delegate GetIsWhispersyncEnabledHandler ()
		{
			if (cb_isWhispersyncEnabled == null)
				cb_isWhispersyncEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWhispersyncEnabled);
			return cb_isWhispersyncEnabled;
		}

		static bool n_IsWhispersyncEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWhispersyncEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isWhispersyncEnabled;
		public bool IsWhispersyncEnabled {
			get {
				if (id_isWhispersyncEnabled == IntPtr.Zero)
					id_isWhispersyncEnabled = JNIEnv.GetMethodID (class_ref, "isWhispersyncEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isWhispersyncEnabled);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		public global::Com.Amazon.Ags.Client.KindleFireStatus Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/amazon/ags/client/KindleFireStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (JNIEnv.CallObjectMethod (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_;
#pragma warning disable 0169
		static Delegate GetBindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_Handler ()
		{
			if (cb_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_ == null)
				cb_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_);
			return cb_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_;
		}

		static void n_BindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.IKindleFireBindingCallback p0 = (global::Com.Amazon.Ags.Client.IKindleFireBindingCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireBindingCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindToGameCircleService (p0);
		}
#pragma warning restore 0169

		IntPtr id_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_;
		public void BindToGameCircleService (global::Com.Amazon.Ags.Client.IKindleFireBindingCallback p0)
		{
			if (id_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_ == IntPtr.Zero)
				id_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_ = JNIEnv.GetMethodID (class_ref, "bindToGameCircleService", "(Lcom/amazon/ags/client/KindleFireBindingCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_bindToGameCircleService_Lcom_amazon_ags_client_KindleFireBindingCallback_, new JValue (p0));
		}

		static Delegate cb_setOptIn_Z;
#pragma warning disable 0169
		static Delegate GetSetOptIn_ZHandler ()
		{
			if (cb_setOptIn_Z == null)
				cb_setOptIn_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOptIn_Z);
			return cb_setOptIn_Z;
		}

		static void n_SetOptIn_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOptIn (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOptIn_Z;
		public void SetOptIn (bool p0)
		{
			if (id_setOptIn_Z == IntPtr.Zero)
				id_setOptIn_Z = JNIEnv.GetMethodID (class_ref, "setOptIn", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setOptIn_Z, new JValue (p0));
		}

		static Delegate cb_showOverlay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowOverlay_Ljava_lang_String_Handler ()
		{
			if (cb_showOverlay_Ljava_lang_String_ == null)
				cb_showOverlay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowOverlay_Ljava_lang_String_);
			return cb_showOverlay_Ljava_lang_String_;
		}

		static void n_ShowOverlay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowOverlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_showOverlay_Ljava_lang_String_;
		public void ShowOverlay (string p0)
		{
			if (id_showOverlay_Ljava_lang_String_ == IntPtr.Zero)
				id_showOverlay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showOverlay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_showOverlay_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SignMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SignMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Client.IKindleFireProxy __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.SignMessage (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public global::System.Collections.Generic.IDictionary<string, string> SignMessage (string p0, string p1, string p2)
		{
			if (id_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "signMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_signMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
