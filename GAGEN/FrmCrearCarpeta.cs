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

namespace GAGEN
{
    public partial class FrmCrearCarpeta : Form
    {
        // variables
        string Ruta;
        public string RutaDir;

        public FrmCrearCarpeta()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs a)
        {
            Ruta = RutaDir + @"\" + TbNombreCarpeta.Text;
                        
            try
            {
                if (TbNombreCarpeta.Text == "" )
                {
                    throw new Exception("Debe definir un nombre de carpeta");
                }

                if (Directory.Exists(Ruta))
                {
                    throw new Exception("Error - Carpeta ya existe");
                }

                //--Intenta crear el directorio con los permisos--//
                DirectoryInfo di = Directory.CreateDirectory(Ruta);
                var directory = new DirectoryInfo(Ruta);
                if (CmbPermisos.SelectedIndex == 0)
                {
                    directory.Attributes |= FileAttributes.Normal;
                }
                else if (CmbPermisos.SelectedIndex == 1)
                {
                    directory.Attributes |= FileAttributes.ReadOnly;
                }

                if (MessageBox.Show("El directorio Se ha creado correctamente" + Directory.GetCreationTime(Ruta),
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {   
            this.Hide();
        }
    }
}
