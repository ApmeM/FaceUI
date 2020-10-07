namespace FaceUI.Exceptions
{
    using System;

    /// <summary>
    /// Thrown when the user provides an invalid value.
    /// </summary>
    public class InvalidValueException : Exception
    {
        /// <summary>
        /// Create the exception without message.
        /// </summary>
        public InvalidValueException()
        {
        }

        /// <summary>
        /// Create the exception with message.
        /// </summary>
        public InvalidValueException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Create the exception with message and inner exception.
        /// </summary>
        public InvalidValueException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}