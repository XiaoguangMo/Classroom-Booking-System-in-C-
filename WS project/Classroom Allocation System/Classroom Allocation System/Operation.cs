using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;


namespace Classroom_Allocation_System
{
    public partial class Operation : Theme
    {
        

        public Operation()
        {
            InitializeComponent();
        }

        private void Operation_Load(object sender, EventArgs e)
        {

            time = 6000;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login Login = new Login();
            Login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Select_zone Select_zone = new Select_zone("Book");
            Select_zone.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Select_Classroom_Cancel Select_Classroom_Cancel = new Select_Classroom_Cancel("change");
            Select_Classroom_Cancel.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Select_Classroom_Cancel Select_Classroom_Cancel = new Select_Classroom_Cancel("cancel");
            Select_Classroom_Cancel.Show();
        }
    }
}
