using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/amazon/insights/core/http",
						"com/amazon/insights/core/idresolver",
						"com/amazon/insights/core/system",
					},
					new Converter<string, Type>[]{
						lookup_com_amazon_insights_core_http_package,
						lookup_com_amazon_insights_core_idresolver_package,
						lookup_com_amazon_insights_core_system_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_amazon_insights_core_http_mappings;
		static Type lookup_com_amazon_insights_core_http_package (string klass)
		{
			if (package_com_amazon_insights_core_http_mappings == null) {
				package_com_amazon_insights_core_http_mappings = new string[]{
					"com/amazon/insights/core/http/HttpClient$HttpMethod:Com.Amazon.Insights.Core.Http.HttpClientHttpMethod",
				};
			}

			return Lookup (package_com_amazon_insights_core_http_mappings, klass);
		}

		static string[] package_com_amazon_insights_core_idresolver_mappings;
		static Type lookup_com_amazon_insights_core_idresolver_package (string klass)
		{
			if (package_com_amazon_insights_core_idresolver_mappings == null) {
				package_com_amazon_insights_core_idresolver_mappings = new string[]{
					"com/amazon/insights/core/idresolver/Id:Com.Amazon.Insights.Core.Idresolver.Id",
				};
			}

			return Lookup (package_com_amazon_insights_core_idresolver_mappings, klass);
		}

		static string[] package_com_amazon_insights_core_system_mappings;
		static Type lookup_com_amazon_insights_core_system_package (string klass)
		{
			if (package_com_amazon_insights_core_system_mappings == null) {
				package_com_amazon_insights_core_system_mappings = new string[]{
					"com/amazon/insights/core/system/AndroidAppDetails:com.amazon.insights.core.system.amazon.AndroidAppDetails",
					"com/amazon/insights/core/system/AndroidConnectivity:com.amazon.insights.core.system.amazon.AndroidConnectivity",
					"com/amazon/insights/core/system/AndroidConnectivity$Network:com.amazon.insights.core.system.amazon.AndroidConnectivity/Network",
					"com/amazon/insights/core/system/AndroidDeviceDetails:com.amazon.insights.core.system.amazon.AndroidDeviceDetails",
					"com/amazon/insights/core/system/AndroidPreferences:com.amazon.insights.core.system.amazon.AndroidPreferences",
					"com/amazon/insights/core/system/AndroidSystem:com.amazon.insights.core.system.amazon.AndroidSystem",
					"com/amazon/insights/core/system/DefaultFileManager:com.amazon.insights.core.system.amazon.DefaultFileManager",
				};
			}

			return Lookup (package_com_amazon_insights_core_system_mappings, klass);
		}
	}
}
