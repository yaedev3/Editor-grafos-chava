namespace Editor_grafos
{
    partial class FormEditor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNodo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAristaD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAristaND = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMatriz = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListaAdyacencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMatrizIncidencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGradosDirigidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGradosNoDirigidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCorolarios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNodo,
            this.toolStripButtonAristaD,
            this.toolStripButtonAristaND,
            this.toolStripButtonNuevo,
            this.toolStripButtonMatriz,
            this.toolStripButtonListaAdyacencia,
            this.toolStripButtonMatrizIncidencia,
            this.toolStripButtonGradosDirigidos,
            this.toolStripButtonGradosNoDirigidos,
            this.toolStripButton1,
            this.toolStripButtonCn,
            this.toolStripButtonKn,
            this.toolStripButtonWn,
            this.toolStripButtonCorolarios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNodo
            // 
            this.toolStripButtonNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNodo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNodo.Image")));
            this.toolStripButtonNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNodo.Name = "toolStripButtonNodo";
            this.toolStripButtonNodo.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonNodo.Text = "Agregar Nodo";
            this.toolStripButtonNodo.Click += new System.EventHandler(this.toolStripButtonNodo_Click);
            // 
            // toolStripButtonAristaD
            // 
            this.toolStripButtonAristaD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAristaD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAristaD.Image")));
            this.toolStripButtonAristaD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAristaD.Name = "toolStripButtonAristaD";
            this.toolStripButtonAristaD.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonAristaD.Text = "Arista dirigida";
            this.toolStripButtonAristaD.Click += new System.EventHandler(this.toolStripButtonAristaD_Click);
            // 
            // toolStripButtonAristaND
            // 
            this.toolStripButtonAristaND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAristaND.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAristaND.Image")));
            this.toolStripButtonAristaND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAristaND.Name = "toolStripButtonAristaND";
            this.toolStripButtonAristaND.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonAristaND.Text = "Arista no dirigida";
            this.toolStripButtonAristaND.Click += new System.EventHandler(this.toolStripButtonAristaND_Click);
            // 
            // toolStripButtonNuevo
            // 
            this.toolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevo.Image")));
            this.toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            this.toolStripButtonNuevo.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonNuevo.Text = "Nuevo";
            this.toolStripButtonNuevo.Click += new System.EventHandler(this.toolStripButtonNuevo_Click);
            // 
            // toolStripButtonMatriz
            // 
            this.toolStripButtonMatriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMatriz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMatriz.Image")));
            this.toolStripButtonMatriz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMatriz.Name = "toolStripButtonMatriz";
            this.toolStripButtonMatriz.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonMatriz.Text = "Matriz de Adyacencia";
            this.toolStripButtonMatriz.Click += new System.EventHandler(this.toolStripButtonMatriz_Click);
            // 
            // toolStripButtonListaAdyacencia
            // 
            this.toolStripButtonListaAdyacencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonListaAdyacencia.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonListaAdyacencia.Image")));
            this.toolStripButtonListaAdyacencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListaAdyacencia.Name = "toolStripButtonListaAdyacencia";
            this.toolStripButtonListaAdyacencia.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonListaAdyacencia.Text = "Lista de adyacencia";
            this.toolStripButtonListaAdyacencia.Click += new System.EventHandler(this.toolStripButtonListaAdyacencia_Click);
            // 
            // toolStripButtonMatrizIncidencia
            // 
            this.toolStripButtonMatrizIncidencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMatrizIncidencia.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMatrizIncidencia.Image")));
            this.toolStripButtonMatrizIncidencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMatrizIncidencia.Name = "toolStripButtonMatrizIncidencia";
            this.toolStripButtonMatrizIncidencia.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonMatrizIncidencia.Text = "Matriz de incidencia";
            this.toolStripButtonMatrizIncidencia.Click += new System.EventHandler(this.toolStripButtonMatrizIncidencia_Click);
            // 
            // toolStripButtonGradosDirigidos
            // 
            this.toolStripButtonGradosDirigidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGradosDirigidos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGradosDirigidos.Image")));
            this.toolStripButtonGradosDirigidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGradosDirigidos.Name = "toolStripButtonGradosDirigidos";
            this.toolStripButtonGradosDirigidos.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonGradosDirigidos.Text = "Grados dirigidos";
            this.toolStripButtonGradosDirigidos.Click += new System.EventHandler(this.toolStripButtonGradosDirigidos_Click);
            // 
            // toolStripButtonGradosNoDirigidos
            // 
            this.toolStripButtonGradosNoDirigidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGradosNoDirigidos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGradosNoDirigidos.Image")));
            this.toolStripButtonGradosNoDirigidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGradosNoDirigidos.Name = "toolStripButtonGradosNoDirigidos";
            this.toolStripButtonGradosNoDirigidos.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonGradosNoDirigidos.Text = "Grados no dirigidos";
            this.toolStripButtonGradosNoDirigidos.Click += new System.EventHandler(this.toolStripButtonGradosNoDirigidos_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonCn
            // 
            this.toolStripButtonCn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCn.Image")));
            this.toolStripButtonCn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCn.Name = "toolStripButtonCn";
            this.toolStripButtonCn.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonCn.Text = "Cn";
            this.toolStripButtonCn.Click += new System.EventHandler(this.toolStripButtonCn_Click);
            // 
            // toolStripButtonKn
            // 
            this.toolStripButtonKn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonKn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKn.Image")));
            this.toolStripButtonKn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKn.Name = "toolStripButtonKn";
            this.toolStripButtonKn.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonKn.Text = "Kn";
            this.toolStripButtonKn.Click += new System.EventHandler(this.toolStripButtonKn_Click);
            // 
            // toolStripButtonWn
            // 
            this.toolStripButtonWn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWn.Image")));
            this.toolStripButtonWn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWn.Name = "toolStripButtonWn";
            this.toolStripButtonWn.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonWn.Text = "Wn";
            this.toolStripButtonWn.Click += new System.EventHandler(this.toolStripButtonWn_Click);
            // 
            // toolStripButtonCorolarios
            // 
            this.toolStripButtonCorolarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCorolarios.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCorolarios.Image")));
            this.toolStripButtonCorolarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCorolarios.Name = "toolStripButtonCorolarios";
            this.toolStripButtonCorolarios.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonCorolarios.Text = "Corolarios";
            this.toolStripButtonCorolarios.Click += new System.EventHandler(this.toolStripButtonCorolarios_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEditor";
            this.Text = "Editor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormEditor_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEditor_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNodo;
        private System.Windows.Forms.ToolStripButton toolStripButtonAristaD;
        private System.Windows.Forms.ToolStripButton toolStripButtonAristaND;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButtonMatriz;
        private System.Windows.Forms.ToolStripButton toolStripButtonListaAdyacencia;
        private System.Windows.Forms.ToolStripButton toolStripButtonGradosDirigidos;
        private System.Windows.Forms.ToolStripButton toolStripButtonGradosNoDirigidos;
        private System.Windows.Forms.ToolStripButton toolStripButtonMatrizIncidencia;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCn;
        private System.Windows.Forms.ToolStripButton toolStripButtonKn;
        private System.Windows.Forms.ToolStripButton toolStripButtonWn;
        private System.Windows.Forms.ToolStripButton toolStripButtonCorolarios;
    }
}

