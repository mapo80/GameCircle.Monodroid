using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/AccumulatingNumber", DoNotGenerateAcw=true)]
	public partial class AccumulatingNumber : global::Java.Lang.Object, global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber, global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/AccumulatingNumber", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccumulatingNumber); }
		}

		protected AccumulatingNumber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Lcom_amazon_ags_client_whispersync_model_SyncState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/constructor[@name='AccumulatingNumber' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.math.BigDecimal'] and parameter[3][@type='java.math.BigDecimal'] and parameter[4][@type='com.amazon.ags.client.whispersync.model.SyncState']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/math/BigDecimal;Ljava/math/BigDecimal;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", "")]
		public AccumulatingNumber (string p0, global::Java.Math.BigDecimal p1, global::Java.Math.BigDecimal p2, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AccumulatingNumber)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/math/BigDecimal;Ljava/math/BigDecimal;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/math/BigDecimal;Ljava/math/BigDecimal;Lcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Lcom_amazon_ags_client_whispersync_model_SyncState_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Lcom_amazon_ags_client_whispersync_model_SyncState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/math/BigDecimal;Ljava/math/BigDecimal;Lcom/amazon/ags/client/whispersync/model/SyncState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Lcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Lcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/constructor[@name='AccumulatingNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public AccumulatingNumber (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AccumulatingNumber)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getLocal;
#pragma warning disable 0169
		static Delegate GetGetLocalHandler ()
		{
			if (cb_getLocal == null)
				cb_getLocal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocal);
			return cb_getLocal;
		}

		static IntPtr n_GetLocal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Local);
		}
#pragma warning restore 0169

		static IntPtr id_getLocal;
		public virtual global::Java.Math.BigDecimal Local {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='getLocal' and count(parameter)=0]"
			[Register ("getLocal", "()Ljava/math/BigDecimal;", "GetGetLocalHandler")]
			get {
				if (id_getLocal == IntPtr.Zero)
					id_getLocal = JNIEnv.GetMethodID (class_ref, "getLocal", "()Ljava/math/BigDecimal;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod  (Handle, id_getLocal), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocal), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRemote;
#pragma warning disable 0169
		static Delegate GetGetRemoteHandler ()
		{
			if (cb_getRemote == null)
				cb_getRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemote);
			return cb_getRemote;
		}

		static IntPtr n_GetRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remote);
		}
#pragma warning restore 0169

		static IntPtr id_getRemote;
		public virtual global::Java.Math.BigDecimal Remote {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='getRemote' and count(parameter)=0]"
			[Register ("getRemote", "()Ljava/math/BigDecimal;", "GetGetRemoteHandler")]
			get {
				if (id_getRemote == IntPtr.Zero)
					id_getRemote = JNIEnv.GetMethodID (class_ref, "getRemote", "()Ljava/math/BigDecimal;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod  (Handle, id_getRemote), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRemote), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/amazon/ags/client/whispersync/model/SyncState;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallObjectMethod  (Handle, id_getState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getState), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsDecimal ());
		}
#pragma warning restore 0169

		static IntPtr id_asDecimal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='asDecimal' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble ();
		}
#pragma warning restore 0169

		static IntPtr id_asDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='asDouble' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt ();
		}
#pragma warning restore 0169

		static IntPtr id_asInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='asInt' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong ();
		}
#pragma warning restore 0169

		static IntPtr id_asLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='asLong' and count(parameter)=0]"
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		static IntPtr id_asString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='asString' and count(parameter)=0]"
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

		static Delegate cb_completeSyncing;
#pragma warning disable 0169
		static Delegate GetCompleteSyncingHandler ()
		{
			if (cb_completeSyncing == null)
				cb_completeSyncing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CompleteSyncing);
			return cb_completeSyncing;
		}

		static void n_CompleteSyncing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompleteSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_completeSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='completeSyncing' and count(parameter)=0]"
		[Register ("completeSyncing", "()V", "GetCompleteSyncingHandler")]
		public virtual void CompleteSyncing ()
		{
			if (id_completeSyncing == IntPtr.Zero)
				id_completeSyncing = JNIEnv.GetMethodID (class_ref, "completeSyncing", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_completeSyncing);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_completeSyncing);
		}

		static Delegate cb_decrement_D;
#pragma warning disable 0169
		static Delegate GetDecrement_DHandler ()
		{
			if (cb_decrement_D == null)
				cb_decrement_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Decrement_D);
			return cb_decrement_D;
		}

		static void n_Decrement_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decrement_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("decrement", "(D)V", "GetDecrement_DHandler")]
		public virtual void Decrement (double p0)
		{
			if (id_decrement_D == IntPtr.Zero)
				id_decrement_D = JNIEnv.GetMethodID (class_ref, "decrement", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decrement_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_decrement_D, new JValue (p0));
		}

		static Delegate cb_decrement_I;
#pragma warning disable 0169
		static Delegate GetDecrement_IHandler ()
		{
			if (cb_decrement_I == null)
				cb_decrement_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Decrement_I);
			return cb_decrement_I;
		}

		static void n_Decrement_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decrement_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decrement", "(I)V", "GetDecrement_IHandler")]
		public virtual void Decrement (int p0)
		{
			if (id_decrement_I == IntPtr.Zero)
				id_decrement_I = JNIEnv.GetMethodID (class_ref, "decrement", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decrement_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_decrement_I, new JValue (p0));
		}

		static Delegate cb_decrement_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrement_Ljava_lang_String_Handler ()
		{
			if (cb_decrement_Ljava_lang_String_ == null)
				cb_decrement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decrement_Ljava_lang_String_);
			return cb_decrement_Ljava_lang_String_;
		}

		static void n_Decrement_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decrement_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrement", "(Ljava/lang/String;)V", "GetDecrement_Ljava_lang_String_Handler")]
		public virtual void Decrement (string p0)
		{
			if (id_decrement_Ljava_lang_String_ == IntPtr.Zero)
				id_decrement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrement", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decrement_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_decrement_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_decrement_J;
#pragma warning disable 0169
		static Delegate GetDecrement_JHandler ()
		{
			if (cb_decrement_J == null)
				cb_decrement_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Decrement_J);
			return cb_decrement_J;
		}

		static void n_Decrement_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decrement_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("decrement", "(J)V", "GetDecrement_JHandler")]
		public virtual void Decrement (long p0)
		{
			if (id_decrement_J == IntPtr.Zero)
				id_decrement_J = JNIEnv.GetMethodID (class_ref, "decrement", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decrement_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_decrement_J, new JValue (p0));
		}

		static Delegate cb_deepCopy;
#pragma warning disable 0169
		static Delegate GetDeepCopyHandler ()
		{
			if (cb_deepCopy == null)
				cb_deepCopy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeepCopy);
			return cb_deepCopy;
		}

		static IntPtr n_DeepCopy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeepCopy ());
		}
#pragma warning restore 0169

		static IntPtr id_deepCopy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/amazon/ags/client/whispersync/model/AccumulatingNumber;", "GetDeepCopyHandler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/amazon/ags/client/whispersync/model/AccumulatingNumber;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (JNIEnv.CallObjectMethod  (Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_deepCopy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_increment_D;
#pragma warning disable 0169
		static Delegate GetIncrement_DHandler ()
		{
			if (cb_increment_D == null)
				cb_increment_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Increment_D);
			return cb_increment_D;
		}

		static void n_Increment_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_increment_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("increment", "(D)V", "GetIncrement_DHandler")]
		public virtual void Increment (double p0)
		{
			if (id_increment_D == IntPtr.Zero)
				id_increment_D = JNIEnv.GetMethodID (class_ref, "increment", "(D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_D, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_increment_D, new JValue (p0));
		}

		static Delegate cb_increment_I;
#pragma warning disable 0169
		static Delegate GetIncrement_IHandler ()
		{
			if (cb_increment_I == null)
				cb_increment_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Increment_I);
			return cb_increment_I;
		}

		static void n_Increment_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_increment_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("increment", "(I)V", "GetIncrement_IHandler")]
		public virtual void Increment (int p0)
		{
			if (id_increment_I == IntPtr.Zero)
				id_increment_I = JNIEnv.GetMethodID (class_ref, "increment", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_increment_I, new JValue (p0));
		}

		static Delegate cb_increment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIncrement_Ljava_lang_String_Handler ()
		{
			if (cb_increment_Ljava_lang_String_ == null)
				cb_increment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Increment_Ljava_lang_String_);
			return cb_increment_Ljava_lang_String_;
		}

		static void n_Increment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_increment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("increment", "(Ljava/lang/String;)V", "GetIncrement_Ljava_lang_String_Handler")]
		public virtual void Increment (string p0)
		{
			if (id_increment_Ljava_lang_String_ == IntPtr.Zero)
				id_increment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_increment_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_increment_J;
#pragma warning disable 0169
		static Delegate GetIncrement_JHandler ()
		{
			if (cb_increment_J == null)
				cb_increment_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Increment_J);
			return cb_increment_J;
		}

		static void n_Increment_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_increment_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("increment", "(J)V", "GetIncrement_JHandler")]
		public virtual void Increment (long p0)
		{
			if (id_increment_J == IntPtr.Zero)
				id_increment_J = JNIEnv.GetMethodID (class_ref, "increment", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_increment_J, new JValue (p0));
		}

		static Delegate cb_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_;
#pragma warning disable 0169
		static Delegate GetMerge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_Handler ()
		{
			if (cb_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_ == null)
				cb_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_);
			return cb_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_;
		}

		static void n_Merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Merge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.client.whispersync.model.AccumulatingNumber']]"
		[Register ("merge", "(Lcom/amazon/ags/client/whispersync/model/AccumulatingNumber;)V", "GetMerge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_Handler")]
		public virtual void Merge (global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber p0)
		{
			if (id_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_ == IntPtr.Zero)
				id_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lcom/amazon/ags/client/whispersync/model/AccumulatingNumber;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_merge_Lcom_amazon_ags_client_whispersync_model_AccumulatingNumber_, new JValue (p0));
		}

		static Delegate cb_startSyncing;
#pragma warning disable 0169
		static Delegate GetStartSyncingHandler ()
		{
			if (cb_startSyncing == null)
				cb_startSyncing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartSyncing);
			return cb_startSyncing;
		}

		static void n_StartSyncing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSyncing ();
		}
#pragma warning restore 0169

		static IntPtr id_startSyncing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='AccumulatingNumber']/method[@name='startSyncing' and count(parameter)=0]"
		[Register ("startSyncing", "()V", "GetStartSyncingHandler")]
		public virtual void StartSyncing ()
		{
			if (id_startSyncing == IntPtr.Zero)
				id_startSyncing = JNIEnv.GetMethodID (class_ref, "startSyncing", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startSyncing);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startSyncing);
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Client.Whispersync.Model.IMergeable
		global::Java.Lang.Object global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable.DeepCopy ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(DeepCopy ());
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Client.Whispersync.Model.IMergeable
		void global::Com.Amazon.Ags.Client.Whispersync.Model.IMergeable.Merge (global::Java.Lang.Object p0)
		{
			Merge (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Client.Whispersync.Model.AccumulatingNumber>(p0));
		}

	}
}
