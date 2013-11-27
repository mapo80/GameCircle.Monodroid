using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncResponse']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/network/WhispersyncResponse", DoNotGenerateAcw=true)]
	public partial class WhispersyncResponse : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/network/WhispersyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncResponse); }
		}

		protected WhispersyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncResponse']/constructor[@name='WhispersyncResponse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public WhispersyncResponse (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (WhispersyncResponse)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Date);
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		public virtual string Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncResponse']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/lang/String;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDate), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Document);
		}
#pragma warning restore 0169

		static IntPtr id_getDocument;
		public virtual string Document {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncResponse']/method[@name='getDocument' and count(parameter)=0]"
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

		static Delegate cb_getVersionId;
#pragma warning disable 0169
		static Delegate GetGetVersionIdHandler ()
		{
			if (cb_getVersionId == null)
				cb_getVersionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersionId);
			return cb_getVersionId;
		}

		static IntPtr n_GetVersionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Network.WhispersyncResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionId);
		}
#pragma warning restore 0169

		static IntPtr id_getVersionId;
		public virtual string VersionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.network']/class[@name='WhispersyncResponse']/method[@name='getVersionId' and count(parameter)=0]"
			[Register ("getVersionId", "()Ljava/lang/String;", "GetGetVersionIdHandler")]
			get {
				if (id_getVersionId == IntPtr.Zero)
					id_getVersionId = JNIEnv.GetMethodID (class_ref, "getVersionId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersionId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
