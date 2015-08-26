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

namespace Classroom_Allocation_System
{
    public partial class Select_Classroom_Cancel : Theme
    {
        int switcher=0;
        String course = "";
        String teacher = "";
        String student = "";
        String room = "";
        String capacity = "";
        String timedomain = "";
        String timetemp = "";
        String course2 = "";
        String teacher2 = "";
        String student2 = "";
        String room2 = "";
        String capacity2 = "";
        String timedomain2 = "";
        String timetemp2 = "";
        String operation;
        int choosenumber;
        int roomchange;
        public Select_Classroom_Cancel(String operate)
        {
            operation = operate;
            InitializeComponent();
            if (operation == "change")
            {
                choosenumber = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomchange = 0;
            //MessageBox.Show(timetemp);
            XmlDocument xmlDoc1 = new XmlDocument();
            xmlDoc1.Load("timetable.xml");
            XmlNodeList nodeList = xmlDoc1.SelectSingleNode("NewDataSet").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                int choose = 0;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;
                    if (xe2.Name == "F1")
                    {
                        if (xe2.InnerText == textBox1.Text)
                        {
                            course = xe2.InnerText;
                            choose = 1;
                            
                        }
                    }
                    if (xe2.Name == "F6" && choose == 1)
                    {
                            //choose = 2;
                            //MessageBox.Show(xe2.InnerText);
                            timedomain = xe2.InnerText;
                            
                           
                        
                    }
                    if (xe2.Name == "F2" && choose == 1)
                    {
                        //choose = 3;
                        teacher = xe2.InnerText;
                        

                    }
                    if (xe2.Name == "F3" && choose == 1)
                    {
                        //choose = 4;
                        student = xe2.InnerText;
                        //label10.Text = "Teacher: " + xe2.InnerText;

                    }
                    if (xe2.Name == "F4" && choose == 1)
                    {
                        //choose = 5;
                        room = xe2.InnerText;
                        

                    }
                    if (xe2.Name == "F5" && choose == 1)
                    {
                        //choose = 6;
                        capacity = xe2.InnerText;
                        //label10.Text = "Teacher: " + xe2.InnerText;

                    }
                   
                    
                    
                    
                   
                }
                
            }


            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.Load("timetable.xml");
            XmlNodeList nodeList2 = xmlDoc2.SelectSingleNode("NewDataSet").ChildNodes;
            foreach (XmlNode xn in nodeList2)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                int choose = 0;
                int choosetime = 0;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;
                    if (xe2.Name == "F1")
                    {
                        if (xe2.InnerText == textBox1.Text)
                        {
                            course = xe2.InnerText;
                            choose = 1;
                        }
                    } 
                    if (xe2.Name == "F2" && choose == 1)
                    {
                        //choose = 3;
                        teacher2 = xe2.InnerText;


                    }
                    if (xe2.Name == "F3" && choose == 1)
                    {
                        //choose = 4;
                        student2 = xe2.InnerText;
                        //label10.Text = "Teacher: " + xe2.InnerText;

                    }
                    if (xe2.Name == "F4" && choose == 1 && xe2.InnerText!=room)
                    {
                        //choose = 5;
                        room2 = xe2.InnerText;


                    }
                    if (xe2.Name == "F5" && choose == 1)
                    {
                        //choose = 6;
                        capacity2 = xe2.InnerText;
                        //label10.Text = "Teacher: " + xe2.InnerText;

                    }      
                    if (xe2.Name == "F6" && choose == 1 && xe2.InnerText != timedomain)
                    {
                        //choose = 2;
                        //MessageBox.Show(xe2.InnerText);
                        timedomain2 = xe2.InnerText;
                        choosetime = 1;
                    }
                             

                }

            }
            if (room2=="")
            {
                room2 = room;
            }
            if (timedomain2=="")
            {
                timedomain2 = timedomain;
            }

            if (switcher==0)
            {
                
                    label9.Text = "Room: " + room;
                    label10.Text = "Teacher: " + teacher;
                    label8.Text =  "Time: "+timedomain;
                    label2.Text = "Course Name: " + course;
                    roomchange = 1;
                    switcher = 1;
            }
            else
            {
                
                label9.Text = "Room: " + room2;
                label10.Text = "Teacher: " + teacher;
                label8.Text =  "Time: "+timedomain2;
                label2.Text = "Course Name: " + course;
                roomchange = 1;
                switcher = 0;
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (course == "")
            {
                MessageBox.Show("You should choose a course first!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You are canceling " + room + " for teacher " + teacher + " and course " + course + ". Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    XmlDocument xmlDoc2 = new XmlDocument();
                    xmlDoc2.Load("timetable.xml");
                    XmlNodeList nodeList = xmlDoc2.SelectSingleNode("NewDataSet").ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {
                        XmlElement xe = (XmlElement)xn;
                        XmlNodeList nls = xe.ChildNodes;
                        int choose = 0;
                        int choosetime = 0;
                        foreach (XmlNode xn1 in nls)
                        {
                            XmlElement xe2 = (XmlElement)xn1;
                            if (xe2.Name == "F1")
                            {
                                if (xe2.InnerText == textBox1.Text)
                                {
                                    label2.Text = "Course Name: " + textBox1.Text;
                                    choose = 1;
                                }
                            }
                            if (xe2.Name == "F6" && choose == 1)
                            {
                                if (xe2.InnerText == label8.Text.Substring(6))
                                {
                                    choosetime = 1;
                                }
                            }
                            if (choose == 1 && choosetime == 1)
                            {
                                xe.RemoveAll();
                                StreamWriter sw = File.AppendText("Cancelmemo.txt");
                                sw.WriteLine("Cancel successful! \nRoom: " + room + " for teacher " + teacher + " and course " + course + " at "+timedomain+"\n");
                                sw.Flush();
                                sw.Close();
                                MessageBox.Show("Cancel successful!");
                                choose = 0;
                            }
                        }




                    }
                    xmlDoc2.Save("timetable.xml");
                    if (choosenumber == 1)
                    {
                        this.Visible = false;
                        Select_zone Select_zone = new Select_zone("Change", course, teacher, student, room, capacity, timedomain);
                        Select_zone.Show();
                    }
                    else if (choosenumber == 0)
                    {
                        this.Visible = false;
                        Operation Operation = new Operation();
                        Operation.Show();
                    }
                }
            }
        }

        private void Select_Classroom_Cancel_Load(object sender, EventArgs e)
        {
            time = 6000;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation Operation = new Operation();
            Operation.Show();
        }
    }
}
