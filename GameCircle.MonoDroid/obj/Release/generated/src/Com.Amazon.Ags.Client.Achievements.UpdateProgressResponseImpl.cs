using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='UpdateProgressResponseImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/achievements/UpdateProgressResponseImpl", DoNotGenerateAcw=true)]
	public partial class UpdateProgressResponseImpl : global::Com.Amazon.Ags.Client.RequestResponseImpl, global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/achievements/UpdateProgressResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateProgressResponseImpl); }
		}

		protected UpdateProgressResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='UpdateProgressResponseImpl']/constructor[@name='UpdateProgressResponseImpl' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register (".ctor", "(ZI)V", "")]
		public UpdateProgressResponseImpl (bool p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UpdateProgressResponseImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZI)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ZI == IntPtr.Zero)
				id_ctor_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZI, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_ILcom_amazon_ags_api_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='UpdateProgressResponseImpl']/constructor[@name='UpdateProgressResponseImpl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.amazon.ags.api.ErrorCode']]"
		[Register (".ctor", "(ILcom/amazon/ags/api/ErrorCode;)V", "")]
		public UpdateProgressResponseImpl (int p0, global::Com.Amazon.Ags.Api.ErrorCode p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UpdateProgressResponseImpl)) {
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

		static Delegate cb_isNewlyUnlocked;
#pragma warning disable 0169
		static Delegate GetIsNewlyUnlockedHandler ()
		{
			if (cb_isNewlyUnlocked == null)
				cb_isNewlyUnlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNewlyUnlocked);
			return cb_isNewlyUnlocked;
		}

		static bool n_IsNewlyUnlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Achievements.UpdateProgressResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Achievements.UpdateProgressResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNewlyUnlocked;
		}
#pragma warning restore 0169

		static IntPtr id_isNewlyUnlocked;
		public virtual bool IsNewlyUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.achievements']/class[@name='UpdateProgressResponseImpl']/method[@name='isNewlyUnlocked' and count(parameter)=0]"
			[Register ("isNewlyUnlocked", "()Z", "GetIsNewlyUnlockedHandler")]
			get {
				if (id_isNewlyUnlocked == IntPtr.Zero)
					id_isNewlyUnlocked = JNIEnv.GetMethodID (class_ref, "isNewlyUnlocked", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isNewlyUnlocked);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isNewlyUnlocked);
			}
		}

	}
}
