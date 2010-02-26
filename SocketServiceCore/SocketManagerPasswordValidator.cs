﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using GiantSoft.SocketServiceCore.Config;

namespace GiantSoft.SocketServiceCore
{
	public class SocketManagerPasswordValidator : UserNamePasswordValidator
	{
		private ICredentialConfig m_Config;

		public SocketManagerPasswordValidator(ICredentialConfig config)
		{
			m_Config = config;
		}

		public override void Validate(string userName, string password)
		{
			if (string.Compare(m_Config.UserName, userName, true) != 0 ||
					string.Compare(m_Config.Password, password, true) != 0)
			{
				throw new SecurityTokenException("Unknown Username or Password");
			}
		}
	}
}
