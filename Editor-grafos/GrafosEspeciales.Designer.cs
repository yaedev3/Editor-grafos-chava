namespace Editor_grafos
{
    partial class GrafosEspeciales
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTamano = new System.Windows.Forms.NumericUpDown();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamano)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño:";
            // 
            // numericUpDownTamano
            // 
            this.numericUpDownTamano.Location = new System.Drawing.Point(53, 39);
            this.numericUpDownTamano.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTamano.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownTamano.Name = "numericUpDownTamano";
            this.numericUpDownTamano.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownTamano.TabIndex = 1;
            this.numericUpDownTamano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTamano.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(53, 65);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // GrafosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 100);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.numericUpDownTamano);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrafosEspeciales";
            this.Text = "GrafosEspeciales";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTamano;
        private System.Windows.Forms.Button buttonAceptar;
    }
}