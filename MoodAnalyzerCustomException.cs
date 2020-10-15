using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerFinal
{
    public class MoodAnalyzerCustomException : Exception
    {
        /// <summary>
        /// enum for variable exception messages
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ERROR
        }
        /// <summary>
        /// Crating variable for ExceptionType
        /// </summary>
        private readonly ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyzerCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
