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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data.xml");

            
            XmlNodeList idList = xmlDoc.SelectNodes("//ID");
            foreach (XmlNode node in idList)
            {
                if (node.InnerText == textBox1.Text)
                {
                    exit = 1;
                    MessageBox.Show("The same ID !");
                }
            }
            if (exit == 0)
            {
                XmlNode root = xmlDoc.SelectSingleNode("Table");
                XmlElement xe1 = xmlDoc.CreateElement("Data");


                XmlElement xesub1 = xmlDoc.CreateElement("ID");
                xesub1.InnerText = textBox1.Text;
                xe1.AppendChild(xesub1);

                XmlElement xesub2 = xmlDoc.CreateElement("Password");
                xesub2.InnerText = textBox2.Text;
                xe1.AppendChild(xesub2);

                XmlElement xesub3 = xmlDoc.CreateElement("Money");
                xesub3.InnerText = "0";
                xe1.AppendChild(xesub3);

                XmlElement xesub5 = xmlDoc.CreateElement("Name");
                xesub5.InnerText = textBox4.Text;
                xe1.AppendChild(xesub5);

                XmlElement xesub6 = xmlDoc.CreateElement("Email");
                xesub6.InnerText = textBox5.Text;
                xe1.AppendChild(xesub6);

                XmlElement xesub4 = xmlDoc.CreateElement("Birthday");
                xesub4.InnerText = textBox3.Text;
                xe1.AppendChild(xesub4);

                XmlElement xesub7 = xmlDoc.CreateElement("Block");
                xesub7.InnerText = "0";
                xe1.AppendChild(xesub7);

                root.AppendChild(xe1);
                xmlDoc.Save("data.xml");
        }
    }
}
