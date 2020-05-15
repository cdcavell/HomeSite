using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;

namespace HomeSite.ClassLibrary.Commons.Xml
{
    /// <summary>
    /// Class to perform XSLT Transformation
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/14/2020 | Initial build |~ 
    /// </revision>
    public class Transform
    {
        /// <summary>
        /// Method to perform XSLT Transformation and write out file
        /// </summary>
        /// <param name="inputXslt">string</param>
        /// <param name="inputXml">string</param>
        /// <param name="outputFile">string</param>
        public static void Write(string inputXslt, string inputXml, string outputFile)
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(inputXslt);
            transform.Transform(inputXml, outputFile);
        }
    }
}
