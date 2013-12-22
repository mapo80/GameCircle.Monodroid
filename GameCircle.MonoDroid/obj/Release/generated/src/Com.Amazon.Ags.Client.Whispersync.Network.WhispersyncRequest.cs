using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncRequest']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/network/WhispersyncRequest", DoNotGenerateAcw=true)]
	public partial class WhispersyncRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/network/WhispersyncRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncRequest); }
		}

		protected WhispersyncRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncRequest']/constructor[@name='WhispersyncRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public WhispersyncRequest (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (WhispersyncRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getDocument;
#pragma warning disable 0169
		static Delegate GetGetDocumentHandler ()
		{
			if (cb_getDocument == null)
				cb_getDocument = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocument);
			return cb_getDocument;
		}

		static IntPtr n_GetDocument (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Document);
		}
#pragma warning restore 0169

		static IntPtr id_getDocument;
		public virtual string Document {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncRequest']/method[@name='getDocument' and count(parameter)=0]"
			[Register ("getDocument", "()Ljava/lang/String;", "GetGetDocumentHandler")]
			get {
				if (id_getDocument == IntPtr.Zero)
					id_getDocument = JNIEnv.GetMethodID (class_ref, "getDocument", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDocument), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDocument), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPriorVersionId;
#pragma warning disable 0169
		static Delegate GetGetPriorVersionIdHandler ()
		{
			if (cb_getPriorVersionId == null)
				cb_getPriorVersionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriorVersionId);
			return cb_getPriorVersionId;
		}

		static IntPtr n_GetPriorVersionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PriorVersionId);
		}
#pragma warning restore 0169

		static IntPtr id_getPriorVersionId;
		public virtual string PriorVersionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncRequest']/method[@name='getPriorVersionId' and count(parameter)=0]"
			[Register ("getPriorVersionId", "()Ljava/lang/String;", "GetGetPriorVersionIdHandler")]
			get {
				if (id_getPriorVersionId == IntPtr.Zero)
					id_getPriorVersionId = JNIEnv.GetMethodID (class_ref, "getPriorVersionId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPriorVersionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPriorVersionId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
