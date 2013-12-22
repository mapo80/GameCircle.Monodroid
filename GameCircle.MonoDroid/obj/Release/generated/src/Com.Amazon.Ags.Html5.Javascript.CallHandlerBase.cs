using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Javascript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/CallHandlerBase", DoNotGenerateAcw=true)]
	public abstract partial class CallHandlerBase : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/field[@name='TAG']"
		[Register ("TAG")]
		protected string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/javascript/CallHandlerBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallHandlerBase); }
		}

		protected CallHandlerBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_Ljava_util_Set_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/constructor[@name='CallHandlerBase' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.util.Set']]"
		[Register (".ctor", "(Landroid/os/Handler;Ljava/util/Set;)V", "")]
		public CallHandlerBase (global::Android.OS.Handler p0, global::System.Collections.Generic.ICollection<string> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (CallHandlerBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;Ljava/util/Set;)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1))),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;Ljava/util/Set;)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_os_Handler_Ljava_util_Set_ == IntPtr.Zero)
				id_ctor_Landroid_os_Handler_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;Ljava/util/Set;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_Ljava_util_Set_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1))),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_Ljava_util_Set_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getSupportedMessages;
#pragma warning disable 0169
		static Delegate GetGetSupportedMessagesHandler ()
		{
			if (cb_getSupportedMessages == null)
				cb_getSupportedMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedMessages);
			return cb_getSupportedMessages;
		}

		static IntPtr n_GetSupportedMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.SupportedMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedMessages;
		public virtual global::System.Collections.Generic.ICollection<string> SupportedMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='getSupportedMessages' and count(parameter)=0]"
			[Register ("getSupportedMessages", "()Ljava/util/Set;", "GetGetSupportedMessagesHandler")]
			get {
				if (id_getSupportedMessages == IntPtr.Zero)
					id_getSupportedMessages = JNIEnv.GetMethodID (class_ref, "getSupportedMessages", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSupportedMessages), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSupportedMessages), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_Handler ()
		{
			if (cb_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_ == null)
				cb_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_);
			return cb_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_;
		}

		static bool n_HandleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='com.amazon.ags.html5.javascript.domain.JavascriptInterface'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lorg/json/JSONObject;)Z", "GetHandleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_Handler")]
		public virtual bool HandleMessage (global::Com.Amazon.Ags.Html5.Javascript.Domain.JavascriptInterface p0, global::Org.Json.JSONObject p1)
		{
			if (id_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Lcom/amazon/ags/html5/javascript/domain/JavascriptInterface;Lorg/json/JSONObject;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_handleMessage_Lcom_amazon_ags_html5_javascript_domain_JavascriptInterface_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1));
			return __ret;
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
			global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z", "GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected abstract bool HandleMessage (string p0, string p1, global::Org.Json.JSONObject p2);

		static Delegate cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendReply (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='sendReply' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void SendReply (string p0, string p1, string p2)
		{
			if (id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Javascript.CallHandlerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendReply (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='sendReply' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void SendReply (string p0, string p1, string p2, string p3)
		{
			if (id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendReply", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendReply_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/javascript/CallHandlerBase", DoNotGenerateAcw=true)]
	internal partial class CallHandlerBaseInvoker : CallHandlerBase {

		public CallHandlerBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallHandlerBaseInvoker); }
		}

		static IntPtr id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.javascript']/class[@name='CallHandlerBase']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z", "GetHandleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected override bool HandleMessage (string p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
