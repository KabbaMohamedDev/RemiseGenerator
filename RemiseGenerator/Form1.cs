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
    public partial class Form1 : Form
    {
        private static Form1 frmGV;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGV = null;
        }

        public static Form1 getGenerator
        {
            get
            {
                if (frmGV == null)
                {
                    frmGV = new Form1();
                    frmGV.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmGV;
            }
        } 

        public Form1()
        {
            InitializeComponent();
            if (frmGV == null)
            {
                frmGV = this;
            }

            this.BtnGenerator.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnClose1_Click(object sender, EventArgs e)
        {

            SidePanel.Top = BtnClose1.Top;


            if (MessageBox.Show("Vous voullez quitter l'application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void BtnClose2_Click(object sender, EventArgs e)
        {

            SidePanel.Top = BtnClose2.Top;

            if (MessageBox.Show("Vous voullez quitter l'application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();

            SidePanel.Top = BtnLogin.Top;
        }

        private void BtnGenerator_Click(object sender, EventArgs e)
        {
            GeneratorForm GF = new GeneratorForm();
            GF.Owner = this;
            GF.Show();

            SidePanel.Top = BtnGenerator.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SidePanel.Top = button1.Top;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            SidePanel.Top = BtnLogOut.Top;
            if (Form1.getGenerator.BtnGenerator.Enabled == false)
            {
                MessageBox.Show("already loged out", "LOG OUT", MessageBoxButtons.OK);
            }
            else 
            {
                Form1.getGenerator.BtnGenerator.Enabled = false;
            }
        }
    }
}
