using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Whispersync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/whispersync/WhispersyncNativeHandler", DoNotGenerateAcw=true)]
	public partial class WhispersyncNativeHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/whispersync/WhispersyncNativeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhispersyncNativeHandler); }
		}

		protected WhispersyncNativeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/constructor[@name='WhispersyncNativeHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WhispersyncNativeHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WhispersyncNativeHandler)) {
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

		static IntPtr id_containsNumber_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='containsNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("containsNumber", "(Ljava/lang/String;I)Z", "")]
		public static bool ContainsNumber (string p0, int p1)
		{
			if (id_containsNumber_Ljava_lang_String_I == IntPtr.Zero)
				id_containsNumber_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "containsNumber", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsNumber_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_containsString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='containsString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsString", "(Ljava/lang/String;)Z", "")]
		public static bool ContainsString (string p0)
		{
			if (id_containsString_Ljava_lang_String_ == IntPtr.Zero)
				id_containsString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsString", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsString_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decrementAccumulatingNumber_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='decrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("decrementAccumulatingNumber", "(Ljava/lang/String;D)V", "")]
		public static void DecrementAccumulatingNumber (string p0, double p1)
		{
			if (id_decrementAccumulatingNumber_Ljava_lang_String_D == IntPtr.Zero)
				id_decrementAccumulatingNumber_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "decrementAccumulatingNumber", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_decrementAccumulatingNumber_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_decrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='decrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decrementAccumulatingNumber", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void DecrementAccumulatingNumber (string p0, string p1)
		{
			if (id_decrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrementAccumulatingNumber", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_decrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_decrementAccumulatingNumber_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='decrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("decrementAccumulatingNumber", "(Ljava/lang/String;J)V", "")]
		public static void DecrementAccumulatingNumber (string p0, long p1)
		{
			if (id_decrementAccumulatingNumber_Ljava_lang_String_J == IntPtr.Zero)
				id_decrementAccumulatingNumber_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "decrementAccumulatingNumber", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_decrementAccumulatingNumber_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public static void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetStaticMethodID (class_ref, "flush", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_flush);
		}

		static IntPtr id_getAccumulatingNumberAsBigDecimal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getAccumulatingNumberAsBigDecimal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccumulatingNumberAsBigDecimal", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetAccumulatingNumberAsBigDecimal (string p0)
		{
			if (id_getAccumulatingNumberAsBigDecimal_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccumulatingNumberAsBigDecimal_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAccumulatingNumberAsBigDecimal", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAccumulatingNumberAsBigDecimal_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAccumulatingNumberAsDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getAccumulatingNumberAsDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccumulatingNumberAsDouble", "(Ljava/lang/String;)D", "")]
		public static double GetAccumulatingNumberAsDouble (string p0)
		{
			if (id_getAccumulatingNumberAsDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccumulatingNumberAsDouble_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAccumulatingNumberAsDouble", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_getAccumulatingNumberAsDouble_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getAccumulatingNumberAsLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getAccumulatingNumberAsLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccumulatingNumberAsLong", "(Ljava/lang/String;)J", "")]
		public static long GetAccumulatingNumberAsLong (string p0)
		{
			if (id_getAccumulatingNumberAsLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccumulatingNumberAsLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAccumulatingNumberAsLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getAccumulatingNumberAsLong_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getLowestLevelElementAsMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getLowestLevelElementAsMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLowestLevelElementAsMap", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/GameDataMap;", "")]
		protected static global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GetLowestLevelElementAsMap (string p0)
		{
			if (id_getLowestLevelElementAsMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getLowestLevelElementAsMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLowestLevelElementAsMap", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/GameDataMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLowestLevelElementAsMap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getLowestLevelKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getLowestLevelKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLowestLevelKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static string GetLowestLevelKey (string p0)
		{
			if (id_getLowestLevelKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getLowestLevelKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLowestLevelKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLowestLevelKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getLowestLevelMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getLowestLevelMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLowestLevelMap", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/GameDataMap;", "")]
		protected static global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap GetLowestLevelMap (string p0)
		{
			if (id_getLowestLevelMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getLowestLevelMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLowestLevelMap", "(Ljava/lang/String;)Lcom/amazon/ags/api/whispersync/GameDataMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.Whispersync.IGameDataMap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLowestLevelMap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMapKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getMapKeys' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMapKeys", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetMapKeys (string p0)
		{
			if (id_getMapKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_getMapKeys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMapKeys", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMapKeys_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMaxSizeNumberList_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getMaxSizeNumberList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getMaxSizeNumberList", "(Ljava/lang/String;I)I", "")]
		public static int GetMaxSizeNumberList (string p0, int p1)
		{
			if (id_getMaxSizeNumberList_Ljava_lang_String_I == IntPtr.Zero)
				id_getMaxSizeNumberList_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getMaxSizeNumberList", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxSizeNumberList_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMaxSizeStringList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getMaxSizeStringList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMaxSizeStringList", "(Ljava/lang/String;)I", "")]
		public static int GetMaxSizeStringList (string p0)
		{
			if (id_getMaxSizeStringList_Ljava_lang_String_ == IntPtr.Zero)
				id_getMaxSizeStringList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMaxSizeStringList", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxSizeStringList_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberAsBigDecimal_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberAsBigDecimal' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberAsBigDecimal", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static string GetNumberAsBigDecimal (string p0, int p1)
		{
			if (id_getNumberAsBigDecimal_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberAsBigDecimal_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberAsBigDecimal", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNumberAsBigDecimal_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberAsDouble_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberAsDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberAsDouble", "(Ljava/lang/String;I)D", "")]
		public static double GetNumberAsDouble (string p0, int p1)
		{
			if (id_getNumberAsDouble_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberAsDouble_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberAsDouble", "(Ljava/lang/String;I)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_getNumberAsDouble_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberAsLong_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberAsLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberAsLong", "(Ljava/lang/String;I)J", "")]
		public static long GetNumberAsLong (string p0, int p1)
		{
			if (id_getNumberAsLong_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberAsLong_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberAsLong", "(Ljava/lang/String;I)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getNumberAsLong_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberListAsBigDecimals_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberListAsBigDecimals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberListAsBigDecimals", "(Ljava/lang/String;I)[Ljava/lang/String;", "")]
		public static string[] GetNumberListAsBigDecimals (string p0, int p1)
		{
			if (id_getNumberListAsBigDecimals_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberListAsBigDecimals_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberListAsBigDecimals", "(Ljava/lang/String;I)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNumberListAsBigDecimals_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberListAsDoubles_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberListAsDoubles' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberListAsDoubles", "(Ljava/lang/String;I)[D", "")]
		public static double[] GetNumberListAsDoubles (string p0, int p1)
		{
			if (id_getNumberListAsDoubles_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberListAsDoubles_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberListAsDoubles", "(Ljava/lang/String;I)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNumberListAsDoubles_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (double));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getNumberListAsLongs_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getNumberListAsLongs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNumberListAsLongs", "(Ljava/lang/String;I)[J", "")]
		public static long[] GetNumberListAsLongs (string p0, int p1)
		{
			if (id_getNumberListAsLongs_Ljava_lang_String_I == IntPtr.Zero)
				id_getNumberListAsLongs_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getNumberListAsLongs", "(Ljava/lang/String;I)[J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNumberListAsLongs_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (long));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getStringList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getStringList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringList", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetStringList (string p0)
		{
			if (id_getStringList_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringList", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getStringListKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getStringListKeys' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringListKeys", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetStringListKeys (string p0)
		{
			if (id_getStringListKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringListKeys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringListKeys", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringListKeys_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getStringSet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getStringSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringSet", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetStringSet (string p0)
		{
			if (id_getStringSet_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringSet_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringSet", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringSet_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getStringSetKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='getStringSetKeys' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringSetKeys", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static string[] GetStringSetKeys (string p0)
		{
			if (id_getStringSetKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringSetKeys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringSetKeys", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringSetKeys_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_incrementAccumulatingNumber_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='incrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("incrementAccumulatingNumber", "(Ljava/lang/String;D)V", "")]
		public static void IncrementAccumulatingNumber (string p0, double p1)
		{
			if (id_incrementAccumulatingNumber_Ljava_lang_String_D == IntPtr.Zero)
				id_incrementAccumulatingNumber_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "incrementAccumulatingNumber", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_incrementAccumulatingNumber_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_incrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='incrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("incrementAccumulatingNumber", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void IncrementAccumulatingNumber (string p0, string p1)
		{
			if (id_incrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_incrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "incrementAccumulatingNumber", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_incrementAccumulatingNumber_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_incrementAccumulatingNumber_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='incrementAccumulatingNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("incrementAccumulatingNumber", "(Ljava/lang/String;J)V", "")]
		public static void IncrementAccumulatingNumber (string p0, long p1)
		{
			if (id_incrementAccumulatingNumber_Ljava_lang_String_J == IntPtr.Zero)
				id_incrementAccumulatingNumber_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "incrementAccumulatingNumber", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_incrementAccumulatingNumber_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_initializeNativeHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='initializeNativeHandler' and count(parameter)=0]"
		[Register ("initializeNativeHandler", "()V", "")]
		public static void InitializeNativeHandler ()
		{
			if (id_initializeNativeHandler == IntPtr.Zero)
				id_initializeNativeHandler = JNIEnv.GetStaticMethodID (class_ref, "initializeNativeHandler", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeNativeHandler);
		}

		static IntPtr id_insertToNumberList_Ljava_lang_String_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='insertToNumberList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("insertToNumberList", "(Ljava/lang/String;DI)V", "")]
		public static void InsertToNumberList (string p0, double p1, int p2)
		{
			if (id_insertToNumberList_Ljava_lang_String_DI == IntPtr.Zero)
				id_insertToNumberList_Ljava_lang_String_DI = JNIEnv.GetStaticMethodID (class_ref, "insertToNumberList", "(Ljava/lang/String;DI)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_insertToNumberList_Ljava_lang_String_DI, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_insertToNumberList_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='insertToNumberList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("insertToNumberList", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public static void InsertToNumberList (string p0, string p1, int p2)
		{
			if (id_insertToNumberList_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_insertToNumberList_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "insertToNumberList", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_insertToNumberList_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_insertToNumberList_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='insertToNumberList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("insertToNumberList", "(Ljava/lang/String;JI)V", "")]
		public static void InsertToNumberList (string p0, long p1, int p2)
		{
			if (id_insertToNumberList_Ljava_lang_String_JI == IntPtr.Zero)
				id_insertToNumberList_Ljava_lang_String_JI = JNIEnv.GetStaticMethodID (class_ref, "insertToNumberList", "(Ljava/lang/String;JI)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_insertToNumberList_Ljava_lang_String_JI, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_insertToStringList_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='insertToStringList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("insertToStringList", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void InsertToStringList (string p0, string p1)
		{
			if (id_insertToStringList_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_insertToStringList_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "insertToStringList", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_insertToStringList_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_insertToStringSet_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='insertToStringSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("insertToStringSet", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void InsertToStringSet (string p0, string p1)
		{
			if (id_insertToStringSet_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_insertToStringSet_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "insertToStringSet", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_insertToStringSet_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setMaxSizeNumberList_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setMaxSizeNumberList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setMaxSizeNumberList", "(Ljava/lang/String;II)V", "")]
		public static void SetMaxSizeNumberList (string p0, int p1, int p2)
		{
			if (id_setMaxSizeNumberList_Ljava_lang_String_II == IntPtr.Zero)
				id_setMaxSizeNumberList_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "setMaxSizeNumberList", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxSizeNumberList_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setMaxSizeStringList_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setMaxSizeStringList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setMaxSizeStringList", "(Ljava/lang/String;I)V", "")]
		public static void SetMaxSizeStringList (string p0, int p1)
		{
			if (id_setMaxSizeStringList_Ljava_lang_String_I == IntPtr.Zero)
				id_setMaxSizeStringList_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxSizeStringList", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxSizeStringList_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setNumber_Ljava_lang_String_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setNumber' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("setNumber", "(Ljava/lang/String;DI)V", "")]
		public static void SetNumber (string p0, double p1, int p2)
		{
			if (id_setNumber_Ljava_lang_String_DI == IntPtr.Zero)
				id_setNumber_Ljava_lang_String_DI = JNIEnv.GetStaticMethodID (class_ref, "setNumber", "(Ljava/lang/String;DI)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setNumber_Ljava_lang_String_DI, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setNumber_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setNumber' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setNumber", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public static void SetNumber (string p0, string p1, int p2)
		{
			if (id_setNumber_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_setNumber_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setNumber", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setNumber_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setNumber_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setNumber' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("setNumber", "(Ljava/lang/String;JI)V", "")]
		public static void SetNumber (string p0, long p1, int p2)
		{
			if (id_setNumber_Ljava_lang_String_JI == IntPtr.Zero)
				id_setNumber_Ljava_lang_String_JI = JNIEnv.GetStaticMethodID (class_ref, "setNumber", "(Ljava/lang/String;JI)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setNumber_Ljava_lang_String_JI, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='setString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setString", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void SetString (string p0, string p1)
		{
			if (id_setString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_stringSetContains_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='stringSetContains' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stringSetContains", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool StringSetContains (string p0, string p1)
		{
			if (id_stringSetContains_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stringSetContains_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringSetContains", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_stringSetContains_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_synchronize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.whispersync']/class[@name='WhispersyncNativeHandler']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "")]
		public static void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetStaticMethodID (class_ref, "synchronize", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_synchronize);
		}

	}
}
