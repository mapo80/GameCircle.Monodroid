using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']"
	[Register ("com/amazon/ags/html5/overlay/toasts/ClickableToast", "", "Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker")]
	public partial interface IClickableToast : IJavaObject {

		bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='addClickableToastObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.overlay.toasts.ClickableToastObserver']]"
		[Register ("addClickableToastObserver", "(Lcom/amazon/ags/html5/overlay/toasts/ClickableToastObserver;)V", "GetAddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_Handler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void AddClickableToastObserver (global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='setToastData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToastData", "(Ljava/lang/String;)V", "GetSetToastData_Ljava_lang_String_Handler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void SetToastData (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='setToastOnTouchListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnTouchListener']]"
		[Register ("setToastOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", "GetSetToastOnTouchListener_Landroid_view_View_OnTouchListener_Handler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void SetToastOnTouchListener (global::Android.Views.View.IOnTouchListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("show", "(Landroid/os/Handler;)V", "GetShow_Landroid_os_Handler_Handler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void Show (global::Android.OS.Handler p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/interface[@name='ClickableToast']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("update", "(Ljava/lang/String;I)V", "GetUpdate_Ljava_lang_String_IHandler:Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastInvoker, GameCircle.MonoDroid")]
		void Update (string p0, int p1);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToast", DoNotGenerateAcw=true)]
	internal class IClickableToastInvoker : global::Java.Lang.Object, IClickableToast {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToast");
		IntPtr class_ref;

		public static IClickableToast GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClickableToast> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.overlay.toasts.ClickableToast"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClickableToastInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IClickableToastInvoker); }
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		IntPtr id_isShowing;
		public bool IsShowing {
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isShowing);
			}
		}

		static Delegate cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
#pragma warning disable 0169
		static Delegate GetAddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_Handler ()
		{
			if (cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ == null)
				cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_);
			return cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
		}

		static void n_AddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver p0 = (global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddClickableToastObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
		public void AddClickableToastObserver (global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver p0)
		{
			if (id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ == IntPtr.Zero)
				id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ = JNIEnv.GetMethodID (class_ref, "addClickableToastObserver", "(Lcom/amazon/ags/html5/overlay/toasts/ClickableToastObserver;)V");
			JNIEnv.CallVoidMethod (Handle, id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_, new JValue (p0));
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (Handle, id_destroy);
		}

		static Delegate cb_setToastData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToastData_Ljava_lang_String_Handler ()
		{
			if (cb_setToastData_Ljava_lang_String_ == null)
				cb_setToastData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToastData_Ljava_lang_String_);
			return cb_setToastData_Ljava_lang_String_;
		}

		static void n_SetToastData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetToastData (p0);
		}
#pragma warning restore 0169

		IntPtr id_setToastData_Ljava_lang_String_;
		public void SetToastData (string p0)
		{
			if (id_setToastData_Ljava_lang_String_ == IntPtr.Zero)
				id_setToastData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToastData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setToastData_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetToastOnTouchListener_Landroid_view_View_OnTouchListener_Handler ()
		{
			if (cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ == null)
				cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToastOnTouchListener_Landroid_view_View_OnTouchListener_);
			return cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
		}

		static void n_SetToastOnTouchListener_Landroid_view_View_OnTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnTouchListener p0 = (global::Android.Views.View.IOnTouchListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetToastOnTouchListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
		public void SetToastOnTouchListener (global::Android.Views.View.IOnTouchListener p0)
		{
			if (id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ == IntPtr.Zero)
				id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ = JNIEnv.GetMethodID (class_ref, "setToastOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_, new JValue (p0));
		}

		static Delegate cb_show_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_os_Handler_Handler ()
		{
			if (cb_show_Landroid_os_Handler_ == null)
				cb_show_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Show_Landroid_os_Handler_);
			return cb_show_Landroid_os_Handler_;
		}

		static void n_Show_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0);
		}
#pragma warning restore 0169

		IntPtr id_show_Landroid_os_Handler_;
		public void Show (global::Android.OS.Handler p0)
		{
			if (id_show_Landroid_os_Handler_ == IntPtr.Zero)
				id_show_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/os/Handler;)V");
			JNIEnv.CallVoidMethod (Handle, id_show_Landroid_os_Handler_, new JValue (p0));
		}

		static Delegate cb_update_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_String_IHandler ()
		{
			if (cb_update_Ljava_lang_String_I == null)
				cb_update_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Update_Ljava_lang_String_I);
			return cb_update_Ljava_lang_String_I;
		}

		static void n_Update_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_update_Ljava_lang_String_I;
		public void Update (string p0, int p1)
		{
			if (id_update_Ljava_lang_String_I == IntPtr.Zero)
				id_update_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_update_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
