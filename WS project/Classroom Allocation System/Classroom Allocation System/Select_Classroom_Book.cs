using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Xml;
using System.IO;

namespace Classroom_Allocation_System
{
    public partial class Select_Classroom_Book : Theme
    {
        String this_operation;
        String course2;
        String teacher2;
        String student2;
        String room2;
        String capacity2;
        String time2;
        String this_zone;
        int hasvalue = 0;
        public Select_Classroom_Book(String zone)
        {
            InitializeComponent();
            this_zone = zone;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Select_Classroom_Book(String zone,String course,String teacher,String student,String room,String capacity,String time)
        {
            course2 = course;
            teacher2 = teacher;
            student2 = student;
            room2 = room;
            capacity2 = capacity;
            time2 = time;
            hasvalue = 1;
            InitializeComponent();
            this_zone = zone;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.Text = teacher;
            textBox2.Text = student;
            textBox3.Text = course;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void Select_classroom_Book_Load(object sender, EventArgs e)
        {
            time = 6000;
            /*
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "工作薄(*.xls)|*.xls|所有文件(*.*)|*.*";
            if (openfile.FilterIndex == 1 && openfile.ShowDialog() == DialogResult.OK)
                ExcelToDS(openfile.FileName);*/
            label1.Text = "ZONE "+this_zone;
            if (this_zone == "C")
            {
                button1.Text = "C121";
                button2.Text = "C122";
                button3.Text = "C123";
                button4.Text = "C124";
                button5.Text = "C125";
                button6.Text = "C126";
                button7.Text = "C127";
                button8.Text = "C128";
                button9.Text = "C203";
                button10.Text = "C204";
                button11.Text = "C205";
                button12.Text = "C207";
                button13.Text = "C208";
                button14.Text = "C209";
                button15.Text = "C210";
                button16.Text = "C301";
                button17.Text = "C302";
                button18.Text = "C303";
                button19.Text = "C304";
                button20.Text = "C305";
                button21.Text = "C306";
                button22.Text = "C307";
                button23.Text = "C402";
                button24.Text = "C403";
                button25.Text = "C405";
                button26.Text = "C406";
                button27.Text = "C407";
            }
            else if (this_zone == "F")
            {
                button1.Text = "F310";
                button2.Text = "F103-3";
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
            }
            else if (this_zone == "E")
            {
                button1.Text = "E308A";
                button2.Text = "E308B";
                button3.Text = "E307";
                button4.Text = "E305";
                button5.Text = "E304";
                button6.Text = "E303B";
                button7.Text = "E303A";
                button8.Text = "E302";
                button9.Text = "E301";
                button10.Text = "E208C";
                button11.Text = "E208B";
                button12.Text = "E205A";
                button13.Text = "E204";
                button14.Text = "E202";
                button15.Text = "E201";
                button16.Text = "E106";
                button17.Text = "E105";
                button18.Text = "E104";
                button19.Text = "E103";
                button20.Text = "E102";
                button21.Text = "E101";
                button22.Text = "E205B";
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
            }
            else if (this_zone == "D")
            {
                button1.Text = "D408";
                button2.Text = "D407";
                button3.Text = "D406";
                button4.Text = "D405";
                button5.Text = "D404";
                button6.Text = "D306";
                button7.Text = "D305";
                button8.Text = "D303";
                button9.Text = "D302";
                button10.Text = "D301";
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
            }
            else if (this_zone == "B")
            {
                button1.Text = "B201";
                button2.Text = "B202";
                button3.Text = "B203";
                button4.Text = "B301";
                button5.Text = "B302";
                button6.Text = "B303";
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
            }
            check_valiable();
        }
        
        private void Textbox1_Click(object sender, EventArgs e)
        {
            if (hasvalue == 1)
            {
            }
            else
            {
                textBox1.Clear();
                check_valiable();
            }
            
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            if (hasvalue == 1)
            {
            }
            else
            {
                textBox2.Clear();
                check_valiable();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

            if (hasvalue == 1)
            {
                this.Visible = false;
                Select_zone Select_zone = new Select_zone("Change", course2, teacher2, student2, room2, capacity2, time2);
                Select_zone.Show();
            }
            else
            {
                this.Visible = false;
                Select_zone Select_zone = new Select_zone("Book");
                Select_zone.Show();
            }
        }

        

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (hasvalue == 1)
            {
            }
            else
            {
                textBox3.Clear();
                check_valiable();
            }
        }

        private void check_valiable()
        {
            Button[] obj = new Button[28];
            obj[1] = button1;
            obj[2] = button2;
            obj[3] = button3;
            obj[4] = button4;
            obj[5] = button5;
            obj[6] = button6;
            obj[7] = button7;
            obj[8] = button8;
            obj[9] = button9;
            obj[10] = button10;
            obj[11] = button11;
            obj[12] = button12;
            obj[13] = button13;
            obj[14] = button14;
            obj[15] = button15;
            obj[16] = button16;
            obj[17] = button17;
            obj[18] = button18;
            obj[19] = button19;
            obj[20] = button20;
            obj[21] = button21;
            obj[22] = button22;
            obj[23] = button23;
            obj[24] = button24;
            obj[25] = button25;
            obj[26] = button26;
            obj[27] = button27;
            for (int i = 1; i < 28; i++)
            {
                obj[i].BackColor = System.Drawing.Color.Green;
                if (theme == 1)
                {
                    obj[i].BackColor = System.Drawing.Color.LightSkyBlue;
                }
                if (theme == 2)
                {
                    obj[i].BackColor = System.Drawing.Color.Gold;
                }
                if (theme == 3)
                {
                    obj[i].BackColor = System.Drawing.Color.Pink;
                }
                
            }
           
                XmlDocument xmlDoc1 = new XmlDocument();
                xmlDoc1.Load("timetable.xml");
                XmlNodeList nodeList = xmlDoc1.SelectSingleNode("NewDataSet").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    for (int i = 1; i < 28; i++)
                    {
                    XmlElement xe = (XmlElement)xn;
                    //xe是一个row，一个table
                    XmlNodeList nls = xe.ChildNodes;
                    //nls是element，是F1，F2，F3
                    int choose = 0;
                    foreach (XmlNode xn1 in nls)
                    {
                        
                            //int choose = 0;
                            XmlElement xe2 = (XmlElement)xn1;
                            if (xe2.Name == "F4")
                            {
                                if (xe2.InnerText == obj[i].Text)
                                {
                                    choose = 1;
                                }
                            }

                            if (xe2.Name == "F6" && choose == 1)
                            {
                                
                                String temp = comboBox2.Text + " " + comboBox3.Text + "-" + comboBox1.Text;/*
                                String tem1 = comboBox1.Text.Replace(":", "");
                                int tem2 = System.Int32.Parse(tem1)+100;
                                int tem3 = System.Int32.Parse(tem1)+200;
                                string tem4 = Convert.ToString(tem2);
                                string tem5 = Convert.ToString(tem3);
                                tem4 = tem4.Replace("00", ":00");
                                tem5 = tem5.Replace("00", ":00");*/
                                String tem1 = comboBox3.Text.Replace(":", "");
                                String tem2 = comboBox1.Text.Replace(":", "");
                                int tem3 = System.Int32.Parse(tem1);//start
                                int tem4 = System.Int32.Parse(tem2);//end
                                String abc = xe2.InnerText.Substring(4);
                                int a=abc.IndexOf("-");
                                String abc2 = abc.Substring(a+1);
                                String abc3 = abc.Substring(0, a);
                                //MessageBox.Show("end time: " + abc2 + "start time: " + abc3);
                                String tem5 = abc2.Replace(":", "");
                                String tem6 = abc3.Replace(":", "");
                                int tem8 = System.Int32.Parse(tem6);//start
                                int tem7 = System.Int32.Parse(tem5);//end
                                if (tem3 > tem4)
                                {
                                    obj[i].BackColor = System.Drawing.Color.Red;
                                    if (theme == 1)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Orange;
                                    }
                                    if (theme == 2)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Silver;
                                    }
                                    if (theme == 3)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Purple;
                                    }
                                }
                                else if ((tem8 > tem4 && tem7 > tem4) || (tem3 > tem7 && tem4 > tem7))
                                {
                                    //MessageBox.Show("search start "+tem3+"search end "+tem4+"\nstart"+tem8+"end"+tem7);
                                }                                
                                else if(xe2.InnerText.Substring(0,3)==comboBox2.Text)
                                {
                                    obj[i].BackColor = System.Drawing.Color.Red;
                                    if (theme == 1)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Orange;
                                    }
                                    if (theme == 2)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Silver;
                                    }
                                    if (theme == 3)
                                    {
                                        obj[i].BackColor = System.Drawing.Color.Purple;
                                    }
                                }
                            }//13-15 13-14 
                        }//13-14 12-14 13-15 11-14 12-15 13-16
                    }//13-16 13-14 14-15 15-16 12-14 13-15 14-16 15-17 11-14 12-15 13-16 14-17 15-18
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == System.Drawing.Color.Green||button1.BackColor == System.Drawing.Color.LightSkyBlue||button1.BackColor == System.Drawing.Color.Gold||button1.BackColor == System.Drawing.Color.Pink)
            {
                book(button1.Text);
            }
            else
            {
                nobook(button1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == System.Drawing.Color.Green || button2.BackColor == System.Drawing.Color.LightSkyBlue || button2.BackColor == System.Drawing.Color.Gold || button2.BackColor == System.Drawing.Color.Pink)
            {
                book(button2.Text);
            }
            else
            {
                nobook(button2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == System.Drawing.Color.Green || button3.BackColor == System.Drawing.Color.LightSkyBlue || button3.BackColor == System.Drawing.Color.Gold || button3.BackColor == System.Drawing.Color.Pink)
            {
                book(button3.Text);
            }
            else
            {
                nobook(button3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == System.Drawing.Color.Green || button4.BackColor == System.Drawing.Color.LightSkyBlue || button4.BackColor == System.Drawing.Color.Gold || button4.BackColor == System.Drawing.Color.Pink)
            {
                book(button4.Text);
            }
            else
            {
                nobook(button4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == System.Drawing.Color.Green || button5.BackColor == System.Drawing.Color.LightSkyBlue || button5.BackColor == System.Drawing.Color.Gold || button5.BackColor == System.Drawing.Color.Pink)
            {
                book(button5.Text);
            }
            else
            {
                nobook(button5.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == System.Drawing.Color.Green || button6.BackColor == System.Drawing.Color.LightSkyBlue || button6.BackColor == System.Drawing.Color.Gold || button6.BackColor == System.Drawing.Color.Pink)
            {
                book(button6.Text);
            }
            else
            {
                nobook(button6.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == System.Drawing.Color.Green || button7.BackColor == System.Drawing.Color.LightSkyBlue || button7.BackColor == System.Drawing.Color.Gold || button7.BackColor == System.Drawing.Color.Pink)
            {
                book(button7.Text);
            }
            else
            {
                nobook(button7.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == System.Drawing.Color.Green || button8.BackColor == System.Drawing.Color.LightSkyBlue || button8.BackColor == System.Drawing.Color.Gold || button8.BackColor == System.Drawing.Color.Pink)
            {
                book(button8.Text);
            }
            else
            {
                nobook(button8.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == System.Drawing.Color.Green || button9.BackColor == System.Drawing.Color.LightSkyBlue || button9.BackColor == System.Drawing.Color.Gold || button9.BackColor == System.Drawing.Color.Pink)
            {
                book(button9.Text);
            }
            else
            {
                nobook(button9.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == System.Drawing.Color.Green || button10.BackColor == System.Drawing.Color.LightSkyBlue || button10.BackColor == System.Drawing.Color.Gold || button10.BackColor == System.Drawing.Color.Pink)
            {
                book(button10.Text);
            }
            else
            {
                nobook(button10.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == System.Drawing.Color.Green || button11.BackColor == System.Drawing.Color.LightSkyBlue || button11.BackColor == System.Drawing.Color.Gold || button11.BackColor == System.Drawing.Color.Pink)
            {
                book(button11.Text);
            }
            else
            {
                nobook(button11.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == System.Drawing.Color.Green || button12.BackColor == System.Drawing.Color.LightSkyBlue || button12.BackColor == System.Drawing.Color.Gold || button12.BackColor == System.Drawing.Color.Pink)
            {
                book(button12.Text);
            }
            else
            {
                nobook(button12.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == System.Drawing.Color.Green || button13.BackColor == System.Drawing.Color.LightSkyBlue || button13.BackColor == System.Drawing.Color.Gold || button13.BackColor == System.Drawing.Color.Pink)
            {
                book(button13.Text);
            }
            else
            {
                nobook(button13.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == System.Drawing.Color.Green || button14.BackColor == System.Drawing.Color.LightSkyBlue || button14.BackColor == System.Drawing.Color.Gold || button14.BackColor == System.Drawing.Color.Pink)
            {
                book(button14.Text);
            }
            else
            {
                nobook(button14.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == System.Drawing.Color.Green || button15.BackColor == System.Drawing.Color.LightSkyBlue || button15.BackColor == System.Drawing.Color.Gold || button15.BackColor == System.Drawing.Color.Pink)
            {
                book(button15.Text);
            }
            else
            {
                nobook(button15.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == System.Drawing.Color.Green || button16.BackColor == System.Drawing.Color.LightSkyBlue || button16.BackColor == System.Drawing.Color.Gold || button16.BackColor == System.Drawing.Color.Pink)
            {
                book(button16.Text);
            }
            else
            {
                nobook(button16.Text);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == System.Drawing.Color.Green || button17.BackColor == System.Drawing.Color.LightSkyBlue || button17.BackColor == System.Drawing.Color.Gold || button17.BackColor == System.Drawing.Color.Pink)
            {
                book(button17.Text);
            }
            else
            {
                nobook(button17.Text);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == System.Drawing.Color.Green || button18.BackColor == System.Drawing.Color.LightSkyBlue || button18.BackColor == System.Drawing.Color.Gold || button18.BackColor == System.Drawing.Color.Pink)
            {
                book(button18.Text);
            }
            else
            {
                nobook(button18.Text);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == System.Drawing.Color.Green || button19.BackColor == System.Drawing.Color.LightSkyBlue || button19.BackColor == System.Drawing.Color.Gold || button19.BackColor == System.Drawing.Color.Pink)
            {
                book(button19.Text);
            }
            else
            {
                nobook(button19.Text);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == System.Drawing.Color.Green || button20.BackColor == System.Drawing.Color.LightSkyBlue || button20.BackColor == System.Drawing.Color.Gold || button20.BackColor == System.Drawing.Color.Pink)
            {
                book(button20.Text);
            }
            else
            {
                nobook(button20.Text);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == System.Drawing.Color.Green || button21.BackColor == System.Drawing.Color.LightSkyBlue || button21.BackColor == System.Drawing.Color.Gold || button21.BackColor == System.Drawing.Color.Pink)
            {
                book(button21.Text);
            }
            else
            {
                nobook(button21.Text);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == System.Drawing.Color.Green || button22.BackColor == System.Drawing.Color.LightSkyBlue || button22.BackColor == System.Drawing.Color.Gold || button22.BackColor == System.Drawing.Color.Pink)
            {
                book(button22.Text);
            }
            else
            {
                nobook(button22.Text);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == System.Drawing.Color.Green || button23.BackColor == System.Drawing.Color.LightSkyBlue || button23.BackColor == System.Drawing.Color.Gold || button23.BackColor == System.Drawing.Color.Pink)
            {
                book(button23.Text);
            }
            else
            {
                nobook(button23.Text);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == System.Drawing.Color.Green || button24.BackColor == System.Drawing.Color.LightSkyBlue || button24.BackColor == System.Drawing.Color.Gold || button24.BackColor == System.Drawing.Color.Pink)
            {
                book(button24.Text);
            }
            else
            {
                nobook(button24.Text);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == System.Drawing.Color.Green || button25.BackColor == System.Drawing.Color.LightSkyBlue || button25.BackColor == System.Drawing.Color.Gold || button25.BackColor == System.Drawing.Color.Pink)
            {
                book(button25.Text);
            }
            else
            {
                nobook(button25.Text);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == System.Drawing.Color.Green || button26.BackColor == System.Drawing.Color.LightSkyBlue || button26.BackColor == System.Drawing.Color.Gold || button26.BackColor == System.Drawing.Color.Pink)
            {
                book(button26.Text);
            }
            else
            {
                nobook(button26.Text);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == System.Drawing.Color.Green || button27.BackColor == System.Drawing.Color.LightSkyBlue || button27.BackColor == System.Drawing.Color.Gold || button27.BackColor == System.Drawing.Color.Pink)
            {
                book(button27.Text);
            }
            else
            {
                nobook(button27.Text);
            }
        }

        private void book(String classroom)
        {
            String temp1 = comboBox3.Text.Replace(":", "");
            String temp2 = comboBox1.Text.Replace(":", "");
            int temp3 = System.Int32.Parse(temp1);
            int temp4 = System.Int32.Parse(temp2);
            
            if ((temp3 - temp4) > 0)
            {
                MessageBox.Show("You should input a valid time!");
            }
            else if (textBox1.Text == "Teacher" || textBox1.Text == "" || textBox3.Text == "Course name" || textBox3.Text == "")
            {
                MessageBox.Show("You should input a valid teacher name and course name");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You are booking "+classroom+" for teacher "+textBox1.Text+" and course "+textBox3.Text+" at "+comboBox2.Text+" "+comboBox3.Text+"-"+comboBox1.Text+". Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                  {
                
                
                

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("timetable.xml");
                    XmlNode root = xmlDoc.SelectSingleNode("NewDataSet");
                    XmlElement xe1 = xmlDoc.CreateElement("Table");


                    XmlElement xesub1 = xmlDoc.CreateElement("F1");
                    xesub1.InnerText = textBox3.Text;
                    xe1.AppendChild(xesub1);

                    XmlElement xesub2 = xmlDoc.CreateElement("F2");
                    xesub2.InnerText = textBox1.Text;
                    xe1.AppendChild(xesub2);

                    if (textBox2.Text == "Input Student")
                    {
                        XmlElement xesub3 = xmlDoc.CreateElement("F3");
                        xesub3.InnerText = "";
                        xe1.AppendChild(xesub3);
                    }
                    else
                    {
                        XmlElement xesub3 = xmlDoc.CreateElement("F3");
                        xesub3.InnerText = textBox2.Text;
                        xe1.AppendChild(xesub3);
                    }

                    XmlElement xesub5 = xmlDoc.CreateElement("F4");
                    xesub5.InnerText = classroom;
                    xe1.AppendChild(xesub5);

                    String temp = "50";
                    XmlDocument xmlDoc1 = new XmlDocument();
                    xmlDoc1.Load("timetable.xml");
                    XmlNodeList nodeList = xmlDoc1.SelectSingleNode("NewDataSet").ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {
                        {
                            XmlElement xe = (XmlElement)xn;
                            //xe是一个row，一个table
                            XmlNodeList nls = xe.ChildNodes;
                            //nls是element，是F1，F2，F3
                            int choose = 0;
                            foreach (XmlNode xn1 in nls)
                            {

                                //int choose = 0;
                                XmlElement xe2 = (XmlElement)xn1;
                                if (xe2.Name == "F4")
                                {
                                    if (xe2.InnerText == classroom)
                                    {
                                        choose = 1;
                                    }
                                }

                                if (xe2.Name == "F5" && choose == 1)
                                {
                                    temp = xe2.InnerText;
                                }
                            }
                        }
                    }

                    XmlElement xesub6 = xmlDoc.CreateElement("F5");
                    xesub6.InnerText = temp;
                    xe1.AppendChild(xesub6);

                    XmlElement xesub4 = xmlDoc.CreateElement("F6");
                    xesub4.InnerText = comboBox2.Text + " " + comboBox3.Text + "-" + comboBox1.Text; ;
                    xe1.AppendChild(xesub4);

                    root.AppendChild(xe1);
                    xmlDoc.Save("timetable.xml");
                    StreamWriter sw = File.AppendText("memo.txt");
                    sw.WriteLine("Book successful! \nRoom: " + classroom + "\n Time: " + comboBox2.Text + " " + comboBox3.Text + "-" + comboBox1.Text + "\n Course: " + textBox3.Text+"\n");
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Book successful! \nRoom: " +classroom + "\n Time: " + comboBox2.Text + " " + comboBox3.Text + "-" + comboBox1.Text + "\n Course: " + textBox3.Text);
                }
            }
            check_valiable();
        }

        private void nobook(String button)
        {
            Button[] obj = new Button[28];
            obj[1] = button1;
            obj[2] = button2;
            obj[3] = button3;
            obj[4] = button4;
            obj[5] = button5;
            obj[6] = button6;
            obj[7] = button7;
            obj[8] = button8;
            obj[9] = button9;
            obj[10] = button10;
            obj[11] = button11;
            obj[12] = button12;
            obj[13] = button13;
            obj[14] = button14;
            obj[15] = button15;
            obj[16] = button16;
            obj[17] = button17;
            obj[18] = button18;
            obj[19] = button19;
            obj[20] = button20;
            obj[21] = button21;
            obj[22] = button22;
            obj[23] = button23;
            obj[24] = button24;
            obj[25] = button25;
            obj[26] = button26;
            obj[27] = button27;

            int flag = 0;
            String teacher="";
            String coursetime="";
            String course = "";
            String classroom="";
            XmlDocument xmlDoc1 = new XmlDocument();
            xmlDoc1.Load("timetable.xml");
            XmlNodeList nodeList = xmlDoc1.SelectSingleNode("NewDataSet").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                for (int i = 1; i < 28; i++)
                {
                    XmlElement xe = (XmlElement)xn;
                    //xe是一个row，一个table
                    XmlNodeList nls = xe.ChildNodes;
                    //nls是element，是F1，F2，F3
                    int choose = 0;
                    if (flag == 2)
                    {
                        break;
                    }
                    flag = 0;
                    foreach (XmlNode xn1 in nls)
                    {
                        
                        //int choose = 0;
                        XmlElement xe2 = (XmlElement)xn1;
                        if (xe2.Name == "F1")
                        {
                            course = xe2.InnerText;
                        }
                        if (xe2.Name == "F2") 
                        {
                            teacher = xe2.InnerText;
                        }
                        if (xe2.Name == "F4")
                        {
                            if (xe2.InnerText == button)
                            {
                                choose = 1;
                                classroom=xe2.InnerText;
                            }
                        }

                        if (xe2.Name == "F6" && choose == 1)
                        {

                            String temp = comboBox2.Text + " " + comboBox3.Text + "-" + comboBox1.Text;/*
                                String tem1 = comboBox1.Text.Replace(":", "");
                                int tem2 = System.Int32.Parse(tem1)+100;
                                int tem3 = System.Int32.Parse(tem1)+200;
                                string tem4 = Convert.ToString(tem2);
                                string tem5 = Convert.ToString(tem3);
                                tem4 = tem4.Replace("00", ":00");
                                tem5 = tem5.Replace("00", ":00");*/
                            String tem1 = comboBox3.Text.Replace(":", "");
                            String tem2 = comboBox1.Text.Replace(":", "");
                            int tem3 = System.Int32.Parse(tem1);//start
                            int tem4 = System.Int32.Parse(tem2);//end
                            String abc = xe2.InnerText.Substring(4);
                            int a = abc.IndexOf("-");
                            String abc2 = abc.Substring(a + 1);
                            String abc3 = abc.Substring(0, a);
                            //MessageBox.Show("end time: " + abc2 + "start time: " + abc3);
                            String tem5 = abc2.Replace(":", "");
                            String tem6 = abc3.Replace(":", "");
                            int tem8 = System.Int32.Parse(tem6);//start
                            int tem7 = System.Int32.Parse(tem5);//end
                            if ((tem8 > tem4 && tem7 > tem4) || (tem3 > tem7 && tem4 > tem7)||xe2.InnerText.Substring(0,3)!=comboBox2.Text)
                            {
                                flag = 0;
                            }
                            else
                            {
                                flag=1;
                                coursetime = xe2.InnerText;
                            }

                        }
                        if (flag == 1 && choose == 1)
                        {
                            MessageBox.Show("This classroom has already been booked by " + teacher + " for " + course + " at " + coursetime+ " at classroom "+ classroom);
                            flag = 2;
                        }//13-15 13-14 
                    }//13-14 12-14 13-15 11-14 12-15 13-16
                }//13-16 13-14 14-15 15-16 12-14 13-15 14-16 15-17 11-14 12-15 13-16 14-17 15-18
            }
        }
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            check_valiable();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            /*String temp1 = comboBox3.Text.Replace(":", "");
            String temp2 = comboBox1.Text.Replace(":", "");
            int temp3 = System.Int32.Parse(temp1);
            int temp4 = System.Int32.Parse(temp2);
            if (temp3 > temp4)
            {
                comboBox3.Text = "8:00";
            }*/
            check_valiable();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            check_valiable();
        }

        private void themebutton_Click(object sender, EventArgs e)
        {
            if (theme < 3)
            {
                theme++;
            }
            else
            {
                theme = 0;
            }
            check_valiable();
        }
    }
}