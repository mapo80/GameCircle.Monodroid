using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Metrics.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/metrics/events/GameCircleGenericEvent", DoNotGenerateAcw=true)]
	public partial class GameCircleGenericEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/metrics/events/GameCircleGenericEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameCircleGenericEvent); }
		}

		protected GameCircleGenericEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']/constructor[@name='GameCircleGenericEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V", "")]
		public GameCircleGenericEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);;
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p2);;
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.ToLocalJniHandle (p3);;
			if (GetType () != typeof (GameCircleGenericEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3))),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3))),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		public virtual global::System.Collections.Generic.IDictionary<string, string> Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Ljava/util/Map;", "GetGetAttributesHandler")]
			get {
				if (id_getAttributes == IntPtr.Zero)
					id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAttributes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCountMetrics;
#pragma warning disable 0169
		static Delegate GetGetCountMetricsHandler ()
		{
			if (cb_getCountMetrics == null)
				cb_getCountMetrics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountMetrics);
			return cb_getCountMetrics;
		}

		static IntPtr n_GetCountMetrics (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (__this.CountMetrics);
		}
#pragma warning restore 0169

		static IntPtr id_getCountMetrics;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> CountMetrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']/method[@name='getCountMetrics' and count(parameter)=0]"
			[Register ("getCountMetrics", "()Ljava/util/Map;", "GetGetCountMetricsHandler")]
			get {
				if (id_getCountMetrics == IntPtr.Zero)
					id_getCountMetrics = JNIEnv.GetMethodID (class_ref, "getCountMetrics", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCountMetrics), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCountMetrics), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEventName;
#pragma warning disable 0169
		static Delegate GetGetEventNameHandler ()
		{
			if (cb_getEventName == null)
				cb_getEventName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventName);
			return cb_getEventName;
		}

		static IntPtr n_GetEventName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventName);
		}
#pragma warning restore 0169

		static IntPtr id_getEventName;
		public virtual string EventName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']/method[@name='getEventName' and count(parameter)=0]"
			[Register ("getEventName", "()Ljava/lang/String;", "GetGetEventNameHandler")]
			get {
				if (id_getEventName == IntPtr.Zero)
					id_getEventName = JNIEnv.GetMethodID (class_ref, "getEventName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEventName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEventName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimeMetrics;
#pragma warning disable 0169
		static Delegate GetGetTimeMetricsHandler ()
		{
			if (cb_getTimeMetrics == null)
				cb_getTimeMetrics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeMetrics);
			return cb_getTimeMetrics;
		}

		static IntPtr n_GetTimeMetrics (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Metrics.Events.GameCircleGenericEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.ToLocalJniHandle (__this.TimeMetrics);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeMetrics;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> TimeMetrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.metrics.events']/class[@name='GameCircleGenericEvent']/method[@name='getTimeMetrics' and count(parameter)=0]"
			[Register ("getTimeMetrics", "()Ljava/util/Map;", "GetGetTimeMetricsHandler")]
			get {
				if (id_getTimeMetrics == IntPtr.Zero)
					id_getTimeMetrics = JNIEnv.GetMethodID (class_ref, "getTimeMetrics", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTimeMetrics), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTimeMetrics), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
