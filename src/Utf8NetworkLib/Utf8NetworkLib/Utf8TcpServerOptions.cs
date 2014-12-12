﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utf8NetworkLib
{
	/// <summary>
	/// Options for server connections
	/// </summary>
	[Flags]
	public enum Utf8TcpServerOptions
	{
		/// <summary>
		/// Connections can come only from localhost
		/// </summary>
		LocalHostOnly = 1,
		/// <summary>
		/// As a client connects, every other non-connected client is disconnected
		/// </summary>
		SingleClientOnly = 2,
		/// <summary>
		/// The default
		/// </summary>
		Default = 0,
	}
}
