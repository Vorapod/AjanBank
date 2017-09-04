using System;

namespace Event.Model
{
    public class InsertGotError : EventArgs
    {
        public Type ExceptionType { get; set; }
        public int RecordFailed { get; set; }
        public Person Person { get; set; }
    }
}
