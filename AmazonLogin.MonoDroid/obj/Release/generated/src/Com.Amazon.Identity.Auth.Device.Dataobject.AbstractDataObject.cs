using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AbstractDataObject", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDataObject : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/field[@name='NON_EXISTENT_ROW']"
		[Register ("NON_EXISTENT_ROW")]
		public const int NonExistentRow = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AbstractDataObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataObject); }
		}

		protected AbstractDataObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/constructor[@name='AbstractDataObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AbstractDataObject () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractDataObject)) {
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

		static Delegate cb_getRowId;
#pragma warning disable 0169
		static Delegate GetGetRowIdHandler ()
		{
			if (cb_getRowId == null)
				cb_getRowId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRowId);
			return cb_getRowId;
		}

		static long n_GetRowId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RowId;
		}
#pragma warning restore 0169

		static Delegate cb_setRowId_J;
#pragma warning disable 0169
		static Delegate GetSetRowId_JHandler ()
		{
			if (cb_setRowId_J == null)
				cb_setRowId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRowId_J);
			return cb_setRowId_J;
		}

		static void n_SetRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RowId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRowId;
		static IntPtr id_setRowId_J;
		public virtual long RowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getRowId' and count(parameter)=0]"
			[Register ("getRowId", "()J", "GetGetRowIdHandler")]
			get {
				if (id_getRowId == IntPtr.Zero)
					id_getRowId = JNIEnv.GetMethodID (class_ref, "getRowId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRowId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getRowId);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='setRowId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRowId", "(J)V", "GetSetRowId_JHandler")]
			set {
				if (id_setRowId_J == IntPtr.Zero)
					id_setRowId_J = JNIEnv.GetMethodID (class_ref, "setRowId", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRowId_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRowId_J, new JValue (value));
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getValuesForInsert' and count(parameter)=0]"
			[Register ("getValuesForInsert", "()Landroid/content/ContentValues;", "GetGetValuesForInsertHandler")] get;
		}

		static Delegate cb_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAreObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AreObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_AreObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AreObjectsEqual (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='areObjectsEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("areObjectsEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetAreObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected virtual bool AreObjectsEqual (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "areObjectsEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_areObjectsEqual_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_delete_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDelete_Landroid_content_Context_Handler ()
		{
			if (cb_delete_Landroid_content_Context_ == null)
				cb_delete_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Delete_Landroid_content_Context_);
			return cb_delete_Landroid_content_Context_;
		}

		static bool n_Delete_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("delete", "(Landroid/content/Context;)Z", "GetDelete_Landroid_content_Context_Handler")]
		public virtual bool Delete (global::Android.Content.Context p0)
		{
			if (id_delete_Landroid_content_Context_ == IntPtr.Zero)
				id_delete_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "delete", "(Landroid/content/Context;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_delete_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_delete_Landroid_content_Context_, new JValue (p0));
			return __ret;
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public abstract bool Equals (global::Java.Lang.Object p0);

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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AbstractDataSource;", "GetGetDataSource_Landroid_content_Context_Handler")]
		public abstract global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource (global::Android.Content.Context p0);

		static Delegate cb_insert_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_content_Context_Handler ()
		{
			if (cb_insert_Landroid_content_Context_ == null)
				cb_insert_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Insert_Landroid_content_Context_);
			return cb_insert_Landroid_content_Context_;
		}

		static long n_Insert_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Insert (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("insert", "(Landroid/content/Context;)J", "GetInsert_Landroid_content_Context_Handler")]
		public virtual long Insert (global::Android.Content.Context p0)
		{
			if (id_insert_Landroid_content_Context_ == IntPtr.Zero)
				id_insert_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/content/Context;)J");

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_insert_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_insert_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_insertOrUpdate_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInsertOrUpdate_Landroid_content_Context_Handler ()
		{
			if (cb_insertOrUpdate_Landroid_content_Context_ == null)
				cb_insertOrUpdate_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InsertOrUpdate_Landroid_content_Context_);
			return cb_insertOrUpdate_Landroid_content_Context_;
		}

		static bool n_InsertOrUpdate_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InsertOrUpdate (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insertOrUpdate_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='insertOrUpdate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("insertOrUpdate", "(Landroid/content/Context;)Z", "GetInsertOrUpdate_Landroid_content_Context_Handler")]
		public virtual bool InsertOrUpdate (global::Android.Content.Context p0)
		{
			if (id_insertOrUpdate_Landroid_content_Context_ == IntPtr.Zero)
				id_insertOrUpdate_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "insertOrUpdate", "(Landroid/content/Context;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_insertOrUpdate_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_insertOrUpdate_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_update_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_content_Context_Handler ()
		{
			if (cb_update_Landroid_content_Context_ == null)
				cb_update_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Update_Landroid_content_Context_);
			return cb_update_Landroid_content_Context_;
		}

		static bool n_Update_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Update (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='update' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("update", "(Landroid/content/Context;)Z", "GetUpdate_Landroid_content_Context_Handler")]
		public virtual bool Update (global::Android.Content.Context p0)
		{
			if (id_update_Landroid_content_Context_ == IntPtr.Zero)
				id_update_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/content/Context;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_update_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_update_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AbstractDataObject", DoNotGenerateAcw=true)]
	internal partial class AbstractDataObjectInvoker : AbstractDataObject {

		public AbstractDataObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataObjectInvoker); }
		}

		static IntPtr id_getValuesForInsert;
		public override global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getValuesForInsert' and count(parameter)=0]"
			[Register ("getValuesForInsert", "()Landroid/content/ContentValues;", "GetGetValuesForInsertHandler")]
			get {
				if (id_getValuesForInsert == IntPtr.Zero)
					id_getValuesForInsert = JNIEnv.GetMethodID (class_ref, "getValuesForInsert", "()Landroid/content/ContentValues;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AbstractDataObject']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AbstractDataSource;", "GetGetDataSource_Landroid_content_Context_Handler")]
		public override global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AbstractDataSource;");
			global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
