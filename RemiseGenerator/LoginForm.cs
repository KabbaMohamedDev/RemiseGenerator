using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemiseGenerator
{
    public partial class LoginForm : Form 
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public void BtnConnect_Click(object sender, EventArgs e)
        {
            string username = textbox1.Text;
            string password = textbox2.Text;

            if (Form1.getGenerator.BtnGenerator.Enabled == true)
            {
                MessageBox.Show("Already login", "LOGIN", MessageBoxButtons.OK);
            }

            else
            {

                if (textbox1.Text == string.Empty && textbox2.Text == string.Empty)
                {

                    MessageBox.Show("Saisir Nom d'utilisateur et Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox1.Focus();
                }

                else if (textbox1.Text != string.Empty && textbox2.Text == string.Empty)
                {
                    MessageBox.Show("Saisir Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox1.Focus();

                }

                else if (textbox1.Text == string.Empty && textbox2.Text != string.Empty)
                {
                    MessageBox.Show("Saisir Nom d'utilisateur", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox1.Focus();

                }


                else if (username == "admin" && password == "admin123")
                {

                    MessageBox.Show("Login successfully", "LOGIN", MessageBoxButtons.OK);
                    this.Hide();
                    Form1.getGenerator.BtnGenerator.Enabled = true;

                }


                else
                {
                    MessageBox.Show("Login failed");
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox1.Focus();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           this.Hide();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
