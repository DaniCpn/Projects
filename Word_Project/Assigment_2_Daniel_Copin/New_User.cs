using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_2_Daniel_Copin
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }

        //Cancel Function
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //New User Function
        private void NewUser_Click(object sender, EventArgs e)
        {
            string new_user = "";

            if(tB_RePassword.Text == tB_Password.Text)
            {
                new_user = tB_Username.Text + "," + tB_Password.Text;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\UTS Projects\P.NET\Assigment_2_Daniel_Copin\Assigment_2_Daniel_Copin\bin\Debug\login.txt", true))
                {
                    file.WriteLine(new_user);
                }        
            }
            else
            {
                MessageBox.Show("The Password is not Correct");
            }
            
        }
    }
}
