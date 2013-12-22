using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableNumber", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker")]
	public partial interface ISyncableNumber : global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement {

		bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set", "(D)V", "GetSet_DHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(DLjava/util/Map;)V", "GetSet_DLjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (double p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set", "(I)V", "GetSet_IHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(ILjava/util/Map;)V", "GetSet_ILjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (int p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSet_Ljava_lang_String_Ljava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("set", "(J)V", "GetSet_JHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumber']/method[@name='set' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.Map']]"
		[Register ("set", "(JLjava/util/Map;)V", "GetSet_JLjava_util_Map_Handler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberInvoker, GameCircle.MonoDroid")]
		void Set (long p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableNumber", DoNotGenerateAcw=true)]
	internal class ISyncableNumberInvoker : global::Java.Lang.Object, ISyncableNumber {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableNumber");
		IntPtr class_ref;

		public static ISyncableNumber GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableNumber> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableNumber"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableNumberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableNumberInvoker); }
		}

		static Delegate cb_isSet;
#pragma warning disable 0169
		static Delegate GetIsSetHandler ()
		{
			if (cb_isSet == null)
				cb_isSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSet);
			return cb_isSet;
		}

		static bool n_IsSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet;
		}
#pragma warning restore 0169

		IntPtr id_isSet;
		public bool IsSet {
			get {
				if (id_isSet == IntPtr.Zero)
					id_isSet = JNIEnv.GetMethodID (class_ref, "isSet", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSet);
			}
		}

		static Delegate cb_set_D;
#pragma warning disable 0169
		static Delegate GetSet_DHandler ()
		{
			if (cb_set_D == null)
				cb_set_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_D);
			return cb_set_D;
		}

		static void n_Set_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		IntPtr id_set_D;
		public void Set (double p0)
		{
			if (id_set_D == IntPtr.Zero)
				id_set_D = JNIEnv.GetMethodID (class_ref, "set", "(D)V");
			JNIEnv.CallVoidMethod (Handle, id_set_D, new JValue (p0));
		}

		static Delegate cb_set_DLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSet_DLjava_util_Map_Handler ()
		{
			if (cb_set_DLjava_util_Map_ == null)
				cb_set_DLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_Set_DLjava_util_Map_);
			return cb_set_DLjava_util_Map_;
		}

		static void n_Set_DLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_DLjava_util_Map_;
		public void Set (double p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_DLjava_util_Map_ == IntPtr.Zero)
				id_set_DLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(DLjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_set_DLjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_set_I;
#pragma warning disable 0169
		static Delegate GetSet_IHandler ()
		{
			if (cb_set_I == null)
				cb_set_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_I);
			return cb_set_I;
		}

		static void n_Set_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		IntPtr id_set_I;
		public void Set (int p0)
		{
			if (id_set_I == IntPtr.Zero)
				id_set_I = JNIEnv.GetMethodID (class_ref, "set", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_set_I, new JValue (p0));
		}

		static Delegate cb_set_ILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_util_Map_Handler ()
		{
			if (cb_set_ILjava_util_Map_ == null)
				cb_set_ILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_ILjava_util_Map_);
			return cb_set_ILjava_util_Map_;
		}

		static void n_Set_ILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_ILjava_util_Map_;
		public void Set (int p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_ILjava_util_Map_ == IntPtr.Zero)
				id_set_ILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_set_ILjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_;
		}

		static void n_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_;
		public void Set (string p0)
		{
			if (id_set_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_set_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_set_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_util_Map_);
			return cb_set_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Set_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_Ljava_util_Map_;
		public void Set (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_set_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_set_J;
#pragma warning disable 0169
		static Delegate GetSet_JHandler ()
		{
			if (cb_set_J == null)
				cb_set_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Set_J);
			return cb_set_J;
		}

		static void n_Set_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		IntPtr id_set_J;
		public void Set (long p0)
		{
			if (id_set_J == IntPtr.Zero)
				id_set_J = JNIEnv.GetMethodID (class_ref, "set", "(J)V");
			JNIEnv.CallVoidMethod (Handle, id_set_J, new JValue (p0));
		}

		static Delegate cb_set_JLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSet_JLjava_util_Map_Handler ()
		{
			if (cb_set_JLjava_util_Map_ == null)
				cb_set_JLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_Set_JLjava_util_Map_);
			return cb_set_JLjava_util_Map_;
		}

		static void n_Set_JLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_JLjava_util_Map_;
		public void Set (long p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_set_JLjava_util_Map_ == IntPtr.Zero)
				id_set_JLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "set", "(JLjava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_set_JLjava_util_Map_, new JValue (p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)));
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public global::System.Collections.Generic.IDictionary<string, string> Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		IntPtr id_getTimestamp;
		public long Timestamp {
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getTimestamp);
			}
		}

	}

}
