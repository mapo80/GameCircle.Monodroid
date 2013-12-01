using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']"
	[global::Android.Runtime.Register ("com/amazon/insights/InsightsProcessingService", DoNotGenerateAcw=true)]
	public partial class InsightsProcessingService : global::Android.App.IntentService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']/field[@name='ACTION_SUBMIT_MEASUREMENTS']"
		[Register ("ACTION_SUBMIT_MEASUREMENTS")]
		public const string ActionSubmitMeasurements = (string) "SubmitMeasurements";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']/field[@name='ACTION_SYNC_CONFIGURATION']"
		[Register ("ACTION_SYNC_CONFIGURATION")]
		public const string ActionSyncConfiguration = (string) "SyncConfiguration";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/InsightsProcessingService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InsightsProcessingService); }
		}

		protected InsightsProcessingService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']/constructor[@name='InsightsProcessingService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public InsightsProcessingService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InsightsProcessingService)) {
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

		static IntPtr id_cancelPendingIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']/method[@name='cancelPendingIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("cancelPendingIntent", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void CancelPendingIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_cancelPendingIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_cancelPendingIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "cancelPendingIntent", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelPendingIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onHandleIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnHandleIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_onHandleIntent_Landroid_content_Intent_ == null)
				cb_onHandleIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleIntent_Landroid_content_Intent_);
			return cb_onHandleIntent_Landroid_content_Intent_;
		}

		static void n_OnHandleIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.InsightsProcessingService __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.InsightsProcessingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights']/class[@name='InsightsProcessingService']/method[@name='onHandleIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onHandleIntent", "(Landroid/content/Intent;)V", "GetOnHandleIntent_Landroid_content_Intent_Handler")]
		protected override void OnHandleIntent (global::Android.Content.Intent p0)
		{
			if (id_onHandleIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_onHandleIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onHandleIntent", "(Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onHandleIntent_Landroid_content_Intent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onHandleIntent_Landroid_content_Intent_, new JValue (p0));
		}

	}
}
