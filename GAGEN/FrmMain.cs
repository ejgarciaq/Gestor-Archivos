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
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace GAGEN
{
    public partial class FrmMain : Form
    {
        //Variables universales
        Computer mycomputer = new Computer();
        string rutainicial;
        public string envio = "";
        public string destino;
        string infile;
        
        public FrmMain()
        {
            InitializeComponent();
            PopulateTreeView();
            TbAddress.Text = rutainicial;
        }

        //---- METODOS

        /* Crea el arbol*/
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            rutainicial = @"C:\Users\ejgar\source\repos\Gestor Archivos GEN\GAGEN\bin\Debug\Sistemas Operativos II";

            DirectoryInfo info = new DirectoryInfo(rutainicial);

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.ExpandAll();
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        /*visualizar  directorios en TreeView*/
        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        //visualizar contenido en listview
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directorio"),
                        new ListViewItem.ListViewSubItem(item,
                    dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
                        new ListViewItem.ListViewSubItem(item,
                    file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.EndUpdate();
            treeView1.EndUpdate();
            listView1.Refresh();
            treeView1.Refresh();
        }

        //Menu desplegable

        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            envio = TbAddress.Text;
            infile = listView1.SelectedItems[0].Text;
        }



        private void origenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            origenToolStripMenuItem.Enabled = false;
            envio = TbAddress.Text;
            infile = listView1.SelectedItems[0].Text;
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destino();
        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar() {
            try
            {
                DialogResult opcion = MessageBox.Show("Está seguro de eliminar ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                string ruta = TbAddress.Text;

                if (opcion == DialogResult.OK)
                {
                    if (Directory.Exists(ruta))
                    {
                        mycomputer.FileSystem.DeleteDirectory(ruta, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
                    }
                    else
                        mycomputer.FileSystem.DeleteFile(ruta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearTxt frmC = new FrmCrearTxt();
            frmC.RutaDir = TbAddress.Text;
            frmC.Show();
        }

        /*Abrir archivo por software por defecto segun SO*/
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(TbAddress.Text);
        }

        //---- ver direccion en textbox
        private void DirListViewr_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Application.StartupPath;
            string selectedFile = listView1.SelectedItems[0].Text;
            string selectedDir = treeView1.SelectedNode.Text;

            if (selectedDir == "Sistemas Operativos II")
            {
                TbAddress.Text = Path.Combine(ruta, selectedDir, selectedFile);
            } else
                TbAddress.Text = Path.Combine(ruta + @"\Sistemas Operativos II", selectedDir, selectedFile);
        }

        //--- ToolStripMenu
        private void carpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearCarpeta frm = new FrmCrearCarpeta();
            frm.RutaDir = TbAddress.Text;
            frm.Show();
        }

        private void toolStripCrearArchivo_Click(object sender, EventArgs e)
        {
            FrmCrearTxt frmC = new FrmCrearTxt();
            frmC.RutaDir = TbAddress.Text;
            frmC.Show();
            listView1.Refresh();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();     
        }

        private void toolStripBtnInicio_Click(object sender, EventArgs e)
        {
            home();
        }

        private void home(){
            TbAddress.Text = rutainicial;
            treeView1.Nodes.Clear();
            PopulateTreeView();
            listView1.Items.Clear();
            listView1.Items.Add(rutainicial);

            //--actualizar listview
            TreeNode newSelected = treeView1.Nodes[0];
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directorio"),
                        new ListViewItem.ListViewSubItem(item,
                    dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
                        new ListViewItem.ListViewSubItem(item,
                    file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            this.treeView1.SelectedNode = this.treeView1.Nodes[0];
            this.treeView1.Select();
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }



        //Visualizar listview
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TreeNode newSelected = treeView1.Nodes[0];
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directorio"),
                        new ListViewItem.ListViewSubItem(item,
                    dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
                        new ListViewItem.ListViewSubItem(item,
                    file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
        }

        private void toolStripCrearCarpeta_Click(object sender, EventArgs e)
        {
            FrmCrearCarpeta frm = new FrmCrearCarpeta();
            frm.RutaDir = TbAddress.Text;
            frm.Show();      
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destino = TbAddress.Text;
            string Origen = envio;
            string Destino = destino;

            try
            {
                if (Origen != "" && Destino != "")
                {
                    if (MessageBox.Show("Se copio " + Origen + " correctamente.", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (Directory.Exists(envio))
                        {
                            mycomputer.FileSystem.CopyDirectory(envio, destino + @"\" + infile);
                        }
                        if (File.Exists(envio))
                        {
                            mycomputer.FileSystem.CopyFile(envio, destino + @"\" + infile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debes ingresar una ruta de Origen y otra de Destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo copiar Archivo no se puede copiar o ya existe en el destino");
            }

        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            envio = TbAddress.Text;
            infile = listView1.SelectedItems[0].Text;
        }

        private void toolStripPegar_Click(object sender, EventArgs e)
        {
            destino = TbAddress.Text;
            string Origen = envio;
            string Destino = destino;

            try
            {
                if (Origen != "" && Destino != "")
                {
                    if (MessageBox.Show("Se copio " + Origen + " correctamente.", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (Directory.Exists(envio))
                        {
                            mycomputer.FileSystem.CopyDirectory(envio, destino + @"\" + infile);
                        }
                        if (File.Exists(envio))
                        {
                            mycomputer.FileSystem.CopyFile(envio, destino + @"\" + infile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debes ingresar una ruta de Origen y otra de Destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo copiar Archivo no se puede copiar o ya existe en el destino");
            }
        }

        private void origenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            origenToolStripMenuItem.Enabled = false;
            envio = TbAddress.Text;
            infile = listView1.SelectedItems[0].Text;   
        }

        private void destinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Destino();
        }
        private void Destino() {
            destino = TbAddress.Text;

            string Origen = envio;
            string Destino = destino;

            try
            {
                if (Origen != "" && Destino != "")
                {
                    if (Directory.Exists(envio))
                    {
                        mycomputer.FileSystem.MoveDirectory(envio, destino + @"\" + infile);
                    }
                    if (File.Exists(envio))
                    {
                        mycomputer.FileSystem.MoveFile(envio, destino + @"\" + infile);
                    }
                    if (MessageBox.Show("Se movio " + Origen + " correctamente.", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Debes ingresar una ruta de Origen y otra de Destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo copiar Archivo no se puede copiar o ya existe en el destino");
            }
            origenToolStripMenuItem.Enabled = true;
        }
    }
}
