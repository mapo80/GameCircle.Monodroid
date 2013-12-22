using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/ReportEventHandler", DoNotGenerateAcw=true)]
	public partial class ReportEventHandler : global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler.HandlerReply']"
		[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/ReportEventHandler$HandlerReply", DoNotGenerateAcw=true)]
		protected internal partial class HandlerReply : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/ReportEventHandler$HandlerReply", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HandlerReply); }
			}

			protected HandlerReply (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_amazon_ags_html5_javascript_ReportEventHandler_Lorg_json_JSONObject_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler.HandlerReply']/constructor[@name='ReportEventHandler.HandlerReply' and count(parameter)=3 and parameter[1][@type='com.amazon.ags.html5.javascript.ReportEventHandler'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/amazon/ags/html5/javascript/ReportEventHandler;Lorg/json/JSONObject;Ljava/lang/String;)V", "")]
			public HandlerReply (global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler __self, global::Org.Json.JSONObject p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (HandlerReply)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/json/JSONObject;Ljava/lang/String;)V", new JValue (__self), new JValue (p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/json/JSONObject;Ljava/lang/String;)V", new JValue (__self), new JValue (p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Lcom_amazon_ags_html5_javascript_ReportEventHandler_Lorg_json_JSONObject_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_ags_html5_javascript_ReportEventHandler_Lorg_json_JSONObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/html5/javascript/ReportEventHandler;Lorg/json/JSONObject;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_html5_javascript_ReportEventHandler_Lorg_json_JSONObject_Ljava_lang_String_, new JValue (__self), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_html5_javascript_ReportEventHandler_Lorg_json_JSONObject_Ljava_lang_String_, new JValue (__self), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_getReplyMsg;
#pragma warning disable 0169
			static Delegate GetGetReplyMsgHandler ()
			{
				if (cb_getReplyMsg == null)
					cb_getReplyMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReplyMsg);
				return cb_getReplyMsg;
			}

			static IntPtr n_GetReplyMsg (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReplyMsg);
			}
#pragma warning restore 0169

			static IntPtr id_getReplyMsg;
			public virtual global::Org.Json.JSONObject ReplyMsg {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler.HandlerReply']/method[@name='getReplyMsg' and count(parameter)=0]"
				[Register ("getReplyMsg", "()Lorg/json/JSONObject;", "GetGetReplyMsgHandler")]
				get {
					if (id_getReplyMsg == IntPtr.Zero)
						id_getReplyMsg = JNIEnv.GetMethodID (class_ref, "getReplyMsg", "()Lorg/json/JSONObject;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getReplyMsg), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getReplyMsg), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getResult;
#pragma warning disable 0169
			static Delegate GetGetResultHandler ()
			{
				if (cb_getResult == null)
					cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
				return cb_getResult;
			}

			static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Result);
			}
#pragma warning restore 0169

			static IntPtr id_getResult;
			public virtual string Result {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler.HandlerReply']/method[@name='getResult' and count(parameter)=0]"
				[Register ("getResult", "()Ljava/lang/String;", "GetGetResultHandler")]
				get {
					if (id_getResult == IntPtr.Zero)
						id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResult), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/ReportEventHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportEventHandler); }
		}

		protected ReportEventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler']/constructor[@name='ReportEventHandler' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.client.metrics.EventCollectorClient'] and parameter[2][@type='android.os.Handler']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;Landroid/os/Handler;)V", "")]
		public ReportEventHandler (global::Com.Amazon.Ags.Client.Metrics.EventCollectorClient p0, global::Android.OS.Handler p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ReportEventHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/metrics/EventCollectorClient;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/metrics/EventCollectorClient;Landroid/os/Handler;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/metrics/EventCollectorClient;Landroid/os/Handler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_Landroid_os_Handler_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_metrics_EventCollectorClient_Landroid_os_Handler_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static bool n_HandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z", "GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected override bool HandleMessage (string p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_reportEvent_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetReportEvent_Lorg_json_JSONObject_Handler ()
		{
			if (cb_reportEvent_Lorg_json_JSONObject_ == null)
				cb_reportEvent_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportEvent_Lorg_json_JSONObject_);
			return cb_reportEvent_Lorg_json_JSONObject_;
		}

		static IntPtr n_ReportEvent_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReportEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reportEvent_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='ReportEventHandler']/method[@name='reportEvent' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("reportEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/html5/javascript/ReportEventHandler$HandlerReply;", "GetReportEvent_Lorg_json_JSONObject_Handler")]
		protected virtual global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply ReportEvent (global::Org.Json.JSONObject p0)
		{
			if (id_reportEvent_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_reportEvent_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "reportEvent", "(Lorg/json/JSONObject;)Lcom/amazon/ags/html5/javascript/ReportEventHandler$HandlerReply;");

			global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply> (JNIEnv.CallObjectMethod  (Handle, id_reportEvent_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.ReportEventHandler.HandlerReply> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_reportEvent_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
