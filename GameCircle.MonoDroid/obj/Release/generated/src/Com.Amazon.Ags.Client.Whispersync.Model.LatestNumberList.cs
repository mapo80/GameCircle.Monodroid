using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/model/LatestNumberList", DoNotGenerateAcw=true)]
	public partial class LatestNumberList : global::Com.Amazon.Ags.Client.Whispersync.Model.NumberList {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/model/LatestNumberList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatestNumberList); }
		}

		protected LatestNumberList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']/constructor[@name='LatestNumberList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public LatestNumberList (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (LatestNumberList)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_ILcom_amazon_ags_client_whispersync_model_SyncState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']/constructor[@name='LatestNumberList' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List'] and parameter[3][@type='int'] and parameter[4][@type='com.amazon.ags.client.whispersync.model.SyncState']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;ILcom/amazon/ags/client/whispersync/model/SyncState;)V", "")]
		public LatestNumberList (string p0, global::System.Collections.Generic.IList<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement> p1, int p2, global::Com.Amazon.Ags.Client.Whispersync.Model.SyncState p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Amazon.Ags.Client.Whispersync.Model.NumberElement>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (LatestNumberList)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/List;ILcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/List;ILcom/amazon/ags/client/whispersync/model/SyncState;)V", new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_util_List_ILcom_amazon_ags_client_whispersync_model_SyncState_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_util_List_ILcom_amazon_ags_client_whispersync_model_SyncState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;ILcom/amazon/ags/client/whispersync/model/SyncState;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_ILcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_ILcom_amazon_ags_client_whispersync_model_SyncState_, new JValue (native_p0), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p1)), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getComparator;
#pragma warning disable 0169
		static Delegate GetGetComparatorHandler ()
		{
			if (cb_getComparator == null)
				cb_getComparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComparator);
			return cb_getComparator;
		}

		static IntPtr n_GetComparator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Comparator);
		}
#pragma warning restore 0169

		static IntPtr id_getComparator;
		public override global::Java.Util.IComparator Comparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']/method[@name='getComparator' and count(parameter)=0]"
			[Register ("getComparator", "()Ljava/util/Comparator;", "GetGetComparatorHandler")]
			get {
				if (id_getComparator == IntPtr.Zero)
					id_getComparator = JNIEnv.GetMethodID (class_ref, "getComparator", "()Ljava/util/Comparator;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallObjectMethod  (Handle, id_getComparator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getComparator), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSyncableType;
#pragma warning disable 0169
		static Delegate GetGetSyncableTypeHandler ()
		{
			if (cb_getSyncableType == null)
				cb_getSyncableType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSyncableType);
			return cb_getSyncableType;
		}

		static IntPtr n_GetSyncableType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SyncableType);
		}
#pragma warning restore 0169

		static IntPtr id_getSyncableType;
		public override global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType SyncableType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']/method[@name='getSyncableType' and count(parameter)=0]"
			[Register ("getSyncableType", "()Lcom/amazon/ags/client/whispersync/model/SyncableType;", "GetGetSyncableTypeHandler")]
			get {
				if (id_getSyncableType == IntPtr.Zero)
					id_getSyncableType = JNIEnv.GetMethodID (class_ref, "getSyncableType", "()Lcom/amazon/ags/client/whispersync/model/SyncableType;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (JNIEnv.CallObjectMethod  (Handle, id_getSyncableType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.SyncableType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSyncableType), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeepCopy ());
		}
#pragma warning restore 0169

		static IntPtr id_deepCopy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync.model']/class[@name='LatestNumberList']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/amazon/ags/client/whispersync/model/LatestNumberList;", "GetDeepCopyHandler")]
		public virtual global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/amazon/ags/client/whispersync/model/LatestNumberList;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList> (JNIEnv.CallObjectMethod  (Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.Model.LatestNumberList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_deepCopy), JniHandleOwnership.TransferLocalRef);
		}

	}
}
