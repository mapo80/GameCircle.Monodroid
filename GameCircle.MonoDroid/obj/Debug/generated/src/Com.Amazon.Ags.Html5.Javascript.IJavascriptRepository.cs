using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/interface[@name='JavascriptRepository']"
	[Register ("com/amazon/ags/html5/javascript/JavascriptRepository", "", "Com.Amazon.Ags.Html5.Javascript.IJavascriptRepositoryInvoker")]
	public partial interface IJavascriptRepository : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/interface[@name='JavascriptRepository']/method[@name='loadBackgroundJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadBackgroundJavascript", "(Landroid/webkit/WebView;)V", "GetLoadBackgroundJavascript_Landroid_webkit_WebView_Handler:Com.Amazon.Ags.Html5.Javascript.IJavascriptRepositoryInvoker, GameCircle.MonoDroid")]
		void LoadBackgroundJavascript (global::Android.Webkit.WebView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/interface[@name='JavascriptRepository']/method[@name='loadOverlayJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadOverlayJavascript", "(Landroid/webkit/WebView;)V", "GetLoadOverlayJavascript_Landroid_webkit_WebView_Handler:Com.Amazon.Ags.Html5.Javascript.IJavascriptRepositoryInvoker, GameCircle.MonoDroid")]
		void LoadOverlayJavascript (global::Android.Webkit.WebView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/interface[@name='JavascriptRepository']/method[@name='loadToastJavascript' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("loadToastJavascript", "(Landroid/webkit/WebView;)V", "GetLoadToastJavascript_Landroid_webkit_WebView_Handler:Com.Amazon.Ags.Html5.Javascript.IJavascriptRepositoryInvoker, GameCircle.MonoDroid")]
		void LoadToastJavascript (global::Android.Webkit.WebView p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/JavascriptRepository", DoNotGenerateAcw=true)]
	internal class IJavascriptRepositoryInvoker : global::Java.Lang.Object, IJavascriptRepository {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/javascript/JavascriptRepository");
		IntPtr class_ref;

		public static IJavascriptRepository GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJavascriptRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.javascript.JavascriptRepository"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJavascriptRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJavascriptRepositoryInvoker); }
		}

		static Delegate cb_loadBackgroundJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadBackgroundJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadBackgroundJavascript_Landroid_webkit_WebView_ == null)
				cb_loadBackgroundJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadBackgroundJavascript_Landroid_webkit_WebView_);
			return cb_loadBackgroundJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadBackgroundJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadBackgroundJavascript (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadBackgroundJavascript_Landroid_webkit_WebView_;
		public void LoadBackgroundJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadBackgroundJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadBackgroundJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadBackgroundJavascript", "(Landroid/webkit/WebView;)V");
			JNIEnv.CallVoidMethod (Handle, id_loadBackgroundJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

		static Delegate cb_loadOverlayJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadOverlayJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadOverlayJavascript_Landroid_webkit_WebView_ == null)
				cb_loadOverlayJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadOverlayJavascript_Landroid_webkit_WebView_);
			return cb_loadOverlayJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadOverlayJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadOverlayJavascript (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadOverlayJavascript_Landroid_webkit_WebView_;
		public void LoadOverlayJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadOverlayJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadOverlayJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadOverlayJavascript", "(Landroid/webkit/WebView;)V");
			JNIEnv.CallVoidMethod (Handle, id_loadOverlayJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

		static Delegate cb_loadToastJavascript_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetLoadToastJavascript_Landroid_webkit_WebView_Handler ()
		{
			if (cb_loadToastJavascript_Landroid_webkit_WebView_ == null)
				cb_loadToastJavascript_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadToastJavascript_Landroid_webkit_WebView_);
			return cb_loadToastJavascript_Landroid_webkit_WebView_;
		}

		static void n_LoadToastJavascript_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.IJavascriptRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadToastJavascript (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadToastJavascript_Landroid_webkit_WebView_;
		public void LoadToastJavascript (global::Android.Webkit.WebView p0)
		{
			if (id_loadToastJavascript_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_loadToastJavascript_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "loadToastJavascript", "(Landroid/webkit/WebView;)V");
			JNIEnv.CallVoidMethod (Handle, id_loadToastJavascript_Landroid_webkit_WebView_, new JValue (p0));
		}

	}

}
