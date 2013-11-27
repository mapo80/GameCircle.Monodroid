using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Achievements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']"
	[Register ("com/amazon/ags/api/achievements/Achievement", "", "Com.Amazon.Ags.Api.Achievements.IAchievementInvoker")]
	public partial interface IAchievement : IJavaObject {

		global::Java.Util.Date DateUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getDateUnlocked' and count(parameter)=0]"
			[Register ("getDateUnlocked", "()Ljava/util/Date;", "GetGetDateUnlockedHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getImageURL' and count(parameter)=0]"
			[Register ("getImageURL", "()Ljava/lang/String;", "GetGetImageURLHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='isHidden' and count(parameter)=0]"
			[Register ("isHidden", "()Z", "GetIsHiddenHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		bool IsUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='isUnlocked' and count(parameter)=0]"
			[Register ("isUnlocked", "()Z", "GetIsUnlockedHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		int PointValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getPointValue' and count(parameter)=0]"
			[Register ("getPointValue", "()I", "GetGetPointValueHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		float Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()F", "GetGetProgressHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.achievements']/interface[@name='Achievement']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Amazon.Ags.Api.Achievements.IAchievementInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/achievements/Achievement", DoNotGenerateAcw=true)]
	internal class IAchievementInvoker : global::Java.Lang.Object, IAchievement {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/achievements/Achievement");
		IntPtr class_ref;

		public static IAchievement GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAchievement> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.achievements.Achievement"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAchievementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAchievementInvoker); }
		}

		static Delegate cb_getDateUnlocked;
#pragma warning disable 0169
		static Delegate GetGetDateUnlockedHandler ()
		{
			if (cb_getDateUnlocked == null)
				cb_getDateUnlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateUnlocked);
			return cb_getDateUnlocked;
		}

		static IntPtr n_GetDateUnlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DateUnlocked);
		}
#pragma warning restore 0169

		IntPtr id_getDateUnlocked;
		public global::Java.Util.Date DateUnlocked {
			get {
				if (id_getDateUnlocked == IntPtr.Zero)
					id_getDateUnlocked = JNIEnv.GetMethodID (class_ref, "getDateUnlocked", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getDateUnlocked), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageURL;
#pragma warning disable 0169
		static Delegate GetGetImageURLHandler ()
		{
			if (cb_getImageURL == null)
				cb_getImageURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageURL);
			return cb_getImageURL;
		}

		static IntPtr n_GetImageURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		IntPtr id_getImageURL;
		public string ImageURL {
			get {
				if (id_getImageURL == IntPtr.Zero)
					id_getImageURL = JNIEnv.GetMethodID (class_ref, "getImageURL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getImageURL), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isHidden;
#pragma warning disable 0169
		static Delegate GetIsHiddenHandler ()
		{
			if (cb_isHidden == null)
				cb_isHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHidden);
			return cb_isHidden;
		}

		static bool n_IsHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHidden;
		}
#pragma warning restore 0169

		IntPtr id_isHidden;
		public bool IsHidden {
			get {
				if (id_isHidden == IntPtr.Zero)
					id_isHidden = JNIEnv.GetMethodID (class_ref, "isHidden", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isHidden);
			}
		}

		static Delegate cb_isUnlocked;
#pragma warning disable 0169
		static Delegate GetIsUnlockedHandler ()
		{
			if (cb_isUnlocked == null)
				cb_isUnlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnlocked);
			return cb_isUnlocked;
		}

		static bool n_IsUnlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnlocked;
		}
#pragma warning restore 0169

		IntPtr id_isUnlocked;
		public bool IsUnlocked {
			get {
				if (id_isUnlocked == IntPtr.Zero)
					id_isUnlocked = JNIEnv.GetMethodID (class_ref, "isUnlocked", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isUnlocked);
			}
		}

		static Delegate cb_getPointValue;
#pragma warning disable 0169
		static Delegate GetGetPointValueHandler ()
		{
			if (cb_getPointValue == null)
				cb_getPointValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPointValue);
			return cb_getPointValue;
		}

		static int n_GetPointValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointValue;
		}
#pragma warning restore 0169

		IntPtr id_getPointValue;
		public int PointValue {
			get {
				if (id_getPointValue == IntPtr.Zero)
					id_getPointValue = JNIEnv.GetMethodID (class_ref, "getPointValue", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPointValue);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosition);
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		IntPtr id_getPosition;
		public int Position {
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPosition);
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetProgress);
			return cb_getProgress;
		}

		static float n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		IntPtr id_getProgress;
		public float Progress {
			get {
				if (id_getProgress == IntPtr.Zero)
					id_getProgress = JNIEnv.GetMethodID (class_ref, "getProgress", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getProgress);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Achievements.IAchievement __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Achievements.IAchievement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
