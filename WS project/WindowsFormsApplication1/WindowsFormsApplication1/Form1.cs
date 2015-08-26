using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("timetable.xml");
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                int choose = 0;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;
                    if (xe2.Name == "ID")
                    {
                        if (xe2.InnerText == userid)
                        {
                            choose = 1;
                        }
                    }
                    if (xe2.Name == "Password" && choose == 1)
                    {
                        xe2.InnerText = textBox1.Text;
                        MessageBox.Show("The password changed!");
                        choose = 0;
                    }
                }
            }
            xmlDoc.Save("data.xml");
        }
    }
}
