using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventId']"
	[global::Android.Runtime.Register ("com/amazon/ags/storage/OfflineEventId", DoNotGenerateAcw=true)]
	public partial class OfflineEventId : global::Java.Lang.Object {


		static IntPtr Invalid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventId']/field[@name='Invalid']"
		[Register ("Invalid")]
		public static global::Com.Amazon.Ags.Storage.OfflineEventId Invalid {
			get {
				if (Invalid_jfieldId == IntPtr.Zero)
					Invalid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Invalid", "Lcom/amazon/ags/storage/OfflineEventId;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Invalid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Invalid_jfieldId == IntPtr.Zero)
					Invalid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Invalid", "Lcom/amazon/ags/storage/OfflineEventId;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, Invalid_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/storage/OfflineEventId", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OfflineEventId); }
		}

		protected OfflineEventId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventId']/constructor[@name='OfflineEventId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public OfflineEventId (long p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OfflineEventId)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", new JValue (p0));
				return;
			}

			if (id_ctor_J == IntPtr.Zero)
				id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, new JValue (p0));
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Storage.OfflineEventId __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Storage.OfflineEventId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.storage']/class[@name='OfflineEventId']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getId);
			}
		}

	}
}
