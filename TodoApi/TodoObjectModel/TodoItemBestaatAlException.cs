using System;
using System.Collections.Generic;
using System.Text;

namespace TodoObjectModel
{

    [Serializable]
    public class TodoItemBestaatAlException : Exception
    {
        public TodoItemBestaatAlException() { }
        public TodoItemBestaatAlException(string message) : base(message) { }
        public TodoItemBestaatAlException(string message, Exception inner) : base(message, inner) { }
        protected TodoItemBestaatAlException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
