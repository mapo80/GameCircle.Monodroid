using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='NetworkUtil']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/NetworkUtil", DoNotGenerateAcw=true)]
	public partial class NetworkUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/NetworkUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkUtil); }
		}

		protected NetworkUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='NetworkUtil']/constructor[@name='NetworkUtil' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public NetworkUtil (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NetworkUtil)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_isNetworkConnected;
#pragma warning disable 0169
		static Delegate GetIsNetworkConnectedHandler ()
		{
			if (cb_isNetworkConnected == null)
				cb_isNetworkConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNetworkConnected);
			return cb_isNetworkConnected;
		}

		static bool n_IsNetworkConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Util.NetworkUtil __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Util.NetworkUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNetworkConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isNetworkConnected;
		public virtual bool IsNetworkConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='NetworkUtil']/method[@name='isNetworkConnected' and count(parameter)=0]"
			[Register ("isNetworkConnected", "()Z", "GetIsNetworkConnectedHandler")]
			get {
				if (id_isNetworkConnected == IntPtr.Zero)
					id_isNetworkConnected = JNIEnv.GetMethodID (class_ref, "isNetworkConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isNetworkConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isNetworkConnected);
			}
		}

	}
}
