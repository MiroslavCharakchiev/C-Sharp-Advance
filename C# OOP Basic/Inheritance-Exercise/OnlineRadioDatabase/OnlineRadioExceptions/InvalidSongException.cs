using System;

namespace OnlineRadioDatabase.OnlineRadioExceptions
{
    public class InvalidSongException : Exception
    {
        private string exceptionMessage;

        public string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }
        public override string Message => exceptionMessage;
    }
}
