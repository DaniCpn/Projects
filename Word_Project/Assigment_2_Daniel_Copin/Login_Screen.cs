using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assigment_2_Daniel_Copin
{
    public partial class Login_Screen : Form
    {
        //Initialize
        public Login_Screen()
        {
            InitializeComponent();
        }

        //Exit Function
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //New User Function
        private void NewUser2_Click(object sender, EventArgs e)
        {
            //Create new user
            New_User New_User = new New_User();
            //And display
            New_User.Show();
        }

        //Login Function
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("login.txt");

                bool found = true;
                foreach (string set in lines)
                {
                    // Split each line
                    string[] splits = set.Split(',');
                    //Display the values of username and password
                    Console.WriteLine("UserName: {0}, Password: {1}", splits[0], splits[1]);


                    if((tB_Username.Text == splits[0]) && (tB_Password.Text == splits[1]))
                    {
                        Text_Editor text_edit = new Text_Editor();
                        text_edit.Show();
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }

                }
                if (found == false)
                {
                    MessageBox.Show("UserName of Password Incorrect");
                }

            }
            // Catch the FileNotFoundException exception
            catch (FileNotFoundException errorMsg)
            {
                // Display the error message
                Console.WriteLine(errorMsg.Message);
                Console.ReadKey();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
