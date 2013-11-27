using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Client.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']"
	[global::Android.Runtime.Register ("com/amazon/ags/client/whispersync/SyncRequestState", DoNotGenerateAcw=true)]
	public partial class SyncRequestState : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/client/whispersync/SyncRequestState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncRequestState); }
		}

		protected SyncRequestState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/constructor[@name='SyncRequestState' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SyncRequestState () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SyncRequestState)) {
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

		static Delegate cb_isActiveCloudWrite;
#pragma warning disable 0169
		static Delegate GetIsActiveCloudWriteHandler ()
		{
			if (cb_isActiveCloudWrite == null)
				cb_isActiveCloudWrite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActiveCloudWrite);
			return cb_isActiveCloudWrite;
		}

		static bool n_IsActiveCloudWrite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveCloudWrite;
		}
#pragma warning restore 0169

		static Delegate cb_setActiveCloudWrite_Z;
#pragma warning disable 0169
		static Delegate GetSetActiveCloudWrite_ZHandler ()
		{
			if (cb_setActiveCloudWrite_Z == null)
				cb_setActiveCloudWrite_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetActiveCloudWrite_Z);
			return cb_setActiveCloudWrite_Z;
		}

		static void n_SetActiveCloudWrite_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActiveCloudWrite = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isActiveCloudWrite;
		static IntPtr id_setActiveCloudWrite_Z;
		public virtual bool ActiveCloudWrite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='isActiveCloudWrite' and count(parameter)=0]"
			[Register ("isActiveCloudWrite", "()Z", "GetIsActiveCloudWriteHandler")]
			get {
				if (id_isActiveCloudWrite == IntPtr.Zero)
					id_isActiveCloudWrite = JNIEnv.GetMethodID (class_ref, "isActiveCloudWrite", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isActiveCloudWrite);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isActiveCloudWrite);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='setActiveCloudWrite' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setActiveCloudWrite", "(Z)V", "GetSetActiveCloudWrite_ZHandler")]
			set {
				if (id_setActiveCloudWrite_Z == IntPtr.Zero)
					id_setActiveCloudWrite_Z = JNIEnv.GetMethodID (class_ref, "setActiveCloudWrite", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setActiveCloudWrite_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setActiveCloudWrite_Z, new JValue (value));
			}
		}

		static Delegate cb_isCloudWriteRequested;
#pragma warning disable 0169
		static Delegate GetIsCloudWriteRequestedHandler ()
		{
			if (cb_isCloudWriteRequested == null)
				cb_isCloudWriteRequested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCloudWriteRequested);
			return cb_isCloudWriteRequested;
		}

		static bool n_IsCloudWriteRequested (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloudWriteRequested;
		}
#pragma warning restore 0169

		static Delegate cb_setCloudWriteRequested_Z;
#pragma warning disable 0169
		static Delegate GetSetCloudWriteRequested_ZHandler ()
		{
			if (cb_setCloudWriteRequested_Z == null)
				cb_setCloudWriteRequested_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCloudWriteRequested_Z);
			return cb_setCloudWriteRequested_Z;
		}

		static void n_SetCloudWriteRequested_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloudWriteRequested = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCloudWriteRequested;
		static IntPtr id_setCloudWriteRequested_Z;
		public virtual bool CloudWriteRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='isCloudWriteRequested' and count(parameter)=0]"
			[Register ("isCloudWriteRequested", "()Z", "GetIsCloudWriteRequestedHandler")]
			get {
				if (id_isCloudWriteRequested == IntPtr.Zero)
					id_isCloudWriteRequested = JNIEnv.GetMethodID (class_ref, "isCloudWriteRequested", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCloudWriteRequested);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isCloudWriteRequested);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='setCloudWriteRequested' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCloudWriteRequested", "(Z)V", "GetSetCloudWriteRequested_ZHandler")]
			set {
				if (id_setCloudWriteRequested_Z == IntPtr.Zero)
					id_setCloudWriteRequested_Z = JNIEnv.GetMethodID (class_ref, "setCloudWriteRequested", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCloudWriteRequested_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setCloudWriteRequested_Z, new JValue (value));
			}
		}

		static Delegate cb_isDiskWriteRequested;
#pragma warning disable 0169
		static Delegate GetIsDiskWriteRequestedHandler ()
		{
			if (cb_isDiskWriteRequested == null)
				cb_isDiskWriteRequested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDiskWriteRequested);
			return cb_isDiskWriteRequested;
		}

		static bool n_IsDiskWriteRequested (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiskWriteRequested;
		}
#pragma warning restore 0169

		static Delegate cb_setDiskWriteRequested_Z;
#pragma warning disable 0169
		static Delegate GetSetDiskWriteRequested_ZHandler ()
		{
			if (cb_setDiskWriteRequested_Z == null)
				cb_setDiskWriteRequested_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDiskWriteRequested_Z);
			return cb_setDiskWriteRequested_Z;
		}

		static void n_SetDiskWriteRequested_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Client.Whispersync.SyncRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiskWriteRequested = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDiskWriteRequested;
		static IntPtr id_setDiskWriteRequested_Z;
		public virtual bool DiskWriteRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='isDiskWriteRequested' and count(parameter)=0]"
			[Register ("isDiskWriteRequested", "()Z", "GetIsDiskWriteRequestedHandler")]
			get {
				if (id_isDiskWriteRequested == IntPtr.Zero)
					id_isDiskWriteRequested = JNIEnv.GetMethodID (class_ref, "isDiskWriteRequested", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDiskWriteRequested);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isDiskWriteRequested);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.client.whispersync']/class[@name='SyncRequestState']/method[@name='setDiskWriteRequested' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDiskWriteRequested", "(Z)V", "GetSetDiskWriteRequested_ZHandler")]
			set {
				if (id_setDiskWriteRequested_Z == IntPtr.Zero)
					id_setDiskWriteRequested_Z = JNIEnv.GetMethodID (class_ref, "setDiskWriteRequested", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDiskWriteRequested_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDiskWriteRequested_Z, new JValue (value));
			}
		}

	}
}
