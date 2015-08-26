using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
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
                            xe2.RemoveAll();
                        }
                }
            }
            xmlDoc.Save("data.xml");
        }
    }
}
