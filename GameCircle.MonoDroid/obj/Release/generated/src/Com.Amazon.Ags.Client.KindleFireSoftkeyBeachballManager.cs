using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireSoftkeyBeachballManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/KindleFireSoftkeyBeachballManager", DoNotGenerateAcw=true)]
	public partial class KindleFireSoftkeyBeachballManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/KindleFireSoftkeyBeachballManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KindleFireSoftkeyBeachballManager); }
		}

		protected KindleFireSoftkeyBeachballManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Application_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client']/class[@name='KindleFireSoftkeyBeachballManager']/constructor[@name='KindleFireSoftkeyBeachballManager' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register (".ctor", "(Landroid/app/Application;)V", "")]
		public KindleFireSoftkeyBeachballManager (global::Android.App.Application p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KindleFireSoftkeyBeachballManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Application;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_app_Application_ == IntPtr.Zero)
				id_ctor_Landroid_app_Application_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Application_, new JValue (p0));
		}

	}
}
