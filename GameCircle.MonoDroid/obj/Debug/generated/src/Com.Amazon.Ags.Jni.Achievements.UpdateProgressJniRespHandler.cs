using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Achievements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='UpdateProgressJniRespHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/achievements/UpdateProgressJniRespHandler", DoNotGenerateAcw=true)]
	public partial class UpdateProgressJniRespHandler : global::Com.Amazon.Ags.Jni.JniResponseHandler, global::Com.Amazon.Ags.Api.IAGResponseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/achievements/UpdateProgressJniRespHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateProgressJniRespHandler); }
		}

		protected UpdateProgressJniRespHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='UpdateProgressJniRespHandler']/constructor[@name='UpdateProgressJniRespHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;IJ)V", "")]
		public UpdateProgressJniRespHandler (string p0, int p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (UpdateProgressJniRespHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IJ)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;IJ)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_IJ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Handler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_ == null)
				cb_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_);
			return cb_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Jni.Achievements.UpdateProgressJniRespHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Achievements.UpdateProgressJniRespHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse p0 = (global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.achievements']/class[@name='UpdateProgressJniRespHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.achievements.UpdateProgressResponse']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/achievements/UpdateProgressResponse;)V", "GetOnComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_Handler")]
		public virtual void OnComplete (global::Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse p0)
		{
			if (id_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/achievements/UpdateProgressResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onComplete_Lcom_amazon_ags_api_achievements_UpdateProgressResponse_, new JValue (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Api.IAGResponseCallback
		void global::Com.Amazon.Ags.Api.IAGResponseCallback.OnComplete (global::Java.Lang.Object p0)
		{
			OnComplete (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Api.Achievements.IUpdateProgressResponse>(p0));
		}

	}
}
