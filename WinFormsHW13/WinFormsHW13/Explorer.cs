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

namespace WinFormsHW13
{
    public partial class Explorer : Form
    {
        TreeNode treeNodeDrives;
        public Explorer()
        {
            InitializeComponent();
            InfoDriveMove();
        }

        private void TreeDrive(TreeNode driveNodes, string path)
        {
            string[] directorios = Directory.GetDirectories(path);
            foreach (string directory in directorios)
            {
                TreeNode treeNodeDrive = new TreeNode();
                treeNodeDrive.Text = directory.Remove(0, directory.LastIndexOf("\\") + 1);
                driveNodes.Nodes.Add(treeNodeDrive);
            }
        }

        private void InfoDriveMove()
        {
            treeNodeDrives = new TreeNode();
            foreach (DriveInfo infoDrive in DriveInfo.GetDrives())
            {                
                TreeDrive(treeNodeDrives, infoDrive.Name);
                treeViewExplorerFile.Nodes.Add(treeNodeDrives);
                treeNodeDrives = new TreeNode()
                {
                    Text = infoDrive.Name
                };
               
            }
        }
    }
}
