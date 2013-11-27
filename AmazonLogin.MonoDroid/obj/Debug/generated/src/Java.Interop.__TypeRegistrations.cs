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
						"com/amazon/identity/auth/device/authorization",
					},
					new Converter<string, Type>[]{
						lookup_com_amazon_identity_auth_device_authorization_package,
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

		static string[] package_com_amazon_identity_auth_device_authorization_mappings;
		static Type lookup_com_amazon_identity_auth_device_authorization_package (string klass)
		{
			if (package_com_amazon_identity_auth_device_authorization_mappings == null) {
				package_com_amazon_identity_auth_device_authorization_mappings = new string[]{
					"com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub:Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub",
					"com/amazon/identity/auth/device/authorization/AmazonAuthorizationServiceInterface$Stub$Proxy:Com.Amazon.Identity.Auth.Device.Authorization.AmazonAuthorizationServiceInterfaceStub/Proxy",
				};
			}

			return Lookup (package_com_amazon_identity_auth_device_authorization_mappings, klass);
		}
	}
}
