namespace FaceUI.Exceptions
{
    using System;

    /// <summary>
    /// Thrown when something is not found (key, value, index, etc.)
    /// </summary>
    public class NotFoundException : Exception
    {
        /// <summary>
        /// Create the exception without message.
        /// </summary>
        public NotFoundException()
        {
        }

        /// <summary>
        /// Create the exception with message.
        /// </summary>
        public NotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Create the exception with message and inner exception.
        /// </summary>
        public NotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}