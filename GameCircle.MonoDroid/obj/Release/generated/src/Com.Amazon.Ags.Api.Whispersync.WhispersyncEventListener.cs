using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']"
	[global::Android.Runtime.Register ("com/amazon/ags/api/whispersync/WhispersyncEventListener", DoNotGenerateAcw=true)]
	public partial class WhispersyncEventListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/api/whispersync/WhispersyncEventListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncEventListener); }
		}

		protected WhispersyncEventListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/constructor[@name='WhispersyncEventListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WhispersyncEventListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncEventListener)) {
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

		static Delegate cb_onDataUploadedToCloud;
#pragma warning disable 0169
		static Delegate GetOnDataUploadedToCloudHandler ()
		{
			if (cb_onDataUploadedToCloud == null)
				cb_onDataUploadedToCloud = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDataUploadedToCloud);
			return cb_onDataUploadedToCloud;
		}

		static void n_OnDataUploadedToCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataUploadedToCloud ();
		}
#pragma warning restore 0169

		static IntPtr id_onDataUploadedToCloud;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/method[@name='onDataUploadedToCloud' and count(parameter)=0]"
		[Register ("onDataUploadedToCloud", "()V", "GetOnDataUploadedToCloudHandler")]
		public virtual void OnDataUploadedToCloud ()
		{
			if (id_onDataUploadedToCloud == IntPtr.Zero)
				id_onDataUploadedToCloud = JNIEnv.GetMethodID (class_ref, "onDataUploadedToCloud", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDataUploadedToCloud);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onDataUploadedToCloud);
		}

		static Delegate cb_onDiskWriteComplete;
#pragma warning disable 0169
		static Delegate GetOnDiskWriteCompleteHandler ()
		{
			if (cb_onDiskWriteComplete == null)
				cb_onDiskWriteComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDiskWriteComplete);
			return cb_onDiskWriteComplete;
		}

		static void n_OnDiskWriteComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDiskWriteComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onDiskWriteComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/method[@name='onDiskWriteComplete' and count(parameter)=0]"
		[Register ("onDiskWriteComplete", "()V", "GetOnDiskWriteCompleteHandler")]
		public virtual void OnDiskWriteComplete ()
		{
			if (id_onDiskWriteComplete == IntPtr.Zero)
				id_onDiskWriteComplete = JNIEnv.GetMethodID (class_ref, "onDiskWriteComplete", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDiskWriteComplete);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onDiskWriteComplete);
		}

		static Delegate cb_onFirstSynchronize;
#pragma warning disable 0169
		static Delegate GetOnFirstSynchronizeHandler ()
		{
			if (cb_onFirstSynchronize == null)
				cb_onFirstSynchronize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFirstSynchronize);
			return cb_onFirstSynchronize;
		}

		static void n_OnFirstSynchronize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstSynchronize ();
		}
#pragma warning restore 0169

		static IntPtr id_onFirstSynchronize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/method[@name='onFirstSynchronize' and count(parameter)=0]"
		[Register ("onFirstSynchronize", "()V", "GetOnFirstSynchronizeHandler")]
		public virtual void OnFirstSynchronize ()
		{
			if (id_onFirstSynchronize == IntPtr.Zero)
				id_onFirstSynchronize = JNIEnv.GetMethodID (class_ref, "onFirstSynchronize", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFirstSynchronize);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onFirstSynchronize);
		}

		static Delegate cb_onNewCloudData;
#pragma warning disable 0169
		static Delegate GetOnNewCloudDataHandler ()
		{
			if (cb_onNewCloudData == null)
				cb_onNewCloudData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNewCloudData);
			return cb_onNewCloudData;
		}

		static void n_OnNewCloudData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNewCloudData ();
		}
#pragma warning restore 0169

		static IntPtr id_onNewCloudData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/method[@name='onNewCloudData' and count(parameter)=0]"
		[Register ("onNewCloudData", "()V", "GetOnNewCloudDataHandler")]
		public virtual void OnNewCloudData ()
		{
			if (id_onNewCloudData == IntPtr.Zero)
				id_onNewCloudData = JNIEnv.GetMethodID (class_ref, "onNewCloudData", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onNewCloudData);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onNewCloudData);
		}

		static Delegate cb_onThrottled;
#pragma warning disable 0169
		static Delegate GetOnThrottledHandler ()
		{
			if (cb_onThrottled == null)
				cb_onThrottled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnThrottled);
			return cb_onThrottled;
		}

		static void n_OnThrottled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.WhispersyncEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnThrottled ();
		}
#pragma warning restore 0169

		static IntPtr id_onThrottled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.whispersync']/class[@name='WhispersyncEventListener']/method[@name='onThrottled' and count(parameter)=0]"
		[Register ("onThrottled", "()V", "GetOnThrottledHandler")]
		public virtual void OnThrottled ()
		{
			if (id_onThrottled == IntPtr.Zero)
				id_onThrottled = JNIEnv.GetMethodID (class_ref, "onThrottled", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onThrottled);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onThrottled);
		}

	}
}
