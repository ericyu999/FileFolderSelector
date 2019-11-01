using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFolderSelector
{
    public partial class Form1 : Form
    {
        string sSelectedFile;
        string sSelectedFolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Choof_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sSelectedFile = choofdlog.FileName;
                this.textBox1.Text = sSelectedFile;
            }
            else
                sSelectedFile = string.Empty;
        }

        private void Direc_Click_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedFolder = fbd.SelectedPath;
                this.textBox2.Text = sSelectedFolder;
            }
            else
                sSelectedFolder = string.Empty;
        }

        private void Run_Click_Click(object sender, EventArgs e)
        {
            if(sSelectedFolder != string.Empty && sSelectedFile != string.Empty)
            {
                Microsoft.Office.Interop.Excel.Application excelApp;

                string fnTarget;
                DateTime date;
                string numOfPcs;
                string clientCode;
                string awb;
                string awbEnding;
                //fnTarget = "\\DPD TRACKING " + numOfPcs + " pcs_" + clientCode + "_" + awbEnding + ".xlsx";

                //string fileTarget = "C:\\Users\\SBL-Warehouse\\Desktop\\ExcelBatchSave_Project" + fnTarget;
                string fileTemplate = Application.StartupPath + "\\DPD TRACKING 123 pcs_SOSO_7777_template.xlsx";
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wbTarget;
                Microsoft.Office.Interop.Excel.Worksheet sh;


                string fn;
                SpreadsheetLight.SLDocument ss;
                fn = sSelectedFile;
                ss = new SpreadsheetLight.SLDocument(fn);
                ss.SelectWorksheet("Sheet1");

                //int rt;
                //rt = 0;

                Int32 row_count;
                row_count = ss.GetWorksheetStatistics().EndRowIndex;

                for (int ri = 2; ri <= row_count; ri++)
                {
                    date = ss.GetCellValueAsDateTime(ri, 1);
                    clientCode = ss.GetCellValueAsString(ri, 2);
                    awb = ss.GetCellValueAsString(ri, 3);
                    awbEnding = awb.Substring(awb.Length - 4);
                    numOfPcs = ss.GetCellValueAsString(ri, 4);

                    wbTarget = excelApp.Workbooks.Open(fileTemplate);
                    sh = wbTarget.Worksheets["Sheet1"];
                    sh.Cells[1, 1] = date;
                    sh.Cells[1, 2] = numOfPcs + " pcs";
                    sh.Cells[1, 5] = awb;

                    fnTarget = "\\DPD TRACKING " + numOfPcs + " pcs_" + clientCode + "_" + awbEnding + ".xlsx";
                    string fileTarget = sSelectedFolder + fnTarget;
                    wbTarget.SaveAs(fileTarget);
                    wbTarget.Close(true);

                    excelApp.Quit();
                }

                string promptValue = Prompt.ShowDialog("Program finished successfully!", "Confirmation");
            }
        }
    }


    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, Text = text };
            //TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            //prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? "All good" : "Error";
        }
    }
}
