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
						"com/amazon/ags/html5/factory",
						"com/amazon/ags/storage",
					},
					new Converter<string, Type>[]{
						lookup_com_amazon_ags_html5_factory_package,
						lookup_com_amazon_ags_storage_package,
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

		static string[] package_com_amazon_ags_html5_factory_mappings;
		static Type lookup_com_amazon_ags_html5_factory_package (string klass)
		{
			if (package_com_amazon_ags_html5_factory_mappings == null) {
				package_com_amazon_ags_html5_factory_mappings = new string[]{
					"com/amazon/ags/html5/factory/AGSClientInstanceCoordinator:Com.Amazon.Ags.Html5.Factory.AGSClientInstanceCoordinatorWrapper",
				};
			}

			return Lookup (package_com_amazon_ags_html5_factory_mappings, klass);
		}

		static string[] package_com_amazon_ags_storage_mappings;
		static Type lookup_com_amazon_ags_storage_package (string klass)
		{
			if (package_com_amazon_ags_storage_mappings == null) {
				package_com_amazon_ags_storage_mappings = new string[]{
					"com/amazon/ags/storage/OfflineEventManager$OfflineEventTuple:Com.Amazon.Ags.Storage.OfflineEventManagerOfflineEventTuple",
					"com/amazon/ags/storage/OfflineEventStorage$OfflineEventJSONTuple:Com.Amazon.Ags.Storage.OfflineEventStorageOfflineEventJSONTuple",
				};
			}

			return Lookup (package_com_amazon_ags_storage_mappings, klass);
		}
	}
}
