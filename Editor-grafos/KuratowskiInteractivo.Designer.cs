﻿namespace Editor_grafos
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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonComprobar,
            this.toolStripButtonAgregarNodo,
            this.toolStripButtonQuitarNodo});
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
            this.toolStripButtonQuitarNodo.Text = "Quitar nodo";
            this.toolStripButtonQuitarNodo.Click += new System.EventHandler(this.toolStripButtonQuitarNodo_Click);
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
    }
}