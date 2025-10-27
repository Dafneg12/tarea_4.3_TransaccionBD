namespace tarea_4._3_TransaccionBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnBuscar = new Button();
            btnDescontinuar = new Button();
            txtCodigoProduct = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(37, 109);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(991, 411);
            dgvProducts.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(167, 245, 149);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 11F);
            btnBuscar.Location = new Point(457, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 41);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.BackColor = Color.FromArgb(167, 245, 149);
            btnDescontinuar.FlatStyle = FlatStyle.Flat;
            btnDescontinuar.Font = new Font("Calibri", 11F);
            btnDescontinuar.Location = new Point(901, 51);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(127, 37);
            btnDescontinuar.TabIndex = 2;
            btnDescontinuar.Text = "Descontinuar";
            btnDescontinuar.UseVisualStyleBackColor = false;
            btnDescontinuar.Click += btnDescontinuar_Click;
            // 
            // txtCodigoProduct
            // 
            txtCodigoProduct.Location = new Point(37, 45);
            txtCodigoProduct.Multiline = true;
            txtCodigoProduct.Name = "txtCodigoProduct";
            txtCodigoProduct.PlaceholderText = "Código";
            txtCodigoProduct.Size = new Size(405, 41);
            txtCodigoProduct.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 245, 210);
            ClientSize = new Size(1064, 557);
            Controls.Add(txtCodigoProduct);
            Controls.Add(btnDescontinuar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnBuscar;
        private Button btnDescontinuar;
        private TextBox txtCodigoProduct;
    }
}
