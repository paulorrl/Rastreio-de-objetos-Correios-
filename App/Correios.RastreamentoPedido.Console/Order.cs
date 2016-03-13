using System;
using System.IO;
using System.Net;
using System.Text;

namespace Correios.RastreamentoPedido.Console
{
    public static class Order
    {
        /// <summary>
        /// Performs tracking requests by the api Correios.
        /// </summary>
        /// <param name="trackingCode">Code to be tracked</param>
        /// <param name="urlApi">Api url without parameters</param>
        /// <param name="returnType">The possible returns are JSON or XML</param>
        /// <returns></returns>
        public static string Tracking(string trackingCode, string urlApi, string returnType)
        {
            WebRequest request = WebRequest.Create(urlApi + returnType + "/" + trackingCode);

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            // Information
            System.Console.WriteLine("Information" + Environment.NewLine);
            System.Console.WriteLine("Header: " + Environment.NewLine + response.Headers);

            System.Console.WriteLine("Content Lenght: " + response.ContentLength);
            System.Console.WriteLine("Method: " + response.Method);
            System.Console.WriteLine("Protocol Version: " + response.ProtocolVersion);
            System.Console.WriteLine("Response Uri: " + response.ResponseUri);
            System.Console.WriteLine("Status Code: " + response.StatusCode);
            System.Console.WriteLine("Status Description: " + response.StatusDescription);

            StreamReader stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("ISO-8859-1"));
            string data = stream.ReadToEnd();

            return data;
        }
    }
}