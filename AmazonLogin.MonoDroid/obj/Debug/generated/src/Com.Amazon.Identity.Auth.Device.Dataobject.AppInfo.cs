using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AppInfo", DoNotGenerateAcw=true)]
	public partial class AppInfo : global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject {


		static IntPtr ALL_COLUMNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/field[@name='ALL_COLUMNS']"
		[Register ("ALL_COLUMNS")]
		public static IList<string> AllColumns {
			get {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALL_COLUMNS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				IntPtr native_value = JavaArray<string>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ALL_COLUMNS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/field[@name='DELIM']"
		[Register ("DELIM")]
		public const string Delim = (string) ",";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX", DoNotGenerateAcw=true)]
		public sealed partial class COL_INDEX : global::Java.Lang.Enum {


			static IntPtr ALLOWED_SCOPES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='ALLOWED_SCOPES']"
			[Register ("ALLOWED_SCOPES")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX AllowedScopes {
				get {
					if (ALLOWED_SCOPES_jfieldId == IntPtr.Zero)
						ALLOWED_SCOPES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOWED_SCOPES", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALLOWED_SCOPES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALLOWED_SCOPES_jfieldId == IntPtr.Zero)
						ALLOWED_SCOPES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOWED_SCOPES", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALLOWED_SCOPES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_FAMILY_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='APP_FAMILY_ID']"
			[Register ("APP_FAMILY_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX AppFamilyId {
				get {
					if (APP_FAMILY_ID_jfieldId == IntPtr.Zero)
						APP_FAMILY_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_FAMILY_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_FAMILY_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_FAMILY_ID_jfieldId == IntPtr.Zero)
						APP_FAMILY_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_FAMILY_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_FAMILY_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_VARIANT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='APP_VARIANT_ID']"
			[Register ("APP_VARIANT_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX AppVariantId {
				get {
					if (APP_VARIANT_ID_jfieldId == IntPtr.Zero)
						APP_VARIANT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VARIANT_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_VARIANT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_VARIANT_ID_jfieldId == IntPtr.Zero)
						APP_VARIANT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VARIANT_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_VARIANT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX ClientId {
				get {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_ID_jfieldId == IntPtr.Zero)
						CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GRANTED_PERMISSIONS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='GRANTED_PERMISSIONS']"
			[Register ("GRANTED_PERMISSIONS")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX GrantedPermissions {
				get {
					if (GRANTED_PERMISSIONS_jfieldId == IntPtr.Zero)
						GRANTED_PERMISSIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRANTED_PERMISSIONS", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GRANTED_PERMISSIONS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GRANTED_PERMISSIONS_jfieldId == IntPtr.Zero)
						GRANTED_PERMISSIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRANTED_PERMISSIONS", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GRANTED_PERMISSIONS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PACKAGE_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='PACKAGE_NAME']"
			[Register ("PACKAGE_NAME")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX PackageName {
				get {
					if (PACKAGE_NAME_jfieldId == IntPtr.Zero)
						PACKAGE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAME", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PACKAGE_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PACKAGE_NAME_jfieldId == IntPtr.Zero)
						PACKAGE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PACKAGE_NAME", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PACKAGE_NAME_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PAYLOAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='PAYLOAD']"
			[Register ("PAYLOAD")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX Payload {
				get {
					if (PAYLOAD_jfieldId == IntPtr.Zero)
						PAYLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYLOAD", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYLOAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PAYLOAD_jfieldId == IntPtr.Zero)
						PAYLOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYLOAD", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PAYLOAD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ROW_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='ROW_ID']"
			[Register ("ROW_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX RowId {
				get {
					if (ROW_ID_jfieldId == IntPtr.Zero)
						ROW_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROW_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ROW_ID_jfieldId == IntPtr.Zero)
						ROW_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_ID", "Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ROW_ID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr colId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/field[@name='colId']"
			[Register ("colId")]
			public int ColId {
				get {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					return JNIEnv.GetIntField (Handle, colId_jfieldId);
				}
				set {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					JNIEnv.SetField (Handle, colId_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (COL_INDEX); }
			}

			internal COL_INDEX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo.COL_INDEX']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;", "")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/AppInfo$COL_INDEX;");
				return (global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo.COL_INDEX));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AppInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppInfo); }
		}

		protected AppInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/constructor[@name='AppInfo' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public AppInfo (string p0, string p1, string p2, string[] p3, string[] p4, string p5, global::Org.Json.JSONObject p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = JNIEnv.NewArray (p3);;
			IntPtr native_p4 = JNIEnv.NewArray (p4);;
			IntPtr native_p5 = JNIEnv.NewString (p5);;
			if (GetType () != typeof (AppInfo)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				JNIEnv.DeleteLocalRef (native_p5);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (native_p5), new JValue (p6));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/constructor[@name='AppInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AppInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AppInfo)) {
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

		static Delegate cb_getAppFamilyId;
#pragma warning disable 0169
		static Delegate GetGetAppFamilyIdHandler ()
		{
			if (cb_getAppFamilyId == null)
				cb_getAppFamilyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppFamilyId);
			return cb_getAppFamilyId;
		}

		static IntPtr n_GetAppFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppFamilyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppFamilyId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppFamilyId_Ljava_lang_String_ == null)
				cb_setAppFamilyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppFamilyId_Ljava_lang_String_);
			return cb_setAppFamilyId_Ljava_lang_String_;
		}

		static void n_SetAppFamilyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppFamilyId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		static IntPtr id_setAppFamilyId_Ljava_lang_String_;
		public virtual string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getAppFamilyId' and count(parameter)=0]"
			[Register ("getAppFamilyId", "()Ljava/lang/String;", "GetGetAppFamilyIdHandler")]
			get {
				if (id_getAppFamilyId == IntPtr.Zero)
					id_getAppFamilyId = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setAppFamilyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppFamilyId", "(Ljava/lang/String;)V", "GetSetAppFamilyId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppFamilyId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppFamilyId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppFamilyId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppFamilyId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAppFamilyId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppVariantId;
#pragma warning disable 0169
		static Delegate GetGetAppVariantIdHandler ()
		{
			if (cb_getAppVariantId == null)
				cb_getAppVariantId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVariantId);
			return cb_getAppVariantId;
		}

		static IntPtr n_GetAppVariantId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVariantId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppVariantId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppVariantId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppVariantId_Ljava_lang_String_ == null)
				cb_setAppVariantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppVariantId_Ljava_lang_String_);
			return cb_setAppVariantId_Ljava_lang_String_;
		}

		static void n_SetAppVariantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppVariantId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppVariantId;
		static IntPtr id_setAppVariantId_Ljava_lang_String_;
		public virtual string AppVariantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getAppVariantId' and count(parameter)=0]"
			[Register ("getAppVariantId", "()Ljava/lang/String;", "GetGetAppVariantIdHandler")]
			get {
				if (id_getAppVariantId == IntPtr.Zero)
					id_getAppVariantId = JNIEnv.GetMethodID (class_ref, "getAppVariantId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVariantId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppVariantId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setAppVariantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppVariantId", "(Ljava/lang/String;)V", "GetSetAppVariantId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppVariantId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppVariantId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppVariantId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppVariantId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAppVariantId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientId_Ljava_lang_String_ == null)
				cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientId_Ljava_lang_String_);
			return cb_setClientId_Ljava_lang_String_;
		}

		static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		static IntPtr id_setClientId_Ljava_lang_String_;
		public virtual string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getClientId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClientId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setClientId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setPackageName_Ljava_lang_String_ == null)
				cb_setPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPackageName_Ljava_lang_String_);
			return cb_setPackageName_Ljava_lang_String_;
		}

		static void n_SetPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPackageName;
		static IntPtr id_setPackageName_Ljava_lang_String_;
		public virtual string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPackageName), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPackageName", "(Ljava/lang/String;)V", "GetSetPackageName_Ljava_lang_String_Handler")]
			set {
				if (id_setPackageName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPackageName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPackageName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPackageName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getValuesForInsert;
#pragma warning disable 0169
		static Delegate GetGetValuesForInsertHandler ()
		{
			if (cb_getValuesForInsert == null)
				cb_getValuesForInsert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValuesForInsert);
			return cb_getValuesForInsert;
		}

		static IntPtr n_GetValuesForInsert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getValuesForInsert;
		public override global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getValuesForInsert' and count(parameter)=0]"
			[Register ("getValuesForInsert", "()Landroid/content/ContentValues;", "GetGetValuesForInsertHandler")]
			get {
				if (id_getValuesForInsert == IntPtr.Zero)
					id_getValuesForInsert = JNIEnv.GetMethodID (class_ref, "getValuesForInsert", "()Landroid/content/ContentValues;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/amazon/identity/auth/device/dataobject/AppInfo;", "GetCloneHandler")]
		public virtual global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/amazon/identity/auth/device/dataobject/AppInfo;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_getAllowedRemoteScopes;
#pragma warning disable 0169
		static Delegate GetGetAllowedRemoteScopesHandler ()
		{
			if (cb_getAllowedRemoteScopes == null)
				cb_getAllowedRemoteScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllowedRemoteScopes);
			return cb_getAllowedRemoteScopes;
		}

		static IntPtr n_GetAllowedRemoteScopes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllowedRemoteScopes ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllowedRemoteScopes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getAllowedRemoteScopes' and count(parameter)=0]"
		[Register ("getAllowedRemoteScopes", "()[Ljava/lang/String;", "GetGetAllowedRemoteScopesHandler")]
		public virtual string[] GetAllowedRemoteScopes ()
		{
			if (id_getAllowedRemoteScopes == IntPtr.Zero)
				id_getAllowedRemoteScopes = JNIEnv.GetMethodID (class_ref, "getAllowedRemoteScopes", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllowedRemoteScopes), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAllowedRemoteScopes), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getAllowedScopes;
#pragma warning disable 0169
		static Delegate GetGetAllowedScopesHandler ()
		{
			if (cb_getAllowedScopes == null)
				cb_getAllowedScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllowedScopes);
			return cb_getAllowedScopes;
		}

		static IntPtr n_GetAllowedScopes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllowedScopes ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllowedScopes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getAllowedScopes' and count(parameter)=0]"
		[Register ("getAllowedScopes", "()[Ljava/lang/String;", "GetGetAllowedScopesHandler")]
		public virtual string[] GetAllowedScopes ()
		{
			if (id_getAllowedScopes == IntPtr.Zero)
				id_getAllowedScopes = JNIEnv.GetMethodID (class_ref, "getAllowedScopes", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllowedScopes), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAllowedScopes), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getAttributeByKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttributeByKey_Ljava_lang_String_Handler ()
		{
			if (cb_getAttributeByKey_Ljava_lang_String_ == null)
				cb_getAttributeByKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttributeByKey_Ljava_lang_String_);
			return cb_getAttributeByKey_Ljava_lang_String_;
		}

		static IntPtr n_GetAttributeByKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAttributeByKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeByKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getAttributeByKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttributeByKey", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAttributeByKey_Ljava_lang_String_Handler")]
		public virtual string GetAttributeByKey (string p0)
		{
			if (id_getAttributeByKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttributeByKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttributeByKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAttributeByKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAttributeByKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDataSource_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetDataSource_Landroid_content_Context_Handler ()
		{
			if (cb_getDataSource_Landroid_content_Context_ == null)
				cb_getDataSource_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSource_Landroid_content_Context_);
			return cb_getDataSource_Landroid_content_Context_;
		}

		static IntPtr n_GetDataSource_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AppInfoDataSource;", "GetGetDataSource_Landroid_content_Context_Handler")]
		public override global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AppInfoDataSource;");

			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getGrantedPermissions;
#pragma warning disable 0169
		static Delegate GetGetGrantedPermissionsHandler ()
		{
			if (cb_getGrantedPermissions == null)
				cb_getGrantedPermissions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantedPermissions);
			return cb_getGrantedPermissions;
		}

		static IntPtr n_GetGrantedPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedPermissions ());
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedPermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='getGrantedPermissions' and count(parameter)=0]"
		[Register ("getGrantedPermissions", "()[Ljava/lang/String;", "GetGetGrantedPermissionsHandler")]
		public virtual string[] GetGrantedPermissions ()
		{
			if (id_getGrantedPermissions == IntPtr.Zero)
				id_getGrantedPermissions = JNIEnv.GetMethodID (class_ref, "getGrantedPermissions", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getGrantedPermissions), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getGrantedPermissions), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_setAllowedScopes_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAllowedScopes_arrayLjava_lang_String_Handler ()
		{
			if (cb_setAllowedScopes_arrayLjava_lang_String_ == null)
				cb_setAllowedScopes_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAllowedScopes_arrayLjava_lang_String_);
			return cb_setAllowedScopes_arrayLjava_lang_String_;
		}

		static void n_SetAllowedScopes_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetAllowedScopes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowedScopes_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setAllowedScopes' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setAllowedScopes", "([Ljava/lang/String;)V", "GetSetAllowedScopes_arrayLjava_lang_String_Handler")]
		public virtual void SetAllowedScopes (string[] p0)
		{
			if (id_setAllowedScopes_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setAllowedScopes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAllowedScopes", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAllowedScopes_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAllowedScopes_arrayLjava_lang_String_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGrantedPermissions_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGrantedPermissions_arrayLjava_lang_String_Handler ()
		{
			if (cb_setGrantedPermissions_arrayLjava_lang_String_ == null)
				cb_setGrantedPermissions_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGrantedPermissions_arrayLjava_lang_String_);
			return cb_setGrantedPermissions_arrayLjava_lang_String_;
		}

		static void n_SetGrantedPermissions_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetGrantedPermissions (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGrantedPermissions_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setGrantedPermissions' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setGrantedPermissions", "([Ljava/lang/String;)V", "GetSetGrantedPermissions_arrayLjava_lang_String_Handler")]
		public virtual void SetGrantedPermissions (string[] p0)
		{
			if (id_setGrantedPermissions_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setGrantedPermissions_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGrantedPermissions", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGrantedPermissions_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setGrantedPermissions_arrayLjava_lang_String_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPayload_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPayload_Ljava_lang_String_Handler ()
		{
			if (cb_setPayload_Ljava_lang_String_ == null)
				cb_setPayload_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_Ljava_lang_String_);
			return cb_setPayload_Ljava_lang_String_;
		}

		static void n_SetPayload_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPayload (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPayload_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPayload", "(Ljava/lang/String;)V", "GetSetPayload_Ljava_lang_String_Handler")]
		public virtual void SetPayload (string p0)
		{
			if (id_setPayload_Ljava_lang_String_ == IntPtr.Zero)
				id_setPayload_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPayload", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPayload_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPayload_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPayload_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetPayload_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setPayload_Lorg_json_JSONObject_ == null)
				cb_setPayload_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_Lorg_json_JSONObject_);
			return cb_setPayload_Lorg_json_JSONObject_;
		}

		static void n_SetPayload_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPayload (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPayload_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AppInfo']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setPayload", "(Lorg/json/JSONObject;)V", "GetSetPayload_Lorg_json_JSONObject_Handler")]
		public virtual void SetPayload (global::Org.Json.JSONObject p0)
		{
			if (id_setPayload_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setPayload_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setPayload", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPayload_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPayload_Lorg_json_JSONObject_, new JValue (p0));
		}

	}
}
