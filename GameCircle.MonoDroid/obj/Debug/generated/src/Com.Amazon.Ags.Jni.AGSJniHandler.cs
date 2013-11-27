using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/AGSJniHandler", DoNotGenerateAcw=true)]
	public partial class AGSJniHandler : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AGSJniHandler";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/AGSJniHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AGSJniHandler); }
		}

		protected AGSJniHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/constructor[@name='AGSJniHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AGSJniHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AGSJniHandler)) {
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

		static IntPtr id_isLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/method[@name='isLoaded' and count(parameter)=0]"
		[Register ("isLoaded", "()V", "")]
		public static void IsLoaded ()
		{
			if (id_isLoaded == IntPtr.Zero)
				id_isLoaded = JNIEnv.GetStaticMethodID (class_ref, "isLoaded", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_isLoaded);
		}

		static IntPtr id_loadLibrary;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/method[@name='loadLibrary' and count(parameter)=0]"
		[Register ("loadLibrary", "()V", "")]
		public static void LoadLibrary ()
		{
			if (id_loadLibrary == IntPtr.Zero)
				id_loadLibrary = JNIEnv.GetStaticMethodID (class_ref, "loadLibrary", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_loadLibrary);
		}

		static IntPtr id_showGameCircleResponseFailure_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/method[@name='showGameCircleResponseFailure' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showGameCircleResponseFailure", "(JII)V", "")]
		public static void ShowGameCircleResponseFailure (long p0, int p1, int p2)
		{
			if (id_showGameCircleResponseFailure_JII == IntPtr.Zero)
				id_showGameCircleResponseFailure_JII = JNIEnv.GetStaticMethodID (class_ref, "showGameCircleResponseFailure", "(JII)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_showGameCircleResponseFailure_JII, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_showGameCircleResponseSuccess_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='AGSJniHandler']/method[@name='showGameCircleResponseSuccess' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("showGameCircleResponseSuccess", "(JI)V", "")]
		public static void ShowGameCircleResponseSuccess (long p0, int p1)
		{
			if (id_showGameCircleResponseSuccess_JI == IntPtr.Zero)
				id_showGameCircleResponseSuccess_JI = JNIEnv.GetStaticMethodID (class_ref, "showGameCircleResponseSuccess", "(JI)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_showGameCircleResponseSuccess_JI, new JValue (p0), new JValue (p1));
		}

	}
}
