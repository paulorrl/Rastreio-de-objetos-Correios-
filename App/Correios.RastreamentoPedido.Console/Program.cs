using System;

namespace Correios.RastreamentoPedido.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string trackingCode = "PJ124500882BR";
            const string urlApi = "http://developers.agenciaideias.com.br/correios/rastreamento/";
            const string returnType = "json";

            try
            {
                string returnApi = Order.Tracking(trackingCode, urlApi, returnType);

                System.Console.WriteLine(Environment.NewLine + "Message body: " + Environment.NewLine);
                System.Console.WriteLine(returnApi);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }

            System.Console.ReadLine();
        }
    }
}