using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Achievements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='AchievementsClient']"
	[Register ("com/amazon/ags/api/achievements/AchievementsClient", "", "Com.Amazon.Ags.Api.Achievements.IAchievementsClientInvoker")]
	public partial interface IAchievementsClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='AchievementsClient']/method[@name='getAchievement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetAchievement_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Achievements.IAchievementsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievement (string p0, params global:: Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='AchievementsClient']/method[@name='getAchievements' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetGetAchievements_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Achievements.IAchievementsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievements (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='AchievementsClient']/method[@name='showAchievementsOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("showAchievementsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetShowAchievementsOverlay_arrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Achievements.IAchievementsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle ShowAchievementsOverlay (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='AchievementsClient']/method[@name='updateProgress' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;", "GetUpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_Handler:Com.Amazon.Ags.Api.Achievements.IAchievementsClientInvoker, GameCircle.MonoDroid")]
		global::Com.Amazon.Ags.Api.IAGResponseHandle UpdateProgress (string p0, float p1, params global:: Java.Lang.Object[] p2);

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/achievements/AchievementsClient", DoNotGenerateAcw=true)]
	internal class IAchievementsClientInvoker : global::Java.Lang.Object, IAchievementsClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/achievements/AchievementsClient");
		IntPtr class_ref;

		public static IAchievementsClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAchievementsClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.achievements.AchievementsClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAchievementsClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAchievementsClientInvoker); }
		}

		static Delegate cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAchievement_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAchievement_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetAchievement_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAchievement (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievement (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAchievement", "(Ljava/lang/String;[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getAchievement_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getAchievements_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAchievements_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getAchievements_arrayLjava_lang_Object_ == null)
				cb_getAchievements_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAchievements_arrayLjava_lang_Object_);
			return cb_getAchievements_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetAchievements_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAchievements (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAchievements_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle GetAchievements (params global:: Java.Lang.Object[] p0)
		{
			if (id_getAchievements_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getAchievements_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAchievements", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_getAchievements_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_showAchievementsOverlay_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetShowAchievementsOverlay_arrayLjava_lang_Object_Handler ()
		{
			if (cb_showAchievementsOverlay_arrayLjava_lang_Object_ == null)
				cb_showAchievementsOverlay_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowAchievementsOverlay_arrayLjava_lang_Object_);
			return cb_showAchievementsOverlay_arrayLjava_lang_Object_;
		}

		static IntPtr n_ShowAchievementsOverlay_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowAchievementsOverlay (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showAchievementsOverlay_arrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle ShowAchievementsOverlay (params global:: Java.Lang.Object[] p0)
		{
			if (id_showAchievementsOverlay_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_showAchievementsOverlay_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "showAchievementsOverlay", "([Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_showAchievementsOverlay_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_Handler ()
		{
			if (cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ == null)
				cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr, IntPtr>) n_UpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_);
			return cb_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
		}

		static IntPtr n_UpdateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievementsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateProgress (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_;
		public global::Com.Amazon.Ags.Api.IAGResponseHandle UpdateProgress (string p0, float p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ == IntPtr.Zero)
				id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "updateProgress", "(Ljava/lang/String;F[Ljava/lang/Object;)Lcom/amazon/ags/api/AGResponseHandle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Amazon.Ags.Api.IAGResponseHandle __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IAGResponseHandle> (JNIEnv.CallObjectMethod (Handle, id_updateProgress_Ljava_lang_String_FarrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}

}
