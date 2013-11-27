using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']"
	[global::Android.Runtime.Register ("com/amazon/ags/constants/AuthorizeKeys", DoNotGenerateAcw=true)]
	public partial class AuthorizeKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']/field[@name='AUTHORIZED']"
		[Register ("AUTHORIZED")]
		public const string Authorized = (string) "AUTHORIZED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']/field[@name='CANNOT_AUTHORIZE']"
		[Register ("CANNOT_AUTHORIZE")]
		public const string CannotAuthorize = (string) "CANNOT_AUTHORIZE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']/field[@name='INVALID_SESSION']"
		[Register ("INVALID_SESSION")]
		public const string InvalidSession = (string) "INVALID_SESSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']/field[@name='NOT_AUTHORIZED']"
		[Register ("NOT_AUTHORIZED")]
		public const string NotAuthorized = (string) "NOT_AUTHORIZED";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/constants/AuthorizeKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizeKeys); }
		}

		protected AuthorizeKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.constants']/class[@name='AuthorizeKeys']/constructor[@name='AuthorizeKeys' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthorizeKeys () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthorizeKeys)) {
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
