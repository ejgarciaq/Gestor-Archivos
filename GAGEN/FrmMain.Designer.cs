namespace GAGEN
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.toolStripCrearCarpeta = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCrearArchivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitMover = new System.Windows.Forms.ToolStripSplitButton();
            this.origenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.destinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(12, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(224, 410);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.moverToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 114);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpetaToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // carpetaToolStripMenuItem
            // 
            this.carpetaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.carpetaToolStripMenuItem.Name = "carpetaToolStripMenuItem";
            this.carpetaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.carpetaToolStripMenuItem.Text = "Carpeta";
            this.carpetaToolStripMenuItem.Click += new System.EventHandler(this.carpetaToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenToolStripMenuItem,
            this.destinoToolStripMenuItem});
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.moverToolStripMenuItem.Text = "Mover";
            // 
            // origenToolStripMenuItem
            // 
            this.origenToolStripMenuItem.Name = "origenToolStripMenuItem";
            this.origenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.origenToolStripMenuItem.Text = "Origen";
            this.origenToolStripMenuItem.Click += new System.EventHandler(this.origenToolStripMenuItem_Click);
            // 
            // destinoToolStripMenuItem
            // 
            this.destinoToolStripMenuItem.Name = "destinoToolStripMenuItem";
            this.destinoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.destinoToolStripMenuItem.Text = "Destino";
            this.destinoToolStripMenuItem.Click += new System.EventHandler(this.destinoToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click_1);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(242, 69);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(556, 410);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DirListViewr_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UltimaPosicion";
            this.columnHeader3.Width = 197;
            // 
            // TbAddress
            // 
            this.TbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TbAddress.Location = new System.Drawing.Point(71, 5);
            this.TbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(727, 21);
            this.TbAddress.TabIndex = 2;
            // 
            // toolStripCrearCarpeta
            // 
            this.toolStripCrearCarpeta.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCrearCarpeta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripCrearCarpeta.Image = global::GAGEN.Properties.Resources.CarpetaCrear;
            this.toolStripCrearCarpeta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCrearCarpeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCrearCarpeta.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripCrearCarpeta.MergeIndex = 0;
            this.toolStripCrearCarpeta.Name = "toolStripCrearCarpeta";
            this.toolStripCrearCarpeta.Size = new System.Drawing.Size(107, 29);
            this.toolStripCrearCarpeta.Text = "Crear Carpeta";
            this.toolStripCrearCarpeta.ToolTipText = "Crear Carpeta";
            this.toolStripCrearCarpeta.Click += new System.EventHandler(this.toolStripCrearCarpeta_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnInicio,
            this.toolStripSeparator2,
            this.toolStripCrearCarpeta,
            this.toolStripCrearArchivo,
            this.toolStripSplitMover,
            this.toolStripCopy,
            this.toolStripPegar,
            this.toolStripEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(811, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnInicio
            // 
            this.toolStripBtnInicio.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnInicio.Image = global::GAGEN.Properties.Resources.Home;
            this.toolStripBtnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripBtnInicio.MergeIndex = 0;
            this.toolStripBtnInicio.Name = "toolStripBtnInicio";
            this.toolStripBtnInicio.Size = new System.Drawing.Size(65, 29);
            this.toolStripBtnInicio.Text = "Inicio";
            this.toolStripBtnInicio.Click += new System.EventHandler(this.toolStripBtnInicio_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripCrearArchivo
            // 
            this.toolStripCrearArchivo.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCrearArchivo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripCrearArchivo.Image = global::GAGEN.Properties.Resources.CrearFile;
            this.toolStripCrearArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCrearArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCrearArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripCrearArchivo.MergeIndex = 0;
            this.toolStripCrearArchivo.Name = "toolStripCrearArchivo";
            this.toolStripCrearArchivo.Size = new System.Drawing.Size(107, 29);
            this.toolStripCrearArchivo.Text = "Crear Archivo";
            this.toolStripCrearArchivo.ToolTipText = "Crear Archivo";
            this.toolStripCrearArchivo.Click += new System.EventHandler(this.toolStripCrearArchivo_Click);
            // 
            // toolStripSplitMover
            // 
            this.toolStripSplitMover.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitMover.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.origenToolStripMenuItem1,
            this.destinoToolStripMenuItem1});
            this.toolStripSplitMover.Image = global::GAGEN.Properties.Resources.CarpetaMover;
            this.toolStripSplitMover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitMover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitMover.Name = "toolStripSplitMover";
            this.toolStripSplitMover.Size = new System.Drawing.Size(81, 30);
            this.toolStripSplitMover.Text = "Mover";
            // 
            // origenToolStripMenuItem1
            // 
            this.origenToolStripMenuItem1.Name = "origenToolStripMenuItem1";
            this.origenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.origenToolStripMenuItem1.Text = "Origen";
            this.origenToolStripMenuItem1.Click += new System.EventHandler(this.origenToolStripMenuItem1_Click);
            // 
            // destinoToolStripMenuItem1
            // 
            this.destinoToolStripMenuItem1.Name = "destinoToolStripMenuItem1";
            this.destinoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.destinoToolStripMenuItem1.Text = "Destino";
            this.destinoToolStripMenuItem1.Click += new System.EventHandler(this.destinoToolStripMenuItem1_Click);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCopy.Image = global::GAGEN.Properties.Resources.Copy;
            this.toolStripCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(70, 30);
            this.toolStripCopy.Text = "Copiar";
            this.toolStripCopy.Click += new System.EventHandler(this.toolStripCopy_Click);
            // 
            // toolStripPegar
            // 
            this.toolStripPegar.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPegar.Image = global::GAGEN.Properties.Resources.Pegar;
            this.toolStripPegar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPegar.Name = "toolStripPegar";
            this.toolStripPegar.Size = new System.Drawing.Size(65, 30);
            this.toolStripPegar.Text = "Pegar";
            this.toolStripPegar.Click += new System.EventHandler(this.toolStripPegar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.BackColor = System.Drawing.Color.Transparent;
            this.toolStripEliminar.Image = global::GAGEN.Properties.Resources.CarpetaEliminar;
            this.toolStripEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripEliminar.MergeIndex = 0;
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(78, 29);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 31);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dirección";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAGEN.Properties.Resources.tecnology;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Archivos GEN";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripCrearCarpeta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripEliminar;
        private System.Windows.Forms.ToolStripButton toolStripCrearArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnInicio;
        private System.Windows.Forms.ToolStripMenuItem carpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPegar;
        private System.Windows.Forms.ToolStripMenuItem origenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitMover;
        private System.Windows.Forms.ToolStripMenuItem origenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem destinoToolStripMenuItem1;
    }
}

