using EmitirConsole.FacturaTech;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EmitirConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WSfacturatechSoapClient soapClient = new WSfacturatechSoapClient("WSfacturatechSoap");

            RespuestaWebservice respuesta = new RespuestaWebservice();

            string factura = System.IO.File.ReadAllText("..\\..\\FACTURAPRUEBA1.TXT");
            respuesta = soapClient.EmitirComprobante(factura);

            Console.WriteLine(respuesta.MensajeEmisor);
            foreach (string errString in respuesta.MensajeErrorLAYOUT)
            {
                Console.WriteLine(errString);
            }
            Console.WriteLine(respuesta.MensajeRespuestaCUFE.Status);
            
            Console.ReadKey();
        }

        
    }
}
