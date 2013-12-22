using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Core.Log.Appender {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.log.appender']/class[@name='DeveloperLogCatAppender']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/log/appender/DeveloperLogCatAppender", DoNotGenerateAcw=true)]
	public partial class DeveloperLogCatAppender : global::Com.Amazon.Insights.Core.Log.Appender.LogAppender {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/log/appender/DeveloperLogCatAppender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeveloperLogCatAppender); }
		}

		protected DeveloperLogCatAppender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.log.appender']/class[@name='DeveloperLogCatAppender']/constructor[@name='DeveloperLogCatAppender' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeveloperLogCatAppender () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeveloperLogCatAppender)) {
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

	}
}
