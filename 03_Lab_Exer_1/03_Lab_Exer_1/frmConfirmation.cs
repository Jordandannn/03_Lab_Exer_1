using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Lab_Exer_1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = "0"+StudentInformation.SetStudentNo.ToString();
            lblName.Text = StudentInformation.SetFullname.ToString();
            lblProgram.Text = StudentInformation.SetProgram.ToString();
            lblBirthday.Text = StudentInformation.SetBirthday.ToString();
            lblGender.Text = StudentInformation.SetGender.ToString();
            lblContactNo.Text = "+63"+StudentInformation.SetContactNo.ToString();
            lblAge.Text = StudentInformation.SetAge.ToString();
        }
    }
}
