using System;

namespace HomeSite.ClassLibrary.Commons.Logging
{
    /// <summary>
    /// Static console logging class.
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/14/2020 | Initial build |~ 
    /// </revision>
    public static class ConsoleLog
    {
        public static void Exception(Exception exception)
        {
            Console.WriteLine(AsciiCodes.CRLF + "Exception thrown in application");

            Console.WriteLine("Exception Message:    " + exception.Message);
            Console.WriteLine("Exception Source:     " + exception.Source);
            Console.WriteLine("Exception StackTrace: " + AsciiCodes.CRLF + exception.StackTrace + AsciiCodes.CRLF);

            if (exception.InnerException != null)
            {
                Console.WriteLine("InnerException Message:    " + exception.InnerException.Message);
                Console.WriteLine("InnerException Source:     " + exception.InnerException.Source);
                Console.WriteLine("InnerException StackTrace: " + AsciiCodes.CRLF + exception.InnerException.StackTrace + AsciiCodes.CRLF);
            }
        }
    }
}
