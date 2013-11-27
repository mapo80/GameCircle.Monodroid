using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']"
	[global::Android.Runtime.Register ("com/amazon/insights/core/system/AndroidAppDetails", DoNotGenerateAcw=true)]
	public partial class AndroidAppDetails : global::Java.Lang.Object, global::com.amazon.insights.core.system.amazon.IAppDetails {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/insights/core/system/AndroidAppDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidAppDetails); }
		}

		protected AndroidAppDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']/constructor[@name='AndroidAppDetails' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public AndroidAppDetails (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AndroidAppDetails)) {
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

		static Delegate cb_packageName;
#pragma warning disable 0169
		static Delegate GetPackageNameHandler ()
		{
			if (cb_packageName == null)
				cb_packageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PackageName);
			return cb_packageName;
		}

		static IntPtr n_PackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName ());
		}
#pragma warning restore 0169

		static IntPtr id_packageName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']/method[@name='packageName' and count(parameter)=0]"
		[Register ("packageName", "()Ljava/lang/String;", "GetPackageNameHandler")]
		public virtual string PackageName ()
		{
			if (id_packageName == IntPtr.Zero)
				id_packageName = JNIEnv.GetMethodID (class_ref, "packageName", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_packageName), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_packageName), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_signatures;
#pragma warning disable 0169
		static Delegate GetSignaturesHandler ()
		{
			if (cb_signatures == null)
				cb_signatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Signatures);
			return cb_signatures;
		}

		static IntPtr n_Signatures (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Signatures ());
		}
#pragma warning restore 0169

		static IntPtr id_signatures;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']/method[@name='signatures' and count(parameter)=0]"
		[Register ("signatures", "()[Ljava/lang/String;", "GetSignaturesHandler")]
		public virtual string[] Signatures ()
		{
			if (id_signatures == IntPtr.Zero)
				id_signatures = JNIEnv.GetMethodID (class_ref, "signatures", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_signatures), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_signatures), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_versionCode;
#pragma warning disable 0169
		static Delegate GetVersionCodeHandler ()
		{
			if (cb_versionCode == null)
				cb_versionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_VersionCode);
			return cb_versionCode;
		}

		static IntPtr n_VersionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionCode ());
		}
#pragma warning restore 0169

		static IntPtr id_versionCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']/method[@name='versionCode' and count(parameter)=0]"
		[Register ("versionCode", "()Ljava/lang/String;", "GetVersionCodeHandler")]
		public virtual string VersionCode ()
		{
			if (id_versionCode == IntPtr.Zero)
				id_versionCode = JNIEnv.GetMethodID (class_ref, "versionCode", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_versionCode), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_versionCode), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_versionName;
#pragma warning disable 0169
		static Delegate GetVersionNameHandler ()
		{
			if (cb_versionName == null)
				cb_versionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_VersionName);
			return cb_versionName;
		}

		static IntPtr n_VersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::com.amazon.insights.core.system.amazon.AndroidAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.AndroidAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName ());
		}
#pragma warning restore 0169

		static IntPtr id_versionName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/class[@name='AndroidAppDetails']/method[@name='versionName' and count(parameter)=0]"
		[Register ("versionName", "()Ljava/lang/String;", "GetVersionNameHandler")]
		public virtual string VersionName ()
		{
			if (id_versionName == IntPtr.Zero)
				id_versionName = JNIEnv.GetMethodID (class_ref, "versionName", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_versionName), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_versionName), JniHandleOwnership.TransferLocalRef);
		}

	}
}
