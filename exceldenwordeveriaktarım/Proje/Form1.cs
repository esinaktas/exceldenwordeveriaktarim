using SautinSoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string excelFile;
        string docxFile;
        string excelName;
        private void exceldosyası_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Excel Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                excelName = file.SafeFileName;
                if (DosyaYolu != "")
                {
                    excelFile = Path.GetFullPath(DosyaYolu);
                    kaydetword.Enabled = true;
                }
            }
        }

        private void kaydetword_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            if (Klasor.ShowDialog() == DialogResult.OK)
            {
                string KlasorYolu = Klasor.SelectedPath;
                docxFile = Path.ChangeExtension(KlasorYolu + @"\" + excelName, "docx");
                dönüştür.Enabled = true;
            }
        }

        private void dönüştür_Click(object sender, EventArgs e)
        {
            ExcelToPdf x = new ExcelToPdf();
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Docx;

            try
            {
                x.ConvertFile(excelFile, docxFile);
                MessageBox.Show("Dönüştürme işlemi başarılı .");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
