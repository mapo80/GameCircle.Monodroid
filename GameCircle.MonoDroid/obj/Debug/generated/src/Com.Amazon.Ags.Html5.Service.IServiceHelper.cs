using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.service']/interface[@name='ServiceHelper']"
	[Register ("com/amazon/ags/html5/service/ServiceHelper", "", "Com.Amazon.Ags.Html5.Service.IServiceHelperInvoker")]
	public partial interface IServiceHelper : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.service']/interface[@name='ServiceHelper']/method[@name='handleRequestAsync' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.JSONRequest']]"
		[Register ("handleRequestAsync", "(Lcom/amazon/ags/client/JSONRequest;)V", "GetHandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_Handler:Com.Amazon.Ags.Html5.Service.IServiceHelperInvoker, GameCircle.MonoDroid")]
		void HandleRequestAsync (global::Com.Amazon.Ags.Client.IJSONRequest p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/service/ServiceHelper", DoNotGenerateAcw=true)]
	internal class IServiceHelperInvoker : global::Java.Lang.Object, IServiceHelper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/service/ServiceHelper");
		IntPtr class_ref;

		public static IServiceHelper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServiceHelper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.service.ServiceHelper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServiceHelperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IServiceHelperInvoker); }
		}

		static Delegate cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
#pragma warning disable 0169
		static Delegate GetHandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_Handler ()
		{
			if (cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ == null)
				cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_);
			return cb_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
		}

		static void n_HandleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Service.IServiceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Service.IServiceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.IJSONRequest p0 = (global::Com.Amazon.Ags.Client.IJSONRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.IJSONRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleRequestAsync (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_;
		public void HandleRequestAsync (global::Com.Amazon.Ags.Client.IJSONRequest p0)
		{
			if (id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ == IntPtr.Zero)
				id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_ = JNIEnv.GetMethodID (class_ref, "handleRequestAsync", "(Lcom/amazon/ags/client/JSONRequest;)V");
			JNIEnv.CallVoidMethod (Handle, id_handleRequestAsync_Lcom_amazon_ags_client_JSONRequest_, new JValue (p0));
		}

	}

}
