using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Lab_Exer_1
{
    public partial class frmRegistration : Form
    {
        //private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        private string _FirstName;
        private string _LastName;
        private string _MiddleInitial;
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            string[] Gender = new string[]
            {
                "Male",
                "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(Gender[i].ToString());
            }
        }
        public long StudentNumber(string studNum)
        {
            if (Regex.IsMatch(studNum, @"^[0-9]{11}"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new FormatException("Enter 11 digit number on Student Number");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new OverflowException("Enter 11 digit number on contact no.!");
            }

            return _ContactNo;
        }

        /*public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("Wrong input in Name!");
            }

            return _FullName;
        }*/
        public string FirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, @"^[a-zA-Z]+$"))
            {
                _FirstName = FirstName;
            }
            else
            {
                throw new ArgumentNullException("Null or Wrong input in First Name!");
            }
            return _FirstName;
        }
        public string LastName(string LastName)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$"))
            {
                _LastName = LastName;
            }
            else
            {
                throw new ArgumentNullException("Null or Wrong input in Last Name!");
            }
            return _LastName;
        }
        public string MiddleInitial(string MiddleInitial)
        {
            if (Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _MiddleInitial = MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException("Null or Wrong input in Middle Inital!");
            }
            return _MiddleInitial;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new IndexOutOfRangeException("Null or Out of Range in Age");
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformation.SetStudentNo = StudentNumber(txtSudentNo.Text);
                /*StudentInformation.SetFullName = FullName(txtLastName.Text,txtFirstName.Text,
                    txtMiddleInitial.Text);*/
                StudentInformation.SetFullname = LastName(txtLastName.Text) + ", "+
                    FirstName(txtFirstName.Text) +", "+ MiddleInitial(txtMiddleInitial.Text);
                StudentInformation.SetProgram = cbProgram.Text;
                StudentInformation.SetGender = cbGender.Text;
                StudentInformation.SetAge = Age(txtAge.Text);
                StudentInformation.SetContactNo = ContactNo(txtContacNo.Text);
                StudentInformation.SetBirthday = datePickerBrithday.Value.ToString("yyyy-MM-dd");
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (ArgumentNullException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message);
            }
            catch (IndexOutOfRangeException r)
            {
                MessageBox.Show(r.Message);
            }

        }
    }
}
