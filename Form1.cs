using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = "Muhammad Ali";
            student.Age = 20;
            student.RollNum = "014";
            student.Class1 = "FA25-BSE";
            string name = student.Name;
            int age = student.Age;
            string rollNum = student.RollNum;
            string class1 = student.Class1;
            string Id = student.Class1 + student.RollNum;
            label1.Text = student.introduce();
        }
    }
}
