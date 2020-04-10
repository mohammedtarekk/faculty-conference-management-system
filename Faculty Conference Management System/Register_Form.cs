﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Conference_Management_System
{
    public partial class Register_Form : Form
    {
        public Login_Form LoginFormObject = new Login_Form();

        public Register_Form()
        {
            InitializeComponent();
        }



        private void BunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
           
        }

        private void Exit_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFormObject.Show();
        }

        private void UserID_txt_MouseClick(object sender, MouseEventArgs e)
        {
            UserID_txt.Text = "";
            UserID_txt.ForeColor = Color.Silver;
        }

        private void Password_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Password_txt.Text = "";
            Password_txt.ForeColor = Color.Silver;
            Password_txt.PasswordChar = '*';
        }

        private void FName_txt_MouseClick(object sender, MouseEventArgs e)
        {
            FName_txt.Text = "";
            FName_txt.ForeColor = Color.Silver;
        }

        private void LNAME_txt_MouseClick(object sender, MouseEventArgs e)
        {
            LNAME_txt.Text = "";
            LNAME_txt.ForeColor = Color.Silver;
        }

        private void Email_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Email_txt.Text = "";
            Email_txt.ForeColor = Color.Silver;
        }

        private void Address_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Address_txt.Text = "";
            Address_txt.ForeColor = Color.Silver;
        }

        private void DateBirth_txt_MouseClick(object sender, MouseEventArgs e)
        {
            DateBirth_txt.Text = "";
            DateBirth_txt.ForeColor = Color.Silver;
        }

        private void SignUp_bt_Click(object sender, EventArgs e)
        {
            //PUT YOUR LOGIC HERE ^^


            //USE ACCORDING TO YOUR LOGIC BUT DON'T MODIFY THIS
            MessageBox.Show("SUCCESS","You have been registered successfully! Sign in NOW!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            LoginFormObject.Show();
        }
    }
    
}
