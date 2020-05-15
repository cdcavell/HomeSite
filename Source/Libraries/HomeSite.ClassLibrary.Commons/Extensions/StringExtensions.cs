using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;

namespace System
{
    /// <summary>
    /// Extension methods for existing string types.
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/15/2020 | Initial build |~ 
    /// </revision>
    public static class StringExtensions
    {
        /// <summary>
        /// Method to determine if string is a valid email address
        /// </summary>
        /// <param name="email">this string</param>
        /// <returns>bool</returns>
        /// <method>IsValidEmail(this string email)</method>
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
        
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[2].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Method to remove "Carriage Return" and "Line Feed" as well as Html filtering to provide proper neutralization.
        /// </summary>
        /// <param name="value">this string</param>
        /// <returns>string</returns>
        /// <method>string Clean(this string value)</method>
        public static string Clean(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return string.Format(HttpUtility.HtmlEncode(value.Replace("\r", string.Empty).Replace("\n", string.Empty)));
        }

    }
}
