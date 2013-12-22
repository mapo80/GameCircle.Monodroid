using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireBindingCallback']"
	[Register ("com/amazon/ags/client/KindleFireBindingCallback", "", "Com.Amazon.Ags.Client.IKindleFireBindingCallbackInvoker")]
	public partial interface IKindleFireBindingCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireBindingCallback']/method[@name='onBound' and count(parameter)=0]"
		[Register ("onBound", "()V", "GetOnBoundHandler:Com.Amazon.Ags.Client.IKindleFireBindingCallbackInvoker, GameCircle.MonoDroid")]
		void OnBound ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client']/interface[@name='KindleFireBindingCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.KindleFireStatus']]"
		[Register ("onFailure", "(Lcom/amazon/ags/client/KindleFireStatus;)V", "GetOnFailure_Lcom_amazon_ags_client_KindleFireStatus_Handler:Com.Amazon.Ags.Client.IKindleFireBindingCallbackInvoker, GameCircle.MonoDroid")]
		void OnFailure (global::Com.Amazon.Ags.Client.KindleFireStatus p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/client/KindleFireBindingCallback", DoNotGenerateAcw=true)]
	internal class IKindleFireBindingCallbackInvoker : global::Java.Lang.Object, IKindleFireBindingCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/client/KindleFireBindingCallback");
		IntPtr class_ref;

		public static IKindleFireBindingCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKindleFireBindingCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.client.KindleFireBindingCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKindleFireBindingCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IKindleFireBindingCallbackInvoker); }
		}

		static Delegate cb_onBound;
#pragma warning disable 0169
		static Delegate GetOnBoundHandler ()
		{
			if (cb_onBound == null)
				cb_onBound = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBound);
			return cb_onBound;
		}

		static void n_OnBound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.IKindleFireBindingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireBindingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBound ();
		}
#pragma warning restore 0169

		IntPtr id_onBound;
		public void OnBound ()
		{
			if (id_onBound == IntPtr.Zero)
				id_onBound = JNIEnv.GetMethodID (class_ref, "onBound", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBound);
		}

		static Delegate cb_onFailure_Lcom_amazon_ags_client_KindleFireStatus_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_amazon_ags_client_KindleFireStatus_Handler ()
		{
			if (cb_onFailure_Lcom_amazon_ags_client_KindleFireStatus_ == null)
				cb_onFailure_Lcom_amazon_ags_client_KindleFireStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_amazon_ags_client_KindleFireStatus_);
			return cb_onFailure_Lcom_amazon_ags_client_KindleFireStatus_;
		}

		static void n_OnFailure_Lcom_amazon_ags_client_KindleFireStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.IKindleFireBindingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IKindleFireBindingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.KindleFireStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.KindleFireStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_amazon_ags_client_KindleFireStatus_;
		public void OnFailure (global::Com.Amazon.Ags.Client.KindleFireStatus p0)
		{
			if (id_onFailure_Lcom_amazon_ags_client_KindleFireStatus_ == IntPtr.Zero)
				id_onFailure_Lcom_amazon_ags_client_KindleFireStatus_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/amazon/ags/client/KindleFireStatus;)V");
			JNIEnv.CallVoidMethod (Handle, id_onFailure_Lcom_amazon_ags_client_KindleFireStatus_, new JValue (p0));
		}

	}

}
