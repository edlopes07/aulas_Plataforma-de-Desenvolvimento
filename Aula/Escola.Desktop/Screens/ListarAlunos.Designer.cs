namespace Escola.Desktop.Screens
{
    partial class ListarAlunos
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            button1 = new Button();
            lblErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(284, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 51);
            label1.TabIndex = 0;
            label1.Text = "Alunos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Idade, DataNascimento, Email });
            dataGridView1.Location = new Point(31, 108);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(676, 244);
            dataGridView1.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Idade
            // 
            Idade.HeaderText = "Idade";
            Idade.Name = "Idade";
            Idade.ReadOnly = true;
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataNascimento.HeaderText = "Data de Nascimento";
            DataNascimento.MinimumWidth = 8;
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(31, 66);
            button1.Name = "button1";
            button1.Size = new Size(73, 37);
            button1.TabIndex = 2;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(110, 77);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(41, 15);
            lblErro.TabIndex = 3;
            lblErro.Text = "lblErro";
            lblErro.Visible = false;
            lblErro.Click += label2_Click;
            // 
            // ListarAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 404);
            Controls.Add(lblErro);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ListarAlunos";
            Text = "ListarAlunos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Email;
        private Button button1;
        private Label lblErro;
    }
}