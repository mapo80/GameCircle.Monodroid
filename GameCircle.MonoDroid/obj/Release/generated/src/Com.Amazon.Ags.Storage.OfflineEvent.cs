using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEvent']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEvent", DoNotGenerateAcw=true)]
	public partial class OfflineEvent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEvent']/field[@name='KEY_EVENT_TIME']"
		[Register ("KEY_EVENT_TIME")]
		public const string KeyEventTime = (string) "eventTime";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineEvent); }
		}

		protected OfflineEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEvent']/constructor[@name='OfflineEvent' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public OfflineEvent (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OfflineEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0));
		}

		static Delegate cb_getEventTime;
#pragma warning disable 0169
		static Delegate GetGetEventTimeHandler ()
		{
			if (cb_getEventTime == null)
				cb_getEventTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventTime);
			return cb_getEventTime;
		}

		static IntPtr n_GetEventTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventTime);
		}
#pragma warning restore 0169

		static IntPtr id_getEventTime;
		public virtual global::Java.Util.Date EventTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEvent']/method[@name='getEventTime' and count(parameter)=0]"
			[Register ("getEventTime", "()Ljava/util/Date;", "GetGetEventTimeHandler")]
			get {
				if (id_getEventTime == IntPtr.Zero)
					id_getEventTime = JNIEnv.GetMethodID (class_ref, "getEventTime", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getEventTime), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEventTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEvent']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public virtual global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toJson), JniHandleOwnership.TransferLocalRef);
		}

	}
}
