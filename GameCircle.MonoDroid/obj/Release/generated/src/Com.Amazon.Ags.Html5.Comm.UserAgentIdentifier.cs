using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='UserAgentIdentifier']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/UserAgentIdentifier", DoNotGenerateAcw=true)]
	public partial class UserAgentIdentifier : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/UserAgentIdentifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserAgentIdentifier); }
		}

		protected UserAgentIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_VersionInfo_Lcom_amazon_ags_html5_content_ContentVersion_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='UserAgentIdentifier']/constructor[@name='UserAgentIdentifier' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.VersionInfo'] and parameter[2][@type='com.amazon.ags.html5.content.ContentVersion']]"
		[Register (".ctor", "(Lcom/amazon/ags/VersionInfo;Lcom/amazon/ags/html5/content/ContentVersion;)V", "")]
		public UserAgentIdentifier (global::Com.Amazon.Ags.VersionInfo p0, global::Com.Amazon.Ags.Html5.Content.ContentVersion p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserAgentIdentifier)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/VersionInfo;Lcom/amazon/ags/html5/content/ContentVersion;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/VersionInfo;Lcom/amazon/ags/html5/content/ContentVersion;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_VersionInfo_Lcom_amazon_ags_html5_content_ContentVersion_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_VersionInfo_Lcom_amazon_ags_html5_content_ContentVersion_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/VersionInfo;Lcom/amazon/ags/html5/content/ContentVersion;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_VersionInfo_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_VersionInfo_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getUserAgent;
#pragma warning disable 0169
		static Delegate GetGetUserAgentHandler ()
		{
			if (cb_getUserAgent == null)
				cb_getUserAgent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserAgent);
			return cb_getUserAgent;
		}

		static IntPtr n_GetUserAgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Comm.UserAgentIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.UserAgentIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserAgent);
		}
#pragma warning restore 0169

		static IntPtr id_getUserAgent;
		public virtual string UserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='UserAgentIdentifier']/method[@name='getUserAgent' and count(parameter)=0]"
			[Register ("getUserAgent", "()Ljava/lang/String;", "GetGetUserAgentHandler")]
			get {
				if (id_getUserAgent == IntPtr.Zero)
					id_getUserAgent = JNIEnv.GetMethodID (class_ref, "getUserAgent", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserAgent), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUserAgent), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
