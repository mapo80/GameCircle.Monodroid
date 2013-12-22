using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Insights.Delivery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore.EventIterator']"
	[Register ("com/amazon/insights/delivery/EventStore$EventIterator", "", "Com.Amazon.Insights.Delivery.IEventStoreEventIteratorInvoker")]
	public partial interface IEventStoreEventIterator : global::Java.Util.IIterator {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore.EventIterator']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/String;", "GetPeekHandler:Com.Amazon.Insights.Delivery.IEventStoreEventIteratorInvoker, AmazonInsights.MonoDroid")]
		string Peek ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore.EventIterator']/method[@name='removeReadEvents' and count(parameter)=0]"
		[Register ("removeReadEvents", "()V", "GetRemoveReadEventsHandler:Com.Amazon.Insights.Delivery.IEventStoreEventIteratorInvoker, AmazonInsights.MonoDroid")]
		void RemoveReadEvents ();

	}

	[global::Android.Runtime.Register ("com/amazon/insights/delivery/EventStore$EventIterator", DoNotGenerateAcw=true)]
	internal class IEventStoreEventIteratorInvoker : global::Java.Lang.Object, IEventStoreEventIterator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/delivery/EventStore$EventIterator");
		IntPtr class_ref;

		public static IEventStoreEventIterator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventStoreEventIterator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.delivery.EventStore.EventIterator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventStoreEventIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventStoreEventIteratorInvoker); }
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Peek ());
		}
#pragma warning restore 0169

		IntPtr id_peek;
		public string Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_peek), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeReadEvents;
#pragma warning disable 0169
		static Delegate GetRemoveReadEventsHandler ()
		{
			if (cb_removeReadEvents == null)
				cb_removeReadEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveReadEvents);
			return cb_removeReadEvents;
		}

		static void n_RemoveReadEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveReadEvents ();
		}
#pragma warning restore 0169

		IntPtr id_removeReadEvents;
		public void RemoveReadEvents ()
		{
			if (id_removeReadEvents == IntPtr.Zero)
				id_removeReadEvents = JNIEnv.GetMethodID (class_ref, "removeReadEvents", "()V");
			JNIEnv.CallVoidMethod (Handle, id_removeReadEvents);
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetGetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasNext);
			return cb_hasNext;
		}

		static bool n_GetHasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public global::System.Boolean HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasNext);
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		IntPtr id_next;
		public global::Java.Lang.Object Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_next), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod (Handle, id_remove);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore']"
	[Register ("com/amazon/insights/delivery/EventStore", "", "Com.Amazon.Insights.Delivery.IEventStoreInvoker")]
	public partial interface IEventStore : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Lcom/amazon/insights/delivery/EventStore$EventIterator;", "GetIteratorHandler:Com.Amazon.Insights.Delivery.IEventStoreInvoker, AmazonInsights.MonoDroid")]
		global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.insights.delivery']/interface[@name='EventStore']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;)Z", "GetPut_Ljava_lang_String_Handler:Com.Amazon.Insights.Delivery.IEventStoreInvoker, AmazonInsights.MonoDroid")]
		bool Put (string p0);

	}

	[global::Android.Runtime.Register ("com/amazon/insights/delivery/EventStore", DoNotGenerateAcw=true)]
	internal class IEventStoreInvoker : global::Java.Lang.Object, IEventStore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/insights/delivery/EventStore");
		IntPtr class_ref;

		public static IEventStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.insights.delivery.EventStore"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventStoreInvoker); }
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Insights.Delivery.IEventStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Lcom/amazon/insights/delivery/EventStore$EventIterator;");
			return global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStoreEventIterator> (JNIEnv.CallObjectMethod (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_put_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_;
		}

		static bool n_Put_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Insights.Delivery.IEventStore __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Insights.Delivery.IEventStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_;
		public bool Put (string p0)
		{
			if (id_put_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_put_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
