﻿namespace OnlineRadioDatabase.OnlineRadioExceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}