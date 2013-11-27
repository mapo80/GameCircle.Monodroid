using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/GlobalState", DoNotGenerateAcw=true)]
	public partial class GlobalState : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.util']/interface[@name='GlobalState.GlobalStateListener']"
		[Register ("com/amazon/ags/html5/util/GlobalState$GlobalStateListener", "", "Com.Amazon.Ags.Html5.Util.GlobalState/IGlobalStateListenerInvoker")]
		public partial interface IGlobalStateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/interface[@name='GlobalState.GlobalStateListener']/method[@name='notifyIsGuestModeSet' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("notifyIsGuestModeSet", "(Z)V", "GetNotifyIsGuestModeSet_ZHandler:Com.Amazon.Ags.Html5.Util.GlobalState/IGlobalStateListenerInvoker, GameCircle.MonoDroid")]
			void NotifyIsGuestModeSet (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/interface[@name='GlobalState.GlobalStateListener']/method[@name='notifyPlayerIdSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("notifyPlayerIdSet", "(Ljava/lang/String;)V", "GetNotifyPlayerIdSet_Ljava_lang_String_Handler:Com.Amazon.Ags.Html5.Util.GlobalState/IGlobalStateListenerInvoker, GameCircle.MonoDroid")]
			void NotifyPlayerIdSet (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/interface[@name='GlobalState.GlobalStateListener']/method[@name='notifyStateSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("notifyStateSet", "(Ljava/lang/String;Ljava/lang/String;)V", "GetNotifyStateSet_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amazon.Ags.Html5.Util.GlobalState/IGlobalStateListenerInvoker, GameCircle.MonoDroid")]
			void NotifyStateSet (string p0, string p1);

		}

		[global::Android.Runtime.Register ("com/amazon/ags/html5/util/GlobalState$GlobalStateListener", DoNotGenerateAcw=true)]
		internal class IGlobalStateListenerInvoker : global::Java.Lang.Object, IGlobalStateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/util/GlobalState$GlobalStateListener");
			IntPtr class_ref;

			public static IGlobalStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGlobalStateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.util.GlobalState.GlobalStateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGlobalStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGlobalStateListenerInvoker); }
			}

			static Delegate cb_notifyIsGuestModeSet_Z;
#pragma warning disable 0169
			static Delegate GetNotifyIsGuestModeSet_ZHandler ()
			{
				if (cb_notifyIsGuestModeSet_Z == null)
					cb_notifyIsGuestModeSet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_NotifyIsGuestModeSet_Z);
				return cb_notifyIsGuestModeSet_Z;
			}

			static void n_NotifyIsGuestModeSet_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NotifyIsGuestModeSet (p0);
			}
#pragma warning restore 0169

			IntPtr id_notifyIsGuestModeSet_Z;
			public void NotifyIsGuestModeSet (bool p0)
			{
				if (id_notifyIsGuestModeSet_Z == IntPtr.Zero)
					id_notifyIsGuestModeSet_Z = JNIEnv.GetMethodID (class_ref, "notifyIsGuestModeSet", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_notifyIsGuestModeSet_Z, new JValue (p0));
			}

			static Delegate cb_notifyPlayerIdSet_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNotifyPlayerIdSet_Ljava_lang_String_Handler ()
			{
				if (cb_notifyPlayerIdSet_Ljava_lang_String_ == null)
					cb_notifyPlayerIdSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyPlayerIdSet_Ljava_lang_String_);
				return cb_notifyPlayerIdSet_Ljava_lang_String_;
			}

			static void n_NotifyPlayerIdSet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotifyPlayerIdSet (p0);
			}
#pragma warning restore 0169

			IntPtr id_notifyPlayerIdSet_Ljava_lang_String_;
			public void NotifyPlayerIdSet (string p0)
			{
				if (id_notifyPlayerIdSet_Ljava_lang_String_ == IntPtr.Zero)
					id_notifyPlayerIdSet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyPlayerIdSet", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_notifyPlayerIdSet_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNotifyStateSet_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyStateSet_Ljava_lang_String_Ljava_lang_String_);
				return cb_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_NotifyStateSet_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.NotifyStateSet (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_;
			public void NotifyStateSet (string p0, string p1)
			{
				if (id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyStateSet", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_notifyStateSet_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		public partial class NotifyIsGuestModeSetEventArgs : global::System.EventArgs {

			public NotifyIsGuestModeSetEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class NotifyPlayerIdSetEventArgs : global::System.EventArgs {

			public NotifyPlayerIdSetEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class NotifyStateSetEventArgs : global::System.EventArgs {

			public NotifyStateSetEventArgs (string p0, string p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amazon/ags/html5/util/GlobalState_GlobalStateListenerImplementor")]
		internal sealed class IGlobalStateListenerImplementor : global::Java.Lang.Object, IGlobalStateListener {

			object sender;

			public IGlobalStateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/ags/html5/util/GlobalState_GlobalStateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NotifyIsGuestModeSetEventArgs> NotifyIsGuestModeSetHandler;
#pragma warning restore 0649

			public void NotifyIsGuestModeSet (bool p0)
			{
				var __h = NotifyIsGuestModeSetHandler;
				if (__h != null)
					__h (sender, new NotifyIsGuestModeSetEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NotifyPlayerIdSetEventArgs> NotifyPlayerIdSetHandler;
#pragma warning restore 0649

			public void NotifyPlayerIdSet (string p0)
			{
				var __h = NotifyPlayerIdSetHandler;
				if (__h != null)
					__h (sender, new NotifyPlayerIdSetEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NotifyStateSetEventArgs> NotifyStateSetHandler;
#pragma warning restore 0649

			public void NotifyStateSet (string p0, string p1)
			{
				var __h = NotifyStateSetHandler;
				if (__h != null)
					__h (sender, new NotifyStateSetEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IGlobalStateListenerImplementor value)
			{
				return value.NotifyIsGuestModeSetHandler == null && value.NotifyPlayerIdSetHandler == null && value.NotifyStateSetHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/GlobalState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlobalState); }
		}

		protected GlobalState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/constructor[@name='GlobalState' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GlobalState () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GlobalState)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getCountrySupport;
#pragma warning disable 0169
		static Delegate GetGetCountrySupportHandler ()
		{
			if (cb_getCountrySupport == null)
				cb_getCountrySupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountrySupport);
			return cb_getCountrySupport;
		}

		static IntPtr n_GetCountrySupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountrySupport);
		}
#pragma warning restore 0169

		static IntPtr id_getCountrySupport;
		public virtual string CountrySupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='getCountrySupport' and count(parameter)=0]"
			[Register ("getCountrySupport", "()Ljava/lang/String;", "GetGetCountrySupportHandler")]
			get {
				if (id_getCountrySupport == IntPtr.Zero)
					id_getCountrySupport = JNIEnv.GetMethodID (class_ref, "getCountrySupport", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountrySupport), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCountrySupport), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isGuestMode;
#pragma warning disable 0169
		static Delegate GetIsGuestModeHandler ()
		{
			if (cb_isGuestMode == null)
				cb_isGuestMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGuestMode);
			return cb_isGuestMode;
		}

		static bool n_IsGuestMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGuestMode;
		}
#pragma warning restore 0169

		static IntPtr id_isGuestMode;
		public virtual bool IsGuestMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='isGuestMode' and count(parameter)=0]"
			[Register ("isGuestMode", "()Z", "GetIsGuestModeHandler")]
			get {
				if (id_isGuestMode == IntPtr.Zero)
					id_isGuestMode = JNIEnv.GetMethodID (class_ref, "isGuestMode", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isGuestMode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isGuestMode);
			}
		}

		static Delegate cb_getPlayerId;
#pragma warning disable 0169
		static Delegate GetGetPlayerIdHandler ()
		{
			if (cb_getPlayerId == null)
				cb_getPlayerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerId);
			return cb_getPlayerId;
		}

		static IntPtr n_GetPlayerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerId);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerId;
		public virtual string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='getPlayerId' and count(parameter)=0]"
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler")]
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_Handler ()
		{
			if (cb_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ == null)
				cb_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_);
			return cb_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
		}

		static void n_AddListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener p0 = (global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.util.GlobalState.GlobalStateListener']]"
		[Register ("addListener", "(Lcom/amazon/ags/html5/util/GlobalState$GlobalStateListener;)V", "GetAddListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_Handler")]
		public virtual void AddListener (global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener p0)
		{
			if (id_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ == IntPtr.Zero)
				id_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/amazon/ags/html5/util/GlobalState$GlobalStateListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_, new JValue (p0));
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
		public virtual string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isHidden;
#pragma warning disable 0169
		static Delegate GetIsHiddenHandler ()
		{
			if (cb_isHidden == null)
				cb_isHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsHidden);
			return cb_isHidden;
		}

		static IntPtr n_IsHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsHidden ());
		}
#pragma warning restore 0169

		static IntPtr id_isHidden;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='isHidden' and count(parameter)=0]"
		[Register ("isHidden", "()Ljava/lang/Boolean;", "GetIsHiddenHandler")]
		public virtual global::Java.Lang.Boolean IsHidden ()
		{
			if (id_isHidden == IntPtr.Zero)
				id_isHidden = JNIEnv.GetMethodID (class_ref, "isHidden", "()Ljava/lang/Boolean;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isHidden), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_isHidden), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_put_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_Handler ()
		{
			if (cb_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ == null)
				cb_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_);
			return cb_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
		}

		static void n_RemoveListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener p0 = (global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.util.GlobalState.GlobalStateListener']]"
		[Register ("removeListener", "(Lcom/amazon/ags/html5/util/GlobalState$GlobalStateListener;)V", "GetRemoveListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_Handler")]
		public virtual void RemoveListener (global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener p0)
		{
			if (id_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ == IntPtr.Zero)
				id_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/amazon/ags/html5/util/GlobalState$GlobalStateListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeListener_Lcom_amazon_ags_html5_util_GlobalState_GlobalStateListener_, new JValue (p0));
		}

		static Delegate cb_toJSON;
#pragma warning disable 0169
		static Delegate GetToJSONHandler ()
		{
			if (cb_toJSON == null)
				cb_toJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSON);
			return cb_toJSON;
		}

		static IntPtr n_ToJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.GlobalState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.GlobalState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSON ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSON;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='GlobalState']/method[@name='toJSON' and count(parameter)=0]"
		[Register ("toJSON", "()Lorg/json/JSONObject;", "GetToJSONHandler")]
		public virtual global::Org.Json.JSONObject ToJSON ()
		{
			if (id_toJSON == IntPtr.Zero)
				id_toJSON = JNIEnv.GetMethodID (class_ref, "toJSON", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSON), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toJSON), JniHandleOwnership.TransferLocalRef);
		}

#region "Event implementation for Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListener"

		global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListenerImplementor __CreateIGlobalStateListenerImplementor ()
		{
			return new global::Com.Amazon.Ags.Html5.Util.GlobalState.IGlobalStateListenerImplementor (this);
		}
#endregion
	}
}
