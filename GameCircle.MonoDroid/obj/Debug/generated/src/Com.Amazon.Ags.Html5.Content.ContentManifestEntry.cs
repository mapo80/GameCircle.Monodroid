using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/content/ContentManifestEntry", DoNotGenerateAcw=true)]
	public partial class ContentManifestEntry : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/content/ContentManifestEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentManifestEntry); }
		}

		protected ContentManifestEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_content_ContentVersion_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']/constructor[@name='ContentManifestEntry' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.html5.content.ContentVersion'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/content/ContentVersion;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public ContentManifestEntry (global::Com.Amazon.Ags.Html5.Content.ContentVersion p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (ContentManifestEntry)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/content/ContentVersion;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/content/ContentVersion;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_content_ContentVersion_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_content_ContentVersion_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/content/ContentVersion;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_content_ContentVersion_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_content_ContentVersion_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getChecksum;
#pragma warning disable 0169
		static Delegate GetGetChecksumHandler ()
		{
			if (cb_getChecksum == null)
				cb_getChecksum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChecksum);
			return cb_getChecksum;
		}

		static IntPtr n_GetChecksum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Checksum);
		}
#pragma warning restore 0169

		static IntPtr id_getChecksum;
		public virtual string Checksum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']/method[@name='getChecksum' and count(parameter)=0]"
			[Register ("getChecksum", "()Ljava/lang/String;", "GetGetChecksumHandler")]
			get {
				if (id_getChecksum == IntPtr.Zero)
					id_getChecksum = JNIEnv.GetMethodID (class_ref, "getChecksum", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getChecksum), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getChecksum), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentURL;
#pragma warning disable 0169
		static Delegate GetGetContentURLHandler ()
		{
			if (cb_getContentURL == null)
				cb_getContentURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentURL);
			return cb_getContentURL;
		}

		static IntPtr n_GetContentURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentURL);
		}
#pragma warning restore 0169

		static IntPtr id_getContentURL;
		public virtual string ContentURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']/method[@name='getContentURL' and count(parameter)=0]"
			[Register ("getContentURL", "()Ljava/lang/String;", "GetGetContentURLHandler")]
			get {
				if (id_getContentURL == IntPtr.Zero)
					id_getContentURL = JNIEnv.GetMethodID (class_ref, "getContentURL", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getContentURL), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual global::Com.Amazon.Ags.Html5.Content.ContentVersion Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Lcom/amazon/ags/html5/content/ContentVersion;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.ContentVersion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createManifestEntriesFromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='ContentManifestEntry']/method[@name='createManifestEntriesFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createManifestEntriesFromFile", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry> CreateManifestEntriesFromFile (string p0)
		{
			if (id_createManifestEntriesFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createManifestEntriesFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createManifestEntriesFromFile", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IDictionary<string, global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry> __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Amazon.Ags.Html5.Content.ContentManifestEntry>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_createManifestEntriesFromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
