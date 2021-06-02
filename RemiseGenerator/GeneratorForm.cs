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
using System.Xml;

namespace RemiseGenerator
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
            File.Delete(@"D:\schema058.xml");
        }

        private void Moive()
        {
        }

        private void BtnLoadXML_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            path = (@"D://schema058.xml");
            treeViewServices treeviewXml = new treeViewServices();
            treeviewXml.readXml(path, treeXML); 


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                xmlServices xmlService = new xmlServices();

                string path = string.Empty;
                path = (@"D:\schema058.xml");

                string xmlInputData = string.Empty;
                string xmlOutputData = string.Empty;

                // EXAMPLE 2

                xmlInputData = File.ReadAllText(path);

                Document document = xmlService.Deserialize<Document>(xmlInputData);

                List<string> rowsList = new List<string>();
                xmlService.readRows(document.Rows, rowsList);

                lstDATA.Items.Clear();

                for (int i = 0; i < rowsList.Count; i++)
                {
                    lstDATA.Items.Add(rowsList.ElementAt(i));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No XML to generate");
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            saveFile.InitialDirectory = @"C:\Users\Mehdi\Desktop";
            saveFile.Title = "Save text";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                foreach (var item in lstDATA.Items)
                sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void BtnAnnuller_Click(object sender, EventArgs e)
        {
            treeXML.Nodes.Clear();
            lstDATA.Items.Clear();
            File.Delete(@"D:\schema058.xml");
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Vous voullez quitter le générateur?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void SelectXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose XML";
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.InitialDirectory = @"C:\Users\Mehdi\Desktop\XML";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            ofd.ShowDialog();

            string path = "";
            string destinationPath = @"D:\";
            string destinationPath2 = @"D:\schema058.xml";

            

            path = ofd.FileName;


            try
            {
                destinationPath += Path.GetFileName(path);
                File.Copy(path, destinationPath);
                File.Move(destinationPath, destinationPath2);

                MessageBox.Show("XML Selected successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Select XML please");
            }
              

        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter le générateur?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
