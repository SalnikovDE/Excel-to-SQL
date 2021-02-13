using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExcelFileData = new ExcelFileDataStruct();
        }

        private void load_data_button_click(object sender, EventArgs e)
        {
            
            ExcelFileData.xlWorkbook = ExcelFileData.xlApp.Workbooks.Open(ExcelLoadTextBox.Text);
            ExcelFileData.xlWorksheet = ExcelFileData.xlWorkbook.Sheets[1];
            ExcelFileData.xlRange = ExcelFileData.xlWorksheet.UsedRange;

        }

        private void LoadDataChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenExcelDialog.ShowDialog();
            ExcelLoadTextBox.Text = OpenExcelDialog.FileName;
        }
        class ExcelFileDataStruct
        {
            public ExcelFileDataStruct()
            {
                xlApp = new Excel.Application();
            }
            public Excel.Application xlApp;
            public Excel.Workbook xlWorkbook;
            public Excel._Worksheet xlWorksheet;
            public Excel.Range xlRange;
        }
        ExcelFileDataStruct ExcelFileData;
    }
}


