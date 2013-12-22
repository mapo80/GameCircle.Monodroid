using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEventPoster']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/WhispersyncEventPoster", DoNotGenerateAcw=true)]
	public partial class WhispersyncEventPoster : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/WhispersyncEventPoster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncEventPoster); }
		}

		protected WhispersyncEventPoster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEventPoster']/constructor[@name='WhispersyncEventPoster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WhispersyncEventPoster () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncEventPoster)) {
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

		static Delegate cb_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_;
#pragma warning disable 0169
		static Delegate GetPostEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_Handler ()
		{
			if (cb_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_ == null)
				cb_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_);
			return cb_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_;
		}

		static void n_PostEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEventPoster']/method[@name='postEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.WhispersyncEvent']]"
		[Register ("postEvent", "(Lcom/amazon/ags/client/whispersync/WhispersyncEvent;)V", "GetPostEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_Handler")]
		public virtual void PostEvent (global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEvent p0)
		{
			if (id_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_ == IntPtr.Zero)
				id_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_ = JNIEnv.GetMethodID (class_ref, "postEvent", "(Lcom/amazon/ags/client/whispersync/WhispersyncEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_postEvent_Lcom_amazon_ags_client_whispersync_WhispersyncEvent_, new JValue (p0));
		}

		static Delegate cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
#pragma warning disable 0169
		static Delegate GetSetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_Handler ()
		{
			if (cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ == null)
				cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_);
			return cb_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
		}

		static void n_SetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.WhispersyncEventPoster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWhispersyncEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='WhispersyncEventPoster']/method[@name='setWhispersyncEventListener' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.whispersync.WhispersyncEventListener']]"
		[Register ("setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V", "GetSetWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_Handler")]
		public virtual void SetWhispersyncEventListener (global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener p0)
		{
			if (id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ == IntPtr.Zero)
				id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_ = JNIEnv.GetMethodID (class_ref, "setWhispersyncEventListener", "(Lcom/amazon/ags/api/whispersync/WhispersyncEventListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setWhispersyncEventListener_Lcom_amazon_ags_api_whispersync_WhispersyncEventListener_, new JValue (p0));
		}

	}
}
