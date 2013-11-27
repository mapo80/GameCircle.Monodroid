using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='HttpNetworkClient']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/comm/HttpNetworkClient", DoNotGenerateAcw=true)]
	public partial class HttpNetworkClient : global::Java.Lang.Object, global::Com.Amazon.Ags.Html5.Comm.INetworkClient {


		static IntPtr DEVICE_SERIAL_NUMBER_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='HttpNetworkClient']/field[@name='DEVICE_SERIAL_NUMBER_HEADER']"
		[Register ("DEVICE_SERIAL_NUMBER_HEADER")]
		public static string DeviceSerialNumberHeader {
			get {
				if (DEVICE_SERIAL_NUMBER_HEADER_jfieldId == IntPtr.Zero)
					DEVICE_SERIAL_NUMBER_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_SERIAL_NUMBER_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_SERIAL_NUMBER_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVICE_SERIAL_NUMBER_HEADER_jfieldId == IntPtr.Zero)
					DEVICE_SERIAL_NUMBER_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_SERIAL_NUMBER_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DEVICE_SERIAL_NUMBER_HEADER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/comm/HttpNetworkClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpNetworkClient); }
		}

		protected HttpNetworkClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='HttpNetworkClient']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.comm.ServiceRequestBase']]"
		[Register ("execute", "(Lcom/amazon/ags/html5/comm/ServiceRequestBase;)Lcom/amazon/ags/html5/comm/ServiceResponse;", "")]
		public global::Com.Amazon.Ags.Html5.Comm.ServiceResponse Execute (global::Com.Amazon.Ags.Html5.Comm.ServiceRequestBase p0)
		{
			if (id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ == IntPtr.Zero)
				id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/amazon/ags/html5/comm/ServiceRequestBase;)Lcom/amazon/ags/html5/comm/ServiceResponse;");
			global::Com.Amazon.Ags.Html5.Comm.ServiceResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.ServiceResponse> (JNIEnv.CallObjectMethod  (Handle, id_execute_Lcom_amazon_ags_html5_comm_ServiceRequestBase_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr, int, IntPtr>) n_ReportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_);
			return cb_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_ReportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Amazon.Ags.Html5.Comm.HttpNetworkClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Comm.HttpNetworkClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.ReportServiceCall (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.comm']/class[@name='HttpNetworkClient']/method[@name='reportServiceCall' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("reportServiceCall", "(JLjava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "GetReportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler")]
		protected virtual void ReportServiceCall (long p0, string p1, string p2, int p3, string p4)
		{
			if (id_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reportServiceCall", "(JLjava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reportServiceCall_JLjava_lang_String_Ljava_lang_String_ILjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}
}
