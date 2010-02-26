using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using GiantSoft.SocketServiceCore.Config;

namespace GiantSoft.SocketServiceCore.Configuration
{
	public class CertificateConfig : ConfigurationElement, ICertificateConfig
	{		
		#region ICertificateConfig Members

		[ConfigurationProperty("certificateFilePath", IsRequired = true)]
		public string CertificateFilePath
		{
			get
			{
				return this["certificateFilePath"] as string;
			}
		}

		[ConfigurationProperty("certificatePassword", IsRequired = true)]
		public string CertificatePassword
		{
			get
			{
				return this["certificatePassword"] as string;
			}
		}

		#endregion
	}
}
