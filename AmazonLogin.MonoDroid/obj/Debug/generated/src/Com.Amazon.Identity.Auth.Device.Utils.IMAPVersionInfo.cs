using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	[Register ("com/amazon/identity/auth/device/utils/MAPVersionInfo")]
	public abstract class MAPVersionInfo {

		internal MAPVersionInfo ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/interface[@name='MAPVersionInfo']/field[@name='LWA_VERSION']"
		[Register ("LWA_VERSION")]
		public const string LwaVersion = (string) "1.0.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/interface[@name='MAPVersionInfo']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "3.3.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/interface[@name='MAPVersionInfo']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "AmazonAuthenticationSDK";
	}

	[System.Obsolete ("Use the 'MAPVersionInfo' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MAPVersionInfoConsts : MAPVersionInfo {

		private MAPVersionInfoConsts ()
		{
		}
	}

}
