using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']"
	[Register ("com/amazon/ags/api/whispersync/model/SyncableNumberElement", "", "Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker")]
	public partial interface ISyncableNumberElement : global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableElement {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']/method[@name='asDecimal' and count(parameter)=0]"
		[Register ("asDecimal", "()Ljava/math/BigDecimal;", "GetAsDecimalHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker, GameCircle.MonoDroid")]
		global::Java.Math.BigDecimal AsDecimal ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']/method[@name='asDouble' and count(parameter)=0]"
		[Register ("asDouble", "()D", "GetAsDoubleHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker, GameCircle.MonoDroid")]
		double AsDouble ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']/method[@name='asInt' and count(parameter)=0]"
		[Register ("asInt", "()I", "GetAsIntHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker, GameCircle.MonoDroid")]
		int AsInt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']/method[@name='asLong' and count(parameter)=0]"
		[Register ("asLong", "()J", "GetAsLongHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker, GameCircle.MonoDroid")]
		long AsLong ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync.model']/interface[@name='SyncableNumberElement']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler:Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElementInvoker, GameCircle.MonoDroid")]
		string AsString ();

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/model/SyncableNumberElement", DoNotGenerateAcw=true)]
	internal class ISyncableNumberElementInvoker : global::Java.Lang.Object, ISyncableNumberElement {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/whispersync/model/SyncableNumberElement");
		IntPtr class_ref;

		public static ISyncableNumberElement GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncableNumberElement> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.whispersync.model.SyncableNumberElement"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncableNumberElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISyncableNumberElementInvoker); }
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.Model.ISyncableNumberElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
