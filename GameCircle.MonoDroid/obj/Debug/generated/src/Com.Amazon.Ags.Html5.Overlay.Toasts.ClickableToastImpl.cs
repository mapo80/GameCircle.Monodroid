using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Html5.Overlay.Toasts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']"
	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastImpl", DoNotGenerateAcw=true)]
	public abstract partial class ClickableToastImpl : global::Android.Widget.LinearLayout, global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToast {


		static IntPtr hideAnimation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/field[@name='hideAnimation']"
		[Register ("hideAnimation")]
		protected global::Android.Views.Animations.Animation HideAnimation {
			get {
				if (hideAnimation_jfieldId == IntPtr.Zero)
					hideAnimation_jfieldId = JNIEnv.GetFieldID (class_ref, "hideAnimation", "Landroid/view/animation/Animation;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, hideAnimation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (hideAnimation_jfieldId == IntPtr.Zero)
					hideAnimation_jfieldId = JNIEnv.GetFieldID (class_ref, "hideAnimation", "Landroid/view/animation/Animation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, hideAnimation_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr showAnimation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/field[@name='showAnimation']"
		[Register ("showAnimation")]
		protected global::Android.Views.Animations.Animation ShowAnimation {
			get {
				if (showAnimation_jfieldId == IntPtr.Zero)
					showAnimation_jfieldId = JNIEnv.GetFieldID (class_ref, "showAnimation", "Landroid/view/animation/Animation;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, showAnimation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (showAnimation_jfieldId == IntPtr.Zero)
					showAnimation_jfieldId = JNIEnv.GetFieldID (class_ref, "showAnimation", "Landroid/view/animation/Animation;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, showAnimation_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']"
		[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams", DoNotGenerateAcw=true)]
		public partial class ToastParams : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ToastParams); }
			}

			protected ToastParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/constructor[@name='ClickableToastImpl.ToastParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public ToastParams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ToastParams)) {
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

			static Delegate cb_getDuration;
#pragma warning disable 0169
			static Delegate GetGetDurationHandler ()
			{
				if (cb_getDuration == null)
					cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
				return cb_getDuration;
			}

			static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static Delegate cb_setDuration_J;
#pragma warning disable 0169
			static Delegate GetSetDuration_JHandler ()
			{
				if (cb_setDuration_J == null)
					cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDuration_J);
				return cb_setDuration_J;
			}

			static void n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Duration = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			static IntPtr id_setDuration_J;
			public virtual long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "GetGetDurationHandler")]
				get {
					if (id_getDuration == IntPtr.Zero)
						id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getDuration);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
				set {
					if (id_setDuration_J == IntPtr.Zero)
						id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDuration_J, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDuration_J, new JValue (value));
				}
			}

			static Delegate cb_getFadeInDuration;
#pragma warning disable 0169
			static Delegate GetGetFadeInDurationHandler ()
			{
				if (cb_getFadeInDuration == null)
					cb_getFadeInDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFadeInDuration);
				return cb_getFadeInDuration;
			}

			static long n_GetFadeInDuration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FadeInDuration;
			}
#pragma warning restore 0169

			static Delegate cb_setFadeInDuration_J;
#pragma warning disable 0169
			static Delegate GetSetFadeInDuration_JHandler ()
			{
				if (cb_setFadeInDuration_J == null)
					cb_setFadeInDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetFadeInDuration_J);
				return cb_setFadeInDuration_J;
			}

			static void n_SetFadeInDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FadeInDuration = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getFadeInDuration;
			static IntPtr id_setFadeInDuration_J;
			public virtual long FadeInDuration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getFadeInDuration' and count(parameter)=0]"
				[Register ("getFadeInDuration", "()J", "GetGetFadeInDurationHandler")]
				get {
					if (id_getFadeInDuration == IntPtr.Zero)
						id_getFadeInDuration = JNIEnv.GetMethodID (class_ref, "getFadeInDuration", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getFadeInDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getFadeInDuration);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setFadeInDuration' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setFadeInDuration", "(J)V", "GetSetFadeInDuration_JHandler")]
				set {
					if (id_setFadeInDuration_J == IntPtr.Zero)
						id_setFadeInDuration_J = JNIEnv.GetMethodID (class_ref, "setFadeInDuration", "(J)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFadeInDuration_J, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFadeInDuration_J, new JValue (value));
				}
			}

			static Delegate cb_getFadeOutDuration;
#pragma warning disable 0169
			static Delegate GetGetFadeOutDurationHandler ()
			{
				if (cb_getFadeOutDuration == null)
					cb_getFadeOutDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFadeOutDuration);
				return cb_getFadeOutDuration;
			}

			static long n_GetFadeOutDuration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FadeOutDuration;
			}
#pragma warning restore 0169

			static Delegate cb_setFadeOutDuration_J;
#pragma warning disable 0169
			static Delegate GetSetFadeOutDuration_JHandler ()
			{
				if (cb_setFadeOutDuration_J == null)
					cb_setFadeOutDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetFadeOutDuration_J);
				return cb_setFadeOutDuration_J;
			}

			static void n_SetFadeOutDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FadeOutDuration = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getFadeOutDuration;
			static IntPtr id_setFadeOutDuration_J;
			public virtual long FadeOutDuration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getFadeOutDuration' and count(parameter)=0]"
				[Register ("getFadeOutDuration", "()J", "GetGetFadeOutDurationHandler")]
				get {
					if (id_getFadeOutDuration == IntPtr.Zero)
						id_getFadeOutDuration = JNIEnv.GetMethodID (class_ref, "getFadeOutDuration", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getFadeOutDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getFadeOutDuration);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setFadeOutDuration' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setFadeOutDuration", "(J)V", "GetSetFadeOutDuration_JHandler")]
				set {
					if (id_setFadeOutDuration_J == IntPtr.Zero)
						id_setFadeOutDuration_J = JNIEnv.GetMethodID (class_ref, "setFadeOutDuration", "(J)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFadeOutDuration_J, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFadeOutDuration_J, new JValue (value));
				}
			}

			static Delegate cb_getHideAnimationResource;
#pragma warning disable 0169
			static Delegate GetGetHideAnimationResourceHandler ()
			{
				if (cb_getHideAnimationResource == null)
					cb_getHideAnimationResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHideAnimationResource);
				return cb_getHideAnimationResource;
			}

			static int n_GetHideAnimationResource (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HideAnimationResource;
			}
#pragma warning restore 0169

			static Delegate cb_setHideAnimationResource_I;
#pragma warning disable 0169
			static Delegate GetSetHideAnimationResource_IHandler ()
			{
				if (cb_setHideAnimationResource_I == null)
					cb_setHideAnimationResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHideAnimationResource_I);
				return cb_setHideAnimationResource_I;
			}

			static void n_SetHideAnimationResource_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HideAnimationResource = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getHideAnimationResource;
			static IntPtr id_setHideAnimationResource_I;
			public virtual int HideAnimationResource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getHideAnimationResource' and count(parameter)=0]"
				[Register ("getHideAnimationResource", "()I", "GetGetHideAnimationResourceHandler")]
				get {
					if (id_getHideAnimationResource == IntPtr.Zero)
						id_getHideAnimationResource = JNIEnv.GetMethodID (class_ref, "getHideAnimationResource", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHideAnimationResource);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getHideAnimationResource);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setHideAnimationResource' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setHideAnimationResource", "(I)V", "GetSetHideAnimationResource_IHandler")]
				set {
					if (id_setHideAnimationResource_I == IntPtr.Zero)
						id_setHideAnimationResource_I = JNIEnv.GetMethodID (class_ref, "setHideAnimationResource", "(I)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHideAnimationResource_I, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setHideAnimationResource_I, new JValue (value));
				}
			}

			static Delegate cb_getHorizontalMarginLandscape;
#pragma warning disable 0169
			static Delegate GetGetHorizontalMarginLandscapeHandler ()
			{
				if (cb_getHorizontalMarginLandscape == null)
					cb_getHorizontalMarginLandscape = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHorizontalMarginLandscape);
				return cb_getHorizontalMarginLandscape;
			}

			static float n_GetHorizontalMarginLandscape (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HorizontalMarginLandscape;
			}
#pragma warning restore 0169

			static Delegate cb_setHorizontalMarginLandscape_F;
#pragma warning disable 0169
			static Delegate GetSetHorizontalMarginLandscape_FHandler ()
			{
				if (cb_setHorizontalMarginLandscape_F == null)
					cb_setHorizontalMarginLandscape_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHorizontalMarginLandscape_F);
				return cb_setHorizontalMarginLandscape_F;
			}

			static void n_SetHorizontalMarginLandscape_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HorizontalMarginLandscape = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getHorizontalMarginLandscape;
			static IntPtr id_setHorizontalMarginLandscape_F;
			public virtual float HorizontalMarginLandscape {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getHorizontalMarginLandscape' and count(parameter)=0]"
				[Register ("getHorizontalMarginLandscape", "()F", "GetGetHorizontalMarginLandscapeHandler")]
				get {
					if (id_getHorizontalMarginLandscape == IntPtr.Zero)
						id_getHorizontalMarginLandscape = JNIEnv.GetMethodID (class_ref, "getHorizontalMarginLandscape", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getHorizontalMarginLandscape);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getHorizontalMarginLandscape);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setHorizontalMarginLandscape' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setHorizontalMarginLandscape", "(F)V", "GetSetHorizontalMarginLandscape_FHandler")]
				set {
					if (id_setHorizontalMarginLandscape_F == IntPtr.Zero)
						id_setHorizontalMarginLandscape_F = JNIEnv.GetMethodID (class_ref, "setHorizontalMarginLandscape", "(F)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHorizontalMarginLandscape_F, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setHorizontalMarginLandscape_F, new JValue (value));
				}
			}

			static Delegate cb_getHorizontalMarginPortrait;
#pragma warning disable 0169
			static Delegate GetGetHorizontalMarginPortraitHandler ()
			{
				if (cb_getHorizontalMarginPortrait == null)
					cb_getHorizontalMarginPortrait = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHorizontalMarginPortrait);
				return cb_getHorizontalMarginPortrait;
			}

			static float n_GetHorizontalMarginPortrait (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HorizontalMarginPortrait;
			}
#pragma warning restore 0169

			static Delegate cb_setHorizontalMarginPortrait_F;
#pragma warning disable 0169
			static Delegate GetSetHorizontalMarginPortrait_FHandler ()
			{
				if (cb_setHorizontalMarginPortrait_F == null)
					cb_setHorizontalMarginPortrait_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHorizontalMarginPortrait_F);
				return cb_setHorizontalMarginPortrait_F;
			}

			static void n_SetHorizontalMarginPortrait_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HorizontalMarginPortrait = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getHorizontalMarginPortrait;
			static IntPtr id_setHorizontalMarginPortrait_F;
			public virtual float HorizontalMarginPortrait {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getHorizontalMarginPortrait' and count(parameter)=0]"
				[Register ("getHorizontalMarginPortrait", "()F", "GetGetHorizontalMarginPortraitHandler")]
				get {
					if (id_getHorizontalMarginPortrait == IntPtr.Zero)
						id_getHorizontalMarginPortrait = JNIEnv.GetMethodID (class_ref, "getHorizontalMarginPortrait", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getHorizontalMarginPortrait);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getHorizontalMarginPortrait);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setHorizontalMarginPortrait' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setHorizontalMarginPortrait", "(F)V", "GetSetHorizontalMarginPortrait_FHandler")]
				set {
					if (id_setHorizontalMarginPortrait_F == IntPtr.Zero)
						id_setHorizontalMarginPortrait_F = JNIEnv.GetMethodID (class_ref, "setHorizontalMarginPortrait", "(F)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHorizontalMarginPortrait_F, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setHorizontalMarginPortrait_F, new JValue (value));
				}
			}

			static Delegate cb_getPopUpLocation;
#pragma warning disable 0169
			static Delegate GetGetPopUpLocationHandler ()
			{
				if (cb_getPopUpLocation == null)
					cb_getPopUpLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPopUpLocation);
				return cb_getPopUpLocation;
			}

			static IntPtr n_GetPopUpLocation (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PopUpLocation);
			}
#pragma warning restore 0169

			static Delegate cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
#pragma warning disable 0169
			static Delegate GetSetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_Handler ()
			{
				if (cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == null)
					cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_);
				return cb_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
			}

			static void n_SetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Ags.Api.Overlay.PopUpLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PopUpLocation = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getPopUpLocation;
			static IntPtr id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_;
			public virtual global::Com.Amazon.Ags.Api.Overlay.PopUpLocation PopUpLocation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getPopUpLocation' and count(parameter)=0]"
				[Register ("getPopUpLocation", "()Lcom/amazon/ags/api/overlay/PopUpLocation;", "GetGetPopUpLocationHandler")]
				get {
					if (id_getPopUpLocation == IntPtr.Zero)
						id_getPopUpLocation = JNIEnv.GetMethodID (class_ref, "getPopUpLocation", "()Lcom/amazon/ags/api/overlay/PopUpLocation;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (JNIEnv.CallObjectMethod  (Handle, id_getPopUpLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Overlay.PopUpLocation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPopUpLocation), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setPopUpLocation' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.overlay.PopUpLocation']]"
				[Register ("setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V", "GetSetPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_Handler")]
				set {
					if (id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ == IntPtr.Zero)
						id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_ = JNIEnv.GetMethodID (class_ref, "setPopUpLocation", "(Lcom/amazon/ags/api/overlay/PopUpLocation;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPopUpLocation_Lcom_amazon_ags_api_overlay_PopUpLocation_, new JValue (value));
				}
			}

			static Delegate cb_getShowAnimationResource;
#pragma warning disable 0169
			static Delegate GetGetShowAnimationResourceHandler ()
			{
				if (cb_getShowAnimationResource == null)
					cb_getShowAnimationResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShowAnimationResource);
				return cb_getShowAnimationResource;
			}

			static int n_GetShowAnimationResource (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ShowAnimationResource;
			}
#pragma warning restore 0169

			static Delegate cb_setShowAnimationResource_I;
#pragma warning disable 0169
			static Delegate GetSetShowAnimationResource_IHandler ()
			{
				if (cb_setShowAnimationResource_I == null)
					cb_setShowAnimationResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShowAnimationResource_I);
				return cb_setShowAnimationResource_I;
			}

			static void n_SetShowAnimationResource_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowAnimationResource = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getShowAnimationResource;
			static IntPtr id_setShowAnimationResource_I;
			public virtual int ShowAnimationResource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getShowAnimationResource' and count(parameter)=0]"
				[Register ("getShowAnimationResource", "()I", "GetGetShowAnimationResourceHandler")]
				get {
					if (id_getShowAnimationResource == IntPtr.Zero)
						id_getShowAnimationResource = JNIEnv.GetMethodID (class_ref, "getShowAnimationResource", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getShowAnimationResource);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getShowAnimationResource);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setShowAnimationResource' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setShowAnimationResource", "(I)V", "GetSetShowAnimationResource_IHandler")]
				set {
					if (id_setShowAnimationResource_I == IntPtr.Zero)
						id_setShowAnimationResource_I = JNIEnv.GetMethodID (class_ref, "setShowAnimationResource", "(I)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setShowAnimationResource_I, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowAnimationResource_I, new JValue (value));
				}
			}

			static Delegate cb_getVerticalMarginLandscape;
#pragma warning disable 0169
			static Delegate GetGetVerticalMarginLandscapeHandler ()
			{
				if (cb_getVerticalMarginLandscape == null)
					cb_getVerticalMarginLandscape = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVerticalMarginLandscape);
				return cb_getVerticalMarginLandscape;
			}

			static float n_GetVerticalMarginLandscape (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.VerticalMarginLandscape;
			}
#pragma warning restore 0169

			static Delegate cb_setVerticalMarginLandscape_F;
#pragma warning disable 0169
			static Delegate GetSetVerticalMarginLandscape_FHandler ()
			{
				if (cb_setVerticalMarginLandscape_F == null)
					cb_setVerticalMarginLandscape_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVerticalMarginLandscape_F);
				return cb_setVerticalMarginLandscape_F;
			}

			static void n_SetVerticalMarginLandscape_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VerticalMarginLandscape = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getVerticalMarginLandscape;
			static IntPtr id_setVerticalMarginLandscape_F;
			public virtual float VerticalMarginLandscape {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getVerticalMarginLandscape' and count(parameter)=0]"
				[Register ("getVerticalMarginLandscape", "()F", "GetGetVerticalMarginLandscapeHandler")]
				get {
					if (id_getVerticalMarginLandscape == IntPtr.Zero)
						id_getVerticalMarginLandscape = JNIEnv.GetMethodID (class_ref, "getVerticalMarginLandscape", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getVerticalMarginLandscape);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getVerticalMarginLandscape);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setVerticalMarginLandscape' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setVerticalMarginLandscape", "(F)V", "GetSetVerticalMarginLandscape_FHandler")]
				set {
					if (id_setVerticalMarginLandscape_F == IntPtr.Zero)
						id_setVerticalMarginLandscape_F = JNIEnv.GetMethodID (class_ref, "setVerticalMarginLandscape", "(F)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVerticalMarginLandscape_F, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setVerticalMarginLandscape_F, new JValue (value));
				}
			}

			static Delegate cb_getVerticalMarginPortrait;
#pragma warning disable 0169
			static Delegate GetGetVerticalMarginPortraitHandler ()
			{
				if (cb_getVerticalMarginPortrait == null)
					cb_getVerticalMarginPortrait = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVerticalMarginPortrait);
				return cb_getVerticalMarginPortrait;
			}

			static float n_GetVerticalMarginPortrait (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.VerticalMarginPortrait;
			}
#pragma warning restore 0169

			static Delegate cb_setVerticalMarginPortrait_F;
#pragma warning disable 0169
			static Delegate GetSetVerticalMarginPortrait_FHandler ()
			{
				if (cb_setVerticalMarginPortrait_F == null)
					cb_setVerticalMarginPortrait_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVerticalMarginPortrait_F);
				return cb_setVerticalMarginPortrait_F;
			}

			static void n_SetVerticalMarginPortrait_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VerticalMarginPortrait = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getVerticalMarginPortrait;
			static IntPtr id_setVerticalMarginPortrait_F;
			public virtual float VerticalMarginPortrait {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='getVerticalMarginPortrait' and count(parameter)=0]"
				[Register ("getVerticalMarginPortrait", "()F", "GetGetVerticalMarginPortraitHandler")]
				get {
					if (id_getVerticalMarginPortrait == IntPtr.Zero)
						id_getVerticalMarginPortrait = JNIEnv.GetMethodID (class_ref, "getVerticalMarginPortrait", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getVerticalMarginPortrait);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getVerticalMarginPortrait);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl.ToastParams']/method[@name='setVerticalMarginPortrait' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setVerticalMarginPortrait", "(F)V", "GetSetVerticalMarginPortrait_FHandler")]
				set {
					if (id_setVerticalMarginPortrait_F == IntPtr.Zero)
						id_setVerticalMarginPortrait_F = JNIEnv.GetMethodID (class_ref, "setVerticalMarginPortrait", "(F)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVerticalMarginPortrait_F, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setVerticalMarginPortrait_F, new JValue (value));
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/html5/overlay/toasts/ClickableToastImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickableToastImpl); }
		}

		protected ClickableToastImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/constructor[@name='ClickableToastImpl' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public ClickableToastImpl (global::Android.App.Activity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClickableToastImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/constructor[@name='ClickableToastImpl' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.amazon.ags.html5.overlay.toasts.ClickableToastImpl.ToastParams']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;)V", "")]
		public ClickableToastImpl (global::Android.App.Activity p0, global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl.ToastParams p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClickableToastImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_app_Activity_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/amazon/ags/html5/overlay/toasts/ClickableToastImpl$ToastParams;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastImpl_ToastParams_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isShowing;
		public virtual bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowing);
			}
		}

		static Delegate cb_getWindowManagerParams;
#pragma warning disable 0169
		static Delegate GetGetWindowManagerParamsHandler ()
		{
			if (cb_getWindowManagerParams == null)
				cb_getWindowManagerParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWindowManagerParams);
			return cb_getWindowManagerParams;
		}

		static IntPtr n_GetWindowManagerParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WindowManagerParams);
		}
#pragma warning restore 0169

		static IntPtr id_getWindowManagerParams;
		protected virtual global::Android.Views.WindowManagerLayoutParams WindowManagerParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='getWindowManagerParams' and count(parameter)=0]"
			[Register ("getWindowManagerParams", "()Landroid/view/WindowManager$LayoutParams;", "GetGetWindowManagerParamsHandler")]
			get {
				if (id_getWindowManagerParams == IntPtr.Zero)
					id_getWindowManagerParams = JNIEnv.GetMethodID (class_ref, "getWindowManagerParams", "()Landroid/view/WindowManager$LayoutParams;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.WindowManagerLayoutParams> (JNIEnv.CallObjectMethod  (Handle, id_getWindowManagerParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.WindowManagerLayoutParams> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getWindowManagerParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
#pragma warning disable 0169
		static Delegate GetAddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_Handler ()
		{
			if (cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ == null)
				cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_);
			return cb_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
		}

		static void n_AddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver p0 = (global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddClickableToastObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='addClickableToastObserver' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.html5.overlay.toasts.ClickableToastObserver']]"
		[Register ("addClickableToastObserver", "(Lcom/amazon/ags/html5/overlay/toasts/ClickableToastObserver;)V", "GetAddClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_Handler")]
		public virtual void AddClickableToastObserver (global::Com.Amazon.Ags.Html5.Overlay.Toasts.IClickableToastObserver p0)
		{
			if (id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ == IntPtr.Zero)
				id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_ = JNIEnv.GetMethodID (class_ref, "addClickableToastObserver", "(Lcom/amazon/ags/html5/overlay/toasts/ClickableToastObserver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addClickableToastObserver_Lcom_amazon_ags_html5_overlay_toasts_ClickableToastObserver_, new JValue (p0));
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_destroy);
		}

		static Delegate cb_initAnimations;
#pragma warning disable 0169
		static Delegate GetInitAnimationsHandler ()
		{
			if (cb_initAnimations == null)
				cb_initAnimations = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitAnimations);
			return cb_initAnimations;
		}

		static void n_InitAnimations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitAnimations ();
		}
#pragma warning restore 0169

		static IntPtr id_initAnimations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='initAnimations' and count(parameter)=0]"
		[Register ("initAnimations", "()V", "GetInitAnimationsHandler")]
		protected virtual void InitAnimations ()
		{
			if (id_initAnimations == IntPtr.Zero)
				id_initAnimations = JNIEnv.GetMethodID (class_ref, "initAnimations", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initAnimations);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initAnimations);
		}

		static Delegate cb_initView;
#pragma warning disable 0169
		static Delegate GetInitViewHandler ()
		{
			if (cb_initView == null)
				cb_initView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InitView);
			return cb_initView;
		}

		static IntPtr n_InitView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitView ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='initView' and count(parameter)=0]"
		[Register ("initView", "()Landroid/view/View;", "GetInitViewHandler")]
		protected abstract global::Android.Views.View InitView ();

		static Delegate cb_onDetachedFromWindow;
#pragma warning disable 0169
		static Delegate GetOnDetachedFromWindowHandler ()
		{
			if (cb_onDetachedFromWindow == null)
				cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetachedFromWindow);
			return cb_onDetachedFromWindow;
		}

		static void n_OnDetachedFromWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetachedFromWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_onDetachedFromWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public virtual void OnDetachedFromWindow ()
		{
			if (id_onDetachedFromWindow == IntPtr.Zero)
				id_onDetachedFromWindow = JNIEnv.GetMethodID (class_ref, "onDetachedFromWindow", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDetachedFromWindow);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onDetachedFromWindow);
		}

		static Delegate cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetToastOnTouchListener_Landroid_view_View_OnTouchListener_Handler ()
		{
			if (cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ == null)
				cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToastOnTouchListener_Landroid_view_View_OnTouchListener_);
			return cb_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
		}

		static void n_SetToastOnTouchListener_Landroid_view_View_OnTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnTouchListener p0 = (global::Android.Views.View.IOnTouchListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetToastOnTouchListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='setToastOnTouchListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnTouchListener']]"
		[Register ("setToastOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", "GetSetToastOnTouchListener_Landroid_view_View_OnTouchListener_Handler")]
		public virtual void SetToastOnTouchListener (global::Android.Views.View.IOnTouchListener p0)
		{
			if (id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ == IntPtr.Zero)
				id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_ = JNIEnv.GetMethodID (class_ref, "setToastOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setToastOnTouchListener_Landroid_view_View_OnTouchListener_, new JValue (p0));
		}

		static Delegate cb_show_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_os_Handler_Handler ()
		{
			if (cb_show_Landroid_os_Handler_ == null)
				cb_show_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Show_Landroid_os_Handler_);
			return cb_show_Landroid_os_Handler_;
		}

		static void n_Show_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("show", "(Landroid/os/Handler;)V", "GetShow_Landroid_os_Handler_Handler")]
		public virtual void Show (global::Android.OS.Handler p0)
		{
			if (id_show_Landroid_os_Handler_ == IntPtr.Zero)
				id_show_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/os/Handler;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_show_Landroid_os_Handler_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_show_Landroid_os_Handler_, new JValue (p0));
		}

		static Delegate cb_update_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_String_IHandler ()
		{
			if (cb_update_Ljava_lang_String_I == null)
				cb_update_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Update_Ljava_lang_String_I);
			return cb_update_Ljava_lang_String_I;
		}

		static void n_Update_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("update", "(Ljava/lang/String;I)V", "GetUpdate_Ljava_lang_String_IHandler")]
		public abstract void Update (string p0, int p1);

		static Delegate cb_setToastData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToastData_Ljava_lang_String_Handler ()
		{
			if (cb_setToastData_Ljava_lang_String_ == null)
				cb_setToastData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToastData_Ljava_lang_String_);
			return cb_setToastData_Ljava_lang_String_;
		}

		static void n_SetToastData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Html5.Overlay.Toasts.ClickableToastImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetToastData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='setToastData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToastData", "(Ljava/lang/String;)V", "GetSetToastData_Ljava_lang_String_Handler")]
		public abstract void SetToastData (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/html5/overlay/toasts/ClickableToastImpl", DoNotGenerateAcw=true)]
	internal partial class ClickableToastImplInvoker : ClickableToastImpl {

		public ClickableToastImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickableToastImplInvoker); }
		}

		static IntPtr id_initView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='initView' and count(parameter)=0]"
		[Register ("initView", "()Landroid/view/View;", "GetInitViewHandler")]
		protected override global::Android.Views.View InitView ()
		{
			if (id_initView == IntPtr.Zero)
				id_initView = JNIEnv.GetMethodID (class_ref, "initView", "()Landroid/view/View;");
			return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_initView), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_update_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("update", "(Ljava/lang/String;I)V", "GetUpdate_Ljava_lang_String_IHandler")]
		public override void Update (string p0, int p1)
		{
			if (id_update_Ljava_lang_String_I == IntPtr.Zero)
				id_update_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setToastData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.html5.overlay.toasts']/class[@name='ClickableToastImpl']/method[@name='setToastData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setToastData", "(Ljava/lang/String;)V", "GetSetToastData_Ljava_lang_String_Handler")]
		public override void SetToastData (string p0)
		{
			if (id_setToastData_Ljava_lang_String_ == IntPtr.Zero)
				id_setToastData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToastData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setToastData_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
