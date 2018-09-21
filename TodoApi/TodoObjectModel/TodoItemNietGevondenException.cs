using System;
using System.Collections.Generic;
using System.Text;

namespace TodoObjectModel
{

    [Serializable]
    public class TodoItemNietGevondenException : Exception
    {
        public TodoItemNietGevondenException() { }
        public TodoItemNietGevondenException(string message) : base(message) { }
        public TodoItemNietGevondenException(string message, Exception inner) : base(message, inner) { }
        protected TodoItemNietGevondenException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
