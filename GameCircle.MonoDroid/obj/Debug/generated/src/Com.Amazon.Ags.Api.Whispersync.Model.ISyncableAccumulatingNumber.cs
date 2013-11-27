using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableAccumulatingNumber", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker")]
	public partial interface ISyncableAccumulatingNumber : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='asDecimal' and count(parameter)=0]"
		[Register ("asDecimal", "()Ljava/math/BigDecimal;", "GetAsDecimalHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		global::Java.Math.BigDecimal AsDecimal ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='asDouble' and count(parameter)=0]"
		[Register ("asDouble", "()D", "GetAsDoubleHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		double AsDouble ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='asInt' and count(parameter)=0]"
		[Register ("asInt", "()I", "GetAsIntHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		int AsInt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='asLong' and count(parameter)=0]"
		[Register ("asLong", "()J", "GetAsLongHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		long AsLong ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		string AsString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("decrement", "(D)V", "GetDecrement_DHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Decrement (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decrement", "(I)V", "GetDecrement_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Decrement (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrement", "(Ljava/lang/String;)V", "GetDecrement_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Decrement (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='decrement' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("decrement", "(J)V", "GetDecrement_JHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Decrement (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("increment", "(D)V", "GetIncrement_DHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Increment (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("increment", "(I)V", "GetIncrement_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Increment (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("increment", "(Ljava/lang/String;)V", "GetIncrement_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Increment (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableAccumulatingNumber']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("increment", "(J)V", "GetIncrement_JHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumberInvoker, GameCircle.MonoDroid")]
		void Increment (long p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableAccumulatingNumber", DoNotGenerateAcw=true)]
	internal class ISyncableAccumulatingNumberInvoker : global::Java.Lang.Object, ISyncableAccumulatingNumber {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableAccumulatingNumber");
		IntPtr class_ref;

		public static ISyncableAccumulatingNumber GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableAccumulatingNumber> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableAccumulatingNumber"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableAccumulatingNumberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableAccumulatingNumberInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsDecimal ());
		}
#pragma warning restore 0169

		IntPtr id_asDecimal;
		public global::Java.Math.BigDecimal AsDecimal ()
		{
			if (id_asDecimal == IntPtr.Zero)
				id_asDecimal = JNIEnv.GetMethodID (class_ref, "asDecimal", "()Ljava/math/BigDecimal;");
			return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (Handle, id_asDecimal), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble ();
		}
#pragma warning restore 0169

		IntPtr id_asDouble;
		public double AsDouble ()
		{
			if (id_asDouble == IntPtr.Zero)
				id_asDouble = JNIEnv.GetMethodID (class_ref, "asDouble", "()D");
			return JNIEnv.CallDoubleMethod (Handle, id_asDouble);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt ();
		}
#pragma warning restore 0169

		IntPtr id_asInt;
		public int AsInt ()
		{
			if (id_asInt == IntPtr.Zero)
				id_asInt = JNIEnv.GetMethodID (class_ref, "asInt", "()I");
			return JNIEnv.CallIntMethod (Handle, id_asInt);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong ();
		}
#pragma warning restore 0169

		IntPtr id_asLong;
		public long AsLong ()
		{
			if (id_asLong == IntPtr.Zero)
				id_asLong = JNIEnv.GetMethodID (class_ref, "asLong", "()J");
			return JNIEnv.CallLongMethod (Handle, id_asLong);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		IntPtr id_asString;
		public string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_asString), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_decrement_D;
		public void Decrement (double p0)
		{
			if (id_decrement_D == IntPtr.Zero)
				id_decrement_D = JNIEnv.GetMethodID (class_ref, "decrement", "(D)V");
			JNIEnv.CallVoidMethod (Handle, id_decrement_D, new JValue (p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_decrement_I;
		public void Decrement (int p0)
		{
			if (id_decrement_I == IntPtr.Zero)
				id_decrement_I = JNIEnv.GetMethodID (class_ref, "decrement", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_decrement_I, new JValue (p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_decrement_Ljava_lang_String_;
		public void Decrement (string p0)
		{
			if (id_decrement_Ljava_lang_String_ == IntPtr.Zero)
				id_decrement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrement", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_decrement_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_decrement_J;
		public void Decrement (long p0)
		{
			if (id_decrement_J == IntPtr.Zero)
				id_decrement_J = JNIEnv.GetMethodID (class_ref, "decrement", "(J)V");
			JNIEnv.CallVoidMethod (Handle, id_decrement_J, new JValue (p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		IntPtr id_increment_D;
		public void Increment (double p0)
		{
			if (id_increment_D == IntPtr.Zero)
				id_increment_D = JNIEnv.GetMethodID (class_ref, "increment", "(D)V");
			JNIEnv.CallVoidMethod (Handle, id_increment_D, new JValue (p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		IntPtr id_increment_I;
		public void Increment (int p0)
		{
			if (id_increment_I == IntPtr.Zero)
				id_increment_I = JNIEnv.GetMethodID (class_ref, "increment", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_increment_I, new JValue (p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		IntPtr id_increment_Ljava_lang_String_;
		public void Increment (string p0)
		{
			if (id_increment_Ljava_lang_String_ == IntPtr.Zero)
				id_increment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_increment_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableAccumulatingNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		IntPtr id_increment_J;
		public void Increment (long p0)
		{
			if (id_increment_J == IntPtr.Zero)
				id_increment_J = JNIEnv.GetMethodID (class_ref, "increment", "(J)V");
			JNIEnv.CallVoidMethod (Handle, id_increment_J, new JValue (p0));
		}

	}

}
