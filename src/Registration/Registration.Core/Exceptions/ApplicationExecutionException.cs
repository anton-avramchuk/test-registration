using System;

namespace Registration.Core.Exceptions
{
    public class ApplicationExecutionException : Exception
    {
        public string[] Messages { get; }

        public ApplicationExecutionException(string[] messages)
        {
            Messages = messages;
        }

        public ApplicationExecutionException(string message) : this(new[] { message })
        {

        }

        public override string Message
        {
            get
            {
                return string.Join(Environment.NewLine, Messages);
            }
        }
    }
}