using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/metrics/WhispersyncMetricsFactory", DoNotGenerateAcw=true)]
	public partial class WhispersyncMetricsFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/metrics/WhispersyncMetricsFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncMetricsFactory); }
		}

		protected WhispersyncMetricsFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/constructor[@name='WhispersyncMetricsFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WhispersyncMetricsFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncMetricsFactory)) {
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

		static IntPtr id_createBooleanCountEvent_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createBooleanCountEvent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("createBooleanCountEvent", "(Ljava/lang/String;IZ)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateBooleanCountEvent (string p0, int p1, bool p2)
		{
			if (id_createBooleanCountEvent_Ljava_lang_String_IZ == IntPtr.Zero)
				id_createBooleanCountEvent_Ljava_lang_String_IZ = JNIEnv.GetStaticMethodID (class_ref, "createBooleanCountEvent", "(Ljava/lang/String;IZ)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBooleanCountEvent_Ljava_lang_String_IZ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createBooleanGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createBooleanGenericEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.Boolean']]"
		[Register ("createBooleanGenericEvent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/Boolean;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateBooleanGenericEvent (string p0, global::Java.Lang.Integer p1, global::Java.Lang.Long p2, global::Java.Lang.Boolean p3)
		{
			if (id_createBooleanGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_createBooleanGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "createBooleanGenericEvent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/Boolean;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBooleanGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Ljava_lang_Boolean_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createCountEvent_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createCountEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createCountEvent", "(Ljava/lang/String;I)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateCountEvent (string p0, int p1)
		{
			if (id_createCountEvent_Ljava_lang_String_I == IntPtr.Zero)
				id_createCountEvent_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "createCountEvent", "(Ljava/lang/String;I)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCountEvent_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createGenericEvent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Long']]"
		[Register ("createGenericEvent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateGenericEvent (string p0, global::Java.Lang.Integer p1, global::Java.Lang.Long p2)
		{
			if (id_createGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_ == IntPtr.Zero)
				id_createGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "createGenericEvent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createGenericEvent_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createSyncableTypeEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createSyncableTypeEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.client.whispersync.model.SyncableType']]"
		[Register ("createSyncableTypeEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateSyncableTypeEvent (string p0, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType p1)
		{
			if (id_createSyncableTypeEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ == IntPtr.Zero)
				id_createSyncableTypeEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ = JNIEnv.GetStaticMethodID (class_ref, "createSyncableTypeEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSyncableTypeEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createTimeEvent_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.metrics']/class[@name='WhispersyncMetricsFactory']/method[@name='createTimeEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createTimeEvent", "(Ljava/lang/String;J)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;", "")]
		public static global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent CreateTimeEvent (string p0, long p1)
		{
			if (id_createTimeEvent_Ljava_lang_String_J == IntPtr.Zero)
				id_createTimeEvent_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "createTimeEvent", "(Ljava/lang/String;J)Lcom/amazon/ags/client/metrics/events/GameCircleGenericEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTimeEvent_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
