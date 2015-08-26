using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Classroom_Allocation_System
{
    public partial class Login : Theme
    {
        public Login()
        {
            InitializeComponent();
        }
        private string strConnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=timetable.xls;Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";
        private void Form1_Load(object sender, EventArgs e)
        {
            time = 6000;
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
                System.IO.FileStream fs = new System.IO.FileStream("timetablechanged.xml", System.IO.FileMode.Create);
                System.Xml.XmlTextWriter xmlWriter = new System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode);
                xmlWriter.WriteProcessingInstruction("xml", "version='1.0'");
                objDataSet.WriteXml(xmlWriter);
                xmlWriter.Close();
                objConnect.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Password.Text == "ilovejudy")
            {
                this.Visible = false;
                Password.Clear();
                Operation Operation = new Operation();
                Operation.Show();
            }
            else
            {
                Password.Clear();
                MessageBox.Show("Password wrong!");

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
