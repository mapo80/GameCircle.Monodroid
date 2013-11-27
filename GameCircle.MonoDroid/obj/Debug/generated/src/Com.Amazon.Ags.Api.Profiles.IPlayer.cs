using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Api.Profiles {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.ags.api.profiles']/interface[@name='Player']"
	[Register ("com/amazon/ags/api/profiles/Player", "", "Com.Amazon.Ags.Api.Profiles.IPlayerInvoker")]
	public partial interface IPlayer : IJavaObject {

		string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.profiles']/interface[@name='Player']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler:Com.Amazon.Ags.Api.Profiles.IPlayerInvoker, GameCircle.MonoDroid")] get;
		}

		string PlayerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.api.profiles']/interface[@name='Player']/method[@name='getPlayerId' and count(parameter)=0]"
			[Register ("getPlayerId", "()Ljava/lang/String;", "GetGetPlayerIdHandler:Com.Amazon.Ags.Api.Profiles.IPlayerInvoker, GameCircle.MonoDroid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/ags/api/profiles/Player", DoNotGenerateAcw=true)]
	internal class IPlayerInvoker : global::Java.Lang.Object, IPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/ags/api/profiles/Player");
		IntPtr class_ref;

		public static IPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.ags.api.profiles.Player"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPlayerInvoker); }
		}

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Profiles.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		IntPtr id_getAlias;
		public string Alias {
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlayerId;
#pragma warning disable 0169
		static Delegate GetGetPlayerIdHandler ()
		{
			if (cb_getPlayerId == null)
				cb_getPlayerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerId);
			return cb_getPlayerId;
		}

		static IntPtr n_GetPlayerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Ags.Api.Profiles.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Profiles.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerId);
		}
#pragma warning restore 0169

		IntPtr id_getPlayerId;
		public string PlayerId {
			get {
				if (id_getPlayerId == IntPtr.Zero)
					id_getPlayerId = JNIEnv.GetMethodID (class_ref, "getPlayerId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPlayerId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
