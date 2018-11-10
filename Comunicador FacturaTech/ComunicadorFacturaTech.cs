using Comunicador_FacturaTech.FacturaTech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicador_FacturaTech
{
    public partial class ComunicadorFacturaTech : Form
    {
        public ComunicadorFacturaTech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (elegirFactura.CheckFileExists)
            {
                String factura = System.IO.File.ReadAllText(elegirFactura.FileName);
                factura = factura.Replace(System.Environment.NewLine, String.Empty).Replace(" ", String.Empty).Replace("\t", String.Empty);

                WSfacturatechSoapClient soapClient = new WSfacturatechSoapClient("WSfacturatechSoap");

                RespuestaWebservice respuesta = new RespuestaWebservice();

                respuesta = soapClient.EmitirComprobante(factura);

                DataTable listaRespuesta = new DataTable();
                listaRespuesta.Columns.Add("Parametro");
                listaRespuesta.Columns.Add("Estadoo");

                foreach (string errString in respuesta.MensajeErrorLAYOUT)
                {
                    DataRow detalleRespuesta = listaRespuesta.NewRow();
                    detalleRespuesta["Parametro"] = "Mensaje ERROR";
                    detalleRespuesta["Estado"] = errString;
                    listaRespuesta.Rows.Add(detalleRespuesta);
                }


            }

        }
    }
}
