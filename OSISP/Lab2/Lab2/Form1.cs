using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {

            int tabNumber = XMLTabWindow.TabCount + 1;
            TreeView newTreeView = new TreeView();
            newTreeView.Location = new System.Drawing.Point(6, 6);
            newTreeView.Name = "treeView1";
            newTreeView.Size = new System.Drawing.Size(881, 453);
            newTreeView.TabIndex = 0;

            TabPage newTab = new TabPage();
            newTab.Controls.Add(newTreeView);
            newTab.Location = new System.Drawing.Point(4, 22);
            newTab.Name = "tabPage" + tabNumber;
            newTab.Padding = new System.Windows.Forms.Padding(3);
            newTab.Size = new System.Drawing.Size(893, 465);
            newTab.TabIndex = 0;
            newTab.Text = "Page "+tabNumber;
            newTab.UseVisualStyleBackColor = true;

            this.XMLTabWindow.Controls.Add(newTab);
            this.XMLTabWindow.SelectTab(newTab);

        }

        private TreeView GetTreeViewFromTab(TabPage tabPage)
        {
            return (TreeView)tabPage.Controls["treeView1"];
        }

        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            if (XMLTabWindow.TabPages.Count > 1)
            {
                this.XMLTabWindow.TabPages.Remove(XMLTabWindow.SelectedTab);
                XMLTabWindow.SelectTab(XMLTabWindow.TabPages[XMLTabWindow.TabPages.Count - 1]);
            }
            
        }

        private void OpenXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filename = openFileDialog.FileName;
                parseXmlToTab(filename, XMLTabWindow.SelectedTab);
            }

        }

        private void parseXmlToTab(string filename, TabPage currentTab)
        {
            TreeView currentTreeView = GetTreeViewFromTab(currentTab);
            XmlDocument dom = new XmlDocument();
                dom.Load(filename);

                XmlNode rootXml = dom.FirstChild;

                TreeNode rootNode = new TreeNode();
                AddChildToNode(rootNode, rootXml);
                currentTreeView.Nodes.Add(rootNode);
                currentTreeView.EndUpdate();
            
        
        }

        private void AddChildToNode(TreeNode treeNode, XmlNode xmlNode)
        {
            if (xmlNode != null)
            {
                treeNode.Text = xmlNode.Name;
                if (xmlNode.Attributes != null)
                {
                    foreach (XmlAttribute attribute in xmlNode.Attributes)
                    {
                        TreeNode attrNode = new TreeNode();
                        attrNode.Text = attribute.LocalName;
                        attrNode.Nodes.Add(new TreeNode(attribute.Value));
                        treeNode.Nodes.Add(attrNode);
                    }
                }

                foreach (XmlNode child in xmlNode.ChildNodes)
                {
                    TreeNode node = new TreeNode();
                    AddChildToNode(node, child);
                    treeNode.Nodes.Add(node);
                }

            }

        }

    }

}
