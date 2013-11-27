using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ImageManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/util/ImageManager", DoNotGenerateAcw=true)]
	public partial class ImageManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/util/ImageManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageManager); }
		}

		protected ImageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_html5_content_ContentManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ImageManager']/constructor[@name='ImageManager' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.content.ContentManager']]"
		[Register (".ctor", "(Lcom/amazon/ags/html5/content/ContentManager;)V", "")]
		public ImageManager (global::Com.Amazon.Ags.Html5.Content.ContentManager p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/html5/content/ContentManager;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/html5/content/ContentManager;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_html5_content_ContentManager_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_html5_content_ContentManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/content/ContentManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_content_ContentManager_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_content_ContentManager_, new JValue (p0));
		}

		static IntPtr id_downloadImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.util']/class[@name='ImageManager']/method[@name='downloadImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("downloadImage", "(Ljava/lang/String;)V", "")]
		public void DownloadImage (string p0)
		{
			if (id_downloadImage_Ljava_lang_String_ == IntPtr.Zero)
				id_downloadImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "downloadImage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_downloadImage_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
