using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace Classroom_Allocation_System
{
    public partial class Theme : Form
    {
        public int time = 6000;
        public int theme = 0;
        public Theme()
        {
            InitializeComponent();
        }

        private void Theme_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc3 = new XmlDocument();
            xmlDoc3.Load("save.txt");
            XmlNodeList nodeList = xmlDoc3.SelectSingleNode("NewDataSet").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;
                    if (xe2.Name == "F1")
                    {
                        theme = System.Int32.Parse(xe2.InnerText);
                        //MessageBox.Show(xe2.InnerText);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.Load("timetable.xml");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F1(?=>)", "Name");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F2(?=>)", "Teachers");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F3(?=>)", "Classes");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F4(?=>)", "Room");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F5(?=>)", "Capacity");
            xmlDoc2.InnerXml = Regex.Replace(xmlDoc2.InnerXml, @"(?s)(?<=</?)F6(?=>)", "Date");
            
            //MessageBox.Show("saved successful !");
            xmlDoc2.Save("timetable_.xls");
            
            XmlDocument xmlDoc3 = new XmlDocument();
            xmlDoc3.Load("save.txt");
            XmlNodeList nodeList = xmlDoc3.SelectSingleNode("NewDataSet").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;
                    if (xe2.Name == "F1")
                    {
                        xe2.InnerText = ""+theme;
                        //MessageBox.Show("theme is " + theme);
                    }
                }
                xmlDoc3.Save("save.txt");
            }
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (theme < 3)
            {
                theme++;
            }
            else
            {
                theme = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString();
            time--;
            timelabel.Text = "" + time;
            if (time == 0)
            {
                timer1.Stop();
                this.Visible = false;
                Login Login = new Login();
                Login.Show();
            }
        }
    }
}
