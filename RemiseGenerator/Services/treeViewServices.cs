using System;
using System.Windows.Forms;
using System.Xml;

namespace RemiseGenerator
{
    public class treeViewServices
    {
        public void readXml(String fullFileName,TreeView treeView)
        {
            try
            {
                XmlTextReader xtr = new XmlTextReader(fullFileName);
                xtr.WhitespaceHandling = WhitespaceHandling.None;

                XmlDocument xd = new XmlDocument();
                xd.Load(xtr);
                LoadTreeFromXmlDocument(xd, treeView);
                xtr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No XML Founded");
            }
        }
        private void LoadTreeFromXmlDocument(XmlDocument dom, TreeView treeView)
        {
            try
            {
                // SECTION 2. Initialize the TreeView control.
                treeView.Nodes.Clear();

                // SECTION 3. Populate the TreeView with the DOM nodes.
                foreach (XmlNode node in dom.DocumentElement.ChildNodes)
                {
                    if (node.Name == "namespace" && node.ChildNodes.Count == 0 && string.IsNullOrEmpty(GetAttributeText(node, "name")))
                        continue;
                    AddNode(treeView.Nodes, node);
                }

                treeView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetAttributeText(XmlNode inXmlNode, string name)
        {
            XmlAttribute attr = (inXmlNode.Attributes == null ? null : inXmlNode.Attributes[name]);
            return attr == null ? null : attr.Value;
        }

        private void AddNode(TreeNodeCollection nodes, XmlNode inXmlNode)
        {
            if (inXmlNode.HasChildNodes)
            {
                string text = GetAttributeText(inXmlNode, "name");

                if (string.IsNullOrEmpty(text))
                    text = inXmlNode.Name;
                TreeNode newNode = nodes.Add(text);
                XmlNodeList nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    XmlNode xNode = inXmlNode.ChildNodes[i];
                    AddNode(newNode.Nodes, xNode);
                }
            }
            else
            {
                // If the node has an attribute "name", use that.  Otherwise display the entire text of the node.
                string text = GetAttributeText(inXmlNode, "name");
                if (string.IsNullOrEmpty(text))
                    text = (inXmlNode.OuterXml).Trim();
                TreeNode newNode = nodes.Add(text);
            }
        }
    }
}
