using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/NumberElement", DoNotGenerateAcw=true)]
	public partial class NumberElement : global::Com.Amazon.Ags.Client.Whispersync.Model.Element, global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement {


		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/field[@name='value']"
		[Register ("value")]
		protected global::Java.Math.BigDecimal Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/math/BigDecimal;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, value_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/math/BigDecimal;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, value_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/NumberElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumberElement); }
		}

		protected NumberElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_math_BigDecimal_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/constructor[@name='NumberElement' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register (".ctor", "(Ljava/math/BigDecimal;)V", "")]
		public NumberElement (global::Java.Math.BigDecimal p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NumberElement)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/math/BigDecimal;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/math/BigDecimal;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_math_BigDecimal_ == IntPtr.Zero)
				id_ctor_Ljava_math_BigDecimal_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigDecimal;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigDecimal_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_math_BigDecimal_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_math_BigDecimal_Ljava_util_Map_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/constructor[@name='NumberElement' and count(parameter)=3 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/math/BigDecimal;Ljava/util/Map;J)V", "")]
		public NumberElement (global::Java.Math.BigDecimal p0, global::System.Collections.Generic.IDictionary<string, string> p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (NumberElement)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/math/BigDecimal;Ljava/util/Map;J)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/math/BigDecimal;Ljava/util/Map;J)V", new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_math_BigDecimal_Ljava_util_Map_J == IntPtr.Zero)
				id_ctor_Ljava_math_BigDecimal_Ljava_util_Map_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigDecimal;Ljava/util/Map;J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_util_Map_J, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_util_Map_J, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_amazon_ags_client_whispersync_model_NumberElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/constructor[@name='NumberElement' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.model.NumberElement']]"
		[Register (".ctor", "(Lcom/amazon/ags/client/whispersync/model/NumberElement;)V", "")]
		public NumberElement (global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NumberElement)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/ags/client/whispersync/model/NumberElement;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/ags/client/whispersync/model/NumberElement;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_amazon_ags_client_whispersync_model_NumberElement_ == IntPtr.Zero)
				id_ctor_Lcom_amazon_ags_client_whispersync_model_NumberElement_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/ags/client/whispersync/model/NumberElement;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_model_NumberElement_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_ags_client_whispersync_model_NumberElement_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/constructor[@name='NumberElement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NumberElement () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NumberElement)) {
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

		static Delegate cb_asDecimal;
#pragma warning disable 0169
		static Delegate GetAsDecimalHandler ()
		{
			if (cb_asDecimal == null)
				cb_asDecimal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsDecimal);
			return cb_asDecimal;
		}

		static IntPtr n_AsDecimal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsDecimal ());
		}
#pragma warning restore 0169

		static IntPtr id_asDecimal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='asDecimal' and count(parameter)=0]"
		[Register ("asDecimal", "()Ljava/math/BigDecimal;", "GetAsDecimalHandler")]
		public virtual global::Java.Math.BigDecimal AsDecimal ()
		{
			if (id_asDecimal == IntPtr.Zero)
				id_asDecimal = JNIEnv.GetMethodID (class_ref, "asDecimal", "()Ljava/math/BigDecimal;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod  (Handle, id_asDecimal), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asDecimal), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_asDouble;
#pragma warning disable 0169
		static Delegate GetAsDoubleHandler ()
		{
			if (cb_asDouble == null)
				cb_asDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_AsDouble);
			return cb_asDouble;
		}

		static double n_AsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble ();
		}
#pragma warning restore 0169

		static IntPtr id_asDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='asDouble' and count(parameter)=0]"
		[Register ("asDouble", "()D", "GetAsDoubleHandler")]
		public virtual double AsDouble ()
		{
			if (id_asDouble == IntPtr.Zero)
				id_asDouble = JNIEnv.GetMethodID (class_ref, "asDouble", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_asDouble);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_asDouble);
		}

		static Delegate cb_asInt;
#pragma warning disable 0169
		static Delegate GetAsIntHandler ()
		{
			if (cb_asInt == null)
				cb_asInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_AsInt);
			return cb_asInt;
		}

		static int n_AsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt ();
		}
#pragma warning restore 0169

		static IntPtr id_asInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='asInt' and count(parameter)=0]"
		[Register ("asInt", "()I", "GetAsIntHandler")]
		public virtual int AsInt ()
		{
			if (id_asInt == IntPtr.Zero)
				id_asInt = JNIEnv.GetMethodID (class_ref, "asInt", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_asInt);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_asInt);
		}

		static Delegate cb_asLong;
#pragma warning disable 0169
		static Delegate GetAsLongHandler ()
		{
			if (cb_asLong == null)
				cb_asLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_AsLong);
			return cb_asLong;
		}

		static long n_AsLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong ();
		}
#pragma warning restore 0169

		static IntPtr id_asLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='asLong' and count(parameter)=0]"
		[Register ("asLong", "()J", "GetAsLongHandler")]
		public virtual long AsLong ()
		{
			if (id_asLong == IntPtr.Zero)
				id_asLong = JNIEnv.GetMethodID (class_ref, "asLong", "()J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_asLong);
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_asLong);
		}

		static Delegate cb_asString;
#pragma warning disable 0169
		static Delegate GetAsStringHandler ()
		{
			if (cb_asString == null)
				cb_asString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsString);
			return cb_asString;
		}

		static IntPtr n_AsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		static IntPtr id_asString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler")]
		public virtual string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_asString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
#pragma warning disable 0169
		static Delegate GetReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_Handler ()
		{
			if (cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ == null)
				cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_);
			return cb_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
		}

		static void n_ReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='NumberElement']/method[@name='reportEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.ags.client.whispersync.model.SyncableType']]"
		[Register ("reportEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)V", "GetReportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_Handler")]
		protected virtual void ReportEvent (string p0, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType p1)
		{
			if (id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ == IntPtr.Zero)
				id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_ = JNIEnv.GetMethodID (class_ref, "reportEvent", "(Ljava/lang/String;Lcom/amazon/ags/client/whispersync/model/SyncableType;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reportEvent_Ljava_lang_String_Lcom_amazon_ags_client_whispersync_model_SyncableType_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
