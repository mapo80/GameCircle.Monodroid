using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	[Register ("com/amazon/identity/auth/device/utils/MAPConstants")]
	public abstract class MAPConstants {

		internal MAPConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/interface[@name='MAPConstants']/field[@name='MAP_IS_PRIMARY']"
		[Register ("MAP_IS_PRIMARY")]
		public const string MapIsPrimary = (string) "map.primary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/interface[@name='MAPConstants']/field[@name='MAP_VERSION_KEY']"
		[Register ("MAP_VERSION_KEY")]
		public const string MapVersionKey = (string) "map.version";
	}

	[System.Obsolete ("Use the 'MAPConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MAPConstantsConsts : MAPConstants {

		private MAPConstantsConsts ()
		{
		}
	}

}
