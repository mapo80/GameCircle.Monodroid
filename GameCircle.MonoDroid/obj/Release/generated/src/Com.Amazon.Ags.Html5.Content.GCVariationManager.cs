using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='GCVariationManager']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/content/GCVariationManager", DoNotGenerateAcw=true)]
	public partial class GCVariationManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.html5.content']/interface[@name='GCVariationManager.GCVariationManagerRefreshCallback']"
		[Register ("com/amazon/ags/html5/content/GCVariationManager$GCVariationManagerRefreshCallback", "", "Com.Amazon.Ags.Html5.Content.GCVariationManager/IGCVariationManagerRefreshCallbackInvoker")]
		public partial interface IGCVariationManagerRefreshCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/interface[@name='GCVariationManager.GCVariationManagerRefreshCallback']/method[@name='onRefreshCompleted' and count(parameter)=0]"
			[Register ("onRefreshCompleted", "()V", "GetOnRefreshCompletedHandler:Com.Amazon.Ags.Html5.Content.GCVariationManager/IGCVariationManagerRefreshCallbackInvoker, GameCircle.MonoDroid")]
			void OnRefreshCompleted ();

		}

		[global::Android.Runtime.Register ("com/amazon/ags/html5/content/GCVariationManager$GCVariationManagerRefreshCallback", DoNotGenerateAcw=true)]
		internal class IGCVariationManagerRefreshCallbackInvoker : global::Java.Lang.Object, IGCVariationManagerRefreshCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/html5/content/GCVariationManager$GCVariationManagerRefreshCallback");
			IntPtr class_ref;

			public static IGCVariationManagerRefreshCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGCVariationManagerRefreshCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.html5.content.GCVariationManager.GCVariationManagerRefreshCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGCVariationManagerRefreshCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGCVariationManagerRefreshCallbackInvoker); }
			}

			static Delegate cb_onRefreshCompleted;
#pragma warning disable 0169
			static Delegate GetOnRefreshCompletedHandler ()
			{
				if (cb_onRefreshCompleted == null)
					cb_onRefreshCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRefreshCompleted);
				return cb_onRefreshCompleted;
			}

			static void n_OnRefreshCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRefreshCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onRefreshCompleted;
			public void OnRefreshCompleted ()
			{
				if (id_onRefreshCompleted == IntPtr.Zero)
					id_onRefreshCompleted = JNIEnv.GetMethodID (class_ref, "onRefreshCompleted", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onRefreshCompleted);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/content/GCVariationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GCVariationManager); }
		}

		protected GCVariationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='GCVariationManager']/constructor[@name='GCVariationManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GCVariationManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GCVariationManager)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='GCVariationManager']/constructor[@name='GCVariationManager' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public GCVariationManager (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (GCVariationManager)) {
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

		static Delegate cb_getCachedVariations;
#pragma warning disable 0169
		static Delegate GetGetCachedVariationsHandler ()
		{
			if (cb_getCachedVariations == null)
				cb_getCachedVariations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedVariations);
			return cb_getCachedVariations;
		}

		static IntPtr n_GetCachedVariations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Content.GCVariationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.GCVariationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CachedVariations);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedVariations;
		public virtual global::System.Collections.Generic.IDictionary<string, string> CachedVariations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='GCVariationManager']/method[@name='getCachedVariations' and count(parameter)=0]"
			[Register ("getCachedVariations", "()Ljava/util/Map;", "GetGetCachedVariationsHandler")]
			get {
				if (id_getCachedVariations == IntPtr.Zero)
					id_getCachedVariations = JNIEnv.GetMethodID (class_ref, "getCachedVariations", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCachedVariations), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCachedVariations), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_;
#pragma warning disable 0169
		static Delegate GetRefreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_Handler ()
		{
			if (cb_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_ == null)
				cb_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_);
			return cb_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_;
		}

		static void n_RefreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Html5.Content.GCVariationManager __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.GCVariationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback p1 = (global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RefreshVariations (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.content']/class[@name='GCVariationManager']/method[@name='refreshVariations' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.ags.html5.content.GCVariationManager.GCVariationManagerRefreshCallback']]"
		[Register ("refreshVariations", "(Landroid/content/Context;Lcom/amazon/ags/html5/content/GCVariationManager$GCVariationManagerRefreshCallback;)V", "GetRefreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_Handler")]
		public virtual void RefreshVariations (global::Android.Content.Context p0, global::Com.Amazon.Ags.Html5.Content.GCVariationManager.IGCVariationManagerRefreshCallback p1)
		{
			if (id_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_ == IntPtr.Zero)
				id_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_ = JNIEnv.GetMethodID (class_ref, "refreshVariations", "(Landroid/content/Context;Lcom/amazon/ags/html5/content/GCVariationManager$GCVariationManagerRefreshCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_refreshVariations_Landroid_content_Context_Lcom_amazon_ags_html5_content_GCVariationManager_GCVariationManagerRefreshCallback_, new JValue (p0), new JValue (p1));
		}

	}
}
