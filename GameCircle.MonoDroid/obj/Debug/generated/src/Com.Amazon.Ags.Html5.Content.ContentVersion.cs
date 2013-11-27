using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/content/ContentVersion", DoNotGenerateAcw=true)]
	public partial class ContentVersion : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/content/ContentVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentVersion); }
		}

		protected ContentVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/constructor[@name='ContentVersion' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public ContentVersion (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContentVersion)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/constructor[@name='ContentVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ContentVersion (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ContentVersion)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MajorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMajorVersion;
		public virtual int MajorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='getMajorVersion' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMinorVersion;
		public virtual int MinorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='getMinorVersion' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PatchVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getPatchVersion;
		public virtual int PatchVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='getPatchVersion' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='getVersion' and count(parameter)=0]"
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

		static Delegate cb_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_ags_html5_content_ContentVersion_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_ == null)
				cb_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_ags_html5_content_ContentVersion_);
			return cb_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_;
		}

		static int n_CompareTo_Lcom_amazon_ags_html5_content_ContentVersion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Content.ContentVersion p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.content.ContentVersion']]"
		[Register ("compareTo", "(Lcom/amazon/ags/html5/content/ContentVersion;)I", "GetCompareTo_Lcom_amazon_ags_html5_content_ContentVersion_Handler")]
		public virtual int CompareTo (global::Java.Lang.Object p0)
		{
			if (id_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/ags/html5/content/ContentVersion;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_compareTo_Lcom_amazon_ags_html5_content_ContentVersion_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_createVersionFromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentVersion']/method[@name='createVersionFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createVersionFromFile", "(Ljava/lang/String;)Lcom/amazon/ags/html5/content/ContentVersion;", "")]
		public static global::Com.Amazon.Ags.Html5.Content.ContentVersion CreateVersionFromFile (string p0)
		{
			if (id_createVersionFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createVersionFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createVersionFromFile", "(Ljava/lang/String;)Lcom/amazon/ags/html5/content/ContentVersion;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Html5.Content.ContentVersion __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createVersionFromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
