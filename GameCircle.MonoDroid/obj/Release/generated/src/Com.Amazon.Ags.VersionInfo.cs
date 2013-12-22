using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']"
	[global::Android.Runtime.Register ("com/amazon/ags/VersionInfo", DoNotGenerateAcw=true)]
	public partial class VersionInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/VersionInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionInfo); }
		}

		protected VersionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/constructor[@name='VersionInfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public VersionInfo (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VersionInfo)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_III == IntPtr.Zero)
				id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getMajorVersion;
#pragma warning disable 0169
		static Delegate GetGetMajorVersionHandler ()
		{
			if (cb_getMajorVersion == null)
				cb_getMajorVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMajorVersion);
			return cb_getMajorVersion;
		}

		static int n_GetMajorVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.VersionInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.VersionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MajorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMajorVersion;
		public virtual int MajorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/method[@name='getMajorVersion' and count(parameter)=0]"
			[Register ("getMajorVersion", "()I", "GetGetMajorVersionHandler")]
			get {
				if (id_getMajorVersion == IntPtr.Zero)
					id_getMajorVersion = JNIEnv.GetMethodID (class_ref, "getMajorVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMajorVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getMajorVersion);
			}
		}

		static Delegate cb_getMinorVersion;
#pragma warning disable 0169
		static Delegate GetGetMinorVersionHandler ()
		{
			if (cb_getMinorVersion == null)
				cb_getMinorVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinorVersion);
			return cb_getMinorVersion;
		}

		static int n_GetMinorVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.VersionInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.VersionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMinorVersion;
		public virtual int MinorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/method[@name='getMinorVersion' and count(parameter)=0]"
			[Register ("getMinorVersion", "()I", "GetGetMinorVersionHandler")]
			get {
				if (id_getMinorVersion == IntPtr.Zero)
					id_getMinorVersion = JNIEnv.GetMethodID (class_ref, "getMinorVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinorVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getMinorVersion);
			}
		}

		static Delegate cb_getPatchVersion;
#pragma warning disable 0169
		static Delegate GetGetPatchVersionHandler ()
		{
			if (cb_getPatchVersion == null)
				cb_getPatchVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPatchVersion);
			return cb_getPatchVersion;
		}

		static int n_GetPatchVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.VersionInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.VersionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PatchVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getPatchVersion;
		public virtual int PatchVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/method[@name='getPatchVersion' and count(parameter)=0]"
			[Register ("getPatchVersion", "()I", "GetGetPatchVersionHandler")]
			get {
				if (id_getPatchVersion == IntPtr.Zero)
					id_getPatchVersion = JNIEnv.GetMethodID (class_ref, "getPatchVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPatchVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getPatchVersion);
			}
		}

		static IntPtr id_getSDKVersion;
		public static global::Com.Amazon.Ags.VersionInfo SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Lcom/amazon/ags/VersionInfo;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getSDKVersion", "()Lcom/amazon/ags/VersionInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.VersionInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.VersionInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.VersionInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags']/class[@name='VersionInfo']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
