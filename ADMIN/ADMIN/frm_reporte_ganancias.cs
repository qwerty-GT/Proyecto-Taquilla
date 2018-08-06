﻿using System;
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
    public partial class frm_reporte_ganancias : Form
    {
        public frm_reporte_ganancias()
        {
            InitializeComponent();
            consulta();
        }

        private void consulta()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT NOMBRE_CINE FROM CINE;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                    comboBox2.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        /*AQUI SE GENERAN LOS REPORTES SEMANALES*/

        public void CargarGrid1()//carga la informacion del dg1
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error por favor verifique");
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
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "AUTORIZÓ: JOSUÉ PONCIANO";
                string envio = "FECHA:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("REPORTE DE GANANCIAS CINEMA LICAS", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
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
                GenerarDocumento2(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("FIRMA DE ENCARGADO: ", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        /*INFORMACION Y REPORTES MENSUALES*/

        public void CargarGrid2()//carga la informacion del dg2
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error por favor verifique");
            }
        }

        public void GenerarDocumento2(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridView2.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas2(dataGridView2);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView2.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView2.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView2[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas2(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }

        private void To_pdf2()
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
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "AUTORIZÓ: JOSUÉ PONCIANO";
                string envio = "FECHA:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("REPORTE DE GANANCIAS CINEMA LICAS", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
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
                GenerarDocumento2(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("FIRMA DE ENCARGADO: ", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_formatoAceptar_Click(object sender, EventArgs e)
        {
            To_pdf();
        }

        private void frm_reporte_ganancias_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            To_pdf2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarGrid1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarGrid2();
        }
    }
}
