using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.comm']/interface[@name='NetworkClient']"
	[Register ("com/amazon/ags/html5/comm/NetworkClient", "", "Com.Amazon.Ags.Html5.Comm.INetworkClientInvoker")]
	public partial interface INetworkClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/interface[@name='NetworkClient']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.comm.ServiceRequestBase']]"
		[Register ("execute", "(Lcom/amazon/ags/html5/comm/ServiceRequestBase;)Lcom/amazon/ags/html5/comm/ServiceResponse;", "GetExecute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_Handler:Com.Amazon.Ags.Html5.Comm.INetworkClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Html5.Comm.ServiceResponse Execute (global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/NetworkClient", DoNotGenerateAcw=true)]
	internal class INetworkClientInvoker : global::Java.Lang.Object, INetworkClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/comm/NetworkClient");
		IntPtr class_ref;

		public static INetworkClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.comm.NetworkClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (INetworkClientInvoker); }
		}

		static Delegate cb_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_Handler ()
		{
			if (cb_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ == null)
				cb_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_);
			return cb_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_;
		}

		static IntPtr n_Execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Comm.INetworkClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.INetworkClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_;
		public global::Com.Amazon.Ags.Html5.Comm.ServiceResponse Execute (global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase p0)
		{
			if (id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ == IntPtr.Zero)
				id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/amazon/ags/html5/comm/ServiceRequestBase;)Lcom/amazon/ags/html5/comm/ServiceResponse;");
			global::Com.Amazon.Ags.Html5.Comm.ServiceResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.ServiceResponse> (JNIEnv.CallObjectMethod (Handle, id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
