namespace Escola.Desktop.Screens
{
    partial class CadastrarAluno
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
            components = new System.ComponentModel.Container();
            primaryButton1 = new Escola.Desktop.Components.PrimaryButton(components);
            label1 = new Label();
            txtCodigo = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pickerData = new DateTimePicker();
            lblErro = new Label();
            SuspendLayout();
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.DarkBlue;
            primaryButton1.Font = new Font("Arial", 12F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(204, 280);
            primaryButton1.Margin = new Padding(2);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(158, 45);
            primaryButton1.TabIndex = 0;
            primaryButton1.Text = "Cadastrar";
            primaryButton1.UseVisualStyleBackColor = false;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(108, 65);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 213);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 108);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 7;
            label4.Text = "Data de Nascimento";
            // 
            // pickerData
            // 
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(108, 162);
            pickerData.Margin = new Padding(2);
            pickerData.Name = "pickerData";
            pickerData.Size = new Size(250, 23);
            pickerData.TabIndex = 8;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(391, 296);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(41, 15);
            lblErro.TabIndex = 9;
            lblErro.Text = "lblErro";
            lblErro.Visible = false;
            lblErro.Click += lblErro_Click;
            // 
            // CadastrarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 407);
            Controls.Add(lblErro);
            Controls.Add(pickerData);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(primaryButton1);
            Margin = new Padding(2);
            Name = "CadastrarAluno";
            Text = "CadastrarAluno";
            Load += CadastrarAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.PrimaryButton primaryButton1;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private DateTimePicker pickerData;
        private Label lblErro;
    }
}