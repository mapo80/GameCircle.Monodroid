using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.amazon.insights.core.system.amazon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='AppDetails']"
	[Register ("com/amazon/insights/core/system/AppDetails", "", "com.amazon.insights.core.system.amazon.IAppDetailsInvoker")]
	public partial interface IAppDetails : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='AppDetails']/method[@name='packageName' and count(parameter)=0]"
		[Register ("packageName", "()Ljava/lang/String;", "GetPackageNameHandler:com.amazon.insights.core.system.amazon.IAppDetailsInvoker, AmazonInsights.MonoDroid")]
		string PackageName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='AppDetails']/method[@name='signatures' and count(parameter)=0]"
		[Register ("signatures", "()[Ljava/lang/String;", "GetSignaturesHandler:com.amazon.insights.core.system.amazon.IAppDetailsInvoker, AmazonInsights.MonoDroid")]
		string[] Signatures ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='AppDetails']/method[@name='versionCode' and count(parameter)=0]"
		[Register ("versionCode", "()Ljava/lang/String;", "GetVersionCodeHandler:com.amazon.insights.core.system.amazon.IAppDetailsInvoker, AmazonInsights.MonoDroid")]
		string VersionCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.core.system']/interface[@name='AppDetails']/method[@name='versionName' and count(parameter)=0]"
		[Register ("versionName", "()Ljava/lang/String;", "GetVersionNameHandler:com.amazon.insights.core.system.amazon.IAppDetailsInvoker, AmazonInsights.MonoDroid")]
		string VersionName ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/core/system/AppDetails", DoNotGenerateAcw=true)]
	internal class IAppDetailsInvoker : global::Java.Lang.Object, IAppDetails {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/core/system/AppDetails");
		IntPtr class_ref;

		public static IAppDetails GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppDetails> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.core.system.AppDetails"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppDetailsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAppDetailsInvoker); }
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
			global::com.amazon.insights.core.system.amazon.IAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName ());
		}
#pragma warning restore 0169

		IntPtr id_packageName;
		public string PackageName ()
		{
			if (id_packageName == IntPtr.Zero)
				id_packageName = JNIEnv.GetMethodID (class_ref, "packageName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_packageName), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Signatures ());
		}
#pragma warning restore 0169

		IntPtr id_signatures;
		public string[] Signatures ()
		{
			if (id_signatures == IntPtr.Zero)
				id_signatures = JNIEnv.GetMethodID (class_ref, "signatures", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_signatures), JniHandleOwnership.TransferLocalRef, typeof (string));
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
			global::com.amazon.insights.core.system.amazon.IAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionCode ());
		}
#pragma warning restore 0169

		IntPtr id_versionCode;
		public string VersionCode ()
		{
			if (id_versionCode == IntPtr.Zero)
				id_versionCode = JNIEnv.GetMethodID (class_ref, "versionCode", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_versionCode), JniHandleOwnership.TransferLocalRef);
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
			global::com.amazon.insights.core.system.amazon.IAppDetails __this = global::Java.Lang.Object.GetObject<global::com.amazon.insights.core.system.amazon.IAppDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName ());
		}
#pragma warning restore 0169

		IntPtr id_versionName;
		public string VersionName ()
		{
			if (id_versionName == IntPtr.Zero)
				id_versionName = JNIEnv.GetMethodID (class_ref, "versionName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_versionName), JniHandleOwnership.TransferLocalRef);
		}

	}

}
