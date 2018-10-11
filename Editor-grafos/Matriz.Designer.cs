namespace Editor_grafos
{
    partial class Matriz
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
            this.dataGridViewMatriz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatriz
            // 
            this.dataGridViewMatriz.AllowUserToAddRows = false;
            this.dataGridViewMatriz.AllowUserToDeleteRows = false;
            this.dataGridViewMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatriz.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatriz.MultiSelect = false;
            this.dataGridViewMatriz.Name = "dataGridViewMatriz";
            this.dataGridViewMatriz.ReadOnly = true;
            this.dataGridViewMatriz.RowHeadersVisible = false;
            this.dataGridViewMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMatriz.Size = new System.Drawing.Size(788, 438);
            this.dataGridViewMatriz.TabIndex = 0;
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMatriz);
            this.Name = "Matriz";
            this.Text = "Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatriz;
    }
}