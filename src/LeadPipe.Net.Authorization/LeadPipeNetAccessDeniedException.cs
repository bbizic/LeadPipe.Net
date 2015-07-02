﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeadPipeNetAccessDeniedException.cs" company="Lead Pipe Software">
//   Copyright (c) Lead Pipe Software All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeadPipe.Net.Authorization
{
    /// <summary>
	/// Defines a LeadPipeNetAccessDeniedException.
	/// </summary>
	[Serializable]
	public class LeadPipeNetAccessDeniedException : LeadPipeNetSecurityException
	{
		#region Constructors and Destructors

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		public LeadPipeNetAccessDeniedException()
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		/// <param name="message">
		/// The exception message.
		/// </param>
		public LeadPipeNetAccessDeniedException(string message)
			: base(message)
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		/// <param name="userContext">The user context.</param>
		public LeadPipeNetAccessDeniedException(IUserContext userContext)
			: base(userContext)
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="userContext">The user context.</param>
		public LeadPipeNetAccessDeniedException(string message, IUserContext userContext)
			: base(message, userContext)
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		/// <param name="message">
		/// The exception message.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		public LeadPipeNetAccessDeniedException(string message, Exception innerException)
			: base(message, innerException)
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LeadPipeNetAccessDeniedException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="userContext">The user context.</param>
		/// <param name="innerException">The inner exception.</param>
		public LeadPipeNetAccessDeniedException(string message, IUserContext userContext, Exception innerException)
			: base(message, userContext, innerException)
		{
			this.LeadPipeNetExceptionType = LeadPipeNetExceptionType.Security;
		}

		#endregion
	}
}