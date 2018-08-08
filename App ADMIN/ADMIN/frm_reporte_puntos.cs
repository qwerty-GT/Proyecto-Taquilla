using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.Odbc;
using System.Diagnostics;
using System.IO;

namespace ADMIN
{
    public partial class frm_reporte_puntos : Form
    {
        frm_reportes reporte;
        public frm_reporte_puntos(frm_reportes anterior, bool[] privilegios)
        {
            InitializeComponent();
            reporte = anterior;
        }

        public void CargarGrid1()//carga la informacion del dg1
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT SUM(F.PUNTOS_FACTURA),C.EMAIL_CLIENTE FROM FACTURA AS F, CLIENTE AS C WHERE F.EMAIL_CLIENTE=C.EMAIL_CLIENTE AND C.EMAIL_CLIENTE='{0}';", textBox1.Text);
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }

        private void To_pdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "AUTORIZÓ: JAVIER BATZIBAL";
                string envio = "FECHA:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("REPORTE DE PUNTOS DE CLIENTES CINEMA LICAS", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("CIUDAD DE GUATEMALA"));
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("FIRMA DE ENCARGADO: ", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            To_pdf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reporte.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarGrid1();
        }

        private void frm_reporte_puntos_FormClosing(object sender, FormClosingEventArgs e)
        {
            reporte.Show();
        }
    }
}
