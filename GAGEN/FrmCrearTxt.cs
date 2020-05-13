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

namespace GAGEN
{
    public partial class FrmCrearTxt : Form
    {
        // variables
        string Ruta;
        public string RutaDir;

        FolderBrowserDialog folder = new FolderBrowserDialog();
        public FrmCrearTxt()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Ruta = RutaDir + @"\" + TbNombreFichero.Text;

            var Guardar = RutaDir;
            var Nombre = TbNombreFichero.Text;

            if (Guardar != "" && Nombre != "")
            {
                GuardarTxt(Guardar, Nombre);
            }
            else
            {
                MessageBox.Show("Debes de ingresar un Nombre al archivo.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        //CREAR ARCHIVO DE TEXTO
        private void GuardarTxt(string Guardar, string Nombre)
        {
            string Direccion = Guardar + @"\" + Nombre + ".txt";

            if (File.Exists(Direccion))
            {
                DialogResult Pregunta = new DialogResult();
                Pregunta = MessageBox.Show("El archivo " + Nombre + " ya existe, ¿Desea remplazarlo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pregunta == DialogResult.No)
                {
                    Nombre = Nombre + "-1";
                    Direccion = Guardar + @"\" + Nombre + ".txt";
                }

                using (StreamWriter sw = File.CreateText(Direccion))
                {
                    sw.WriteLine(RtbTextContenido.Text);
                }

                //DEFINICION DE PERMISOS
                var Atributo = File.GetAttributes(Direccion);
                if (CmbPermisos.SelectedIndex == 1)
                {
                    //ARCHIVO READONLY
                    Atributo = Atributo | FileAttributes.ReadOnly;
                }

                File.SetAttributes(Direccion, Atributo);

                if (MessageBox.Show("El archivo se ha creado correctamente con el nombre de: " + Nombre, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(Direccion))
                {
                    sw.WriteLine(RtbTextContenido.Text);
                }

                //DEFINICION DE PERMISOS
                var Atributo = File.GetAttributes(Direccion);
                if (CmbPermisos.SelectedIndex == 0)
                {
                    //PERMISO NORMAL
                    Atributo = Atributo | ~FileAttributes.ReadOnly;
                }
                else
                {
                    //PERMISO SOLO LECTURA
                    Atributo = Atributo | FileAttributes.ReadOnly;
                }
                File.SetAttributes(Direccion, Atributo);

                if (MessageBox.Show("El archivo se ha creado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        //DEFINIR DIRECCION
        public string DefinirDireccion()
        {
            string result = string.Empty;

            try
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    var Dir = folder.SelectedPath;

                    if (Dir == "")
                    {
                        DefinirDireccion();
                    }

                    result = Dir;
                }
                else
                {
                    MessageBox.Show("No se definio una direccion válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string DirDefault = @"C: \Users\ejgar\source\repos\Gestor Archivos GEN\GAGEN\bin\Debug\Sistemas Operativos II";
                    CrearDirectorio(DirDefault);
                    result = DirDefault;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        //CREAR RUTA INICIAL
        private void CrearDirectorio(string dir)
        {
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
