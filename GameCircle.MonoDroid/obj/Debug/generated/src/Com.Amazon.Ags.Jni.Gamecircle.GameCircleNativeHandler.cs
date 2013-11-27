using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Gamecircle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='GameCircleNativeHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/gamecircle/GameCircleNativeHandler", DoNotGenerateAcw=true)]
	public partial class GameCircleNativeHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/gamecircle/GameCircleNativeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameCircleNativeHandler); }
		}

		protected GameCircleNativeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='GameCircleNativeHandler']/constructor[@name='GameCircleNativeHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GameCircleNativeHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GameCircleNativeHandler)) {
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

		static IntPtr id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGames_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='GameCircleNativeHandler']/method[@name='initializeNativeHandler' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.AmazonGames']]"
		[Register ("initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGames;)V", "")]
		public static void InitializeNativeHandler (global::Com.Amazon.Ags.Api.IAmazonGames p0)
		{
			if (id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGames_ == IntPtr.Zero)
				id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGames_ = JNIEnv.GetStaticMethodID (class_ref, "initializeNativeHandler", "(Lcom/amazon/ags/api/AmazonGames;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeNativeHandler_Lcom_amazon_ags_api_AmazonGames_, new JValue (p0));
		}

		static IntPtr id_showGameCircle_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='GameCircleNativeHandler']/method[@name='showGameCircle' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("showGameCircle", "(IJ)V", "")]
		public static void ShowGameCircle (int p0, long p1)
		{
			if (id_showGameCircle_IJ == IntPtr.Zero)
				id_showGameCircle_IJ = JNIEnv.GetStaticMethodID (class_ref, "showGameCircle", "(IJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_showGameCircle_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_showGameCircleHandle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='GameCircleNativeHandler']/method[@name='showGameCircleHandle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("showGameCircleHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;", "")]
		public static global::Com.Amazon.Ags.Api.IAGResponseHandle ShowGameCircleHandle (int p0)
		{
			if (id_showGameCircleHandle_I == IntPtr.Zero)
				id_showGameCircleHandle_I = JNIEnv.GetStaticMethodID (class_ref, "showGameCircleHandle", "(I)Lcom/amazon/ags/api/AGResponseHandle;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_showGameCircleHandle_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
