namespace Editor_grafos
{
    partial class KuratowskiInteractivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuratowskiInteractivo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonComprobar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregarNodo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitarNodo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxGrafos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonAgregarAristas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonComprobar,
            this.toolStripButtonAgregarNodo,
            this.toolStripButtonAgregarAristas,
            this.toolStripButtonQuitarNodo,
            this.toolStripButtonQuitar,
            this.toolStripLabel1,
            this.toolStripComboBoxGrafos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonComprobar
            // 
            this.toolStripButtonComprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonComprobar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonComprobar.Image")));
            this.toolStripButtonComprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonComprobar.Name = "toolStripButtonComprobar";
            this.toolStripButtonComprobar.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonComprobar.Text = "Comprobar";
            this.toolStripButtonComprobar.Click += new System.EventHandler(this.toolStripButtonComprobar_Click);
            // 
            // toolStripButtonAgregarNodo
            // 
            this.toolStripButtonAgregarNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregarNodo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregarNodo.Image")));
            this.toolStripButtonAgregarNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarNodo.Name = "toolStripButtonAgregarNodo";
            this.toolStripButtonAgregarNodo.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonAgregarNodo.Text = "Agregar nodo";
            this.toolStripButtonAgregarNodo.Click += new System.EventHandler(this.toolStripButtonAgregarNodo_Click);
            // 
            // toolStripButtonQuitarNodo
            // 
            this.toolStripButtonQuitarNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonQuitarNodo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuitarNodo.Image")));
            this.toolStripButtonQuitarNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitarNodo.Name = "toolStripButtonQuitarNodo";
            this.toolStripButtonQuitarNodo.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonQuitarNodo.Text = "Quitar arista";
            this.toolStripButtonQuitarNodo.Click += new System.EventHandler(this.toolStripButtonQuitarNodo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel1.Text = "Selecciona grafo";
            // 
            // toolStripComboBoxGrafos
            // 
            this.toolStripComboBoxGrafos.Name = "toolStripComboBoxGrafos";
            this.toolStripComboBoxGrafos.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonAgregarAristas
            // 
            this.toolStripButtonAgregarAristas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregarAristas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregarAristas.Image")));
            this.toolStripButtonAgregarAristas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarAristas.Name = "toolStripButtonAgregarAristas";
            this.toolStripButtonAgregarAristas.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonAgregarAristas.Text = "Agregar aristas";
            this.toolStripButtonAgregarAristas.Click += new System.EventHandler(this.toolStripButtonAgregarAristas_Click);
            // 
            // toolStripButtonQuitar
            // 
            this.toolStripButtonQuitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonQuitar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuitar.Image")));
            this.toolStripButtonQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitar.Name = "toolStripButtonQuitar";
            this.toolStripButtonQuitar.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonQuitar.Text = "Quitar nodo";
            this.toolStripButtonQuitar.Click += new System.EventHandler(this.toolStripButtonQuitar_Click);
            // 
            // KuratowskiInteractivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "KuratowskiInteractivo";
            this.Text = "KuratowskiInteractivo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KuratowskiInteractivo_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KuratowskiInteractivo_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonComprobar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregarNodo;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitarNodo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxGrafos;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregarAristas;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitar;
    }
}