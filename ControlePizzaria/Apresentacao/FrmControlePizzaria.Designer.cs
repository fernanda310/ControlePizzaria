namespace ControlePizzaria
{
    partial class FrmControlePizzaria
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
            lblNome = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            dtgEstoque = new DataGridView();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(193, 84);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(328, 84);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(460, 101);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(328, 102);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(59, 85);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(59, 103);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // dtgEstoque
            // 
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(59, 159);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.Size = new Size(570, 219);
            dtgEstoque.TabIndex = 7;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(554, 101);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmControlePizzaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(dtgEstoque);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtPreco);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Name = "FrmControlePizzaria";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblPreco;
        private Button btnSalvar;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Label lblId;
        private TextBox txtId;
        private DataGridView dtgEstoque;
        private Button btnExcluir;
    }
}
