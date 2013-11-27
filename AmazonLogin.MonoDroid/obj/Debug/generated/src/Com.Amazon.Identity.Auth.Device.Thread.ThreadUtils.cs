using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='ThreadUtils']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/thread/ThreadUtils", DoNotGenerateAcw=true)]
	public sealed partial class ThreadUtils : global::Java.Lang.Object {


		static IntPtr THREAD_POOL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='ThreadUtils']/field[@name='THREAD_POOL']"
		[Register ("THREAD_POOL")]
		public static global::Java.Util.Concurrent.IExecutor ThreadPool {
			get {
				if (THREAD_POOL_jfieldId == IntPtr.Zero)
					THREAD_POOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREAD_POOL", "Ljava/util/concurrent/Executor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREAD_POOL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (THREAD_POOL_jfieldId == IntPtr.Zero)
					THREAD_POOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREAD_POOL", "Ljava/util/concurrent/Executor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, THREAD_POOL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/thread/ThreadUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadUtils); }
		}

		internal ThreadUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isRunningOnMainThread;
		public static bool IsRunningOnMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.thread']/class[@name='ThreadUtils']/method[@name='isRunningOnMainThread' and count(parameter)=0]"
			[Register ("isRunningOnMainThread", "()Z", "GetIsRunningOnMainThreadHandler")]
			get {
				if (id_isRunningOnMainThread == IntPtr.Zero)
					id_isRunningOnMainThread = JNIEnv.GetStaticMethodID (class_ref, "isRunningOnMainThread", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRunningOnMainThread);
			}
		}

	}
}
