using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='PlayerImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/profiles/PlayerImpl", DoNotGenerateAcw=true)]
	public partial class PlayerImpl : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Profiles.IPlayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/profiles/PlayerImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerImpl); }
		}

		protected PlayerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='PlayerImpl']/constructor[@name='PlayerImpl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public PlayerImpl (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (PlayerImpl)) {
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

		static IntPtr id_getAlias;
		public string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='PlayerImpl']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Client.Profiles.PlayerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Profiles.PlayerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerId);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerId;
		public virtual string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='PlayerImpl']/method[@name='getPlayerId' and count(parameter)=0]"
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

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='PlayerImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
