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
            elegirFactura.ShowDialog();
            if (elegirFactura.CheckFileExists)
            {
                String factura = System.IO.File.ReadAllText(elegirFactura.FileName);
                factura = factura.Replace(System.Environment.NewLine, String.Empty).Replace(" ", String.Empty).Replace("\t", String.Empty);

                WSfacturatechSoapClient soapClient = new WSfacturatechSoapClient("WSfacturatechSoap");

                RespuestaWebservice respuesta = new RespuestaWebservice();

                respuesta = soapClient.EmitirComprobante(factura);

                DataTable listaRespuesta = new DataTable();
                listaRespuesta.Columns.Add("Parametro Respuesta");
                listaRespuesta.Columns.Add("Estado");

                DataRow mensajeEstado = listaRespuesta.NewRow();
                mensajeEstado["Parametro Respuesta"] = "Mensaje Estado";
                mensajeEstado["Estado"] = respuesta.MensajeEmisor;
                listaRespuesta.Rows.Add(mensajeEstado);

                foreach (string errString in respuesta.MensajeErrorLAYOUT)
                {
                    DataRow detalleRespuesta = listaRespuesta.NewRow();
                    detalleRespuesta["Parametro Respuesta"] = "Mensaje ERROR";
                    detalleRespuesta["Estado"] = errString;
                    listaRespuesta.Rows.Add(detalleRespuesta);
                }

                DataRow detalleRespuesta1 = listaRespuesta.NewRow();
                detalleRespuesta1["Parametro Respuesta"] = "respuesta.fileName";


                DataRow detalleRespuesta2 = listaRespuesta.NewRow();
                detalleRespuesta2["Parametro Respuesta"] = "respuesta.documentNumber";


                DataRow detalleRespuesta3 = listaRespuesta.NewRow();
                detalleRespuesta3["Parametro Respuesta"] = "respuesta.ID";


                DataRow detalleRespuesta4 = listaRespuesta.NewRow();
                detalleRespuesta4["Parametro Respuesta"] = "respuesta.MensajeEmisor";


                DataRow detalleRespuesta5 = listaRespuesta.NewRow();
                detalleRespuesta5["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.processName";


                DataRow detalleRespuesta6 = listaRespuesta.NewRow();
                detalleRespuesta6["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.processStatus";


                DataRow detalleRespuesta7 = listaRespuesta.NewRow();
                detalleRespuesta7["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.processDate";


                DataRow detalleRespuesta8 = listaRespuesta.NewRow();
                detalleRespuesta8["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.messageType";


                DataRow detalleRespuesta9 = listaRespuesta.NewRow();
                detalleRespuesta9["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.errorMessage";


                DataRow detalleRespuesta10 = listaRespuesta.NewRow();
                detalleRespuesta10["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.legalStatus";


                DataRow detalleRespuesta11 = listaRespuesta.NewRow();
                detalleRespuesta11["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.businessStatus";


                DataRow detalleRespuesta12 = listaRespuesta.NewRow();
                detalleRespuesta12["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.governmentResponseCode";


                DataRow detalleRespuesta13 = listaRespuesta.NewRow();
                detalleRespuesta13["Parametro Respuesta"] = "respuesta.MensajeDocumentStatus.governmentResponseDescription";


                DataRow detalleRespuesta14 = listaRespuesta.NewRow();
                detalleRespuesta14["Parametro Respuesta"] = "respuesta.MensajeRespuestaCUFE.Status";


                DataRow detalleRespuesta15 = listaRespuesta.NewRow();
                detalleRespuesta15["Parametro Respuesta"] = "respuesta.MensajeRespuestaCUFE.CUFE";

                detalleRespuesta1["Estado"] = respuesta.fileName;
                detalleRespuesta2["Estado"] = respuesta.documentNumber;
                detalleRespuesta3["Estado"] = respuesta.ID;
                detalleRespuesta4["Estado"] = respuesta.MensajeEmisor;
                detalleRespuesta5["Estado"] = respuesta.MensajeDocumentStatus.processName;
                detalleRespuesta6["Estado"] = respuesta.MensajeDocumentStatus.processStatus;
                detalleRespuesta7["Estado"] = respuesta.MensajeDocumentStatus.processDate;
                detalleRespuesta8["Estado"] = respuesta.MensajeDocumentStatus.messageType;
                detalleRespuesta9["Estado"] = respuesta.MensajeDocumentStatus.errorMessage;
                detalleRespuesta10["Estado"] = respuesta.MensajeDocumentStatus.legalStatus;
                detalleRespuesta11["Estado"] = respuesta.MensajeDocumentStatus.businessStatus;
                detalleRespuesta12["Estado"] = respuesta.MensajeDocumentStatus.governmentResponseCode;
                detalleRespuesta13["Estado"] = respuesta.MensajeDocumentStatus.governmentResponseDescription;
                detalleRespuesta14["Estado"] = respuesta.MensajeRespuestaCUFE.Status;
                detalleRespuesta15["Estado"] = respuesta.MensajeRespuestaCUFE.CUFE;

                listaRespuesta.Rows.Add(detalleRespuesta1);
                listaRespuesta.Rows.Add(detalleRespuesta2);
                listaRespuesta.Rows.Add(detalleRespuesta3);
                listaRespuesta.Rows.Add(detalleRespuesta4);
                listaRespuesta.Rows.Add(detalleRespuesta5);
                listaRespuesta.Rows.Add(detalleRespuesta6);
                listaRespuesta.Rows.Add(detalleRespuesta7);
                listaRespuesta.Rows.Add(detalleRespuesta8);
                listaRespuesta.Rows.Add(detalleRespuesta9);
                listaRespuesta.Rows.Add(detalleRespuesta10);
                listaRespuesta.Rows.Add(detalleRespuesta11);
                listaRespuesta.Rows.Add(detalleRespuesta12);
                listaRespuesta.Rows.Add(detalleRespuesta13);
                listaRespuesta.Rows.Add(detalleRespuesta14);
                listaRespuesta.Rows.Add(detalleRespuesta15);


                detallesRespuesta.DataSource = listaRespuesta;

            }

        }
    }
}
