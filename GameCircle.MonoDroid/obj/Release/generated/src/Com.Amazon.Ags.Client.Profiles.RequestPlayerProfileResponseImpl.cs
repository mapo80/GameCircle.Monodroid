using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Profiles {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='RequestPlayerProfileResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/profiles/RequestPlayerProfileResponseImpl", DoNotGenerateAcw=true)]
	public partial class RequestPlayerProfileResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Profiles.IRequestPlayerProfileResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/profiles/RequestPlayerProfileResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestPlayerProfileResponseImpl); }
		}

		protected RequestPlayerProfileResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_api_profiles_Player_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='RequestPlayerProfileResponseImpl']/constructor[@name='RequestPlayerProfileResponseImpl' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.api.profiles.Player'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/amazon/ags/api/profiles/Player;I)V", "")]
		public RequestPlayerProfileResponseImpl (global::Com.Amazon.Ags.Api.Profiles.IPlayer p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestPlayerProfileResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/api/profiles/Player;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/api/profiles/Player;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_api_profiles_Player_I == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_api_profiles_Player_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/api/profiles/Player;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_api_profiles_Player_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_api_profiles_Player_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='RequestPlayerProfileResponseImpl']/constructor[@name='RequestPlayerProfileResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public RequestPlayerProfileResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestPlayerProfileResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/amazon/ags/api/ErrorCode;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILcom_amazon_ags_api_ErrorCode_ == IntPtr.Zero)
				id_ctor_ILcom_amazon_ags_api_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/amazon/ags/api/ErrorCode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_amazon_ags_api_ErrorCode_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getPlayer;
#pragma warning disable 0169
		static Delegate GetGetPlayerHandler ()
		{
			if (cb_getPlayer == null)
				cb_getPlayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayer);
			return cb_getPlayer;
		}

		static IntPtr n_GetPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Profiles.RequestPlayerProfileResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Profiles.RequestPlayerProfileResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Player);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayer;
		public virtual global::Com.Amazon.Ags.Api.Profiles.IPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.profiles']/class[@name='RequestPlayerProfileResponseImpl']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/amazon/ags/api/profiles/Player;", "GetGetPlayerHandler")]
			get {
				if (id_getPlayer == IntPtr.Zero)
					id_getPlayer = JNIEnv.GetMethodID (class_ref, "getPlayer", "()Lcom/amazon/ags/api/profiles/Player;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (JNIEnv.CallObjectMethod  (Handle, id_getPlayer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPlayer), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
