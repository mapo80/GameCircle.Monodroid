using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineCacheRequest']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineCacheRequest", DoNotGenerateAcw=true)]
	public partial class OfflineCacheRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineCacheRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineCacheRequest); }
		}

		protected OfflineCacheRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineCacheRequest']/constructor[@name='OfflineCacheRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public OfflineCacheRequest (string p0, string p1, global::Org.Json.JSONObject p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (OfflineCacheRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getJsonObject;
#pragma warning disable 0169
		static Delegate GetGetJsonObjectHandler ()
		{
			if (cb_getJsonObject == null)
				cb_getJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonObject);
			return cb_getJsonObject;
		}

		static IntPtr n_GetJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineCacheRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsonObject);
		}
#pragma warning restore 0169

		static IntPtr id_getJsonObject;
		public virtual global::Org.Json.JSONObject JsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineCacheRequest']/method[@name='getJsonObject' and count(parameter)=0]"
			[Register ("getJsonObject", "()Lorg/json/JSONObject;", "GetGetJsonObjectHandler")]
			get {
				if (id_getJsonObject == IntPtr.Zero)
					id_getJsonObject = JNIEnv.GetMethodID (class_ref, "getJsonObject", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJsonObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getJsonObject), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrimaryKey;
#pragma warning disable 0169
		static Delegate GetGetPrimaryKeyHandler ()
		{
			if (cb_getPrimaryKey == null)
				cb_getPrimaryKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrimaryKey);
			return cb_getPrimaryKey;
		}

		static IntPtr n_GetPrimaryKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineCacheRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrimaryKey);
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryKey;
		public virtual string PrimaryKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineCacheRequest']/method[@name='getPrimaryKey' and count(parameter)=0]"
			[Register ("getPrimaryKey", "()Ljava/lang/String;", "GetGetPrimaryKeyHandler")]
			get {
				if (id_getPrimaryKey == IntPtr.Zero)
					id_getPrimaryKey = JNIEnv.GetMethodID (class_ref, "getPrimaryKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrimaryKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPrimaryKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSecondaryKey;
#pragma warning disable 0169
		static Delegate GetGetSecondaryKeyHandler ()
		{
			if (cb_getSecondaryKey == null)
				cb_getSecondaryKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondaryKey);
			return cb_getSecondaryKey;
		}

		static IntPtr n_GetSecondaryKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineCacheRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineCacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondaryKey);
		}
#pragma warning restore 0169

		static IntPtr id_getSecondaryKey;
		public virtual string SecondaryKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineCacheRequest']/method[@name='getSecondaryKey' and count(parameter)=0]"
			[Register ("getSecondaryKey", "()Ljava/lang/String;", "GetGetSecondaryKeyHandler")]
			get {
				if (id_getSecondaryKey == IntPtr.Zero)
					id_getSecondaryKey = JNIEnv.GetMethodID (class_ref, "getSecondaryKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecondaryKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSecondaryKey), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
