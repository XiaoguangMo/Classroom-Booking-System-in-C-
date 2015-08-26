using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classroom_Allocation_System
{
    public partial class Select_zone : Theme
    {
        String this_operation;
        String course2="";
        String teacher2;
        String student2;
        String room2;
        String capacity2;
        String time2;
        public Select_zone(String operation)
        {
            InitializeComponent();
            this_operation = operation;
        }

        public Select_zone(String operation, String course, String teacher, String student, String room, String capacity, String time)
        {
            InitializeComponent();
            this_operation = operation;
            course2 = course;
            teacher2 = teacher;
            student2 = student;
            room2 = room;
            capacity2 = capacity;
            time2 = time;
        }

        private void Select_zone_Load(object sender, EventArgs e)
        {

            time = 6000;
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("D");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("D",course2,teacher2,student2,room2,capacity2,time2);
                book.Show();
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("E");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("E", course2, teacher2, student2, room2, capacity2, time2);
                book.Show();
            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("F");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("F", course2, teacher2, student2, room2, capacity2, time2);
                book.Show();
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("A");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("A", course2, teacher2, student2, room2, capacity2, time2);
                book.Show();
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("B");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("B", course2, teacher2, student2, room2, capacity2, time2);
                book.Show();
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (this_operation == "Book")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("C");
                book.Show();
            }
            else if (this_operation == "Change")
            {
                this.Visible = false;
                Select_Classroom_Book book = new Select_Classroom_Book("C", course2, teacher2, student2, room2, capacity2, time2);
                book.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (course2 == "")
            {
                this.Visible = false;
                Operation Operation = new Operation();
                Operation.Show();
            }
            else
            {
                this.Visible = false;
                Select_Classroom_Cancel Select_Classroom_Cancel = new Select_Classroom_Cancel("change");
                Select_Classroom_Cancel.Show();
            }
        }
    }
}
