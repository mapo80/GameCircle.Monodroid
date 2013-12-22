using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='JniResponseHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/JniResponseHandler", DoNotGenerateAcw=true)]
	public abstract partial class JniResponseHandler : global::Java.Lang.Object {


		static IntPtr m_CallbackPointer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='JniResponseHandler']/field[@name='m_CallbackPointer']"
		[Register ("m_CallbackPointer")]
		protected long MCallbackPointer {
			get {
				if (m_CallbackPointer_jfieldId == IntPtr.Zero)
					m_CallbackPointer_jfieldId = JNIEnv.GetFieldID (class_ref, "m_CallbackPointer", "J");
				return JNIEnv.GetLongField (Handle, m_CallbackPointer_jfieldId);
			}
			set {
				if (m_CallbackPointer_jfieldId == IntPtr.Zero)
					m_CallbackPointer_jfieldId = JNIEnv.GetFieldID (class_ref, "m_CallbackPointer", "J");
				JNIEnv.SetField (Handle, m_CallbackPointer_jfieldId, value);
			}
		}

		static IntPtr m_DeveloperTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='JniResponseHandler']/field[@name='m_DeveloperTag']"
		[Register ("m_DeveloperTag")]
		protected int MDeveloperTag {
			get {
				if (m_DeveloperTag_jfieldId == IntPtr.Zero)
					m_DeveloperTag_jfieldId = JNIEnv.GetFieldID (class_ref, "m_DeveloperTag", "I");
				return JNIEnv.GetIntField (Handle, m_DeveloperTag_jfieldId);
			}
			set {
				if (m_DeveloperTag_jfieldId == IntPtr.Zero)
					m_DeveloperTag_jfieldId = JNIEnv.GetFieldID (class_ref, "m_DeveloperTag", "I");
				JNIEnv.SetField (Handle, m_DeveloperTag_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/JniResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JniResponseHandler); }
		}

		protected JniResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni']/class[@name='JniResponseHandler']/constructor[@name='JniResponseHandler' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public JniResponseHandler (int p0, long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JniResponseHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IJ)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IJ)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_IJ == IntPtr.Zero)
				id_ctor_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1));
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/jni/JniResponseHandler", DoNotGenerateAcw=true)]
	internal partial class JniResponseHandlerInvoker : JniResponseHandler {

		public JniResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JniResponseHandlerInvoker); }
		}

	}

}
