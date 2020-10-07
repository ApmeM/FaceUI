// -------------------------------------------------------
// Define some engine exceptions.
//
// Author: Ronen Ness.
// Since: 2017.
// -------------------------------------------------------
using System;


namespace FaceUI.Exceptions
{
    /// <summary>
    /// Thrown when the user tries to perform an action but the object / UI state does not allow it.
    /// </summary>
    public class InvalidStateException : Exception
    {
        /// <summary>
        /// Create the exception without message.
        /// </summary>
        public InvalidStateException()
        {
        }

        /// <summary>
        /// Create the exception with message.
        /// </summary>
        public InvalidStateException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Create the exception with message and inner exception.
        /// </summary>
        public InvalidStateException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
