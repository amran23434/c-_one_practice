using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigmment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string student_name, student_id, department, semester, fulldate;
            student_name = txtname.Text;
            student_id = txtstudentid.Text;
            department = txtdepartment.Text;
            semester = txtsemester.Text;
            fulldate = student_name + "" + student_id + "" + department + "" + semester;
            lbloutput.Text = fulldate;




                


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";




        }
    }
}
