using System.Data.OleDb;
using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       private string strConnect  = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\工作表.xls;Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";

        public Form1()
        {
            InitializeComponent();
        }   
        private void button1_Click(object sender, EventArgs e)
        {
           // OpenFileDialog openFileDlg = new OpenFileDialog();
            //openFileDlg.InitialDirectory = "c:\\";
            //openFileDlg.RestoreDirectory = true;

            //连接到数据资源
            OleDbConnection objConnect = new OleDbConnection(strConnect);
            try
            {
                objConnect.Open();
                //记录填补一个客户表格的数据
                OleDbCommand objCmd = new OleDbCommand("select * from [Sheet1$]", objConnect);
                OleDbDataAdapter objAdapter = new OleDbDataAdapter();
                objAdapter.SelectCommand = objCmd;
                DataSet objDataSet = new DataSet();
                objAdapter.Fill(objDataSet);
                System.IO.FileStream fs = new System.IO.FileStream("C:\\Customers.xml",System.IO.FileMode.Create);
                System.Xml.XmlTextWriter xmlWriter = new System.Xml.XmlTextWriter(fs,System.Text.Encoding.Unicode);
                xmlWriter.WriteProcessingInstruction("xml","version='1.0'");
                objDataSet.WriteXml(xmlWriter);
                xmlWriter.Close();
                objConnect.Close();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
