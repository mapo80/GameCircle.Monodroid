using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseHandle']"
	[Register ("com/amazon/ags/api/GCResponseHandle", "", "Com.Amazon.Ags.Api.IGCResponseHandleInvoker")]
	public partial interface IGCResponseHandle : IJavaObject {

		bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseHandle']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler:Com.Amazon.Ags.Api.IGCResponseHandleInvoker, GameCircle.MonoDroid")] get;
		}

		global::Java.Lang.Object Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api']/interface[@name='GCResponseHandle']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/amazon/ags/api/RequestResponse;", "GetGetResponseHandler:Com.Amazon.Ags.Api.IGCResponseHandleInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/GCResponseHandle", DoNotGenerateAcw=true)]
	internal class IGCResponseHandleInvoker : global::Java.Lang.Object, IGCResponseHandle {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/GCResponseHandle");
		IntPtr class_ref;

		public static IGCResponseHandle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGCResponseHandle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.GCResponseHandle"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGCResponseHandleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGCResponseHandleInvoker); }
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IGCResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IGCResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		IntPtr id_isDone;
		public bool IsDone {
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDone);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.IGCResponseHandle __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IGCResponseHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public global::Java.Lang.Object Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lcom/amazon/ags/api/RequestResponse;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
