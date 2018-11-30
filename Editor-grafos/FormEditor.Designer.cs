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
            this.toolStripButtonQuitarArista = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAristaD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAristaND = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMatriz = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListaAdyacencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMatrizIncidencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGradosDirigidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGradosNoDirigidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCorolarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEuler = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIso = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKura = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNumeroCromatico = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFloyd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKuratowskiInterativo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKruskal = new System.Windows.Forms.ToolStripButton();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.toolStripButtonEliminarNodo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelGrafoActual = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonCambiarGrafo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNodo,
            this.toolStripButtonQuitarArista,
            this.toolStripButtonEliminarNodo,
            this.toolStripButtonAristaD,
            this.toolStripButtonAristaND,
            this.toolStripButtonNuevo,
            this.toolStripButtonMatriz,
            this.toolStripButtonListaAdyacencia,
            this.toolStripButtonMatrizIncidencia,
            this.toolStripButtonGradosDirigidos,
            this.toolStripButtonGradosNoDirigidos,
            this.toolStripButtonCn,
            this.toolStripButtonKn,
            this.toolStripButtonWn,
            this.toolStripButtonCorolarios,
            this.toolStripButtonEuler,
            this.toolStripButtonIso,
            this.toolStripButtonKura,
            this.toolStripButtonNumeroCromatico,
            this.toolStripButtonFloyd,
            this.toolStripButtonKuratowskiInterativo,
            this.toolStripButtonKruskal});
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
            // toolStripButtonQuitarArista
            // 
            this.toolStripButtonQuitarArista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuitarArista.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuitarArista.Image")));
            this.toolStripButtonQuitarArista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitarArista.Name = "toolStripButtonQuitarArista";
            this.toolStripButtonQuitarArista.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonQuitarArista.Text = "Quitar Arista";
            this.toolStripButtonQuitarArista.Click += new System.EventHandler(this.toolStripButtonQuitarArista_Click);
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
            // toolStripButtonEuler
            // 
            this.toolStripButtonEuler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEuler.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEuler.Image")));
            this.toolStripButtonEuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEuler.Name = "toolStripButtonEuler";
            this.toolStripButtonEuler.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonEuler.Text = "Euler";
            this.toolStripButtonEuler.Click += new System.EventHandler(this.toolStripButtonEuler_Click);
            // 
            // toolStripButtonIso
            // 
            this.toolStripButtonIso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIso.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIso.Image")));
            this.toolStripButtonIso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIso.Name = "toolStripButtonIso";
            this.toolStripButtonIso.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonIso.Text = "Isomorfismo";
            this.toolStripButtonIso.Click += new System.EventHandler(this.toolStripButtonIso_Click);
            // 
            // toolStripButtonKura
            // 
            this.toolStripButtonKura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonKura.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKura.Image")));
            this.toolStripButtonKura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKura.Name = "toolStripButtonKura";
            this.toolStripButtonKura.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonKura.Text = "Kuratowsky";
            this.toolStripButtonKura.Click += new System.EventHandler(this.toolStripButtonKura_Click);
            // 
            // toolStripButtonNumeroCromatico
            // 
            this.toolStripButtonNumeroCromatico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNumeroCromatico.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNumeroCromatico.Image")));
            this.toolStripButtonNumeroCromatico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNumeroCromatico.Name = "toolStripButtonNumeroCromatico";
            this.toolStripButtonNumeroCromatico.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonNumeroCromatico.Text = "Numero cromatico";
            this.toolStripButtonNumeroCromatico.Click += new System.EventHandler(this.toolStripButtonNumeroCromatico_Click);
            // 
            // toolStripButtonFloyd
            // 
            this.toolStripButtonFloyd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFloyd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFloyd.Image")));
            this.toolStripButtonFloyd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFloyd.Name = "toolStripButtonFloyd";
            this.toolStripButtonFloyd.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonFloyd.Text = "Floyd";
            this.toolStripButtonFloyd.Click += new System.EventHandler(this.toolStripButtonFloyd_Click);
            // 
            // toolStripButtonKuratowskiInterativo
            // 
            this.toolStripButtonKuratowskiInterativo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonKuratowskiInterativo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKuratowskiInterativo.Image")));
            this.toolStripButtonKuratowskiInterativo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKuratowskiInterativo.Name = "toolStripButtonKuratowskiInterativo";
            this.toolStripButtonKuratowskiInterativo.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonKuratowskiInterativo.Text = "Kuratowski interactivo";
            this.toolStripButtonKuratowskiInterativo.Click += new System.EventHandler(this.toolStripButtonKuratowskiInterativo_Click);
            // 
            // toolStripButtonKruskal
            // 
            this.toolStripButtonKruskal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonKruskal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKruskal.Image")));
            this.toolStripButtonKruskal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKruskal.Name = "toolStripButtonKruskal";
            this.toolStripButtonKruskal.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonKruskal.Text = "Kruskal";
            this.toolStripButtonKruskal.Click += new System.EventHandler(this.toolStripButtonKruskal_Click);
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Location = new System.Drawing.Point(622, 80);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownPeso.TabIndex = 5;
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // toolStripButtonEliminarNodo
            // 
            this.toolStripButtonEliminarNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminarNodo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminarNodo.Image")));
            this.toolStripButtonEliminarNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarNodo.Name = "toolStripButtonEliminarNodo";
            this.toolStripButtonEliminarNodo.Size = new System.Drawing.Size(29, 29);
            this.toolStripButtonEliminarNodo.Text = "Eliminar nodo";
            this.toolStripButtonEliminarNodo.Click += new System.EventHandler(this.toolStripButtonEliminarNodo_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabelGrafoActual,
            this.toolStripSeparator1,
            this.toolStripButtonCambiarGrafo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 32);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(685, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "Grafo actual";
            // 
            // toolStripLabelGrafoActual
            // 
            this.toolStripLabelGrafoActual.Name = "toolStripLabelGrafoActual";
            this.toolStripLabelGrafoActual.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabelGrafoActual.Text = "Uno";
            // 
            // toolStripButtonCambiarGrafo
            // 
            this.toolStripButtonCambiarGrafo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCambiarGrafo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCambiarGrafo.Image")));
            this.toolStripButtonCambiarGrafo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCambiarGrafo.Name = "toolStripButtonCambiarGrafo";
            this.toolStripButtonCambiarGrafo.Size = new System.Drawing.Size(103, 22);
            this.toolStripButtonCambiarGrafo.Text = "Cambiar de grafo";
            this.toolStripButtonCambiarGrafo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.numericUpDownPeso);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEditor";
            this.Text = "Editor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormEditor_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEditor_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonCn;
        private System.Windows.Forms.ToolStripButton toolStripButtonKn;
        private System.Windows.Forms.ToolStripButton toolStripButtonWn;
        private System.Windows.Forms.ToolStripButton toolStripButtonCorolarios;
        private System.Windows.Forms.ToolStripButton toolStripButtonEuler;
        private System.Windows.Forms.ToolStripButton toolStripButtonKura;
        private System.Windows.Forms.ToolStripButton toolStripButtonIso;
        private System.Windows.Forms.ToolStripButton toolStripButtonNumeroCromatico;
        private System.Windows.Forms.ToolStripButton toolStripButtonFloyd;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.ToolStripButton toolStripButtonKuratowskiInterativo;
        private System.Windows.Forms.ToolStripButton toolStripButtonKruskal;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitarArista;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarNodo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelGrafoActual;
        private System.Windows.Forms.ToolStripButton toolStripButtonCambiarGrafo;
    }
}

